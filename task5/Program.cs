//Задача 1: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.
int [,] MayArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = rnd.Next(1,99);
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
          
            Console.Write($"{array[i,j]}  \t");
      
        }
       Console.WriteLine($"\n");  
    }
        Console.WriteLine();
 }

void SortArray(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)

        {
        int max = j;
            for (int a=j+1;a<array.GetLength(1);a++)
            {
                if(array[i,max]<array[i,a])
                    {
                     max = a;
                    int temporary = array[i,max];
                    array[i,max]=array[i,j];
                     array[i,j] = temporary;
                    }
            }
            Console.Write($"{array[i,j]}  \t");
      
        }
       Console.WriteLine($"\n");  
    }
        Console.WriteLine();
 }
 int [,] array = MayArray(5,4);
PrintArray(array);
 SortArray(array);

        
 


