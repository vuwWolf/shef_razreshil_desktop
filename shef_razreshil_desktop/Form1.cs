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
            string shef = "���";
            string happy_shef = null;
            string evil_shef = null;

            Random xuy = new Random();
            int zalupa = xuy.Next(1, 3);
            if (zalupa == 1)
            {
                happy_shef = "������������� � �������� ��������";
            }
            else if (zalupa == 2) 
            {
                happy_shef = "� ����� ��������� �������� �������� � ��������";
            }

            Random penis = new Random();
            int davalka = penis.Next(1, 3);
            if (davalka == 1) 
            {
                evil_shef = "�������� ������";
            }
            else if (davalka == 2)
            {
                evil_shef = "� ������, ������� ������ ������";
            }


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