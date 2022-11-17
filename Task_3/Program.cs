//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Enter number of rows :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns :");
int n = Convert.ToInt32(Console.ReadLine());


int [,] matrix = new int [m, n];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,11);

        Console.Write(matrix[i,j]+"\t");

    }
    Console.WriteLine();


}
double [] sum = new double[matrix.GetLength(0)];
for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum[j] = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum[j] += matrix[i, j];
                   
        }
        Console.WriteLine($"{j} average is : {sum[j]/m}");
    }            