// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1 = ReadData("k1");
double b1 = ReadData("b1");
double k2 = ReadData("k2");
double b2 = ReadData("b2");
FindCoordinates(k1, b1, k2, b2);


double ReadData(string arg)
{
    System.Console.Write($"Введите {arg}: ");
    return double.Parse(Console.ReadLine());
}


void FindCoordinates(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);;
    double y = k1 * x + b1;
    System.Console.WriteLine($"Координаты точки пересечения двух прямых: ({x}; {y})"); 
}
