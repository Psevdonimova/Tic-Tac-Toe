using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class MoveChecker : IMoveChecker
    {
        public bool checkArrayCorrectness(string [] turnArray)
        {
            if (turnArray.Length != 2)
                return false;
            else
                return true;
        }
        public bool checkArrayContent(int sizeOfField, int targetLine, int targetColumn)
        {
            if (targetLine > sizeOfField || targetColumn > sizeOfField || targetLine == 0 || targetColumn == 0)
                return false;
            else
                return true;
        }
        public bool checkPosition(int [,] generalField, int targetLine, int targetColumn)
        {
            if (generalField[targetLine - 1,targetColumn - 1] != 0)
                return false;
            else
                return true;
        }
    }
}
