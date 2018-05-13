using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Computer : Player
    {
        public Computer(int sizeOfField) : base(sizeOfField) {}
        public override int getSign()
        {
            return 2;
        }
    }
}
