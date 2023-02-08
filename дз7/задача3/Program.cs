int Getnumber(string message) {
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
            matrix[i,j] = rnd.Next(1, 10);
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

double sum = 0;
double sr = 0;

for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        sum = sum + matrix[j,i];
    }
    sr = sum / rows;
    sum = 0;
    Console.WriteLine(Math.Round(sr, 2));
}