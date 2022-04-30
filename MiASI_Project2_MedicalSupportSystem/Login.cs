using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MiASI_Project2_MedicalSupportSystem
{
    public partial class Login : Form
    {
        public static string loginDisplay;
        public static string userRole;

        string privateKey = "<RSAKeyValue><Modulus>1BqYDcKctOuTI73qRbUCaxO3tTBXD9Wmm6tYsS7q/ubk7+dlRsx8v8w4vHAskuk0LXSb1y9OhSBONnPT8Hre7GjE8zzSCFwsBuPJTzG21Zeu/R5jPSXWmmZCc0p3S5s8ILaR3qrdDDLpyru1mSGWBL0A22+iGaGIeuIwO/1jFmk=</Modulus><Exponent>AQAB</Exponent><P>1hR1mgC+Zo1dnQZ7N6SIlL7Q9DoRt0/cCnKke7lXxFWYv4lfwyD2Ap317kZg855qJsrBLs+ij2rwx8ae5i98/w==</P><Q>/aMUGARxOpBNQrgBIwqT6PUvUGO0FXG8YIeusJNHiNsFNBL9boDfN3WUAKV4DKbBYBv+seLQQCq2unHXm7Oklw==</Q><DP>n7v8U8CiUNrCMtwXLFl0H6iROOnrNiA8Sv9ng3mz5ycHJkNWVL5PUXyTeArDZIObKP64TjlXTjO5HRcykQZ1+Q==</DP><DQ>SxWg2C9Qeb7IMG0aYQ47lSYoOIsbf5Go64afL0SaU6hK1QyeG71o1xkmlD5n2I7xBgujjXOQpL5AU9dptX0rxw==</DQ><InverseQ>uWrT5YrpQ6dMioZJ9CFW2Xj9jNndKMtW/vwQYyTXJIDDwtLFEexx/gCfiVO+yCZUoIK6qFFy2jx8x8mi/GAgSg==</InverseQ><D>Dz/6PsMHUVq+sYsuFOT2z4wTYUugdtr9p6OiNNsSulEPlNAmT/jT31ZnneTSz51Eyx/fNJGKK7gu52tciaXL8UHWPQhlwg9w8Ny5in87ZuufSB7AO9yDziiq/uQsXUcfPL+Xtz9oKoOpo+8VcmLy1Ss2pVSZlnzx4JC9180RXiE=</D></RSAKeyValue>";
        public Login()
        {
            InitializeComponent();
        }

        public static string Decryption(string strText, string privateKey)
        {
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {         
                    rsa.FromXmlString(privateKey);

                    var resultBytes = Convert.FromBase64String(strText);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        private void CreateAccount_label_MouseEnter(object sender, EventArgs e)
        {
            CreateAccount_label.Font = new Font(CreateAccount_label.Font, FontStyle.Underline);
        }

        private void CreateAccount_label_MouseLeave(object sender, EventArgs e)
        {
            CreateAccount_label.Font = new Font(CreateAccount_label.Font, FontStyle.Regular);
        }

        private void CreateAccount_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.ShowDialog();
            this.Close();
        }

        private void signIn_BTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_signIn_TB.Text) || string.IsNullOrWhiteSpace(password_signIn_TB.Text) || login_signIn_TB.Text.Any(Char.IsWhiteSpace) || password_signIn_TB.Text.Any(Char.IsWhiteSpace))
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                string login = login_signIn_TB.Text;
                loginDisplay = login;

                string password = password_signIn_TB.Text;

                string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;Encrypt=false;";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlDataReader dataReader;
                String sql;
                sql = $"SELECT u.UserLogin, p.Password, r.Description FROM Project2.dbo.Users as u INNER JOIN Project2.dbo.Passwords p ON u.PasswordID = p.PasswordID INNER JOIN Project2.dbo.Roles r ON u.RoleID = r.RoleID WHERE u.UserLogin LIKE '{login}'";

                SqlCommand cmd = new SqlCommand(sql, cnn);
                try
                {
                    dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        string pass = dataReader.GetValue(1).ToString();

                        if(!string.IsNullOrWhiteSpace(pass))
                        {
                            string passDB = Decryption(pass, privateKey);

                            if ((dataReader.GetValue(0).ToString() == login) && (passDB == password))
                            {
                                userRole = dataReader.GetValue(2).ToString();

                                if (userRole == "Patient")
                                {
                                    this.Hide();
                                    PatientHome patientHome = new PatientHome();
                                    patientHome.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    this.Hide();
                                    DoctorHome doctorHome = new DoctorHome();
                                    doctorHome.ShowDialog();
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your login or password is incorrect");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your login or password is incorrect");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your login or password is incorrect");
                    }
                    dataReader.Close();
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
                finally
                {
                    cmd.Dispose();
                    cnn.Close();
                }

            }
        }
    }
}
