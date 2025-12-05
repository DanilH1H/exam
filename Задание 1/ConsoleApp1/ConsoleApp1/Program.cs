using System;
using Xunit;
    public class Program
{
    static void Main()
    {
        string text = "Мой кот очень милый";
    
        Pitomets r = new Pitomets();
        Console.WriteLine(r.aboba(text));
    }

    [Fact]
    public void Test()
    {
        string text = "Мой кот очень милый";
        Pitomets r = new Pitomets();
        Assert.Equal("Мой пес очень милый", r.aboba(text));  
    }
}
public class Pitomets
{
    public string aboba(string x) => x.Replace("кот", "пес");
}

