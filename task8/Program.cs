// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите заданное число ");
int namber1 = int.Parse(Console.ReadLine());
Console.Write("Введите кратное число заданному ");
int namber2 = int.Parse(Console.ReadLine());
if (namber1 % namber2 == 0) Console.Write("Число действительно кратное");
else Console.Write($"{namber1} не кратно числу {namber2}. Остаток = {namber1 % namber2}");