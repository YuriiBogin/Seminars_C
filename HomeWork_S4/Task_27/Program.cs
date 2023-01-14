/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int ReadNumber(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());

}

int GetSum1ToA(int a)
{
    int count = 0;
    while (a != 0)
    {
        
        int chislo = a%10;
        count = count + chislo;
        a=a/10;
    }

    return count;
}
int number = ReadNumber("Введите число ");

if (number>0)
{
    int kol = GetSum1ToA(number);
    Console.WriteLine($"Сумма цифр в числе = {kol}");
}
else
{
    Console.WriteLine($"Введите правильное число");
}
