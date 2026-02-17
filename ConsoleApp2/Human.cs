namespace ConsoleApp2;

public class Human
{
    public string? name { get; private set; }

    private int _age;
    public int Age { get; set; }
    

    public Human(string name)
    {
        this.name = name;
    }
    
    public Human(int age)
    {
        name = null;
        Age = age;

    }

    public Human(string name, int age)
    {
        this.name = name;
        Age = age;
    }

}



