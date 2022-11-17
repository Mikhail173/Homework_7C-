﻿//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9




double [,] matrix = new double [3, 4];

for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 4; j++)
    {
        matrix[i,j] = new Random().Next(-9,10) + new Random().NextDouble();
        matrix[i,j] = Math.Round(matrix[i,j], 1);

        Console.Write(matrix[i,j]+"\t");

    }
    Console.WriteLine();

}