using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class PersonalComputer : ISwitchable
    {
        public void Vkl()
        {
            Console.WriteLine("включен пк");
        }
        public void Vukl()
        {
            Console.WriteLine("выключен пк");
        }
    }
}
