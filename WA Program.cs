using System;

class WA
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Q1");
        int num = -5;

        string result = num > 0 ? "Positive" : num < 0 ? "Negative" : "Zero";
        Console.WriteLine(result);

        Console.WriteLine("Q2");
        int num2 = 2;
        if (num2 > 0)
        {
            if (num2 > 1)
            {
                if (num2 > 2)
                {
                    Console.WriteLine("Number is greater than 2");
                }
            }
        }
        int num3 = 3;
        if (num3 > 0 && num3 > 1 && num3 > 2)
        {
            Console.WriteLine("Number is greater than 2 \n");

        }

        Console.WriteLine("Q3");
        int min_bal = 10000;
        int limit = 20000;
        int amount = Convert.ToInt32(Console.ReadLine());

        if (amount <= min_bal)
        {
            if (limit <= min_bal)
            {
                Console.WriteLine("Allowed");
            }
        }
        else
        {
            Console.WriteLine("Rejected");
        }

        Console.WriteLine("Q4");
        string password = "Pass@123"; // input inside code

        bool hasDigit = false;
        bool hasSpecialChar = false;

        for (int i = 0; i < password.Length; i++)
        {
            char ch = password[i];

            if (ch >= '0' && ch <= '9')
            {
                hasDigit = true;
            }
            else if (!(ch >= 'a' && ch <= 'z') && !(ch >= 'A' && ch <= 'Z'))
            {
                hasSpecialChar = true;
            }
        }

        if (password.Length >= 8 && hasDigit && hasSpecialChar)
        {
            Console.WriteLine("Strong");
        }
        else if ((password.Length >= 8 && hasDigit) ||
                 (password.Length >= 8 && hasSpecialChar) ||
                 (hasDigit && hasSpecialChar))
        {
            Console.WriteLine("Medium");
        }
        else
        {
            Console.WriteLine("Weak");
        }

        Console.WriteLine("Q5");
        int a = -5;
        int b = a * -1;
        Console.WriteLine($"Absolute Value is {b}");

        Console.WriteLine("Q6");
        int c = 15;
        if(c%3==0 && c%5 == 0)
        {
            Console.WriteLine($"{c} is Divisible by 3 and 5");
        }

        Console.WriteLine("Q6");
        int degrees = 32;
        if (degrees == 0)
        {
            Console.WriteLine("Freezing");
        }
        else if(degrees>0 && degrees < 20)
        {
            Console.WriteLine("Cold");
        }
        else if(degrees>21 && degrees < 35)
        {
            Console.WriteLine("Warm");
        }
        else
        {
            Console.WriteLine("Hot");
        }
        Console.WriteLine("Q7");

        string customer = "Jack";
        bool isPrime = true;
        bool isRestaurantOpen = true;
        bool isDeliveryAvailable = true;
        int orderAmount = 150;

        if (isRestaurantOpen && isDeliveryAvailable)
        {
            if (isPrime || orderAmount >= 200)
            {
                Console.WriteLine("Order Accepted");
            }
            else
            {
                Console.WriteLine("Order Rejected");
            }
        }
        else
        {
            Console.WriteLine("Order Rejected");
        }

    }
}
