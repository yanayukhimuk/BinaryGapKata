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
            _integer = 9;

            Assert.That(_binaryConverter.BinaryGapsAmount(_integer), Is.EqualTo(1));
            Assert.That(_binaryConverter.CalculateZerosInBinaryGap(_integer), Is.EqualTo(2));
        }

        [Test]
        public void CheckTheBinaryGapOfABigNumber()
        {
            _integer = 20;

            Assert.That(_binaryConverter.BinaryGapsAmount(_integer), Is.EqualTo(1));
            Assert.That(_binaryConverter.CalculateZerosInBinaryGap(_integer), Is.EqualTo(1));
        }

        [Test]
        public void CheckTheBinaryGapOfABinaryWithOnesOnly()
        {
            _integer = 15;

            Assert.That(_binaryConverter.BinaryGapsAmount(_integer), Is.EqualTo(0));
            Assert.That(_binaryConverter.CalculateZerosInBinaryGap(_integer), Is.EqualTo(0));
        }
    }
}