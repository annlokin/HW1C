// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число");
string usernumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(usernumber1);

System.Console.WriteLine("Введите второе число");
string usernumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(usernumber2);

System.Console.WriteLine("Введите третье число");
string usernumber3 = Console.ReadLine();
int number3 = Convert.ToInt32(usernumber3);

int MaxNumber = number1;

if (number2 > MaxNumber)
{
    System.Console.WriteLine($"Число {number2} максимальное");
}
else if (number3 > MaxNumber)
{
    System.Console.WriteLine($"Число {number3} максимальное");
}
else 
{
    System.Console.WriteLine($"Число {number1} максимальное");
}


