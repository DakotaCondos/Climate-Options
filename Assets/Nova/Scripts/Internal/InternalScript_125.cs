using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_12
{
    internal partial class InternalType_460
    {
        
        [BurstCompile]
        internal struct InternalType_468
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_2048;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_478> InternalField_2049;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53> InternalField_2050;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_54> InternalField_2051;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_55> InternalField_2052;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_2053;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2054;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_99> InternalField_2055;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_98> InternalField_2056;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2057;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_70> InternalField_2058;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_45.InternalType_47> InternalField_2059;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2060;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_2061;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_164<InternalType_133>> InternalField_2062;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_142> InternalField_2063;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_220> InternalField_2064;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_2065;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2066;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_2067;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool InternalMethod_1881(InternalType_133 InternalParameter_2076, bool InternalParameter_2077 = false)
            {
                InternalType_222 InternalVar_1 = InternalField_2060[InternalParameter_2076];
                InternalType_131 InternalVar_2 = InternalVar_1.InternalField_586;

                bool InternalVar_3 = InternalVar_2.InternalProperty_192;
                InternalType_133 InternalVar_4 = InternalVar_3 ? InternalField_2061[InternalVar_2] : InternalType_133.InternalField_418;

                bool InternalVar_5 = false;

                if (!InternalParameter_2077)
                {
                    bool InternalVar_6 = InternalField_2064[InternalParameter_2076].InternalProperty_250;

                    InternalType_220 InternalVar_7 = !InternalVar_3 ? InternalType_220.InternalField_3625 : InternalField_2064[InternalVar_4];
                    InternalVar_5 = InternalVar_7 == InternalType_220.InternalField_580;

                    if (!InternalVar_6 && !InternalVar_5)
                    {
                        if (InternalVar_7.InternalProperty_249)
                        {
                            InternalField_2064[InternalParameter_2076] = InternalType_220.InternalField_3626;
                        }

                        return false;
                    }
                }

                InternalType_448.InternalType_449 InternalVar_8 = InternalType_448.InternalMethod_1749(InternalParameter_2076, ref InternalField_2050, ref InternalField_2052);
                InternalVar_8.InternalMethod_1807(ref InternalField_2051);
                InternalVar_8.InternalMethod_1796(ref InternalField_2055);
                InternalVar_8.InternalMethod_1800(ref InternalField_2054);
                InternalVar_8.InternalMethod_1803(ref InternalField_2053);
                InternalVar_8.InternalMethod_1798(ref InternalField_2056);
                InternalVar_8.InternalMethod_1802(ref InternalField_2057);

                float3 InternalVar_9 = InternalVar_3 ? InternalMethod_1897(InternalVar_4) : InternalType_187.InternalField_530;

                InternalType_448.InternalType_450 InternalVar_10 = InternalVar_8.InternalMethod_1793();
                InternalVar_8.InternalMethod_1785(InternalVar_9);

                if (InternalField_2048 && !InternalVar_3)
                {
                    InternalMethod_1040(ref InternalVar_8, InternalVar_1.InternalField_585);
                }

                if (InternalField_2067[InternalParameter_2076])
                {
                    float3 InternalVar_11 = InternalType_187.InternalField_530;

                    if (InternalVar_3)
                    {
                        InternalType_448.InternalType_449 InternalVar_12 = InternalType_448.InternalMethod_1749(InternalVar_4, ref InternalField_2050, ref InternalField_2052);
                        InternalVar_12.InternalMethod_1807(ref InternalField_2051);

                        InternalVar_11 = InternalVar_12.InternalProperty_378.InternalProperty_139;
                    }

                    float3 InternalVar_13 = InternalVar_8.InternalMethod_1784(ref InternalField_2065, ref InternalField_2053) + InternalVar_8.InternalProperty_379.InternalProperty_137;
                    float3 InternalVar_14 = InternalVar_8.InternalProperty_379.InternalProperty_139;

                    float3 InternalVar_15 = InternalType_182.InternalMethod_852(InternalField_2066[InternalParameter_2076], InternalVar_13, InternalVar_14, InternalVar_9, InternalVar_11, InternalField_2054[InternalParameter_2076]);

                    InternalVar_8.InternalProperty_361.InternalProperty_115 = InternalType_53.InternalMethod_388(InternalVar_15, ref InternalVar_8.InternalProperty_361, ref InternalVar_8.InternalProperty_365, InternalVar_9);

                    InternalVar_8.InternalMethod_1787(InternalVar_9);
                }

                ref InternalType_70 InternalVar_16 = ref InternalField_2058.ElementAt(InternalParameter_2076);
                ref InternalType_45.InternalType_47 InternalVar_17 = ref InternalField_2059.ElementAt(InternalParameter_2076);
                float InternalVar_18 = InternalVar_17.InternalField_153;

                if (InternalVar_16.InternalProperty_155)
                {
                    InternalMethod_3645(ref InternalVar_16, ref InternalVar_17, InternalParameter_2076);
                }

                bool InternalVar_19 = InternalVar_3 ? InternalMethod_3341(ref InternalVar_8, InternalVar_4) : false;

                if (!InternalParameter_2077)
                {
                    InternalType_220 InternalVar_20 = InternalVar_19 ? InternalType_220.InternalField_580 : InternalVar_8.InternalMethod_1791(ref InternalVar_10);

                    InternalType_220 InternalVar_21 = InternalVar_18 != InternalVar_17.InternalField_153 ? InternalType_220.InternalField_580 : InternalType_220.InternalField_3625;
                    InternalType_220 InternalVar_22 = InternalType_220.InternalMethod_1052(InternalVar_20, InternalVar_21);
                    InternalVar_22 = InternalVar_5 ? InternalType_220.InternalMethod_1052(InternalVar_22, InternalType_220.InternalField_579) : InternalVar_22;

                    InternalField_2064[InternalParameter_2076] = InternalType_220.InternalMethod_1052(InternalVar_22, InternalField_2064[InternalParameter_2076]);
                }

                return InternalVar_19;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private float3 InternalMethod_1897(InternalType_133 InternalParameter_715)
            {
                InternalType_448.InternalType_453 InternalVar_1 = InternalType_448.InternalMethod_1751(InternalParameter_715, ref InternalField_2052);
                return InternalVar_1.InternalProperty_402;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_3645(ref InternalType_70 InternalParameter_3440, ref InternalType_45.InternalType_47 InternalParameter_3441, InternalType_133 InternalParameter_3442)
            {
                InternalType_448.InternalType_453 InternalVar_1 = InternalType_448.InternalMethod_1751(InternalParameter_3442, ref InternalField_2052);

                float3 InternalVar_2 = InternalVar_1.InternalProperty_402;

                int InternalVar_3 = InternalParameter_3440.InternalField_225.InternalMethod_508();
                float InternalVar_4 = InternalVar_2[InternalVar_3];

                InternalParameter_3441 = InternalParameter_3440.InternalMethod_451(InternalVar_4);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1040(ref InternalType_448.InternalType_449 InternalParameter_1765, InternalType_131 InternalParameter_1632)
            {
                if (!InternalField_2049.TryGetValue(InternalParameter_1632, out InternalType_478 InternalVar_1) || !InternalVar_1.InternalField_2146)
                {
                    return;
                }

                InternalType_98 InternalVar_2 = InternalParameter_1765.InternalProperty_357;
                if (InternalVar_2.InternalProperty_173)
                {
                    int InternalVar_3 = InternalVar_2.InternalField_309.InternalMethod_508();
                    float3 InternalVar_4 = InternalVar_1.InternalField_2145;
                    InternalVar_4[InternalVar_3] = InternalParameter_1765.InternalProperty_360[InternalVar_3].InternalProperty_102 || InternalParameter_1765.InternalProperty_354[InternalVar_3] == InternalType_83.InternalField_281 ? InternalVar_1.InternalField_2145[InternalVar_3] / InternalParameter_1765.InternalProperty_360[InternalVar_3].InternalField_145 : InternalVar_4[InternalVar_3];

                    InternalParameter_1765.InternalMethod_1788(InternalVar_4, true);
                }
                else
                {
                    InternalParameter_1765.InternalProperty_376 = new InternalType_53.InternalType_55()
                    {
                        InternalField_177 = new InternalType_45.InternalType_47(InternalVar_1.InternalField_2145.x, InternalParameter_1765.InternalProperty_360.InternalField_167.InternalProperty_102 ? InternalParameter_1765.InternalProperty_360.InternalField_167.InternalField_145 : 1),
                        InternalField_178 = new InternalType_45.InternalType_47(InternalVar_1.InternalField_2145.y, InternalParameter_1765.InternalProperty_360.InternalField_168.InternalProperty_102 ? InternalParameter_1765.InternalProperty_360.InternalField_168.InternalField_145 : 1),
                        InternalField_179 = new InternalType_45.InternalType_47(InternalVar_1.InternalField_2145.z, InternalParameter_1765.InternalProperty_360.InternalField_169.InternalProperty_102 ? InternalParameter_1765.InternalProperty_360.InternalField_169.InternalField_145 : 1),
                    };
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private bool InternalMethod_3341(ref InternalType_448.InternalType_449 InternalParameter_2164, InternalType_133 InternalParameter_2226)
            {
                bool3 InternalVar_1 = InternalField_2055.ElementAt(InternalParameter_2226).InternalProperty_177;

                return !math.any(InternalVar_1) ? false : math.any(InternalVar_1 & InternalParameter_2164.InternalProperty_381);
            }
        }
    }
}
