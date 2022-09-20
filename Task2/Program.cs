// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
double[] GetPointCoord(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;
    return point;


}
double b1 = DataEntry("Введите b1: ");
double k1 = DataEntry("Введите k1: ");
double b2 = DataEntry("Введите b2: ");
double k2 = DataEntry("Введите k2: ");
double[] point = GetPointCoord(b1, k1, b2, k2);

if (k1 == k2) System.Console.WriteLine("Прямые параллельны");
else
    System.Console.WriteLine($"Точка пересечения двух заданных прямых имеет координаты: x= {point[0]}, y= {point[1]}");







