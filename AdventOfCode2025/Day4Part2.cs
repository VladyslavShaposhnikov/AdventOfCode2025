namespace AdventOfCode2025;

public class Day4Part2
{
    public static int Forklifts(string path)
    {
        // here i'll wrap input into additional layer/frame consisting of "#" to not hit out of range exception
        
        // example:
        //                                              #######
        // input:    .@..@      after adding layer:     #.@..@#
        //           @.@.@                              #@.@.@#
        //           ..@@.                              #..@@.#
        //           @@.@@                              #@@.@@#
        //                                              #######
        
        // then i iterate through each element, check is it "@" and if yes i count how many "@" aroung current element
        
        var lines = File.ReadAllLines(path);
        int vertical = lines.Length;
        int horizontal = lines.First().Length;

        string s = "";
        for (int i = 0; i < horizontal+2; i++)
        {
            s += "#";
        }
        
        List<string> list = new List<string>();
        list.Add(s);

        for (int i = 0; i < vertical; i++)
        {
            string toAdd = "#"+lines[i]+"#";
            list.Add(toAdd);
        }
        
        list.Add(s);

        int finalCount = 0;

        int iterationCount;

        do
        {
            iterationCount = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[0].Length; j++)
                {
                    // Console.Write(list[i][j]);
                    int count = 0;
                    if (list[i][j] == '@')
                    {
                        for (int k = i - 1; k < i - 1 + 3; k++)
                        {
                            for (int l = j - 1; l < j - 1 + 3; l++)
                            {
                                if (list[k][l] == '@')
                                {
                                    count++;
                                }
                            }
                        }

                        count--;
                        if (count < 4 && count > -1)
                        {
                            finalCount++;
                            iterationCount++;
                            list[i] = list[i].Remove(j, 1);
                            list[i] = list[i].Insert(j, ".");
                        }
                    }
                }

                // Console.WriteLine();
            }

        } while (iterationCount != 0);
        
        

        return finalCount;
    }
}