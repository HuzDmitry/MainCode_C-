// Console.WriteLine("Введите число: ");
// int num=Convert.ToInt32(Console.ReadLine());
// int [] arry= new int[8];
// Console.WriteLine();

// Задача 31: Задайте массив из 12 элементов, заполненный
//  случайными числами из промежутка [-9, 9]. 
//  Найдите сумму отрицательных и положительных
//   элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
//  сумма положительных чисел равна 29, сумма отрицательных
//   равна -20.

// int[] numArr = new int[12];

// int positiveNum=0;
// int negNum=0;

// for(int i=0;i<numArr.Length;i++)
// {
//     numArr[i] = new Random().Next(-9,10);

//     if(numArr[i]>0)
//     {
//         positiveNum+=numArr[i];
//     }
//     else
//     {
//         negNum+=numArr[i];
//     }
// }

// Console.WriteLine(String.Join(",",numArr)+
// "\nСумма положительных "+positiveNum+" отрицательных "+negNum);

// Задача 32: Напишите программу замена элементов массива: положительные
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// int[] numArr = new int[] {1,7898,66,-6,-52,0};

// Console.WriteLine(String.Join(",",numArr));

// for(int i=0;i<numArr.Length;i++)
// {
//     numArr[i]=-numArr[i];
// }

// Console.WriteLine(String.Join(",",numArr));

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
// Console.WriteLine("Ведите число");
// int nom= Convert.ToInt32(Console.ReadLine());
// int[] numArr = new int[] {1,7898,66,-6,-52,0};
// Console.WriteLine(String.Join(",",numArr));
// bool flag=false;
// for(int i=0;i<numArr.Length;i++)
// {
//     if ( numArr[i]==nom)
//     {
//         flag=true;
//         break;
//     }
// }
// if (flag==true)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

int[] array1 = new int[] {3,8,2,6,2};
int[] array2= new int [(array1.Length/2)+ (array1.Length%2)];

for(int i=0;i<array2.Length;i++)
{
    array2[i]=array1[i]*array1[array1.Length-1-i];

    if (i==array1.Length-1-i)
    {
        array2[i]=array1[array1.Length-1-i];
    }
}
Console.WriteLine(String.Join(",",array2));
