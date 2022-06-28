/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/*Console.WriteLine("Задача 2");
Console.WriteLine("Введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Меньшее число " + number2);
    Console.WriteLine("Большее число " + number1);
} 
else
{
    Console.WriteLine("Меньшее число " + number1);
    Console.WriteLine("Большее число " + number2);
}*/

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/*Console.WriteLine("Задача 4");
Console.WriteLine("Введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3 ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (number2 > max)
{
    max = number2;
} 
if (number3 > max)
{
    max = number3;
} 
Console.WriteLine("<Большее число " + max); */

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

/* Console.WriteLine("Задача 6");
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
{
  Console.WriteLine("Четное число");
} 
else
{
   Console.WriteLine("Нечетное число"); 
}*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Задача 8");
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
  if (i%2 == 0)
  {
    Console.Write(i + " ");
  }  
}
Console.WriteLine();

