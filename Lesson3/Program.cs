namespace Lesson3
{
    internal class Program
    {
        //Create delegate printString
        public delegate void MyFirstDelegate(string message);

        static void Main(string[] args)
        {
            MyFirstDelegate green = PrintGreen;
            MyFirstDelegate orange = PrintOrange;
            MyFirstDelegate defaultColor = DefaultColor;

            MyFirstDelegate line = green + orange + defaultColor;

            green("___Green___");

            orange("___Orange___");

            line("");
        }

        //method that takes a string as input and returns nothing
        //the first prints the string to the console with green color

        //the second one prints it to the console with orange color.

        static void PrintGreen(string text) 
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
        }

        static void PrintOrange(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
        }

        static void DefaultColor(string text)
        {
            Console.ResetColor();
        }
    }
}