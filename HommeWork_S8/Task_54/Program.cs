/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

void SortAr(int[,] matr)
{
    for  (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j<matr.GetLength(1);j++)
        {     
           int n = matr.GetLength(1);

            for (int x=0;x<n-1;x++)

            if (matr[i,x]<matr[i,x+1])

                {
                    int c=matr[i,x];

                    matr[i,x]=matr[i,x+1];

                    matr[i,x+1]=c;

                }
               
        }
               
    }    
}

Console.WriteLine("Введите массив m на n");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[n,m];
FillAr(matrix);
Console.WriteLine();
PrintAR(matrix);
SortAr(matrix);
Console.WriteLine();
PrintAR(matrix);