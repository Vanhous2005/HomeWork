﻿int Getnumber(string message) {
    int result = 0;

        while (true)
        {
            Console.WriteLine(message);
            
            if(int.TryParse(Console.ReadLine(), out result) && result > 0) {
                break;
            }else {
                Console.WriteLine("Ввели не корректное число. Повторите ввод.");
            }

        }
    return result;
}

int[,] InitMatrix(int rows, int columns)
{

    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rnd.Next(1, 20);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();   
    }
}

int  rows = Getnumber("Введите кол-во строк:");
int columns = Getnumber("Введите кол-во столбцов:");
int[,] matrix = InitMatrix(rows, columns);

PrintArray(matrix);

Console.WriteLine("Введите искомую строку");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомый столбец");
int j = Convert.ToInt32(Console.ReadLine());

if (i <= rows && j <= columns){
    Console.WriteLine(matrix[i,j]);
} else{
    Console.WriteLine("Такого элемента нет");
}