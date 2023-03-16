using System;
using System.Collections.Generic;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    internal static class InternalType_196
    {
        
        public static bool InternalMethod_975<KeyType, ValType>(this Dictionary<KeyType, ValType> InternalParameter_938, KeyType InternalParameter_939, out ValType InternalParameter_940) where ValType : class, new()
        {
            if (InternalParameter_938.TryGetValue(InternalParameter_939, out InternalParameter_940))
            {
                return true;
            }
            else
            {
                InternalParameter_940 = new ValType();
                InternalParameter_938.Add(InternalParameter_939, InternalParameter_940);
                return false;
            }
        }

        public static void InternalMethod_976<T1, T2>(this KeyValuePair<T1, T2> InternalParameter_941, out T1 InternalParameter_942, out T2 InternalParameter_943)
        {
            InternalParameter_942 = InternalParameter_941.Key;
            InternalParameter_943 = InternalParameter_941.Value;
        }

        public static void InternalMethod_977<K, V>(this Dictionary<K, V> InternalParameter_944) where V : IDisposable
        {
            foreach (var InternalVar_1 in InternalParameter_944.Values)
            {
                InternalVar_1.Dispose();
            }
        }
    }
}

