//Задача 53: Задайте двумерный массив. Напишите программу,
 //которая поменяет местами первую и последнюю строку массива.

// int [,] CreateArray()
// {
//     Console.WriteLine("Введите колличество строк в массиве:");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов в массиве:");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     int [,] array =new  int [rows,columns];
//     return array;
// }
// int[,] GetRandomArray(int[,] array, int length)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//        {
//             array[i,j] =new Random().Next(length);
//         }
//     }
//     return array;
// }


// void PrintArray(int[,]result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i,j]);
//         }

//         Console.WriteLine();
//     }
// }
// void ChangeRows(int [,] result)
// {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//         int temp = result[0,j];
//         result[0,j]=result[result.GetLength(0)-1,j];
//         result[result.GetLength(0)-1,j]= temp;
//     }
// }

// int [,] result = GetRandomArray(CreateArray(), 10);
// PrintArray(result);
// ChangeRows(result);
// Console.WriteLine("________");
// PrintArray(result);

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.
// int [,] CreateArray()
// {
//     Console.WriteLine("Введите колличество строк в массиве:");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов в массиве:");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     int [,] array =new  int [rows,columns];
//     return array;
// }
// int[,] GetRandomArray(int[,] array, int length)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//        {
//             array[i,j] =new Random().Next(length);
//         }
//     }
//     return array;
// }
// void ChangeArray(int [,] array1, int[,]array2)
// {
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array1.GetLength(1); j++)
//        {
//         array2[j,i]=array1[i,j];
//        }
//     }

// }
// void PrintArray(int[,]result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i,j]);
//         }

//         Console.WriteLine();
//     }
// }
// int [,] array1 = GetRandomArray(CreateArray(), 10);
// int[,] array2=CreateArray();
// PrintArray(array1);
// ChangeArray(array1, array2);
// PrintArray(array2);


// int minEl=int.MaxValue;
// int minRows=0;
// int minColumns=0;
// void DelList(int[,]result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         if (i!=minRows)
//         {
//             for (int j = 0; j < result.GetLength(1); j++)
//             {
//                if (j!=minColumns)
//                {
//                 Console.Write(result[i,j]);
//                }
              
//             }

//             Console.WriteLine();
//         }
        
//     }
// }
// void GetArray(int [,]result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i,j] = new Random().Next(0,10);

//             if (result[i,j]<minEl)
//             {
//                 minEl=result[i,j];
//                 minRows=i;
//                 minColumns=j;
//             }
//         } 
//     }
// }

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// PrintNambers (N);
// void PrintNambers (int N)
// {
//     if (N<1)
//     {
//         return;
//     }
//     PrintNambers (N-1);
//     Console.Write(N + " ");
// }

// int M = ReadInt("Введите число M: ");
// int N = ReadInt("Введтите число N: ");

// if (M < N)
// {
//     PrintNambers(N, M);
// }
// else
// {
//     PrintNambers(M, N);
// }

// int ReadInt(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void PrintNambers(int N, int M)
// {
//     if (M > N)
//     {
//         return;
//     }
//     Console.Write(M + " ");
//     PrintNambers(N, M + 1);
// }
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int n = ReadInt("Введите число N: ");
// if(n < 0)
// {
//     System.Console.WriteLine("Не корректное число");
//     return;
// }
// System.Console.WriteLine(SumNumbers(n));

// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SumNumbers(int n)
// {
//     if (n < 1)
//     {
//         return 0;
//     }
//     return n % 10 + SumNumbers(n/10);
// }
// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
int a = ReadInt("Введите число A: ");
int b = ReadInt("Введите число B: ");
System.Console.WriteLine(pow(a,b));

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int pow(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    return a * pow(a, b - 1);
}
