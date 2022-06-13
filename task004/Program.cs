// Задача 22: Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

int Square (int a) // метод для нахождения квадрата
{
    return a * a;
}

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count < n)
{
    int sq = Square(count);
    count ++;
    Console.Write($"{sq}, ");
}
Console.WriteLine(Square(n));