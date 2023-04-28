// Console.WriteLine("Ведите число 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите число 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите число 3");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 < (num2 + num3) && (num2 < (num1 + num3)) && (num3 < (num1 + num2)))
// {
//     Console.WriteLine("Такой треугольник существует");
// }
// else if ((num1 <= 0) || (num2 <= 0) || (num3 <= 0))
// {
//     Console.WriteLine("Некорректный ввод");
// }
// else
// {
//     Console.WriteLine("Такой треугольник не существует");
// }


// Console.WriteLine("Введите число: ");
// int num=Convert.ToInt32(Console.ReadLine());
// string result="";

// while(num>0)
// {
//     result=num%2+result;
//     num=num/2;

// }
// Console.WriteLine(result);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число больше 2");
// int N = Convert.ToInt32(Console.ReadLine());
// int i=2;
// if (N>=i)
// {
//     int[] fib=new int[N];
//     fib[0]=0;
//     fib[1]=1;
//     Console.Write($"{fib[0]} {fib[1] }");//Console.Write("0 1");
// while(i<N) //for(int i=2;i<N;i++)
// {
//     fib[i]=fib[i-1]+fib[i-2];
//     Console.Write($" {fib[i]}");
//     i++;
// }
// }
// else{
//     Console.WriteLine("Некорректный ввод");
// }
// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] array = new int[5]{1,2,3,4,5};

// int temp=0;
// for (int i = 0; i < array.Length/2; i++)
// {
//     temp = array[i];
//     array[i]=array[array.Length-1-i];
//     array[array.Length-1-i]=temp;
// }

// Console.WriteLine(String.Join(",",array));

// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array =new  int [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//        array[i,j] = new Random().Next(0,10);
//        Console.Write(array[i,j]+ " ");
//     }
//      Console.WriteLine();
// }
// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array =new  int [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//        array[i,j] = new Random().Next(0,10);
//        Console.Write(array[i,j]+  " ");
//     }

//     Console.WriteLine();
// }
//  Console.WriteLine("______");
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if((i%2==0)&&(j%2==0))
//         {
//             array[i,j]= array[i,j]*array[i,j];
//         }

//        Console.Write(array[i,j]+  " ");
//     }

//     Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array =new  int [rows,columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       array[i,j] = new Random().Next(0,10);
       Console.Write(array[i,j]+  " ");
    }

    Console.WriteLine();
}
 Console.WriteLine("______");

int sum=0;

for (int i = 0,j=0; i < array.GetLength(0); i++, j++)
{
    if(j<array.GetLength(1))
   sum=sum+array[i,j];
}

Console.WriteLine("Сумма "+sum);

for (int i = 0; i < array.GetLength(0)&&i<array.GetLength(1); i++)
{
   sum=sum+array[i,i];
}
