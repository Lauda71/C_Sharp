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
    public partial class FinalresultTest : Form
    {
        public FinalresultTest()
        {
            InitializeComponent();
        }

        private void FinalresultTest_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(GlobalClass.mainBackColor);
            this.ForeColor = Color.FromName(GlobalClass.mainForeColor);

            labName.Text = GlobalClass.studentName;
            labGr.Text = Convert.ToString(GlobalClass.group);
            labTest.Text = GlobalClass.testsName;
            labDate.Text = Convert.ToString(DateTime.Now);

            GlobalClass.End();

            labMark.Text = Convert.ToString(GlobalClass.mark);

            labQAmount.Text = Convert.ToString(GlobalClass.all);
            labRightQ.Text = Convert.ToString(GlobalClass.good) + " (" + Convert.ToString(GlobalClass.percentGood) + " %)"; //56%       56 %
            labFalseQ.Text = Convert.ToString(GlobalClass.bad) + " (" + Convert.ToString(GlobalClass.percentBad) + " %)";


            // сохранение результатов прохождения теста в БД

            string connectionString = Properties.Settings.Default.DB16TestConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(); //Создали
            command.Connection = connection;

            string name = GlobalClass.testsName + "_" + GlobalClass.idTeacher;  //Название создаваемой таблицы
            string commandString;

            try
            {
                commandString = "INSERT INTO Results" +
                        "([ID_student], [ID_test], [Date_testing], [Mark]) " +
                        "VALUES('" + GlobalClass.studIdentifier + "','" + GlobalClass.testIdentifier + "','" + DateTime.Now + "','" + GlobalClass.mark + "')";
                command.CommandText = commandString;
                command.ExecuteNonQuery(); //Выполнить команду без результатов

                commandString = "";
                connection.Close();
                MessageBox.Show("Результаты теста сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении данных.\r\n" + "Повторите сохранение.");
                connection.Close();
                return;
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();

            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void butAgain_Click(object sender, EventArgs e)
        {
            this.Close();

            HereTheTestBegins testik = new HereTheTestBegins();
            testik.Show();
            this.Hide();
        }
    }
}
