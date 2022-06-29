/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
{
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
 
if(num1 > num2)
    {
    Console.WriteLine("Первое число больше второго");
    }
        else if (num1 < num2)
            {
                Console.WriteLine("Первое число меньше второго");
            }
            else
            {
                Console.WriteLine("Оба числа равны");
            }
            Console.WriteLine();
}
*/
/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a, b, c;
Console.Write("Input a first number:  ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number:  ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a third number:  ");
c = Convert.ToInt32(Console.ReadLine());


{
if (a > b && a > c)
    Console.WriteLine("Max Number is = " + a); 
else 
  if (b > c)
    Console.WriteLine("Max Number is = " + b); 
  else
    Console.WriteLine("Max Number is = " + c); 
            
Console.WriteLine();
}
*/
/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
{
Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.Read());
if (a % 2 == 0) Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");
Console.Writeline();
}
*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
{
        Console.Write("Write number 1: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write number 2: ");
        int m = Convert.ToInt32(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.WriteLine(i + " ");
            }
        }
        Console.Writeline();
    }
*/