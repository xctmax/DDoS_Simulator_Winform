using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

public class down_proxy
{
    private ListBox listBoxStatus; // ListBox để hiển thị trạng thái
    private static readonly HttpClient httpClient = new HttpClient(); // HttpClient dùng chung

    public down_proxy(ListBox listBoxStatus)
    {
        this.listBoxStatus = listBoxStatus;
    }

    public async Task DownloadProxiesAsync() // Đổi tên phương thức về DownloadProxiesAsync
    {
        listBoxStatus.Items.Clear(); // Xóa danh sách trạng thái hiện tại
        List<string> sources = new List<string>
        {
            "https://api.proxyscrape.com/v2/?request=getproxies&protocol=http&timeout=10000&country=all&simplified=true",
            "https://www.proxy-list.download/api/v1/get?type=https",
            "https://www.proxyscan.io/download?type=https",
        };

        // Xóa tệp cũ nếu tồn tại
        string filePath = "D:\\AppC#\\DDoS_Simulator\\proxy.txt";
        if (File.Exists(filePath))
        {
            File.Delete(filePath); // Xóa tệp cũ
        }

        // Tạo tệp mới
        using (File.Create(filePath)) { } // Tạo tệp mới để ghi vào

        List<Task> tasks = new List<Task>();
        foreach (var source in sources)
        {
            tasks.Add(DownloadAndSaveProxies(source, filePath));
        }

        await Task.WhenAll(tasks); // Chờ tất cả các tác vụ hoàn thành
    }

    private async Task DownloadAndSaveProxies(string url, string filePath)
    {
        try
        {
            var response = await httpClient.GetStringAsync(url);
            var proxies = response.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Ghi vào tệp mới
            using (var writer = new StreamWriter(filePath, true))
            {
                foreach (var proxy in proxies)
                {
                    await writer.WriteLineAsync(proxy); // Lưu từng dòng vào tệp
                }
            }

            listBoxStatus.Items.Add($"Đã tải {proxies.Length} proxy từ {url}");
        }
        catch (Exception ex)
        {
            listBoxStatus.Items.Add($"Lỗi khi tải proxy từ {url}: {ex.Message}");
        }
    }
}