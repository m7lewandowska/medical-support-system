using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MiASI_Project2_MedicalSupportSystem
{
    public partial class DoctorShowPatientDetails : Form
    {
        public static string userLogin;
        public DoctorShowPatientDetails()
        {
            InitializeComponent();
            loginName_LB.Text = Login.loginDisplay;
            userLogin = DoctorShowPatientsList.clickedUserLogin;
            patientDetailsName_LB.Text = $"{DoctorShowPatientsList.clickedUserName} {DoctorShowPatientsList.clickedUserSurname}";

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false;";
            SqlConnection cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Pregnancies,Glucose,BloodPressure,SkinThickness,Insulin,BMI,DiabetesPedigree,Age,Outcome FROM Project2.dbo.Samples as s INNER JOIN Project2.dbo.Users as u ON s.UserID = u.UserID where u.UserLogin Like '{userLogin}'", cnn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    noData_LB.Visible = false;

                    pregnancies_TB.Text = dataReader[0].ToString();
                    glucose_TB.Text = dataReader[1].ToString();
                    bloodPressure_TB.Text = dataReader[2].ToString();
                    skinThickness_TB.Text = dataReader[3].ToString();
                    insulin_TB.Text = dataReader[4].ToString();
                    bmi_TB.Text = dataReader[5].ToString();
                    diabetesPedigree_TB.Text = dataReader[6].ToString();
                    age_TB.Text = dataReader[7].ToString();

                    if(string.IsNullOrEmpty(dataReader[8].ToString()))
                    {
                        patientOutcome_LB.Text = "NOT DIAGNOSED";
                        patientOutcome_LB.ForeColor = Color.FromArgb(0, 163, 136);
                    }
                    else if (dataReader[8].ToString() == "True")
                    {
                        patientOutcome_LB.Text = "DIABETES";
                        patientOutcome_LB.ForeColor = Color.FromArgb(194, 43, 63);
                    }
                    else if (dataReader[8].ToString() == "False")
                    {
                        patientOutcome_LB.Text = "NO DIABETES";
                        patientOutcome_LB.ForeColor = Color.FromArgb(33, 209, 92);
                    }
                }
                else
                {
                    patientOutcome_LB.Text = "NOT DIAGNOSED";
                    patientOutcome_LB.ForeColor = Color.FromArgb(0, 163, 136);
                    patientDetails_PNL.Visible = false;
                    noData_LB.Visible = true;
                }
                

                cmd.Dispose();
                dataReader.Close();
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

        private void backShowList_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorShowPatientsList patientsList = new DoctorShowPatientsList();
            patientsList.ShowDialog();
            this.Close();
        }
    }
}
