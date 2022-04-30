using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiASI_Project2_MedicalSupportSystem
{
    public partial class DoctorHome : Form
    {
        public static string role;

        public DoctorHome()
        {
            InitializeComponent();
            loginName_LB.Text = Login.loginDisplay;
            role = Login.userRole;
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

        private void show_PatientsData_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorShowPatientsList patientsList = new DoctorShowPatientsList();
            patientsList.ShowDialog();
            this.Close();
        }

        private void goToClassify_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorPatientsListToClassify patientsListToClassify = new DoctorPatientsListToClassify();
            patientsListToClassify.ShowDialog();
            this.Close();
        }
    }
}
