using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Louis_AI
{
    public partial class Sw_version : Form
    {
        public Sw_version()
        {
            InitializeComponent();
            // 外枠に黒線を表示する
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panel);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_btn_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sw_version_Load(object sender, EventArgs e)
        {

        }
    }
}
