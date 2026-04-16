internal class Checker
{
    public static bool CheckBool(string prompt)
    {
        Console.Write(prompt);
        while (true)
        {
            string input = Console.ReadLine().ToLower();

            if (input == "true" || input == "t" || input == "1")
            {
                return true;
            }

            if (input == "false" || input == "f" || input == "0")
            {
                return false;
            }

            Console.Write("Ошибка! Введите true или false: ");
        }
    }

    public static int CheckInt(string prompt, int min, int max)
    {
        Console.Write(prompt);
        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result) && result >= min && result <= max)
            {
                return result;
            }

            Console.Write($"Ошибка! Введите число от {min} до {max}: ");
        }
    }

    public static string CheckString(string prompt)
    {
        Console.Write(prompt);
        while (true)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            Console.Write("Ошибка! Строка не может быть пустой: ");
        }
    }
}