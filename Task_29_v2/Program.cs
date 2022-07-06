/* Напишите программу, которая задаёт массив из 8 случайных целых чисел
и выводит отсортированный по модулю массив
Сортировка пузырьком */

Zadacha29();

void Zadacha29()
{
    int size = 8;
    int [] array = new int [size];
    FillArray(array);
    PrintArray(array);
    SortArray(array);
    PrintArray(array);
}

void FillArray (int [] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-999, 1000);
    }
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [i]} ");
    }
    Console.WriteLine();
}

void SortArray (int [] array)
{
    int length = array.Length;
    while ( length > 0)
    {
        for (int i = 0; i < array.Length-1; i++)
        {
            int minPosition = i;
            if (Math.Abs(array [i+1]) < Math.Abs(array[minPosition])) 
                {
                    minPosition = i+1;
                    int temp = array[i];
                    array[i] = array[minPosition];
                    array[minPosition] = temp;
                }
        }
        length = length -1;
    } 
}