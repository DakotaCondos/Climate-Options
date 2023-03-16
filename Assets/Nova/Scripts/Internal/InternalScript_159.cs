using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_498 : System.IComparable<InternalType_498>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_101 InternalField_1711;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1710;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_684 => InternalField_1711.InternalField_317;

        public int CompareTo(InternalType_498 other)
        {
            if (InternalProperty_684 != other.InternalProperty_684)
            {
                return InternalProperty_684.CompareTo(other.InternalProperty_684);
            }

            if (InternalField_1711.InternalField_316 != other.InternalField_1711.InternalField_316)
            {
                return InternalField_1711.InternalField_316.CompareTo(other.InternalField_1711.InternalField_316);
            }

            return InternalField_1710.CompareTo(other.InternalField_1710);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_498 InternalField_3659 = new InternalType_498()
        {
            InternalField_1711 = new InternalType_101()
            {
                InternalField_316 = int.MinValue,
                InternalField_317 = int.MinValue,
                InternalField_491 = false,
            },
            InternalField_1710 = int.MinValue,
        };
    }

    internal struct InternalType_270
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_224> InternalField_845;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_339> InternalField_846;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_299<InternalType_71>> InternalField_847;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_133, int> InternalField_848;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_101> InternalField_849;

        public InternalType_498 InternalMethod_1939(InternalType_133 InternalParameter_1302)
        {
            InternalType_224 InternalVar_1 = InternalField_845[InternalParameter_1302];
            if (!InternalField_846.TryGetValue(InternalVar_1.InternalField_589, out InternalType_339 InternalVar_2))
            {
                return InternalType_498.InternalField_3659;
            }

            InternalType_498 InternalVar_3 = new InternalType_498();
            if (!InternalField_849.TryGetValue(InternalVar_1.InternalField_589, out InternalVar_3.InternalField_1711))
            {
                InternalVar_3.InternalField_1711 = InternalType_101.InternalField_318;
            }

            short InternalVar_4 = InternalField_847[InternalParameter_1302].InternalField_983.InternalField_233;
            int InternalVar_5 = InternalVar_2.InternalMethod_1501(InternalVar_4);
            InternalVar_3.InternalField_1710 = InternalField_848[InternalParameter_1302] + InternalVar_5;
            return InternalVar_3;
        }
    }
}

