// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");

string usernumberN = Console.ReadLine();
int numberN = Convert.ToInt32(usernumberN);
int startNumber = 1;

while (numberN > startNumber)
{
    System.Console.Write($"{startNumber + 1}, ");
    startNumber += 2;
}
