//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

int [,] MayArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = rnd.Next(1,18);
        }
    }
return array;
}

void PrintArray(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
       {
            Console.Write($"{array[i,j]}\t");
       }
       Console.WriteLine();  
    }
        Console.WriteLine();
 }
void MaxNumber(int[,]array)
{
    int i = 0;
    int[] sum = new int [array.GetLength(1)];
    for (i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            sum[i]+=array[i,j];
        }
      Console.Write($"\n\nсумма элементов строки\t{i+1} равна {sum[i]}   \t");
        }
        Console.WriteLine();

    int min = sum[0];  
     for (i = 0; i < sum.Length; ++i)
    if (sum[i] < min) min = sum[i];
    for (i = 0; i < sum.Length; ++i)
    if(min == sum[i] )
    Console.Write($"\nна строке {i+1} находится наименьшая  сумма элементов,сумма = {sum[i]}   \t");
}
int [,] array = MayArray(4,4);
PrintArray(array);
MaxNumber(array);

