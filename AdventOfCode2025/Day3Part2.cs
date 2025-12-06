namespace AdventOfCode2025;

public class Day3Part2
{
    public static ulong Joltage(string path)
    {
        ulong res = 0;
        
        foreach (var line in File.ReadAllLines(path))
        {
            res += ulong.Parse(Helper(line));
        }
        return res;
    }

    static string Helper(string line)
    {
        string res = "";
        for (int i = 12; i > 0; i--)
        {
            string substring = line.Substring(0, line.Length - i + 1);
            string biggest = substring.Max(c => c).ToString();
            int index = line.IndexOf(biggest);
            res += biggest;
            line = line.Substring(index+1);
        }
        return res;
    }
}