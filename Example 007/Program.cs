// string[,]table=new string[2,5];//кол. строк и кол. столбцов
// table[1,2]="слово";
// for (int i = 0; i < 2; i++)
// {
//     for (int r = 0; r < 5; r++)
//     {
//         Console.WriteLine($"-{table[i,r]}-");
//     }
// }
// int[,] matrix=new int[3, 4];
// void PrintArray(int[,] matr)
// {

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//  Console.WriteLine();
// }
// }

// void FillAray(int[,]matr)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix.GetLength(1); j++)
//     {
//         matr[i,j]=new Random().Next(1,10);
//     }
// }
// }
// FillAray(matrix);
// PrintArray(matrix);
// int Faktorial(int t)
// {
//     if (t==1) return 1;
//     else return t* Faktorial(t-1);
// }
// for (int i = 0; i < 40; i++)
// {
    
// }
// Console.WriteLine(Faktorial(5));

double Fibonaci(int n)
{
    if (n==1||n==2)return 1;
    else return Fibonaci(n-1)+Fibonaci(n-2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i})={Fibonaci(i)}");
}