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
    public partial class PatientHome : Form
    {
        public static string role;
        public static string userLogin;
        public PatientHome()
        {
            InitializeComponent();
            loginName_LB.Text = Login.loginDisplay;
            role = Login.userRole;
            userLogin = Login.loginDisplay;

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false;";
            SqlConnection cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Project2.dbo.Samples as s INNER JOIN Project2.dbo.Users as u ON s.UserID = u.UserID where u.UserLogin Like '{userLogin}'", cnn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    noMedData_LB.Visible = false;
                    add_MedData_BTN.Visible = false;

                    resultData_Panel.Visible = true;
                    medData_Panel.Visible = true;
                }
                else
                {
                    noMedData_LB.Visible = true;
                    add_MedData_BTN.Visible = true;

                    resultData_Panel.Visible = false;
                    medData_Panel.Visible = false;
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

        private void add_MedData_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientAddData patientAddData = new PatientAddData();
            patientAddData.ShowDialog();
            this.Close();
        }

        private void show_MedData_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientShowData patientShowData = new PatientShowData();
            patientShowData.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientShowResults patientShowResult = new PatientShowResults();
            patientShowResult.ShowDialog();
            this.Close();
        }
    }
}
