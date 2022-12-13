using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Weapons
    {
        int buller_capasity;
        int buller_count;
        double comp_discharge_second;
        string weapon_mod = "tekli";
        public int Buller_count 
        { 
            get
            {
                return buller_count;
            }
            set
            {
                if (value>0 && value<buller_capasity)
                {
                    buller_count = value;
                }
            }
        }
        public int Buller_Capasity
        {
            get
            {
                return buller_capasity;
            }
            set
            {
                if(value>5  && value<=40)
                {
                    buller_capasity = value;
                }
            }
        }
        public double Comp_discharge_second
        {
            get
            {
                return comp_discharge_second;
            }
            set
            {
                if (value > 6 && value < 60)
                {
                    comp_discharge_second = value;
                }
            }
        }
        public bool Weapon_Mod { get; set; }
        
        public Weapons(int buller_capasity, int buller_count, double comp_discharge_second)
        {

            Buller_Capasity = buller_capasity;
            Buller_count = buller_count;
            Comp_discharge_second = comp_discharge_second;
            
        }
        public void Shoot(double bullercount) 
        {
            bullercount = this.buller_capasity;
            if(bullercount>0)
            {
                Console.WriteLine("Gulle atildi");
                bullercount = bullercount - 1;
            }
            else if (bullercount ==0)
            {
                Console.WriteLine("sizin gulleniz yoxdur");
            }
            
        }
        public void Show_info()
        {
            Console.WriteLine("gulle sayi :"+ buller_capasity);
            Console.WriteLine("gulle sayi :" + comp_discharge_second);
            Console.WriteLine("gulle sayi :" + weapon_mod);
        }
        public double Fire()
        {
            return comp_discharge_second / (buller_capasity - buller_count);
        }
        public void Reolad()
        {
            if(buller_count<buller_capasity)
            {
                buller_count = buller_count + (buller_capasity - buller_count);
            }
            Console.WriteLine(buller_count);
        }
        public int GetRemainBulletCount()
        {
            return buller_capasity - buller_count;
        }
        public void ChangeFireMode()
        {
            weapon_mod = "avto";
        }
    }
}
