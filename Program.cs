// Напишите программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше либо равна 3.

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string[] s1 = new string[5] {"ru", "hello", "777", "A", "1234"};