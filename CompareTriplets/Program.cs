﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    /// <summary>
    /// Solution
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// New Joshua Alviando 2022/08/05
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {

        List<int> point = new List<int>();
        point.Add(0);
        point.Add(0);

        //Check if list a and b has the same length, if it is not, they are not compareable
        if (a.Count == b.Count)
        {
            

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    point[0] ++;
                }else if(a[i] < b[i])
                {
                    point[1]++;
                }
            }
            
        }

        return point;

    }

}


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
