namespace InterceptorTestApp.Generated;

static class Generated
{
    [System.Runtime.CompilerServices.InterceptsLocation(@"C:\Users\koron\RiderProjects\CSharp12FeaturesApp\InterceptorTestApp\Program.cs", line: 3, character: 15)]
    public static void Intercept1(this TalkingEntity talkingEntity, string phrase)
        => Console.WriteLine($"Собачка говорит: {phrase}");

    [System.Runtime.CompilerServices.InterceptsLocation(@"C:\Users\koron\RiderProjects\CSharp12FeaturesApp\InterceptorTestApp\Program.cs", line: 4, character: 15)]
    public static void Intercept2(this TalkingEntity talkingEntity, string phrase)
        => Console.WriteLine($"Боевой перехватчик космодесанта говорит: {phrase}");
}
