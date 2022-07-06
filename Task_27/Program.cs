/* Напишите программу, которая принимает на вход число и выдаёт
сумму цифр в числе */

Zadacha27();

void Zadacha27()
{
    Console.WriteLine("Введите число больше нуля");
    int numberA = Convert.ToInt32(Console.ReadLine());
    if (numberA > 0) SumNumbers (numberA);
    else Console.WriteLine("Число введено неверно");
}

void SumNumbers (int numA)
{
    int result = 0;
    int count = numA;
    while(count > 0)
    {
        result = result + count%10;
        count = count/10;
    }
    Console.WriteLine($"Cумма цифр в числе {numA} равна {result}");
}