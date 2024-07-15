using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Singleton
{
    class Singleton
    {
        string versionNumber;
        private static Singleton singleton;

        public string getVersionNumber {get; set;}

        private Singleton() { }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Singleton getInstance()
        {
            if (singleton == null)
                singleton = new Singleton();
            return singleton;
        }
    }
}
