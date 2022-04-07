//Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.




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
void MaxNumber(int[,]array)
{
    int i = 0;
    int[] sum = new int [array.GetLength(1)];
    int[] sum2 = new int [array.GetLength(1)];
    int[] sum3 = new int [array.GetLength(1)];
    int[] sum4 = new int [array.GetLength(1)];

    
    //for (i=0;i<array.GetLength(0);i++)
    //{
    
        for (int j=0;j<4;j++)
        {
            sum[i] = array[0,j];
           Console.Write($"{sum[i]}   \t");
        }
        Console.WriteLine();
        for (int j=0;j<4;j++)
        {
            sum2[i] = array[1,j]; 
            Console.Write($"{sum2[i]}   \t");
        }
        Console.WriteLine();
        for (int j=0;j<4;j++)
        {
            sum3[i] = array[2,j]; 
            Console.Write($"{sum3[i]}   \t");
        }
        Console.WriteLine();
        for (int j=0;j<4;j++)
        {
            sum4[i] = array[3,j]; 
            Console.Write($"{sum4[i]}   \t");
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int j=0;j<4;j++)
        {
            int max = j;
            for (int a=j+1;a<array.GetLength(1);a++)
            {
                int max1 = j;
                if(array[3,max]<array[3,a])
                    {
                     max = a;
                    int temporary = array[3,max];
                    array[3,max]=array[3,j];
                     array[3,j] = temporary;
                    }
            }
           
           Console.Write($"{array[3,j]}   \t");
        }

}
MaxNumber(array);      
