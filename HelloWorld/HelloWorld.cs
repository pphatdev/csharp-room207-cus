
internal class HelloWorld
{
    static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        int a = 10;
        int b = 20;
        int c;
        c = a + b;
        Console.WriteLine("HelloWorld! a:10 + b:20 = c:" + c);
    }
}