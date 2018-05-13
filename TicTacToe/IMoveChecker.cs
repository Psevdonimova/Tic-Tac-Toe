using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    interface IMoveChecker
    {
        bool checkArrayCorrectness(string[] turnArray);
        bool checkArrayContent(int sizeOfField, int targetLine, int targetColumn);
        bool checkPosition(int[,] generalField, int targetLine, int targetColumn);       
    }
}
