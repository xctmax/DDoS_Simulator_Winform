using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

public class check_proxy
{
    private string proxyListPath; // Đường dẫn tới tệp danh sách proxy
    private ListBox listBoxStatus; // ListBox để hiển thị trạng thái proxy
    private static readonly HttpClient httpClient; // HttpClient dùng chung

    static check_proxy()
    {
        // Khởi tạo HttpClient một lần duy nhất
        httpClient = new HttpClient();
    }

    public check_proxy(string proxyListPath, ListBox listBoxStatus)
    {
        this.proxyListPath = proxyListPath;
        this.listBoxStatus = listBoxStatus;
    }

    public async Task CheckProxiesAsync()
    {
        listBoxStatus.Items.Clear(); // Xóa danh sách trạng thái hiện tại
        List<string> proxies = new List<string>();
        int workingCount = 0; // Số proxy dùng được
        int notWorkingCount = 0; // Số proxy không dùng được

        // Kiểm tra tệp danh sách proxy
        if (File.Exists(proxyListPath))
        {
            proxies.AddRange(File.ReadAllLines(proxyListPath));
        }
        else
        {
            MessageBox.Show("Tệp danh sách proxy không tồn tại!");
            return;
        }

        List<Task<string>> tasks = new List<Task<string>>();

        // Tạo task cho mỗi proxy
        foreach (var proxy in proxies)
        {
            tasks.Add(CheckProxyAsync(proxy));
        }

        // Chờ tất cả các task hoàn thành
        var results = await Task.WhenAll(tasks);

        // Đếm số lượng proxy hoạt động và không hoạt động
        foreach (var result in results)
        {
            if (result == "Hoạt động")
            {
                workingCount++;
            }
            else
            {
                notWorkingCount++;
            }
        }

        // Hiển thị kết quả tổng kết
        listBoxStatus.Items.Add($"{workingCount} số proxy dùng được; {notWorkingCount} proxy không dùng được.");
    }

    private async Task<string> CheckProxyAsync(string proxy)
    {
        string[] parts = proxy.Split(':');
        if (parts.Length != 2) return "Không hợp lệ"; // Đảm bảo định dạng proxy hợp lệ

        string ip = parts[0];
        string port = parts[1];

        try
        {
            var webProxy = new WebProxy(ip, int.Parse(port))
            {
                BypassProxyOnLocal = false,
                UseDefaultCredentials = false
            };

            // Tạo một HttpClientHandler với proxy
            var handler = new HttpClientHandler()
            {
                Proxy = webProxy,
                UseProxy = true,
            };

            using (var client = new HttpClient(handler)) // Sử dụng HttpClient với handler đã thiết lập proxy
            {
                client.Timeout = TimeSpan.FromSeconds(2); // Thời gian chờ 2 giây

                var response = await client.GetAsync("http://httpbin.org/ip"); // URL để kiểm tra
                if (response.IsSuccessStatusCode)
                {
                    return "Hoạt động"; // Proxy hoạt động
                }
            }
        }
        catch
        {
            // Nếu có lỗi, coi như proxy không hoạt động
        }

        return "Không hoạt động"; // Proxy không hoạt động
    }
}
