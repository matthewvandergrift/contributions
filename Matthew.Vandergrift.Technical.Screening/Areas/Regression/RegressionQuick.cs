namespace Matthew.Vandergrift.Technical.Screening.Areas.Regression
{
    public class RegressionQuick
    {
        public long CalculateFibonacci(int number)
        {
            switch (number)
            {
                case 0:
                case 1:
                    return number;
                default:
                    return CalculateFibonacci(number - 2) + CalculateFibonacci(number - 1);
            }
        }
    }
}