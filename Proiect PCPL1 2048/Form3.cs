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
        private Game game;
        public Form3()
        {
            InitializeComponent();

            game = new Game();//initializare joc

            game.GameBoardModified += DrawGameBoard;//modificare tabla
            game.GameOver += GameOver;//verificare joc terminat

            game.Start();//inceputul jocului
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)//procesare comenzi de tasta
        {
            if (keyData == Keys.Up)//tasta sus
            {
                game.Move(Direction.UP);
            }

            if (keyData == Keys.Down)//tasta jost
            {
                game.Move(Direction.DOWN);
            }

            if (keyData == Keys.Left)//tasta stanga
            {
                game.Move(Direction.LEFT);
            }

            if (keyData == Keys.Right)//tasta dreapta
            {
                game.Move(Direction.RIGHT);
            }

            return base.ProcessCmdKey(ref msg, keyData);//incheiere mutare tastatura
        }
        private void GameOver(object sender, EventArgs e)
        {
            MessageBox.Show("Game Over!", "Game Over!", MessageBoxButtons.OK);//mesaj afisat cand jocul este terminat
        }
        private Color NumToColor(int num)
        {
            switch (num)//culori(cand numarul este o valoare exacta din case, culoarea patratului se schimba
            {
                case 0://Empty
                    return Color.Gray;
                case 2://1
                    return Color.Turquoise;
                case 4://2
                    return Color.Azure;
                case 8://3
                    return Color.Beige;
                case 16://4
                    return Color.Coral;
                case 32://5
                    return Color.DarkCyan;
                case 64://6
                    return Color.Firebrick;
                case 128://7
                    return Color.Goldenrod;
                case 256://8
                    return Color.HotPink;
                case 512://9
                    return Color.Indigo;
                case 1024://10
                    return Color.Khaki;
                case 2048://11
                    return Color.Silver;
                case 4096://12
                    return Color.Magenta;
                case 8192://13
                    return Color.Aquamarine;
                case 16384://14
                    return Color.MediumAquamarine;
                case 32768://15
                    return Color.RebeccaPurple;
                case 65536://16
                    return Color.Red;
                case 131072://17
                    return Color.OrangeRed;
                default:
                    return base.BackColor;
            }
        }
        private String NumToText(int num)//verificare daca este spatiu liber
        {
            if (num == 0)
            {
                return "";
            }
            else
            {
                return num.ToString();
            }
        }
        private void DrawGameBoard(object sender, EventArgs e)//crearea spatiului de joc
        {
            int[,] gameBoard = (e as GameBoardStatus).gameBoard;//crearea tablei

            label1.BackColor = NumToColor(gameBoard[0, 0]);//initializarea patratelelor in culoare
            label1.Text = NumToText(gameBoard[0, 0]);//initializarea patratelelor in text

            label2.BackColor = NumToColor(gameBoard[0, 1]);
            label2.Text = NumToText(gameBoard[0, 1]);

            label3.BackColor = NumToColor(gameBoard[0, 2]);
            label3.Text = NumToText(gameBoard[0, 2]);

            label4.BackColor = NumToColor(gameBoard[0, 3]);
            label4.Text = NumToText(gameBoard[0, 3]);

            label5.BackColor = NumToColor(gameBoard[1, 0]);
            label5.Text = NumToText(gameBoard[1, 0]);

            label6.BackColor = NumToColor(gameBoard[1, 1]);
            label6.Text = NumToText(gameBoard[1, 1]);

            label7.BackColor = NumToColor(gameBoard[1, 2]);
            label7.Text = NumToText(gameBoard[1, 2]);

            label8.BackColor = NumToColor(gameBoard[1, 3]);
            label8.Text = NumToText(gameBoard[1, 3]);

            label9.BackColor = NumToColor(gameBoard[2, 0]);
            label9.Text = NumToText(gameBoard[2, 0]);

            label10.BackColor = NumToColor(gameBoard[2, 1]);
            label10.Text = NumToText(gameBoard[2, 1]);

            label11.BackColor = NumToColor(gameBoard[2, 2]);
            label11.Text = NumToText(gameBoard[2, 2]);

            label12.BackColor = NumToColor(gameBoard[2, 3]);
            label12.Text = NumToText(gameBoard[2, 3]);

            label13.BackColor = NumToColor(gameBoard[3, 0]);
            label13.Text = NumToText(gameBoard[3, 0]);

            label14.BackColor = NumToColor(gameBoard[3, 1]);
            label14.Text = NumToText(gameBoard[3, 1]);

            label15.BackColor = NumToColor(gameBoard[3, 2]);
            label15.Text = NumToText(gameBoard[3, 2]);

            label16.BackColor = NumToColor(gameBoard[3, 3]);
            label16.Text = NumToText(gameBoard[3, 3]);

            Invalidate();//terminare creare tabla
        }

        private void Form3_Load(object sender, EventArgs e)
        {   

        }
        
        
        private void Return_Click(object sender, EventArgs e)//functie pentru intoarcerea inapoi la pagina principala
        {
            this.Close();
            Form1 newform = new Form1();
            newform.Show();

        }
        private void jocNouToolStripMenuItem1_Click(object sender, EventArgs e)//folosit pentru a incepe alt joc
        {
            if (MessageBox.Show("începe un joc nou. Continuați?", "Joc nou", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                game = null;

                game = new Game();

                game.GameBoardModified += DrawGameBoard;
                game.GameOver += GameOver;

                game.Start();
            }

        }



        private void OptiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
