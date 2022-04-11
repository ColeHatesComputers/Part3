using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Greetings();
            Adder();
            Distance();
            Hypotenuse();
        }
        
        public static void Greetings()
        {
            string name;
            int age;
            int year;

            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your chronological age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the current year:");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name is {name} and you were born in {year - age}.");
        }
        
        public static void Adder()
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Please enter your first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your third number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" The sum of the three numbers you entered is {num1 + num2 + num3}.");
        }
        public static void Distance()
        {
            double dis1;
            double dis2;
            double dis3;
            double average;
            Console.WriteLine("Enter your first distance:");
            dis1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second distance:");
            dis2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your third distance:");
            dis3 = Convert.ToDouble(Console.ReadLine());

            average = (dis1 + dis2 + dis3) / 3;
           Console.WriteLine($"The average distance of those three is {Math.Round(average, 2)}");
                
        }
        public static void Hypotenuse()
        {
            double leg1;
            double leg2;
            double hypotenuse;

            Console.WriteLine("Please enter your first leg length:");
            leg1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your second leg length:");
            leg2 = Convert.ToDouble(Console.ReadLine());

            hypotenuse = Math.Sqrt(leg1 * leg1) + (leg2 * leg2);
            Console.WriteLine($"The hypotenuse is {hypotenuse}.");
        }





    }
}
