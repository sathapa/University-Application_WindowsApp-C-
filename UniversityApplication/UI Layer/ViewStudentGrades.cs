using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityApplication
{
    public partial class ViewStudentGrades : Form
    {
        public string StudentID
        {
            get { return txtStudentID.Text; }
        }
        public ViewStudentGrades()
        {
            InitializeComponent();
        }

    }
}
