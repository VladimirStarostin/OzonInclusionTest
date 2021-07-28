namespace Ozon
{
    public class InclusionFinder
    {
        private readonly BinarySearcher binSearcher = new BinarySearcher();

        public bool IsInclude(int[] sortedArray, int[] sortedSubArray)
        {
            if (sortedSubArray.Length == 0)
                return true;

            var rightIdx = binSearcher.GetRightIdxBinary(sortedArray, sortedSubArray[0]);
            
            if(rightIdx == -1)
                return false;   // вообще не нашли вхождений первой цифры sortedSubArray

            var startRightSearchIdx = FindIdxToStartRightComparison(sortedSubArray);

            if (sortedSubArray.Length - startRightSearchIdx > sortedArray.Length - rightIdx)
                return false;   //  после возможного повторения первой цифры sortedSubArray длиннее sortedArray

            for (int idx = 1; idx < sortedSubArray.Length - startRightSearchIdx; idx++)
            {
                if (sortedArray[rightIdx + idx] != sortedSubArray[idx + startRightSearchIdx])
                    return false;   //  элемент справа от возможно повторяющегося первого элемента в sortedSubArray не равен соотвествующему в sortedArray
            }

            for (int idx = 1; idx <= startRightSearchIdx; idx++)
            {
                if (rightIdx - idx < 0 || sortedArray[rightIdx - idx] != sortedSubArray[0])
                    return false;   // или число повторений первой цифры в sortedSubArray больше наличных вхождений оной в sortedArray, или соответсвующие элементы в sortedArray и sortedSubArray не равны
            }

            return true;    //  всё ок
        }

        private int FindIdxToStartRightComparison(int[] sortedArray)
        {
            int idx = -1;
            while (++idx < sortedArray.Length - 1)
            {
                if (sortedArray[idx] != sortedArray[idx + 1])
                    break;
            }
            return idx;
        }
    }
}