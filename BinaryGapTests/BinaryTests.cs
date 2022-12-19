using BinaryGapLib;

namespace BinaryGapTests
{
    public class Tests
    {
        private BinaryConverter _binaryConverter;
        private uint _integer;

        [SetUp]
        public void Setup()
        {
            _binaryConverter = new BinaryConverter();
        }

        [Test]
        public void CheckTheBinaryGapOfASmallDigit()
        {
            int[] expected = { 2 };
            _integer = 9;

            Assert.That(_binaryConverter.BinaryGapsAmount(_integer), Is.EqualTo(1));
            Assert.That(_binaryConverter.ReturnGapsLengthForEachGap(_integer), Is.EqualTo(expected));
        }

        [Test]
        public void CheckTheBinaryGapOfABigNumber()
        {
            int[] expected = { 1 };
            _integer = 20;

            Assert.That(_binaryConverter.BinaryGapsAmount(_integer), Is.EqualTo(1));
            Assert.That(_binaryConverter.ReturnGapsLengthForEachGap(_integer), Is.EqualTo(expected));
        }

        [Test]
        public void CheckTheBinaryGapOfABinaryWithOnesOnly()
        {
            int[] expected = Array.Empty<int>();
            _integer = 15;

            Assert.That(_binaryConverter.BinaryGapsAmount(_integer), Is.EqualTo(0));
            Assert.That(_binaryConverter.ReturnGapsLengthForEachGap(_integer), Is.EqualTo(expected));
        }

        [Test]
        public void CheckTheBinaryGapForAnIntegerWithTwoGaps()
        {
            _integer = 529;
            var returnedGaps = _binaryConverter.ReturnGapsLengthForEachGap(_integer);
            var maxGap = _binaryConverter.ReturnTheSizeOfABiggestGap(returnedGaps);
            int[] expected = { 3, 4 };

            Assert.That(_binaryConverter.BinaryGapsAmount(_integer), Is.EqualTo(2));
            Assert.That(returnedGaps, Is.EquivalentTo(expected));
            Assert.That(maxGap, Is.EqualTo(4));
        }
    }
}