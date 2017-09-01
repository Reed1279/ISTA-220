using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSquad
{
    class Gun3 : Squad
    {


        public void G3Fire()
        {
            Console.WriteLine("Gun 3 responds with Gun 3 Rapid Rate on 1");
        }

        public void G3ShiftFire()
        {
            Console.WriteLine("After last burst, Gun 3 replies Gun 3 Shift Fire on Me, Shift Fire Confirmed");
        }

        public override void Kill()
        {
            Console.WriteLine("Executes guidance given from his SL with precise execution");
        }
    }
}
