// Решение Задачи 6.

Console.Write("Введите целое число: ");
int userInput = int.Parse(Console.ReadLine() ?? "");

if (userInput % 2 == 0)
Console.WriteLine($"{userInput} -> является четным числом");

else if (userInput != 0)
Console.WriteLine($"{userInput} -> не является четным числом");