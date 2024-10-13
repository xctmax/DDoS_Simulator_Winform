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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Form currentFormCon;
        private void openFormCon(Form FormCon)
        {
            if (currentFormCon != null)
            {
                currentFormCon.Close();
            }
            currentFormCon = FormCon;
            FormCon.TopLevel = false;
            FormCon.FormBorderStyle = FormBorderStyle.None;
            FormCon.Dock = DockStyle.Fill;
            panel1.Controls.Add(currentFormCon);
            panel1.Tag = FormCon;
            FormCon.BringToFront();
            FormCon.Show();
        }
        private void l7FloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormCon(new DDoS_Simulator());
        }

        private void dNSAmplificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormCon(new DNS_Amplification());
        }
    }
}
