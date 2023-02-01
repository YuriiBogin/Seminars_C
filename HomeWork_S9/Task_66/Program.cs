/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int printNatural(int ctr, int x)
    {
	    if (ctr == x+1) return 0;
	   		 	    
        return   ctr + printNatural(ctr+1,x); 
    }
Console.WriteLine("Введите m:");    
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( $"Sum= {printNatural(m,n)}");  