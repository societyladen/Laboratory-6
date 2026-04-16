internal class Pet
{
    private bool isPredator;
    private bool huntAtNight;

    public Pet()
    {
        isPredator = false;
        huntAtNight = false;
    }

    public Pet(Pet other)
    {
        isPredator = other.isPredator;
        huntAtNight = other.huntAtNight;
    }

    public Pet(bool isPredator, bool huntAtNight)
    {
        this.isPredator = isPredator;
        this.huntAtNight = huntAtNight;
    }

    public override string ToString()
    {
        return $"Хищник = {isPredator} : Охотится ночью = {huntAtNight}";
    }

    public bool Disjunction()
    {
        return isPredator || huntAtNight;
    }
}