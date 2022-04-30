using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MiASI_Project2_MedicalSupportSystem
{
    public partial class DoctorPatientDetailsToClassify : Form
    {
        public static string clickedUserLogin;
        public static string clickedUserID;
        public static IEnumerable<string> file;
        private static List<Points> points;
        public static int healthy0 = 0, sick1 = 0, k = 0;
        public static string patientData;
        private static Points patient;

        public DoctorPatientDetailsToClassify()
        {
            InitializeComponent();
            decisionSaved_LB.Visible = false;
            clickedUserID = DoctorPatientsListToClassify.clickedUserID;
            loginName_LB.Text = Login.loginDisplay;
            clickedUserLogin = DoctorPatientsListToClassify.clickedUserLogin;
            patientDetailsName_LB.Text = $"{DoctorPatientsListToClassify.clickedUserName} {DoctorPatientsListToClassify.clickedUserSurname}";
            pesel_LB.Text = "PESEL: " + DoctorPatientsListToClassify.clickedUserPesel;

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false;";
            SqlConnection cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Pregnancies,Glucose,BloodPressure,SkinThickness,Insulin,BMI,DiabetesPedigree,Age,Outcome FROM Project2.dbo.Samples as s INNER JOIN Project2.dbo.Users as u ON s.UserID = u.UserID where u.UserLogin Like '{clickedUserLogin}'", cnn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    pregnancies_TB.Text = dataReader[0].ToString();
                    glucose_TB.Text = dataReader[1].ToString();
                    bloodPressure_TB.Text = dataReader[2].ToString();
                    skinThickness_TB.Text = dataReader[3].ToString();
                    insulin_TB.Text = dataReader[4].ToString();
                    bmi_TB.Text = dataReader[5].ToString();
                    diabetesPedigree_TB.Text = dataReader[6].ToString();
                    age_TB.Text = dataReader[7].ToString();
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
            DoctorPatientsListToClassify patientsList = new DoctorPatientsListToClassify();
            patientsList.ShowDialog();
            this.Close();
        }

        private void classify_BTN_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false;";
            SqlConnection cnn = new SqlConnection(connectionString);
            classification_BTNs.Visible = true;

            #region Vairables
            try
            {
                file = File.ReadAllLines("diabetes.csv").Skip(1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            healthy0 = 0;
            sick1 = 0;
            k = 0;
            points = new List<Points>();
            patient = new Points();
            #endregion

            CSVToList();
            file = null;

            GetPatientData();
            patientData = null;
            GetKNN();

            #region CountDistanceAndCheckResults
            CalculateDistance();
            //liczymy tutaj K ilość osób, które mają i nie mają cukrzycy
            for (int i = 0; i < k; i++)
            {
                if (points[i].outcome.Equals(0)) healthy0++;
                else sick1++;
            }
            #endregion

            #region ShowResults
            if (healthy0 > sick1)
            {
                outcome_LB.Text = "Patient does not have diabietes";
            }
            else
            {
                outcome_LB.Text = "Patient have diabietes";
            }
            #endregion
        }

        void CalculateDistance()
        {
            // Liczymy odległość pomiędzy pacjentem, a każdą inną osobą w naszej bazie
            foreach (Points p in points)
            {
                int x1 = p.pregnancies - patient.pregnancies;
                int x2 = p.age - patient.age;
                int x3 = p.bloodPressure - patient.bloodPressure;
                int x4 = p.skinThickness - patient.skinThickness;
                int x5 = p.insulin - patient.insulin;
                int x6 = p.glucose - patient.glucose;
                float x7 = p.bmi - patient.bmi;
                float x8 = p.diabetesPedigreeFunction - patient.diabetesPedigreeFunction;
                float distance = x1 * x1 + x2 * x2 + x3 * x3 + x4 * x4 + x5 * x5 + x6 * x6 + x7 * x7 + x8 * x8;
                p.score = MathF.Sqrt(distance);
            }
            //sortujemy listę według odległości od naszego pacjenta (od najmmniejszej do największej)
            points.Sort((x1, x2) => x1.score.CompareTo(x2.score));
        }

        void CSVToList()
        {
            try
            {
                foreach (string s in file)
                {
                    var line = s.Split(',').ToList();
                    points.Add(new Points(
                          int.Parse(line[0]),
                          int.Parse(line[1]),
                          int.Parse(line[2]),
                          int.Parse(line[3]),
                          int.Parse(line[4]),
                          float.Parse(line[5].Replace('.', ',')),
                          float.Parse(line[6].Replace('.', ',')),
                          int.Parse(line[7]),
                          int.Parse(line[8])
                          ));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void nodiabetes_BTN_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false;";
            SqlConnection cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Project2.dbo.Samples SET Outcome = 0 WHERE UserID Like '{clickedUserID}'", cnn);
                cmd.ExecuteNonQuery();
                decisionSaved_LB.Visible = true;
                classification_BTNs.Visible = false;
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

        private void diabetes_BTN_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false;";
            SqlConnection cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Project2.dbo.Samples SET Outcome = 1 WHERE UserID Like '{clickedUserID}'", cnn);
                cmd.ExecuteNonQuery();
                decisionSaved_LB.Visible = true;
                classification_BTNs.Visible = false;

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

        void GetPatientData()
        {
            do
            {
                patientData = $"{pregnancies_TB.Text} {glucose_TB.Text} {bloodPressure_TB.Text} {skinThickness_TB.Text} {insulin_TB.Text} {bmi_TB.Text} {diabetesPedigree_TB.Text} {age_TB.Text}";
                var check = patientData.Split(' ').ToList();
                if (check.Count() != 8) //Jest dokładnie 8 różnych czynników na podstawie, których sprawdzamy czy ktoś ma cukrzycę czy nie. Stąd to 8
                {
                    patientData = null;
                    MessageBox.Show("You have missed some patient data. Check it one more time.");
                }
                else
                {
                    try //Jeśli będzie problem z parsowanie stringa na int lub float, to dostaniemy informacje, że coś zostało źle podane
                    {
                        patient.pregnancies = int.Parse(check[0]);
                        patient.glucose = int.Parse(check[1]);
                        patient.bloodPressure = int.Parse(check[2]);
                        patient.skinThickness = int.Parse(check[3]);
                        patient.insulin = int.Parse(check[4]);
                        patient.bmi = float.Parse(check[5]);
                        patient.diabetesPedigreeFunction = float.Parse(check[6]);
                        patient.age = int.Parse(check[7]);
                    }
                    catch (Exception e)
                    {
                        patientData = null;
                        MessageBox.Show(e.Message);
                    }

                }
            } while (patientData == null);
        }

        void GetKNN()
        {
            do
            {
                patientData = "100";
                try
                {
                    k = int.Parse(patientData);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    patientData = null;
                }
                if (k == 0 || k > points.Count())
                {
                    patientData = null;
                    MessageBox.Show("Number of K neighbours exceeded " + points.Count() + "or is equall 0. Input proper number!");
                }
            } while (patientData == null);
        }
    }
}
