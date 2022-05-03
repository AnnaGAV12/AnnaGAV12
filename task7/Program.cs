// Удалить вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число ");
int namber = int.Parse(Console.ReadLine());
int namber1 = namber / 100;
int namber3 = namber % 10;
Console.WriteLine($"Число c удаленной второй цифрой: {namber1}{namber3}");