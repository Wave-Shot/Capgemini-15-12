using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1. Write a program to find the age of Harry if the birth year is 2000. Assume the Current Year is 2024");
        int birthYear = 2000;
        int currentYear = 2024;
        int age = currentYear - birthYear;
        Console.WriteLine($"Harry's age in 2024 is {age}\n");

        Console.WriteLine("2. Sam’s mark in Maths is 94, Physics is 95, and Chemistry is 96 out of 100. Find the average percent mark in PCM");
        int maths = 94;
        int physics = 95;
        int chemistry = 96;
        int average = (maths + physics + chemistry) / 3;
        Console.WriteLine($"Sam’s average mark in PCM is {average}\n");

        Console.WriteLine("3. Create a program to convert the distance of 10.8 kilometers to miles");
        double km = 10.8;
        double miles = km * 1.6;
        Console.WriteLine($"The distance {km} km in miles is {miles}\n");

        Console.WriteLine("4. Create a program to calculate the profit and loss in number and percentage");
        int costPrice = 129;
        int sellingPrice = 191;
        int profit = sellingPrice - costPrice;
        double profitPercentage = (double)profit / costPrice * 100;
        Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}");
        Console.WriteLine($"The Profit is INR {profit} and the Profit Percentage is {profitPercentage}\n");

        Console.WriteLine("5. Divide 14 pens among 3 students equally");
        int totalPens = 14;
        int students = 3;
        int pensPerStudent = totalPens / students;
        int remainingPens = totalPens % students;
        Console.WriteLine($"The Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {remainingPens}\n");

        Console.WriteLine("6. University fee discount for fixed values");
        double fee = 125000;
        double discountPercent = 10;
        double discount = fee * discountPercent / 100;
        double finalFee = fee - discount;
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}\n");

        Console.WriteLine("7. Compute the volume of Earth in km^3 and miles^3");
        double radius = 6378;
        double volumeKm = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
        double volumeMiles = volumeKm * 1.6;
        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm} and cubic miles is {volumeMiles}\n");

        Console.WriteLine("8. Convert distance in kilometers to miles using user input");
        Console.Write("Enter km: ");
        double userKm = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The total miles is {userKm * 1.6} mile for the given {userKm} km\n");

        Console.WriteLine("9. University fee discount using user input");
        Console.Write("Enter fee: ");
        double userFee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter discount percent: ");
        double userDiscountPercent = Convert.ToDouble(Console.ReadLine());
        double userDiscount = userFee * userDiscountPercent / 100;
        Console.WriteLine($"The discount amount is INR {userDiscount} and final discounted fee is INR {userFee - userDiscount}\n");

        Console.WriteLine("10. Convert height in centimeters to feet and inches");
        Console.Write("Enter height in cm: ");
        double cm = Convert.ToDouble(Console.ReadLine());
        double inches = cm / 2.54;
        int feet = (int)(inches / 12);
        inches = inches % 12;
        Console.WriteLine($"Your Height in cm is {cm} while in feet is {feet} and inches is {inches}\n");

        Console.WriteLine("11. Basic calculator using two numbers");
        Console.Write("Enter number1: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number2: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {n1} and {n2} is {n1 + n2}, {n1 - n2}, {n1 * n2}, {n1 / n2}\n");

        Console.WriteLine("12. Find area of triangle");
        Console.Write("Enter base: ");
        double baseVal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Area of triangle is {0.5 * baseVal * height}\n");

        Console.WriteLine("13. Find side of square from perimeter");
        Console.Write("Enter perimeter: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The length of the side is {perimeter / 4} whose perimeter is {perimeter}\n");

        Console.WriteLine("14. Find distance in yards and miles for the distance provided in feet");
        double distanceInFeet = 36;
        double yards = distanceInFeet / 3;
        double milesFromFeet = yards / 1760;
        Console.WriteLine($"Distance in yards is {yards} and in miles is {milesFromFeet}\n");

        Console.WriteLine("15. Calculate total price based on unit price and quantity");
        double unitPrice = 250;
        int quantity = 4;
        double totalPrice = unitPrice * quantity;
        Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity {quantity} and unit price is INR {unitPrice}\n");

        Console.WriteLine("16. Find maximum number of handshakes among N students");
        int numberOfStudents = 10;
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        Console.WriteLine($"The maximum number of handshakes is {handshakes}");

        Console.ReadLine();
    }
}
