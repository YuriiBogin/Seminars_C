/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

void printNatural(int ctr)
    {
	    if (ctr == 0) return;
	        
	    Console.Write(" {0} ",ctr);
		printNatural(ctr-1);
    }
Console.WriteLine("Введите N:");
int c = Convert.ToInt32(Console.ReadLine());

if (c > 0) printNatural(c);
else 
Console.WriteLine("Введите введите натуральное N");
