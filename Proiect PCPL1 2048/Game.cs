using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PCPL1_2048
{
    public enum Direction { UP, DOWN, LEFT, RIGHT }//declarare directii
    public class GameBoardStatus : EventArgs//declarare tabla de joc
    {
        public int[,] gameBoard;

        public GameBoardStatus(int[,] gameBoard)
        {
            this.gameBoard = (int[,])gameBoard.Clone();
        }
    }
    public class Game//functia joc
    {
        private const int PERCENTAGE_OF_4_APPEARANCE = 20;//procent de aparitie a lui 4 in loc de 2 la inceputul jocului

        private int[,] gameBoard;

        public event EventHandler GameBoardModified;
        public event EventHandler GameOver;

        public Game()//initializare functie
        {
            gameBoard = new int[4, 4];
        }

        public void Start()//adaugarea primelor 2 numere pe spatii aleatorii
        {
            AddNewNum();
            AddNewNum();

            GameBoardModified?.Invoke(this, new GameBoardStatus(gameBoard));
        }

        private void AddNewNum()//functie adaugare numere
        {
            Random rand = new Random();//functie aleatorie

            int x, y;//variabile ale tabelului

            while (true)//conditie de acceptare a numerelor noi
            {
                x = rand.Next(4);
                y = rand.Next(4);

                if (gameBoard[x, y] == 0)
                {
                    break;
                }
            }

            int percent = rand.Next(100);//declarare procentaj aparitii

            if (percent < PERCENTAGE_OF_4_APPEARANCE)//conditie pentru aparitia lui 4
            {
                gameBoard[x, y] = 4;
            }
            else//conditie pentru aparitia lui 2
            {
                gameBoard[x, y] = 2;
            }
        }

        public void Move(Direction dir)//functie pentru taste
        {
            int movement = 0;

            switch (dir)
            {
                case Direction.UP:
                    movement = MoveUp();
                    break;

                case Direction.DOWN:
                    movement = MoveDown();
                    break;

                case Direction.LEFT:
                    movement = MoveLeft();
                    break;

                case Direction.RIGHT:
                    movement = MoveRight();
                    break;
            }

            if (movement != 0)//daca se poate face o mutare
            {
                AddNewNum();
                GameBoardModified?.Invoke(this, new GameBoardStatus(gameBoard));
            }

            if (MoveAble() == false)//daca nu se mai poate face o mutare
            { 
                GameOver?.Invoke(this, EventArgs.Empty);
            }
        }

        private int MoveUp()//variabile de taste returnare
        {
            return _MoveUp(gameBoard);
        }

        private int MoveDown()
        {
            return _MoveDown(gameBoard);
        }

        private int MoveLeft()
        {
            return _MoveLeft(gameBoard);
        }

        private int MoveRight()
        {
            return _MoveRight(gameBoard);
        }

        private bool MoveAble()//conditie 2 pentru verificarea posibilitatii de miscare
        {
            int[,] cloneForMoveUp = (int[,])gameBoard.Clone();
            int[,] cloneForMoveDown = (int[,])gameBoard.Clone();
            int[,] cloneForMoveLeft = (int[,])gameBoard.Clone();
            int[,] cloneForMoveRight = (int[,])gameBoard.Clone();

            int movement = _MoveUp(cloneForMoveUp) + _MoveDown(cloneForMoveDown) + _MoveLeft(cloneForMoveLeft) + _MoveRight(cloneForMoveRight);

            if (movement == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Primește o intrare de matrice int[4], mută elementele din ea către al 0-lea element și returnează numărul total de mișcări.
        // </rezumat>
        // <param name="line">Matrice de int[4] de mutat</param>
        // <returns>Numărul de mișcări</returns>
        private int _MoveLine(int[] input)
        {
            int movement = 0;

            //1. În primul rând, colectați toate elementele către al 0-lea element.
            int numNum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0) //Dacă există un număr în intrare[i]
                {
                    if (i != numNum) //doar dacă numărul nu este în locul potrivit
                    {
                        input[numNum] = input[i];
                        input[i] = 0;
                        movement++;
                    }

                    numNum++;
                }
            }

            //2. Verificați dacă există un număr care poate fi combinat începând cu al 0-lea element și, dacă există, îmbinați-l.
            for (int i = 0; i < numNum - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input[i] *= 2;
                    input[i + 1] = 0;
                    movement++;
                    i++; //Elementul (i + 1) nu trebuie verificat.
                }
            }

            //3. Colectați din nou toate elementele către al 0-lea element.
            int ptr = 0;
            for (int i = 0; i < numNum; i++)
            {
                if (input[i] != 0)
                {
                    if (i != ptr)
                    {
                        input[ptr] = input[i];
                        input[i] = 0;
                        movement++;
                    }

                    ptr++;
                }
            }

            return movement;
        }

        private int _MoveUp(int[,] gameBoard)//functie tasta de sus
        {
            int movement = 0;//declarare variabila

            for (int i = 0; i < 4; i++)//Conditie pana la 4(maxim de tabel) si declarare variabila i
            {
                int[] input = new int[4] { gameBoard[0, i], gameBoard[1, i], gameBoard[2, i], gameBoard[3, i] };

                movement += _MoveLine(input);

                for (int j = 0; j < 4; j++)//repetare conditie si declarare variabila j
                {
                    gameBoard[j, i] = input[j];
                }
            }

            return movement;
        }

        private int _MoveDown(int[,] gameBoard)//functie tasta de jos
        {
            int movement = 0;

            for (int i = 0; i < 4; i++)
            {
                int[] input = new int[4] { gameBoard[3, i], gameBoard[2, i], gameBoard[1, i], gameBoard[0, i] };

                movement += _MoveLine(input);

                for (int j = 0; j < 4; j++)
                {
                    gameBoard[3 - j, i] = input[j];
                }
            }

            return movement;
        }

        private int _MoveLeft(int[,] gameBoard)
        {
            int movement = 0;

            for (int i = 0; i < 4; i++)
            {
                int[] input = new int[4] { gameBoard[i, 0], gameBoard[i, 1], gameBoard[i, 2], gameBoard[i, 3] };

                movement += _MoveLine(input);

                for (int j = 0; j < 4; j++)
                {
                    gameBoard[i, j] = input[j];
                }
            }

            return movement;
        }

        private int _MoveRight(int[,] gameBoard)
        {
            int movement = 0;

            for (int i = 0; i < 4; i++)
            {
                int[] input = new int[4] { gameBoard[i, 3], gameBoard[i, 2], gameBoard[i, 1], gameBoard[i, 0] };

                movement += _MoveLine(input);

                for (int j = 0; j < 4; j++)
                {
                    gameBoard[i, 3 - j] = input[j];
                }
            }

            return movement;
        }
        
    }
}