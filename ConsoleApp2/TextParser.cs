namespace ConsoleApp2;

public class TextParser
{
    public string[] parseText(string input)
    {
        input = input.Replace(",", "");
        return input.Split(".");
    }
}