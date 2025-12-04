namespace AdventOfCode2025;

public class FirstStar
{
    public static int Rotate(string path)
    {
        int start = 50;
        int res = 0;
        foreach (var line in File.ReadLines(path))
        {
            string s = line.Trim();
            int extracted = int.Parse(s.Substring(1));
            if (s[0].ToString().ToUpper() == "R")
            {
                start = (start + extracted) % 100;
            }
            else if (s[0].ToString().ToUpper() == "L")
            {
                start = (start - extracted) % 100;
            }

            if (start == 0)
            {
                res++;
            }
        }

        return res;
    }
}