// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int vihodnoy (int chislo)
{
    if (chislo > 5  )
    {
        Console.WriteLine ("Введенный день недели является выходным");
    }
    else 
    {
    Console.WriteLine ("Введенный день недели  не является выходным");
    }
    
    return chislo;
}

int chislo = 6; // вводим число от 1 до 7
Console.WriteLine (vihodnoy (chislo));
