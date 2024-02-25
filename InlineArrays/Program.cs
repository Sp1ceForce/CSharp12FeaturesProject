using System.Runtime.CompilerServices;

var array = new InlineArray();
for (int i = 0; i < 10; i++)
{
    array[i] = i;
}

foreach (var item in array)
{
    Console.Write($"{item},");
}

[InlineArray(10)]
public struct InlineArray
{
    private int arrayValueType;
}