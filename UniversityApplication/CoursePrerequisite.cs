using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication
{
    class CoursePrerequisite
    {
        public CoursePrerequisite() { }

        private string preCourseNum;
        public string PreCourseNum
        {
            get { return preCourseNum; }
            set { preCourseNum = value; }
        }


    }
}
