using System.Globalization;

namespace LambdaLab;

internal class Program
{
    static void Main(string[] args)
    {
        var strings = new List<string>
        {
            "12.6",
            "19.4",
            "abc",
            "-184.45",
            "484.99",
            "8424",
            "11104.99"
        };
        strings.ForEach(s => Console.WriteLine(s));

        //var any = strings.FirstOrDefault(x => Convert.ToDouble(x) < 0d);
        //Console.WriteLine(any is not null ? $"ja! {any}" : "nope");

        var all = strings.All(x => double.TryParse(x, out _));
        Console.WriteLine($"alleen maar getallen? {(all ? "jep!" : "nope")}");


        Console.WriteLine("==========");
        var nieuweStrings = strings.Where(x => decimal.TryParse(x, out _)).ToList();
        nieuweStrings.ForEach(s => Console.WriteLine(s));

        Console.WriteLine("==========");

        var doubles = nieuweStrings
            .Select(x => Convert.ToDouble(x, CultureInfo.InvariantCulture))
            .ToList();
        doubles.ForEach(d => Console.WriteLine(d));

        Console.WriteLine($"alles bij elkaar: {doubles.Sum():C}");
    }
}
