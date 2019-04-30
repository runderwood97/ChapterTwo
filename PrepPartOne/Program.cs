using System;

namespace PrepPartOne
{
    class Program
    {
        public static void Add(int[] numbers)
	    {
		    int x;
		    int sum = 0;

		    for(x = 0; x < numbers.Length; x++)
		    {
			    sum += numbers[x];
		    }

		    Console.WriteLine("The sum of this array is {0}", sum);
	    }
        
        static void Main(string[] args)
        {
            int[] numbers = new int[] {7, 3, 29, 52, 42, 27, 3, 5, 9, 100};
		    Add(numbers); 
        }
    }
}
