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
    public partial class UTTBoard : UserControl
    {
        UTTSmallBoard[,] boards = new UTTSmallBoard[3, 3];

        public UTTBoard()
        {
            InitializeComponent();

            boards[0, 0] = board00;
            boards[0, 1] = board01;
            boards[0, 2] = board02;
            boards[1, 0] = board10;
            boards[1, 1] = board11;
            boards[1, 2] = board12;
            boards[2, 0] = board20;
            boards[2, 1] = board21;
            boards[2, 2] = board22;
        }

        public void SetTile(int x, int y, int team)
        {
            boards[x / 3, y / 3].SetTile(x % 3, y % 3, team);
        }

        public UTTSmallBoard GetBoard(int bX, int bY)
        {
            return boards[bX, bY];
        }

        public void Reset()
        {
            for (int y = 0; y < 3; ++y)
            {
                for (int x = 0; x < 3; ++x)
                {
                    boards[x, y].Reset();
                }
            }
        }
    }
}
