using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSquad
{
    class Gun2 : Squad
    {


        public void G2Fire()
        {
            Console.WriteLine("Gun 2 responds with Gun 2 Rapid Rate on 1");
        }

        public void G2ShiftFire()
        {
            Console.WriteLine("Gun 2 shifts and replies Shift Fire Confirmed");
        }

        public override void Kill()
        {
            Console.WriteLine("Executes guidance given from his SL with precise execution");
        }


    }
}
