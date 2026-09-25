public interface IUnit
{
    void Attack();
}

public class Warrior : IUnit
{
    private string Name;

    public void Attack()
    {
        Console.WriteLine($"Воин {Name} атакует мечом!");
    }
}

public class Mage : IUnit
{
    private string Name;

    public void Attack()
    {
        Console.WriteLine($"Маг {Name} атакует огненным заклинанием!");
    }

}

public class Squad : IUnit
{
    public string Name;
    private List<IUnit> units = new List<IUnit>();
    public Squad(string name)
    {
        Name = name;
    }
    public void Attack()
    {
        Console.WriteLine("Второй отряд атакует!");
        foreach (IUnit unit in units)
        {
            unit.Attack();
        }
    }
    public void Add(IUnit unit)
    {
        units.Add(unit);
    }
}

class Program
{
    static void Main()
    {
        Squad mainsquad = new Squad("Главный отряд");
        mainsquad.Add(new Warrior());
        mainsquad.Add(new Mage());
        

        Squad newsquad = new Squad("Второй отряд");
        newsquad.Add(new Warrior());
        newsquad.Add(new Mage());
    }
}