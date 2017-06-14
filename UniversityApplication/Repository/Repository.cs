using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication
{
    class Repository
    {
        DataAccess _dac = null;
        static string connStr = "Server=SANTOS-PC;integrated security=true;database=StudentU";
        public Repository() { }
        public Repository(DataAccess dac)
        {
            _dac = dac;
        }

        #region Insert DATA
        public bool InsertStudents(string sid,string fname,string lname,string staddress, string city, string state, string phone)
        {
            bool res = false;
            try
            {
                        string sql2 = "insert into Students (StudentID,FirstName,LastName,StreetAddress,City,State,Telephone) VALUES(@sid,@fname,@lname,@staddress,@city,@state,@telephone)";

                        List<DbParameter> Plist = new List<DbParameter>();
                        SqlParameter p1 = new SqlParameter("@sid", SqlDbType.VarChar, 10);
                        p1.Value = sid;
                        Plist.Add(p1);
                        SqlParameter p2 = new SqlParameter("@fname", SqlDbType.VarChar, 50);
                        p2.Value = fname;
                        Plist.Add(p2);
                        SqlParameter p3 = new SqlParameter("@lname", SqlDbType.VarChar, 50);
                        p3.Value = lname;
                        Plist.Add(p3);
                        SqlParameter p4 = new SqlParameter("@staddress", SqlDbType.VarChar, 100);
                        p4.Value = staddress;
                        Plist.Add(p4);
                        SqlParameter p5 = new SqlParameter("@city", SqlDbType.VarChar, 50);
                        p5.Value = city;
                        Plist.Add(p5);
                        SqlParameter p6 = new SqlParameter("@state", SqlDbType.VarChar, 10);
                        p6.Value = state;
                        Plist.Add(p6);
                        SqlParameter p7 = new SqlParameter("@telephone", SqlDbType.VarChar, 20);
                        p7.Value = phone;
                        Plist.Add(p7);
                        int noOfRows = DataAccess.InsertUpdateDelete(sql2,Plist);
                        
                        if(noOfRows>0){res=true;}
                        else{res=false;}
            }
            catch(Exception ex){throw ex;}
            return res;
        }

        public bool InsertDeparts(string did, string dname)
        {
            bool res = false;
            try
            {
                string sql2 = "insert into Departments (DepartmentID,DepartmentName) VALUES(@did,@dname)";

                List<DbParameter> Dlist = new List<DbParameter>();
                SqlParameter d1 = new SqlParameter("@did", SqlDbType.Int);
                d1.Value = did;
                Dlist.Add(d1);
                SqlParameter d2 = new SqlParameter("@dname", SqlDbType.VarChar, 20);
                d2.Value = dname;
                Dlist.Add(d2);
                int noOfRows = DataAccess.InsertUpdateDelete(sql2, Dlist);

                if (noOfRows > 0) { res = true; }
                else { res = false; }
            }
            catch (Exception ex) { throw ex; }
            return res;
        }

        public bool InsertProfessors(string pid, string fname, string lname, string staddress, string city, string state, string phone)
        {
            bool res = false;
            try
            {
                string sql2 = "insert into Professors (ProfessorID,FirstName,LastName,StreetAddress,City,State,Telephone) VALUES(@pid,@fname,@lname,@staddress,@city,@state,@telephone)";

                List<DbParameter> Plist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@pid", SqlDbType.VarChar, 10);
                p1.Value = pid;
                Plist.Add(p1);
                SqlParameter p2 = new SqlParameter("@fname", SqlDbType.VarChar, 50);
                p2.Value = fname;
                Plist.Add(p2);
                SqlParameter p3 = new SqlParameter("@lname", SqlDbType.VarChar, 50);
                p3.Value = lname;
                Plist.Add(p3);
                SqlParameter p4 = new SqlParameter("@staddress", SqlDbType.VarChar, 100);
                p4.Value = staddress;
                Plist.Add(p4);
                SqlParameter p5 = new SqlParameter("@city", SqlDbType.VarChar, 50);
                p5.Value = city;
                Plist.Add(p5);
                SqlParameter p6 = new SqlParameter("@state", SqlDbType.VarChar, 10);
                p6.Value = state;
                Plist.Add(p6);
                SqlParameter p7 = new SqlParameter("@telephone", SqlDbType.VarChar, 20);
                p7.Value = phone;
                Plist.Add(p7);
                int noOfRows = DataAccess.InsertUpdateDelete(sql2, Plist);

                if (noOfRows > 0) { res = true; }
                else { res = false; }
            }
            catch (Exception ex) { throw ex; }
            return res;
        }

        public bool InsertCourses(string cnum, string cname, string chours, string desc, string did)
        {
            bool res = false;
            try
            {
                string sql2 = "insert into Courses (CourseNum,CourseName,CreditHours,Description,DepartmentID) VALUES(@cnum,@cname,@chours,@desc,@did)";

                List<DbParameter> Plist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@cnum", SqlDbType.VarChar, 20);
                p1.Value = cnum;
                Plist.Add(p1);
                SqlParameter p2 = new SqlParameter("@cname", SqlDbType.VarChar, 50);
                p2.Value = cname;
                Plist.Add(p2);
                SqlParameter p3 = new SqlParameter("@chours", SqlDbType.Int);
                p3.Value = chours;
                Plist.Add(p3);
                SqlParameter p4 = new SqlParameter("@desc", SqlDbType.Text);
                p4.Value = desc;
                Plist.Add(p4);
                SqlParameter p5 = new SqlParameter("@did", SqlDbType.Int);
                p5.Value = did;
                Plist.Add(p5);
                int noOfRows = DataAccess.InsertUpdateDelete(sql2, Plist);

                if (noOfRows > 0) { res = true; }
                else { res = false; }
            }
            catch (Exception ex) { throw ex; }
            return res;
        }

        public bool InsertCoursePre(string cnum, string cpnum)
        {
            bool res = false;
            try
            {
                string sql2 = "insert into CoursePrerequisites (CourseNum,PrereqCourseNum) VALUES(@cnum,@cpnum)";

                List<DbParameter> Dlist = new List<DbParameter>();
                SqlParameter d1 = new SqlParameter("@cnum", SqlDbType.VarChar,20);
                d1.Value = cnum;
                Dlist.Add(d1);
                SqlParameter d2 = new SqlParameter("@cpnum", SqlDbType.VarChar, 20);
                d2.Value = cpnum;
                Dlist.Add(d2);
                int noOfRows = DataAccess.InsertUpdateDelete(sql2, Dlist);

                if (noOfRows > 0) { res = true; }
                else { res = false; }
            }
            catch (Exception ex) { throw ex; }
            return res;
        }

        public bool InsertCoursesOffered(string cnum, string sem, string max_enroll, string enroll_count, string room_no, string pid)
        {
            bool res = false;
            try
            {
                string sql2 = "insert into CoursesOffered (CourseNum,Semester,MaxEnrollment,EnrolledCount,RoomNumber,ProfessorId) VALUES(@cnum, @sem, @max_enroll, @enroll_count, @room_no, @pid)";

                List<DbParameter> Plist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@cnum", SqlDbType.VarChar, 10);
                p1.Value = cnum;
                Plist.Add(p1);
                SqlParameter p2 = new SqlParameter("@sem", SqlDbType.VarChar, 50);
                p2.Value = sem;
                Plist.Add(p2);
                SqlParameter p3 = new SqlParameter("@max_enroll", SqlDbType.VarChar, 50);
                p3.Value = max_enroll;
                Plist.Add(p3);
                SqlParameter p4 = new SqlParameter("@enroll_count", SqlDbType.VarChar, 100);
                p4.Value = enroll_count;
                Plist.Add(p4);
                SqlParameter p5 = new SqlParameter("@room_no", SqlDbType.VarChar, 50);
                p5.Value = room_no;
                Plist.Add(p5);
                SqlParameter p6 = new SqlParameter("@pid", SqlDbType.VarChar, 10);
                p6.Value = pid;
                Plist.Add(p6);
                int noOfRows = DataAccess.InsertUpdateDelete(sql2, Plist);

                if (noOfRows > 0) { res = true; }
                else { res = false; }
            }
            catch (Exception ex) { throw ex; }
            return res;
        }

        public bool InsertCoursesTaken(string sid, string cnum, string sem, string grade)
        {
            bool res = false;
            try
            {
                string sql2 = "insert into CoursesTaken (StudentID,CourseNum,Semester,Grade) VALUES(@sid,@cnum,@sem,@grade)";

                List<DbParameter> Plist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@sid", SqlDbType.VarChar, 10);
                p1.Value = sid;
                Plist.Add(p1);
                SqlParameter p2 = new SqlParameter("@cnum", SqlDbType.VarChar, 50);
                p2.Value = cnum;
                Plist.Add(p2);
                SqlParameter p3 = new SqlParameter("@sem", SqlDbType.VarChar, 50);
                p3.Value = sem;
                Plist.Add(p3);
                SqlParameter p4 = new SqlParameter("@grade", SqlDbType.VarChar, 100);
                p4.Value = grade;
                Plist.Add(p4);
                int noOfRows = DataAccess.InsertUpdateDelete(sql2, Plist);

                if (noOfRows > 0) { res = true; }
                else { res = false; }
            }
            catch (Exception ex) { throw ex; }
            return res;
        }

        public bool InsertStudentCourses(string sid, string cnum, string sem)
        {
            bool res = false;
            try
            {
                string sql2 = "insert into StudentCourses (StudentID,CourseNum,Semester) VALUES(@sid,@cnum,@sem)";

                List<DbParameter> Plist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@sid", SqlDbType.VarChar, 10);
                p1.Value = sid;
                Plist.Add(p1);
                SqlParameter p2 = new SqlParameter("@cnum", SqlDbType.VarChar, 50);
                p2.Value = cnum;
                Plist.Add(p2);
                SqlParameter p3 = new SqlParameter("@sem", SqlDbType.VarChar, 50);
                p3.Value = sem;
                Plist.Add(p3);
                int noOfRows = DataAccess.InsertUpdateDelete(sql2, Plist);

                if (noOfRows > 0) { res = true; }
                else { res = false; }
            }
            catch (Exception ex) { throw ex; }
            return res;
        }

        public bool InsertStudentMajors(string sid, string did)
        {
            bool res = false;
            try
            {
                string sql2 = "insert into StudentMajors (StudentID,DepartmentID) VALUES(@sid,@did)";

                List<DbParameter> Plist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@sid", SqlDbType.VarChar, 10);
                p1.Value = sid;
                Plist.Add(p1);
                SqlParameter p2 = new SqlParameter("@did", SqlDbType.VarChar, 50);
                p2.Value = did;
                Plist.Add(p2);
                int noOfRows = DataAccess.InsertUpdateDelete(sql2, Plist);

                if (noOfRows > 0) { res = true; }
                else { res = false; }
            }
            catch (Exception ex) { throw ex; }
            return res;
        }

        public bool InsertProfessorDepartments(string pid, string did)
        {
            bool res = false;
            try
            {
                string sql2 = "insert into ProfessorDepartments (ProfessorID,DepartmentID) VALUES(@pid,@did)";

                List<DbParameter> Plist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@pid", SqlDbType.VarChar, 10);
                p1.Value = pid;
                Plist.Add(p1);
                SqlParameter p2 = new SqlParameter("@did", SqlDbType.VarChar, 50);
                p2.Value = did;
                Plist.Add(p2);
                int noOfRows = DataAccess.InsertUpdateDelete(sql2, Plist);

                if (noOfRows > 0) { res = true; }
                else { res = false; }
            }
            catch (Exception ex) { throw ex; }
            return res;
        }
        #endregion
        public DataTable GetStudentsbyMajors(string dname)
        {
            DataTable dt = null;
            try
            {
                string sql = "SELECT s.StudentID,s.FirstName,s.LastName,d.DepartmentName as Department FROM Students s " +
                                "inner join StudentMajors sm on s.StudentId=sm.StudentId " +
                                "inner join Departments d on sm.DepartmentId=d.DepartmentId " +
                                "where d.DepartmentName='" + dname + "'";
                List<DbParameter> PList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@dname", SqlDbType.VarChar, 50);
                p1.Value = dname;
                PList.Add(p1);
                dt = DataAccess.GetManyRowsCols(sql, PList);
            }
            catch (Exception ex)
            { 
                throw ex; 
            }
            return dt;
        }

        public DataTable GetStudents_Courses_Grades(string sid)
        {
            DataTable dt=null;
            try
            {
                string sql = "SELECT s.StudentID,s.FirstName,s.LastName,d.DepartmentName,ct.Grade,c.CourseName from students s "+
                                "inner join StudentMajors sm on s.StudentId=sm.StudentId "+
                                "inner join Departments d on sm.DepartmentId=d.DepartmentId "+
                                "inner join CoursesTaken ct on ct.StudentId=s.StudentId "+
                                "inner join Courses c on ct.CourseNum = c.CourseNum "+
                                "where s.StudentId='"+sid+"'";
                List<DbParameter> PList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@sid", SqlDbType.VarChar, 50);
                p1.Value = sid;
                PList.Add(p1);
                dt = DataAccess.GetManyRowsCols(sql, PList);
            }
            catch(Exception ex)
            { throw ex; }
            return dt;
        }

        public DataTable GetCoursesOfferedbySemester(string sem)
        {
            DataTable dt = null;
            try
            {
                string sql = "SELECT c.CourseNum,c.CourseName,c.CreditHours,co.MaxEnrollment,co.EnrolledCount,co.RoomNumber, "+
                                "p.FirstName +' '+p.LastName as Professor FROM CoursesOffered co "+
                                "inner join Courses c ON co.CourseNum=c.CourseNum "+
                                "inner join Professors p ON p.ProfessorId=co.ProfessorId "+
                                "WHERE co.Semester='"+sem+"'";
                List<DbParameter> PList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@sem", SqlDbType.VarChar, 50);
                p1.Value = sem;
                PList.Add(p1);
                dt = DataAccess.GetManyRowsCols(sql, PList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable GetEnrollmentOfCoursesbySemester(string sem,string cnum)
        {
            DataTable dt = null;
            try
            {
                string sql = "Select c.CourseNum,c.CourseName,co.Semester,c.CreditHours,co.EnrolledCount,co.MaxEnrollment from Courses c"
                 + " inner join CoursesOffered co on c.CourseNum=co.CourseNum"
                 + " where co.Semester = '" + sem + "' and c.CourseName='" + cnum + "'"; 
                List<DbParameter> PList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@sem", SqlDbType.VarChar, 50);
                p1.Value = sem;
                PList.Add(p1);
                SqlParameter p2 = new SqlParameter("@cnum", SqlDbType.VarChar, 50);
                p2.Value = cnum;
                PList.Add(p2);
                dt = DataAccess.GetManyRowsCols(sql, PList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

    }
}
