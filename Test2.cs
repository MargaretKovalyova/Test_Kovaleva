﻿//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с
//   клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Write("Размерность массива: ");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < a.Length; i++)
{
    Console.Write("a[{0}] = ", i);
    a[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < a.Length; i++)
{
    Console.Write(a[i] + ", ");
}

Console.WriteLine();
Console.Write("Количество элементов для выбора: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Индекс первого элемента: ");
int index = int.Parse(Console.ReadLine());

int[] b = new int[count];
for (int i = 0; i < count; i++)
{
    int j = i + index;
    if (j >= a.Length)
        b[i] = 1;
    else
        b[i] = a[j];
}
for (int i = 0; i < b.Length; i++)
{
    Console.Write(b[i] + ", ");
}
Console.WriteLine();