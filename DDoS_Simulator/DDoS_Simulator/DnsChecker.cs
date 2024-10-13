using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

public class DnsChecker
{
    public static async Task CheckDnsServersAsync(List<string> dnsServers, string targetUrl, Action<string> updateStatus)
    {
        int validCount = 0;
        List<Task> tasks = new List<Task>();

        foreach (var dnsServer in dnsServers)
        {
            tasks.Add(Task.Run(() =>
            {
                try
                {
                    // Tạo một yêu cầu đến DNS server
                    var request = WebRequest.Create($"https://{targetUrl}");
                    request.Timeout = 5000; // Thời gian chờ 5 giây
                    var response = request.GetResponse();
                    validCount++;
                    updateStatus($"DNS Server {dnsServer} hoạt động.");
                }
                catch
                {
                    updateStatus($"DNS Server {dnsServer} không khả dụng.");
                }
            }));
        }

        await Task.WhenAll(tasks);
        updateStatus($"Tổng số DNS khả dụng: {validCount}/{dnsServers.Count}");
    }
}
