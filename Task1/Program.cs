//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число");
string usernumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(usernumber1);

System.Console.WriteLine("Введите второе число");
string usernumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(usernumber2);

if (number1 > number2)
{
    System.Console.WriteLine($"Число {number1} больше, чем число {number2}");
}
else
{
    System.Console.WriteLine($"Число {number2} больше, чем число {number1}");
}