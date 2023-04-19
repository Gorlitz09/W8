/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

using System;
using static System.Console;

Clear();
WriteLine("Введите размеры массива через пробел: ");
string[] num = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,,] array = GetArray(new int[] {int.Parse(num[0]), int.Parse(num[1]), int.Parse(num[2])}, 10, 100);
PrintArray(array);

int[,,] GetArray(int[] size, int min, int max)
{
    int[,,] result = new int[size[0], size[1], size[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int el = new Random().Next(min, max + 1);
                if (FindElement(result, el)) continue;
                result[i, j, k] = el;
                k++;
            }
        }
    }
    return result;
}

bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            WriteLine();
            ReadKey();
        }
    }
}