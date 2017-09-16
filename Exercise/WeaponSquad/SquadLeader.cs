using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSquad
{
    class SquadLeader : Squad
    {

        public virtual void CMDFire()
        {
            Console.WriteLine("SL yell's out Rapid Rate of Fire on 1");
        }

        public virtual void CMDShiftFire()
        {
            Console.WriteLine("SL directs guns to Shift Fire on 3");
        }

        public override void Kill()
        {
            Console.WriteLine("Gives commands to his Squad for execution");
        }
    }
}
