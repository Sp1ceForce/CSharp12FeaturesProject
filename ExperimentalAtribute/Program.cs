using System.Diagnostics.CodeAnalysis;

var veryDangerous = new VeryDangerous();
veryDangerous.DoSomeScaryStuff(); 

class VeryDangerous
{
    [Experimental("Amogus"))] 
    public void DoSomeScaryStuff()
    {
        Console.WriteLine("Very scary");
    }
}