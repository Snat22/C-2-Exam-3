namespace Task2;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }


    public override void Greets()
    {
        System.Console.WriteLine("Woof");
    }

    public virtual void Greets(Dog another)
    {
        System.Console.WriteLine("Wooooooooooof");
    }
}
