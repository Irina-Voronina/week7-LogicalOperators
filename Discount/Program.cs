using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение спрашивает пользователя, на какую сумму он сделал покупку в магазине "Н"
            //если сумма чека составила больше 10 евро, то пользователь получает скидку на следующую покупку в размере 1 евро
            //если сумма чека, составляет от 20 евро до 50 евро, то скидка на следующую покупку 5 евро
            //если сумма чека от 50 - 100 евро, то скидка на следующую покупку 10 евро
            //если сумма чека превышает 100 евро, то скидка на следующую покупку составляет 15 евро

            //позволить пользователю ввести общую стоимость его чека
            //в ответ он получит, какую скидку он получит в следующий раз


            Console.WriteLine("What is the purchase amount of your check in our store?");
            Console.WriteLine("Enter amount (integer) : ");
            int totalCost = Convert.ToInt32(Console.ReadLine());

            if(totalCost < 10)
            {
                Console.WriteLine("Unfortunately next time there will be no discount.");
            }
            else if (totalCost >= 10 && totalCost <= 20)
            {
                Console.WriteLine("Your discount on your next purchase in our store will be 1 euro");
            }
            else if (totalCost > 20 && totalCost <= 50)
            {
                Console.WriteLine("Your discount on your next purchase in our store will be 5 euro");
            }
            else if (totalCost > 50 && totalCost <= 100)
            {
                Console.WriteLine("Your discount on your next purchase in our store will be 10 euro");
            }
            else
            {
                Console.WriteLine("Your discount on your next purchase in our store will be 15 euro");
            }

            Console.WriteLine("Have a nice day!");
        }
    }
}
