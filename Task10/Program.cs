// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трех-значное число: ");
int num = int.Parse(Console.ReadLine());

int del100 = num % 100;
int result = del100 / 10;

Console.WriteLine($"{num} -> {result}");
