Console.Clear();
Console.Write("Введите координату x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите координату x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2)),2);

System.Console.WriteLine($"Расстояние между двумя точками в 3D пространстве {result}");
