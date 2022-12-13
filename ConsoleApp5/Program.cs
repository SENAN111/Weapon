using ConsoleApp5.Models;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        tryagain:
            Console.WriteLine("Bullercountu daxil edin");
            int buller_counnt = int.Parse(Console.ReadLine());
            if (buller_counnt <0 || buller_counnt>40)
            {
                Console.WriteLine("dogru daxil edin");
                goto tryagain;
            }
            tryagain1:
            Console.WriteLine("Buller capastini daxil edin");
            int buller_capasity = int.Parse(Console.ReadLine());
            if(buller_capasity<5 || buller_capasity>40)
            {
                Console.WriteLine("dogru daxil edin");
                goto tryagain1;
            }
              tryagain2:
            Console.WriteLine("dargin bosalma saniyesini daxil edin");
           
            double comp_discharge_second = double.Parse(Console.ReadLine());
            if(comp_discharge_second<6 || comp_discharge_second>50)
            {
                Console.WriteLine("dogru daxil edin");
                goto tryagain2;
            }
        tryagain3:
            //Console.WriteLine("atis modunu daxil edin");
            //string weapon_mod = Console.ReadLine();
            //if(weapon_mod.ToLower()!= "tek" && weapon_mod.ToLower()!="avto")
            //{
            //    Console.WriteLine("dogru daxil edin");
            //    goto tryagain3;
            //}

            Weapons weapons = new Weapons(buller_capasity, buller_counnt, comp_discharge_second);
            Console.WriteLine("secim edin");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "0":
                    Console.WriteLine();
                    break;
                case "1":
                    //weapons.Shoot();
                    break;
                case "2":
                    weapons.Fire();
                    break;
                case "3":

                    weapons.GetRemainBulletCount();
                    break;
                case "4":
                    weapons.Reolad();
                    break;
                case "5":
                    weapons.ChangeFireMode();
                    break;
                case "6":
                    return;

            }
            
        }
    }
}