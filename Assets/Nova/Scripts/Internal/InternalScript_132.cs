using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_12
{
    internal partial class InternalType_460
    {
        
        [BurstCompile]
        internal struct InternalType_471 : InternalType_193
        {
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_55> InternalField_2102;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53> InternalField_2103;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_54> InternalField_75;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_2104;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2105;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_2106;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_142> InternalField_2107;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2108;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_2109;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_2110;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_220> InternalField_2111;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_2112;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_478> InternalField_2113;

            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2114;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Execute(int dirtyIndex)
            {
                InternalMethod_1895(InternalField_2110[dirtyIndex]);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void InternalMethod_1895(InternalType_133 InternalParameter_2106, bool InternalParameter_2107 = false)
            {
                InternalType_222 InternalVar_1 = InternalField_2108[InternalParameter_2106];
                InternalType_131 InternalVar_2 = InternalVar_1.InternalField_586;

                InternalType_133 InternalVar_3 = InternalType_133.InternalField_418;

                if (InternalVar_2.InternalProperty_192)
                {
                    InternalVar_3 = InternalField_2109[InternalVar_2];

                    if (!InternalParameter_2107)
                    {
                        bool InternalVar_4 = InternalField_2107[InternalVar_3].InternalField_426;
                        InternalType_220 InternalVar_5 = InternalField_2111[InternalParameter_2106];

                        if (!InternalVar_5.InternalProperty_250 && !InternalVar_4 &&
                            InternalField_2111[InternalVar_3] <= InternalType_220.InternalField_579)
                        {
                            return;
                        }
                    }
                }

                float3 InternalVar_6 = InternalMethod_854(InternalVar_3);

                float3 InternalVar_7 = InternalType_187.InternalField_530;

                if (InternalVar_3.InternalProperty_194)
                {
                    InternalType_448.InternalType_453 InternalVar_8 = InternalType_448.InternalMethod_1751(InternalVar_3, ref InternalField_2102);
                    InternalVar_7 = InternalVar_8.InternalProperty_400.InternalProperty_139;
                }

                InternalType_448.InternalType_453 InternalVar_9 = InternalType_448.InternalMethod_1751(InternalParameter_2106, ref InternalField_2102);
                float3 InternalVar_10 = InternalVar_9.InternalMethod_1831(ref InternalField_2106, ref InternalField_2104);
                float3 InternalVar_11 = InternalMethod_1896(ref InternalVar_9, ref InternalVar_10, ref InternalVar_6, InternalVar_7, ref InternalField_2105);

                if (InternalType_187.InternalMethod_935(ref InternalVar_11))
                {
                    InternalField_2114[InternalParameter_2106] = InternalVar_11;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float3 InternalMethod_1896(ref InternalType_448.InternalType_453 InternalParameter_2108, ref float3 InternalParameter_2109, ref float3 InternalParameter_2110, float3 InternalParameter_2111, ref NativeList<float3> InternalParameter_2112)
            {
                InternalType_56.InternalType_58 InternalVar_1 = InternalParameter_2108.InternalProperty_401;
                float3 InternalVar_2 = InternalParameter_2112[InternalParameter_2108.InternalField_1830];
                float3 InternalVar_3 = InternalParameter_2109 + InternalVar_1.InternalProperty_137;
                return InternalType_182.InternalMethod_851(InternalParameter_2108.InternalProperty_399.InternalProperty_124, InternalVar_3, InternalVar_1.InternalProperty_139, InternalParameter_2110, InternalParameter_2111, InternalVar_2);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private float3 InternalMethod_854(InternalType_133 InternalParameter_3130)
            {
                if (!InternalParameter_3130.InternalProperty_194)
                {
                    return InternalType_187.InternalField_530;
                }

                InternalType_448.InternalType_453 InternalVar_1 = InternalType_448.InternalMethod_1751(InternalParameter_3130, ref InternalField_2102);
                return InternalVar_1.InternalProperty_402;
            }
        }
    }
}
