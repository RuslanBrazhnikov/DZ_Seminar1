﻿// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int m = 1;
    for (int i = m; i <= n; i++)
    {
        if (i % 2 == 0) 
            {
                Console.Write(i + " "); 
            }
            if(i >= n)
            {
                break;
            }
    }
