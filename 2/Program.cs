// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


int[,] array = new int[,]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4}
};
        
Console.Write("Введите координаты элемента через пробел (например, 2 3): ");
string input = Console.ReadLine();
string[] parts = input.Split(' ');
        
    if (parts.Length != 2)
    {
    Console.WriteLine("Некорректный ввод. Необходимо ввести две координаты через пробел.");
    return;
    }

    if (!int.TryParse(parts[0], out int row) || !int.TryParse(parts[1], out int column))
    {
    Console.WriteLine("Некорректный ввод. Необходимо ввести два целых числа через пробел.");
    return;
    }
        
    if (row < 0 || row >= array.GetLength(0) || column < 0 || column >= array.GetLength(1))
    {
    Console.WriteLine("Указанная позиция находится за пределами массива.");
    return;
    }
        
int value = array[row, column];
Console.WriteLine("Значение элемента: " + value);