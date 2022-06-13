// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Input("Введите координату х1: ");
int y1 = Input("Введите координату y1: ");
int x2 = Input("Введите координату х2: ");
int y2 = Input("Введите координату y2: ");

int lineX = x2 - x1;
int lineY = y2 - y1;

Console.WriteLine(Math.Sqrt((lineX*lineX) + lineY*lineY));


