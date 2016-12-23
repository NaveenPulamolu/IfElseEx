using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the age");
            a = Convert.ToInt32(Console.ReadLine());
            if(a < 13)
            {
                Console.WriteLine("Hello kid");
            }
            else if(a <= 19)
            {
                Console.WriteLine("You a teenager");
            }
            else if (a > 19 && a <= 40)
            {
                Console.WriteLine("Energetic youth");
            }
            else
            {
                Console.WriteLine("Hello, Senior");
            }
            Console.ReadLine();
        }
    }
}
