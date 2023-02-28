// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int num;
if (int.TryParse(Console.ReadLine(), out num))
{
    string numStr = num.ToString();

    if (num < 100)
    {
        Console.WriteLine($"{num} -> Третьей цифры нет");
    }
    else
    {
        Console.WriteLine($"{num} -> {numStr[2]}");
    }

}
else
{
    Console.WriteLine("Некорректный ввод числа!");
}
