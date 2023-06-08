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
                Console.WriteLine("1. Count Duplicate Elements\n2. Print Unique Elements\n3. Exit\nEnter Your Option To Execute: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the elements of the array (comma-separated):");
                        string input1 = Console.ReadLine();
                        int[] arr1 = Array.ConvertAll(input1.Split(','), int.Parse);

                        DuplicateElements duplicateElements = new DuplicateElements();
                        int duplicateCount = DuplicateElements.CountDuplicateElements(arr1);

                        Console.WriteLine($"Total number of duplicate elements: {duplicateCount}");
                        break;
                    case 2:
                        Console.WriteLine("Enter the elements of the array (comma-separated):");
                        string input2 = Console.ReadLine();
                        int[] arr2 = Array.ConvertAll(input2.Split(','), int.Parse);

                        UniqueElements uniqueElements = new UniqueElements();
                        int[] uniqueArr = uniqueElements.GetUniqueElements(arr2);

                        Console.WriteLine("Unique elements in the array:");
                        foreach (int num in uniqueArr)
                        {
                            Console.WriteLine(num);
                        }
                        break;
                    case 3:
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
