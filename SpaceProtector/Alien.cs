using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceProtector
{
    public class Alien
    {
        public int x, y, size, speed;

        public Boolean BullColl(Bullet b)
        {
            Rectangle bullRec = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle alienRec = new Rectangle(x, y, size, size);

            return bullRec.IntersectsWith(alienRec);
        }
        
        public Alien(int _x, int _y, int _size, int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
        }
    }
}
