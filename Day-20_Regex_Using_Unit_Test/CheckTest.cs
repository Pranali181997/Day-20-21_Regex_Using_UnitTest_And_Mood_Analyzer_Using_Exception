using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day19_Regex;
namespace Test
{
    [TestClass]
    public class CheckTest
    {
        //UC-1-As a User need to enter a valid First name
        [TestMethod]
        public void givenCorrectNameWhen_Validate_Name_Should_return_True()
        {
           
            FirstName firstname = new FirstName();
            string Name = "Ram";
            
             bool expected = true;
             bool actual = firstname.validateName(Name);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void givenWrongNameWhen_Validate_Name_Should_return_True()
        {

            FirstName firstname = new FirstName();
            string Name = "HEL@1";
            //string REGEX_NAME= "^[A-Z]{1}[a-z]{1,}$";
            bool expected = false;
            bool actual = firstname.validateName(Name);
            Assert.AreEqual(expected, actual);
        }


        //UC-2-As a User need to enter a valid Last name
        [TestMethod]
        public void givenCorrectLastNameWhenValidateNameShouldreturnTrue()
        {
            FirstName lastname = new FirstName();
            string Name = "Lambat";            
            bool expected = true;
            bool actual = lastname.validateName(Name);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void givenWrongLastNameWhenValidateNameShouldreturnTrue()
        {
            FirstName lastname = new FirstName();
            string Name = "Lamba@t";
            bool expected = false;
            bool actual = lastname.validateName(Name);
            Assert.AreEqual(expected, actual);
        }

        //UC-3-As a User need to follow pre-defined Mobile Format
        [TestMethod]
        public void givenCorrectMobileNumberShouldReturnTrue()
        {
            Mobile_Format format = new Mobile_Format();
            string Name = "+918555241365";       
            bool expected = true;
            bool actual = format.validMobile(Name);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void givenWrongMobileNumberShouldReturnTrue()
        {
            Mobile_Format format = new Mobile_Format();
            string Name = "918555aa241365";
            bool expected = false;
            bool actual = format.validMobile(Name);
            Assert.AreEqual(expected, actual);

        }

        //UC-4-As a User need to enter a valid email
        [TestMethod]
        public void givenCorrectEmailNumberShouldReturnTrue()
        {

            EmailForAllCase format1 = new EmailForAllCase();
            string Email = "abc@gmail.com";
            bool expected = true;
            bool actual = format1.validateEmail(Email);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void givenWrongEmailNumberShouldReturnTrue()
        {

            EmailForAllCase format1 = new EmailForAllCase();
            string Email = ")abc@gmail.com";
            bool expected = false;
            bool actual = format1.validateEmail(Email);
            Assert.AreEqual(expected, actual);
        }

        //UC-5-As a User need to  follow pre-definedPassword rules.Rule1 – minimum 8 Characters
        [TestMethod]
        public void givenCorrectPasswordShouldReturnTrue()
        {

            PassUC_5 format2 = new PassUC_5();
            string Password = "Aqws123sAa";
            bool expected = true;
            bool actual = format2.validPassword(Password);
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void givenWrongPasswordShouldReturnTrue()
        {

            PassUC_5 format2 = new PassUC_5();
            string Password = "(Aqws123sAa";
            bool expected = false;
            bool actual = format2.validPassword(Password);
            Assert.AreEqual(expected, actual);
        }

        //UC-6-As a User need to  follow pre-definedPassword rules.Rule2 Should have at least 1 Upper Case - NOTE – All rules must be
        [TestMethod]
        public void givenCorrectPasswordShouldHaveRule2AndReturnTrue()
        {

            PassUC_6 format3 = new PassUC_6();
            string Password = "Aqws123sAa";
            bool expected = true;
            bool actual = format3.validPasswordRule2(Password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void givenWrongPasswordShouldHaveRule2AndReturnTrue()
        {

            PassUC_6 format3 = new PassUC_6();
            string Password = "a";
            bool expected = false;
            bool actual = format3.validPasswordRule2(Password);
            Assert.AreEqual(expected, actual);
        }

        //UC-7 As a User need to  follow pre-definedPassword rules.Rule3 Should have at least one Numeric Number
        [TestMethod]
        public void givenCorrectPasswordShouldHaveRule3AndReturnTrue()
        {

            PassUC_7 format4 = new PassUC_7();
            string Password = "Aqws123sAa";
            bool expected = true;
            bool actual = format4.validPasswordRule3(Password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void givenWrongPasswordShouldHaveRule3AndReturnTrue()
        {

            PassUC_7 format4 = new PassUC_7();
            string Password = ")aaaaaa";
            bool expected = false;
            bool actual = format4.validPasswordRule3(Password);
            Assert.AreEqual(expected, actual);
        }

        //UC-8 As a User need to  follow pre-definedPassword rules.Rule4 Should have at least one special character - NOTE – All rules must b

        [TestMethod]
        public void givenCorrectPasswordShouldHaveRule4AndReturnTrue()
        {

            PassUC_8 format4 = new PassUC_8();
            string Password = "Aqws123sA@a";
            bool expected = true;
            bool actual = format4.validPasswordRule4(Password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void givenWrongPasswordShouldHaveRule4AndReturnTrue()
        {

            PassUC_8 format4 = new PassUC_8();
            string Password = ")Aqws123sAa";
            bool expected = false;
            bool actual = format4.validPasswordRule4(Password);
            Assert.AreEqual(expected, actual);
        }

        //UC-9 Should clear all email samples provided separately
        [TestMethod]
        public void givenCorrectPatternForEmailShouldHaveReturnTrue()
        {

            EmailForAllCase format5 = new EmailForAllCase();
            string password1 = "abc@yahoo.com";
            string password2 = "abc-100@yahoo.com";
            string password3 = "abc.100@yahoo.com";
            string password4 = "abc111@abc.com";
            string password5 = "abc-100@abc.com";
            string password6 = "abc.100@abc.com";
            string password7 = "abc@1.com";
            string password8 = "abc+100@gmail.com";
            bool expected = true;

            bool actual = format5.validateEmail(password1);
            bool actual1 = format5.validateEmail(password2);
            bool actual2 = format5.validateEmail(password3);
            bool actual3 = format5.validateEmail(password4);
            bool actual4 = format5.validateEmail(password5);
            bool actual5 = format5.validateEmail(password6);
            bool actual6 = format5.validateEmail(password7);
            bool actual7 = format5.validateEmail(password8);


            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
            Assert.AreEqual(expected, actual4);
            Assert.AreEqual(expected, actual5);
            Assert.AreEqual(expected, actual6);
            Assert.AreEqual(expected, actual7);

        }

        [TestMethod]
        public void givenWrongPatternForEmailShouldHaveReturnTrue()
        {

            EmailForAllCase format5 = new EmailForAllCase();
            string password1 = "111111";
            string password2 = "22222";
            string password3 = "ahom";
            string password4 = "m";
            string password5 = "m";
            string password6 = "//";
            string password7 = "6";
            string password8 = "m";
            bool expected = false;

            bool actual = format5.validateEmail(password1);
            bool actual1 = format5.validateEmail(password2);
            bool actual2 = format5.validateEmail(password3);
            bool actual3 = format5.validateEmail(password4);
            bool actual4 = format5.validateEmail(password5);
            bool actual5 = format5.validateEmail(password6);
            bool actual6 = format5.validateEmail(password7);
            bool actual7 = format5.validateEmail(password8);
            

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
            Assert.AreEqual(expected, actual4);
            Assert.AreEqual(expected, actual5);
            Assert.AreEqual(expected, actual6);
            Assert.AreEqual(expected, actual7);

        }


    }
}
