using System.Numerics;
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
        Console.WriteLine(Day4.Forklifts("./day4.txt"));
        Console.WriteLine(Day4Part2.Forklifts("./day4.txt"));
        Console.WriteLine(Day5Part2.Ingredients("./day5.txt"));
        Console.WriteLine(Day6Part2.Math("./day6.txt"));
    }
}