﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class FlyNoFly : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Not Flying");
        }
    }
}
