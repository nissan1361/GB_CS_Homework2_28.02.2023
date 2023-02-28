// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayWeek = int.Parse(Console.ReadLine());

if (dayWeek < 1 || dayWeek > 7)
{
    Console.WriteLine("Не верно введен день недели!");
}
else
{
    if (dayWeek == 6 || dayWeek == 7)
    {
        Console.WriteLine($"{dayWeek} -> ДА");
    }
    else
    {
        Console.WriteLine($"{dayWeek} -> НЕТ");
    }
}
