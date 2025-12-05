namespace AdventOfCode2025;

public class Day2
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
                if (s.Length % 2 == 0)
                {
                    int l = s.Length / 2;
                    if (s.Substring(0, l) == s.Substring(l))
                    {
                        res += i;
                    }
                }
            }
        }
        return res;
    }
}