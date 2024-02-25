Test.InVoid(5);
//Warning: Argument 1 should be a variable because it is passed to a 'ref readonly' parameter
Test.ReadonlyRefVoid(5); 
//Error: 'ref' argument must be an assignable variable, field, or an array element
Test.ReadonlyRefVoid(ref 5); 

int e = 5;
Test.ReadonlyRefVoid(ref e);
Test.InVoid(e);
//Warning: Argument 1 should be passed with 'ref' or 'in' keyword
Test.ReadonlyRefVoid(e); 

public static class Test
{
    public static void ReadonlyRefVoid(ref readonly int test) { } 
    
    public static void InVoid(in int test) { } 
}