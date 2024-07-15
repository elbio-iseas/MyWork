using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class MyProperties
    {
        private static MyProperties properties;
        private int versionNumber;

        private MyProperties() { }

        public int getVersionNumber()
        {
            return versionNumber;
        }

        public static MyProperties getInstance()
        {
            if (properties == null)
            {
                properties = new MyProperties();
            }
            return properties;
        }



        public void loadProperties() { }


    }
}
