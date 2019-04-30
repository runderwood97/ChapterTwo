using System;

namespace PrepPartThree
{
    class Program
    {
        public static void PrintNumbers(string[] numbers)
	    {
		    int x;

		    for(x = 0; x < numbers.Length; x++)
		    {
			    Console.WriteLine(numbers[x]);
		    }
	    }
        
        static void Main(string[] args)
        {
            string[] numbers = new string[] {"1", "1", "2", "3", "5", "8"};
		    PrintNumbers(numbers);
        }
    }
}
