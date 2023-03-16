using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal enum InternalType_344
    {
        InternalField_1185,
        InternalField_1186,
    }

    internal struct InternalType_345 : InternalType_147
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_344> InternalField_1187;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_101> InternalField_1188;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, int> InternalField_3381;

        public void InternalMethod_1507(InternalType_131 InternalParameter_1615)
        {
            InternalField_1187[InternalParameter_1615] = InternalType_344.InternalField_1185;
        }

        public void InternalMethod_1508(InternalType_131 InternalParameter_1616)
        {
            InternalField_1187.Remove(InternalParameter_1616);
        }

        public void InternalMethod_1509(InternalType_131 InternalParameter_1617, ref InternalType_101 InternalParameter_1618)
        {
            InternalField_1187[InternalParameter_1617] = InternalType_344.InternalField_1186;
            InternalField_1188[InternalParameter_1617] = InternalParameter_1618;
        }

        public void InternalMethod_1510(InternalType_131 InternalParameter_1619)
        {
            InternalField_1187.Remove(InternalParameter_1619);
            InternalField_1188.Remove(InternalParameter_1619);
        }

        public void InternalMethod_702()
        {
            InternalField_1187.Init(InternalType_178.InternalField_3012);
            InternalField_1188.Init(InternalType_178.InternalField_3011);
            InternalField_3381.Init(InternalType_178.InternalField_3011);
        }

        public void Dispose()
        {
            InternalField_1187.Dispose();
            InternalField_1188.Dispose();
            InternalField_3381.Dispose();
        }
    }
}

