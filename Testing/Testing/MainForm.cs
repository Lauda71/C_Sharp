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

namespace Testing
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();

            timerCurrentTimeInSystem.Interval = 1000;
            timerCurrentTimeInSystem.Start();
        }        

        private void butReg_Click(object sender, EventArgs e)
        {
            if(tbStudName.Text != "")
            {
                if(tbStudGrId.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int team = 0;
                try
                {
                    team = Convert.ToInt32(tbStudGrId.Text);
                }
                catch
                {
                    MessageBox.Show("ID группы введен некорректно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DB16TestDataSetTableAdapters.StudentsTableAdapter studik = new DB16TestDataSetTableAdapters.StudentsTableAdapter();
                studik.Insert(tbStudName.Text, team);

                MessageBox.Show("Студент добавлен!", "Регистрация выполнена успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (tbLog.Text == "" || tbPas.Text == "" || tbFIO.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbPas.Text.Length < 6 || tbPas.Text.Length > 10)
            {
                MessageBox.Show("Не корректная длина пароля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                char[] password = tbPas.Text.ToArray();
                if (password[0] == '0' || password[0] == '1' || password[0] == '2' || password[0] == '3' || password[0] == '4' || password[0] == '5' || password[0] == '6' || password[0] == '7' || password[0] == '8' || password[0] == '9')
                {
                    MessageBox.Show("Пароль не должен начинаться с цифры!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // проверка на существование таких же
                    string log = tbLog.Text, pass = tbPas.Text, name = tbFIO.Text;

                    DB16TestDataSetTableAdapters.TeachersTableAdapter teacherAdap = new DB16TestDataSetTableAdapters.TeachersTableAdapter();
                    var records = teacherAdap.GetData();
                    var filter = records.Where(p => p.Login == log);

                    if (filter.Count() == 0)
                    {
                        // регистрация
                        teacherAdap.Insert(log, pass, name);

                        tbFIO.Text = "";
                        tbLog.Text = "";
                        tbPas.Text = "";

                        MessageBox.Show("Преподаватель добавлен!", "Регистрация выполнена успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //dgvListTeachers.Refresh();

                    }
                    else
                    {
                        MessageBox.Show("Логин уже занят.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }
           
        private void tbPas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }
                       
        private void MainForm_Load(object sender, EventArgs e)
        {
            DB16TestDataSetTableAdapters.TestsTableAdapter tta = new DB16TestDataSetTableAdapters.TestsTableAdapter();
            var res = tta.GetData();
            var fil = res.Where(p => p.ID_teacher == GlobalClass.idTeacher);

            cbNameTest.Items.Add("Все тесты");
            for (int i = 0; i < fil.Count(); i++)
            {
                cbNameTest.Items.Add(fil.ElementAt(i).Name_test);
            }
            cbNameTest.SelectedIndex = 0;

            DB16TestDataSetTableAdapters.TeamsTableAdapter ta = new DB16TestDataSetTableAdapters.TeamsTableAdapter();
            var ress = ta.GetData();

            cbGroup.Items.Add("Все группы");
            for (int i = 0; i < ress.Count(); i++)
            {
                cbGroup.Items.Add(ress.ElementAt(i).Team);
            }
            cbGroup.SelectedIndex = 0;
            

            cbMark.Items.Add("Все оценки");
            cbMark.Items.Add(5);
            cbMark.Items.Add(4);
            cbMark.Items.Add(3);
            cbMark.Items.Add(2);
            cbMark.SelectedIndex = 0;




            if (lbTestList.SelectedIndex == -1) butEditFast.Enabled = false;


            labHello.Text = "Здравствуйте, " + GlobalClass.nameTeacher + "!";


            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB16TDataSet.Teachers". При необходимости она может быть перемещена или удалена.

            if (GlobalClass.login == "Admin")
            {
                //tpReg.Parent = null;
                tpReg.Parent = mainTC;
            }
            else
            {
                tpReg.Parent = null;
            }

            //this.BackColor = 

            //else if(GlobalClass.login == "") 

            if (GlobalClass.mainBackColor == "SkyBly")
            {
                this.BackColor = Color.SkyBlue;
                this.ForeColor = Color.Black;

                for (int i = 0; i < mainTC.TabCount; i++)
                {
                    mainTC.TabPages[i].BackColor = Color.SkyBlue;
                    mainTC.TabPages[i].ForeColor = Color.Black;
                }
            }
            else if (GlobalClass.mainBackColor == "Firebrick")
            {
                this.BackColor = Color.Firebrick;
                this.ForeColor = Color.White;

                for (int i = 0; i < mainTC.TabCount; i++)
                {
                    mainTC.TabPages[i].BackColor = Color.Firebrick;
                    mainTC.TabPages[i].ForeColor = Color.White;
                }
            }
            else if (GlobalClass.mainBackColor == "SeaGreen")
            {
                this.BackColor = Color.SeaGreen;
                this.ForeColor = Color.Black;

                for (int i = 0; i < mainTC.TabCount; i++)
                {
                    mainTC.TabPages[i].BackColor = Color.SeaGreen;
                    mainTC.TabPages[i].ForeColor = Color.Black;
                }
            }
            else if (GlobalClass.mainBackColor == "Plum")
            {
                this.BackColor = Color.Plum;
                this.ForeColor = Color.Black;

                for (int i = 0; i < mainTC.TabCount; i++)
                {
                    mainTC.TabPages[i].BackColor = Color.Plum;
                    mainTC.TabPages[i].ForeColor = Color.Black;
                }
            }
            else if (GlobalClass.mainBackColor == "Tomato")
            {
                this.BackColor = Color.Tomato;
                this.ForeColor = Color.Black;

                for (int i = 0; i < mainTC.TabCount; i++)
                {
                    mainTC.TabPages[i].BackColor = Color.Tomato;
                    mainTC.TabPages[i].ForeColor = Color.Black;
                }
            }
            else if (GlobalClass.mainBackColor == "Black")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.Gray;

                for (int i = 0; i < mainTC.TabCount; i++)
                {
                    mainTC.TabPages[i].BackColor = Color.Black;
                    mainTC.TabPages[i].ForeColor = Color.Gray;
                }
            }
            else if (GlobalClass.mainBackColor == "WhiteSmoke")
            {
                this.BackColor = Color.WhiteSmoke;
                this.ForeColor = Color.Black;

                for (int i = 0; i < mainTC.TabCount; i++)
                {
                    mainTC.TabPages[i].BackColor = Color.WhiteSmoke;
                    mainTC.TabPages[i].ForeColor = Color.Black;
                }
            }
            //MessageBox.Show(GlobalClass.mainBackColor + GlobalClass.mainForeColor, "Цвета:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            loadTestsInLb();

            if(GlobalClass.login == "Admin")
            {
                DB16TestDataSetTableAdapters.ResultsTableAdapter rez = new DB16TestDataSetTableAdapters.ResultsTableAdapter();
                var resultates = rez.GetData();
                mainDGV.DataSource = resultates;
            }
            else
            {
                mainDGV.DataSource = this.statTableAdapter1.GetDataIdTeacher(GlobalClass.idTeacher);

                mainDGV.Columns[3].Visible = false;
                mainDGV.Columns[4].Visible = false;
                mainDGV.Columns[9].Visible = false;

                //mainDGV.AutoResizeColumns(); 
                mainDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                mainDGV.Columns[0].HeaderText = "Тест";
                mainDGV.Columns[1].HeaderText = "Тем теста";
                mainDGV.Columns[2].HeaderText = "Комментарий";
                mainDGV.Columns[5].HeaderText = "Дата тестирования";
                mainDGV.Columns[6].HeaderText = "Оценка";
                mainDGV.Columns[7].HeaderText = "Студент";
                mainDGV.Columns[8].HeaderText = "Группа";
            }



        }


        private void loadTestsInLb()
        {
            DB16TestDataSetTableAdapters.TestsTableAdapter tsts = new DB16TestDataSetTableAdapters.TestsTableAdapter();
            var inf = tsts.GetData();

            var filter = inf.Where(p => GlobalClass.idTeacher == p.ID_teacher);


            for (int i = 0; i < filter.Count(); i++)
            {
                lbTestList.Items.Add(filter.ElementAt(i).Name_test);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }
        
        private void butDel_Click(object sender, EventArgs e)
        {
            if (tbDelLog.Text == "Admin")
            {
                MessageBox.Show("Насколько бы не был силен Администратор, он никогда не сможет себя уничтожить...", "Обнаружен пространственный парадокс !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                tbDelLog.Text = "";
            }
            else if (tbDelLog.Text == "")
            {
                MessageBox.Show("Не заполнены важные поля", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbDelLog.Text != "")
            {
                string log = tbDelLog.Text;
                DB16TestDataSetTableAdapters.TeachersTableAdapter teacherAdap = new DB16TestDataSetTableAdapters.TeachersTableAdapter();
                var records = teacherAdap.GetData();
                var filter = records.Where(p => p.Login == log);

                if (filter.Count() == 0)
                {
                    MessageBox.Show("Преподаватель не найден.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить преподавателя из системы?", " Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        teacherAdap.Delete(filter.ElementAt(0).ID_Teacher, filter.ElementAt(0).Login, filter.ElementAt(0).Password, filter.ElementAt(0).Name_teacher);
                        MessageBox.Show("Преподаватель утилизирован.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        tbDelLog.Text = "";
                    }
                }
            }
        }

        private void butChangeUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Вы уверены, что хотите сменить пользователя в системе?", " Реавторизация", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                //LoginForm ifrm = new LoginForm();
                Form ifrm = Application.OpenForms[0];
                ifrm.Show();
            }
        }

        private void butCheckListTeachers_Click(object sender, EventArgs e)
        {
            GlobalClass.teachers = true;
            TeachersListForm tlf = new TeachersListForm();
            tlf.ShowDialog();
        }


        int timerCounterSec = 0; //счётчик для таймера
        int timerCounterMin = 0; //счётчик для таймера
        int timerCounterHour = 0; //счётчик для таймера
        private void timerCurrentTimeInSystem_Tick(object sender, EventArgs e)
        {
            timerCounterSec += 1;

            if (timerCounterSec == 60)
            {
                timerCounterMin++;
                timerCounterSec = 0;
            }

            if (timerCounterMin == 60)
            {
                timerCounterMin = 0;
                timerCounterHour++;
            }

            if (timerCounterHour == 0 && timerCounterMin == 0 && timerCounterSec < 10)
            {
                labelCurrentTime.Text = "00:00:0" + (timerCounterSec).ToString();
            }
            else if (timerCounterHour == 0 && timerCounterMin == 0)
            {
                labelCurrentTime.Text = "00:00:" + (timerCounterSec).ToString();
            }
            else if (timerCounterHour == 0 && timerCounterMin < 10 && timerCounterSec < 10)
            {
                labelCurrentTime.Text = "00:0" + (timerCounterMin).ToString() + ":0" + (timerCounterSec).ToString();
            }
            else if (timerCounterHour == 0 && timerCounterMin < 10)
            {
                labelCurrentTime.Text = "00:0" + (timerCounterMin).ToString() + ":" + (timerCounterSec).ToString();
            }
            else if (timerCounterHour == 0)
            {
                labelCurrentTime.Text = "00:" + (timerCounterMin).ToString() + ":" + (timerCounterSec).ToString();
            }
            else if (timerCounterHour < 10)
            {
                labelCurrentTime.Text = "0" + (timerCounterHour).ToString() + ":" + (timerCounterMin).ToString() + ":" + (timerCounterSec).ToString();
            }
            else labelCurrentTime.Text = (timerCounterHour).ToString() + ":" + (timerCounterMin).ToString() + ":" + (timerCounterSec).ToString();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Вы уверены, что хотите выйти из системы?", " Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }

        private void butCreateTest_Click(object sender, EventArgs e)
        {
            // вроде как уже сделано :) QClass.DelQ(); // GlobalClass обнуление переменных и коллекций

            CreateTestForm test = new CreateTestForm();
            //this.Hide();
            test.ShowDialog();
        }

        private void lbTestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbTestList.SelectedIndex != -1)
            {
                butEditFast.Enabled = true;
                butOpenTest.Enabled = true;
                butChangeTest.Enabled = true;
                butDelTest.Enabled = true;


                string nameT = lbTestList.SelectedItem.ToString();

                DB16TestDataSetTableAdapters.TestsTableAdapter tinf = new DB16TestDataSetTableAdapters.TestsTableAdapter();
                var inf = tinf.GetData();
                var filter = inf.Where(p => nameT == p.Name_test);

                GlobalClass.UriHostNameType = nameT;

                infTopic.Text = filter.ElementAt(0).Test_topic;
                infDate.Text = filter.ElementAt(0).Date_create.ToString();
                GlobalClass.ID_test = filter.ElementAt(0).ID_test.ToString().Trim();
                GlobalClass.testsWasBorn = filter.ElementAt(0).Date_create.ToString().Trim();



                string connectionString = Properties.Settings.Default.DB16TestConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(); //Создали
                command.Connection = connection;

                GlobalClass.testsName = filter.ElementAt(0).Name_test;

                string name = GlobalClass.testsName + "_" + GlobalClass.idTeacher;  //Название создаваемой таблицы
                string commandString;
                
                try
                {
                    commandString = "SELECT * FROM " + name;
                    command.CommandText = commandString; //Выполнить команду
                    command.ExecuteNonQuery(); //Выполнить команду без результатов
                }
                catch
                {
                    MessageBox.Show("Ошибка при работе с данными теста.\r\n" +
                                    "Повторите запрос.");
                    connection.Close();
                    return;
                }


                int countTestNum = 0;
                SqlDataReader dataReader = command.ExecuteReader(); //Все записи
                while (dataReader.Read())                   //Перебрать все записи по одной
                {
                    countTestNum++;
                }
                dataReader.Close();
                connection.Close();


                infAmountQ.Text = Convert.ToString(countTestNum);

                infLimTime.Text = filter.ElementAt(0).Time_limit;
                infLimTry.Text = filter.ElementAt(0).Try_limit;
                infLab.Text = filter.ElementAt(0).Comment;
                retLab.Text = filter.ElementAt(0).Test_return_limit;

                GlobalClass.testsComment = filter.ElementAt(0).Comment;
                GlobalClass.testsReturnLimit = filter.ElementAt(0).Test_return_limit;
                GlobalClass.TimeLimit = filter.ElementAt(0).Time_limit;
                GlobalClass.testsTopic = filter.ElementAt(0).Test_topic;
                GlobalClass.tryLimit = filter.ElementAt(0).Try_limit;
                GlobalClass.testsName = filter.ElementAt(0).Name_test;
                GlobalClass.testsWasBorn = Convert.ToString(filter.ElementAt(0).Date_create);

                GlobalClass.selectedIn = lbTestList.SelectedIndex;
            }
            else
            {
                butEditFast.Enabled = false;
                butOpenTest.Enabled = false;
                butChangeTest.Enabled = false;
                butDelTest.Enabled = false;
            }






        }

        private void butEditFast_Click(object sender, EventArgs e)
        {
            if(butEditFast.Text == "Редактировать")
            {
                tbEditComment.Visible = true;
                tbEditReturn.Visible = true;
                tbEditTimeLim.Visible = true;
                tbEditTopic.Visible = true;
                tbEditTryLim.Visible = true;

                butEditFast.Text = "Сохранить";
                butEditFast.ForeColor = Color.Green;

                tbEditComment.Text = infLab.Text.Trim();
                tbEditReturn.Text = retLab.Text.Trim();
                tbEditTimeLim.Text = infLimTime.Text.Trim();
                tbEditTopic.Text = infTopic.Text.Trim();
                tbEditTryLim.Text = infLimTry.Text.Trim();
            }
            else if(butEditFast.Text == "Сохранить")
            {
                tbEditTimeLim.Text = tbEditTimeLim.Text.Trim();
                tbEditTryLim.Text = tbEditTryLim.Text.Trim();
                tbEditReturn.Text = tbEditReturn.Text.Trim();

                if (tbEditTimeLim.Text == "none" || tbEditTimeLim.Text == "")
                {
                    tbEditTimeLim.Text = "none";
                }
                else if (tbEditTimeLim.Text.Length > 3)
                {
                    MessageBox.Show("Слишком некорректное количество минут!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbEditTryLim.Text == "none" || tbEditTryLim.Text == "")
                {
                    tbEditTryLim.Text = "none";
                }
                else if (Convert.ToInt32(tbEditTryLim.Text) > 10)
                {
                    MessageBox.Show("Слишком много попыток!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbEditReturn.Text == "none" || tbEditReturn.Text == "")
                {
                    tbEditReturn.Text = "none";
                }
                else if (tbEditReturn.Text != "1" && tbEditReturn.Text != "2" && tbEditReturn.Text != "3" && tbEditReturn.Text != "5" && tbEditReturn.Text != "10" && tbEditReturn.Text.ToLower() != "все")
                {
                    MessageBox.Show(" Не корректное количество возвратов!\n Введите 1, 2, 3, 5, 10 или все.", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tbEditComment.Text = tbEditComment.Text.Trim();
                tbEditTopic.Text = tbEditTopic.Text.Trim();

                string connectionString = Properties.Settings.Default.DB16TestConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(); //Создали
                command.Connection = connection;

                string name = GlobalClass.testsName + "_" + GlobalClass.idTeacher;  //Название создаваемой таблицы
                string commandString;

                try
                {
                    commandString = "UPDATE Tests SET Test_topic = '" + tbEditTopic.Text + "', Comment = '" + 
                       tbEditComment.Text + "', Time_limit = '" + tbEditTimeLim.Text + "', Try_limit = '" + 
                       tbEditTryLim.Text + "', Test_return_limit = '" + tbEditReturn.Text + "' WHERE ID_test = '" + GlobalClass.ID_test + "';";

                    command.CommandText = commandString; //Выполнить команду
                    command.ExecuteNonQuery(); //Выполнить команду без результатов
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка при обновлении теста.\r\n" +
                                    "Повторите запрос.");
                    connection.Close();
                    return;
                }
                connection.Close();

                //GlobalClass.testsComment = tbEditComment.Text;
                //GlobalClass.testsReturnLimit = tbEditReturn.Text;
                //GlobalClass.TimeLimit = tbEditTimeLim.Text;
                //GlobalClass.testsTopic = tbEditTopic.Text;
                //GlobalClass.tryLimit = tbEditTryLim.Text;


                butEditFast.ForeColor = Color.Black;
                               
                tbEditComment.Visible = false;
                tbEditReturn.Visible = false;
                tbEditTimeLim.Visible = false;
                tbEditTopic.Visible = false;
                tbEditTryLim.Visible = false;

                butEditFast.Text = "Редактировать";
                lbTestList_SelectedIndexChanged(this, e);
            }
        }


        private void tbEditTimeLim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbEditTryLim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            else if(tbEditTryLim.Text.Length == 1 && e.KeyChar != Convert.ToChar(48))
            {
                e.Handled = true;
            }
        }

        private void butChangeTeacher_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Вы уверены, что хотите сменить пользователя?", " Смена пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else { }

            
        }

        private void butChangeTest_Click(object sender, EventArgs e)
        {
            if (lbTestList.SelectedIndex != -1)
            {
                GlobalClass.IcameHereToSaveTheTest = true;
                this.Hide();

                // // //
                string connectionString = Properties.Settings.Default.DB16TestConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(); //Создали
                command.Connection = connection;

                string name = GlobalClass.testsName + "_" + GlobalClass.idTeacher;  //Название таблицы, откуда будем брать всю информацию (вопросы, ответы)
                string commandString;

                try
                {
                    commandString = "SELECT * FROM " + name;
                    command.CommandText = commandString; //Выполнить команду
                    command.ExecuteNonQuery(); //Выполнить команду без результатов
                }
                catch
                {
                    MessageBox.Show("Ошибка при работе с данными теста.\r\n" +
                                    "Повторите запрос.");
                    connection.Close();
                    return;
                }

                QClass.DelQ();

                //int countTestNum = 0;
                SqlDataReader dataReader = command.ExecuteReader(); //Все записи
                while (dataReader.Read())                   //Перебрать все записи по одной
                {
                    QClass.localQN.Add(Convert.ToInt32(dataReader["Number_question"]));
                    QClass.localQT.Add(Convert.ToString(dataReader["Type_question"]));
                    QClass.localQ.Add(Convert.ToString(dataReader["Text_question"]));
                    QClass.localA.Add(Convert.ToString(dataReader["Answers"]));
                    QClass.localQPic.Add(Convert.ToString(dataReader["Picture"]));
                }
                dataReader.Close();
                connection.Close();
                // // //
                

                CreateTestForm ctf = new CreateTestForm();
                ctf.ShowDialog();
            }
            
        }

        private void butDelTest_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.DB16TestConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(); //Создали
            command.Connection = connection;

            string name = GlobalClass.testsName + "_" + GlobalClass.idTeacher;  //Название создаваемой таблицы
            string commandString;

            commandString = "DELETE FROM Tests WHERE Name_test = '" + GlobalClass.testsName + "'"; // удаление записей в таблице

            command.CommandText = commandString;
            command.ExecuteNonQuery(); //Выполнить команду без результатов

            commandString = "";



            commandString = "DROP TABLE " + GlobalClass.testsName + "_" + GlobalClass.idTeacher; // удаление записей в таблице

            command.CommandText = commandString;
            command.ExecuteNonQuery(); //Выполнить команду без результатов

            commandString = "";

            lbTestList.Items.RemoveAt(lbTestList.SelectedIndex);

        }

        private void butShowMeRes_Click(object sender, EventArgs e)
        {

            if(cbMark.SelectedIndex != 0 && cbGroup.SelectedIndex != 0 && cbNameTest.SelectedIndex != 0) // все 3 параметра
            {
                mainDGV.DataSource = this.statTableAdapter1.GetOverHere(GlobalClass.idTeacher, cbNameTest.Text, Convert.ToInt32(cbMark.Text), Convert.ToInt32(cbGroup.Text));
                //mainDGV.DataSource = this.statTableAdapter1.GetDataMark(GlobalClass.idTeacher, Convert.ToInt32(cbMark.Text));
            }


            else if (cbMark.SelectedIndex == 0 && cbGroup.SelectedIndex == 0 && cbNameTest.SelectedIndex != 0) // только имя 
            {
                mainDGV.DataSource = this.statTableAdapter1.GetDataTestName(GlobalClass.idTeacher, cbNameTest.Text);
            }
            else if (cbMark.SelectedIndex != 0 && cbGroup.SelectedIndex == 0 && cbNameTest.SelectedIndex == 0) // только оценка
            {
                mainDGV.DataSource = this.statTableAdapter1.GetDataMark(GlobalClass.idTeacher, Convert.ToInt32(cbMark.Text));
            }
            else if (cbMark.SelectedIndex == 0 && cbGroup.SelectedIndex != 0 && cbNameTest.SelectedIndex == 0) // только группа
            {
                mainDGV.DataSource = this.statTableAdapter1.GetDataGroup(GlobalClass.idTeacher, Convert.ToInt32(cbGroup.Text));
            }


            else if (cbMark.SelectedIndex == 0 && cbGroup.SelectedIndex != 0 && cbNameTest.SelectedIndex != 0) // имя * группа
            {
                mainDGV.DataSource = this.statTableAdapter1.GetDataTestTeam(GlobalClass.idTeacher, cbNameTest.Text, Convert.ToInt32(cbGroup.Text));
            }
            else if (cbMark.SelectedIndex != 0 && cbGroup.SelectedIndex == 0 && cbNameTest.SelectedIndex != 0) //  имя * оценка
            {
                mainDGV.DataSource = this.statTableAdapter1.GetDataTestMark(GlobalClass.idTeacher, cbNameTest.Text, Convert.ToInt32(cbMark.Text));
            }
            else if (cbMark.SelectedIndex != 0 && cbGroup.SelectedIndex != 0 && cbNameTest.SelectedIndex == 0) // оценка * группа
            {
                mainDGV.DataSource = this.statTableAdapter1.GetDataMarkTeam(GlobalClass.idTeacher, Convert.ToInt32(cbMark.Text), Convert.ToInt32(cbGroup.Text));
            }
        }

        private void butDelS_Click(object sender, EventArgs e)
        {
            if(tbStudentDel.Text == "" || tbStudentGrDel.Text == "")
            {
                MessageBox.Show("Не все поля заполнены", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int idGr = Convert.ToInt32(tbStudentGrDel.Text);
                }
                catch
                {
                    MessageBox.Show("Не корректно введен ID группы", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DB16TestDataSetTableAdapters.StudentsTableAdapter st = new DB16TestDataSetTableAdapters.StudentsTableAdapter();
                var s = st.GetData();
                var fltr = s.Where(p => p.Name_student == tbStudentDel.Text);
                if(fltr.Count() == 0)
                {
                    MessageBox.Show("Студент не найден", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                st.Delete(fltr.ElementAt(0).ID_student, Convert.ToInt32(tbStudentGrDel.Text));

                MessageBox.Show("Студент уничтожен", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbStudName_TextChanged(object sender, EventArgs e)
        {
            tbLog.Text = "";
            tbPas.Text = "";
            tbFIO.Text = "";
        }

        private void tbLog_TextChanged(object sender, EventArgs e)
        {
            tbStudName.Text = "";
            tbStudGrId.Text = "";
        }

        private void butStudList_Click(object sender, EventArgs e)
        {
            GlobalClass.teachers = false;
            TeachersListForm tlf = new TeachersListForm();
            tlf.ShowDialog();
        }
    }
}
