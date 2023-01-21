/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

string[] AR; 
int count; 
string s;
string[] AR2; 
int kol = 0;

Console.WriteLine("Введите любые целые числа, через Enter. Для остановки введите stop.");

count = 0; 
AR = new string[count]; 

do
    {
        
    s = Console.ReadLine();

    if ((s!="") && (s!="stop"))
        {
          
        count++;
          
        AR2 = new string[count];

        for (int i = 0; i < AR2.Length - 1; i++)
            AR2[i] = AR[i];

        AR2[count - 1] = s;

        AR = AR2;
        }
} while (s != "stop");

int[] ints = Array.ConvertAll(AR, s => int.Parse(s));
//Console.WriteLine(String.Join(",", ints));

for (int i = 0; i<ints.Length;i++)
{
    if (ints[i]>0) kol ++;
}
Console.WriteLine($"Колличество положительных чисел  = {kol}");

