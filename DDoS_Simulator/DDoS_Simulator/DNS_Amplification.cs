using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDoS_Simulator
{
    public partial class DNS_Amplification : Form
    {
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
                label_pathToListDNS.Text = "Path to DNS list: " + filePath; // Cập nhật label với đường dẫn tệp đã chọn

                int dnsCount = dnsOpener.CountDNS(filePath); // Đếm số lượng proxy trong tệp
                listBox_dnsStatus.Items.Add($"Số lượng DNS: {dnsCount}"); // Hiển thị số lượng DNS trong ListBox
            }
            else
            {
                MessageBox.Show("Không có tệp nào được chọn."); // Thông báo nếu không có tệp
            }
        }
    }
}
