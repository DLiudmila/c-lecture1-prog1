int d = 0;
// while(d > 0 || d < 8) 
// {
    Console.WriteLine(" Введите число от 1 до 7");
    d = Convert.ToInt32(Console.ReadLine());
// }

if (d == 1)
{
    Console.WriteLine("Понедельник");
}
if (d == 2)
{
    Console.WriteLine("Вторник");
}
if (d == 3)
{
    Console.WriteLine("Среда");
}
if (d == 4)
{
    Console.WriteLine("Четверг");
}
if (d == 5)
{
    Console.WriteLine("Пятница");
}
if (d == 6)
{
    Console.WriteLine("Суббота");
}
if (d == 7)
{
    Console.WriteLine("Воскресенье");
}
if ( d < 1 || d > 7)
{
    Console.WriteLine("Сам дурак");
}

