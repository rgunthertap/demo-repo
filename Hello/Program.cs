// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!!!!!");
class HelloWorld
{
    public static void Main(string[] args)
    {
        var names = new List<string>{"<name>", "Ana", "Jack", "Kate"};
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name}");
        }

    }
}
