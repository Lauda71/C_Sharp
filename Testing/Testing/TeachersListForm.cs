using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class TeachersListForm : Form
    {
        public TeachersListForm()
        {
            InitializeComponent();
        }

        private void TeachersListForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(GlobalClass.mainBackColor);
            this.ForeColor = Color.FromName(GlobalClass.mainForeColor);

            if(GlobalClass.teachers)
            {
                DB16TestDataSetTableAdapters.TeachersTableAdapter t = new DB16TestDataSetTableAdapters.TeachersTableAdapter();
                var rec = t.GetData();
                this.dgvListTeachers.DataSource = rec;
            }
            else
            {
                DB16TestDataSetTableAdapters.StudentsTableAdapter s = new DB16TestDataSetTableAdapters.StudentsTableAdapter();
                var rec = s.GetData();
                this.dgvListTeachers.DataSource = rec;
            }
            

            //DB16TDataSetTableAdapters.TeachersTableAdapter teacherAdap = new DB16TDataSetTableAdapters.TeachersTableAdapter();
            //var rec = teacherAdap.GetData();

            //this.dgvListTeachers.DataSource = rec;

        }
    }
}
