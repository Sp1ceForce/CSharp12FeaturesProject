var human = new Human("Ryan", "Gosling", false);
Console.WriteLine($"Имя: {human.Name} " +
                  $"Фамилия: {human.Surname} " +
                  $"Умер в конце драйва: {human.IsDead}");

public class Human(string name, string surname, bool isDead)
{
    public string Name { get; } = name;

    public string Surname { get; } = surname;

    public bool IsDead { get; } = isDead;
}
