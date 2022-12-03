// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int element = 0;

int [,] matrix = new int [rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] +   " ");
    }
    Console.WriteLine("");
}
Console.WriteLine("=========================");
Console.WriteLine("Задайте позицию элемента по i");
int num_i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте позицию элемента по j");
int num_j = Convert.ToInt32(Console.ReadLine());

if (num_i<=rows && num_j<=columns)
    {
    element = matrix[num_i,num_j];
    Console.WriteLine("Значение заданного элемента = " + element);
    }
else
{
Console.WriteLine("Такого элемента нет");    
}

