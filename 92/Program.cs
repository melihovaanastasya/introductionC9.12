// 92. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Random2DArray(int m,int n,int min=0,int max=10)
{
    int[,] a=new int[m,n];
    Random random=new Random();
    for(int i=0;i<m;i++)
         for(int j=0;j<n;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

void Multi(int[,]a, int[,]b)
{
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
                    b[i,j]=a[i,j]*b[i,j];
}

int[,] a=Random2DArray(4,4);
int[,] b=Random2DArray(4,4);
Print2DArray(a);
System.Console.WriteLine();
Print2DArray(b);
System.Console.WriteLine();
Multi(a,b);
Print2DArray(b);