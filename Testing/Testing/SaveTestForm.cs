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
    public partial class SaveTestForm : Form
    {
        //GlobalClass.EditTableMode


        public SaveTestForm()
        {
            InitializeComponent();            
        }

        private void SaveTestForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(GlobalClass.mainBackColor);
            this.ForeColor = Color.FromName(GlobalClass.mainForeColor);


            string[] tryLim = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            for (int i = 0; i < tryLim.Length; i++)
            {
                cbTryLim.Items.Add(tryLim[i]);
            }

            string[] retAbility = { "1", "2", "3", "5", "10", "все" };
            for (int i = 0; i < retAbility.Length; i++)
            {
                cbReturnAbility.Items.Add(retAbility[i]);
            }

            if (GlobalClass.EditTableMode)
            {
                tbNameTest.Text = GlobalClass.testsName;
                tbTopicTest.Text = GlobalClass.testsTopic;

                if (GlobalClass.TimeLimit != "none")
                {
                    tbTimeLim.Text = GlobalClass.TimeLimit;
                    chbTime.Checked = true;
                }
                else tbTimeLim.Text = "";

                //
                

                //


                if (GlobalClass.testsComment != "none") tbCommentTest.Text = GlobalClass.testsComment;
                else tbCommentTest.Text = "";

                labDateCreateQ.Text = GlobalClass.testsWasBorn;
            }
            else
            {
                

                labDateCreateQ.Text = DateTime.Now.ToShortDateString();
            }

            labAmountQQ.Text = Convert.ToString(GlobalClass.questionsInTest);

            

            this.BackColor = Color.FromName(GlobalClass.mainBackColor);
            this.ForeColor = Color.FromName(GlobalClass.mainForeColor);

            
        }

        private void tbTimeLim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            else if(tbTimeLim.TextLength >= 3) e.Handled = true;
        }

        private void chbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTime.Checked)
            {
                tbTimeLim.Enabled = true;
                labTimeLim.Enabled = true;
                labMin.Enabled = true;
            }
            else
            {
                tbTimeLim.Enabled = false;
                labTimeLim.Enabled = false;
                labMin.Enabled = false;
            }
        }

        private void chbTry_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTry.Checked)
            {
                labTryLimit.Enabled = true;
                cbTryLim.Enabled = true;
            }
            else
            {
                labTryLimit.Enabled = false;
                cbTryLim.Enabled = false;
            }
        }

        private void butSaveTest_Click(object sender, EventArgs e)
        {
            tbNameTest.Text = tbNameTest.Text.Trim();
            tbTopicTest.Text = tbTopicTest.Text.Trim();

            if (tbNameTest.Text == "" || tbTopicTest.Text == "")
            {
                MessageBox.Show("Не заполнены важные поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(chbReturnAbility.Checked)
                {
                    string[] retAbility = { "1", "2", "3", "5", "10", "все" };
                    switch (cbReturnAbility.SelectedIndex)
                    {
                        case 0:
                            GlobalClass.testsReturnLimit = retAbility[cbReturnAbility.SelectedIndex];
                            break;
                        case 1:
                            GlobalClass.testsReturnLimit = retAbility[cbReturnAbility.SelectedIndex];
                            break;
                        case 2:
                            GlobalClass.testsReturnLimit = retAbility[cbReturnAbility.SelectedIndex];
                            break;
                        case 3:
                            GlobalClass.testsReturnLimit = retAbility[cbReturnAbility.SelectedIndex];
                            break;
                        case 4:
                            GlobalClass.testsReturnLimit = retAbility[cbReturnAbility.SelectedIndex];
                            break;
                        case 5:
                            GlobalClass.testsReturnLimit = retAbility[cbReturnAbility.SelectedIndex];
                            break;
                        case 6:
                            GlobalClass.testsReturnLimit = retAbility[cbReturnAbility.SelectedIndex];
                            break;
                    }
                }
                else
                {
                    GlobalClass.testsReturnLimit = "none";
                }

                if(chbTime.Checked)
                {
                    GlobalClass.TimeLimit = tbTimeLim.Text;
                }
                else {
                    GlobalClass.TimeLimit = "none";
                }

                if(chbTry.Checked)
                {
                    GlobalClass.tryLimit = cbTryLim.Text;
                }
                else
                {
                    GlobalClass.tryLimit = "none";
                }


                GlobalClass.testsName = tbNameTest.Text;
                GlobalClass.testsTopic = tbTopicTest.Text;
                GlobalClass.testsWasBorn = labDateCreateQ.Text;
                GlobalClass.testsComment = tbCommentTest.Text;
                if (GlobalClass.testsComment == "") GlobalClass.testsComment = "none";

                // // // //     ! ! !
                string connectionString = Properties.Settings.Default.DB16TestConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(); //Создали
                command.Connection = connection;

                string name = GlobalClass.testsName + "_" + GlobalClass.idTeacher;  //Название создаваемой таблицы
                string commandString;               //Строка запроса


                if (GlobalClass.EditTableMode == false)
                {


                    try
                    {
                        commandString = "CREATE TABLE " + name + //Информация о таблице
                                                                 //Описание полей таблицы
                                       "([Number_question] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, " +
                                       "[Type_question] nvarchar(50) NOT NULL," +
                                       "[Text_question] nvarchar(100) NOT NULL," +
                                       "[Answers] nvarchar(100) NOT NULL," +
                                       "[Picture] nvarchar(50) NOT NULL)";
                        command.CommandText = commandString; //Выполнить команду
                        command.ExecuteNonQuery(); //Выполнить команду без результатов
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при сохранении теста.\r\n" +
                                        "Такой тест уже существует в базе.\r\n"+
                                        "Повторите сохранение.");
                        connection.Close();
                        return;
                    }

                }
                else
                { //DELETE FROM
                    commandString = "DELETE FROM " + name; // удаление записей в таблице

                    command.CommandText = commandString;
                    command.ExecuteNonQuery(); //Выполнить команду без результатов

                    commandString = "";


                    commandString = "DELETE FROM Tests WHERE Name_test = '" + GlobalClass.testsName + "'"; // удаление записей в таблице

                    command.CommandText = commandString;
                    command.ExecuteNonQuery(); //Выполнить команду без результатов

                    commandString = "";
                }
                try
                {
                    for (int i = 0; i < QClass.localQN.Count; i++)
                    {
                        commandString = "INSERT INTO " + name +
                        "([Type_question], [Text_question], [Answers], [Picture]) " +
                        "VALUES('" + QClass.localQT.ElementAt(i) + "','" + QClass.localQ.ElementAt(i) + "','" + QClass.localA.ElementAt(i) + "','" + QClass.localQPic.ElementAt(i) + "')";
                        command.CommandText = commandString;
                        command.ExecuteNonQuery(); //Выполнить команду без результатов

                        commandString = "";
                    }
                    // или
                    //int result1 = command.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Тест сохранен ", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка при сохранении данных теста.\r\n" +
                                    "Повторите сохранение.");
                    connection.Close();
                    return;
                }


                DB16TestDataSetTableAdapters.TestsTableAdapter ts = new DB16TestDataSetTableAdapters.TestsTableAdapter();
                ts.Insert(GlobalClass.idTeacher, GlobalClass.testsName, DateTime.Now, GlobalClass.testsTopic, GlobalClass.testsComment, GlobalClass.TimeLimit, GlobalClass.tryLimit, GlobalClass.testsReturnLimit);
                



                //try
                //{
                //    commandString = "INSERT INTO Tests" +
                //        "([ID_teacher], [Name_test], [Date_create], [Test_topic], [Comment], [Time_limit], [Try_limit], [Test_return_limit]) " +
                //        "VALUES('" + GlobalClass.idTeacher + "','" + GlobalClass.testsWasBorn + "','" + GlobalClass.testsTopic + "','" + GlobalClass.testsComment + "','" + GlobalClass.TimeLimit + "','" + GlobalClass.tryLimit + "','" + GlobalClass.testsReturnLimit + "')";
                //    command.CommandText = commandString;
                //    command.ExecuteNonQuery(); //Выполнить команду без результатов
                //}
                //catch
                //{
                //    MessageBox.Show("Ошибка при сохранении данных в таблицу Tests.\r\n" +
                //                    "Повторите сохранение.");
                //    connection.Close();
                //    return;
                //}


                // // // //

                QClass.DelQ();

                //QClass.save = false; что это??

                this.Close();
            }            
        }

        private void butClearAll_Click(object sender, EventArgs e)
        {
            tbNameTest.Text = "";
            tbTopicTest.Text = "";
            tbCommentTest.Text = "";
            tbTimeLim.Text = "";

            cbTryLim.SelectedIndex = -1;
            cbReturnAbility.SelectedIndex = -1;

            chbTime.Checked = false;
            chbTry.Checked = false;
            chbReturnAbility.Checked = false;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Вы действительно хотите выйти из окна сохранения?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); if (result == DialogResult.Yes)
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void cbTryLim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            else if (tbTimeLim.TextLength >= 2) e.Handled = true;
        }

        private void labTimeLim_Click(object sender, EventArgs e)
        {
            chbTime.Checked = true;
        }

        private void labTryLimit_Click(object sender, EventArgs e)
        {
            chbTry.Checked = true;
        }

        private void chbReturnAbility_CheckedChanged(object sender, EventArgs e)
        {
            if (chbReturnAbility.Checked)
            {
                labReturnAbility.Enabled = true;
                cbReturnAbility.Enabled = true;
            }
            else
            {
                labReturnAbility.Enabled = false;
                cbReturnAbility.Enabled = false;
            }
        }

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

        private void labReturnAbility_Click(object sender, EventArgs e)
        {
            chbReturnAbility.Checked = true;
        }
    }
}
