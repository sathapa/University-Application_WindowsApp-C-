using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityApplication
{
    public partial class Form1 : Form
    {
        Repository rep = new Repository();

        List<Student> STList = new List<Student>();
        List<Department> DList = new List<Department>();
        List<Professor> PList = new List<Professor>();
        List<Course> CList = new List<Course>();

        Student st = new Student();
        Department d = new Department();
        Professor p = new Professor();
        Course c = new Course();
        CoursePrerequisite cp = new CoursePrerequisite();
        CoursesOffered co = new CoursesOffered();
        CourseTaken ct = new CourseTaken();
                        
        public Form1()
        {
            InitializeComponent();
        }

        private void IDbStudents_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\Academic\\Sem III\\Windows\\Homeworks\\Homework7\\Text_Files";
            ofd.Filter = "text files|*.txt|docx files|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sid, fname, lname, staddress, city, state, telephone;
                string filename = ofd.FileName;
                FileInfo fi = new FileInfo(filename);
                Stream str = fi.Open(FileMode.Open, FileAccess.Read);
                StreamReader sstr = new StreamReader(str);
                string sLine = sstr.ReadLine();
                char[] seps = { ',' };
                while (sLine != null)
                {
                    string[] parts = sLine.Split(seps);
                    st.StudentID = parts[0];
                    st.FirstName = parts[1];
                    st.LastName = parts[2];
                    st.StreetAddress = parts[3];
                    st.City = parts[4];
                    st.State = parts[5];
                    st.Telephone = parts[6];

                    sid = st.StudentID;
                    fname = st.FirstName;
                    lname = st.LastName;
                    staddress = st.StreetAddress;
                    city = st.City;
                    state = st.State;
                    telephone = st.Telephone;
                    STList.Add(st);

                    string sql1 = "select * from students where StudentID="+sid;
                    object obj = DataAccess.GetSingleAnswer(sql1);
                    if (obj != null)
                    {
                        MessageBox.Show("Student data already inserted.");
                        sLine = sstr.ReadLine();
                    }
                    else
                    {
                        MessageBox.Show("Student data not present.");
                        bool ret = rep.InsertStudents(sid, fname, lname, staddress, city, state, telephone);

                        if (ret == true) { MessageBox.Show("Student Inserted Successfully!"); }
                        else { MessageBox.Show("Student insertion is not Successful."); }
                        sLine = sstr.ReadLine();
                    }
                    if (sLine == null)
                        break;
                    if (sLine.Trim() == "")
                        break;
                }
                sstr.Close();
            }
        }

        private void IdbDepartments_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\Academic\\Sem III\\Windows\\Homeworks\\Homework7\\Text_Files";
            ofd.Filter = "text files|*.txt|docx files|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string did, dname;
                string filename = ofd.FileName;
                FileInfo fi = new FileInfo(filename);
                Stream str = fi.Open(FileMode.Open, FileAccess.Read);
                StreamReader sstr = new StreamReader(str);
                string sLine = sstr.ReadLine();
                char[] seps = { ',' };
                while (sLine != null)
                {
                    string[] parts = sLine.Split(seps);
                    d.DepartmentID = int.Parse(parts[0]);
                    d.DepartmentName = parts[1];
                    
                    did = d.DepartmentID.ToString();
                    dname = d.DepartmentName;
                    DList.Add(d);

                    string sql2 = "select * from departments where DepartmentID=" + did;
                    object obj = DataAccess.GetSingleAnswer(sql2);
                    if (obj != null)
                    {
                        MessageBox.Show("Department data already inserted.");
                        sLine = sstr.ReadLine();
                    }
                    else
                    {
                        MessageBox.Show("Department data not present.");
                        bool res_dep = rep.InsertDeparts(did, dname);

                        if (res_dep == true) { MessageBox.Show("Department Inserted Successfully!"); }
                        else { MessageBox.Show("Department insertion is not Successful."); }
                        sLine = sstr.ReadLine();
                    }
                    if (sLine == null)
                        break;
                    if (sLine.Trim() == "")
                        break;
                }
                sstr.Close();
            }
        }

        private void IdbProfessors_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\Academic\\Sem III\\Windows\\Homeworks\\Homework7\\Text_Files";
            ofd.Filter = "text files|*.txt|docx files|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string pid, fname, lname, staddress, city, state, telephone;
                string filename = ofd.FileName;
                FileInfo fi = new FileInfo(filename);
                Stream str = fi.Open(FileMode.Open, FileAccess.Read);
                StreamReader sstr = new StreamReader(str);
                string sLine = sstr.ReadLine();
                char[] seps = { ',' };
                while (sLine != null)
                {
                    string[] parts = sLine.Split(seps);
                    p.ProfessorID = parts[0];
                    p.FirstName = parts[1];
                    p.LastName = parts[2];
                    p.StreetAddress = parts[3];
                    p.City = parts[4];
                    p.State = parts[5];
                    p.Telephone = parts[6];

                    pid = p.ProfessorID;
                    fname = p.FirstName;
                    lname = p.LastName;
                    staddress = p.StreetAddress;
                    city = p.City;
                    state = p.State;
                    telephone = p.Telephone;
                    PList.Add(p);

                    string sql1 = "select * from professors where ProfessorID=" + pid;
                    object obj = DataAccess.GetSingleAnswer(sql1);
                    if (obj != null)
                    {
                        MessageBox.Show("Professor data already inserted.");
                        sLine = sstr.ReadLine();
                    }
                    else
                    {
                        MessageBox.Show("Professor data not present.");
                        bool ret = rep.InsertProfessors(pid, fname, lname, staddress, city, state, telephone);

                        if (ret == true) { MessageBox.Show("Professor Inserted Successfully!"); }
                        else { MessageBox.Show("Professor insertion is not Successful."); }
                        sLine = sstr.ReadLine();
                    }
                    if (sLine == null)
                        break;
                    if (sLine.Trim() == "")
                        break;
                }
                sstr.Close();
            }
        }

        private void IdbC_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\Academic\\Sem III\\Windows\\Homeworks\\Homework7\\Text_Files";
            ofd.Filter = "text files|*.txt|docx files|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string cnum, cname, chours, desc, did;
                string filename = ofd.FileName;
                FileInfo fi = new FileInfo(filename);
                Stream str = fi.Open(FileMode.Open, FileAccess.Read);
                StreamReader sstr = new StreamReader(str);
                string sLine = sstr.ReadLine();
                char[] seps = { ',' };
                while (sLine != null)
                {
                    string[] parts = sLine.Split(seps);
                    c.CourseNum = parts[0];
                    c.CourseName = parts[1];
                    c.CreditHours = int.Parse(parts[2]);
                    c.Description = parts[3];
                    //c.DepartmentID = int.Parse(parts[4]);
                    d.DepartmentID = int.Parse(parts[4]);
                    
                    cnum = c.CourseNum;
                    cname = c.CourseName;
                    chours = c.CreditHours.ToString();
                    desc = c.Description;
                    did = d.DepartmentID.ToString();
                    //CList.Add(c);
                    
                    string sql1 = "select * from courses where CourseNum='" + cnum+"'";
                    object obj = DataAccess.GetSingleAnswer(sql1);
                    if (obj != null)
                    {
                        MessageBox.Show("Course data already inserted.");
                        sLine = sstr.ReadLine();
                    }
                    else
                    {
                        MessageBox.Show("Course data not present.");
                        bool ret = rep.InsertCourses(cnum, cname, chours, desc, did);

                        if (ret == true) { MessageBox.Show("Course Inserted Successfully!"); }
                        else { MessageBox.Show("Course insertion is not Successful."); }
                        sLine = sstr.ReadLine();
                    }
                    if (sLine == null)
                        break;
                    if (sLine.Trim() == "")
                        break;
                }
                sstr.Close();
            }
        }

        private void IdbCP_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\Academic\\Sem III\\Windows\\Homeworks\\Homework7\\Text_Files";
            ofd.Filter = "text files|*.txt|docx files|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string cnum, cpnum;
                string filename = ofd.FileName;
                FileInfo fi = new FileInfo(filename);
                Stream str = fi.Open(FileMode.Open, FileAccess.Read);
                StreamReader sstr = new StreamReader(str);
                string sLine = sstr.ReadLine();
                char[] seps = { ',' };
                while (sLine != null)
                {
                    string[] parts = sLine.Split(seps);
                    c.CourseNum = parts[0];
                    cp.PreCourseNum = parts[1];
                    
                    cnum = c.CourseNum;
                    cpnum = cp.PreCourseNum;
                    //STList.Add(st);

                    string sql1 = "select * from CoursePrerequisites where CourseNum='" + cnum+"'";
                    object obj = DataAccess.GetSingleAnswer(sql1);
                    if (obj != null)
                    {
                        MessageBox.Show("Course Prerequisite data already inserted.");
                        sLine = sstr.ReadLine();
                    }
                    else
                    {
                        MessageBox.Show("Course Prerequisite data not present.");
                        bool ret = rep.InsertCoursePre(cnum, cpnum);

                        if (ret == true) { MessageBox.Show("Course Preq Inserted Successfully!"); }
                        else { MessageBox.Show("Course Preq insertion is not Successful."); }
                        sLine = sstr.ReadLine();
                    }
                    if (sLine == null)
                        break;
                    if (sLine.Trim() == "")
                        break;
                }
                sstr.Close();
            }
        }

        private void IdbCO_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\Academic\\Sem III\\Windows\\Homeworks\\Homework7\\Text_Files";
            ofd.Filter = "text files|*.txt|docx files|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string cnum, sem, max_enroll, enroll_count, room_no, pid;
                string filename = ofd.FileName;
                FileInfo fi = new FileInfo(filename);
                Stream str = fi.Open(FileMode.Open, FileAccess.Read);
                StreamReader sstr = new StreamReader(str);
                string sLine = sstr.ReadLine();
                char[] seps = { ',' };
                while (sLine != null)
                {
                    string[] parts = sLine.Split(seps);
                    c.CourseNum = parts[0];
                    co.Semester = parts[1];
                    co.MaxEnrollment = int.Parse(parts[2]);
                    co.EnrolledCount = int.Parse(parts[3]);
                    co.RoomNumber = parts[4];
                    p.ProfessorID =parts[5];

                    cnum = c.CourseNum;
                    sem = co.Semester;
                    max_enroll = co.MaxEnrollment.ToString();
                    enroll_count = co.EnrolledCount.ToString();
                    room_no = co.RoomNumber;
                    pid = p.ProfessorID;
                    //STList.Add(st);

                    string sql1 = "select * from CoursesOffered where CourseNum='"+cnum+"' and Semester='"+sem+"'";
                    object obj = DataAccess.GetSingleAnswer(sql1);
                    if (obj != null)
                    {
                        MessageBox.Show("CoursesOffered data already inserted.");
                        sLine = sstr.ReadLine();
                    }
                    else
                    {
                        MessageBox.Show("CoursesOffered data not present.");
                        bool ret = rep.InsertCoursesOffered(cnum, sem, max_enroll, enroll_count, room_no, pid);

                        if (ret == true) { MessageBox.Show("CoursesOffered Inserted Successfully!"); }
                        else { MessageBox.Show("CoursesOffered insertion is not Successful."); }
                        sLine = sstr.ReadLine();
                    }
                    if (sLine == null)
                        break;
                    if (sLine.Trim() == "")
                        break;
                }
                sstr.Close();
            }

        }

        private void IdbCT_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\Academic\\Sem III\\Windows\\Homeworks\\Homework7\\Text_Files";
            ofd.Filter = "text files|*.txt|docx files|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sid, cnum, sem, grade;
                string filename = ofd.FileName;
                FileInfo fi = new FileInfo(filename);
                Stream str = fi.Open(FileMode.Open, FileAccess.Read);
                StreamReader sstr = new StreamReader(str);
                string sLine = sstr.ReadLine();
                char[] seps = { ',' };
                while (sLine != null)
                {
                    string[] parts = sLine.Split(seps);
                    
                    st.StudentID = parts[0];
                    c.CourseNum = parts[1];
                    co.Semester = parts[2];
                    ct.Grade = parts[3];

                    sid = st.StudentID;
                    cnum = c.CourseNum;
                    sem = co.Semester;
                    grade = ct.Grade;
                    //STList.Add(st);

                    string sql1 = "select * from CoursesTaken where StudentID='"+sid+"' and CourseNum='"+cnum+"' and Semester='"+sem+"'";
                    object obj = DataAccess.GetSingleAnswer(sql1);
                    if (obj != null)
                    {
                        MessageBox.Show("CoursesTaken data already inserted.");
                        sLine = sstr.ReadLine();
                    }
                    else
                    {
                        MessageBox.Show("CoursesTaken data not present.");
                        bool ret = rep.InsertCoursesTaken(sid, cnum, sem, grade);

                        if (ret == true) { MessageBox.Show("CoursesTaken Inserted Successfully!"); }
                        else { MessageBox.Show("CoursesTaken insertion is not Successful."); }
                        sLine = sstr.ReadLine();
                    }
                    if (sLine == null)
                        break;
                    if (sLine.Trim() == "")
                        break;
                }
                sstr.Close();
            }

        }

        private void IdbSC_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\Academic\\Sem III\\Windows\\Homeworks\\Homework7\\Text_Files";
            ofd.Filter = "text files|*.txt|docx files|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sid, cnum, sem;
                string filename = ofd.FileName;
                FileInfo fi = new FileInfo(filename);
                Stream str = fi.Open(FileMode.Open, FileAccess.Read);
                StreamReader sstr = new StreamReader(str);
                string sLine = sstr.ReadLine();
                char[] seps = { ',' };
                while (sLine != null)
                {
                    string[] parts = sLine.Split(seps);
                    st.StudentID = parts[0];
                    c.CourseNum = parts[1];
                    co.Semester = parts[2];

                    sid = st.StudentID;
                    cnum = c.CourseNum;
                    sem = co.Semester;
                    //STList.Add(st);

                    string sql1 = "select * from StudentCourses where StudentID='"+sid+"' and CourseNum='"+cnum+"' and Semester='"+sem+"'";
                    object obj = DataAccess.GetSingleAnswer(sql1);
                    if (obj != null)
                    {
                        MessageBox.Show("StudentCourses data already inserted.");
                        sLine = sstr.ReadLine();
                    }
                    else
                    {
                        MessageBox.Show("StudentCourses data not present.");
                        bool ret = rep.InsertStudentCourses(sid, cnum, sem);

                        if (ret == true) { MessageBox.Show("StudentCourses Inserted Successfully!"); }
                        else { MessageBox.Show("StudentCourses insertion is not Successful."); }
                        sLine = sstr.ReadLine();
                    }
                    if (sLine == null)
                        break;
                    if (sLine.Trim() == "")
                        break;
                }
                sstr.Close();
            }
        }

        private void idbSM_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\Academic\\Sem III\\Windows\\Homeworks\\Homework7\\Text_Files";
            ofd.Filter = "text files|*.txt|docx files|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sid, did;
                string filename = ofd.FileName;
                FileInfo fi = new FileInfo(filename);
                Stream str = fi.Open(FileMode.Open, FileAccess.Read);
                StreamReader sstr = new StreamReader(str);
                string sLine = sstr.ReadLine();
                char[] seps = { ',' };
                while (sLine != null)
                {
                    string[] parts = sLine.Split(seps);
                    st.StudentID = parts[0];
                    d.DepartmentID = int.Parse(parts[1]);

                    sid = st.StudentID;
                    did = d.DepartmentID.ToString();
                    //STList.Add(st);

                    string sql1 = "select * from StudentMajors where StudentID='"+sid+"' and DepartmentID='"+did+"'";
                    object obj = DataAccess.GetSingleAnswer(sql1);
                    if (obj != null)
                    {
                        MessageBox.Show("Student data already inserted.");
                        sLine = sstr.ReadLine();
                    }
                    else
                    {
                        MessageBox.Show("Student data not present.");
                        bool ret = rep.InsertStudentMajors(sid, did);

                        if (ret == true) { MessageBox.Show("Student Inserted Successfully!"); }
                        else { MessageBox.Show("Student insertion is not Successful."); }
                        sLine = sstr.ReadLine();
                    }
                    if (sLine == null)
                        break;
                    if (sLine.Trim() == "")
                        break;
                }
                sstr.Close();
            }
        }

        private void idbPD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\Academic\\Sem III\\Windows\\Homeworks\\Homework7\\Text_Files";
            ofd.Filter = "text files|*.txt|docx files|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string pid, did;
                string filename = ofd.FileName;
                FileInfo fi = new FileInfo(filename);
                Stream str = fi.Open(FileMode.Open, FileAccess.Read);
                StreamReader sstr = new StreamReader(str);
                string sLine = sstr.ReadLine();
                char[] seps = { ',' };
                while (sLine != null)
                {
                    string[] parts = sLine.Split(seps);
                    p.ProfessorID = parts[0];
                    d.DepartmentID = int.Parse(parts[1]);

                    pid = p.ProfessorID;
                    did = d.DepartmentID.ToString();
                    //STList.Add(st);

                    string sql1 = "select * from ProfessorDepartments where ProfessorID='" + pid + "' and DepartmentID='" + did + "'";
                    object obj = DataAccess.GetSingleAnswer(sql1);
                    if (obj != null)
                    {
                        MessageBox.Show("ProfessorDepartments data already inserted.");
                        sLine = sstr.ReadLine();
                    }
                    else
                    {
                        MessageBox.Show("ProfessorDepartments data not present.");
                        bool ret = rep.InsertProfessorDepartments(pid, did);

                        if (ret == true) { MessageBox.Show("ProfessorDepartments Inserted Successfully!"); }
                        else { MessageBox.Show("ProfessorDepartments insertion is not Successful."); }
                        sLine = sstr.ReadLine();
                    }
                    if (sLine == null)
                        break;
                    if (sLine.Trim() == "")
                        break;
                }
                sstr.Close();
            }
        }

        private void SMViewStd_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            ViewStudents vST = new ViewStudents();
            if(vST.ShowDialog()==DialogResult.OK)
            {
                string dname = vST.department;
                dt = rep.GetStudentsbyMajors(dname);                

                dgData.DataSource = dt;
                dgData.Refresh();
            }
        }

        private void SMViewStdgd_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            ViewStudentGrades vSG = new ViewStudentGrades();
            if(vSG.ShowDialog()==DialogResult.OK)
            {
                string sid = vSG.StudentID;
                dt = rep.GetStudents_Courses_Grades(sid);

                dgData.DataSource = dt;
                dgData.Refresh();
            }
        }

        private void CMViewCO_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            ViewCoursesOffered vCO = new ViewCoursesOffered();
            if(vCO.ShowDialog() == DialogResult.OK)
            {
                string sem = vCO.Semester;
                dt = rep.GetCoursesOfferedbySemester(sem);

                dgData.DataSource = dt;
                dgData.Refresh();
            }
        }

        private void CMViewE_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            ViewEnrollments vE = new ViewEnrollments();
            if(vE.ShowDialog()==DialogResult.OK)
            {
                string sem = vE.Semester;
                string cnum = vE.CourseNum;
                dt = rep.GetEnrollmentOfCoursesbySemester(sem, cnum);

                dgData.DataSource = dt;
                dgData.Refresh();
            }
        }


    }

}