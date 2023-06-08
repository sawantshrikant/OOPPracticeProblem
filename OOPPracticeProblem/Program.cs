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
                Console.WriteLine("1. Count Duplicate Elements\n2. Print Unique Elements\n3. Count Frequency of Elements\n4. Exit\nEnter Your Option To Execute: ");
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
                        Console.WriteLine("Enter the elements of the array (comma-separated):");
                        string input3 = Console.ReadLine();
                        int[] arr3 = Array.ConvertAll(input3.Split(','), int.Parse);

                        FrequencyOfElements frequencyOfElements = new FrequencyOfElements();
                        Dictionary<int, int> frequencyDict = frequencyOfElements.GetElementFrequencies(arr3);

                        Console.WriteLine("Element frequencies:");
                        foreach (KeyValuePair<int, int> kvp in frequencyDict)
                        {
                            Console.WriteLine($"Element: {kvp.Key}, Frequency: {kvp.Value}");
                        }
                        break;
                    case 4:
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
