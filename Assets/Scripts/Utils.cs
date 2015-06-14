using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Utils
{
    /// <summary>
    /// Use the Fisher-Yates shuffle to shuffle a list.
    /// Code from: http://stackoverflow.com/questions/273313/randomize-a-listt-in-c-sharp
    /// </summary>
    /// <typeparam name="T">Type the list elements.</typeparam>
    /// <param name="list">List to shuffle.</param>
    public static void Shuffle<T>(this IList<T> list)
    {
        Random rng = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}