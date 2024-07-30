// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("Helo C#");
// Console.WriteLine(args[0]);


namespace HelloWorld
{
    internal static class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            float myFloat = 0.01f;
            double myDouble = 0.002;
            decimal myDecimal = 0.1m;
            string myString = "AAAAA";
            bool myBoolean = false;

            Console.WriteLine(myFloat.GetType());
        }
    }
    
}
