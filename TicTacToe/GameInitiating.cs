using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class GameInitiating : IGameInitiating
    {
        public int[,] generalFieldCreating(int sizeOfField)
        {
            int[,] generalField = new int[sizeOfField, sizeOfField];
            return generalField;
        }
    }
}
