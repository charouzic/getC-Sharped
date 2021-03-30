using System;
using System.Collections.Generic;

namespace getInShape
{
    public class LineNumbering
    {
        public static List<string> Number(List<string> lines)
        {
            /*
             example input: number(List<string>{"a", "b", "c"})
                     output: ["1: a", "2: b", "3: c"]
             */
            List<string> output = new List<string>();

            for (int i = 0; i < lines.Count; i++)
            {
                output.Add($"{i+1}: {lines[i]}");
            }

            return output;
        }
    }
}
