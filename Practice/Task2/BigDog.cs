namespace Task2;

public class BigDog : Dog
{
    public BigDog(string name) : base(name)
    {
    }
    public override void Greets()
    {
            System.Console.WriteLine("Wooow");
    }
    public override void Greets(Dog another)
    {
        System.Console.WriteLine("Wooooooooooooooooow");
    }
    public void Greets(BigDog anotherBigdog)
    {
        System.Console.WriteLine("Woooooooooooooooooooooooooooooooooow");
    }
}
