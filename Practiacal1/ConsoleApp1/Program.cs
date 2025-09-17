using System;

class Program
{
    static void Main()
    {
        int[] GenerateRandomArray(int size, int min, int max)
        {
            int[] numbers = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(min, max);
            }
            return numbers;
        }
        int[] arr = GenerateRandomArray(5, 1, 100);
        Console.WriteLine(string.Join(", ", arr));
    }
}