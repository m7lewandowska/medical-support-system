using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiASI_Project2_MedicalSupportSystem
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*GenKey();*/

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

   /*     static void GenKey()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            using (StreamWriter writer = new StreamWriter(@"rsa\rsa-private.xml")) //This file should be kept secret...
            {
                System.Diagnostics.Debug.WriteLine(rsa.ToXmlString(true));

                writer.WriteLine(rsa.ToXmlString(true));
            }
            using (StreamWriter writer = new StreamWriter(@"rsa\rsa-public.xml"))
            {
                System.Diagnostics.Debug.WriteLine(rsa.ToXmlString(false));
                writer.WriteLine(rsa.ToXmlString(false));
            }
        }*/
    }
}
