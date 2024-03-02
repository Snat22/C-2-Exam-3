namespace Task2;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }
    public  override void Greets()
    {
        System.Console.WriteLine("Meow meow");
    }
}
