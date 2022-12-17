/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите три числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int m = a;

if ((m == a) & (m == b) & (m ==c ))
{
    Console.WriteLine($"Числа одинаковые");
}
else
{
if (m < b) m = b;
if (m < c) m = c;
Console.WriteLine($"Большее число {m}");
}

    
  
   