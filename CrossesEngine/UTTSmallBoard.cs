using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossesEngine
{
    public partial class UTTSmallBoard : UserControl
    {
        Label[,] tiles = new Label[3, 3];
        public int[,] tileStates = new int[3, 3];
        public int winner = 0;
        public bool isComplete = false;

        public UTTSmallBoard()
        {
            InitializeComponent();

            tiles[0, 0] = slot00;
            tiles[0, 1] = slot01;
            tiles[0, 2] = slot02;
            tiles[1, 0] = slot10;
            tiles[1, 1] = slot11;
            tiles[1, 2] = slot12;
            tiles[2, 0] = slot20;
            tiles[2, 1] = slot21;
            tiles[2, 2] = slot22;
        }

        public void SetTile(int x, int y, int team)
        {
            tileStates[x, y] = team;
            switch(team)
            {
                case -1:
                case 0:
                    tiles[x, y].Text = "?";
                    tiles[x, y].ForeColor = Color.Black;
                    break;
                case 1:
                    tiles[x, y].Text = "O";
                    tiles[x, y].ForeColor = Color.DeepPink;
                    break;
                case 2:
                    tiles[x, y].Text = "X";
                    tiles[x, y].ForeColor = Color.Blue;
                    break;
            }

            CheckForWin();
        }

        public void Reset()
        {
            winner = 0;
            isComplete = false;

            for (int y = 0; y < 3; ++y)
            {
                for(int x = 0; x < 3; ++x)
                {
                    tileStates[x, y] = 0;
                    tiles[x, y].Text = "?";
                    tiles[x, y].ForeColor = Color.Black;
                }
            }

            CheckForWin();
        }

        private void CheckForWin()
        {
            if (isComplete)
                return;

            for(int x = 0; x < 3; ++x)
            {
                if (tileStates[x, 0] > 0 && tileStates[x, 0] == tileStates[x, 1] && tileStates[x, 0] == tileStates[x, 2])
                {
                    winner = tileStates[x, 0];
                    break;
                }
            }

            for (int y = 0; y < 3 && winner == 0; ++y)
            {
                if (tileStates[0, y] > 0 && tileStates[0, y] == tileStates[1, y] && tileStates[0, y] == tileStates[2, y])
                {
                    winner = tileStates[0, y];
                    break;
                }
            }

            if (winner == 0)
            {
                if (tileStates[0, 0] > 0 && tileStates[0, 0] == tileStates[1, 1] && tileStates[0, 0] == tileStates[2, 2]) //TL to BR
                {
                    winner = tileStates[0, 0];
                }
                else if (tileStates[2, 0] > 0 && tileStates[2, 0] == tileStates[1, 1] && tileStates[2, 0] == tileStates[0, 2]) //TR to BL
                {
                    winner = tileStates[2, 0];
                }
            }

            isComplete = true;
            if (winner == 0) //Check for tie
            {
                for (int y = 0; y < 3; ++y)
                {
                    for(int x = 0; x < 3; ++x)
                    {
                        if (tileStates[x, y] == 0)
                        {
                            isComplete = false;
                            break;
                        }
                    }
                }
            }

            for(int y = 0; y < 3; ++y)
            {
                for(int x = 0; x < 3; ++x)
                {
                    switch (winner)
                    {
                        default:
                        case 0:
                            tiles[x, y].BackColor = isComplete ? Color.Gray : Color.Silver;
                            break;
                        case 1:
                            tiles[x, y].BackColor = Color.HotPink;
                            break;
                        case 2:
                            tiles[x, y].BackColor = Color.SkyBlue;
                            break;
                    }
                }
            }
        }
    }
}
