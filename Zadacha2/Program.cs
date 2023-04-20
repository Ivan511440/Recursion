// Задайте значения M и N.
// Напишите программу, которая найдет сумму натуральных чисел в промежутке от M до N.

// M = 1; N = 15 → 120
// M = 4; N = 8 → 30

using System;
using static System.Console;

Write("Введите число M: ");
int m = Convert.ToInt32(ReadLine());

Write("Введите число N: ");
int n = Convert.ToInt32(ReadLine());

SumFromMTon(m, n);

void SumFromMTon(int m, int n)
{
    Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
    return 0;
    else
    {
        m ++;
        res = m + SumMN(m, n);
        return res;
    }
}


