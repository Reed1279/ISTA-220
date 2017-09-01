using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSquad
{
    class Gun1 : Squad
    {


        public void G1Fire()
        {
            Console.WriteLine("Gun 1 responds with Gun 1 Rapid Rate on me");
        }

        public void G1ShiftFire()
        {
            Console.WriteLine("Gun 1 replys Shift Fire on 3, Shift Fire Confirmed");
        }

        public override void Kill()
        {
            Console.WriteLine("Executes guidance given from his SL with precise execution");
        }
    }
}
