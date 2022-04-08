int[,]Matrix1 ={ 
          {0,0,0,0},
          {0,0,0,0},
          {0,0,0,0},
          {0,0,0,0}
};

int i =0;
int j = 0;
int A = 1;
int sum = 1;
int B = 1;
int Z = 1;
void PicArray(int[,]pic)
{
for(i=0;i<4;i++)
{
    for( j=0;j<4;j++)
    {
     

        Console.Write($"{Matrix1[i,j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
}
PicArray(Matrix1);


Console.WriteLine();
for(i=0;i<Matrix1.GetLength(0);i+=4)
{
    for( j=0;j<Matrix1.GetLength(1);j++)
    {
         Console.Write($"{Matrix1[i,j]+sum}|\t");//         1строка
         sum++;
    }
    Console.WriteLine();
}


for(i=1;i<Matrix1.GetLength(0)-1;i++)
{
     for( j=0;j<Matrix1.GetLength(1)-3;j++)/////1 ряд
    {
        Console.Write($"{Matrix1[i,j]+11+B}|");
        B--;
    }
for( j=2;j<Matrix1.GetLength(1)-1;j++)
    {
        Console.Write($"\t{Matrix1[i,j]+ sum*2+2+Z}|");//2
        Z++;
    }
for( j=3;j<Matrix1.GetLength(1);j++)
    {
        Console.Write($"\t{Matrix1[i,j]+13+i}|");//5 ряд
    }
for( j=3;j<Matrix1.GetLength(1);j+=2)//4 ряд
    {
    Console.Write($"\t{Matrix1[i,j]+sum}|");
        sum++;
    }
    Console.WriteLine();
    }
for(i=3;i<Matrix1.GetLength(0);i++)
{
    for( j=0;j<Matrix1.GetLength(1);j++)
    {
        Console.Write($"{Matrix1[i,j]+sum+2+A}|\t");
        A--;
    }
}
Console.WriteLine();
Console.WriteLine();




 //void ImageArrai(int i,int j)
 //{
     //for(int a = 0;a<3;a++)
    // {
    
    // if(Matrix1[i,j] == 0)
    // {
        // Matrix1[i,j] += sum;
       // Console.Write($"{Matrix1[i,j] + sum}\t");
         //ImageArrai(i,j+1);
        // ImageArrai(i+1,j);
        // ImageArrai(i,j-1);
        // ImageArrai(i-1,j);

  //   }
     
    
    // }
 //}

//ImageArrai(0,0);
//PicArray(Matrix1);
 //PrintArray(Matrix1);



