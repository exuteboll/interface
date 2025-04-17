using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Kokojambo kokojambo = new Kokojambo();
            Jambokoko jambokoko = new Jambokoko();
            kokojambo.Meow1();
            jambokoko.Meow2();
            kokojambo.Meow2();
            Console.ReadKey();

        }
    }
}
