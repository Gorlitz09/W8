/*Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

using System;
using static System.Console;

Clear();
int m = 4;
int n = 4;
int s = 1;

int[,] array = new int[m, n];
for (int i = 0; i < n; i++)
{
    array[0, i] = s;
    s++;
}
for (int j = 1; j < m; j++)
{
    array[j, n - 1] = s;
    s++;
}
for (int i = n - 2; i >= 0; i--)
{
    array[m - 1, i] = s;
    s++;
}
for (int j = m - 2; j > 0; j--)
{
    array[j, 0] = s;
    s++;
}

int c = 1;
int d = 1;

while (s < m * n)
{
    while (array[c, d + 1] == 0)
    {
        array[c, d] = s;
        s++;
        d++;
    }
    while (array[c + 1, d] == 0)
    {
        array[c, d] = s;
        s++;
        c++;
    }
    while(array[c, d - 1] == 0)
    {
        array[c, d] = s;
        s++;
        d--;
    }
    while(array[c - 1, d] == 0)
    {
        array[c, d] = s;
        s++;
        c--;
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i, j] == 0)
        {
            array[i, j] = s;
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i, j] < 10)
        {
            Write($" {array[i,j]} ");
        }
        else Write($"{array[i,j]} ");
    }
    WriteLine();
}

