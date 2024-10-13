using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

public class DnsAmplificationAttack
{
    private List<string> dnsServers;
    private string targetUrl;
    private int dnsPort;
    private float attackDuration;
    private CancellationTokenSource cancellationTokenSource;

    public DnsAmplificationAttack(List<string> dnsServers, string targetUrl, int dnsPort, float attackDuration)
    {
        this.dnsServers = dnsServers;
        this.targetUrl = targetUrl;
        this.dnsPort = dnsPort;
        this.attackDuration = attackDuration;
    }

    public void StartAttack(Action<string> updateStatus)
    {
        cancellationTokenSource = new CancellationTokenSource();
        CancellationToken token = cancellationTokenSource.Token;

        Task.Run(() =>
        {
            try
            {
                DateTime endTime = DateTime.Now.AddSeconds(attackDuration);
                while (DateTime.Now < endTime)
                {
                    foreach (var dns in dnsServers)
                    {
                        if (token.IsCancellationRequested)
                        {
                            updateStatus("Attack stopped.");
                            return;
                        }

                        // Thực hiện tấn công DNS ở đây
                        // Giả sử bạn gửi gói yêu cầu tới DNS server

                        updateStatus($"Sending request to {dns}");
                    }
                }
                updateStatus("Attack completed.");
            }
            catch (Exception ex)
            {
                updateStatus($"Error: {ex.Message}");
            }
        }, token);
    }

    public void StopAttack()
    {
        cancellationTokenSource?.Cancel();
    }
}
