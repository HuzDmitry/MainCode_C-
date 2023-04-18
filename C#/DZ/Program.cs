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

double[] Koordinate()
{
    double[] temp=new double[3];
    Console.Write(" X: ");
    temp[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write(" Y: ");
    temp[1] = Convert.ToDouble(Console.ReadLine());
    Console.Write(" Z: ");
    temp[2] = Convert.ToDouble(Console.ReadLine());
    return temp;
}
Console.WriteLine("Введите координаты точки А: ");
double [] num1 = Koordinate();
Console.WriteLine("Введите координаты точки В: ");
double [] num2 = Koordinate();
double result=Math.Sqrt(Math.Pow(num2[0]-num1[0],2)+
                        Math.Pow(num2[1]-num1[1],2)+
                        Math.Pow(num2[2]-num1[2],2));
                        
Console.WriteLine("Расстояние между точкой А и В: "+ Math.Round(result, 2));

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
