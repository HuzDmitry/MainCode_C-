Console.WriteLine("Введите первое число для сравнения: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для сравнения: ");
int y=Convert.ToInt32(Console.ReadLine());
if (x>y)
{
    Console.WriteLine("max: "+x);
}else
{
    Console.WriteLine("max: "+y);
}