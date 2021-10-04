using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceProtector
{
    public class Alien
    {
        public int x, y, size, speed;

        public Alien(int _x, int _y, int _size, int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
        }
    }
}
