namespace Matthew.Vandergrift.Technical.Screening.Areas.Pointers
{
    public class Pointer
    {
        public int Age;

        public string DisplayAge()
        {
            return $"age = {Age}";
        }

        public unsafe void IncrementAge(int increase)
        {
            fixed (int* age = &Age)
            {
                *age += increase;
            }
        }
    }
}