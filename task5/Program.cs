// Показать вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число ");
int namberA = int.Parse(Console.ReadLine());
int namberB = namberA / 10 % 10;
Console.Write("Вторая цифра " + namberB);
