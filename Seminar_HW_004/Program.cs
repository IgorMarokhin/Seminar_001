// Решение Задачи 8. 

Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine() ?? "");

Console.Write($"{N} -> ");

for (int count = 2; count < N; count++)

    if (count % 2 == 0)
    
        Console.Write($"{count}, ");

Console.WriteLine();