using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Összeg = 0;
            while(Összeg<100)
            { 
                Console.WriteLine("Számokat kérek, az összegük nem haladhatja meg a 100-at");
                var szam = int.Parse(Console.ReadLine());
                if(szam!=null)
                {
                Console.WriteLine("Megadott szám:" + szam.ToString());
                Összeg += szam;
                Console.WriteLine("Összeg:" + Összeg);
                if(Összeg >=100)
                {
                    Console.WriteLine("A megadott számok összege több vagy egyenlő, mint száz");
                    Console.ReadKey();
                    break;
                }
                
                
                
                
                }
            }

        }
    }
}
