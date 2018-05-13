using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    interface IGameEngine
    {
        void processMove(int[,] generalField, Player player, int targetLine, int targetColum);
        int[] makeMove(int[,] generalField, Player human, Player computer);
        bool checkWin(Player player);
        bool checkDraw(int[,] generalField);
    }
}
