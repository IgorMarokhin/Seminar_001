Console.Write("Введите первое целое число: ");
int userInput1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе целое число: ");
int userInput2 = int.Parse(Console.ReadLine() ?? "");

if (userInput1 == userInput2 * userInput2)
Console.WriteLine($"a = {userInput1}, b = {userInput2} -> да");

else if (userInput1 != userInput2 * userInput2)
Console.WriteLine($"a = {userInput1}, b = {userInput2} -> нет");