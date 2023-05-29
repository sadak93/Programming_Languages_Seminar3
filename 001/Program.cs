// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void CheckKoord(int x, int y) //что-то делает но ничего не возвращает
{
    if (x > 0 && y > 0)
        System.Console.WriteLine("Это четверть № 1");
    else if (x > 0 && y < 0)
        System.Console.WriteLine("Это четверть № 4");
    else if (x < 0 && y > 0)
        System.Console.WriteLine("Это четверть № 2");
    else if (x < 0 && y < 0)
        System.Console.WriteLine("Это четверть № 3");
    else
        System.Console.WriteLine("Точка находится на координатной оси");
}

int CheckKoord2 (int x, int y) //что-то делает и что-то возвращает
{
    int result = 0;
    if (x > 0 && y > 0)
        result = 1;
    else if (x > 0 && y < 0)
        result = 4;
    else if (x < 0 && y > 0)
        result = 2;
    else if (x < 0 && y < 0)
        result = 3;
    return result;
}



Console.Clear();
System.Console.WriteLine("Введем координату X");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введем координату Y");
int y = Convert.ToInt32(Console.ReadLine());

CheckKoord(x,y);
System.Console.WriteLine($"это четверть № {CheckKoord2(x,y)}");