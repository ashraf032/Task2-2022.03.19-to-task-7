using System;

namespace _2ededintopl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 dene 5 reqemli eded daxil edin");
            
            Console.Write("I ededi daxil edin :");
            
            string num1 = Console.ReadLine();

            Console.Write("II ededi daxil edin: ");
            
            string num2 = Console.ReadLine();
            
            int a = int.Parse(num1);
            
            int b = int.Parse(num2);
            
            string couple1 = "5";
            
            string couple2 = "5";
            
           
            string c = couple1 +( a + b)+couple2;

            Console.WriteLine(c);

            int e = int.Parse(c);
            
            int d = e / 100 * 5;

            if(a>=10000 && a<100000 || b>10000 && b<100000)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("Nezere alinmayib");
            }


        }
    }
}
