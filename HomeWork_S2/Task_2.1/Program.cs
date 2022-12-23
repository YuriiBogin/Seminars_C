Console.WriteLine("Введите  число");

int a = Convert.ToInt32(Console.ReadLine());
int b =a;

a = Math.Abs(a);

if  (a>99) 
{
while (a >= 1000) a /= 10;

int d = a % 10;

Console.WriteLine($"Третья цифра числа {b} = {d} ");
}
else Console.WriteLine($"Третьей цифры в числе {b} - нет ");
