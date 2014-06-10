using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace google.test.utilities
{
    class RuntimeData
    {
        private static readonly Hashtable RuntimeSessionData = new Hashtable();

        public static void Save(string key, Object value)
        {
            RuntimeSessionData.Add(key, value);
        }

        public static Object Get(string key)
        {
            return RuntimeSessionData[key];
        }

        public static void Remove(string key)
        {
            RuntimeSessionData.Remove(key);
        }
    }
}
