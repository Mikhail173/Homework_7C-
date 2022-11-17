//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Enter number of rows :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns :");
int n = Convert.ToInt32(Console.ReadLine());


int [,] matrix = new int [m, n];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,21);

        Console.Write(matrix[i,j]+"\t");

    }
    Console.WriteLine();

}
Console.WriteLine("Enter row :");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter column :");
int x = Convert.ToInt32(Console.ReadLine());
if ((y>m)||(x>n))
{
    Console.WriteLine("There's no number.");
}
else
{   
    
    Console.WriteLine("There's number : " + matrix[y,x]);
}    


