double Gipotinuse(double xa, double ya, double xb, double yb, double za, double zb)

{
    double result = Math.Sqrt(Math.Pow((xa - xb),2) + Math.Pow((ya - yb),2) + Math.Pow((za - zb),2));
    result = Math.Round(result,2, MidpointRounding.ToZero);
    return result;
}

Console.Write("Первая точка - введите координату x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка - введите координату y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка - введите координату z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка - введите координату x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка - введите координату y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка - введите координату z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Gipotinuse(x1, y1, x2, y2, z1, z2);
Console.Write($"Расстояние между точками {x1},{y1},{z1} и {x2},{y2},{z2} -> {distance}");
