using AdventOfCode2025;


public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(FirstStar.Rotate("./advent_of_code.txt"));   
        Console.WriteLine(SecondStar.Rotate("./advent_of_code.txt"));
        Console.WriteLine(Day2.InvalidId("./day2.txt"));
        Console.WriteLine(Day2Part2.InvalidId("./day2.txt"));
        Console.WriteLine(Day3Part2.Joltage("./day3.txt"));
    }
}