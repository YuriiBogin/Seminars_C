/* Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i =0; i< array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange+1);
    }

    return array;
}

int[] massive = GetRandomArray(123, 0,151);
Console.WriteLine(string.Join(", ", massive));

int count = 0;
for(int i = 0; i < massive.Length; i++) if ((massive[i] >= 10) & (massive[i]<=99))  count ++;

Console.WriteLine($"Количество элементов массива из диапазона [10,99] = {count}");




