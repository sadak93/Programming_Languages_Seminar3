// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите координаты X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите размерность ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [] basis=new basis [n];
// int [] basis1=new basis1 [n];

// for (int count=0; count<n; count ++)
// {
//     double r1= Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
// }

double CheckLength(int x1, int x2, int y1, int y2)
{
    double r1= Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));  
    return r1;
}


Console.WriteLine(CheckLength(x1, x2, y1, y2));


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// void CheckSqr (int num)
// {
//     int count = 1;
//     while (count <= num)
//     {
//         Console.Write(count*count + ", ");
//         count ++;
//     }
//     // System.Console.WriteLine();
// }

// Console.Clear();
// Console.WriteLine("Введите целое число N");
// int num = Convert.ToInt32 (Console.ReadLine());
// CheckSqr (num);

