using MapToolkit.Model;
using NFluent;
using NUnit.Framework;

namespace Map.Toolkit.Test
{
    [TestFixture]
    public class ComputeContinentTest
    {
        private MapToolkit.Model.Map _map;

        [Test]
        public void The_number_of_continents_should_be_0_when_map_is_empty()
        {
            Point[][] mapStructure = { };
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 0;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }

        [Test]
        public void The_number_of_continents_should_be_0_when_map_is_00()
        {
            Point[][] mapStructure = { new[] { new Point(0), new Point(0) } };
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 0;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }

        [Test]
        public void The_number_of_continents_should_be_0_when_map_is_null()
        {
            Point[][] mapStructure = null;
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 0;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }

        [Test]
        public void The_number_of_continents_should_be_1_when_map_is_0()
        {
            Point[][] mapStructure = { new[] { new Point(0) } };
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 0;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }

        [Test]
        public void The_number_of_continents_should_be_1_when_map_is_1()
        {
            Point[][] mapStructure = { new[] { new Point(1) } };
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 1;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }

        [Test]
        public void The_number_of_continents_should_be_1_when_map_is_11()
        {
            Point[][] mapStructure = { new[] { new Point(1), new Point(1) } };
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 1;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }

        [Test]
        public void The_number_of_continents_should_be_1_when_map_is_10_10()
        {
            Point[][] mapStructure = { new[] { new Point(1), new Point(0) }, new[] { new Point(1), new Point(0) } };
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 1;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }

        [Test]
        public void The_number_of_continents_should_be_1_when_map_is_01_11()
        {
            Point[][] mapStructure = { new[] { new Point(0), new Point(1) }, new[] { new Point(1), new Point(1) } };
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 1;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }

        [Test]
        public void The_number_of_continents_should_be_1_when_map_is_01_01()
        {
            Point[][] mapStructure = { new[] { new Point(0), new Point(1) }, new[] { new Point(0), new Point(1) } };
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 1;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }

        [Test]
        public void The_number_of_continents_should_be_1_when_map_is_10_01()
        {
            Point[][] mapStructure = { new[] { new Point(1), new Point(0) }, new[] { new Point(0), new Point(1) } };
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 1;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }

        [Test]
        public void The_number_of_continents_should_be_1_when_map_is_01_10()
        {
            Point[][] mapStructure = { new[] { new Point(0), new Point(1) }, new[] { new Point(1), new Point(0) } };
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 1;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }

        [Test]
        public void The_number_of_continents_should_be_3_when_map_is_0000100000_0100100111_0111100000_0111100000_0100000100_0001111000_0001111000_0000000000()
        {
            Point[][] mapStructure = {
                new[] { new Point(0),new Point(0),new Point(0),new Point(0),new Point(1),new Point(0),new Point(0),new Point( 0),new Point( 0), new Point(0)},
                new[] { new Point(0),new Point(1),new Point(0),new Point(0),new Point(1),new Point(0),new Point(0),new Point( 1),new Point( 1), new Point(1)},
                new[] { new Point(0),new Point(1),new Point(1),new Point(1),new Point(1),new Point(0),new Point(0),new Point( 0),new Point( 0), new Point(0)},
                new[] { new Point(0),new Point(1),new Point(1),new Point(1),new Point(1),new Point(0),new Point(0),new Point( 0),new Point( 0), new Point(0)},
                new[] { new Point(0),new Point(1),new Point(0),new Point(0),new Point(0),new Point(0),new Point(0),new Point( 1),new Point( 0), new Point(0)},
                new[] { new Point(0),new Point(0),new Point(0),new Point(1),new Point(1),new Point(1),new Point(1),new Point( 0),new Point( 0), new Point(0)},
                new[] { new Point(0),new Point(0),new Point(0),new Point(1),new Point(1),new Point(1),new Point(1),new Point( 0),new Point( 0), new Point(0)},
                new[] { new Point(0),new Point(0),new Point(0), new Point(0),new Point(0),new Point(0),new Point(0),new Point( 0),new Point( 0), new Point(0)}
            };
            _map = new MapToolkit.Model.Map(mapStructure);
            var continentNumber = _map.ComputeContinent();

            var expectedContinentCount = 3;
            Check.That(continentNumber).IsEqualTo(expectedContinentCount);
        }
    }
}
