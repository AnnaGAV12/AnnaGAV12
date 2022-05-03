// Показать четные числа от 1 до N

Console.Write("Введите число N ");
int namberN = int.Parse(Console.ReadLine());
int count = 2;
Console.WriteLine($"Четные числа:");
while (count <= namberN)
{
    Console.Write(count + " ");
    count=count + 2;
}
