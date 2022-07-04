using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPasswordGenerator
{
    public class MethodResult<T>
    {
        private Exception _Excep;
        public Exception Excep
        {
            get { return _Excep; }
            set { _Excep = value; }
        }

        private String _ErrorMessae;
        public String ErrorMessage
        {
            get
            {
                return _ErrorMessae;
            }
            set
            {
                _ErrorMessae = value;
            }
        }
        private T _Result;
        public T Result
        {
            get { return _Result; }
            set { _Result = value; }
        }
        public MethodResult(T pResult)
        {
           



        }
    }
}
