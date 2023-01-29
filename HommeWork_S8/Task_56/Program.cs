 /*Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
void PrintAR(int[,] matr)
{
    for  (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j<matr.GetLength(1);j++)
        {                        
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillAr(int[,] matr)
{
    for  (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j<matr.GetLength(1);j++)
        {
            matr[i,j] = new Random().Next(1,10);
                        
        }
    }    
}

Console.WriteLine("Введите массив m на n");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,m];

int[] array = new int[matrix.GetLength(0)];

FillAr(matrix);
Console.WriteLine();
PrintAR(matrix);
Console.WriteLine();

for  (int i = 0; i < matrix.GetLength(0); i++)
     {
         int sum=0;
         for (int j = 0; j<matrix.GetLength(1);j++)
         {
            sum = sum + matrix[i,j];
         }
         array[i] = sum;
     } 

int min = array[0];
int k = 0;
for (int i = 0; i<array.Length; i++) 
{
    if (array[i]<min)
    { 
        min=array[i];
        k = i; 
    }
   
}
Console.WriteLine($" Номер строки с минимальной суммой элементов  = {k+1}");