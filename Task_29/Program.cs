﻿// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] NameArray(int size)
{
int[] array = new int[size]; 
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(0, 1001);
}
return array;
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
{
Console.Write(array[i] + ", ");
}

for (int i = array.Length -1; i < array.Length; i++)
{
Console.Write(array[i]);
}

Console.Write("]");
}

int[] nameArray = NameArray(8);
PrintArray(nameArray);