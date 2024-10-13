using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DDoS_Simulator
{
    public partial class DDoS_Simulator : Form
    {
        private down_proxy proxyDownloader;
        private check_proxy proxyChecker;
        public DDoS_Simulator()
        {
            InitializeComponent();

            checkBox_availableUseProxy.CheckedChanged += checkBox_availableUseProxy_CheckedChanged;
            checkBox_downProxy.CheckedChanged += checkBox_downProxy_CheckedChanged;

            // Khởi tạo lớp down_proxy với listBox_Status
            proxyDownloader = new down_proxy(listBox_Status);

            // Cập nhật để sử dụng đúng listBox
            proxyChecker = new check_proxy(label_pathToListProxy.Text, listBox_checkProxy); // Đảm bảo chỉ có 2 tham số

        }

        private void btn_checkURL_Click(object sender, EventArgs e)
        {
            string url = txt_URL.Text;  // Lấy URL từ TextBox

            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                check_URL checker = new check_URL();  // Khởi tạo lớp CheckURL
                long pingTime = checker.GetPingTime(url);  // Gọi hàm đo ping

                if (pingTime >= 0)
                {
                    label_Ping.Text = $"Ping: {pingTime} ms";
                    listBox_checkProxy.Items.Add($"Ping to {url}: {pingTime} ms");
                }
                else
                {
                    label_Ping.Text = "URL không hoạt động";
                    listBox_checkProxy.Items.Add($"Ping failed for {url}");
                }
            }
            else
            {
                MessageBox.Show("URL không hợp lệ. Vui lòng nhập URL hợp lệ.");
            }
        }

        private void btn_openFileProxy_Click(object sender, EventArgs e)
        {
            open_proxy proxyOpener = new open_proxy(); // Khởi tạo lớp open_proxy
            string filePath = proxyOpener.OpenFile(); // Gọi hàm mở tệp

            if (!string.IsNullOrEmpty(filePath))
            {
                label_pathToListProxy.Text = filePath; // Cập nhật label với đường dẫn tệp đã chọn

                int proxyCount = proxyOpener.CountProxies(filePath); // Đếm số lượng proxy trong tệp
                listBox_checkProxy.Items.Add($"Số lượng proxy: {proxyCount}"); // Hiển thị số lượng proxy trong ListBox

                // Bật checkbox cho việc sử dụng proxy có sẵn
                checkBox_availableUseProxy.Enabled = true;
                checkBox_downProxy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không có tệp nào được chọn."); // Thông báo nếu không có tệp
            }
        }

        private void checkBox_downProxy_CheckedChanged(object sender, EventArgs e)
        {
            btn_downProxy.Enabled = checkBox_downProxy.Checked;
        }

        private void checkBox_availableUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            btn_openFileProxy.Enabled = checkBox_availableUseProxy.Checked;
        }

        private async void btn_downProxy_Click(object sender, EventArgs e)
        {
            // Khởi tạo lớp down_proxy với listBox_checkProxy
            down_proxy proxyDownloader = new down_proxy(listBox_checkProxy);
            await proxyDownloader.DownloadProxiesAsync(); // Gọi phương thức tải xuống proxy
        }

        private async void btn_checkProxy_Click(object sender, EventArgs e)
        {
            listBox_checkProxy.Items.Add("Đang check...");
            if (string.IsNullOrEmpty(label_pathToListProxy.Text))
            {
                MessageBox.Show("Vui lòng chọn một tệp proxy trước khi kiểm tra.");
                return;
            }

            // Khởi tạo lớp check_proxy với đường dẫn tệp và listBox
            check_proxy proxyChecker = new check_proxy(label_pathToListProxy.Text, listBox_checkProxy);
            await proxyChecker.CheckProxiesAsync(); // Gọi phương thức kiểm tra proxy
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            label_pathToListProxy.Text = "Path to proxy list: "; 
            listBox_Status.Items.Clear();
            listBox_checkProxy.Items.Clear();

            checkBox_downProxy.Checked = false;
            checkBox_availableUseProxy.Checked = false;

            radioButton_ccAttack.Checked = false;
            radioButton_slow.Checked = false;
            radioButton_POST.Checked = false;
            radioButton_HEAD.Checked = false;

            txt_URL.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private CancellationTokenSource cts;
        private async void btn_Start_Click(object sender, EventArgs e)
        {
            if (radioButton_HEAD.Checked)
            {
                string targetUrl = txt_URL.Text;
                string proxyPath = label_pathToListProxy.Text;
                int multiple = 10; // Thay đổi số lượng yêu cầu gửi mỗi proxy tùy theo nhu cầu của bạn

                cts = new CancellationTokenSource(); // Khởi tạo CancellationTokenSource
                var headAttack = new HeadAttack(targetUrl, proxyPath, multiple, listBox_Status); // Đảm bảo listBox_Status là tham số thứ 4

                listBox_Status.Items.Add("Bắt đầu tấn công HEAD...");

                try
                {
                    await headAttack.ExecuteAttack(cts.Token);
                }
                catch (OperationCanceledException)
                {
                    listBox_Status.Items.Add("Tấn công đã dừng.");
                }
                catch (Exception ex)
                {
                    listBox_Status.Items.Add($"Lỗi: {ex.Message}");
                }
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
        }
    }
}
