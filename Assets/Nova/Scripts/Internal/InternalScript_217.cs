using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_406 : InternalType_193
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1513;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_220> InternalField_1514;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_224> InternalField_1515;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_133> InternalField_1516;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1517;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_133, InternalType_259> InternalField_1518;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float3> InternalField_1519;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<quaternion> InternalField_1520;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1521;

        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_272<InternalType_394> InternalField_1522;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_133>.ParallelWriter InternalField_1523;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_133>.ParallelWriter InternalField_1524;

        public void Execute(int index)
        {
            InternalType_133 InternalVar_1 = index;
            InternalType_224 InternalVar_2 = InternalField_1515[InternalVar_1];

            InternalType_220 InternalVar_3 = InternalField_1514[InternalVar_1];
            if (InternalVar_3.InternalProperty_249)
            {
                ref float4x4 InternalVar_4 = ref InternalField_1521.ElementAt(InternalVar_1);
                InternalType_133 InternalVar_5 = InternalField_1516[InternalVar_2.InternalField_589];
                ref float4x4 InternalVar_6 = ref InternalField_1517.ElementAt(InternalVar_5);
                InternalField_1522.InternalMethod_1253(InternalField_1518[InternalVar_1]).InternalField_1385 = math.mul(InternalVar_6, InternalVar_4);
            }

            if (!InternalField_1513.AsArray().Contains(InternalVar_2.InternalField_589))
            {
                return;
            }

            ref float3 InternalVar_7 = ref InternalField_1519.ElementAt(InternalVar_1);
            ref quaternion InternalVar_8 = ref InternalField_1520.ElementAt(InternalVar_1);

            if (!InternalType_187.InternalMethod_914(InternalVar_7.z) || !InternalVar_8.InternalMethod_931())
            {
                InternalField_1523.AddNoResize(InternalVar_1);
                InternalField_1524.AddNoResize(InternalVar_1);
                return;
            }

            if (!InternalType_187.InternalMethod_949(ref InternalVar_8))
            {
                InternalField_1524.AddNoResize(InternalVar_1);
                return;
            }
        }
    }
}
