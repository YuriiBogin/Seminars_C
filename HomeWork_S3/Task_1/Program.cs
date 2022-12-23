
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


Console.WriteLine("Введите пятизначное число");

string str = Console.ReadLine();

int[] b = new int[str.Length];

for( int i=0; i < str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
}

if ((b[0]==b[4]) & (b[1]==b[3])) Console.WriteLine($"Число {str} - палиндромом ");

else Console.WriteLine($"Число {str} - не палиндромом ");




