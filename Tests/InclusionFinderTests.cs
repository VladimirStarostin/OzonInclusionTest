using Ozon;
using Shouldly;
using Xunit;

namespace Tests
{
    public class InclusionFinderTests
    {
        [Fact]
        public void InclusionFind_Test()
        {
            var t = new InclusionFinder();
            t.IsInclude(new[] { 1, 2, 3, 5, 7, 9, 11 }, new int[] { }).ShouldBeTrue();
            t.IsInclude(new[] { 1, 2, 3, 5, 7, 9, 11 }, new int[] { 7 }).ShouldBeTrue();
            t.IsInclude(new[] { 1, 2, 3, 5, 7, 9, 11 }, new int[] { 3, 5, 7 }).ShouldBeTrue();
            t.IsInclude(new[] { 1, 2, 3, 5, 7, 9, 11 }, new int[] { 4, 5, 7 }).ShouldBeFalse();

            t.IsInclude(new[] { 1, 2, 3, 5, 7, 7, 7, 9, 11 }, new int[] { 7, 9 }).ShouldBeTrue();
            t.IsInclude(new[] { 1, 2, 3, 5, 7, 7, 7, 9, 11 }, new int[] { 7, 7, 9 }).ShouldBeTrue();
            t.IsInclude(new[] { 1, 2, 3, 5, 7, 7, 7, 9, 11 }, new int[] { 7, 7, 7, 9 }).ShouldBeTrue();
            t.IsInclude(new[] { 1, 2, 3, 5, 7, 7, 7, 9, 11 }, new int[] { 5, 7, 7, 7, 9 }).ShouldBeTrue();
            t.IsInclude(new[] { 1, 2, 3, 5, 7, 7, 7, 9, 11 }, new int[] { 7, 7, 7, 7, 9 }).ShouldBeFalse();

            t.IsInclude(new[] { 1, 1, 2, 11 }, new int[] { 1, 2 }).ShouldBeTrue();
            t.IsInclude(new[] { 1, 1, 2, 11 }, new int[] { 1, 1, 2 }).ShouldBeTrue();
            t.IsInclude(new[] { 1, 1, 2, 11 }, new int[] { 1, 1, 2, 11 }).ShouldBeTrue();
            t.IsInclude(new[] { 1, 1, 2, 11 }, new int[] { 1, 1, 2, 11, 13 }).ShouldBeFalse();
            t.IsInclude(new[] { 1, 1, 2, 11 }, new int[] { 1, 1, 2, 2 }).ShouldBeFalse();
            t.IsInclude(new[] { 1, 1, 2, 11 }, new int[] { 1, 1, 1, 2 }).ShouldBeFalse();
        }
    }
}