using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banana
{
    class Program
    {
        static void Main(string[] args)
        {
            //With Standard Contructor
            Banana banana1 = new Banana();
            banana1.Name = "Banana 1";
            banana1.Size = 9;
            banana1.Color = "Yellow";

            //With Specific Constructor
            Banana banana2 = new Banana("Banana 2", 11, "Green");
            Banana banana3 = new Banana("Banana 3", 11, "Yellow");
            Banana banana4 = new Banana("Banana 4", 8, "Green");
            Banana banana5 = new Banana("Banana 5", 13, "Green");

            //Variablenname Loopbar? also index hochzählen zum hinzufügen einer Liste

            List<Banana> bananaList = new List<Banana> {banana1, banana2, banana3, banana4, banana5 };

            foreach (var item in bananaList)
            {
                if (item.Size >= 10)
                {
                    Console.WriteLine("Banananame: " + item.Name);
                }
            }

            Console.WriteLine();

            foreach (var item in bananaList)
            {
                if (item.Size < 10)
                {
                    Console.WriteLine("Banananame: " + item.Name);
                }
            }

            Console.ReadLine();

        }
    }
}
