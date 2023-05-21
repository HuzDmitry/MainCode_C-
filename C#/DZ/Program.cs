// задача 2
// Console.WriteLine("Введите первое число для сравнения: ");
// int x=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число для сравнения: ");
// int y=Convert.ToInt32(Console.ReadLine());
// if (x>y)
// {
//     Console.WriteLine("max: "+x);
// }else
// {
//     Console.WriteLine("max: "+y);
// }

// задача 4
// Console.WriteLine("Введите первое число для сравнения: ");
// int x=0;
// for (int i = 0; i < 3; i++)
// {
//    int temp=Convert.ToInt32(Console.ReadLine());
//     if (temp>x)
//     {
//         x=temp;
//     }
//     Console.WriteLine("Введите еще число для сравнения: ");

// }
// Console.WriteLine("max= "+x);

//задача 6
// Console.WriteLine("Введите число для анализа: ");
// int x=Convert.ToInt32(Console.ReadLine());
// if (x%2==0)
// {
//     Console.WriteLine(x+" четное");
// }else
// {
//     Console.WriteLine(x+" не четное");
// }
// задача 8
// Console.WriteLine("Введите число для анализа: ");
// int x=Convert.ToInt32(Console.ReadLine());
// int temp=1;
// while (temp<=x)
// {
//     if (temp%2==0)
//     {
//         Console.Write(temp+", ");
//     }
//     temp++;
// }
//----------------------------------------------------------------------------------------------------
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число для анализа: ");
// int num=Convert.ToInt32(Console.ReadLine());
// int x1=num%100/10;
// Console.WriteLine(x1);

// адача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число для анализа: ");
// int num=Convert.ToInt32(Console.ReadLine());

// if (num<100)
// {
//     Console.WriteLine("В этом числе нет третьего числа");
// }
// else 
// {
//     Console.WriteLine(GetInteger(num));
// }
// int GetInteger(int numb)
// {
//     while(numb>999)
//     {
//         numb/=10;
//     }
//     return numb%10;
// }

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число дня недели: ");
// int num=Convert.ToInt32(Console.ReadLine());
// if (num<0 || num>8)
// {
//     Console.WriteLine("в недели всего 7 дней.");
// }else if(num==6 || num==7)
// {
//     Console.WriteLine("это выходной день.");
// }else
// {
//     Console.WriteLine("это рабочий день.");
// }
//-----------------------------------------------------------------------------------------------
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
//  string num=Console.ReadLine();

// char [] temp=num.ToCharArray();

// bool Polindrom(char [] num){
//     bool pol=false;
//     for(int i=0,t=num.Length-1; i<num.Length/2; i++,t--)
//     {
//         pol=num[i]==num[t];
//     }
//     return pol;
// }
// if (Polindrom(temp))
// {
//     Console.Write("это число палиндром");
// }
// else
// {
//     Console.Write("это число не являеться палиндромом");
// }
//----------------------------------------------------------------
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double[] Koordinate()
// {
//     double[] temp=new double[3];
//     Console.Write(" X: ");
//     temp[0] = Convert.ToDouble(Console.ReadLine());
//     Console.Write(" Y: ");
//     temp[1] = Convert.ToDouble(Console.ReadLine());
//     Console.Write(" Z: ");
//     temp[2] = Convert.ToDouble(Console.ReadLine());
//     return temp;
// }
// Console.WriteLine("Введите координаты точки А: ");
// double [] num1 = Koordinate();
// Console.WriteLine("Введите координаты точки В: ");
// double [] num2 = Koordinate();
// double result=Math.Sqrt(Math.Pow(num2[0]-num1[0],2)+
//                         Math.Pow(num2[1]-num1[1],2)+
//                         Math.Pow(num2[2]-num1[2],2));
                        
// Console.WriteLine("Расстояние между точкой А и В: "+ Math.Round(result, 2));

//------------------------------------------------------------------------
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int num=Convert.ToInt32(Console.ReadLine());
// for(int i=0; i<num; i++)
// {
//    Console.Write(", "+Math.Pow(i+1, 3)); 
// }
//---------------------------------------------------------------------------------------

// Урок 4. Функции

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число: ");
// int num1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень числа: ");
// int num2=Convert.ToInt32(Console.ReadLine());
// Console.Write($"число {num1} в степени {num2} = ");
// Console.WriteLine(Exponentiate(num1, num2));

// int Exponentiate(int num1, int num2)
// {
//     int temp=num1;
//     for (int i = 1; i < num2; i++)
//     {
//         temp=temp*num1;
//     }
//     return temp;
// }
// ---------------------------------------

