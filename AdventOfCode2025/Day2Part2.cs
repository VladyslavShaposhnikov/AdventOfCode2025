namespace AdventOfCode2025;

public class Day2Part2
{
    public static ulong InvalidId(string path)
    {
        var text = File.ReadAllText(path);
        string[] lines = text.Split(',');
        ulong res = 0;
        foreach (var line in lines)
        {
            ulong first;
            ulong second;
            string[] splitLine = line.Split('-');
            first = ulong.Parse(splitLine[0]);
            second = ulong.Parse(splitLine[1]);

            for (ulong i = first; i <= second; i++)
            {
                string s = i.ToString();
                for (int j = 1; j <= s.Length/2; j++)
                {
                    string substring = s.Substring(0, j);
                    string[] splitString = s.Split(substring);
                    if (splitString.All(str => str == ""))
                    {
                        res += i;
                        break;
                    }
                }
            }
        }
        return res;
    }
}