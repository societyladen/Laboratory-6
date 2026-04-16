internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Базовый класс Pet\n");

        // Конструктор с параметрами
        Console.WriteLine("1. Создание Pet через конструктор с параметрами:");
        bool predator1 = Checker.CheckBool("Введите true/false (хищник): ");
        bool nightHunter1 = Checker.CheckBool("Введите true/false (охотится ночью): ");
        Pet pet1 = new Pet(predator1, nightHunter1);
        Console.WriteLine($"Результат: {pet1}");
        Console.WriteLine($"Дизъюнкция (хищник ИЛИ ночной охотник): {pet1.Disjunction()}\n");

        // Конструктор копирования
        Console.WriteLine("2. Конструктор копирования Pet:");
        Pet pet2 = new Pet(pet1);
        Console.WriteLine($"Оригинал: {pet1}");
        Console.WriteLine($"Копия: {pet2}");
        Console.WriteLine($"Дизъюнкция копии: {pet2.Disjunction()}\n");

        // Конструктор без параметров
        Console.WriteLine("3. Конструктор без параметров Pet:");
        Pet pet3 = new Pet();
        Console.WriteLine($"Результат: {pet3}");
        Console.WriteLine($"Дизъюнкция: {pet3.Disjunction()}\n");

        // ===== ДЕМОНСТРАЦИЯ ДОЧЕРНЕГО КЛАССА NamedPet =====
        Console.WriteLine("--- Дочерний класс NamedPet ---\n");

        // Конструктор с параметрами
        Console.WriteLine("4. Создание NamedPet через конструктор с параметрами:");
        string name = Checker.CheckString("Введите кличку: ");
        int age = Checker.CheckInt("Введите возраст (0-50): ", 0, 50);
        bool predator2 = Checker.CheckBool("Введите true/false (хищник): ");
        bool nightHunter2 = Checker.CheckBool("Введите true/false (охотится ночью): ");
        NamedPet namedPet1 = new NamedPet(name, age, predator2, nightHunter2);
        Console.WriteLine($"\nРезультат: {namedPet1}");
        Console.WriteLine(namedPet1.IsDangerousForChild());

        // Конструктор копирования
        Console.WriteLine("\n5. Конструктор копирования NamedPet:");
        NamedPet namedPet2 = new NamedPet(namedPet1.GetName(), namedPet1.GetAge(), predator2, nightHunter2);
        Console.WriteLine($"Оригинал: {namedPet1}");
        Console.WriteLine($"Копия: {namedPet2}");

        // Метод Age
        Console.WriteLine("\n6. Демонстрация метода Age():");
        Console.WriteLine($"Текущий возраст {namedPet1.GetName()}: {namedPet1.GetAge()} лет");
        int years = Checker.CheckInt("На сколько лет увеличить возраст? ", 1, 20);
        namedPet1.Age(years);
        Console.WriteLine($"Новый возраст: {namedPet1.GetAge()} лет");

        // Второй конструктор NamedPet (только имя и возраст)
        Console.WriteLine("\n7. Создание NamedPet через конструктор (только имя+возраст):");
        string name2 = Checker.CheckString("Введите кличку: ");
        int age2 = Checker.CheckInt("Введите возраст (0-50): ", 0, 50);
        NamedPet namedPet3 = new NamedPet(name2, age2);
        Console.WriteLine($"Результат: {namedPet3}");
        Console.WriteLine(namedPet3.IsDangerousForChild());
    }
}