// Задача 27: Напишите программу, которая принимает на
//  вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int num1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма чисел в веденном числе = "+Summa(num1));
// int Summa(int sum)
// {
//     int temp=sum;
//     int count=0;
//     int result=0; 
//     while (temp>0)
//     {
//         count=temp%10;// получаю остаток
//         temp=temp/10;// получаю осталоное число без остатка
//         result=result+count; // суммирую каждый остаток
//     }  
//     return result;      
// }
// --------------------------------------------------
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] OutArray()
// {
//     int[] inArray=new int[8];
//     int num;
//     for (int i = 0; i < 8; i++)
//     {
//         Console.Write($"Введите {i+1}-e число: ");
//         num=Convert.ToInt32(Console.ReadLine());
//         inArray[i]=num;
//     }
//     return inArray;
// }
// void PrintIntArray(int[] array)
// {
//     Console.Write("["+string.Join(",",array)+"]");
// }
// int[] array=OutArray();
// PrintIntArray(array);
//-------------------------------------------------------------------------------------
//DZ 5
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Write("Введите длинну массива: ");
// int len=Convert.ToInt32(Console.ReadLine());
// int[]array=new int[len];

// Fill(array);
// int result=Pariti(array);
// Console.WriteLine(String.Join(",",array));
// Console.WriteLine("количество четных чисел в массиве= "+result);

// void Fill(int[] t)
// {
//     Random ran =new Random();
//     for (int i = 0; i < t.Length; i++)
//     {
//        t[i]=ran.Next(100,1000); 
//     }
// } 
// int Pariti(int[] t)
// {
//     int num=0;
//     int temp=0;
//     for (int i = 0; i < t.Length; i++)
//     {
//        temp=t[i]%10;
//        if (temp%2==0)
//        {
//             num++;        
//        }
//     }
//     return num;
// }
//--------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Write("Введите длинну массива: ");
// int len=Convert.ToInt32(Console.ReadLine());
// int[]array=new int[len];
// Fill(array);
// int result=SummNechet(array);
// Console.WriteLine(String.Join(",",array));
// Console.WriteLine("сумма чисел в нечетных позициях в массиве = "+result);

// void Fill(int[] t)
// {
//     Random ran =new Random();
//     for (int i = 0; i < t.Length; i++)
//     {
//        t[i]=ran.Next(10); 
//     }
// } 
// int SummNechet(int[]t)
// {
//     int summa=t[1];
//     for (int i = 3; i < t.Length; i=i+2)
//     {
//         summa+=t[i];
//     }
//     return summa;
// }
//-----------------------------------------------

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.Write("Введите длинну массива: ");
// int len=Convert.ToInt32(Console.ReadLine());
// int[]array=new int[len];
// Fill(array);
// int result=MinusMaxMin(array);
// Console.WriteLine(String.Join(",",array));
// Console.WriteLine("Разница между min и max в массиве = "+result);

// void Fill(int[] t) //метод заполнения массива числами
// {
//     Random ran =new Random();
//     for (int i = 0; i < t.Length; i++)
//     {
//        t[i]=ran.Next(1,100); 
//     }
// } 

// int MinusMaxMin(int[]t) // определение разницы между min и max
// {
//     int min=1000;
//     int max=0;
//     for (int i = 0; i < t.Length; i++)
//     {Console.Write("Введите длинну массива: ");
// int len=Convert.ToInt32(Console.ReadLine());
// int[]array=new int[len];
// Fill(array);
// int result=MinusMaxMin(array);
// Console.WriteLine(String.Join(",",array));
// Console.WriteLine("Разница между min и max в массиве = "+result);

// void Fill(int[] t) //метод заполнения массива числами
// {
//     Random ran =new Random();
//     for (int i = 0; i < t.Length; i++)
//     {
//        t[i]=ran.Next(1,100); 
//     }
// } 

// int MinusMaxMin(int[]t) // определение разницы между min и max
// {
//     int min=1000;
//     int max=0;
//     for (int i = 0; i < t.Length; i++)
//     {
//         if (t[i]<min)
//         {
//             min=t[i];
//         }else if (t[i]>max)
//         {
//             max=t[i];
//         }
//     }
//     max-=min;
//     return max;
// }
//         if (t[i]<min)
//         {
//             min=t[i];
//         }else if (t[i]>max)
//         {
//             max=t[i];
//         }
//     }
//     max-=min;
//     return max;
// }
//------------------------------------------------------------------------------------
// DZ 6

// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] IntRandom()
// {
//     Console.WriteLine("Введите желаемое количесво случайных чисел:");
//     int len=Convert.ToInt32(Console.ReadLine());
//     int[] ran=new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         ran[i]=new Random().Next(-99,100);
//     }
//     return ran;
// }

// string StringRandom()
// {
//     Console.WriteLine("Введите желаемое количесво чисел. В конце нажмите еще раз ввод:");
//     string inInt1=Console.ReadLine();
//     string inInt2="";
//      while (inInt1 !="")
//      {
//         inInt2=inInt2+" "+inInt1;
//         inInt1=Console.ReadLine();
//      }
//     return inInt2;
// }

// int[] StringInInt(string res)// преобразование строки в массив чисел
// {
//     string[] t=res.Split(" ");
//     int[] result=new int[t.Length-1];
//     for (int i = 0; i < t.Length-1; i++)
//     {
//         result[i]=Convert.ToInt32(t[i+1]);
//     }
//     return result;
// }

// int NumArray(int[]t)// вывод количесват положительных чисел
// {
//     int result=0;
//     for (int i = 0; i < t.Length; i++)
//     {
//         Console.Write($"{t[i]}, ");
//         if (t[i]>0) result++;
//     }
//     return result;
// }

// int result=NumArray(IntRandom());
// //int result=NumArray(StringInInt(StringRandom()));
// Console.WriteLine("");
// Console.WriteLine($"Количество положительных чисел = {result}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//y=5x+2 y=9x+4 a2x+b2-a1x-b1=0 a2x-a1x+b2-b1=0 a2x-a1x=b1-b2 x=b1-b2/a2-a1

// float[] InNumCoordinat()
// {
//     Console.WriteLine("Введите координыты 2-х прямых");
//     float[]coordinata=new float[4]; // точки координат прямых:В1.В2.К1.К2
//     for (int i = 0; i < 2; i++)
//     {
//         Console.Write($"точка B{i+1}= ");
//         coordinata[i]=Convert.ToInt32(Console.ReadLine());
//         Console.Write($"точка K{i+1}= ");
//         coordinata[i+2]=Convert.ToInt32(Console.ReadLine());
//     }
//     return coordinata;
// }
// float[] Intersection(float[] t)
// {
//     float[]result=new float[2];// координата точки пересечения: Х.Y
//     result[0]=(t[0]-t[1]) / (t[3]-t[2]);
//     result[1]=t[3]*result[0]+t[1];
//     return result;
// }
// float[] res=Intersection(InNumCoordinat());
// Console.WriteLine(string.Join(",",res));
//-----------------------------------------------------------------------------------
// Урок 7. Двумерные массивы

// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] CreateArray()
// {
//     Console.WriteLine("Введите колличество строк в массиве:");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов в массиве:");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     double [,] array =new  double [rows,columns];
//     return array;
// }
// void GetRandomArray(double[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//        {
//             array[i,j] = Convert.ToDouble(new Random().Next(-100,100)/10.0);
//           Console.Write(array[i,j]+  " ");
//         }
//         Console.WriteLine();
//     }
// }
// GetRandomArray(CreateArray());


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int [,] CreateArray()
// {
//     Console.WriteLine("Введите колличество строк в массиве:");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов в массиве:");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     int [,] array =new  int [rows,columns];
//     return array;
// }
// int[,] GetRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//        {
//             array[i,j] =new Random().Next(100);
//           Console.Write(array[i,j]+  " ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }
// void SerchNumArray(int[,]array, int x, int y)
// {
//      if (x>array.GetLength(0)&&y>array.GetLength(1))
//             {
//                Console.WriteLine("Такой нет позиции в таблице."); 
//             }else
//             {
//                 Console.WriteLine($"Значени в таблице по x={x}, y={y}: {array[x-1,y-1]}"); 
//             }
    
// }
// int[,] result=GetRandomArray(CreateArray());

// Console.WriteLine("Введите строку x:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбец y:");
// int y = Convert.ToInt32(Console.ReadLine());
// SerchNumArray(result,x,y);

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] CreateArray()
// {
//     Console.WriteLine("Введите колличество строк в массиве:");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов в массиве:");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     int [,] array =new  int [rows,columns];
//     return array;
// }
// int[,] GetRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//        {
//             array[i,j] =new Random().Next(10);
//           Console.Write(array[i,j]+  " ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// int[,] result=GetRandomArray(CreateArray());
// double[]arifmet=new double[result.GetLength(1)];

