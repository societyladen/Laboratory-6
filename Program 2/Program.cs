internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты первого отрезка:");
        double x1 = Checker.CheckDouble("Введите x (начало): ");
        double y1 = Checker.CheckDouble("Введите y (конец): ");
        LineSegment s1 = new LineSegment(x1, y1);

        Console.WriteLine("\nВведите координаты второго отрезка:");
        double x2 = Checker.CheckDouble("Введите x (начало): ");
        double y2 = Checker.CheckDouble("Введите y (конец): ");
        LineSegment s2 = new LineSegment(x2, y2);

        LineSegment s3 = new LineSegment(10, 15);

        Console.WriteLine($"\nОтрезок 1: {s1}");
        Console.WriteLine($"Отрезок 2: {s2}");
        Console.WriteLine($"Отрезок 3: {s3}\n");

        Console.WriteLine($"Длина отрезка 1: {!s1}");
        Console.WriteLine($"Длина отрезка 2: {!s2}\n");

        LineSegment s1plus = s1++;
        Console.WriteLine($"Результат s1++: {s1plus}");
        Console.WriteLine($"Исходный s1 после ++: {s1}\n");

        int xInt = s1;
        double yDouble = (double)s1;
        Console.WriteLine($"Неявное приведение к int (целая часть x): {xInt}");
        Console.WriteLine($"Явное приведение к double (координата y): {yDouble}\n");

        LineSegment r1 = s1 - 3;
        LineSegment r2 = 2 - s1;
        Console.WriteLine($"{s1} - 3 = {r1}");
        Console.WriteLine($"2 - {s1} = {r2}\n");

        Console.WriteLine($"{s1} < {s2} = {s1 < s2}");
        Console.WriteLine($"{s1} < {s3} = {s1 < s3}");
        Console.WriteLine($"{s2} < {s3} = {s2 < s3}\n");

        LineSegment copy = new LineSegment(s1);
        Console.WriteLine($"Конструктор копирования: {copy}");
    }
}
