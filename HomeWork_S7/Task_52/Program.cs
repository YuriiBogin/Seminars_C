/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
​Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

int[,] matrix = new int[3,4];
FillAr(matrix);
Console.WriteLine();
PrintAR(matrix);

double s = 0;
List<double> sr = new List<double> ();

for  (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i<matrix.GetLength(0);i++)
        {
            s += matrix[i,j];

        } 
    
    sr.Add(Math.Round((s / matrix.GetLength(0)),2));
    s=0;
    }  

Console.WriteLine($"Средне арифметическое столбцов массива = {String.Join("; ", sr)}");
