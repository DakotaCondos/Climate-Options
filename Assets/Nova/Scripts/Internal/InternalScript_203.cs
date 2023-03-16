using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [Flags]
    internal enum InternalType_266 : ushort
    {
        InternalField_785 = 0,
        InternalField_786 = 1,
        InternalField_787 = 2 * InternalField_786,
        InternalField_788 = 2 * InternalField_787,
        InternalField_789 = 2 * InternalField_788,
        InternalField_790 = 2 * InternalField_789,

        InternalField_791 = InternalField_788 | InternalField_790
    }

    
    internal struct InternalType_373
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_133 InternalField_1294;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_348 InternalField_1295;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_301 InternalField_1296;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_266 InternalField_1297;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_1298;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_373(ref InternalType_133 InternalParameter_1710, ref InternalType_348 InternalParameter_1711, ref InternalType_301 InternalParameter_1712, InternalType_266 InternalParameter_1713)
        {
            InternalField_1294 = InternalParameter_1710;
            InternalField_1295 = InternalParameter_1711;
            InternalField_1296 = InternalParameter_1712;
            InternalField_1297 = InternalParameter_1713;
            InternalField_1298 = false;
        }
    }

    internal static class InternalType_395
    {
        public static bool InternalMethod_999(int InternalParameter_1737, ref NativeList<InternalType_131> InternalParameter_1736, ref NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_373>> InternalParameter_1735, out InternalType_131 InternalParameter_1694, out int InternalParameter_1693)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_1736.Length; ++InternalVar_1)
            {
                InternalParameter_1694 = InternalParameter_1736[InternalVar_1];
                InternalType_162<InternalType_288, InternalType_373> InternalVar_2 = InternalParameter_1735[InternalParameter_1694];
                if (InternalParameter_1737 >= InternalVar_2.InternalProperty_216)
                {
                    InternalParameter_1737 -= InternalVar_2.InternalProperty_216;
                    continue;
                }

                InternalParameter_1693 = InternalParameter_1737;
                return true;
            }

            InternalParameter_1694 = InternalType_131.InternalField_415;
            InternalParameter_1693 = -1;
            return false;
        }

        public static bool InternalMethod_1605(this ref InternalType_266 InternalParameter_1740)
        {
            return (InternalParameter_1740 & InternalType_266.InternalField_787) == 0;
        }
    }
}