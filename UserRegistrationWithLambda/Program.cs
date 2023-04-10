using System;
namespace UserRegistrationWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true; 
            UserOperation reg = new UserOperation();
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Validate first name \n2.Validate last name \n3.Validate E-Mail \n4.Validate Phone number \n5.Validate Password \n6.Validate all mails \n7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter first name");                        
                        bool result = reg.ValidateFirstNameByLambda();
                        if (result)
                            Console.WriteLine("Valid");
                        else 
                            Console.WriteLine("Invalid"); 
                        break;
                    case 2:
                        Console.WriteLine("Enter last name");
                        bool result1 = reg.ValidateLastNameByLambda();
                        if (result1)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 3:
                        Console.WriteLine("Enter E-Mail");
                        bool res = reg.ValidateEmailByLambda();
                        if (res)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 4:
                        Console.WriteLine("Enter Phone number");
                        bool res1 = reg.ValidateMobileNumberByLambda();
                        if (res1)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 5:
                        Console.WriteLine("Enter Password");
                        bool res2 = reg.ValidatePasswordByLambda();
                        if (res2)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                        break;
                    //case 6:
                    //    reg.ValidateEmails();
                    //    break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}
