// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.






int[,] array = new int[,]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4}
};   
int m = array.GetLength(0);
int n = array.GetLength(1);
double[] averages = new double[n];
        
for (int j = 0; j < n; j++)
    {
    int sum = 0;
            
for (int i = 0; i < m; i++)
{
    sum += array[i, j];
}
averages[j] = (double)sum / m;
}
Console.WriteLine("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < n; j++)
{
Console.Write(averages[j].ToString("0.0") + " ");
}