


using ConsoleApp2;

class Program
{
    public static void Main(string[] args)
    {
        Human h1 = new Human("Illia");
        Console.WriteLine();
        Console.WriteLine(h1.name);

        Human h2 = new Human(19);
        Console.WriteLine();
        Console.WriteLine(h2.name);
        
        
        Human h3 = new Human("Donald",-1);
        Console.WriteLine();
        Console.WriteLine(h3.name);
        h3.Age = 24;

        TextParser tp = new TextParser();
        string input = Console.ReadLine();
        var parsedInput = tp.parseText(input);

        StatisicsAnalyzer sa = new StatisicsAnalyzer();
        sa.getStat(parsedInput);

    }
}