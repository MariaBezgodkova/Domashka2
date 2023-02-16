// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

        int Chislo3(int number)
        {
            int result = -1; // данный ответ будет выводится если в заданном числе только 2 цифры
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
int number = 32679; // вводим любое число
Console.WriteLine (Chislo3 (number));        