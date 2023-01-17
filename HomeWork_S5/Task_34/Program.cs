/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i =0; i< array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange+1);
    }

    return array;
}

Console.WriteLine("Введите размер массива");
int x = Convert.ToInt32(Console.ReadLine());

if (x>0)
{
int[] massive = GetRandomArray(x, 100,1000);
Console.WriteLine(string.Join(", ", massive));

int count = 0;
for(int i = 0; i < massive.Length; i++) if (massive[i] % 2 == 0) count ++;

Console.WriteLine($"Количество четных элементов массива = {count}");
}
else Console.WriteLine("Введите правильный размер массива");
