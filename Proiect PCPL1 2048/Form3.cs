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
        bool dinnou = true;//folosit pentru a reincepe jocul
        Random RD = new Random();//folosit pentru a da numere la inceputul jocului aleator
        static ArrayList linie=new ArrayList();//folosit pentru a se putea interactiona cu cele 16 patrate
        public Form3()
        {
            InitializeComponent();

        }
        public void culori()//folosit pentru stabilirea culorilor
        {
            Label[,] joc = {
            {label1,label2,label3,label4 },
            {label5,label6,label7,label8 },
            {label9,label10,label11,label12 },
            {label13,label14,label15,label16 }
            };//recunoasterea celor 16 patratele
            
            for(int i = 0;i<4; i++)//declarare matrice pt 1
            {
                for (int j = 0; j < 4; j++)//declarare matrice pt 2
                {
                    if (joc[i, j].Text == "")//stabilire culoare pentru cand nu este nici un numar in patrat
                    {
                        joc[i, j].BackColor = System.Drawing.Color.MediumSeaGreen;//stabilirea culorii fundalului
                    }
                    if (joc[i, j].Text == "2")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.Turquoise;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;//stabilirea culorii fontului

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
                    if (joc[i, j].Text == "4096")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.Magenta;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                    if (joc[i, j].Text == "8192")
                    {
                        joc[i, j].BackColor = System.Drawing.Color.MediumAquamarine;
                        joc[i, j].ForeColor = System.Drawing.Color.Black;

                    }
                }

            }
        }
        public void produnumere()//functie folosita pentru a produce numere
        {
            linie.Clear();

            Label[,] joc = {
            {label1,label2,label3,label4},
            {label5,label6,label7,label8},
            {label9,label10,label11,label12},
            {label13,label14,label15,label16}
            };//recunoasterea celor 16 patratele

            for (int i = 0; i < 4; i++)//declararea matricii pt 1
            {
                for (int j = 0; j < 4; j++)// declararea matricii pt 2
                {
                    if (joc[i, j].Text == "")//conditie de trecere
                    {
                        linie.Add(i * 4 + j + 1);//trecerea prin fiecare linie

                    }
                }
            }
                    if(linie.Count > 0)
                    {

                        int numara = int.Parse(linie[RD.Next(0, linie.Count - 1)].ToString());//transformarea numerelor din string in echivalent de 32 de biti
                        int i1 = (numara - 1) / 4;//numarare pt 1
                        int j1 = (numara - 1) - i1 * 4;//numarare pt 2
                        int linie2 = RD.Next(1, 10);//stabilirea valorilor aleatorii
                        if (linie2 == 1 || linie2 == 2 || linie2 == 3 || linie2 == 4 || linie2 == 5 || linie2 == 6)//conditie de asignare a valorilor
                        {
                            joc[i1, j1].Text = "2";//asignarea valorii 2 
                        }
                        else
                        {
                            joc[i1, j1].Text = "4";//asignarea valorii 4 
                        }    

                        
                    }
                    culori();
                

            
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {   
            produnumere();//repetare functie de 3 ori 
            produnumere();
            produnumere();

        }
        
        
        private void Return_Click(object sender, EventArgs e)//functie pentru intoarcerea inapoi la pagina principala
        {
            this.Close();
            Form1 newform = new Form1();
            newform.Show();

        }
        private void jocNouToolStripMenuItem1_Click(object sender, EventArgs e)//folosit pentru a incepe alt joc
        {   
            dinnou = true;//conditia de joc nou
            Score2.Text = "0";//resetarea scorului
            Label[,] Game = {
                {label1,label2,label3,label4},
                {label5,label6,label7,label8},
                {label9,label10,label11,label12},
                {label13,label14,label15,label16}
                };//recunoasterea celor 16 patratele

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Visible = true;
                    Game[i, j].Text = "";
                }
            }
            produnumere();
            produnumere();
            produnumere();
        }



        private void OptiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
