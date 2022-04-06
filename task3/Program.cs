//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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
            Console.Write($"{array[i,j]} - {(i,j)} \t");
      
        }
       Console.WriteLine($"\n");  
    }
        Console.WriteLine();
 }
int [,] array = MayArray(4,4);
PrintArray(array);

