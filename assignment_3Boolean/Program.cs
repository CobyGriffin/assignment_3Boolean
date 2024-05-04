namespace Assignment3_boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question_1();
            Question_2();
            Question_3();
        }// main
        public static void Menu()
        {
            Console.WriteLine("What question do you want to run?");
            Console.WriteLine("1 - Question 1");
            Console.WriteLine("2 - Question 2");
            Console.WriteLine("3 - Question 3");
           
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Question_1();
            }
            else if (userInput == "2")
            {
                Question_2();
            }
            else if (userInput == "3")
            {
                Question_3();
            }
            else
            {
                Console.WriteLine("Thank you and have a great day");
                Console.ReadKey();
            }

        }
        public static void Question_1();
        {
        double Tempature;

        Console.WriteLine("Enter a Tempature");

        if (Tempature <= 32) {
            Console.WriteLine("Thats freezing, be careful out there");
            } 
        
             else if (Tempature <= 50 && Tempature >= 33)
            {
            Console.WriteLine("It's really cold out, bring a jacket");
            }

            else if (Tempature <= 68 && Tempature >= 51)
            {
            Console.WriteLine("It's starting to get cold. A sweater should work");
            }
            else if (Tempature <= 75 && Tempature >= 69)
            {
            Console.WriteLine("It's comfortable out. A shirt and jeans will work")
            }
            else if (Tempature >= 76) 
            { 
            Console.WriteLine("It's T-shirt and shorts time");
            }
        }
        
    public static void Question_2()
{
    int number, remainder;

    Console.WriteLine("Please enter a number");

    number = Convert.ToInt32(Console.ReadLine());

    remainder = number % 2;

    if (remainder == 0)

        Console.WriteLine("{0} is an even number", number);

    else

        Console.WriteLine("{0} is an odd number", number);
}
public static void Question_3()
{
    int year;

    Console.WriteLine("Enter a year");

    year = int.Parse(Console.ReadLine());

    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
    {
        Console.WriteLine("{0} is a leap year.", year);


    }
    Console.ReadLine();
}


    }// class
}//name space