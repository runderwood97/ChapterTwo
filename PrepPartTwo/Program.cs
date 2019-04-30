using System;

namespace PrepPartTwo
{
    class Program
    {
        public static void PrintLetters(string[] letters)
	    {
		    int x;

		    for(x = 0; x < letters.Length; x++)
		    {
			    Console.WriteLine(letters[x]);
		    }
	    }

        static void Main(string[] args)
        {
            string[] letters = new string[] {"k", "d", "u", "q", "r"};
		    PrintLetters(letters);
        }
    }
}
