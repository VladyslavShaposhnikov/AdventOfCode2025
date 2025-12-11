namespace AdventOfCode2025;

public class Day7
{
    public static int Laboratories(string path)
    {
        var input = File.ReadAllLines(path);
        int res = 0;
        List< (int, int)> list = new List<(int, int)>();
        
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input[i].Length; j++)
            {
                if (input[i][j] == '^')
                {
                    bool left = false;
                    bool right = false;
                    for (int k = i+1; k < input.Length - 1; k++)
                    {
                        if (input[k][j+1] == '^')
                        {
                            if (!list.Contains((k, j + 1)) && right == false)
                            {
                                res++;
                                list.Add((k, j+1));
                            }
                            right = true;
                        }

                        if (input[k][j-1] == '^')
                        {
                            if (!list.Contains((k, j - 1)) && left == false)
                            {
                                res++;
                                list.Add((k, j-1));
                            }
                            left = true;
                        }
                    }
                }
            }
        }

        return res+1;
    }
}