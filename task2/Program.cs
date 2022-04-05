
//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,]Matrix1 ={ 
          {3,4,8,},
          {9,3,8,},
          {1,9,3,}
};
int[,]Matrix2 ={ 
          {8,4,8,},
          {9,1,2,},
          {6,4,3,}
};

for(int i=0;i<Matrix1.GetLength(0);i++)
{
    for(int j=0;j<Matrix1.GetLength(1);j++)
    {
        Console.Write($"{Matrix1[i,j]}*");
        Console.Write($"{Matrix2[i,j]}!\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
double Сomposition = 1;
double Сomposition2 = 1;
for(int i=0;i<Matrix1.GetLength(0);i++)
{
    for(int j=0;j<Matrix1.GetLength(1);j++)
    {
        Console.Write($"{Matrix1[i,j]*Matrix2[i,j]}\t");
        Сomposition *= Matrix1[i,j];
        Сomposition2 *= Matrix2[i,j];
    }
    Console.WriteLine();
}
Console.WriteLine($"\n{Сomposition*Сomposition2}");