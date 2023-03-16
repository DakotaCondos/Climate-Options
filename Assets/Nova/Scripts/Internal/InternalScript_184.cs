using Nova.Compat;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_359
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NovaHashMap<InternalType_103, InternalType_311> InternalField_1249;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NovaHashMap<InternalType_310, InternalType_321> InternalField_1250;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1554(InternalType_103 InternalParameter_1679, out InternalType_310 InternalParameter_1680)
        {
            if (!InternalMethod_1555(InternalParameter_1679, out InternalType_311 InternalVar_1))
            {
                InternalParameter_1680 = InternalType_310.InternalField_1023;
                return false;
            }

            InternalParameter_1680 = InternalVar_1.InternalField_1025;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1555(InternalType_103 InternalParameter_1681, out InternalType_311 InternalParameter_1682) => InternalField_1249.TryGetValue(InternalParameter_1681, out InternalParameter_1682);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1556(InternalType_103 InternalParameter_1683, out InternalType_311 InternalParameter_1684, out InternalType_321 InternalParameter_1685)
        {
            if (!InternalField_1249.TryGetValue(InternalParameter_1683, out InternalParameter_1684))
            {
                InternalParameter_1685 = default;
                return false;
            }

            return InternalField_1250.TryGetValue(InternalParameter_1684.InternalField_1025, out InternalParameter_1685);
        }

        public InternalType_359(ref NovaHashMap<InternalType_103, InternalType_311> InternalParameter_993, ref NovaHashMap<InternalType_310, InternalType_321> InternalParameter_992)
        {
            this.InternalField_1249 = InternalParameter_993;
            this.InternalField_1250 = InternalParameter_992;
        }
    }

    internal struct InternalType_360
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NovaHashMap<InternalType_310, InternalType_282> InternalField_1251;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NovaHashMap<InternalType_310, InternalType_314> InternalField_1252;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NovaHashMap<InternalType_282, int> InternalField_1253;

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1558(InternalType_310 InternalParameter_1688, out InternalType_314 InternalParameter_1689)
        {
            InternalParameter_1689 = InternalType_314.InternalField_1041;

            if (!InternalType_24.InternalProperty_945.InternalField_3088)
            {
                return false;
            }

            return
                InternalField_1251.TryGetValue(InternalParameter_1688, out InternalType_282 InternalVar_1) &&
                InternalField_1252.TryGetValue(InternalParameter_1688, out InternalParameter_1689);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1559(InternalType_310 InternalParameter_1690, out InternalType_282 InternalParameter_1691)
        {
            InternalParameter_1691 = InternalType_282.InternalField_923;
            if (!InternalType_24.InternalProperty_945.InternalField_3088)
            {
                return false;
            }

            return InternalField_1251.TryGetValue(InternalParameter_1690, out InternalParameter_1691);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1943(InternalType_282 InternalParameter_716)
        {
            return InternalField_1253.TryGetValue(InternalParameter_716, out int InternalVar_1) && InternalVar_1 > 1;
        }

        public InternalType_360(ref NovaHashMap<InternalType_310, InternalType_282> InternalParameter_998, ref NovaHashMap<InternalType_310, InternalType_314> InternalParameter_997,
            ref NovaHashMap<InternalType_282, int> InternalParameter_989)
        {
            InternalField_1251 = InternalParameter_998;
            InternalField_1252 = InternalParameter_997;
            InternalField_1253 = InternalParameter_989;
        }
    }
}