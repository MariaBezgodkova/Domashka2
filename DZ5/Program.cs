// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

int Chislo = 458; // вводим любое трехзначное число
int b = (Chislo  / 10) % 10; // получаем 45, потом остаток от деления на 10 - 5

Console.WriteLine (b);