// for (int i = 0; i < result.GetLength(0); i++)
//     {
//       for (int j = 0; j < result.GetLength(1); j++)
//         {
//             arifmet[j] +=result[i,j];
//         }
//     }
// Console.WriteLine();
// for (int i = 0; i < arifmet.Length; i++)
// {
//     arifmet[i]/=result.GetLength(1);
//     Console.Write($"{Math.Round(arifmet[i],1)}; ");
// }
//-----------------------------------------------------------------------------
// Урок 8. Двумерные массивы. Продолжение

// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// int [,] CreateArray()//создание массива
// {
//     Console.WriteLine("Введите колличество строк в массиве:");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов в массиве:");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     int [,] array =new  int [rows,columns];
//     return array;
// }
// int[,] GetRandomArray(int[,] array, int length)// заполнение массива случайными числами
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
// void PrintArray(int[,]result)// вывод массива в консоль
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
// void SortArray(int[,] array)
// {
    
//     for(int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int count=array[i,j];
//             int k=j+1;
//             int temp=0;
//             while(k<array.GetLength(1))
//             {
//                 if (count<array[i,k])
//                 {
//                     temp=count;
//                     count=array[i,k];
//                     array[i,k]=temp;
//                 }
//                 k++;
//             } 
//             array[i,j]=count;
//         }
//     } 
// }

// int [,]result=GetRandomArray(CreateArray(), 10);
// PrintArray(result);
// SortArray(result);
// Console.WriteLine();
// PrintArray(result);

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int [,] CreateArray()//создание массива
// {
//     Console.WriteLine("Введите колличество строк в массиве:");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов в массиве:");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     int [,] array =new  int [rows,columns];
//     return array;
// }
// int[,] GetRandomArray(int[,] array, int length)// заполнение массива случайными числами
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
// void PrintArray(int[,]result)// вывод массива в консоль
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write($" {result[i,j]}");
//         }

//         Console.WriteLine();
//     }
// }
// void MinSumString(int[,] array)
// {
    
//     int[] temp=new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int minSum=0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             minSum+=array[i,j];
//         }
//         temp[i]=minSum;
//     }
//     int m=temp.Min();
//     Console.WriteLine($"строка с меньшей суммой = {Array.IndexOf(temp, m)+1} ");
// }
// int [,] array=GetRandomArray(CreateArray(),10);
// PrintArray(array);
// MinSumString(array);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] multiplacationMatrix(int [,] matrix1, int[,] matrix2)
// {
//     int[,] result=new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     if (matrix1.GetLength(1) != matrix2.GetLength(0))
//     {
//         Console.WriteLine("размеры матрицы не подходят для умножения.");
//     }else
//     {
//         for (int i = 0; i < matrix1.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix1.GetLength(1); j++)
//             {
//                 for (int k = 0; k < matrix2.GetLength(1); k++)
//                 {
//                     result[i,k]+=matrix1[i,j] * matrix2[j,k];
//                 }
                
//             }
            
//         }
//     }
//     return result;
// }

// Console.WriteLine("размер первой матрицы");
// int [,] array1=GetRandomArray(CreateArray(),10);//10- это диапозон случайных чисел
// Console.WriteLine("размер второй матрицы");
// int [,] array2=GetRandomArray(CreateArray(),10);
// PrintArray(array1);
// Console.WriteLine();
// PrintArray(array2);
// Console.WriteLine();
// PrintArray(multiplacationMatrix(array1, array2));
//-------------------------------------------------------------------------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] CreateMatrix()//создание массива
{
    Console.WriteLine("Введите первую величину в массиве:");
    int level1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите вторую величину в массиве:");
    int level2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третью величину в массиве:");
    int level3= Convert.ToInt32(Console.ReadLine());
    int [,,] array =new  int [level1, level2, level3];
    return array;
}
void GetRandomMatrix(int[,,] matrix)// заполнение массива случайными числами
{
    Random rand= new Random();
    int count= matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2);
    HashSet <int> steck=new HashSet<int>();

    while(steck.Count != count)
    {
        steck.Add(rand.Next(10,100));
    }
   int[] array=steck.ToArray();
    //Console.Write(String.Join(" ",array));
    //Console.WriteLine();
    int value=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] =array[value++];
            }
        }
    }
}
void PrintMatrix(int[,,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    Console.Write($"{matrix[i,j,k]}({i},{j},{k}); ");
                }
                Console.WriteLine();
            }
        }
}

int[,,]result=CreateMatrix();
GetRandomMatrix(result);
PrintMatrix(result);