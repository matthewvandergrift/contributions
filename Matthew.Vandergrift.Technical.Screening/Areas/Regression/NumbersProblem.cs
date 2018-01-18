using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matthew.Vandergrift.Technical.Screening.Areas.Regression
{
    public class NumbersProblem
    {
        public IEnumerable<int> FindTheMissingInteger(List<int> missing)
        {
            var max = missing.Max(x => x);
            var min = missing.Min(x => x);
            var list = Enumerable.Range(min, max);

            var diff = list.Except(missing);

            return diff;
        }
    }
}