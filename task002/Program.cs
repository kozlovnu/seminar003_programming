// Задача 18: Напишите программу, которая по заданному номеру 
// четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int n = Input("Номер четверти: ");

while (n >= 1 && n <= 4)
{

    if (n == 1)

    {
        Console.WriteLine(" x > 0, y > 0");
    }

    else if (n == 2)
    {
        Console.WriteLine(" x < 0, y > 0");
    }
    else if (n == 3)
    {
        Console.WriteLine(" x < 0, y < 0");
    }
    else if (n == 4)
    {
        Console.WriteLine(" x > 0, y < 0");
    }
    break;
}
