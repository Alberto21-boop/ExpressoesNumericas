namespace ExpressoesNumericas;

public class Expressoes
{
    public static void Main(string[] args)
    {
        //80-6x7+5 = ...
        int a = 80 - 6 * 7 + 5;
        Console.WriteLine(a);

        // (+80) + (-60) + (-100) = ...
        int b = 80 + (-60) + (-100);
        Console.WriteLine(b);

        // 4+[12-(2+5)+9]
        int c = 4 + (12 - (2 + 5) + 9);
        Console.WriteLine(c);
    }
}