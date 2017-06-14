using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication
{
    class Person
    {
        public Person() { }
        public Person(string fname,string lname, string staddress, string city, 
            string state, string telephone)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.streetAddress = staddress;
            this.city = city;
            this.state = state;
            this.telephone = telephone; 
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string streetAddress;
        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        private string telephone;
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public override string ToString()
        {
            return firstName + " " + lastName +
                " " + streetAddress + " " +
                city + " " + state + " " + telephone;
        }
    }
}
