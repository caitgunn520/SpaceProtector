using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceProtector
{
    class Bullet
    {
        public int size, speed, x, y;

        public Bullet(int _size, int _speed, int _x, int _y)
        {
            size = _size;
            speed = _speed;
            x = _x;
            y = _y;
        }
    }
}
