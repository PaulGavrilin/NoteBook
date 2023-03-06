// вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();

// вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Message Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i = i + 1;
    }
}
//Method21("text", count: 4);
//Method21(count: 4, msg: "new text");

//вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//вид 4
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i = i + 1;
    }
    return result;
}
string res = Method4(10,"asdf");
//Console.WriteLine(res);