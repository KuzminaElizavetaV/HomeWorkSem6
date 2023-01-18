/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

int[] SetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int PositiveNumArray(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        count += el > 0 ? 1 : 0;
    }
    return count;
}

Console.WriteLine();
Console.Write("Задайте количество чисел для формирования последовательности: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] myArr = SetArray(sizeArr);
Console.WriteLine();
Console.WriteLine($"{String.Join(", ", myArr)} -> {PositiveNumArray(myArr)}");
Console.WriteLine();
