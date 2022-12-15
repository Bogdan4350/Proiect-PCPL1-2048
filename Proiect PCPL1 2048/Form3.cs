using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proiect_PCPL1_2048
{
    public partial class Form3 : Form
    {
        Random RD = new Random();        
        static ArrayList linie=new ArrayList();
        public Form3()
        {
            InitializeComponent();

        }
        public void culori()
        {
            Label[,] joc = {
            {label1,label2,label3,label4 },
            {label5,label6,label7,label8 },
            {label9,label10,label11,label12 },
            {label13,label14,label15,label16 }
            };
            
            for(int i = 0;i<4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (joc[i, j].Text == "")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.MediumSeaGreen;
                    }
                    if (joc[i, j].Text == "2")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.Turquoise;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (joc[i, j].Text == "4")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.Azure;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (joc[i, j].Text == "8")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.Beige;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (joc[i, j].Text == "16")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.Coral;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (joc[i, j].Text == "32")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.DarkCyan;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (joc[i, j].Text == "64")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.Firebrick;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (joc[i, j].Text == "128")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.Goldenrod;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (joc[i, j].Text == "256")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.HotPink;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (joc[i, j].Text == "512")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.Indigo;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (joc[i, j].Text == "1024")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.Khaki;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (joc[i, j].Text == "2048")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.Silver;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                }

            }
        }
        public void produnumere()
        {
            linie.Clear();

            Label[,] joc = {
            {label1,label2,label3,label4},
            {label5,label6,label7,label8},
            {label9,label10,label11,label12},
            {label13,label14,label15,label16}
            };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (joc[i, j].Text == "")
                    {
                        linie.Add(i * 4 + j + 1);

                    }
                }
            }
                    if(linie.Count > 0)
                    {

                        int numara = int.Parse(linie[RD.Next(0, linie.Count - 1)].ToString());
                        int i1 = (numara - 1) / 4;
                        int j1 = (numara - 1) - i1 * 4;
                        int linie2 = RD.Next(1, 10);
                        if (linie2 == 1 || linie2 == 2 || linie2 == 3 || linie2 == 4 || linie2 == 5 || linie2 == 6)
                        {
                            joc[i1, j1].Text = "2";
                        }
                        else
                        {
                            joc[i1, j1].Text = "4";

                        }    

                        
                    }
                    culori();
                

            
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {produnumere();
            produnumere();
            produnumere();

        }
        
        
        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 newform = new Form1();
            newform.Show();

        }

        
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }
        private void Score2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void joc_incheiat_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

}
