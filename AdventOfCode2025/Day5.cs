using System.Numerics;

namespace AdventOfCode2025;

public class Day5
{
    public static int Ingredients(string path)
    {
        var input = File.ReadAllLines(path);
        int result = 0;
        bool flag = false;
        Dictionary<string, string> fresh = new();
        
        foreach (var line in input)
        {
            if (string.IsNullOrEmpty(line))
            {
                flag = true;
                continue;
            }
            
            if (!flag)
            {
                string[] parts = line.Split("-");

                if (!fresh.ContainsKey(parts[0]))
                {
                    fresh.Add(parts[0], parts[1]);
                }
                else
                {
                    if (BigInteger.Parse(fresh[parts[0]]) < BigInteger.Parse(parts[1]))
                    {
                        fresh[parts[0]] = parts[1];
                    }
                }
            }

            if (flag)
            {
                foreach (var key in fresh.Keys)
                {
                    if (BigInteger.Parse(line) >= BigInteger.Parse(key) && BigInteger.Parse(line) <= BigInteger.Parse(fresh[key]))
                    {
                        result++;
                        break;
                    }
                }
            }
        }
        return result;
    }
}