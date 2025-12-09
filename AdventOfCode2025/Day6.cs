using System.Numerics;

namespace AdventOfCode2025;

public class Day6
{
    public static BigInteger Math(string path)
    {
        BigInteger result = 0;
        
        var input = File.ReadAllLines(path);
        
        List<string[]> list = new List<string[]>();
        
        foreach (var line in input)
        {
            string[] copy = line.Split(" ").Where(c => !string.IsNullOrWhiteSpace(c)).ToArray();
            list.Add(copy);
        }

        for (int i = 0; i < list[0].Length; i++)
        {
            int[] temp = new int[list.Count-1];
            string op = "";
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j][i] == "*" || list[j][i] == "+")
                {
                    op = list[j][i];
                    break;
                }

                temp[j] = int.Parse(list[j][i]);
            }

            result += Helper(temp, op);
        }

        return result;
    }

    static BigInteger Helper(int[] nums, string op)
    {
        if (op == "+")
        {
            return nums.Sum();
        }
        
        BigInteger res = nums[0] * nums[1];
        for (int i = 2; i < nums.Length; i++)
        {
            res *= nums[i];
        }
        return res;
    }
}