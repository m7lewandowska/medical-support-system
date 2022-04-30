using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_RSA()
        {
            //Arrange
            string pass = "ww";
            string dtbpass = "OC0RIjQlrnynRTyCvXBdiZA5s8znOuGz0t0fHVzbSGiTrAnxU1ftpUGl3+UsUcxIEumkLvtZjp98BTWRPg7eygRtcH7u0O9bcnXbshfTexcN6UYfYzhng6jcG1QQrxIxRYLvxHr7RLqeoQCygcBHz4ozDlVAwvCPn7Ml82TNu00=";
            string privateKey = "<RSAKeyValue><Modulus>1BqYDcKctOuTI73qRbUCaxO3tTBXD9Wmm6tYsS7q/ubk7+dlRsx8v8w4vHAskuk0LXSb1y9OhSBONnPT8Hre7GjE8zzSCFwsBuPJTzG21Zeu/R5jPSXWmmZCc0p3S5s8ILaR3qrdDDLpyru1mSGWBL0A22+iGaGIeuIwO/1jFmk=</Modulus><Exponent>AQAB</Exponent><P>1hR1mgC+Zo1dnQZ7N6SIlL7Q9DoRt0/cCnKke7lXxFWYv4lfwyD2Ap317kZg855qJsrBLs+ij2rwx8ae5i98/w==</P><Q>/aMUGARxOpBNQrgBIwqT6PUvUGO0FXG8YIeusJNHiNsFNBL9boDfN3WUAKV4DKbBYBv+seLQQCq2unHXm7Oklw==</Q><DP>n7v8U8CiUNrCMtwXLFl0H6iROOnrNiA8Sv9ng3mz5ycHJkNWVL5PUXyTeArDZIObKP64TjlXTjO5HRcykQZ1+Q==</DP><DQ>SxWg2C9Qeb7IMG0aYQ47lSYoOIsbf5Go64afL0SaU6hK1QyeG71o1xkmlD5n2I7xBgujjXOQpL5AU9dptX0rxw==</DQ><InverseQ>uWrT5YrpQ6dMioZJ9CFW2Xj9jNndKMtW/vwQYyTXJIDDwtLFEexx/gCfiVO+yCZUoIK6qFFy2jx8x8mi/GAgSg==</InverseQ><D>Dz/6PsMHUVq+sYsuFOT2z4wTYUugdtr9p6OiNNsSulEPlNAmT/jT31ZnneTSz51Eyx/fNJGKK7gu52tciaXL8UHWPQhlwg9w8Ny5in87ZuufSB7AO9yDziiq/uQsXUcfPL+Xtz9oKoOpo+8VcmLy1Ss2pVSZlnzx4JC9180RXiE=</D></RSAKeyValue>";

            //Act
            string resultDescription = MiASI_Project2_MedicalSupportSystem.Login.Decryption(dtbpass, privateKey);

            //Assert
            Assert.AreEqual(pass, resultDescription);
        }

        [TestMethod]
        public void Test_isValidPregnancies()
        {
            //Arrange
            string pregnancies = "5";

            //Act
            bool isValid = MiASI_Project2_MedicalSupportSystem.PatientAddData.isValidPregnancies(pregnancies);

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void Test_isValidGlucose()
        {
            //Arrange
            string glucose = "150";
            //Act
            bool isValid = MiASI_Project2_MedicalSupportSystem.PatientAddData.isValidGlucose(glucose);

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void Test_isValidBloodPressure()
        {
            //Arrange
            string bloodPressure = "100";
            //Act
            bool isValid = MiASI_Project2_MedicalSupportSystem.PatientAddData.isValidBloodPressure(bloodPressure);

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void Test_isValidSkinThickness()
        {
            //Arrange
            string skinThickness = "55";
            //Act
            bool isValid = MiASI_Project2_MedicalSupportSystem.PatientAddData.isValidSkinThickness(skinThickness);

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void Test_isValidInsulin()
        {
            //Arrange
            string insulin = "575";
            //Act
            bool isValid = MiASI_Project2_MedicalSupportSystem.PatientAddData.isValidInsulin(insulin);

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void Test_isValidBMI()
        {
            //Arrange
            string bmi = "33,6";
            //Act
            bool isValid = MiASI_Project2_MedicalSupportSystem.PatientAddData.isValidBMI(bmi);

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void Test_isValidDiabetesPedigree()
        {
            //Arrange
            string diabetesPedigree = "2,2";
            //Act
            bool isValid = MiASI_Project2_MedicalSupportSystem.PatientAddData.isValidDiabetesPedigree(diabetesPedigree);

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void Test_isValidAge()
        {
            //Arrange
            string age = "32";
            //Act
            bool isValid = MiASI_Project2_MedicalSupportSystem.PatientAddData.isValidAge(age);

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void Test_isValidPesel()
        {
            //Arrange
            string pesel = "96120624567";
            //Act
            bool isValid = MiASI_Project2_MedicalSupportSystem.SignUp.isValidPesel(pesel);

            //Assert
            Assert.IsTrue(isValid);
        }
     }
}
