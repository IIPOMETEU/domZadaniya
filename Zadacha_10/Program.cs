// Задача 10:
//  Напишите программу, которая принимает на вход
//  трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int number = ReadInt("Введите трехзначное число: ");
int num1 = number.ToString().Length;
if (num1 < 3 || num1 > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int InCenter(int num2)
{
    int result = ((num2 / 10) % 10);
    return result;
}