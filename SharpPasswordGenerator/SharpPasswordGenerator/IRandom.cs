using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SharpPasswordGenerator
{
    public abstract class IRandom
    {
        public abstract int Next(int Min, int Max);
        protected int _iSeedValue = 0;
        protected IRandom()
        {
            _iSeedValue = Convert.ToInt32(DateTime.Now.ToOADate()); // Convert.ToInt32 ( DateTime.Now.Ticks);
        }
        protected IRandom(int iSeedValue)
        {
            _iSeedValue = iSeedValue;
        }
    }

    //This class is for testing only
    public class StanddardRandom : IRandom
    {
        private readonly Random R = new Random();
        private readonly object syncLock = new object();
        public StanddardRandom()
            : base()
        {
        }
        public StanddardRandom(int iSeedValue) : base(iSeedValue)
        {
            R = new Random(_iSeedValue);
        }


        public override int Next(int Min, int Max)
        {
            //throw new NotImplementedException();
            lock (syncLock)
            {

                return R.Next(Min, Max);
            }

        }
    }

    //
    public class CryptoRandom : IRandom
    {
        //RNGCryptoServiceProvider 
        public CryptoRandom(int iSeedValue) : base(iSeedValue)
        {
            //  R = new Random(_iSeedValue);
        }
        public CryptoRandom()
        {

        }



        private readonly RandomNumberGenerator rng = new RNGCryptoServiceProvider();


        public int Next()
        {
            var data = new byte[sizeof(int)];
            rng.GetBytes(data);
            return BitConverter.ToInt32(data, 0) & (int.MaxValue - 1);
        }

        public int Next(int maxValue)
        {
            return Next(0, maxValue);
        }


       

        public double NextDouble()
        {
            var data = new byte[sizeof(uint)];
            rng.GetBytes(data);
            var randUint = BitConverter.ToUInt32(data, 0);
            return randUint / (uint.MaxValue + 1.0);
        }

        public override int Next(int Min, int Max)
        {
            if (Min > Max)
            {
                throw new ArgumentOutOfRangeException();
            }
            return (int)Math.Floor((Min + ((double)Max - Min) * NextDouble()));

        }
    }
    public class MockRandom : IRandom
    {
        private int _Result = 0;
        public void SetResult(int pResult)
        {
            _Result = pResult;
        }
        public MockRandom(int iSeedValue)
            : base(iSeedValue)
        {

        }

        public override int Next(int Min, int Max)
        {
            return _Result;
        }
    }

    public class MockRandomV2 : IRandom
    {
        private int _Result = 0;
        private String _str = "";
        int iCount = -1;
        public void SetResult(String str)
        {
            //_Result = pResult;
            _str = str;
        }
        public MockRandomV2(int iSeedValue)
            : base(iSeedValue)
        {

        }

        public override int Next(int Min, int Max)
        {
            iCount++;

            if (iCount >= _str.Length)
            {
                iCount = 0;
            }
            int iResult = Encoding.ASCII.GetBytes(_str.Substring(iCount, 1))[0];
            return _Result;
        }
    }

}
