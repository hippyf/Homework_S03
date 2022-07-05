/* Напишите цикл, который принимает на вход 2 натуральных числа (А и В) 
и возводит число А в степень В */

Zadacha30();

void Zadacha30()
{
    Console.WriteLine("Введите число А");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B больше нуля");
    int numberB = Convert.ToInt32(Console.ReadLine());
    if (numberB >0) DegreeNumber(numberA, numberB);
    else Console.WriteLine("Число В введено неверно");
}

void DegreeNumber (int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++ )
    {
        result = result * numA;
    }
    Console.WriteLine($"Число {numA} в степени {numB} равно {result}");
}