using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matthew.Vandergrift.Technical.Screening.Areas.BugHunt
{
    public class BugFixes
    {
        public void MakeTheNumbersMatch(int a, int b, int x, int y)
        {
            while (a == x && b == y)
            {
                if (a > x)
                {
                    a--;
                }
                else
                {
                    a++;
                }
                if (b > y)
                {
                    b--;
                }
                else
                {
                    b++;
                }
            }
        }
    }
}