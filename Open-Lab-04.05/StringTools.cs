using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string temp = "";
            for (int y= 0;  y< orig.Length; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    temp += orig[y];
                }
            }
            return temp;
        }
    }
}
