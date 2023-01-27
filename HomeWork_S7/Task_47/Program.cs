/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
​m = 3, n = 4.
​0,5 7 -2 -0,2
​1 -3,3 8 -9,
​8 7,8 -7,1 9*/

void PrintAR(double[,] matr)
{
    for  (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j<matr.GetLength(1);j++)
        {
              Console.Write("{0,6:F2}", matr[i, j]);                  
            //Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillAr(double[,] matr)
{
    Random random = new Random();
    for  (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j<matr.GetLength(1);j++)
        {
            matr[i,j] = -10 + random.NextDouble() * 20;
            
        }
    }    
}
Console.WriteLine("Введите массив m на n");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[n,m];
FillAr(matrix);
Console.WriteLine();
PrintAR(matrix);

