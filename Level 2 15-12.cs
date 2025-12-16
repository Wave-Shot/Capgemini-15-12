using System;

class Level2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Q1");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double division1 = num1 / num2;
        double modulus = num1 % num2;
        Console.WriteLine($"The Quotient is {division1} and Remainder is {modulus} of two numbers {num1} and {num2}\n");

        Console.WriteLine("Q2");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int op1 = a + (b * c);
        int op2 = (a * b) + c;
        int op3 = c + (a / b);
        int op4 = c + (a % b);
        Console.WriteLine($"The results of Int Operations are {op1}, {op2}, {op3} and {op4}");

        Console.WriteLine("Q3");
        double a1 = Convert.ToDouble(Console.ReadLine());
        double b1 = Convert.ToDouble(Console.ReadLine());
        double c1 = Convert.ToDouble(Console.ReadLine());
        double op11 = a1 + (b1 * c1);
        double op21 = (a1 * b1) + c1;
        double op31 = c1 + (a1 / b1);
        double op41 = c1 + (a1 % b1);
        Console.WriteLine($"The results of Int Operations are {op11}, {op21}, {op31} and {op41}");

        Console.Write("Q4");
        double Cdegrees = Convert.ToDouble(Console.ReadLine());
        double Farenheit = (Cdegrees * 9.0 / 5.0) + 32;
        Console.WriteLine($"The {Cdegrees} Celsius is {Farenheit} Fahrenheit");

        Console.WriteLine("Q5");
        double Farenheit2 = Convert.ToDouble(Console.ReadLine());
        double Cdegrees2 = (Farenheit2 - 32) * 5.0 / 9.0;
        Console.WriteLine($"The {Cdegrees2} Celsius is {Farenheit2} Fahrenheit");

        Console.WriteLine("Q6");
        double salary = Convert.ToDouble(Console.ReadLine());
        double bonus = Convert.ToDouble(Console.ReadLine());
        double income = salary + bonus;
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {income}");

        Console.WriteLine("Q7");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int temp = n1;
        n1 = n2;
        n2 = temp;
        Console.WriteLine($"The swapped numbers are {n1} and {n2}\n");

        Console.WriteLine("Q8");
        string name = "Eric";
        string fromCity = "Chennai", viaCity = "Vellore", toCity = "Bangalore";

        double distanceFromToVia = Convert.ToDouble(Console.ReadLine());
        int timeFromToVia = Convert.ToInt32(Console.ReadLine());
        double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());
        int timeViaToFinalCity = Convert.ToInt32(Console.ReadLine());

        double totalDistance = distanceFromToVia + distanceViaToFinalCity;
        int totalTime = timeFromToVia + timeViaToFinalCity;

        Console.WriteLine($"The Total Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance} km and the Total Time taken is {totalTime} minutes");

        Console.WriteLine("Q9");
        double side1 = Convert.ToDouble(Console.ReadLine());
        double side2 = Convert.ToDouble(Console.ReadLine());
        double side3 = Convert.ToDouble(Console.ReadLine());
        double perimeter = side1 + side2 + side3;
        Console.WriteLine($"The total number of rounds the athlete will run is {perimeter} to complete 5 km\r\n");

        Console.WriteLine("Q10");
        int numberofChocolates = Convert.ToInt32(Console.ReadLine());
        int numberofChildren = Convert.ToInt32(Console.ReadLine());
        int division2 = numberofChocolates / numberofChildren;
        int remainder = numberofChocolates % numberofChildren;
        Console.WriteLine($" The number of chocolates each child gets is {division2} and the number of remaining chocolates is {remainder}\r\n");

        Console.WriteLine("Q11");
        double principle = Convert.ToDouble(Console.ReadLine());
        double interest = Convert.ToDouble(Console.ReadLine());
        double time = Convert.ToDouble(Console.ReadLine());
        double SI = principle * interest * time / 100;
        Console.WriteLine($"The Simple Interest is {SI} for Principal {principle}, Rate of Interest {interest} and Time {time}\r\n");

        Console.WriteLine("Q12");
        int weight = Convert.ToInt32(Console.ReadLine());
        double inPound = weight * 2.2;
        Console.WriteLine($"The weight of the person in pounds is {inPound} and in kg is {weight}");
    }
}
