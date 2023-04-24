Console.Write("enter 1st number: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("enter 2nd number: ");
int b = int.Parse(Console.ReadLine()!);
if (a>b)
{
    Console.Write("Biggest: ");
    Console.WriteLine(a);
    Console.Write("Lowest: ");
    Console.WriteLine(b);
}
else
{
    Console.Write("Biggest: ");
    Console.WriteLine(b);
    Console.Write("Lowest: ");
    Console.WriteLine(a);
}