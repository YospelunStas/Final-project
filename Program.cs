// Напишите программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше либо равна 3.

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string[] s1 = new string[5] {"ru", "hello", "777", "A", "1234"};
PrintArray (s1);
Console.WriteLine();

string[] s2 = new string[s1.Length];

int count = 0;
for (int i = 0; i < s1.Length; i++)
{
    if(s1[i].Length <= 3)
    {
        s2[count] = s1[i];
        count ++;
    }
}