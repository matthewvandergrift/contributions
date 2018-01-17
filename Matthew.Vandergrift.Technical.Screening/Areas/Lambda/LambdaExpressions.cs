using System;
using System.Threading.Tasks;

namespace Matthew.Vandergrift.Technical.Screening.Areas.Lambda
{
    public class LambdaExpressions
    {
        public async Task<bool> ExampleAnonymousMethodAsync(int expected, int actual)
        {
            // The following line simulates a task-returning asynchronous process.  
            bool MyFunc(int x) => x == expected;

            var result = MyFunc(actual); 

            await Task.Delay(1000);

            return result;
        }
    }
}