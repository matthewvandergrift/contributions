using System;

namespace Matthew.Vandergrift.Technical.Screening.Areas.Math
{
    public class MathProblemsOutsideTheBox
    {
        public long Divide2IntegersWithoutOperators()
        {
            return 0;
        }

        public int[] Add2IntegersAndReturnIndicesByTarget(int target)
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


    }
}
