// Решение Задачи 4.

Console.Write("Введите первое целое число: ");
int userInput1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе целое число: ");
int userInput2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третье целое число: ");
int userInput3 = int.Parse(Console.ReadLine() ?? "");

int maxInput = 0;

if (userInput1 > userInput2)
maxInput = userInput1;

else if (userInput1 < userInput2)
maxInput = userInput2;

if (userInput3 > maxInput)
maxInput = userInput3;

Console.WriteLine($"a = {userInput1}, b = {userInput2}, c = {userInput3}. Максимальное число равняется: {maxInput}");