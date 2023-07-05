/* Task1 Напишите программу, которая на вход принимает два числа и выдаёт большее. */


Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2)
{
    Console.WriteLine("большее = " + num1);
}
else
{
    Console.WriteLine("большее = " + num2);
}


/* Task2 Напишите программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел. */

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(max<num2) max = num2;
if(max<num3) max = num3;
    Console.WriteLine(max);


/* Task3 Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка). */

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num%2==0)
{
    Console.WriteLine(num + " четное");
}
else
{
    Console.WriteLine(num + " нечётное");
}

/* Task4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. */
Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
while(current<=num)
{
    if(current%2==0)
    Console.Write(current + " ");
    current++;
}