using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            RubberDuck rduck = new RubberDuck();
            rduck.display();
            MallardDuck mduck = new MallardDuck();
            mduck.display();
            Console.ReadLine();
        }
    }
}
