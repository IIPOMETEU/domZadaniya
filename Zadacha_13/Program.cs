// Задача 13:
// Напишите программу,
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int num(int n)
{
    while (n > 999)
    {
        n /= 10;
    }
    return n % 10;
}
bool check(int n)
{
    if (n < 100)
        return false;
    else return true;
}
if (check(n) != true)
    System.Console.WriteLine("Третьей цифры нет");
else
    System.Console.WriteLine($"Третья цифра заданного числа = {num(n)}");