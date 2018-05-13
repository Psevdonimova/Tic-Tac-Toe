using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Human : Player
    {
        public Human(int sizeOfField) : base(sizeOfField) {}
        public override int getSign()
        {
            return 1;
        }
    }
}
