using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class RubberDuck : Duck
    {

        public RubberDuck()
        {
            flyBehavior = new FlyNoFly();
            quackBehavior = new Squeak();
        }

        public void display()
        {
            Console.WriteLine("Rubber Ducky");
            performFly();
            performQuack();
        }
    }
}
