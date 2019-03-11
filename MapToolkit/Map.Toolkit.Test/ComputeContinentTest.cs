using NFluent;
using NUnit.Framework;

namespace Map.Toolkit.Test
{
    [TestFixture]
    public class ComputeContinentTest
    {
        private MapToolkit.Model.Map _map;

        [SetUp]
        public void Init()
        {
            _map = new MapToolkit.Model.Map();
        }

        [Test]
        public void The_number_of_continents_should_be_0_when_map_is_empty()
        {
            int[][] map = { };
            var continentNumber = _map.ComputeContinent();
            var expectedContinentCount = 0;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }
    }
}
