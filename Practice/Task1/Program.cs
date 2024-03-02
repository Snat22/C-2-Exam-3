using Task1;

var std1 = new Student("VAlijon","Ispechak city","C++",3,1500.0);
System.Console.WriteLine(std1.ToString());
System.Console.WriteLine("Baroi ivaz kardani Info dar borai student <<stdChange>>-po Yo <<SCHANGE>>-po dar Console navised: ");
System.Console.WriteLine();
string stdchange = Console.ReadLine();

if(stdchange == "stdChange"|| stdchange == "SCHANGE")
{
    try
    {
        
    System.Console.Write("Write Address: ");
    std1.SetAddress(Console.ReadLine());
    System.Console.Write("Write Program: ");
    std1.SetProgram(Console.ReadLine());
    System.Console.Write("Write Year: ");
    std1.SetYear(Convert.ToInt32(Console.ReadLine()));
    System.Console.Write("Write Fee: ");
    std1.SetFee(Convert.ToDouble(Console.ReadLine()));
    System.Console.WriteLine(std1.ToString());
        
    }
    catch (System.Exception)
    {
        
        System.Console.WriteLine("Neverniy format");
    }
}else
{
    System.Console.WriteLine("Uncorect type: ");
}