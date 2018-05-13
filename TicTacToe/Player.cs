using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    abstract class Player
    {
        public int[,] gameField;
        protected Player (int sizeOfField)
        {
           gameField = new int[2, ++sizeOfField];
        }        
        public abstract int getSign();
    }
}
