using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication
{
    class Professor:Person
    {
        public Professor() { }
        public Professor(string fname,string lname, string staddress, string city, 
            string state, string telephone,string pid)
        {
            this.professorID = pid;
        }

        private string professorID;
        public string ProfessorID
        {
            get { return professorID; }
            set { professorID = value; }
        }
    }
}
