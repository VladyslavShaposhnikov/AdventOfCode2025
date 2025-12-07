using System.Numerics;

namespace AdventOfCode2025;

public class Day5Part2
{
    public static BigInteger Ingredients(string path)
    {
        var input = File.ReadAllLines(path);
        BigInteger result = 0;
        bool flag = false;
        Dictionary<BigInteger, BigInteger> fresh = new();
        
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

                if (!fresh.ContainsKey(BigInteger.Parse(parts[0])))
                {
                    fresh.Add(BigInteger.Parse(parts[0]), BigInteger.Parse(parts[1]));
                }
                else
                {
                    if (fresh[BigInteger.Parse(parts[0])] < BigInteger.Parse(parts[1]))
                    {
                        fresh[BigInteger.Parse(parts[0])] = BigInteger.Parse(parts[1]);
                    }
                }
            }

            if (flag)
            {
                break;
            }
        }
        
        BigInteger b = fresh.Select(s => s.Value).Max();
        
        while (fresh.Count > 0)
        {
            BigInteger smallest = fresh.Keys.Min();
            BigInteger biggest = fresh[smallest];

            while (true)
            {
                var sel = fresh.Where(p => p.Key <= biggest && p.Value >= smallest).ToList();
                if (sel.Count > 0)
                {
                    biggest = sel.Max(m => m.Value);
                    foreach (var key in sel.Select(s => s.Key))
                    {
                        fresh.Remove(key);
                    }
                    
                }
                else
                {
                    break;
                }
            }
            
            fresh.Remove(smallest);
            //Console.WriteLine($"smallest is {smallest}, biggest {biggest}, how many: {biggest-smallest+1}");
            result += biggest - smallest + 1;
        }
        return result;
    }
}