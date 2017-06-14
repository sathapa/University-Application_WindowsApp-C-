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
    public partial class ViewStudents : Form
    {
        public string department { get { return this.cmbDpt.GetItemText(this.cmbDpt.SelectedItem); } }
        public ViewStudents()
        {
            InitializeComponent();
        }
    }
}
