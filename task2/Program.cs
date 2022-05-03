// По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели ");
int namber = int.Parse(Console.ReadLine());
if (namber == 1)
{
    Console.WriteLine("Понедельник");
}
if (namber == 2)
{
    Console.WriteLine("Вторник");
}
if (namber == 3)
{
    Console.WriteLine("Среда");
}
if (namber == 4)
{
    Console.WriteLine("Четверг");
}
if (namber == 5)
{
    Console.WriteLine("Пятница");
}
if (namber == 6)
{
    Console.WriteLine("Суббота");
}
if (namber == 7)
{
    Console.WriteLine("Воскресенье");
}
if (namber > 7 || namber <= 0)
{
    Console.WriteLine("По данному номеру дня недели нет");
}