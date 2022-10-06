/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

void dayInTheWeek (int dayNumber)
{
    if(dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("да");
    }

    else if(dayNumber > 7 || dayNumber < 1)
    {
        Console.WriteLine("Такого дня недели нет");
    }

    else
    {
        Console.WriteLine("нет");
    }
}

dayInTheWeek(6);