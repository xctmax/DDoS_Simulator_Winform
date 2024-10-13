using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DDoS_Simulator
{
    public partial class DNS_Amplification : Form
    {
        private DnsAmplificationAttack attack; // Khai báo ở cấp độ lớp

        public DNS_Amplification()
        {
            InitializeComponent();
        }

        private void DNS_Amplification_Load(object sender, EventArgs e)
        {

        }

        private void btn_openListDNS_Click(object sender, EventArgs e)
        {
            DnsAmplification_openDNS dnsOpener = new DnsAmplification_openDNS(); // Khởi tạo lớp open_proxy
            string filePath = dnsOpener.OpenFile(); // Gọi hàm mở tệp

            if (!string.IsNullOrEmpty(filePath))
            {
                label_pathToListDNS.Text = filePath; // Cập nhật label với đường dẫn tệp đã chọn

                int dnsCount = dnsOpener.CountDNS(filePath); // Đếm số lượng proxy trong tệp
                listBox_dnsStatus.Items.Add($"Số lượng DNS: {dnsCount}"); // Hiển thị số lượng DNS trong ListBox
            }
            else
            {
                MessageBox.Show("Không có tệp nào được chọn."); // Thông báo nếu không có tệp
            }
        }

        private void btn_dnsStart_Click(object sender, EventArgs e)
        {
            string targetUrl = txt_dnsURL.Text;
            string dnsListPath = label_pathToListDNS.Text;

            // Kiểm tra đường dẫn tệp
            if (!File.Exists(dnsListPath))
            {
                MessageBox.Show("Đường dẫn tệp không hợp lệ: " + dnsListPath);
                return;
            }

            DnsQuery dnsQuery = new DnsQuery(dnsListPath);
            List<string> dnsServers = dnsQuery.LoadDnsServers();

            // Tạo instance của DnsAmplificationAttack
            attack = new DnsAmplificationAttack(dnsServers, targetUrl, 53, 10.0f);

            // Gọi StartAttack và truyền updateStatus
            attack.StartAttack((status) =>
            {
                // Cập nhật ListBox từ luồng khác
                if (listBox_dnsStatus.InvokeRequired)
                {
                    listBox_dnsStatus.Invoke(new Action(() => listBox_dnsStatus.Items.Add(status)));
                }
                else
                {
                    listBox_dnsStatus.Items.Add(status);
                }
            });
        }

        private void btn_dnsStop_Click(object sender, EventArgs e)
        {
            if (attack != null)
            {
                attack.StopAttack(); // Dừng cuộc tấn công
            }
        }

        private async void btn_checkDns_Click(object sender, EventArgs e)
        {
            string targetUrl = txt_dnsURL.Text;
            string dnsListPath = label_pathToListDNS.Text;

            // Kiểm tra đường dẫn tệp
            if (!File.Exists(dnsListPath))
            {
                MessageBox.Show("Đường dẫn tệp không hợp lệ: " + dnsListPath);
                return;
            }

            List<string> dnsServers = File.ReadAllLines(dnsListPath).ToList();

            await DnsChecker.CheckDnsServersAsync(dnsServers, targetUrl, (status) =>
            {
                if (listBox_dnsStatus.InvokeRequired)
                {
                    listBox_dnsStatus.Invoke(new Action(() =>
                    {
                        listBox_dnsStatus.Items.Add(status);
                    }));
                }
                else
                {
                    listBox_dnsStatus.Items.Add(status);
                }
            });
        }
    }
}
