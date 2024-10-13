using System;
using System.Collections.Generic;
using System.IO;

public class DnsQuery
{
    private string dnsListPath;

    public DnsQuery(string dnsListPath)
    {
        this.dnsListPath = dnsListPath;
    }

    public List<string> LoadDnsServers()
    {
        if (!File.Exists(dnsListPath))
        {
            throw new FileNotFoundException("DNS list file not found.", dnsListPath);
        }

        return new List<string>(File.ReadAllLines(dnsListPath));
    }
}
