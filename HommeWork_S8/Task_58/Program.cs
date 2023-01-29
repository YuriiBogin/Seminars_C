﻿/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/




        
Console.WriteLine("Введите размерность первой матрицы: ");
int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(1,10);
        }
    }

Console.WriteLine("Введите размерность второй матрицы: ");
int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < B.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            B[i, j] = new Random().Next(1,10);
        }
    }
 
Console.WriteLine("\nМатрица A:");
Print(A);
Console.WriteLine("\nМатрица B:");
Print(B);
Console.WriteLine("\nМатрица C = A * B:");

int[,] C = ProizAr(A, B);
Print(C);

int[,] ProizAr(int[,] a, int[,] b)
    {
        if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
        int[,] r = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    r[i,j] += a[i,k] * b[k,j];
                }
            }
        }
        return r;
    }

void Print(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write("{0} ", a[i, j]);
            }
            Console.WriteLine();
        }
    }
    