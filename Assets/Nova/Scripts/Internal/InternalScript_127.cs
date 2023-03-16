using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_12
{
    internal partial class InternalType_460
    {
        [BurstCompile]
        public struct InternalType_470 : InternalType_193
        {
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2093;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2094;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_55> InternalField_2095;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2096;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_2097;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_2098;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2099;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2100;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_2101;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Execute(int index)
            {
                InternalMethod_1892(InternalField_2101[index]);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void InternalMethod_1892(InternalType_133 InternalParameter_2099, bool InternalParameter_2100 = false)
            {
                InternalType_222 InternalVar_1 = InternalField_2100[InternalParameter_2099];

                float3 InternalVar_2 = float.MaxValue;
                float3 InternalVar_3 = float.MinValue;

                int InternalVar_4 = InternalVar_1.InternalField_587.InternalProperty_216;

                for (int InternalVar_5 = 0; InternalVar_5 < InternalVar_4; ++InternalVar_5)
                {
                    InternalType_133 InternalVar_6 = InternalVar_1.InternalField_587[InternalVar_5];

                    float3x2 InternalVar_7 = default;
                    if (InternalParameter_2100)
                    {
                        InternalMethod_1894(InternalVar_6, InternalParameter_2099, out InternalVar_7);
                    }
                    else
                    {
                        InternalMethod_1893(InternalVar_6, out InternalVar_7);
                    }

                    InternalVar_2 = math.min(InternalVar_7.c0, InternalVar_2);
                    InternalVar_3 = math.max(InternalVar_7.c1, InternalVar_3);
                }

                if (InternalVar_4 == 0)
                {
                    InternalVar_2 = InternalType_187.InternalField_530;
                    InternalVar_3 = InternalType_187.InternalField_530;
                }

                float3 InternalVar_8 = InternalVar_3 - InternalVar_2;
                float3 InternalVar_9 = (InternalVar_3 + InternalVar_2) * InternalType_187.InternalField_526;

                InternalField_2093[InternalParameter_2099] = InternalVar_8;
                InternalField_2094[InternalParameter_2099] = InternalVar_9;
            }

            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1893(InternalType_133 InternalParameter_2101, out float3x2 InternalParameter_2102)
            {
                InternalType_448.InternalType_453 InternalVar_1 = InternalType_448.InternalMethod_1751(InternalParameter_2101, ref InternalField_2095);
                InternalType_187.InternalMethod_896(InternalVar_1.InternalMethod_1831(ref InternalField_2097, ref InternalField_2098) + InternalVar_1.InternalProperty_401.InternalProperty_137, out float3x2 InternalVar_2);
                InternalType_187.InternalMethod_896(InternalField_2096[InternalParameter_2101] - InternalVar_1.InternalProperty_401.InternalProperty_139, out float3x2 InternalVar_3);
                InternalParameter_2102 = (InternalVar_2 * InternalType_187.InternalField_499) + InternalVar_3;
            }

            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1894(InternalType_133 InternalParameter_2103, InternalType_133 InternalParameter_2104, out float3x2 InternalParameter_2105)
            {
                InternalType_448.InternalType_453 InternalVar_1 = InternalType_448.InternalMethod_1751(InternalParameter_2103, ref InternalField_2095);
                InternalType_448.InternalType_453 InternalVar_2 = InternalType_448.InternalMethod_1751(InternalParameter_2104, ref InternalField_2095);

                InternalType_187.InternalMethod_896(InternalVar_1.InternalMethod_1831(ref InternalField_2097, ref InternalField_2098), out float3x2 InternalVar_3);

                float3 InternalVar_4 = InternalType_182.InternalMethod_851(InternalVar_1.InternalProperty_399.InternalProperty_124, InternalVar_3.c0 + InternalVar_1.InternalProperty_401.InternalProperty_137, InternalVar_1.InternalProperty_401.InternalProperty_139, InternalVar_2.InternalProperty_402, InternalVar_2.InternalProperty_400.InternalProperty_139, InternalField_2099[InternalParameter_2103]);
                InternalType_187.InternalMethod_896(InternalVar_4, out float3x2 InternalVar_5);
                InternalParameter_2105 = (InternalVar_3 * InternalType_187.InternalField_499) + InternalVar_5;
            }
        }

        [BurstCompile]
        public struct InternalType_473 : InternalType_192
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2115;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2116;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_2117;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2118;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_3637;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_55> InternalField_2119;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2120;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_2121;

            public void Execute()
            {
                int InternalVar_1 = InternalField_2121.Length;

                for (int InternalVar_2 = InternalVar_1 - 1; InternalVar_2 >= 0; --InternalVar_2)
                {
                    InternalType_133 InternalVar_3 = InternalField_2121[InternalVar_2];

                    InternalType_222 InternalVar_4 = InternalField_2120[InternalVar_3];

                    float3 InternalVar_5 = float.MaxValue;
                    float3 InternalVar_6 = float.MinValue;

                    int InternalVar_7 = InternalVar_4.InternalField_587.InternalProperty_216;

                    for (int InternalVar_8 = 0; InternalVar_8 < InternalVar_7; ++InternalVar_8)
                    {
                        InternalType_133 InternalVar_9 = InternalVar_4.InternalField_587[InternalVar_8];

                        InternalMethod_1898(InternalVar_9, out float3x2 InternalVar_10);

                        InternalVar_5 = math.min(InternalVar_10.c0, InternalVar_5);
                        InternalVar_6 = math.max(InternalVar_10.c1, InternalVar_6);
                    }

                    if (InternalVar_7 == 0)
                    {
                        InternalVar_5 = InternalType_187.InternalField_530;
                        InternalVar_6 = InternalType_187.InternalField_530;
                    }

                    InternalType_187.InternalMethod_896(InternalType_448.InternalMethod_1751(InternalVar_3, ref InternalField_2119).InternalProperty_398.InternalProperty_124, out float3x2 InternalVar_11);
                    float3x2 InternalVar_12 = InternalVar_11 * InternalType_187.InternalField_499;

                    InternalVar_5 = math.min(InternalVar_12[0], InternalVar_5);
                    InternalVar_6 = math.max(InternalVar_12[1], InternalVar_6);

                    InternalField_2115[InternalVar_3] = InternalVar_6 - InternalVar_5;
                    InternalField_2116[InternalVar_3] = (InternalVar_6 + InternalVar_5) * InternalType_187.InternalField_526;
                }
            }

            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1898(InternalType_133 InternalParameter_2116, out float3x2 InternalParameter_2117)
            {
                quaternion InternalVar_1 = InternalField_2117[InternalParameter_2116];
                float3 InternalVar_2 = InternalField_3637[InternalParameter_2116];

                InternalType_187.InternalMethod_896(InternalType_182.InternalMethod_859(InternalField_2115[InternalParameter_2116], InternalVar_1) * InternalVar_2, out float3x2 InternalVar_3);
                float3 InternalVar_4 = InternalField_2118[InternalParameter_2116] + math.rotate(InternalVar_1, InternalField_2116[InternalParameter_2116] * InternalVar_2);

                InternalType_187.InternalMethod_896(InternalVar_4, out float3x2 InternalVar_5);
                InternalParameter_2117 = (InternalVar_3 * InternalType_187.InternalField_499) + InternalVar_5;
            }
        }
    }
}