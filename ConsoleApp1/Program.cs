//TASK 54

using System;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
}

static void CamelCaseSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

//TASK 56



partial class Program
{
    static void Main()
    {
        // Задаем двумерный массив
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        int minSumRow = FindRowWithMinSum(array);

        Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumRow + 1}");
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRow = 0;

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }

        return minSumRow;
    }
}

//TASK 58



partial class Program
{
    public static void Main()
    {
        int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
        int[,] matrix2 = { { 3, 4 }, { 3, 3 } };

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            Console.WriteLine("Умножение матриц невозможно");
            return;
        }

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        Console.WriteLine("Результирующая матрица:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

//TASK 60

partial class Program
{
    static void Main()
    {
        int[,,] array = new int[2, 2, 2];
        int num = 10;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array[i, j, k] = num++;
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
                }
            }
        }

        Console.ReadLine();
    }
}

//TASK 62

partial class Program

{
    static void Main(string[] args)
    {
        int n = 4;
        int[,] spiralArray = new int[n, n];

        int value = 1;
        int minRow = 0;
        int maxRow = n - 1;
        int minCol = 0;
        int maxCol = n - 1;

        while (value <= n * n)
        {
            
            for (int i = minCol; i <= maxCol; i++)
            {
                spiralArray[minRow, i] = value++;
            }
            minRow++;

            
            for (int i = minRow; i <= maxRow; i++)
            {
                spiralArray[i, maxCol] = value++;
            }
            maxCol--;

            
            for (int i = maxCol; i >= minCol; i--)
            {
                spiralArray[maxRow, i] = value++;
            }
            maxRow--;

            
            for (int i = maxRow; i >= minRow; i--)
            {
                spiralArray[i, minCol] = value++;
            }
            minCol++;
        }

        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{spiralArray[i, j]:D2} ");
            }
            Console.WriteLine();
        }
    }
}


//АТТЕСТАЦИЯ

// TASK 1
using System;
partial class Program
{
    static void Main(string[] args)
    {
        int N = 5; 
        PrintNumbers(N);
    }

    static void PrintNumbers(int number)
    {
        if (number <= 1)
        {
            Console.Write(number); 
        }
        else
        {
            Console.Write(number + ", "); 
            PrintNumbers(number - 1); 
        }
    }
}

//TASK 2

using System;

class Program
{
    static void Main(string[] args)
    {
        int M = 1;
        int N = 15;

        int sum = CalculateSumOfNaturalNumbers(M, N);

        Console.WriteLine("Сумма натуральных элементов от {0} до {1} равна {2}", M, N, sum);
    }

    static int CalculateSumOfNaturalNumbers(int start, int end)
    {
        int sum = 0;

        for (int i = start; i <= end; i++)
        {
            sum += i;
        }

        return sum;
    }
}

//TASK 3

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        int m = 2;
        int n = 3;

        int result = Ackermann(m, n);

        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
    }
}