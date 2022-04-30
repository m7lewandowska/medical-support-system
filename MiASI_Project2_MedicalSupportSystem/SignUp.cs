using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MiASI_Project2_MedicalSupportSystem
{
    public partial class SignUp : Form
    {
        string publicKey = "<RSAKeyValue><Modulus>1BqYDcKctOuTI73qRbUCaxO3tTBXD9Wmm6tYsS7q/ubk7+dlRsx8v8w4vHAskuk0LXSb1y9OhSBONnPT8Hre7GjE8zzSCFwsBuPJTzG21Zeu/R5jPSXWmmZCc0p3S5s8ILaR3qrdDDLpyru1mSGWBL0A22+iGaGIeuIwO/1jFmk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        public SignUp()
        {
            InitializeComponent();
            PinPESELCode_TB.Visible = true;
        }
        public static string Encryption(string strText, string publicKey)
        {
            var data = Encoding.UTF8.GetBytes(strText);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {                 
                    rsa.FromXmlString(publicKey.ToString());

                    var encryptedData = rsa.Encrypt(data, true);

                    var base64Encrypted = Convert.ToBase64String(encryptedData);

                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        private void HaveAccount_label_MouseEnter(object sender, EventArgs e)
        {
            HaveAccount_label.Font = new Font(HaveAccount_label.Font, FontStyle.Underline);
        }

        private void HaveAccount_label_MouseLeave(object sender, EventArgs e)
        {
            HaveAccount_label.Font = new Font(HaveAccount_label.Font, FontStyle.Regular);
        }

        private void HaveAccount_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        public static bool isValidPesel(string pesel)
        {
            int[] weight = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            long sum = 0;
            string x = pesel.Substring(10,1);

            long controlNumber = long.Parse(x);

            for (int i = 0; i < 10; i++)
            {
                sum += (long.Parse(pesel.Substring(i, 1)) * weight[i]);
            }


            sum = sum % 10;

            if ((10 - sum) % 10 == controlNumber)
                return true;
            else
                return false; 
        }

        private void IsType_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPatient_CB.Checked)
            {
                //Patient
                PinCode_TB.Visible = false;
                PinPESELCode_TB.Visible = true;
                IsDoctor_CB.Checked = false;
                label9.Text = "Pesel:";
            }
            else
            {
                //Doctor
                PinCode_TB.Visible = true;
                PinPESELCode_TB.Visible = false;
                IsPatient_CB.Checked = false;
                label9.Text = "Pin:";
            }
        }

        private void signUp_BTN_Click(object sender, EventArgs e)
        {
            string userName = name_signUp_TB.Text;
            string userSurname = surname_signUp_TB.Text;
            string userLogin = login_signUp_TB.Text;
            string userPesel = PinPESELCode_TB.Text;
            string userPassword = password_signUp_TB.Text;
            string commandText = "";

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false;";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand cmdSelectPESEL = new SqlCommand($"SELECT * FROM Project2.dbo.Users WHERE UserPesel Like '{PinPESELCode_TB.Text}'", cnn);
            SqlCommand cmdSelect = new SqlCommand($"SELECT * FROM Project2.dbo.Users WHERE UserLogin Like '{userLogin}'", cnn);

            try
            {
                SqlDataReader dataReader = cmdSelect.ExecuteReader();
                while (!dataReader.Read())
                {
                    if (PinCode_TB.Text == "213742069" && IsDoctor_CB.Checked == true)
                    {
                        //Doctor
                        if (string.IsNullOrWhiteSpace(login_signUp_TB.Text) || string.IsNullOrWhiteSpace(password_signUp_TB.Text) || login_signUp_TB.Text.Any(Char.IsWhiteSpace) || password_signUp_TB.Text.Any(Char.IsWhiteSpace))
                        {
                            MessageBox.Show("Invalid input");
                        }
                        else
                        {
                            commandText = $"INSERT INTO Project2.dbo.Passwords (Password) VALUES ('{Encryption(userPassword, publicKey)}'); INSERT INTO Project2.dbo.Users (UserLogin, UserName, UserLastName, UserPesel, RoleID, PasswordID) VALUES ('{userLogin}', '{userName}', '{userSurname}', '{userPesel}', 2, (SELECT TOP 1 PasswordID FROM Project2.dbo.Passwords ORDER BY PasswordID DESC));";
                        }
                    }
                    else if (IsPatient_CB.Checked == true)
                    {
                    //Patient
                        if (isValidPesel(PinPESELCode_TB.Text))
                        {
                            try
                            {
                                SqlDataReader dataReader1 = cmdSelectPESEL.ExecuteReader();
                    
                                if (dataReader1.Read())
                                {
                                    MessageBox.Show("This PESEL has already been assigned an account");
                                }
                                else
                                {
                                    if (string.IsNullOrWhiteSpace(login_signUp_TB.Text) || string.IsNullOrWhiteSpace(password_signUp_TB.Text) || login_signUp_TB.Text.Any(Char.IsWhiteSpace) || password_signUp_TB.Text.Any(Char.IsWhiteSpace))
                                    {
                                        MessageBox.Show("Invalid input");
                                    }
                                    else
                                    {
                                        commandText = $"INSERT INTO Project2.dbo.Passwords (Password) VALUES ('{Encryption(userPassword, publicKey)}'); INSERT INTO Project2.dbo.Users (UserLogin, UserName, UserLastName, UserPesel, RoleID, PasswordID) VALUES ('{userLogin}', '{userName}', '{userSurname}', '{userPesel}', 1, (SELECT TOP 1 PasswordID FROM Project2.dbo.Passwords ORDER BY PasswordID DESC));";
                                    }
                                }
                                dataReader1.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                cmdSelectPESEL.Dispose();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong PESEL!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong pin code!");
                        PinCode_TB.Text = "";
                    }
                    

                    SqlCommand cmd = new SqlCommand(commandText, cnn);
                    cmd.ExecuteNonQuery();

                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    this.Close();
                    return;
                }
                MessageBox.Show("Login exist!");
                login_signUp_TB.Text = "";
                password_signUp_TB.Text = "";
                name_signUp_TB.Text = "";
                surname_signUp_TB.Text = "";
                PinPESELCode_TB.Text = "";
                PinCode_TB.Text = "";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                cmdSelect.Dispose();
                cnn.Close();
            }

        }
    }
}
