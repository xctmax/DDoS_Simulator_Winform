using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DDoS_Simulator
{
    internal class DnsAmplification_openDNS
    {
        public string OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";  // Chỉ cho phép chọn tệp .txt hoặc bất kỳ tệp nào
                openFileDialog.Title = "Chọn tệp DNS";

                // Nếu người dùng chọn tệp và nhấn OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;  // Trả về đường dẫn tệp
                }
            }
            return null;  // Nếu không có tệp nào được chọn
        }
        public int CountDNS(string filePath)
        {
            try
            {
                // Đọc tất cả các dòng trong tệp
                string[] lines = File.ReadAllLines(filePath);
                return lines.Length; // Trả về số lượng dòng (proxy)
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc tệp: " + ex.Message);
                return 0; // Trả về 0 nếu có lỗi
            }
        }
    }
}
