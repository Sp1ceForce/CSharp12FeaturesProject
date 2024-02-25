
var IsDividableBy = (int source, int divider = 2) => source % divider == 0;

Console.WriteLine(IsDividableBy(4));
Console.WriteLine(IsDividableBy(4,3));