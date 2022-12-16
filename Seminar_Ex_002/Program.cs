Console.Write("Введите целое число в диапозоне от 1 до 7: ");

int number = int.Parse(Console.ReadLine() ?? "");

if (number == 1)
    Console.WriteLine($"1 -> понедельник");
    else if (number == 2)
    {
        Console.WriteLine($"2 -> вторник");
    }
    else if (number == 3)
    {
        Console.WriteLine($"3 -> среда");
    }
    else if (number == 4)
    {
        Console.WriteLine($"4 -> четверг");
    }
    else if (number == 5)
    {
        Console.WriteLine($"5 -> пятница");
    }
    else if (number == 6)
    {
        Console.WriteLine($"6 -> суббота");
    }
    else if (number == 7)
    {
        Console.WriteLine($"7 -> воскресенье");
    }
    else
    {
        Console.WriteLine("Введено число, не удовлетворяющее условиям задачи");
    }