﻿Console.WriteLine("Введите число: ");
int x=Convert.ToInt32(Console.ReadLine());
switch (x)
{
    case 1:
        {Console.WriteLine("понедельник");
        break;}
    case 2:
        {Console.WriteLine("вторник");
        break;}
    case 3:
        {Console.WriteLine("среда");
        break;}
    case 4:
        {Console.WriteLine("четверг");
        break;}
    case 5:
        {Console.WriteLine("пятница");
        break;}
    case 6:
        {Console.WriteLine("суббота");
        break;}
    case 7:
        {Console.WriteLine("воскресенье");
        break;}
    default:
        {Console.WriteLine("нет такого дня недели");
        break;}
}