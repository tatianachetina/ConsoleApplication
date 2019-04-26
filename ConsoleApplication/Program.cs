using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Get name and location from user */
            Console.Write("Please enter your full name: ");
            var fullName = Console.ReadLine();

            Console.Write("Please enter your location: ");
            var location = Console.ReadLine();

            /* Output user information */
            Console.WriteLine($"Your name is: {fullName}");
            Console.WriteLine($"Your location is: {location}");

            // Days untill Christmas
            var today = DateTime.Now;

            var christmas = new DateTime(today.Year, 12, 25);

            // ToDo: calculate number of days untill Christmas and output days
            TimeSpan remaining =  christmas - today;
            Console.WriteLine($" {remaining.ToString("d' days 'hh' hours 'mm' minutes 'ss' seconds '")} days untill Christmas");

            // code from the book
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press 'Enter' to exit");
            // basic use of "Console.ReadKey()" method 
            Console.ReadKey();
        }
    }
}
