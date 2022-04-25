using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //OR - || = "или"

            //1. true || true => true
            //2. true || false => true
            //3. false || true => true
            //4. false || false => false

            //контрольные данные: username - admin, password - "1234"
            //Задание 2. Дополнить приложение, чтобы дать пользователю только 3 попытки для входа в систему

            string username, password;
            int i = 0;

            Console.WriteLine("You have three tries");
            

            while (i < 3)
            {
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();

                Console.WriteLine("Enter password");
                password = Console.ReadLine();

                if (username != "admin" || password != "1234")
                {
                    i++;
                    Console.WriteLine("Access denied. Wrong username or password.");
                    Console.WriteLine($"You have {3 - i} tries left");
                }

                else
                {
                    Console.WriteLine("Welcome");
                    break;
                }


            }
        }
    }
}
