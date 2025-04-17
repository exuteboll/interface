using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            TVSet tvset = new TVSet();
            PersonalComputer personalcomputer = new PersonalComputer();
            while( true)
            {
                int i = 0;
                Console.WriteLine(@"Комп\тв
1.Тv 
2. Комп");
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
                switch(i)
                {
                    case 1: tvset.Vkl(); tvset.Vukl(); break;
                    case 2: personalcomputer.Vkl(); personalcomputer.Vukl(); break;
                }
            }
            Console.ReadKey();
        }
    }
}
