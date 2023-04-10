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
                Console.WriteLine("\nChoose option to perform \n1.Validate first name \n2.Validate last name \n3.Validate E-Mail \n4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter first name");
                        string firstName = Console.ReadLine();
                        reg.ValidateFirstName(firstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter last name");
                        string lastName = Console.ReadLine();
                        reg.ValidateLastName(lastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter E-Mail");
                        string eMail = Console.ReadLine();
                        reg.ValidateEmail(eMail);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
