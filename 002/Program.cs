// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// void CheckKoord(int x)
// {    
//     if (x == 1)
//         System.Console.WriteLine("Диапазон x>0 и y>0");
//     else if (x == 2)
//         System.Console.WriteLine("Диапазон x<0 и y>0");
//     else if (x == 3)
//         System.Console.WriteLine("Диапазон x<0 и y<0");
//     else if (x == 4)
//         System.Console.WriteLine("Диапазон x>0 и y<0");
//     else
//         System.Console.WriteLine("Вы ввели неправильную четверть");
// }

// string CheckKoord2(int x)
// {
//     string result = "";
//      if (x == 1)
//         result = "x>0 && y>0";
//     else if (x == 2)
//         result =  "x<0 && y>0";
//     else if (x == 3)
//         result =  "x<0 && y<0";
//     else if (x == 4)
//         result = "x>0 && y<0";
//     return result;
// }

// Console.Clear();
// System.Console.WriteLine("Введите номер четверти: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CheckKoord2(x));


// Console.Clear();
// System.Console.WriteLine("Введите номер четверти: ");
// int x = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x);


void CheckQuarter(int x) //Что то делает но ничего не возвращает
{
    if (x==1)
        System.Console.WriteLine("X>0,Y>0");
    else if (x==2)
        System.Console.WriteLine("X<0,Y>0");
    else if (x==3)
        System.Console.WriteLine("X<0,Y<0");
    else if (x==4)
        System.Console.WriteLine("X>0,Y<0");
    else
        System.Console.WriteLine("Такой четверти нет");
}


Console.Clear();
System.Console.WriteLine("Введите четверть");
try
{
    int x = Convert.ToInt32(Console.ReadLine());
CheckQuarter(x);
}
catch
{
    System.Console.WriteLine("Надо было вводить целое число!");
}
