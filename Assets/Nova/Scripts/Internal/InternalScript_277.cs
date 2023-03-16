using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_3;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    internal static class InternalType_211
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static V InternalMethod_1557<K, V>(this ref NovaHashMap<K, V> InternalParameter_1727, K InternalParameter_1687)
            where K : unmanaged, IEquatable<K>
            where V : unmanaged, InternalType_150
        {
            V InternalVar_1 = InternalParameter_1727[InternalParameter_1687];
            InternalVar_1.InternalMethod_705();
            return InternalVar_1;
        }

        public static V InternalMethod_1297<K, V>(this ref NovaHashMap<K, V> InternalParameter_1686, K InternalParameter_1366, int InternalParameter_1367)
            where K : unmanaged, IEquatable<K>
            where V : unmanaged, InternalType_149
        {
            V InternalVar_1 = InternalParameter_1686[InternalParameter_1366];
            InternalVar_1.InternalProperty_216 = InternalParameter_1367;
            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1146<K, V>(this ref NovaHashMap<K, V> InternalParameter_2231, K InternalParameter_2235)
            where K : unmanaged, IEquatable<K>
            where V : unmanaged, InternalType_147
        {
            V InternalVar_1 = new V();
            InternalVar_1.InternalMethod_702();
            InternalParameter_2231.Add(InternalParameter_2235, InternalVar_1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1073<K, V>(this ref NovaHashMap<K, V> InternalParameter_2236, int InternalParameter_2158 = 4)
            where K : unmanaged, IEquatable<K>
            where V : unmanaged
        {
            InternalParameter_2236 = new NovaHashMap<K, V>(InternalParameter_2158, Allocator.Persistent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_3110<K, V>(this ref NovaHashMap<K, V> InternalParameter_2159, K InternalParameter_2160, out V InternalParameter_2161)
            where K : unmanaged, IEquatable<K>
            where V : unmanaged
        {
            if (InternalParameter_2159.TryGetValue(InternalParameter_2160, out InternalParameter_2161))
            {
                InternalParameter_2159.Remove(InternalParameter_2160);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

