using System;

namespace OOPPracticeProblem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Object-Oriented Programming Practice Problem!");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Count Duplicate Elements\n2. Exit\nEnter Your Option To Execute: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the elements of the array (comma-separated):");
                        string input = Console.ReadLine();
                        int[] arr = Array.ConvertAll(input.Split(','), int.Parse);

                        DuplicateElements duplicateElements = new DuplicateElements();
                        int duplicateCount = DuplicateElements.CountDuplicateElements(arr);

                        Console.WriteLine($"Total number of duplicate elements: {duplicateCount}");
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }

        
    }
}
