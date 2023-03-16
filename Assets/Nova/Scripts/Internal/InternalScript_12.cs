using System;
using System.Collections.Generic;

namespace Nova.InternalNamespace_0.InternalNamespace_4
{
    internal struct InternalType_152<T93> : IEquatable<InternalType_152<T93>>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal static readonly InternalType_152<T93> InternalField_441 = default;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static long InternalField_442 = 1;
        
        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long InternalField_443;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_220 => InternalField_443 != InternalField_441.InternalField_443;

        public static InternalType_152<T93> InternalMethod_716()
        {
            return new InternalType_152<T93>()
            {
                InternalField_443 = InternalField_442++
            };
        }

        public bool Equals(InternalType_152<T93> other)
        {
            return InternalField_443 == other.InternalField_443;
        }

        public override int GetHashCode()
        {
            return InternalField_443.GetHashCode();
        }

        public override string ToString()
        {
            return $"UID<{typeof(T93).Name}>({InternalField_443})";
        }
    }

    internal static class InternalType_169<T31>
    {
        private interface InternalType_170
        {
            void InternalMethod_822(InternalType_152<T31> InternalParameter_666);
        }

        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static Dictionary<Type, InternalType_170> InternalField_459 = new Dictionary<Type, InternalType_170>();
        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static Dictionary<InternalType_152<T31>, InternalType_170> InternalField_460 = new Dictionary<InternalType_152<T31>, InternalType_170>();

        public static void InternalMethod_821(InternalType_152<T31> InternalParameter_665)
        {
            if (!InternalField_460.TryGetValue(InternalParameter_665, out InternalType_170 InternalVar_1))
            {
                return;
            }

            InternalVar_1.InternalMethod_822(InternalParameter_665);
        }

        internal sealed class InternalType_171<T32> : InternalType_170 where T32 : struct
        {
            [NonSerialized]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private static Dictionary<InternalType_152<T31>, T32> InternalField_461 = new Dictionary<InternalType_152<T31>, T32>();

            void InternalType_170.InternalMethod_822(InternalType_152<T31> InternalParameter_666) => InternalMethod_824(InternalParameter_666);

            public static InternalType_152<T31> InternalMethod_823(T32 InternalParameter_667)
            {
                InternalType_152<T31> InternalVar_1 = InternalType_152<T31>.InternalMethod_716();

                InternalField_461.Add(InternalVar_1, InternalParameter_667);

                Type InternalVar_2 = typeof(T32);

                if (!InternalField_459.TryGetValue(InternalVar_2, out InternalType_170 InternalVar_3))
                {
                    InternalVar_3 = new InternalType_171<T32>();
                    InternalField_459.Add(InternalVar_2, InternalVar_3);
                }

                InternalField_460.Add(InternalVar_1, InternalVar_3);

                return InternalVar_1;
            }

            public static void InternalMethod_824(InternalType_152<T31> InternalParameter_668)
            {
                InternalField_461.Remove(InternalParameter_668);
                InternalField_460.Remove(InternalParameter_668);
            }

            public static T32 InternalMethod_825(InternalType_152<T31> InternalParameter_669)
            {
                if (InternalField_461.TryGetValue(InternalParameter_669, out T32 InternalVar_1))
                {
                    return InternalVar_1;
                }

                return default;
            }

            public static bool InternalMethod_826(InternalType_152<T31> InternalParameter_670, out T32 InternalParameter_671)
            {
                return InternalField_461.TryGetValue(InternalParameter_670, out InternalParameter_671);
            }

            public static void InternalMethod_827(InternalType_152<T31> InternalParameter_672, T32 InternalParameter_673)
            {
                if (!InternalField_461.TryGetValue(InternalParameter_672, out T32 _))
                {
                    UnityEngine.Debug.LogError($"Not tracking a struct instance of Type {typeof(T32)} with the given ID");
                    return;
                }

                InternalField_461[InternalParameter_672] = InternalParameter_673;
            }
        }
    }
}
