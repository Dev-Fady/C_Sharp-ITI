using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Game
    {
        IMovable[] movables;
        public Game()
        {
            movables = new IMovable[10];
        }
        public void Add (IMovable movable)
        {

        }
        public void Run()
        {
            for (int i = 0; i < movables.Length; i++)
            {
                movables[i].Move();
            }
        }
    }
}
