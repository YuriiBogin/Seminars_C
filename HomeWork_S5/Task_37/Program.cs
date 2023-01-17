/*Задайте массив натуральных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i =0; i< array.Length; i++) array[i] = new Random().Next(leftRange, rightRange+1);
        return array;
}

Console.WriteLine("Введите размер массива");
int x = Convert.ToInt32(Console.ReadLine());

if (x>0)
{
int[] massive = GetRandomArray(x, 1,100);
Console.WriteLine(string.Join(", ", massive));

int min = massive[0];
int max = massive[0];

for(int i = 0; i < massive.Length; i++) 
{
if (min>massive[i]) min = massive[i];
if (max<massive[i]) max = massive[i];
}
Console.WriteLine($"Максимальный элемент массива = {max}");
Console.WriteLine($"Минимальный элемент массива = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max-min}");
}
else Console.WriteLine("Введите правильный размер массива");