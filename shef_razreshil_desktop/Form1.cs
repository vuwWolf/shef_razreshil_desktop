using System.Security.Cryptography.X509Certificates;

namespace shef_razreshil_desktop
{
    public partial class shef : Form
    {
        public shef()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shef_res = null;
            string shef = "шеф";
            string happy_shef = "смилостивился и разрешил покурить";
            string evil_shef = "запретил курить";
            Random rnd = new Random();
            int x = rnd.Next(0, 10);

            if (x >= 9)
            {
                shef_res = shef + " " + happy_shef;
                result.Text = shef_res;
            }
            else 
            {
                shef_res = shef + " " + evil_shef;
                result.Text = shef_res;
            }

            result.Visible = true;
            
        }
    }
}