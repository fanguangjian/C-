// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("Helo C#");
// Console.WriteLine(args[0]);


namespace HelloWorld
{
    internal static class Program {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello world");

            // float myFloat = 0.01f;
            // double myDouble = 0.002;
            // decimal myDecimal = 0.1m;
            // string myString = "AAAAA";
            // bool myBoolean = false;

            // Console.WriteLine(myFloat.GetType());

            int[] intsToCompress = new int[] {10,11,11,22,33,12,14};
            int totalValue = 0;
            DateTime startTime = DateTime.Now;

            for (int i = 0; i < intsToCompress.Length; i++)
            {
                // Console.WriteLine(intsToCompress[i]);
                totalValue += intsToCompress[i];
            } 
            Console.WriteLine( (DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            // foreach (var item in intsToCompress)
            // {
            //     Console.WriteLine(item);
            // }
            
            startTime = DateTime.Now;
            foreach (int item in intsToCompress)  // foreach is faster than for loop
            {
                // Console.WriteLine(item);
                totalValue += item;
            }
            Console.WriteLine( (DateTime.Now - startTime).TotalSeconds);



        
        }
    }
    
}
