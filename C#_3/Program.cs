/*Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

using System;
using static System.Console;

Clear();
Write("Введите количество строк первого массива: ");
int rows1 = int.Parse(ReadLine());
Write("Введите количество столбцов первого массива: ");
int columns1 = int.Parse(ReadLine());

Write("Введите количество строк второго массива: ");
int rows2 = int.Parse(ReadLine());
Write("Введите количество столбцов второго массива: ");
int columns2 = int.Parse(ReadLine());

int[,] Matrix1 = GetArray(rows1, columns1, 0, 10);
int[,] Matrix2 = GetArray(rows2, columns2, 0, 10);
PrintArray(Matrix1);
WriteLine();
PrintArray(Matrix2);
WriteLine();
PrintArray(MultiplicationMatrix(Matrix1, Matrix2));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}   

int[,] MultiplicationMatrix(int[,] arrayMatrix1, int[,] arrayMatrix2)
{
    int[,] arrayMatrix3 = new int[arrayMatrix1.GetLength(0), arrayMatrix2.GetLength(1)];
    for (int i = 0; i < arrayMatrix1.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMatrix2.GetLength(1); j++)
        {
            for (int k = 0; k < arrayMatrix1.GetLength(1); k++)
            {
                arrayMatrix3[i, j] += arrayMatrix1[i, k] * arrayMatrix2[k, j];
            }
        }
    }
    return arrayMatrix3;
}

if (columns1 != rows2)
{
    WriteLine("Нельзя найти произведение таких матриц!");
    return;
}