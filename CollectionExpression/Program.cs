using System.Collections;
using System.Runtime.CompilerServices;

List<int> numbers = [1, 2, 3, 4, 5];
int[] numbers2 = [6, 7, 8, 9, 10];

List<int> numbersMegazord = [.. numbers, ..numbers2]; 

foreach (var numberRanger in numbersMegazord)
{
    //Вывод: 1 2 3 4 5 6 7 8 9 10
    Console.Write($"{numberRanger} "); 
}

int[] row0 = [1, 2, 3];
int[] row1 = [4, 5, 6];
int[] row2 = [7, 8, 9];
int[][] twoDArrayFromVariables = [row0, row1, row2];

int[][] twoDArray = [[1,2,3], [1,4,6], [3,6,3]];

List<string> truth = ["Да", "не", "умер", "он", "в", "конце", "Драйва"];

var e = twoDArrayFromVariables;
var c = twoDArray;
var r = truth;


ExampleList example = ["Pineapple", "Watermelon", "Sus"];
example.AsEnumerable();
[CollectionBuilder(typeof(ExampleList), nameof(ExampleList.Create))]
public class ExampleList : IEnumerable<string>
{
    private string[] items = new string[50];
    
    public IEnumerator<string> GetEnumerator() 
        => items.AsEnumerable().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() 
        => items.GetEnumerator();

    public static ExampleList Create(ReadOnlySpan<string> source) 
        => new ExampleList(source);

    private ExampleList(ReadOnlySpan<string> source) => source.CopyTo(items);
}