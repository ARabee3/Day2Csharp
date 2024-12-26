using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assignment;
public class Person
{
    public string Name { get; set; }
}
internal class Program
{
    static void Main(string[] args)
    {
        #region Q1
        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());
        //Console.WriteLine(number);
        #endregion
        #region Q2
        //string str = "Hello123";
        //int num = int.Parse(str);
        //Console.WriteLine(num);

        /// Exception : System.FormatException: 'The input string 'Hello123' was not in a correct format.'

        #endregion
        #region Q3
        //float num1 = 5.5f;
        //float num2 = 6.6f;
        //float result = num1 + num2;
        //Console.WriteLine(result);
        //// will correctly print the result of the addition of the two numbers
        //Console.WriteLine(5.5 + 1.2); // will also correclty add the two numbers
        #endregion
        #region Q4
        //string str = "Hello World";
        //string subStr = str.Substring(6); // will only print from the start of index 6 till the end
        //Console.WriteLine(subStr);
        #endregion
        #region Q5
        //int num1 = 5;
        //int num2 = num1;
        //num1 = 10;
        //Console.WriteLine(num1); // will print 10
        //Console.WriteLine(num2); // will print 5
        //                         // Because int is a value type not a refernce type

        #endregion
        #region Q6
        //Person person1 = new Person { Name = "Ahmed" };
        //Person person2 = person1;

        //Console.WriteLine("Before modification:");
        //Console.WriteLine("person1 Name: " + person1.Name);
        //Console.WriteLine("person2 Name: " + person2.Name);


        //person2.Name = "Rabie";

        //Console.WriteLine("\nAfter modification:");
        //Console.WriteLine("person1.Name: " + person1.Name);
        //Console.WriteLine("person2.Name: " + person2.Name);
        //// will print the same every time because the 2 objects are pointing to the same memory location
        #endregion
        #region Q7
        //string str1 = "Hello";
        //string str2 = "World";
        //string str3 = str1 + ' ' + str2;
        //Console.WriteLine(str3);
        #endregion
        #region Q8
        //Console.Write("Enter the principal amount: ");
        //double principal = double.Parse(Console.ReadLine());
        //Console.Write("Enter the rate of interest: ");
        //double rate = double.Parse(Console.ReadLine());
        //Console.Write("Enter the time: ");
        //double time = double.Parse(Console.ReadLine());
        //double interest = (principal * rate * time) / 100;
        //Console.WriteLine(interest);
        #endregion
        #region Q9
        //Console.Write("Enter your weight in kilograms: ");
        //double weight = double.Parse(Console.ReadLine());
        //Console.Write("Enter your height in meters: ");
        //double height = double.Parse(Console.ReadLine());
        //double bmi = weight / (height * height);
        //Console.WriteLine("Your BMI is: " + bmi);
        #endregion
        #region Q10
        //int temprature = int.Parse(Console.ReadLine());
        //string result = temprature > 30 ? "Just Hot" : temprature < 10 ? "Just Cold" : "Just Good";
        //Console.WriteLine(result);
        #endregion
        #region Q11
        //// Solution 1
        //Console.Write("Enter the day: ");
        //int day = int.Parse(Console.ReadLine());
        //Console.Write("Enter the month: ");
        //int month = int.Parse(Console.ReadLine());
        //Console.Write("Enter the year: ");
        //int year = int.Parse(Console.ReadLine());
        //Console.WriteLine($" {day} , {month} , {year}");
        //Console.WriteLine($" {day} / {month} / {year}");
        //Console.WriteLine($" {day} - {month} - {year}");
        //// Solution 2
        //DateTime date = new DateTime(2004, 1, 7);
        //Console.WriteLine($"Date: {date:dd/dd/yyyy}");
        //Console.WriteLine($"Date: {date:dd-MM-yyyy}");
        //Console.WriteLine($"Date: {date:dd,MM,yyyy}");
        #endregion
        #region Q12
        // the correct answer is ((C)) The event is on 06/14/2024
        #endregion
        #region Q13
        // the correct answer is ((f)) A value 1 will be assigned to d.
        #endregion
        #region Q14
        // the correct answer is ((d)) 6 1.
        #endregion
        #region Q15
        // the correct answer is ((d)) 7 7.
        #endregion
    }


}

