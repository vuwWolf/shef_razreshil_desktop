using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace shef_razreshil_desktop
{
    public partial class shef : Form
    {
        public shef()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shefBoxFalse.Visible = false;
            shefBoxTrue.Visible = false;
            string shef_res;
            string shef = "Ўеф";
            string happy_shef = null;
            string evil_shef = null;

            Random xuy = new();
            int zalupa = xuy.Next(1, 3);
            if (zalupa == 1)
            {
                happy_shef = "смилостивилс€ и разрешил покурить";
            }
            else if (zalupa == 2) 
            {
                happy_shef = "в честь праздника разрешил покурить в туалетах";
            }

            Random penis = new();
            int davalka = penis.Next(1, 3);
            if (davalka == 1) 
            {
                evil_shef = "запретил курить";
            }
            else if (davalka == 2)
            {
                evil_shef = "в €рости, сегодн€ опасно курить";
            }


            Random her = new();
            int rukoblud = her.Next(0, 10);

            if (rukoblud >= 9)
            {
                shef_res = shef + " " + happy_shef;
                result.Text = shef_res;
            }
            else 
            {
                shef_res = shef + " " + evil_shef;
                result.Text = shef_res;
            }

            if (rukoblud >= 9)
            {
                shefBoxTrue.Visible = true;
            }
            else
            {
                shefBoxFalse.Visible = true;
            }

            result.Visible = true;
            
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shef_Load(object sender, EventArgs e)
        {

        }
    }
    }
