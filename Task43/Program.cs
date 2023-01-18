/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double[,] SetArray(int row, int col)
{
    double[,] arr = new double[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("Введите значение: ");
            arr[i, j] = Convert.ToDouble(Console.ReadLine());
        }
    return arr;
}

void PointCrossingLines(double[,] arr)
{
    double x = (arr[1, 0] - arr[0, 0])/ (arr[0, 1] - arr[1, 1]);
    double y = arr[0, 1] * x + arr[0, 0];
    Console.WriteLine($"({x}; {y})");
}
Console.WriteLine();
Console.WriteLine("Введите последовательно значения b1, k1, b2, k2");
double[,] myArr = SetArray(2, 2);
Console.WriteLine($"b1 = {myArr[0, 0]}, k1 = {myArr[0, 1]}, b2 = {myArr[1, 0]}, k2 = {myArr[1, 1]} -> ");
PointCrossingLines(myArr);
Console.WriteLine();


