using System;

namespace MasterCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID code:");
            string usersID = Console.ReadLine();
            if (Validate(usersID))
            {
                Console.WriteLine("Welcome!");
                HelloUser(usersID);
               

            }else
            {
                Console.WriteLine("Wrong format.Try again.");
            }
        }

        public static bool Validate(string idCode)
        {
            if (idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }

            }else
            {
                return false;
            }
        }

        public static void HelloUser(string idCode)
        {
            int FirstNum = Int32.Parse(idCode[0].ToString());
            if (FirstNum == 1 || FirstNum == 3 || FirstNum == 5)
            {
                Console.WriteLine("Hello,sir!");

            }
            else if (FirstNum == 2 || FirstNum == 4 || FirstNum == 6)
            {
                Console.WriteLine("Hello,Madam!");
                Console.WriteLine("Enter your CVV code:");
                string Userinput = Console.ReadLine();
                if (CVVValidations(Userinput))
                {
                    Console.WriteLine("Welcome!");
                }
                else
                {
                    Console.WriteLine("Go away!");
                }

            }
            

        }
        public static bool CVVValidations(string Cvvcode)
        {

            if (Cvvcode.Length == 3)
            {
                try
                {
                    Int32.Parse(Cvvcode);
                    return true;

                }
                catch (Exception error)
                {
                    Console.WriteLine("Failed to parse.");
                    return false;
                }


            }
            else
            {
                return false;

            }

        }
    }
}
        
    

