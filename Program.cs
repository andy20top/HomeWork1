// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число:");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);

Console.WriteLine("Введите второе число:");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);

if (num1 > num2) Console.WriteLine($"Число {num1} больше");
else Console.WriteLine($"Число {num2} больше");


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число:");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);

Console.WriteLine("Введите второе число:");
string strNum2 = Console.ReadLine();
int num2 = int.Parse(strNum2);

Console.WriteLine("Введите третье число:");
string strNum3 = Console.ReadLine();
int num3 = int.Parse(strNum3);

if (num1 > num2 && num1 > num3) Console.WriteLine($"Число {num1} больше"); 
else if (num2 > num1 && num2 > num3) Console.WriteLine($"Число {num2} больше");
else if (num3 > num1 && num3 > num2) Console.WriteLine($"Число {num3} больше");
else Console.WriteLine("Какие-то числа равны :)");

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число для проверки его на четность");
string strNum1 = Console.ReadLine();
int num1 = int.Parse(strNum1);

if (num1 % 2 == 0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число. Программа выведет все четные числа от 1 до вашего числа");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int numCount = 1;

while (numCount <= num)
{
    if (numCount % 2 == 0) Console.Write ($"{numCount}; ");
    numCount++;
}