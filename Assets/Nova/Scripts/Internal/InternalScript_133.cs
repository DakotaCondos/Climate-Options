using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace Nova.InternalNamespace_0.InternalNamespace_12
{
    internal static partial class InternalType_482
    {
        
        [BurstCompile]
        internal struct InternalType_484 : IJobParallelForTransform
        {
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2193;
            [WriteOnly, NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float4x4> InternalField_2194;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2195;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_2196;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_2197;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_142> InternalField_2198;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_220> InternalField_2199;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Execute(int phyiscalTransformIndex, TransformAccess transform)
            {
                InternalType_133 InternalVar_1 = InternalField_2197[phyiscalTransformIndex];

                if (!InternalField_2199[InternalVar_1].InternalProperty_249)
                {
                    return;
                }

                InternalType_222 InternalVar_2 = InternalField_2195[InternalVar_1];

                float3 InternalVar_3 = InternalField_2193[InternalVar_1];

                if (InternalField_2196.TryGetValue(InternalVar_2.InternalField_586, out InternalType_133 InternalVar_4) && InternalField_2198[InternalVar_4].InternalField_426)
                {
                    InternalVar_3 += InternalField_2193[InternalVar_4];
                }

                transform.localPosition = InternalVar_3;

                if (!InternalVar_4.InternalProperty_194)
                {
                    InternalField_2194[InternalVar_1] = transform.localToWorldMatrix;
                }
            }
        }

        [BurstCompile]
        internal struct InternalType_485 : InternalType_192
        {
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2200;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_2201;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_224> InternalField_3640;
            
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_142> InternalField_2202;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_2203;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_2204;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2205;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2206;

            [WriteOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_3632;
            [WriteOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_131> InternalField_3633;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float4x4> InternalField_2207;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float4x4> InternalField_2208;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_220> InternalField_2209;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Execute()
            {
                int InternalVar_1 = InternalField_2203.Length;

                for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; ++InternalVar_2)
                {
                    InternalType_133 InternalVar_3 = InternalField_2203[InternalVar_2];

                    ref InternalType_220 InternalVar_4 = ref InternalField_2209.ElementAt(InternalVar_3);
                    InternalType_222 InternalVar_5 = InternalField_2200[InternalVar_3];

                    if (!InternalField_2201.TryGetValue(InternalVar_5.InternalField_586, out InternalType_133 InternalVar_6))
                    {
                        if (InternalVar_4.InternalProperty_249)
                        {
                            InternalField_2207.ElementAt(InternalVar_3) = math.inverse(InternalField_2208.ElementAt(InternalVar_3));
                            InternalField_3633.Add(InternalVar_5.InternalField_585);

                            if (InternalVar_4 == InternalType_220.InternalField_581)
                            {
                                InternalField_3632.Add(InternalVar_3);
                            }
                        }

                        continue;
                    }

                    if (!InternalVar_4.InternalProperty_249 && !InternalField_2209[InternalVar_6].InternalProperty_249)
                    {
                        continue;
                    }

                    ref float4x4 InternalVar_7 = ref InternalField_2207.ElementAt(InternalVar_6);
                    float4x4 InternalVar_8;

                    if (InternalField_2202[InternalVar_3].InternalField_426)
                    {
                        InternalVar_8 = float4x4.Translate(-InternalField_2206[InternalVar_3]);
                    }
                    else
                    {
                        float3 InternalVar_9 = InternalField_2205[InternalVar_3];

                        float4x4 InternalVar_10 = float4x4.Scale(math.select(math.rcp(InternalVar_9), InternalType_187.InternalField_530, InternalVar_9 == InternalType_187.InternalField_530));
                        float4x4 InternalVar_11 = new float4x4(math.inverse(InternalField_2204[InternalVar_3]), InternalType_187.InternalField_530);
                        float4x4 InternalVar_12 = float4x4.Translate(-InternalField_2206[InternalVar_3]);

                        InternalVar_8 = math.mul(InternalVar_10, math.mul(InternalVar_11, InternalVar_12));
                    }

                    float4x4 InternalVar_13 = math.mul(InternalVar_8, InternalVar_7);

                    InternalField_2207.ElementAt(InternalVar_3) = InternalVar_13;
                    InternalField_2208.ElementAt(InternalVar_3) = math.inverse(InternalVar_13);

                    InternalVar_4 = InternalType_220.InternalMethod_1052(InternalVar_4, InternalType_220.InternalField_3626);

                    bool InternalVar_14 = InternalField_3640[InternalVar_3].InternalField_589 == InternalVar_5.InternalField_585;

                    if (InternalVar_14)
                    {
                        InternalField_3633.Add(InternalVar_5.InternalField_585);
                    }

                    if (InternalVar_4.InternalProperty_250)
                    {
                        InternalField_3632.Add(InternalVar_3);
                    }
                }
            }
        }
    }
}
