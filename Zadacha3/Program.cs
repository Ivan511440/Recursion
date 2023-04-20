// Напишите программу вычесления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 → A(m,n) = 9
// m = 3, n = 2 → A(m,n) = 29

using System;
using static System.Console;

Write("Введите число m: ");
int m = Convert.ToInt32(ReadLine());

Write("Введите число n: ");
int n = Convert.ToInt32(ReadLine());

AkkermanFunction(m, n);

void AkkermanFunction(int m, int n)
{
    Write(Akkerman(m, n));
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m -1, 1);
    }
    else
    {
        return(Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


