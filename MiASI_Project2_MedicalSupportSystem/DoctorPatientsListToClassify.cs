using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MiASI_Project2_MedicalSupportSystem
{
    public partial class DoctorPatientsListToClassify : Form
    {
        public static string clickedUserID;
        public static string clickedUserLogin;
        public static string clickedUserName;
        public static string clickedUserSurname;
        public static string clickedUserPesel;
        public static ArrayList usersIDsList = new ArrayList();
        public static ArrayList usersLoginsList = new ArrayList();
        public static ArrayList usersNamesList = new ArrayList();
        public static ArrayList usersLastNamesList = new ArrayList();
        public static ArrayList usersPeselsList = new ArrayList();
        public DoctorPatientsListToClassify()
        {
            InitializeComponent();
            loginName_LB.Text = Login.loginDisplay;
            usersIDsList.Clear();
            usersLoginsList.Clear();
            usersNamesList.Clear();
            usersLastNamesList.Clear();
            usersPeselsList.Clear();

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false;";
            SqlConnection cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT u.UserID, UserLogin, UserName, UserLastName, UserPesel FROM Project2.dbo.Users as u INNER JOIN Project2.dbo.Samples as s ON s.UserID = u.UserID WHERE u.RoleID LIKE '1' INTERSECT SELECT u.UserID, UserLogin, UserName, UserLastName, UserPesel FROM Project2.dbo.Users as u INNER JOIN Project2.dbo.Samples as s ON s.UserID = u.UserID WHERE s.Outcome IS NULL", cnn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    noData_LB.Visible = false;
                    patientsListToClasify_FL.Visible = true;

                    usersIDsList.Add(dataReader[0].ToString());
                    usersLoginsList.Add(dataReader[1].ToString());
                    usersNamesList.Add(dataReader[2].ToString());
                    usersLastNamesList.Add(dataReader[3].ToString());
                    usersPeselsList.Add(dataReader[4].ToString());

                }
                cmd.Dispose();
                dataReader.Close();

                for (int i = 0; i < usersNamesList.Count; i++)
                {
                    Button button = new Button();
                    button.Tag = i;
                    button.Name = (i).ToString() + "_BTN";
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.AutoSize = false;
                    button.Height = 50;
                    button.Width = 645;
                    button.Text = (usersNamesList[i].ToString() + " " + usersLastNamesList[i].ToString() + " | PESEL: " + usersPeselsList[i].ToString());
                    patientsListToClasify_FL.Controls.Add(button);
                    button.Click += new EventHandler(this.button_click);

                    //patientsList_FP.AutoScroll = false;
                    //patientsList_FP.VerticalScroll.Maximum = 0;
                    //patientsList_FP.VerticalScroll.Visible = false;
                    //patientsList_FP.HorizontalScroll.Maximum = 0;
                    //patientsList_FP.HorizontalScroll.Visible = false;
                    //patientsList_FP.AutoScroll = true;
                }

                if (usersNamesList.Count == 0)
                {
                    noData_LB.Visible = true;
                    patientsListToClasify_FL.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string buttonName = btn.Name.ToString();
            int buttonNumber = int.Parse(buttonName.Substring(0, 1));

            clickedUserID = usersIDsList[buttonNumber].ToString();
            clickedUserName = usersNamesList[buttonNumber].ToString();
            clickedUserSurname = usersLastNamesList[buttonNumber].ToString();
            clickedUserLogin = usersLoginsList[buttonNumber].ToString();
            clickedUserPesel = usersPeselsList[buttonNumber].ToString();

            this.Hide();
            DoctorPatientDetailsToClassify patientClassify = new DoctorPatientDetailsToClassify();
            patientClassify.ShowDialog();
            this.Close();
        }

        private void loginName_LB_MouseEnter(object sender, EventArgs e)
        {
            loginName_LB.Font = new Font(loginName_LB.Font, FontStyle.Underline);
        }

        private void loginName_LB_MouseLeave(object sender, EventArgs e)
        {
            loginName_LB.Font = new Font(loginName_LB.Font, FontStyle.Regular);
        }

        private void loginName_LB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void backHomeDoctor_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorHome docHome = new DoctorHome();
            docHome.ShowDialog();
            this.Close();
        }
    }
}
