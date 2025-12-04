namespace AdventOfCode2025;

public class SecondStar
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
                start += extracted;
                if (start > 99)
                {
                    res += start / 100;
                    start %= 100;
                }
            }
            else if (s[0].ToString().ToUpper() == "L")
            {
                res += extracted / 100;
                extracted %= 100;
                for (int i = 0; i < extracted; i++)
                {
                    start--;
                    if (start == 0)
                    {
                        res++;
                    }
                }

                if (start < 0)
                {
                    start += 100;
                }
            }
        }

        return res;
    }
}