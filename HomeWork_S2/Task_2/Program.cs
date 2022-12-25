/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число");

string a = Console.ReadLine();

if (a[0] == '-')
{

if ((a.Length == 2)^ (a.Length == 1)) Console.WriteLine($"Третья цифра числа {a} - нет ");

else Console.WriteLine($"Третья цифра числа {a} = {a[3]} ");
}
else 
{
 if ((a.Length == 2)^ (a.Length == 1)) Console.WriteLine($"Третья цифра числа {a} - нет ");

else Console.WriteLine($"Третья цифра числа {a} = {a[2]} ");

}