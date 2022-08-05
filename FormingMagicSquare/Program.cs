using System.CodeDom.Compiler;
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
     * Complete the 'formingMagicSquare' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY s as parameter.
     */

    /// <summary>
    /// 3x3 magic square
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    /// New Joshua Alviando 2022/08/05
    public static int formingMagicSquare(List<List<int>> s)
    {
        int changingPoint = 0;
        //Make sure the middle is 5
        if (s[1][1] != 5)
        {
            changingPoint += Math.Abs(5- s[1][1]);
        }

        //Check the diagonal pair (cost 10)
        if (s[0][0] == 5)
        {
            if (s[2][2] != 5)
            {
                s[0][0] = returnPair(s[2][2]);
                changingPoint += Math.Abs(5- s[0][0]);
            }
        }

        return changingPoint;

    }

    /// <summary>
    /// checking pair
    /// </summary>
    /// <param name="checkPair"></param>
    /// <returns></returns>
    public static int returnPair(int checkPair)
    {

        switch (checkPair)
        {
            case 1:
                return 9;
            case 2:
                return  8;
            case 3:
                return  7;
            case 4:
                return  6;

            case 6:
                return 4;
            case 7:
                return 3;
            case 8:
                return 2;
            case 9:
                return 1;

            default:
                return 0;
        }

    }

    /// <summary>
    /// check is the same value is exist in the same matrix
    /// </summary>
    /// <param name="checkValue"></param>
    /// <param name="s"></param>
    /// <returns></returns>
    public static bool isValueExist(int checkValue, List<List<int>> s)
    {
        int countValue = 0;
        foreach(var item in s)
        {
            foreach(int i in item)
            {
                if(i == checkValue)
                {
                    countValue++;
                }
            }
        }

        if(countValue > 1)
        {
            return true;
        }

        return false;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> s = new List<List<int>>();

        for (int i = 0; i < 3; i++)
        {
            s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
        }

        int result = Result.formingMagicSquare(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
