using System;

class Program
{
    static void Main(string[] args)
    {
        int size;
        double[,] matrix;

        while (true)
        {
            Console.WriteLine("Enter '+' to add a matrix, '-' to subtract a matrix, or any other character to exit:");
            char operation = Console.ReadLine()[0];

            if (operation == '+' || operation == '-')
            {
                Console.WriteLine("Enter the size of the matrix:");
                while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
                {
                    Console.WriteLine("Invalid size. Please enter a positive integer:");
                }

                matrix = new double[size, size];

                Console.WriteLine("Enter the elements of the matrix:");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        while (!double.TryParse(Console.ReadLine(), out matrix[i, j]))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number:");
                        }
                    }
                }

                double result = CalculateMatrixResult(matrix, operation);
                Console.WriteLine($"Matrix result: {result}");
            }
            else
            {
                break;
            }
        }
    }

    static double CalculateMatrixResult(double[,] matrix, char operation)
    {
        int size = matrix.GetLength(0);
        double result = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (operation == '+')
                {
                    result += matrix[i, j];
                }
                else if (operation == '-')
                {
                    result -= matrix[i, j];
                }
            }
        }

        return result;
    }
}
