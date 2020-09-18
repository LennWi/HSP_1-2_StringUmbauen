using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2_HSP_2
{
    class Program
    {
        static void Main()
        {
            string hw = " HelloWorld Welt";
            double zahl = 2.0;

            //char[] spaces = { ' ' };

            string[] hwSplitUp = hw.Split(' ');     //geht auch mit 'spaces' wenn char array genutzt wird

            string hwNew = hw.Replace(" HelloWorld Welt", String.Format("{0} {1:0.000}", hwSplitUp[1], zahl));

            Console.WriteLine(hwNew);

            Console.ReadKey();
        }
    }
}
