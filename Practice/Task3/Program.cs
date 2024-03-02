List<int> list = new List<int>(){1,0,5,-4,5,10,-80,24, 0, -4, 100, 24, 45, 6, -1};
System.Console.WriteLine("List Before: ");
foreach (var it in list)
{
    System.Console.Write(it+ " ");
}
System.Console.WriteLine();
System.Console.WriteLine($"Max Element: {list.Max()}");

System.Console.WriteLine("List After deleting Duplication: ");
List<int> list2 = list.Distinct().ToList();

foreach (var it in list2)
{
 System.Console.Write(it+" ");   
}
list.Sort();
System.Console.WriteLine();

System.Console.WriteLine("List After: ");
for (int i = 0; i < list.Count; i++)
{
    if (list[i] < 0)
    {
        list[i] = 0;
    }
}
foreach (var item in list)
{
    System.Console.Write(item+ " ");
}



