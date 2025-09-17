using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        bool IsEven(int x)
        {
            return x % 2 == 0;
        }
        string GetMessage(int x)
        {
            if (IsEven(x))
            {
                return "Двері відкриваються";
            }
            return "Двері зачинені";
        }
        if (int.TryParse(Console.ReadLine(), out int enteredNumb))
        {
            Console.WriteLine(GetMessage(enteredNumb));
        }
        else
        {
            Console.WriteLine("Неправильний ввід");
        }
    }
}

