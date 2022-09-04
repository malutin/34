// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray() // функция создания массива и заполнение его случайными цифрами 
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.WriteLine($"{array[i]}"); // исключение запятой в конце
        }
    }
    return array;
}

int Evennum(int[] array) // функция поиска четных чисел
{
    int Count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            Count = Count + 1;
        }
    }
    return Count;
}

int[] mas = FillArray();
int x = Evennum(mas);
Console.WriteLine($"Количество четных чисел {x}");