using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class circles
    {
        public int x, y, r;
        public circles(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public int getCenterX()
        {
            return x + r / 2;
        }
        public int getCenterY()
        {
            return y + r / 2;
        }
    }
}
