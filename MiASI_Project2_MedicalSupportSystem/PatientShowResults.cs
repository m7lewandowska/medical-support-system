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
    public partial class PatientShowResults : Form
    {
        public PatientShowResults()
        {
            InitializeComponent();
            loginName_LB.Text = Login.loginDisplay;

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false;";
            SqlConnection cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Outcome FROM Project2.dbo.Samples as s INNER JOIN Project2.dbo.Users as u ON s.UserID = u.UserID where u.UserLogin Like '{loginName_LB.Text}'", cnn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    if (string.IsNullOrEmpty(dataReader[0].ToString()))
                    {
                        outcomePatientResult_LB.Text = "NOT DIAGNOSED";
                        outcomePatientResult_LB.ForeColor = Color.FromArgb(0, 163, 136);
                    }
                    else if (dataReader[0].ToString() == "True")
                    {
                        outcomePatientResult_LB.Text = "DIABETES";
                        outcomePatientResult_LB.ForeColor = Color.FromArgb(194, 43, 63);
                    }
                    else if (dataReader[0].ToString() == "False")
                    {
                        outcomePatientResult_LB.Text = "NO DIABETES";
                        outcomePatientResult_LB.ForeColor = Color.FromArgb(33, 209, 92);
                    }
                }
                else
                {
                    outcomePatientResult_LB.Text = "NOT DIAGNOSED";
                    outcomePatientResult_LB.ForeColor = Color.FromArgb(0, 163, 136);
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

        private void backShowResult_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientHome patientHome = new PatientHome();
            patientHome.ShowDialog();
            this.Close();
        }
    }
}
