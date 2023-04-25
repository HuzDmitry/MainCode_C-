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