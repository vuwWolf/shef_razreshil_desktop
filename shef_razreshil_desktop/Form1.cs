using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shef_razreshil_desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;

            if (progressBar1.Value >= 99)
            {
                timer1.Enabled = false;
                Form frm = new shef();
                frm.Show();
                this.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 3;

            if (progressBar1.Value >= 99)
            {
                progressBar1.Value = 0;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
