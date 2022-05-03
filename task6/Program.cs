// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Write("Введите число из отрезка [10, 99] ");
int namber = int.Parse(Console.ReadLine());
int namber1 = namber / 10;
int namber2 = namber % 10;
if (namber1 > namber2) Console.Write("Наибольшая цифра числа = " + namber1);
else Console.Write("Наибольшая цифра числа = " + namber2);
