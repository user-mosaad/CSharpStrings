using System.Text;

namespace CSharpStrings;

class Program
{
    static void Main()
    {
        // For many sequential edits, StringBuilder avoids allocating a new string each time.
        var builder = new StringBuilder();
        for (int i = 1; i <= 3; i++)
        {
            builder.Append("item ").Append(i).Append(';');
        }
        string result = builder.ToString();
        Console.WriteLine(result);

        string path = @"C:\src\app\readme.md"; // Verbatim literals

        // Raw string literals
        string json = """
            {
                "name" : "Thomas",
                "roles": ["admin", "editor"]
            }
            """;

        var date = new DateTime(1731, 11, 25);
        Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} L. Euler introduced the letter e to denote {Math.E:F5}.");
        string name = "John";
        Console.WriteLine($"{name, -10}|{{}}");

        const string Audience = "world";
        const string Greeting = $"Hello, {Audience}!";

        string[] words = ["The", "quick", "brown", "fox"];

        // Concat joins the sequence with no separator
        string runTogether = string.Concat(words);
        Console.WriteLine(runTogether);

        // Join places a separator between each element
        string sentence = string.Join(' ', words);
        Console.WriteLine(sentence);


        foreach (string heading in new[] { "North", "South", "East", "West", "NE" })
        {
            // A switch expression matches each constant pattern in turn and
            // returns the first match. The discard (_) handles every other value.
            string instruction = heading switch
            {
                "North" => "Travel due North for 10 km.",
                "South" => "Travel due South for 10 km.",
                "East" => "Travel due East for 10 km.",
                "West" => "Travel due West for 10 km.",
                _ => $"Unknown heading: {heading}.",
            };
            Console.WriteLine(instruction);
        }
    }
}
