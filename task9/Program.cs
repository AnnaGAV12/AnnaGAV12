// See Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число для нахождения третьей цифры ");
int namber = int.Parse(Console.ReadLine());
if (namber < 100) Console.Write("Третьей цифры нет ");
if (namber > 99 || namber < 1000) Console.Write($"Третья цифра {namber % 10}");
else
{
    while (namber > 999 )
    namber = namber / 10;
Console.WriteLine($"Третья цифра числа {(namber % 10)} ");
}