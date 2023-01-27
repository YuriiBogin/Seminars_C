/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
​Например, задан массив:
​1 4 7 2
​5 9 2 3
​8 4 2 4
1 7 -> такого числа в массиве нет*/


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

int[,] matrix = new int[3,4];
FillAr(matrix);

Console.WriteLine("Введите позицию элемента в двумерном массиве:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int k = 0;
bool s = false;

for  (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j<matrix.GetLength(1);j++)
        {
            if ((a==i) & (b==j))
            {
                 k = matrix[i,j];
                 s = true;
                
            }
        }
    }    

if (s) Console.WriteLine(k);

else Console.WriteLine("Такого числа в массиве нет");