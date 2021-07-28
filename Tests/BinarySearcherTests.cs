using Ozon;
using Shouldly;
using Xunit;

namespace Tests
{
    public class BinarySearcherTests
    {
        [Fact]
        public void RightBinarySearch_Test()
        {
            var binSearcher = new BinarySearcher();

            binSearcher.GetRightIdxBinary(new int[] { 1, 2, 2, 2, 3, 3, 3, 3, 7 }, 2).ShouldBe(3);
            binSearcher.GetRightIdxBinary(new int[] { 1, 2, 3, 7 }, 2).ShouldBe(1);
            binSearcher.GetRightIdxBinary(new int[] { 1, 2, 3, 7 }, 0).ShouldBe(-1);
            binSearcher.GetRightIdxBinary(new int[] { 1, 2, 2, 2, 3, 3, 3, 3, 7 }, 7).ShouldBe(8);
            binSearcher.GetRightIdxBinary(new int[] { 0, 2, 2, 2, 3, 3, 3, 3, 7 }, 0).ShouldBe(0);
        }
    }
}