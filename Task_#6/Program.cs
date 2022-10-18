/*
Задача 45 (Второй вариант решения): Напишите программу, 
которая будет создавать копию заданного массива с помощью поэлементного копирования
*/


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("\n");
}

int [] array = new int[10];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1,10);
}

int[] resultArray = new int[10];
Console.WriteLine("resultArray before copy");
PrintArray(resultArray);

Array.Copy(array, resultArray, 10);

Console.WriteLine("resultArray after copy");
PrintArray(resultArray);

Array.Reverse(resultArray);

Console.WriteLine("resultArray after reverse");
PrintArray(resultArray);
