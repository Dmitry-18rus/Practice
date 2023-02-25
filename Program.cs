// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите целое число a ");
int a = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите целое число b ");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.WriteLine("Число a больше числа b ");
    Console.WriteLine("max=" + " "+ a );
}
else if(a<b)
{
    Console.WriteLine("Число b больше числа а");
    Console.WriteLine("max=" + " "+ b );
}
else 
{
    Console.WriteLine("Число а равно числу b");
}
