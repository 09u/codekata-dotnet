using System.Numerics;

namespace Fibonacci
{
    public class Fibonacci
    {
        private Dictionary<BigInteger, BigInteger> _fibDict;

        public Fibonacci()
        {
            _fibDict = new Dictionary<BigInteger, BigInteger>();
        }

        public BigInteger Calculate(BigInteger i)
        {
            if(_fibDict.ContainsKey(i))
                return _fibDict.GetValueOrDefault(i);
            
            if (i < 0)
                return 0;

            if (i == 0 || i == 1)
            {
                _fibDict.Add(i, i);
                return i;
            }

            _fibDict.Add(i, (Calculate(i-1) + Calculate(i-2)));

            return _fibDict.GetValueOrDefault(i);
        }
    }
}
