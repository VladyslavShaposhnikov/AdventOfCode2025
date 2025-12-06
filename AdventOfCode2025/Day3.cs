namespace AdventOfCode2025;

public class Day3
{
    public static int Joltage(string path)
    {
        int res = 0;
        foreach (var line in File.ReadAllLines(path))
        {
            bool swap = false;
            string copy;
            string first = line.Max(c => c).ToString();
            int num = line.IndexOf(first);
            if (num == line.Length - 1)
            {
                swap = true;
                copy = line.Substring(0, line.Length - 1);
            }
            else
            {
                copy = line.Substring(num + 1);
            }
            string second = copy.Max(c => c).ToString();
            int num2 = line.IndexOf(second);

            if (swap)
            {
                (num, num2) = (num2, num);
            }

            res += int.Parse(line[num].ToString() + line[num2]);
        }
        return res;
    }
}