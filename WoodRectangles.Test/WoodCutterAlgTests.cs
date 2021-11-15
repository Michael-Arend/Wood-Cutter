using System.Collections.Generic;
using WoodCutterAlg;
using Xunit;

namespace WoodCutTests
{
    public class WoodCutterAlgTests
    {
        private readonly WoodCutterAlgorithm _alg;

        public WoodCutterAlgTests()
        {
            _alg = new WoodCutterAlgorithm();
        }

        [Theory]
        [MemberData(nameof(TestPlatesNoTurning))]
        public void DifferentPlatesWithoutTurningShouldReturnMinimumPlateTheory(int expectedWidth, int expectedHeight, List<PlateModel> TestPlates)
        {

            var result = _alg.CalculateMinimumBasicPlate(TestPlates, false);

            Assert.Equal(expectedWidth, result.Item1.Width);
            Assert.Equal(expectedHeight, result.Item1.Height);

        }

        [Theory]
        [MemberData(nameof(TestPlatesWithTurning))]
        public void DifferentPlatesWithTurningShouldReturnMinimumPlateTheory(int expectedWidth, int expectedHeight, List<PlateModel> TestPlates)
        {

            var result = _alg.CalculateMinimumBasicPlate(TestPlates, true);

            Assert.Equal(expectedWidth, result.Item1.Width);
            Assert.Equal(expectedHeight, result.Item1.Height);

        }

        public static IEnumerable<object[]> TestPlatesNoTurning()
        => new[]
        {
           new object[] {25,10, new List<PlateModel> { new PlateModel(5, 10), new PlateModel(5, 10), new PlateModel(5, 10), new PlateModel(5, 10), new PlateModel(5, 10) } },
           new object[] {4,10, new List<PlateModel> { new PlateModel(4, 5), new PlateModel(2, 2), new PlateModel(1, 2), new PlateModel(1, 2), new PlateModel(4, 2), new PlateModel(4, 1) } },
            new object[] {9,5, new List<PlateModel> { new PlateModel(4, 5), new PlateModel(2, 2), new PlateModel(1, 2), new PlateModel(2, 1), new PlateModel(4, 2), new PlateModel(4, 1) } }
        };


        public static IEnumerable<object[]> TestPlatesWithTurning()
       => new[]
       {
           new object[] {5,8, new List<PlateModel> { new PlateModel(4, 5), new PlateModel(2, 2), new PlateModel(1, 2), new PlateModel(2, 1), new PlateModel(4, 2), new PlateModel(4, 1) } }
       };
    }
}
