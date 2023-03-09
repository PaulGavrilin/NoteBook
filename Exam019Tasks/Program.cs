// собрать строку с числами от a до b, a <= b (итеративный подход(без рекурсии) и рекурсивный)
string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i = i + 1)
    {
        result += $"{i} ";
    }
    return result;
}
string NumberRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumberRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumberFor(1, 10)); //1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumberRec(1, 10)); //1 2 3 4 5 6 7 8 9 10

// сумма числе от 1 до n
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i = i + 1) result += i;
    return result;
}
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10)); //55
Console.WriteLine(SumRec(10)); //55

// факториал числа
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i = i + 1) result *= i;
    return result;
}
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1); //также стоит описать факториал 0, потому что он тоже равен 1.
}
Console.WriteLine(FactorialFor(10)); //3628800
Console.WriteLine(FactorialRec(10)); //3628800

//вычислить a в степени n
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i = i + 1) result *= a;
    return result;
}
int PowerRec(int a, int n)
{   
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a; //Тернарный оператор (для сокращения)
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath (a * a, n / 2);
    else return PowerRecMath (a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024

// Перебор слов. В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в".
// Покажите все слова, состоящие из Т букв, котороые можно построить из букв этого алфавита.
char[] s = {"а", "и", "с", "в"};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i = i + 1)
{
    for (j = 0; j < count; j = j + 1) // и так далее;
    Console.WriteLine($"{n = n + 1,-2}{s[i]}{s[j]}");
}
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[2]);