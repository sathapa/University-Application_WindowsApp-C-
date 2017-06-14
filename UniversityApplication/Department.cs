using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication
{
    class Department
    {
        public Department() { }
        private int departmentID;
        public int DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; }
        }

        private string departmentName;
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
    }
}
