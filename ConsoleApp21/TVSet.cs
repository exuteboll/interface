using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class TVSet : ISwitchable
    {
        public void Vkl()
        {
            Console.WriteLine("включен тв ");
        }
        public void Vukl()
        {
            Console.WriteLine("выключен тв ");
        }


    }
}
