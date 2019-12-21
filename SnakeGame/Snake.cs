using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Snake
    {
        public Snake()
        {


        }
        public void Progress()
        {


        }

        public void Growth()
        {


        }
    }
        class Snake_Parts
        {
            public readonly int x_;
            public readonly int y_;
            public readonly int size_x;
            public readonly int size_y; 
            public Snake_Parts(int x, int y)
            {
                x_ = x;
                y_ = y;
                size_x = 10;
                size_y = 10;

            }

        }
    class Direction
    {
        public readonly int _x;
        public readonly int _y;
        public Direction(int x,int y)
        {

            _x = x;
            _y = y;
        }
    }


}
