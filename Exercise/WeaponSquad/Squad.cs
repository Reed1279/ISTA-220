using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSquad
{
    class Squad
    {
        public void OnLine(string CallToBringOnLine)
        {
            Console.WriteLine($"Actions at Contact: {CallToBringOnLine}");
        }

        public void CeaseFire(string CallToCeaseFire)
        {
            Console.WriteLine($"All Enemy Eliminated: {CallToCeaseFire}");
        }

        public virtual void Kill()
        {
            Console.WriteLine("Default implementation of the Kill method");
        }
    }
}
