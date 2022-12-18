using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace BinaryGapLib
{
    public class BinaryConverter
    {
        private uint _binaryGap;
        private int _binaryGapsAmount = 0;

        public int BinaryGapsAmount(uint integer)
        {
            string[] binary = ConvertToBinary(integer);
            foreach (var bin in binary)
            {
                if (bin.Contains('0'))
                {
                    _binaryGapsAmount++;
                }
            }
            return _binaryGapsAmount;
        }

        public uint CalculateZerosInBinaryGap(uint integer)
        {
            _binaryGapsAmount = BinaryGapsAmount(integer);
            string[] binary = ConvertToBinary(integer);

            if (_binaryGapsAmount == 1)
            {
                foreach (var bin in binary)
                {
                    if (bin.Contains('0'))
                    {
                        _binaryGap = (uint)bin.Length;
                    }
                    else
                        continue;
                }
            }
            else if (_binaryGapsAmount > 1)
            {

            }
            else
                _binaryGap = 0;
            return _binaryGap;
        }

        private static string[] ConvertToBinary(uint integer)
        {
            return Convert.ToString(integer, 2).Trim('0').Split(new[] { '1' });
        }
    }
}