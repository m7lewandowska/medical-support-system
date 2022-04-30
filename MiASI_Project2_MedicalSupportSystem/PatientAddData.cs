using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MiASI_Project2_MedicalSupportSystem
{
    public partial class PatientAddData : Form
    {
        public static string userLogin;
        public PatientAddData()
        {
            InitializeComponent();
            loginName_LB.Text = Login.loginDisplay;
            userLogin = Login.loginDisplay;
        }

        private void loginName_LB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
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

        private void backAddData_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientHome patientHome = new PatientHome();
            patientHome.ShowDialog();
            this.Close();
        }

        public static bool isValidPregnancies(string dateValue)
        {
            string pattern = @"\b([0-9]|1[0-7])\b";
            Regex dateRegex = new Regex(pattern);
            return dateRegex.IsMatch(dateValue);
        }

        public static bool isValidGlucose(string timeValue)
        {
            string pattern = @"\b([0-9]|[1-9][0-9]|1[0-9][0-9])\b";
            Regex timeRegex = new Regex(pattern);
            return timeRegex.IsMatch(timeValue);
        }

        public static bool isValidBloodPressure(string dateValue)
        {
            string pattern = @"\b([0-9]|[1-9][0-9]|1[01][0-9]|12[0-2])\b";
            Regex dateRegex = new Regex(pattern);
            return dateRegex.IsMatch(dateValue);
        }

        public static bool isValidSkinThickness(string timeValue)
        {
            string pattern = @"\b([0-9]|[1-9][0-9])\b";
            Regex timeRegex = new Regex(pattern);
            return timeRegex.IsMatch(timeValue);
        }

        public static bool isValidInsulin(string dateValue)
        {
            string pattern = @"\b([0-9]|[1-9][0-9]|[1-7][0-9][0-9]|8[0-3][0-9]|84[0-6])\b";
            Regex dateRegex = new Regex(pattern);
            return dateRegex.IsMatch(dateValue);
        }

        public static bool isValidBMI(string timeValue)
        {
            string pattern = @"^(([0-9]|[1-5][0-9])(,[0-9])*|6[0-9])(,[0-9])*$";
            Regex timeRegex = new Regex(pattern);
            return timeRegex.IsMatch(timeValue);
        }

        public static bool isValidDiabetesPedigree(string dateValue)
        {
            string pattern = @"^(([0-2])|(([0-2])(,[0-9]))*|(([0-2])(,[0-9][0-9])))*$";
            Regex dateRegex = new Regex(pattern);
            return dateRegex.IsMatch(dateValue);
        }

        public static bool isValidAge(string timeValue)
        {
            string pattern = @"^(0?[1-9]|[1-9][0-9])$";
            Regex timeRegex = new Regex(pattern);
            return timeRegex.IsMatch(timeValue);
        }


        private void addAddData_BTN_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(pregnancies_TB.Text) || string.IsNullOrWhiteSpace(glucose_TB.Text) || string.IsNullOrWhiteSpace(bloodPressure_TB.Text)
                || string.IsNullOrWhiteSpace(skinThickness_TB.Text) || string.IsNullOrWhiteSpace(insulin_TB.Text) || string.IsNullOrWhiteSpace(bmi_TB.Text)
                    || string.IsNullOrWhiteSpace(diabetesPedigree_TB.Text) || string.IsNullOrWhiteSpace(age_TB.Text))
            {
                MessageBox.Show("Fill all fields!");
            }
            else
            {
                if (isValidPregnancies(pregnancies_TB.Text))
                {
                    if (isValidGlucose(glucose_TB.Text))
                    {
                        if (isValidBloodPressure(bloodPressure_TB.Text))
                        {
                            if (isValidSkinThickness(skinThickness_TB.Text))
                            {
                                if (isValidInsulin(insulin_TB.Text))
                                {
                                    if (isValidBMI(bmi_TB.Text))
                                    {
                                        if (isValidDiabetesPedigree(diabetesPedigree_TB.Text))
                                        {
                                            if (isValidAge(age_TB.Text))
                                            {
                                                string pregnancies = pregnancies_TB.Text;
                                                string glucose = glucose_TB.Text;
                                                string bloodPressure = bloodPressure_TB.Text;
                                                string skinThickness = skinThickness_TB.Text;
                                                string insulin = insulin_TB.Text;
                                                string bmi = bmi_TB.Text;
                                                string diabetesPedigree = diabetesPedigree_TB.Text;
                                                string age = age_TB.Text;
                                                string commandText = "";

                                                string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false;";
                                                SqlConnection cnn = new SqlConnection(connectionString);
                                                cnn.Open();

                                                SqlCommand cmdSelect = new SqlCommand($"SELECT * FROM Project2.dbo.Users WHERE UserLogin Like '{userLogin}'", cnn);

                                                try
                                                {
                                                    SqlDataReader dataReader = cmdSelect.ExecuteReader();
                                                    while (dataReader.Read())
                                                    {
                                                        string userID = dataReader.GetValue(0).ToString();
                                                        commandText = $"INSERT INTO Project2.dbo.Samples (UserID,Pregnancies,Glucose,BloodPressure,SkinThickness,Insulin,BMI,DiabetesPedigree,Age,Outcome) VALUES ('{userID}','{pregnancies}','{glucose}','{bloodPressure}','{skinThickness}','{insulin}','{bmi}','{diabetesPedigree}','{age}', NULL)";
                                                        SqlCommand cmd = new SqlCommand(commandText, cnn);
                                                        cmd.ExecuteNonQuery();

                                                        MessageBox.Show("Data has been added correctly!");
                                                        this.Hide();
                                                        PatientHome patientHome = new PatientHome();
                                                        patientHome.ShowDialog();
                                                        this.Close();
                                                        return;
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show(ex.Message);
                                                }
                                                finally
                                                {
                                                    cmdSelect.Dispose();
                                                    cnn.Close();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Invalid AGE!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Invalid Diabetes Pedigree!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid BMI!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Insuline!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Inbalid Skin Thickness!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Blood Pressure!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Glucose!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Pregnancies!");
                }
                
            }
        }
    }
}
