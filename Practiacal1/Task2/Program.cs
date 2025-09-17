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
        int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;
        }
        double GetAverage(int[] numbers)
        {
            int avg = GetSum(numbers) / numbers.Length;
            return avg;
        }
        int GetMin(int[] numbers) {
            int min = int.MaxValue;
            foreach (int i in numbers)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
        int GetMax(int[] numbers)
        {
            int max = int.MinValue;
            foreach (int i in numbers)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        int InputInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int enteredNumb))
                {
                    return enteredNumb;
                }
                Console.WriteLine("Неправильний ввід");
            }
        }
        Console.Write("Введіть довжину масиву: ");
        int size = InputInt();

        Console.Write("Введіть мінімальне значення: ");
        int min = InputInt();

        Console.Write("Введіть максимальне значення: ");
        int max = InputInt();
        int[] arr = GenerateRandomArray(size, min, max);

    }
}