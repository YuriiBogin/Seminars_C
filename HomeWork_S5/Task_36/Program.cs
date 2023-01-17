/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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
int[] massive = GetRandomArray(x, 0,100);
Console.WriteLine(string.Join(", ", massive));

int sum = 0;
for(int i = 0; i < massive.Length; i++) if (i % 2 != 0) sum = sum +massive[i];

Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях = {sum}");
}
else Console.WriteLine("Введите правильный размер массива");

