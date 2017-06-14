using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityApplication
{
    public partial class ViewEnrollments : Form
    {
        public string Semester { get { return this.cmbSem.GetItemText(this.cmbSem.SelectedItem); } }
        public string CourseNum { get { return this.cmbCN.GetItemText(this.cmbCN.SelectedItem); } }

        public ViewEnrollments()
        {
            InitializeComponent();
            DataTable dt = null;

            dt = GetData("GetAllSemesters",null);
            cmbSem.ValueMember = "Semester";
            cmbSem.DisplayMember = "Semester";
            cmbSem.DataSource = dt;
            cmbSem.Refresh();

            cmbSem.SelectedIndex = 1;
        }

        private DataTable GetData(string SPName, SqlParameter para)
        {
            string connStr = "Server=SANTOS-PC;integrated security=true;database=StudentU";
            SqlConnection con = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter(SPName, connStr);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (para != null)
            {
                da.SelectCommand.Parameters.Add(para);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void cmbSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSem.SelectedIndex >= 0)
            {
                SqlParameter para = new SqlParameter("@Semester", cmbSem.SelectedValue);
                DataTable dt = GetData("GetCoursesBySem", para);
            
                cmbCN.ValueMember = "CourseNum";
                cmbCN.DisplayMember = "CourseName";
                cmbCN.DataSource = dt;
                cmbCN.Refresh();
            }
        }

       /* private DataSet GetData(string SPName,SqlParameter para)
        {
            string connStr = "Server=SANTOS-PC;integrated security=true;database=StudentU";
            SqlConnection con = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter(SPName, connStr);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if(para != null)
            {
                da.SelectCommand.Parameters.Add(para);
            }

            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }*/
    }
}
