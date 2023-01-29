/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int n = 4;

int i = 1, j, k;

int p = n/2;

int[,] A = new int[n,n];

Console.WriteLine($"Заполнение матрицы по спирали");

for (k = 1; k <= p; k++) 
    {
        for (j = (k-1); j < (n-k+1); j++) A[(k-1),j] = i++;

        for (j = k; j < (n-k+1); j++) A[j,n-k] = i++;

        for (j = (n-k-1); j >= (k-1); j--) A[n-k,j] = i++;

        for (j = (n-k-1); j >= k; j--) A[j,(k-1)] = i++;
    }

for (i = 0; i < n;i++)
    {
        for (j = 0; j < n;j++)
        {
            if (i==0)
            Console.Write( $" 0{A[i,j]}");
            else 
            {
                if ((i == 1) & (j<3))  Console.Write( $" {A[i,j]}");
                else 
                {
                    if ((i == 2) & (j<3)) Console.Write( $" {A[i,j]}");
                    else 
                    {
                        if ((i == 3) & (j<1))Console.Write( $" {A[i,j]}");
                        else Console.Write( $" 0{A[i,j]}");
                    }                                     
                }                               
            }

            if (j == (n-1)) Console.WriteLine();
        }
    }

