namespace ClassOOP;

internal class Character
{
    public string Name
    {
        get => _name ?? "default character";
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _name = value;
        }
    }

    public int Health
    {
        get => _health;
        set
        {
            if (value > 0)
                _health = value;
        }
    }

    public int Force
    {
        get => _force;
        set
        {
            if (value > 0)
                _force = value;
        }
    }

    public int Defense
    {
        get => _defense;
        set
        {
            if (value > 0)
                _defense = value;
        }
    }


    public bool IsAlive() => _health > 0;
    public void Attack(Character target)
    {
        target.Health -= Force - target.Defense;
        Console.WriteLine($"{this.Name} attaque {target.Name}");
    }



    private string? _name;
    private int _health = 100;
    private int _force = 25;
    private int _defense = 50;
}
