using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace Nova.InternalNamespace_0.InternalNamespace_12
{
    internal static partial class InternalType_482
    {
        [BurstCompile]
        internal unsafe struct InternalType_483 : IJobParallelForTransform
        {
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2175;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_2176;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_2177;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_2178;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_142> InternalField_2179;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_165.InternalType_166 InternalField_383;

            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_2180;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2181;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2182;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float4x4> InternalField_2183;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float4x4> InternalField_2184;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_220> InternalField_2185;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_2186;

            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53> InternalField_2187;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_54> InternalField_2188;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_55> InternalField_2189;

            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2190;

            [NativeDisableContainerSafetyRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeReference<UnsafeAtomicCounter32> InternalField_2191;

            [NativeDisableContainerSafetyRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeReference<UnsafeAtomicCounter32> InternalField_2192;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Execute(int physicalTransformChunkIndex, TransformAccess transform)
            {
                InternalType_133 InternalVar_1 = InternalField_2178[physicalTransformChunkIndex];

                InternalType_131 InternalVar_2 = InternalField_2175[InternalVar_1].InternalField_586;
                InternalType_133 InternalVar_3 = InternalVar_2.InternalProperty_192 ? InternalField_2176[InternalVar_2] : InternalType_133.InternalField_418;
                bool InternalVar_4 = InternalVar_3.InternalProperty_194 && InternalField_2179[InternalVar_3].InternalField_426;

                float3 InternalVar_5 = transform.localPosition;
                float3 InternalVar_6 = InternalVar_4 ? InternalField_2181[InternalVar_3] + InternalField_2181[InternalVar_1] : InternalField_2181[InternalVar_1];
                bool InternalVar_7 = !math.all(InternalType_187.InternalMethod_927(ref InternalVar_6, ref InternalVar_5));

                quaternion InternalVar_8 = transform.localRotation;
                ref quaternion InternalVar_9 = ref InternalField_2180.ElementAt(InternalVar_1);
                bool InternalVar_10 = !math.all(InternalType_187.InternalMethod_929(ref InternalVar_9.value, ref InternalVar_8.value));

                float3 InternalVar_11 = transform.localScale;
                ref float3 InternalVar_12 = ref InternalField_2182.ElementAt(InternalVar_1);
                bool InternalVar_13 = !math.all(InternalType_187.InternalMethod_927(ref InternalVar_12, ref InternalVar_11));

                InternalType_220 InternalVar_14 = InternalVar_7 || InternalVar_10 || InternalVar_13 ? InternalType_220.InternalField_579 : InternalType_220.InternalField_3625;

                if (!InternalVar_3.InternalProperty_194)
                {
                    ref float4x4 InternalVar_15 = ref InternalField_2184.ElementAt(InternalVar_1);
                    float4x4 InternalVar_16 = transform.localToWorldMatrix;


                    if (InternalVar_10 || InternalVar_13 || !InternalVar_16.Equals(InternalVar_15))
                    {
                        InternalVar_15 = InternalVar_16;
                        InternalField_2183.ElementAt(InternalVar_1) = math.inverse(InternalVar_15);

                        InternalVar_14 = InternalType_220.InternalMethod_1052(InternalVar_14, InternalType_220.InternalField_3626);
                    }
                }

                if (InternalVar_7 && !InternalVar_4 && InternalField_383[InternalVar_1]) 
                {
                    InternalField_2192.InternalMethod_1031()->Add(1);
                    InternalField_2186[InternalVar_1] = true;
                    InternalField_2181[InternalVar_1] = InternalVar_5;
                }

                if (InternalVar_10)
                {
                    InternalVar_9 = InternalVar_8;
                }

                if (InternalVar_13)
                {
                    InternalVar_12 = InternalVar_11;
                }

                if (InternalVar_14.InternalProperty_249)
                {
                    ref InternalType_220 InternalVar_15 = ref InternalField_2185.ElementAt(InternalVar_1);

                    InternalVar_15 = InternalType_220.InternalMethod_1052(InternalVar_15, InternalVar_14);

                    InternalField_2191.InternalMethod_1031()->Add(1);
                }
            }
        }
    }
}
