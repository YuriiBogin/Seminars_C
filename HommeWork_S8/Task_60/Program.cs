/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

void PrintAR(int[,,] matr)
{
    for  (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j<matr.GetLength(1);j++)
        {
            for (int k = 0; k<matr.GetLength(2);k++)
            {
                Console.Write($"{matr[i, j, k],1}({i},{j},{k}) ");
            }                    
        }
    Console.WriteLine();
    }
}

HashSet<int> numbers = new HashSet<int>(); 
Random r = new Random();

int GenerateNumber() //метод проверки на повторяющиеся двузначные числа, через объект HashSet и его метод Contains
{
    while (true)
    {
        var n = r.Next(10, 100);
        if (!numbers.Contains(n)) //если содержиться элемент, то его не добавляем
        {
            numbers.Add(n);
            return n;
        }
    }
}

void FillAr(int[,,] matr)
{
    
    for  (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j<matr.GetLength(1);j++)
        {
           for (int k = 0; k<matr.GetLength(2);k++) 
           {
                matr[i,j,k] = GenerateNumber();
           }
                        
        }
    }    
}

Console.WriteLine("Введите массив m на n на k");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int k = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[n,m,k];

FillAr(matrix);
Console.WriteLine();
PrintAR(matrix);
Console.WriteLine();