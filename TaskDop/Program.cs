/*Задача со звездочкой: Напишите программу, которая реализует обход введенного 
двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
1 2 3
4 5 6 -> 7 8 9 6 3 2 1 4 5
7 8 9
*/

int[,] SetArray(int row, int col, int beginNum, int endNum) 
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

}

void TraversalTwoDimensionalArr(int[,] arr) //метод обхода в двумерном массиве против часовай стрелки, начиная с нижнего левого элемента 
{
    int a = arr.GetLength(0); //строки
    int b = arr.GetLength(1); //столбцы

    int count = 0; //счетчик вывода значений
    int dx = 1; int dy = 0; //изменениe положения индекса строки и столбца, x y

    while (count < arr.Length)
    {

        for (int y = dy; y < b; y++) //вывод самой нижней строки слева направо
        {
            Console.Write(arr[a - 1, y] + " "); count++;
        }
        for (int x = a - 2; x >= dy; x--) //поднимаемся вверх, начиная с предпоследней строки снизу крайнего правого столбца 
        {
            Console.Write(arr[x, b - 1] + " "); count++;
        }
        for (int y = b - 2; y >= dy; y--) //начиная крайнего столбца справа до крайнего столбца слева (элемент [0, 0]) 
        {                                 
            Console.Write(arr[dy, y] + " "); count++;
        }
        for (int x = dx; x < a - 1; x++) //вертикаль, первый столбец от [0, 1] вниз до m - 1 (включая 2ой элемент снизу)
        {
            Console.Write(arr[x, dy] + " "); count++;
        }

        dx++; dy++; 
        a--; b--;   
    }
}
Console.WriteLine();
Console.Write("Введите число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Число столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте начальное значение диапазона: ");
int beginNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте конечное значение диапазона: ");
int endNum = Convert.ToInt32(Console.ReadLine());

int[,] myArray = SetArray(row, col, beginNum, endNum);
Console.WriteLine();
PrintArray(myArray);
Console.WriteLine("  | ");
Console.WriteLine("  V ");
TraversalTwoDimensionalArr(myArray);

