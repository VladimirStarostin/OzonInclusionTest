namespace Ozon
{
    public class BinarySearcher
    {
        public int GetRightIdxBinary(int[] array, int key)
        {
            int leftIdx, median;
            leftIdx = median = -1;
            int rightIdx = array.Length;
            while (rightIdx - leftIdx > 1)
            {
                median = (leftIdx + rightIdx) / 2;
                if (array[median] <= key)
                    leftIdx = median;
                else
                    rightIdx = median;
            }
            return (leftIdx == -1 ? -1 : (array[leftIdx] == key ? leftIdx : -1));
        }
    }
}