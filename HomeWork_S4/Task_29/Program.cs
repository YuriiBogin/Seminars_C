/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 Данные вводятся с консоли пользователем*/

void FillArray(int [] collection)
{
    
    Console.WriteLine("Введите элементы массива");
    int length = collection.Length;
    int index = 0;

    while (index<length)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());

        index++;
    }
    Console.WriteLine("Вы ввели 8 элементов массива");
}

int [] array = new int[8];

FillArray(array);
Console.WriteLine(string.Join(" ", array)); //вывод массива в строку