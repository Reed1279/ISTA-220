using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSquad
{
    class Program : Squad
    {
        static void doWork()
        {
            Console.WriteLine("Weapon Squad Leader:");
            SquadLeader mySQL = new SquadLeader();
            mySQL.OnLine("Guns on Line, Let's GO!!");
            mySQL.CMDFire();
            mySQL.CMDShiftFire();
            mySQL.CeaseFire("Cease Fire!");

            Console.WriteLine("\nGun Team 3:");
            Gun3 myGun3 = new Gun3();
            myGun3.OnLine("Gun 3 Set!");
            myGun3.G3Fire();
            myGun3.G3ShiftFire();
            myGun3.CeaseFire("Cease Fire! Cease Fire! Cease Fire!");

            Console.WriteLine("\nGun Team 1:");
            Gun1 myGun1 = new Gun1();
            myGun1.OnLine("Gun 1 Set!");
            myGun1.G1Fire();
            myGun1.G1ShiftFire();
            myGun1.CeaseFire("Cease Fire!");

            Console.WriteLine("\nGun Team 2:");
            Gun2 myGun2 = new Gun2();
            myGun2.OnLine("Gun 2 Set!");
            myGun2.G2Fire();
            myGun2.G2ShiftFire();
            myGun2.CeaseFire("Cease Fire! Cease Fire!");

            Console.WriteLine("\nTesting polymorphism");
            Squad v = mySQL;
            v.Kill();
            v = myGun1;
            v.Kill();
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}



