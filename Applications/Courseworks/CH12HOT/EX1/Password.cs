using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class Password
    {
        private string _raw;
        private string _hash;

        public Password()
        {

        }

        public Password(string raw, string hash)
        {
            _hash = hash;
            _raw = raw;
        }

        public string Raw
        {
            get { return _raw; }
        }
        public string Hash
        {
            get { return _hash; }
        }
    }
}