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
//int[] ResulttArray(int[,]array)
//{
double[] averageSum = new double[array.GetLength(1)];
//int[] averageSum1 = new int[array.GetLength(1)];
int i=0;
int j = 0;
//int sum = 0;

for (i=0;i<array.GetLength(1);i++)
    {
        for ( j=0;j<array.GetLength(0);j++)
        {
             averageSum[i] = array[j,i]; //+= array[j,i];
             if(array[i,j] < array[i,j+=1]) 
            {
            int temp = array[i,j];
            array[i,j] = array[i,j+=1];
            array[i,j+=1] = temp;
            }
             //averageSum1 [i] += array[j,i+=1];
             //Console.Write($"{averageSum[i]}|\t");
             
             Console.Write($"{averageSum[i]}\t");
        }
        //Console.WriteLine();
        //Console.Write($"{averageSum[i]}|\t");
                //averageSum[i] /= array.GetLength(0);
               //Console.Write($"{averageSum[i]/4}|\t");
                //Console.Write($"{averageSum1 [i]}|\t");
    }
    //return averageSum;
//}

//int[] Sum = ResulttArray(array);
//Console.WriteLine(averageSum[i]);