using System;
using System.Collections.Generic;
using System.Linq;

namespace Matthew.Vandergrift.Technical.Screening.Areas.Math
{
    public class MathProblemsOutsideTheBox
    {
        //Had one today.Looked like problems for 10 year olds or I didn't get what they were looking for. 
        //(1) A function to compute minimum of unsorted numbers in an array of size N. this is a simple loop to find the min.How many times the assignment is executed?
        //(2) Find and fix the bugs - this function is to remove head of a singly linked list.
        //(3) Design a printserver. (there were some criteria)


        public long Divide2IntegersWithoutOperators()
        {
            return 0;
        }

        public int[] Add2IntegersAndReturnIndicesByTargetKnown(int target)
        {
            const int a = 2;
            const int b = 7;
            const int c = 11;
            const int d = 15;

            switch (target)
            {
                case a + b:
                    return new[] { 0, 1 };
                case a + c:
                    return new[] { 0, 2 };
                case a + d:
                    return new[] { 0, 3 };
                case b + c:
                    return new[] { 1, 2 };
                case b + d:
                    return new[] { 1, 3 };
                case c + d:
                    return new[] { 2, 3 };
                default:
                    return null;
            }
        }

        public Tuple<int, int> Add2IntegersAndReturnIndicesByTargetUnknown(IList<int> list, int sum)
        {
            var hs = new HashSet<int>();
            list.ToList().ForEach(x => hs.Add(x));

            for (var i = 0; i < hs.Count; i++)
            {
                var diff = sum - list[i];

                //if you cant find the difference between the target sum and the list multipliers
                if (!hs.Contains(diff)) continue;

                var index = list.IndexOf(diff);

                return new Tuple<int, int>(i, index);
            }

            //couldnt find the target sum
            return null;
        }


    }
}
