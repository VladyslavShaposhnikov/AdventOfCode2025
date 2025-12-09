/*using System.Numerics;

namespace AdventOfCode2025;

public class Day6Part2
{
    public static BigInteger Math(string path)
    {
        BigInteger result = 0;
        
        var input = File.ReadAllLines(path);
        
        List<char[]> list = new List<char[]>();
        
        foreach (var line in input)
        {
            char[] copy = line.ToCharArray();
            list.Add(copy);
        }
        
        string[] test = new string[list[0].Length];

        for (int i = 0; i < list[0].Length; i++)
        {
            string temp = "";
            for (int j = 0; j < list.Count; j++)
            {
                temp += list[j][i].ToString();
            }
            test[i] = temp;
        }

        foreach (var s in test)
        {
            Console.WriteLine(string.Join(", ", s));
        }

        List<int> tmp = new List<int>();
        string op = "";
        for(int i = 0; i < test.Length; i++)
        {
            if (string.IsNullOrEmpty(test[i].Replace(" ", "")) || i == test.Length-1)
            {
                if (i == test.Length - 1)
                {
                    tmp.Add(int.Parse(test[i]));
                }
                result += Helper(tmp.ToArray(), op);
                tmp.Clear();
                continue;
            }
            
            if (test[i].Contains("*"))
            {
                test[i] = test[i].Replace("*", "");
                op = "*";
            }
            else if (test[i].Contains("+"))
            {
                test[i] = test[i].Replace("+", "");
                op = "+";
            }

            if (!string.IsNullOrEmpty(test[i].Replace(" ", "")))
            {
                tmp.Add(int.Parse(test[i]));
            }
        }
        
        return result;
    }

    static BigInteger Helper(int[] nums, string op)
    {
        Console.WriteLine(string.Join(", ", nums));
        
        if (op == "+")
        {
            Console.WriteLine($"Result: {nums.Sum()}");
            return nums.Sum();
        }
        
        BigInteger res = nums[0] * nums[1];
        for (int i = 2; i < nums.Length; i++)
        {
            res *= nums[i];
        }

        Console.WriteLine($"Result: {res}");
        return res;
    }
}*/

using System.Numerics;

namespace AdventOfCode2025;

public class Day6Part2
{
    public static BigInteger Math(string path)
    {
        BigInteger result = 0;
        
        var input = File.ReadAllLines(path);
        
        List<char[]> list = new List<char[]>();
        
        foreach (var line in input)
        {
            char[] copy = line.ToCharArray();
            list.Add(copy);
        }
        
        string[] stringArr = new string[list[0].Length];

        for (int i = 0; i < list[0].Length; i++)
        {
            string temp = "";
            for (int j = 0; j < list.Count; j++)
            {
                temp += list[j][i].ToString();
            }
            stringArr[i] = temp;
        }

        List<int> tmp = new List<int>();
        string op = "";
        for(int i = 0; i < stringArr.Length; i++)
        {
            if (string.IsNullOrEmpty(stringArr[i].Replace(" ", "")) || i == stringArr.Length-1) // check i because there is no empty line at the end of stringArr
            {
                if (i == stringArr.Length - 1)
                {
                    tmp.Add(int.Parse(stringArr[i]));
                }
                result += Helper(tmp.ToArray(), op);
                tmp.Clear();
                continue;
            }
            
            if (stringArr[i].Contains("*"))
            {
                stringArr[i] = stringArr[i].Replace("*", "");
                op = "*";
            }
            else if (stringArr[i].Contains("+"))
            {
                stringArr[i] = stringArr[i].Replace("+", "");
                op = "+";
            }

            
            tmp.Add(int.Parse(stringArr[i]));
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