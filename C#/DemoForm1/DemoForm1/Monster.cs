using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm1
{
    internal class Monster
    {
        private int X;
        private int Y;

        // direction: 1=> Up Down, 3 +> Left, 4 => Right
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    Y += 1;
                    break ;
                case Direction.DOWN:
                    Y -= 1;
                    break ;
                case Direction.LEFT:
                    X -= 1;
                    break;
                case Direction.RIGHT:
                    X -= 1;
                    break;
                default:

                    break ;
            }
        }

        public string ReportPostition()
        {
            return "怪物 (" + X + " , " + Y + ")";
        }
    }
}
