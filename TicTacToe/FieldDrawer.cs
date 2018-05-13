using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class FieldDrawer : IFieldDrawer
    {
        public void drawField (int [,] generalField, Player human, Player computer)
        {
            for (int i = 1; i <= generalField.GetLength(1); i++)
            {
                for (int j = 1; j <= generalField.GetLength(1); j++)
                {
                    if (generalField[i - 1, j - 1] == human.getSign())
                        Console.Write("[" + i + "," + j + "]" + ":" + " " + "X" + " ");
                    else if (generalField[i - 1, j - 1] == computer.getSign())
                        Console.Write("[" + i + "," + j + "]" + ":" + " " + "O" + " ");
                    else
                    {
                        Console.Write("[" + i + "," + j + "]" + ":" + " " + " " + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
