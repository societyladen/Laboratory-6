internal class NamedPet : Pet
{
    private string name;
    private int age;

    public NamedPet(string name, int age, bool isPredator, bool huntAtNight)
        : base(isPredator, huntAtNight)
    {
        this.name = name;
        this.age = age;
    }

    public NamedPet(string name, int age)
        : base(false, false)
    {
        this.name = name;
        this.age = age;
    }

    public override string ToString()
    {
        return $"Имя = {name}, Возраст = {age}, " + base.ToString();
    }

    public void Age(int years)
    {
         age += years;
         Console.WriteLine($"Лет прошло {years}. Сейчас лет {age}");
    }

    public string IsDangerousForChild()
    {
        if (Disjunction())
        {
            return $"{name} - ОПАСЕН для ребенка! Не оставляйте наедине!";
        }
        else
        {
            return $"{name} - безопасен, можно играть.";
        }
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }
}