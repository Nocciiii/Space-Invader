using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Schuss
    {
        Double posx;
        Double posy;

        public Boolean alive;
        public Schuss()
        {
            while(alive==true)
            {
                MoveUP();
            }
        }

        public void MoveUP()
        {
           
        }
    }
}
