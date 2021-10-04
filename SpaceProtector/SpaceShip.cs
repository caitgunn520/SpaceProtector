using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceProtector
{
    public class SpaceShip
    {
        public int x, y, length, width, speed;

        public SpaceShip(int _x, int _y, int _length, int _width, int _speed)
        {
            x = _x;
            y = _y;
            length = _length;
            width = _width;
            speed = _speed;
        }
    }
}
