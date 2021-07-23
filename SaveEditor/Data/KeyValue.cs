using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwptSaveLib
{
    public class KeyValue
    {
        public string Key;
        public string Value;
        public KeyValue(string k, string v)
        {
            Key = k;
            Value = v;
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
