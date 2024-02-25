using System.ComponentModel;

public class ClassA
{
    public int Hehe { get; set; }
}

public class ClassB
{
    [Description($"ClassA part is {nameof(ClassA.Hehe)}")]
    public ClassA ClassA { get; set; }
}