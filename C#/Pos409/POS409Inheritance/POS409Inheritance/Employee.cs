using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS409Inheritance
{
    class Employee
    {
        private double _ID;

        private string _lastName;

        private string _firstName;

        private DateTime _DOB; 

        private DateTime _DOH; 

        public Employee()

        {
            _ID = 100000;

            _lastName = "";

            _firstName = "";

            _DOB = DateTime.Now;

            _DOH = DateTime.Now;
        }

        public double Id
        
        {
            get { return _ID; }

            set { _ID = value; }
        }
        
        public string LastName
        
        {
            get { return _lastName; }

            set { _lastName = value; }
        }
        
        public string FirstName
        
        {
            get { return _firstName;  }

            set { _firstName = value; }
        }
                
        public DateTime DoB
        
        {
            get { return _DOB; }

            set { _DOB = value; }
        }
               
        public DateTime DoH
        
        {
            get { return _DOH; }

            set { _DOH = value; }
        }

   }
}
