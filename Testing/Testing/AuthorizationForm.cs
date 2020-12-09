using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Testing
{
    public partial class LoginForm : Form
    {

        
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void rbT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbT.Checked)
            {
                panS.Enabled = false;
                panT.Enabled = true;
                //cbGroupNumber.Text = "";
                tbNameS.Text = "";
            }
            else
            {
                panT.Enabled = false;
                panS.Enabled = true;
                tbLoginT.Text = "";
                tbPasswordT.Text = "";

                DB16TestDataSetTableAdapters.TeamsTableAdapter tm = new DB16TestDataSetTableAdapters.TeamsTableAdapter();
                var records = tm.GetData();

                cbGroupNumber.DataSource = records;
                cbGroupNumber.DisplayMember = "Team";
                cbGroupNumber.ValueMember = "ID_team";
                cbGroupNumber.SelectedIndex = -1;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            rbS.Checked = true;
            panT.Enabled = false;

            this.BackColor = Color.SkyBlue;
            this.ForeColor = Color.Black;

            GlobalClass.connectionString = Properties.Settings.Default.DB16TestConnectionString;



            DB16TestDataSetTableAdapters.TeamsTableAdapter tm = new DB16TestDataSetTableAdapters.TeamsTableAdapter();
            var records = tm.GetData();

            cbGroupNumber.DataSource = records;
            cbGroupNumber.DisplayMember = "Team";
            cbGroupNumber.ValueMember = "ID_team";
            cbGroupNumber.SelectedIndex = -1;

            DB16TestDataSetTableAdapters.TestsTableAdapter ts = new DB16TestDataSetTableAdapters.TestsTableAdapter();
            var rec = ts.GetData();

            cbTest.DataSource = rec;
            cbTest.DisplayMember = "Name_test";
            cbTest.ValueMember = "ID_test";
            cbTest.SelectedIndex = -1;

            go = true;
        }
        int thatTest = 0;

        int countTBpass = 0;
        
        private void butEntry_Click(object sender, EventArgs e)
        {
            if (rbS.Checked == true)
            {
                if (tbNameS.Text == "")
                {
                    MessageBox.Show("Введите имя!", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (cbGroupNumber.SelectedIndex == -1)
                {
                    MessageBox.Show("Укажите номер группы!", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (cbTest.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите тест!", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                
                DB16TestDataSetTableAdapters.StudentsTableAdapter stud = new DB16TestDataSetTableAdapters.StudentsTableAdapter();
                var rr = stud.GetData();
                var ff = rr.Where(p => p.Name_student == tbNameS.Text && p.ID_team == Convert.ToInt32(cbGroupNumber.SelectedValue));

                if(ff.Count() == 0)
                {
                    MessageBox.Show("Студентов в базе с Вашим именем не обнаружено!", "Кто ты такой", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //labTeacherCreator.Text = "";

                GlobalClass.studentName = tbNameS.Text; // Имя студента
                GlobalClass.group = Convert.ToInt32(cbGroupNumber.Text); // № группы студента
                GlobalClass.testIdentifier = Convert.ToInt32(cbTest.SelectedValue.ToString()); // ID выбранного теста
                GlobalClass.testsName = cbTest.Text;

                //MessageBox.Show("Имя: " + GlobalClass.studentName + ", \nГруппа: " + GlobalClass.group + ", \nТест ID: " + GlobalClass.testIdentifier, "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;

                //DB16TestDataSetTableAdapters.StudentsTableAdapter groupAdap = new DB16TestDataSetTableAdapters.StudentsTableAdapter();
                //var records = groupAdap.GetData();
                //var filter = records.Where(p => p.ID_team == gr && p.Name_student == nameStudent);



                //MessageBox.Show("ID выбранного теста: " + cbTest.SelectedValue, "Информация... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
                GlobalClass.mainBackColor = (Convert.ToString((this.BackColor)).Remove(Convert.ToString(this.BackColor).Length - 1)).Remove(0, 7);
                GlobalClass.mainForeColor = (Convert.ToString((this.ForeColor)).Remove(Convert.ToString(this.ForeColor).Length - 1)).Remove(0, 7);


                GlobalClass.testIdentifier = Convert.ToInt32(cbTest.SelectedValue);
                GlobalClass.studIdentifier = ff.ElementAt(0).ID_student;

                HereTheTestBegins testik = new HereTheTestBegins();
                testik.Show();
                this.Hide();

            }
            else
            {
                if (tbLoginT.Text == "")
                {
                    MessageBox.Show("Введите логин!", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbPasswordT.Text == "")
                {
                    MessageBox.Show("Введите пароль!", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DB16TestDataSetTableAdapters.TeachersTableAdapter teach = new DB16TestDataSetTableAdapters.TeachersTableAdapter();

                string log = tbLoginT.Text, pass = tbPasswordT.Text;

                var records = teach.GetData();
                var filter = records.Where(p => p.Login == log && p.Password == pass);

                if (filter.Count() == 0)
                {
                    MessageBox.Show("Не верный логин или пароль.", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    if (filter.ElementAt(0).Name_teacher == "Administrator")
                    {
                        MessageBox.Show("Добро пожаловать домой, мастер.", "Вход выполнен", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Вы успешно авторизовались", "Вход выполнен", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    ///////////////
                    GlobalClass.idTeacher = filter.ElementAt(0).ID_Teacher;
                    GlobalClass.nameTeacher = filter.ElementAt(0).Name_teacher;
                    GlobalClass.login = filter.ElementAt(0).Login;
                    GlobalClass.pass = filter.ElementAt(0).Password;


                    GlobalClass.mainBackColor = (Convert.ToString((this.BackColor)).Remove(Convert.ToString(this.BackColor).Length - 1)).Remove(0, 7);
                    GlobalClass.mainForeColor = (Convert.ToString((this.ForeColor)).Remove(Convert.ToString(this.ForeColor).Length - 1)).Remove(0, 7);


                    cbGroupNumber.Text = "";
                    tbNameS.Text = "";
                    tbLoginT.Text = "";
                    tbPasswordT.Text = "";

                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.ShowDialog();
                }
            }


        }

        private void tbPasswordT_KeyPress(object sender, KeyPressEventArgs e)
        {
            countTBpass++;
            if (countTBpass % 2 == 0)
            {
                tbPasswordT.PasswordChar = '◪';
            }
            else
            {
                tbPasswordT.PasswordChar = '◩';
            }

            if (e.KeyChar == 13)
            {
                this.butEntry_Click(this, e);
            }
        }

        private void rbColorStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbColorStandard.Checked)
            {
                this.BackColor = Color.SkyBlue;
                this.ForeColor = Color.Black;
                butEntry.ForeColor = Color.Black;
                gbDesignSelection.ForeColor = Color.Black;
            }
        }

        private void rbColorRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbColorRed.Checked)
            {
                this.BackColor = Color.Firebrick;
                this.ForeColor = Color.White;
                butEntry.ForeColor = Color.Black;
                gbDesignSelection.ForeColor = Color.White;
            }
        }

        private void rbColorGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbColorGreen.Checked)
            {
                this.BackColor = Color.SeaGreen;
                this.ForeColor = Color.Black;
                butEntry.ForeColor = Color.Black;
                gbDesignSelection.ForeColor = Color.Black;
            }
        }

        private void rbColorPink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbColorPink.Checked)
            {
                this.BackColor = Color.Plum;
                this.ForeColor = Color.Black;
                butEntry.ForeColor = Color.Black;
                gbDesignSelection.ForeColor = Color.Black;
            }
        }

        private void rbColorOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbColorOrange.Checked)
            {
                this.BackColor = Color.Tomato;
                this.ForeColor = Color.Black;
                butEntry.ForeColor = Color.Black;
                gbDesignSelection.ForeColor = Color.Black;
            }
        }

        private void rbColorDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rbColorDark.Checked)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.Gray;
                butEntry.ForeColor = Color.Black;
                gbDesignSelection.ForeColor = Color.Gray;
            }
        }

        private void rbColorLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbColorLight.Checked)
            {
                this.BackColor = Color.WhiteSmoke;
                this.ForeColor = Color.Black;
                butEntry.ForeColor = Color.Black;
                gbDesignSelection.ForeColor = Color.Black;
            }
        }

        private void tbLoginT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.butEntry_Click(this, e);
            }
        }

        private void tbNameS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.butEntry_Click(this, e);
            }
        }


        // УБРАТЬ
        private void button1_Click(object sender, EventArgs e)
        {
            rbT.Checked = true;
            tbLoginT.Text = "Admin";
            tbPasswordT.Text = "passAdmin";

            this.butEntry_Click(this, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rbT.Checked = true;
            tbLoginT.Text = "Goodness";
            tbPasswordT.Text = "passGood";

            this.butEntry_Click(this, e);
        }


        // НЕ УБИРАТЬ
        private void cbh_DrawItem(object sender, DrawItemEventArgs e)
        {
            // By using Sender, one method could handle multiple ComboBoxes
            ComboBox cbx = sender as ComboBox;
            if (cbx != null)
            {
                // Always draw the background
                e.DrawBackground();

                // Drawing one of the items?
                if (e.Index >= 0)
                {
                    // Set the string alignment.  Choices are Center, Near and Far
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;

                    // Set the Brush to ComboBox ForeColor to maintain any ComboBox color settings
                    // Assumes Brush is solid
                    Brush brush = new SolidBrush(cbx.ForeColor);

                    // If drawing highlighted selection, change brush
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        brush = SystemBrushes.HighlightText;

                    // Draw the string
                    e.Graphics.DrawString(cbx.Items[e.Index].ToString(), cbx.Font, brush, e.Bounds, sf);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rbS.Checked = true;
            tbNameS.Text = "Лапунов Лев";
            cbTest.SelectedIndex = 2;
            cbGroupNumber.SelectedIndex = 0;

            this.butEntry_Click(this, e);
        }

        bool go = false;
        private void cbTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (go)
            {
                //MessageBox.Show(Convert.ToString(cbTest.SelectedValue), "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                thatTest = Convert.ToInt32(cbTest.SelectedValue);

                DB16TestDataSetTableAdapters.TestsTableAdapter tttt = new DB16TestDataSetTableAdapters.TestsTableAdapter();
                var rec = tttt.GetData();
                var fltr = rec.Where(p => p.ID_test == thatTest);

                DB16TestDataSetTableAdapters.TeachersTableAdapter tta = new DB16TestDataSetTableAdapters.TeachersTableAdapter();
                var recc = tta.GetData();
                var ffltr = recc.Where(k => k.ID_Teacher == fltr.ElementAt(0).ID_teacher);

                labTeacherCreator.Text = ffltr.ElementAt(0).Name_teacher;
            }

        }
    }    
}
