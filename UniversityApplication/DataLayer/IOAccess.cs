using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityApplication
{
    class IOAccess
    {
        OpenFileDialog ofd = new OpenFileDialog();

        public void DataRead(string sstr)
        {
            ofd.InitialDirectory = "D:\\Academic\\Sem III\\Windows\\Homeworks\\Homework7\\Text_Files";
            ofd.Filter = "text files|*.txt|docx files|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                FileInfo fi = new FileInfo(filename);
                Stream str = fi.Open(FileMode.Open, FileAccess.Read);
                StreamReader sstr1 = new StreamReader(str);
            }
        }
    }
}
