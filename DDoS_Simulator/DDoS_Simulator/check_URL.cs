using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDoS_Simulator
{
    internal class check_URL
    {
        public long GetPingTime(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                Stopwatch timer = new Stopwatch();

                timer.Start();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    timer.Stop();

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return timer.ElapsedMilliseconds;
                    }
                    else
                    {
                        MessageBox.Show($"Phản hồi không hợp lệ. Mã trạng thái: {response.StatusCode}");
                        return -1;
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show($"Lỗi khi kết nối với máy chủ: {ex.Message}");
                return -1;
            }
        }
    }
}