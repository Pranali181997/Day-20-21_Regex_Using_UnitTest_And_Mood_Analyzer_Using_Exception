using System;

namespace Day19_Regex
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");

            AddPincode addPincode = new AddPincode();
            Console.WriteLine("400088 is valid "+ addPincode.validatepin("400088"));
            //Console.WriteLine("400 088 is valid "+addPincode.validatePinCode("400 088"));

            EmailForAllCase addmail = new EmailForAllCase();
            Console.WriteLine("abc@yahoo.com " + addmail.validateEmail("abc@yahoo.com"));
            Console.WriteLine("abc-100@yahoo.com " + addmail.validateEmail("abc-100@yahoo.com"));
            Console.WriteLine("abc.100@yahoo.com " + addmail.validateEmail("abc.100@yahoo.com"));
            Console.WriteLine("abc.111@abc.com " + addmail.validateEmail("abc.111@abc.com"));
            Console.WriteLine("abc-100@abc.net " + addmail.validateEmail("abc-100@abc.net"));
            Console.WriteLine("abc.100@abc.com.au " + addmail.validateEmail("abc.100@abc.com.au"));
            Console.WriteLine("abc@1.com " + addmail.validateEmail("abc@1.com"));
            Console.WriteLine("abc@gmail.com.com " + addmail.validateEmail("abc@gmail.com.com"));
            Console.WriteLine("abc+100@gmail.com " + addmail.validateEmail("abc+100@gmail.com"));

            UserRagistration user = new UserRagistration();
            LastName user1 = new LastName();
            Valid_Email user2 = new Valid_Email();
            Mobile_Format user3 = new Mobile_Format();
            PassUC_5 user4 = new PassUC_5();
            PassUC_6 user5 = new PassUC_6();
            PassUC_7 user6 = new PassUC_7();
            PassUC_8 user7 = new PassUC_8();
            EmailForAllCase user8 = new EmailForAllCase();

            Console.WriteLine("The user name is " + user.validateName("Pranali"));
            Console.WriteLine("The user LastName is " + user1.validateName("Lambat"));
            Console.WriteLine("The user Email is " + user2.validEmail("abc.xyz@bl.co.in"));
            Console.WriteLine("The user Mobile Number is " + user3.validMobile("+918999408496"));
            Console.WriteLine("The user Password as per Rule-1 is " + user4.validPassword("xvHAJD55"));
            Console.WriteLine("The user Password as per Rule-2 is " + user5.validPasswordRule2("xvHAJD55"));
            Console.WriteLine("The user Password as per Rule-3 is " + user6.validPasswordRule3("xvHAJD55"));
            Console.WriteLine("The user Password as per Rule-4 is " + user7.validPasswordRule4("Ab1@@hijn"));
            Console.WriteLine("The user Email is " + user8.validateEmail("pranali.@gmail.com"));
        }
    }
}
