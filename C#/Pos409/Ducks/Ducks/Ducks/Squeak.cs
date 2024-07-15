using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeaking");
        }
    }
}
