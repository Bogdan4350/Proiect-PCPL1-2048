using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Proiect_PCPL1_2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void START_Click(object sender, EventArgs e)
        { 
            this.Hide();
            var form3 = new Form3();
            form3.Show();
        }

        private void SETTINGS_Click(object sender, EventArgs e)
        {
              
            this.Hide();
            var form2 =new Form2();
            form2.Show();
           
        }

        private void CREDITS_Click(object sender, EventArgs e)
        {  
            this.Hide();
            var form4 = new Form4();
            form4.Show();

        }

        private void Aplicatie_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void EXIT_click(object sender, EventArgs e)
        {
            Application.Exit();


        }
    }

 
}