using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Matthew.Vandergrift.Technical.Screening.Areas.Regression
{
    public class BubbleSort
    {
        private readonly List<int> _array;

        public BubbleSort(List<int> array)
        {
            _array = array;
        }

        public List<int> SortArray()
        {
            for (var i = 1; i < _array.Count; i++)
            {
                for (var j = 0; j < _array.Count - i; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        var temp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = temp;
                    }
                }
            }

            return _array;
        }
    }
}