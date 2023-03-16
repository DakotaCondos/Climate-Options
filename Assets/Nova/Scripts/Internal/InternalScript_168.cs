using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_339 : InternalType_147, InternalType_150
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_164<InternalType_340> InternalField_1168;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int InternalMethod_1500(short InternalParameter_1608)
        {
            if (InternalField_1168.InternalMethod_769(InternalParameter_1608, out int InternalVar_1))
            {
                return InternalField_1168.InternalMethod_800(InternalVar_1).InternalField_1169++;
            }
            else
            {
                InternalField_1168.InternalMethod_785(new InternalType_340()
                {
                    InternalField_1170 = InternalParameter_1608,
                    InternalField_1169 = 1
                });
                return 0;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int InternalMethod_1501(short InternalParameter_1609)
        {
            int InternalVar_1 = 0;
            for (int InternalVar_2 = 0; InternalVar_2 < InternalField_1168.InternalProperty_216; ++InternalVar_2)
            {
                InternalType_340 InternalVar_3 = InternalField_1168[InternalVar_2];
                if (InternalVar_3.InternalField_1170 == InternalParameter_1609)
                {
                    return InternalVar_1;
                }

                InternalVar_1 += InternalVar_3.InternalField_1169;
            }
            return InternalVar_1;
        }

        public void InternalMethod_1502()
        {
            InternalField_1168.InternalField_452.Sort();
        }

        public void InternalMethod_702()
        {
            InternalField_1168.InternalMethod_702();
        }

        public void Dispose()
        {
            InternalField_1168.Dispose();
        }

        public void InternalMethod_705()
        {
            InternalField_1168.InternalMethod_705();
        }

        private struct InternalType_340 : IEquatable<short>, IComparable<InternalType_340>
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_1169;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public short InternalField_1170;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int CompareTo(InternalType_340 other)
            {
                return InternalField_1170 - other.InternalField_1170;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(short other)
            {
                return InternalField_1170 == other;
            }
        }
    }
}

