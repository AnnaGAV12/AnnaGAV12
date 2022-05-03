// По двум заданным числам проверить является ли первое квадратом второго

Console.Write("Введите первое число: ");
int namber1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int namber2 = int.Parse(Console.ReadLine());

if(namber1 == namber2 * namber2)
{
    Console.Write($"Число {namber1} является квадратом числа {namber2}. ");
}
else
{
    Console.Write($"Число {namber1} не является квадратом числа {namber2}. ");
}
