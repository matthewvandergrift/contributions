using System.Collections.Generic;
using System.Linq;

namespace Matthew.Vandergrift.Technical.Screening.Areas.Array
{
    public class ArrayOperations
    {
        public HashSet<int> MergeArrayForLoop(int[][] arrays)
        {
            var mergedArray = new HashSet<int>();

            foreach (var array in arrays)
            {
                mergedArray.UnionWith(array);
            }
            return mergedArray;
        }

        public void BTreeTraversal()
        {
            return;
        }
    }
}