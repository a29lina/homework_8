
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void Slection(int[,] nums)
{
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int a = 0; a < columns - 1; a++)
            {
                if (nums[i, a] < nums[i,a+1])
                {
                    int temp = nums[i, a];
                    nums[i, a] = nums[i, a+1];
                    nums[i, a+1] = temp;
                }
            }
        }
    }
}


int GetSum(int[,] array, int row)
{
    int sum = 0;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int j = 0; j < columns; j++)
    {
        sum = sum + array[row, j];
    }
    return sum;
}




//Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


void Zadacha54()
{
    int rows = 4;
    int columns = 5;

    int[,] arr = new int[rows, columns];

    FillArray(arr);
    PrintArray(arr);
    Slection(arr);
    Console.WriteLine();
    PrintArray(arr);

}




//Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void Zadacha56()
{
    int rows = 4;
    int columns = 5;

    int[,] arr = new int[rows, columns];

    FillArray(arr);
    PrintArray(arr);


    int minSum = GetSum(arr, 0);
    int minIndex = 0;

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum = sum + arr[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            minIndex = i;
        }

        Console.WriteLine();

        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
    }

    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма в {minIndex+1} строке = {minSum}");

}




//Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.


void Zadacha58()
{
    int rows = 4;
    int columns = 4;

    int[,] arr = new int[rows, columns];

    arr[0,0] = Convert.ToInt32 ("01"); 
    arr[0,1] = 02;
    arr[0,2] = 03;
    arr[0,3] = 04;
    arr[1,3] = 05;
    arr[2,3] = 06;
    arr[3,3] = 07;
    arr[3,2] = 08;
    arr[3,1] = 09;
    arr[3,0] = 10;
    arr[2,0] = 11;
    arr[1,0] = 12;
    arr[1,1] = 13;
    arr[1,2] = 14;
    arr[2,2] = 15;
    arr[2,1] = 16;


    PrintArray2(arr);

}


