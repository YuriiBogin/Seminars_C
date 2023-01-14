/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Не использовать Math.Pow() и аналоги!*/

            /////Вариант решения через метод Void

/*void VvodChisel(string message)
{

    Console.WriteLine(message);

    Console.WriteLine("Ведите число А ");
    int ChicloA = Convert.ToInt32(Console.ReadLine());
     

    Console.WriteLine("Ведите число В ");
    int ChicloB = Convert.ToInt32(Console.ReadLine());
    
    int stepen = 1;
    for (int i =1; i <= ChicloB; i++)
    {
        stepen = stepen * ChicloA;
    }

    Console.WriteLine($"{ChicloA} в степени {ChicloB} = {stepen}");
    
}
VvodChisel("Программа возводит число А в степень В");*/

            ////Вариант решения через return

int VvodChisel(string message)
{

    Console.WriteLine(message);

    Console.WriteLine("Ведите число А ");
    int ChicloA = Convert.ToInt32(Console.ReadLine());
     

    Console.WriteLine("Ведите число В ");
    int ChicloB = Convert.ToInt32(Console.ReadLine());
    
    int stepen = 1;
    for (int i =1; i <= ChicloB; i++)
    {
        stepen = stepen * ChicloA;
    }

    return stepen;
    
}

int result =VvodChisel("Программа возводит число А в степень В");
Console.WriteLine($"А в степени В = {result}");
