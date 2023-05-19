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
int [,] CreateArray()
{
    Console.WriteLine("Введите колличество строк в массиве:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве:");
    int columns = Convert.ToInt32(Console.ReadLine());
    int [,] array =new  int [rows,columns];
    return array;
}
int[,] GetRandomArray(int[,] array, int length)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
       {
            array[i,j] =new Random().Next(length);
        }
    }
    return array;
}
void ChangeArray(int [,] array1, int[,]array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
       {
        array2[j,i]=array1[i,j];
       }
    }

}
void PrintArray(int[,]result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i,j]);
        }

        Console.WriteLine();
    }
}
int [,] array1 = GetRandomArray(CreateArray(), 10);
int[,] array2=CreateArray();
PrintArray(array1);
ChangeArray(array1, array2);
PrintArray(array2);


int minEl=int.MaxValue;
int minRows=0;
int minColumns=0;
void DelList(int[,]result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (i!=minRows)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
               if (j!=minColumns)
               {
                Console.Write(result[i,j]);
               }
              
            }

            Console.WriteLine();
        }
        
    }
}
void GetArray(int [,]result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(0,10);

            if (result[i,j]<minEl)
            {
                minEl=result[i,j];
                minRows=i;
                minColumns=j;
            }
        } 
    }
}

