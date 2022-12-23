/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.Write("Введите  число N: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"{n} -> ");

for( int i=1; i < n+1; i++)
{
Console.Write($"{i*i*i}, ");
}