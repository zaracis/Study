/*
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is " + num);

    int sotni = num /100;
    int ed = num % 10;
    int result = sotni * 10 + ed;
    return result;
}


int number = CutNumber();
Console.WriteLine("Result is " + number);
*/

/*
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int MaxNumber()
{
    int num = new Random().Next(10,100);
    Console.WriteLine("Current random number is " + num);

    int desyat = num /10;
    int ed = num % 10;
    if(desyat > ed)
    {
        return desyat;
    }
    else
    {
        return ed;
    }
}
int number = MaxNumber();
Console.WriteLine("Result is " + number);
*/
/*
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
void NumberDel(int x)
{
    Console.WriteLine("Input number: ");
    if(x % 7 == 0 & x % 23 == 0)
        Console.WriteLine("Yes");
}

Console.WriteLine("Result is ");
*/

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
void IsQuad(int num1, int num2)
{
    int quad2 = num2 * num2;
    int quad1 = num1 * num1;
    if(num1 == quad2)
        Console.WriteLine("Yes");
    else
        if(num2 == quad1)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
}

IsQuad();