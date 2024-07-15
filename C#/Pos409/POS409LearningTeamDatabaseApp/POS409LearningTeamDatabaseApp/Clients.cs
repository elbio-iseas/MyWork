using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS409LearningTeamDatabaseApp
{
    class Clients
    {
        private double _phoneNumber;

        private string _lastName;

        private string _firstName;

        private string _address; 

        private string _city;
 
        private string _state;

        private string _zipCode;

        public Clients()

        {
            _phoneNumber = 1000000000;

            _lastName = "";

            _firstName = "";

            _address = "";

            _city = "";

            _state = "";

            _zipCode = "";

        }

        public double PhoneNumber        
        {
            get { return _phoneNumber; }

            set { _phoneNumber = value; }
        }
        
        public string LastName
        
        {
            get { return _lastName; }

            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }

            set { _firstName = value; }
        }
        
        public string Address
        
        {
            get { return _address;  }

            set { _address = value; }
        }

        public string City
        {
            get { return _city; }

            set { _city = value; }
        }

        public string State
        {
            get { return _state; }

            set { _state = value; }
        }

        public string ZipCode
        {
            get { return _zipCode; }

            set { _zipCode = value; }
        }
        
    }
}
