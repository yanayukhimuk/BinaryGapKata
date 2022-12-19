namespace BinaryGapLib
{
    public class BinaryConverter
    {
        public int BinaryGapsAmount(uint integer)
        {
            var binaryGapsAmount = 0;
            string[] binary = ConvertToBinary(integer);
            foreach (var bin in binary)
            {
                if (bin.Contains('0'))
                {
                    binaryGapsAmount++;
                }
            }
            return binaryGapsAmount;
        }

        public int[] ReturnGapsLengthForEachGap(uint integer)
        {
            string[] binary = ConvertToBinary(integer);
            List<int> zeros = new List<int>();
            var binaryGap = 0;

            foreach (var bin in binary)
            {
                if (bin.Contains('0'))
                {
                    binaryGap = bin.Length;
                    zeros.Add(binaryGap);
                }
                else
                    continue;
            }
            return zeros.ToArray();
        }

        public int ReturnTheSizeOfABiggestGap(int[] array)
        {
            return array.Max();
        }

        private static string[] ConvertToBinary(uint integer)
        {
            return Convert.ToString(integer, 2).Trim('0').Split(new[] { '1' });
        }
    }
}