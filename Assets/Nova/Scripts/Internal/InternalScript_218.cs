using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_425 : InternalType_192
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1621;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_373>> InternalField_1622;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_380> InternalField_1623;

        [WriteOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeReference<InternalType_328> InternalField_1624;

        public void Execute()
        {
            InternalType_328 InternalVar_1 = default;
            for (int InternalVar_2 = 0; InternalVar_2 < InternalField_1621.Length; ++InternalVar_2)
            {
                InternalType_131 InternalVar_3 = InternalField_1621[InternalVar_2];
                InternalVar_1.InternalField_1126 += InternalField_1622[InternalVar_3].InternalProperty_216;

                InternalType_380 InternalVar_4 = InternalField_1623[InternalVar_3];
                InternalVar_1.InternalField_1127 += InternalVar_4.InternalProperty_334;
                InternalVar_1.InternalField_1128 += InternalVar_4.InternalProperty_335;
            }
            InternalField_1624.Value = InternalVar_1;
        }
    }
}

