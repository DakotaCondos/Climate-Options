using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_12
{
    internal partial class InternalType_460
    {
        
        internal struct InternalType_469 : InternalType_193
        {
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53> InternalField_2068;

            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_54> InternalField_2069;

            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_55> InternalField_2070;

            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_2071;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2072;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_99> InternalField_2073;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_98> InternalField_2074;

            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2075;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_2076;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_142> InternalField_2077;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2078;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_2079;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_164<InternalType_133>> InternalField_2080;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_70> InternalField_2081;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_45.InternalType_47> InternalField_2082;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_133, InternalType_96> InternalField_2083;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_456> InternalField_2084;

            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_220> InternalField_2085;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_2086;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_222 InternalField_2087;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_133 InternalField_2088;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private bool3 InternalField_2089;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_70 InternalField_2090;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_45.InternalType_47 InternalField_2091;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_448.InternalType_450 InternalField_2092;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Execute(int index)
            {
                InternalMethod_1885(InternalField_2080[InternalField_2086][index]);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void InternalMethod_1885(InternalType_133 InternalParameter_2087, bool InternalParameter_2088 = false)
            {
                InternalField_2088 = InternalParameter_2087;
                InternalField_2087 = InternalField_2078[InternalField_2088];

                if (!InternalParameter_2088 && !InternalMethod_1889())
                {
                    return;
                }

                InternalField_2090 = InternalField_2081[InternalField_2088];
                InternalField_2091 = InternalField_2082[InternalField_2088];

                InternalType_448.InternalType_449 InternalVar_1 = InternalType_448.InternalMethod_1749(InternalField_2088, ref InternalField_2068, ref InternalField_2070);
                InternalVar_1.InternalMethod_1807(ref InternalField_2069);
                InternalVar_1.InternalMethod_1796(ref InternalField_2073);

                InternalField_2092 = InternalVar_1.InternalMethod_1793();

                bool3 InternalVar_2 = InternalField_2092.InternalField_1815.InternalProperty_177;
                float3 InternalVar_3 = InternalField_2092.InternalField_1811.InternalProperty_124 - InternalField_2092.InternalField_1813.InternalProperty_137;

                bool InternalVar_4 = math.any(InternalVar_2);

                float3 InternalVar_5 = InternalMethod_1886(InternalVar_1, InternalVar_3);

                bool InternalVar_6 = false;
                InternalType_456 InternalVar_7 = default;

                if (InternalVar_4 && InternalField_2084.TryGetValue(InternalField_2087.InternalField_585, out InternalVar_7))
                {
                    InternalVar_6 = math.any(InternalVar_7.InternalField_1840);
                    InternalVar_5 = math.select(InternalVar_5, InternalVar_7.InternalField_1839, InternalVar_7.InternalField_1840);
                }

                float3 InternalVar_8 = math.select(InternalVar_3, InternalVar_5, InternalVar_2);

                if (InternalField_2090.InternalProperty_155)
                {
                    float3 InternalVar_9 = InternalType_187.InternalField_528 * InternalVar_5 * InternalType_187.InternalMethod_887(InternalField_2090.InternalProperty_157 & InternalField_2090.InternalMethod_449());
                    InternalMethod_1887(InternalVar_8, InternalVar_9, out float InternalVar_10);
                    InternalVar_5[InternalField_2090.InternalField_225.InternalMethod_508()] = InternalVar_10;

                    if (InternalVar_6)
                    {
                        InternalVar_5 = math.select(InternalVar_5, InternalVar_7.InternalField_1839, InternalVar_7.InternalField_1840);
                    }
                }
                else if (InternalVar_4)
                {
                    InternalMethod_1888(ref InternalVar_8);
                }

                bool InternalVar_11 = InternalMethod_1891(ref InternalVar_5);

                if (InternalVar_11)
                {
                    InternalField_2085[InternalField_2088] = InternalType_220.InternalField_580;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private float3 InternalMethod_1886(InternalType_448.InternalType_449 InternalParameter_1797, float3 InternalParameter_1796)
            {
                int InternalVar_1 = InternalField_2087.InternalProperty_253;
                bool InternalVar_2 = InternalField_2077[InternalField_2088].InternalField_426;

                float3 InternalVar_3 = float.MaxValue;
                float3 InternalVar_4 = float.MinValue;

                int InternalVar_5 = InternalField_2090.InternalField_225.InternalMethod_508();

                if (!InternalVar_2 && InternalField_2090.InternalProperty_155 && InternalField_2083.TryGetValue(InternalField_2088, out InternalType_96 InternalVar_6))
                {
                    InternalField_2089 = InternalVar_6 == InternalType_96.InternalField_304 ? InternalVar_5 != InternalType_187.InternalField_498 : InternalVar_6.InternalMethod_508() == InternalType_187.InternalField_498;
                }
                else
                {
                    InternalField_2089 = InternalType_187.InternalField_548;
                }

                bool3 InternalVar_7 = InternalField_2090.InternalMethod_449();
                bool3 InternalVar_8 = InternalField_2090.InternalProperty_155 ? InternalVar_7 | InternalField_2089 : false;
                bool3 InternalVar_9 = InternalField_2092.InternalField_1815.InternalProperty_177;

                float3 InternalVar_10 = InternalType_187.InternalField_530;
                float3 InternalVar_11 = InternalType_187.InternalField_530;

                InternalType_448.InternalType_449 InternalVar_12 = InternalType_448.InternalMethod_1749(InternalType_133.InternalField_418, ref InternalField_2068, ref InternalField_2070);
                InternalVar_12.InternalMethod_1796(ref InternalField_2073);
                InternalVar_12.InternalMethod_1807(ref InternalField_2069);

                for (int InternalVar_13 = 0; InternalVar_13 < InternalVar_1; ++InternalVar_13)
                {
                    InternalType_133 InternalVar_14 = InternalField_2087.InternalField_587[InternalVar_13];

                    InternalVar_12.InternalProperty_353 = InternalVar_14;
                    InternalMethod_1890(ref InternalVar_12, InternalVar_9, out float3 InternalVar_15, out float3 InternalVar_16);

                    InternalVar_10 += InternalVar_15;
                    InternalVar_11 += InternalVar_16;

                    float3 InternalVar_17 = math.max(InternalVar_15, InternalVar_15.InternalMethod_978(InternalType_187.InternalField_531 - InternalVar_16));
                    InternalType_187.InternalMethod_896(InternalVar_17, out float3x2 InternalVar_18);

                    float3x2 InternalVar_19 = InternalVar_18 * InternalType_187.InternalField_499;

                    InternalVar_3 = math.min(InternalVar_3, InternalVar_19.c0);
                    InternalVar_4 = math.max(InternalVar_4, InternalVar_19.c1);
                }

                bool InternalVar_20 = false;
                bool InternalVar_21 = false;

                if (InternalField_2090.InternalProperty_155)
                {
                    InternalVar_20 = InternalField_2092.InternalField_1815[InternalVar_5] == InternalType_83.InternalField_282;
                    float InternalVar_22 = InternalField_2091.InternalField_153;

                    if (InternalField_2090.InternalField_228)
                    {
                        InternalVar_21 = true;
                        float3 InternalVar_23 = math.max(InternalVar_10, InternalVar_10.InternalMethod_978(InternalType_187.InternalField_531 - InternalVar_11)) * InternalType_187.InternalMethod_887(InternalVar_7);
                        float InternalVar_24;

                        if (InternalVar_20)
                        {
                            InternalVar_24 = math.max((InternalParameter_1797.InternalProperty_364[InternalVar_5].InternalField_148 - InternalVar_23[InternalVar_5]) / (InternalVar_1 - 1), 0);
                        }
                        else
                        {
                            InternalVar_24 = (InternalParameter_1796[InternalVar_5] - InternalVar_23[InternalVar_5]) / (InternalVar_1 - 1);
                        }

                        InternalVar_24 = InternalField_2090.InternalField_227.InternalMethod_349(InternalVar_24);
                        InternalType_45 InternalVar_25 = new InternalType_45() { InternalField_145 = InternalVar_24 };
                        InternalVar_22 = InternalVar_24;
                        InternalField_2090.InternalField_226 = InternalVar_25;
                    }

                    if (!InternalVar_20 || !InternalField_2090.InternalField_226.InternalProperty_102)
                    {
                        InternalVar_10 += (InternalVar_1 - 1) * InternalVar_22 * InternalType_187.InternalMethod_887(InternalVar_7);
                    }
                }

                float3 InternalVar_26 = math.max(InternalVar_10, InternalVar_10.InternalMethod_978(InternalType_187.InternalField_531 - InternalVar_11)) * InternalType_187.InternalMethod_887(InternalVar_7);
                float3 InternalVar_27 = math.select(math.max(InternalType_187.InternalField_530, InternalVar_4 - InternalVar_3), InternalVar_26, InternalVar_7);

                if (InternalVar_20 || InternalVar_21)
                {
                    InternalField_2091 = InternalField_2090.InternalMethod_451(InternalVar_27[InternalVar_5]);
                    InternalField_2082[InternalField_2088] = InternalField_2091;

                    if (InternalVar_20 && InternalField_2090.InternalField_226.InternalProperty_102)
                    {
                        InternalVar_27[InternalVar_5] += InternalField_2091.InternalField_153 * (InternalVar_1 - 1);
                    }
                }

                return InternalVar_27;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1887(float3 InternalParameter_2090, float3 InternalParameter_2091, out float InternalParameter_2092)
            {
                int InternalVar_1 = InternalField_2090.InternalField_225.InternalMethod_508();
                float3 InternalVar_2 = InternalField_2090.InternalField_230;

                float InternalVar_3 = InternalField_2090.InternalField_231;
                float InternalVar_4 = InternalVar_3;
                InternalParameter_2092 = 0;

                bool InternalVar_5 = InternalField_2090.InternalProperty_156;
                bool3 InternalVar_6 = InternalField_2090.InternalMethod_449();
                float3 InternalVar_7 = InternalType_187.InternalMethod_887(!InternalField_2089);

                bool InternalVar_8 = math.any(InternalField_2092.InternalField_1815.InternalProperty_177);

                InternalType_448.InternalType_449 InternalVar_9 = InternalType_448.InternalMethod_1749(InternalType_133.InternalField_418, ref InternalField_2068, ref InternalField_2070);
                InternalVar_9.InternalMethod_1807(ref InternalField_2069);
                InternalVar_9.InternalMethod_1796(ref InternalField_2073);
                InternalVar_9.InternalMethod_1798(ref InternalField_2074);
                InternalVar_9.InternalMethod_1802(ref InternalField_2075);

                int InternalVar_10 = math.select(1, -1, InternalVar_5);

                for (int InternalVar_11 = math.select(0, InternalField_2087.InternalField_587.InternalProperty_216 - 1, InternalVar_5); InternalVar_11 >= 0 && InternalVar_11 < InternalField_2087.InternalField_587.InternalProperty_216; InternalVar_11 += InternalVar_10)
                {
                    InternalType_133 InternalVar_12 = InternalField_2087.InternalField_587[InternalVar_11];

                    InternalVar_9.InternalProperty_353 = InternalVar_12;
                    float3 InternalVar_13 = InternalVar_9.InternalProperty_383;

                    if (InternalVar_8 && !InternalParameter_2090.Equals(InternalVar_13))
                    {
                        InternalVar_9.InternalMethod_1785(InternalParameter_2090);
                        InternalVar_13 = InternalParameter_2090;
                    }

                    float3 InternalVar_14 = InternalVar_9.InternalMethod_1784(ref InternalField_2076, ref InternalField_2071);
                    InternalVar_14 += InternalVar_9.InternalProperty_379.InternalProperty_137;

                    float InternalVar_15 = InternalVar_14[InternalVar_1];

                    float InternalVar_16 = math.select(0, 0.5f * InternalVar_15, InternalField_2090.InternalProperty_157);

                    ref float3 InternalVar_17 = ref InternalField_2072.ElementAt(InternalVar_12);
                    InternalVar_17 = math.select(InternalVar_17, InternalVar_2, InternalVar_6);


                    ref InternalType_53 InternalVar_18 = ref InternalVar_9.InternalProperty_361;
                    float3 InternalVar_19 = InternalVar_18.InternalProperty_115 * InternalVar_7;

                    InternalType_45 InternalVar_20 = InternalVar_18[InternalVar_1];
                    InternalVar_20.InternalField_146 = InternalType_59.InternalField_201;
                    InternalVar_18[InternalVar_1] = InternalVar_20;

                    InternalVar_18.InternalProperty_115 = math.select(InternalVar_19, InternalVar_4 + InternalVar_16, InternalVar_6) + InternalParameter_2091;
                    InternalVar_9.InternalMethod_1787(InternalVar_13);

                    InternalVar_4 += InternalVar_15 + InternalField_2091.InternalField_153;
                }

                InternalParameter_2092 = InternalVar_4 - InternalField_2091.InternalField_153 - InternalVar_3;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1888(ref float3 InternalParameter_2093)
            {
                InternalType_448.InternalType_449 InternalVar_1 = InternalType_448.InternalMethod_1749(InternalType_133.InternalField_418, ref InternalField_2068, ref InternalField_2070);
                InternalVar_1.InternalMethod_1807(ref InternalField_2069);
                InternalVar_1.InternalMethod_1796(ref InternalField_2073);
                InternalVar_1.InternalMethod_1798(ref InternalField_2074);
                InternalVar_1.InternalMethod_1802(ref InternalField_2075);

                for (int InternalVar_2 = 0; InternalVar_2 < InternalField_2087.InternalField_587.InternalProperty_216; ++InternalVar_2)
                {
                    InternalType_133 InternalVar_3 = InternalField_2087.InternalField_587[InternalVar_2];

                    InternalVar_1.InternalProperty_353 = InternalVar_3;
                    float3 InternalVar_4 = InternalVar_1.InternalProperty_383;

                    if (InternalParameter_2093.Equals(InternalVar_4))
                    {
                        continue;
                    }

                    InternalVar_1.InternalMethod_1785(InternalParameter_2093);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private bool InternalMethod_1889()
            {
                if (InternalField_2085[InternalField_2088] == InternalType_220.InternalField_580)
                {
                    return true;
                }

                bool InternalVar_1 = false;
                int InternalVar_2 = InternalField_2087.InternalProperty_253;

                for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_2; ++InternalVar_3)
                {
                    InternalType_133 InternalVar_4 = InternalField_2087.InternalField_587[InternalVar_3];

                    if (InternalField_2085[InternalVar_4].InternalProperty_250)
                    {
                        InternalVar_1 = true;
                        break;
                    }
                }

                return InternalVar_1;
            }

            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1890(ref InternalType_448.InternalType_449 InternalParameter_2094, bool3 InternalParameter_2095, out float3 InternalParameter_2096, out float3 InternalParameter_2097)
            {
                bool3 InternalVar_1 = !InternalParameter_2095;
                float3 InternalVar_2 = InternalParameter_2094.InternalMethod_1784(ref InternalField_2076, ref InternalField_2071) * InternalType_187.InternalMethod_887(!InternalParameter_2094.InternalProperty_380 | InternalVar_1);
                float3 InternalVar_3 = InternalParameter_2094.InternalProperty_360.InternalProperty_117;

                bool3 InternalVar_4 = InternalParameter_2095 & !InternalParameter_2094.InternalProperty_354.InternalProperty_178;

                float3x2 InternalVar_5 = InternalParameter_2094.InternalProperty_379.InternalProperty_133;
                InternalVar_5.c0 *= InternalType_187.InternalMethod_887(!InternalParameter_2094.InternalProperty_363.InternalProperty_127 | InternalVar_1);
                InternalVar_5.c1 *= InternalType_187.InternalMethod_887(!InternalParameter_2094.InternalProperty_363.InternalProperty_128 | InternalVar_1);
                float3x2 InternalVar_6 = InternalParameter_2094.InternalProperty_363.InternalProperty_130;

                InternalParameter_2096 = InternalVar_2 + InternalVar_5.c0 + InternalVar_5.c1;
                InternalParameter_2097 = (InternalVar_3 + InternalVar_6.c0 + InternalVar_6.c1) * InternalType_187.InternalMethod_887(InternalVar_4);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private bool InternalMethod_1891(ref float3 InternalParameter_2098)
            {
                bool3 InternalVar_1 = InternalField_2073.ElementAt(InternalField_2088).InternalProperty_177;
                InternalType_448.InternalType_449 InternalVar_2 = InternalType_448.InternalMethod_1749(InternalField_2088, ref InternalField_2068, ref InternalField_2070);

                if (!math.any(InternalVar_1))
                {
                    return false;
                }

                InternalVar_2.InternalMethod_1807(ref InternalField_2069);
                InternalVar_2.InternalMethod_1796(ref InternalField_2073);
                InternalVar_2.InternalMethod_1798(ref InternalField_2074);
                InternalVar_2.InternalMethod_1802(ref InternalField_2075);
                InternalVar_2.InternalMethod_1786();

                ref InternalType_56 InternalVar_3 = ref InternalVar_2.InternalProperty_362;

                float3 InternalVar_4 = InternalVar_2.InternalProperty_378.InternalProperty_137;
                float3 InternalVar_5 = InternalParameter_2098 + InternalVar_4;

                float3 InternalVar_6 = InternalVar_2.InternalProperty_360.InternalProperty_115;
                InternalVar_2.InternalProperty_360.InternalProperty_118 = InternalVar_2.InternalProperty_360.InternalProperty_118 & !InternalVar_1;
                InternalVar_2.InternalProperty_360.InternalProperty_115 = math.select(InternalVar_6, InternalVar_5, InternalVar_1);

                float3 InternalVar_7 = InternalVar_2.InternalProperty_383;

                InternalVar_2.InternalMethod_1788(InternalVar_7, InternalVar_1);
                InternalVar_2.InternalMethod_1786();

                return math.any(InternalVar_2.InternalProperty_360.InternalProperty_115 != InternalVar_6);
            }
        }
    }
}
