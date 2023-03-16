using AOT;
using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;

namespace Nova.InternalNamespace_0.InternalNamespace_12
{
    internal partial class InternalType_460
    {
        [BurstCompile]
        public struct InternalType_461 : InternalType_193
        {
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53> InternalField_1898;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_54> InternalField_1899;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_1900;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1901;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_99> InternalField_1902;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_98> InternalField_1903;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_70> InternalField_1904;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public unsafe NovaHashMap<InternalType_133, InternalType_96> InternalField_1905;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_1906;

            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_18> InternalField_1907;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_220> InternalField_1908;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_1909;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_1910;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_1911;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_478> InternalField_1913;

            public unsafe void Execute(int index)
            {
                ref InternalType_18 InternalVar_1 = ref InternalField_1907.ElementAt(index);
                InternalType_131 InternalVar_2 = InternalVar_1.InternalField_1838;

                if (!InternalVar_2.InternalProperty_192)
                {
                    return;
                }

                if (!InternalField_1910.TryGetValue(InternalVar_2, out InternalType_133 InternalVar_3))
                {
                    Debug.LogError($"Failed to get index for {InternalVar_2}");
                    return;
                }

                InternalType_448.InternalType_449 InternalVar_4 = InternalType_448.InternalMethod_1747(InternalVar_3, ref InternalField_1898);
                InternalVar_4.InternalMethod_1807(ref InternalField_1899);
                InternalVar_4.InternalMethod_1796(ref InternalField_1902);
                InternalVar_4.InternalMethod_1800(ref InternalField_1901);
                InternalVar_4.InternalMethod_1803(ref InternalField_1900);
                InternalVar_4.InternalMethod_1798(ref InternalField_1903);

                ref InternalType_448.InternalType_451 InternalVar_5 = ref InternalType_448.InternalType_449.InternalMethod_1795(ref UnsafeUtility.AsRef<InternalType_69>(InternalVar_1.InternalField_1836));
                InternalType_220 InternalVar_6 = InternalVar_4.InternalMethod_1792(ref InternalVar_5, InternalParameter_2012: InternalField_1911[InternalVar_3]);

                ref InternalType_70 InternalVar_7 = ref InternalField_1904.ElementAt(InternalVar_3);
                ref InternalType_70 InternalVar_8 = ref UnsafeUtility.AsRef<InternalType_70>(InternalVar_1.InternalField_1227);

                if (InternalVar_7.InternalField_225 != InternalVar_8.InternalField_225)
                {
                    InternalField_1905.Add(InternalVar_3, InternalVar_7.InternalField_225);
                }

                InternalType_220 InternalVar_9 = InternalVar_7.InternalMethod_1046(ref InternalVar_8);

                InternalType_220 InternalVar_10 = InternalType_220.InternalMethod_1052(InternalVar_6, InternalVar_9);

                if (NovaApplication.ConstIsEditor)
                {
#pragma warning disable CS0162 
                    InternalType_222 InternalVar_11 = InternalField_1909[InternalVar_3];

                    if (!InternalVar_11.InternalField_586.InternalProperty_192 && InternalField_1913.TryGetValue(InternalVar_11.InternalField_585, out InternalType_478 InternalVar_12) && InternalVar_12.InternalField_2146 && InternalVar_12.InternalField_2147)
                    {
                        InternalVar_10 = InternalType_220.InternalField_580;
                    }
#pragma warning restore CS0162 
                }

                if (InternalVar_10.InternalProperty_249)
                {
                    InternalField_1908[InternalVar_3] = InternalType_220.InternalMethod_1052(InternalVar_10, InternalField_1908[InternalVar_3]);
                }
            }
        }

        [BurstCompile]
        public struct InternalType_462 : InternalType_192
        {
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_99> InternalField_1914;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_70> InternalField_1915;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_1916;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_220> InternalField_1917;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_1918;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_1919;

            public void Execute()
            {
                int InternalVar_1 = InternalField_1916.Length;
                for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; ++InternalVar_2)
                {
                    InternalType_133 InternalVar_3 = InternalField_1916[InternalVar_2];

                    InternalType_220 InternalVar_4 = InternalField_1917[InternalVar_3];

                    if (!InternalVar_4.InternalProperty_250)
                    {
                        continue;
                    }

                    InternalType_222 InternalVar_5 = InternalField_1918[InternalVar_3];

                    if (InternalMethod_1867(ref InternalVar_5))
                    {
                        InternalVar_1++;
                    }

                    if (InternalVar_4 > InternalType_220.InternalField_579)
                    {
                        InternalVar_1 += InternalMethod_1868(ref InternalVar_5);
                    }
                }
            }

            private bool InternalMethod_1867(ref InternalType_222 InternalParameter_2064)
            {
                InternalType_131 InternalVar_1 = InternalParameter_2064.InternalField_586;

                if (!InternalVar_1.InternalProperty_192 || !InternalField_1919.TryGetValue(InternalVar_1, out InternalType_133 InternalVar_2))
                {
                    return false;
                }

                bool InternalVar_3 = InternalField_1915.ElementAt(InternalVar_2).InternalProperty_155 || math.any(InternalField_1914[InternalVar_2].InternalProperty_177);

                InternalType_220 InternalVar_4 = InternalVar_3 ? InternalType_220.InternalField_580 : InternalType_220.InternalField_3626;
                return InternalMethod_1869(InternalVar_2, InternalVar_4);
            }

            private int InternalMethod_1868(ref InternalType_222 InternalParameter_2065)
            {
                InternalType_164<InternalType_133> InternalVar_1 = InternalParameter_2065.InternalField_587;
                int InternalVar_2 = InternalParameter_2065.InternalProperty_253;

                int InternalVar_3 = 0;
                for (int InternalVar_4 = 0; InternalVar_4 < InternalVar_2; ++InternalVar_4)
                {
                    InternalType_133 InternalVar_5 = InternalVar_1[InternalVar_4];

                    if (InternalMethod_1869(InternalVar_5, InternalType_220.InternalField_3626))
                    {
                        InternalVar_3++;
                    }
                }

                return InternalVar_3;
            }

            private bool InternalMethod_1869(InternalType_133 InternalParameter_2066, InternalType_220 InternalParameter_2067)
            {
                InternalType_220 InternalVar_1 = InternalField_1917[InternalParameter_2066];

                if (InternalVar_1 == InternalType_220.InternalField_580)
                {
                    return false;
                }

                bool InternalVar_2 = false;
                if (!InternalVar_1.InternalProperty_249)
                {
                    InternalField_1916.Add(InternalParameter_2066);
                    InternalVar_2 = true;
                }

                InternalField_1917[InternalParameter_2066] = InternalType_220.InternalMethod_1052(InternalVar_1, InternalParameter_2067);

                return InternalVar_2;
            }
        }

        
        [BurstCompile]
        public unsafe struct InternalType_463 : InternalType_192
        {
            [WriteOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_1920;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_220> InternalField_1921;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeReference<UnsafeAtomicCounter32> InternalField_1922;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeReference<int> InternalField_1923;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeReference<bool> InternalField_1924;

            public void Execute()
            {
                InternalField_1924.Value = false;

                unsafe
                {
                    int InternalVar_1 = *InternalField_1922.Value.Counter;
                    if (InternalVar_1 == 0)
                    {
                        return;
                    }

                    InternalField_1924.Value = InternalField_1923.Value != InternalVar_1;
                }

                bool InternalVar_2 = false;
                int InternalVar_3 = InternalField_1921.Length;
                for (int InternalVar_4 = 0; InternalVar_4 < InternalVar_3; ++InternalVar_4)
                {
                    if (!InternalField_1921[InternalVar_4].InternalProperty_249)
                    {
                        continue;
                    }

                    InternalVar_2 = true;
                    InternalField_1920.Add(InternalVar_4);
                }

                InternalField_1924.Value |= InternalVar_2;
            }
        }

        [BurstCompile]
        public struct InternalType_464 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_1925;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53> InternalField_1926;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_54> InternalField_1927;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_99> InternalField_1928;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1929;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_1930;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_98> InternalField_1931;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_70> InternalField_1932;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_133, InternalType_96> InternalField_1933;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_1934;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_1935;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_18> InternalField_1937;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_220> InternalField_1938;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_133, InternalType_131> InternalField_1939;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_1940;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_1941;

            public unsafe void Execute()
            {
                InternalField_1941.Clear();

                if (!InternalField_1940.TryGetValue(InternalField_1925, out InternalType_133 InternalVar_1))
                {
                    return;
                }

                InternalType_133 InternalVar_2 = InternalMethod_1870(InternalVar_1);
                InternalField_1941.Add(InternalVar_2);

                for (int InternalVar_3 = 0; InternalVar_3 < InternalField_1941.Length; ++InternalVar_3)
                {
                    InternalType_133 InternalVar_4 = InternalField_1941[InternalVar_3];
                    ref InternalType_222 InternalVar_5 = ref InternalField_1935.ElementAt(InternalVar_4);

                    InternalType_448.InternalType_449 InternalVar_6 = InternalType_448.InternalMethod_1747(InternalVar_4, ref InternalField_1926);
                    InternalVar_6.InternalMethod_1796(ref InternalField_1928);

                    ref InternalType_18 InternalVar_7 = ref InternalField_1937.ElementAt(InternalVar_4);

                    if (InternalVar_7.InternalField_1838 == InternalVar_5.InternalField_585)
                    {
                        InternalVar_6.InternalMethod_1807(ref InternalField_1927);
                        InternalVar_6.InternalMethod_1800(ref InternalField_1929);
                        InternalVar_6.InternalMethod_1803(ref InternalField_1930);
                        InternalVar_6.InternalMethod_1798(ref InternalField_1931);

                        InternalType_220 InternalVar_8 = InternalVar_6.InternalMethod_1792(ref InternalType_448.InternalType_449.InternalMethod_1795(ref UnsafeUtility.AsRef<InternalType_69>(InternalVar_7.InternalField_1836)));

                        ref InternalType_70 InternalVar_9 = ref InternalField_1932.ElementAt(InternalVar_4);
                        ref InternalType_70 InternalVar_10 = ref UnsafeUtility.AsRef<InternalType_70>(InternalVar_7.InternalField_1227);

                        if (InternalVar_9.InternalField_225 != InternalVar_10.InternalField_225)
                        {
                            InternalField_1933.Add(InternalVar_4, InternalVar_9.InternalField_225);
                        }

                        InternalType_220 InternalVar_11 = InternalVar_9.InternalMethod_1046(ref InternalVar_10);
                        InternalType_220 InternalVar_12 = InternalType_220.InternalMethod_1052(InternalVar_8, InternalVar_11);
                        InternalField_1938[InternalVar_4] = InternalType_220.InternalMethod_1052(InternalField_1938[InternalVar_4], InternalVar_12);
                    }

                    if (InternalField_1932.ElementAt(InternalVar_4).InternalProperty_155 || math.any(InternalVar_6.InternalProperty_354.InternalProperty_177))
                    {
                        unsafe
                        {
                            InternalField_1941.AddRange(InternalVar_5.InternalField_587.InternalProperty_232, InternalVar_5.InternalProperty_253);
                        }
                    }
                    else
                    {
                        if (InternalVar_4 == InternalVar_1)
                        {
                            break;
                        }

                        int InternalVar_8 = InternalVar_5.InternalProperty_253;
                        for (int InternalVar_9 = 0; InternalVar_9 < InternalVar_8; ++InternalVar_9)
                        {
                            InternalType_133 InternalVar_10 = InternalVar_5.InternalField_587[InternalVar_9];

                            if (InternalField_1939.ContainsKey(InternalVar_10))
                            {
                                InternalField_1941.Add(InternalVar_10);
                                break;
                            }
                        }
                    }
                }
            }

            private InternalType_133 InternalMethod_1870(InternalType_133 InternalParameter_2068)
            {
                bool3 InternalVar_1 = true;

                ref InternalType_222 InternalVar_2 = ref InternalField_1935.ElementAt(InternalParameter_2068);
                InternalType_133 InternalVar_3 = InternalParameter_2068;

                InternalField_1939.Clear();

                InternalField_1939.Add(InternalParameter_2068, InternalVar_2.InternalField_585);

                while (InternalVar_2.InternalField_586.InternalProperty_192 && math.any(InternalVar_1))
                {
                    InternalVar_3 = InternalField_1940[InternalVar_2.InternalField_586];
                    InternalField_1939.Add(InternalVar_3, InternalVar_2.InternalField_586);

                    InternalType_448.InternalType_449 InternalVar_4 = InternalType_448.InternalMethod_1747(InternalVar_3, ref InternalField_1926);
                    InternalVar_4.InternalMethod_1796(ref InternalField_1928);

                    InternalVar_1 = InternalVar_1 & (InternalVar_4.InternalProperty_381 | InternalVar_4.InternalProperty_354.InternalProperty_177);

                    InternalVar_2 = ref InternalField_1935.ElementAt(InternalVar_3);
                }

                return InternalVar_3;
            }
        }

        [BurstCompile]
        public unsafe struct InternalType_465
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53> InternalField_1942;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_54> InternalField_1943;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_55> InternalField_1944;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_1945;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1946;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_99> InternalField_1947;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_70> InternalField_1948;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_45.InternalType_47> InternalField_1949;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_133, InternalType_96> InternalField_1950;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1951;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1952;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1953;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1954;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1955;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1956;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_1957;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1958;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_1959;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_98> InternalField_1960;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_447> InternalField_1961;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_18> InternalField_13;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_165 InternalField_1963;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float4x4> InternalField_1964;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float4x4> InternalField_1965;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_142> InternalField_1966;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_1967;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_1968;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_1969;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_1970;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_70 InternalField_1971;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_69 InternalField_1972;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public Vector3 InternalField_1973;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public Quaternion InternalField_1974;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public Vector3 InternalField_1975;

            [NativeDisableUnsafePtrRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_53* InternalField_1976;
            [NativeDisableUnsafePtrRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_53.InternalType_54* InternalField_1977;
            [NativeDisableUnsafePtrRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_53.InternalType_55* InternalField_1978;
            [NativeDisableUnsafePtrRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47* InternalField_1979;
            [NativeDisableUnsafePtrRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool* InternalField_1980;
            [NativeDisableUnsafePtrRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float3* InternalField_1981;
            [NativeDisableUnsafePtrRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_99* InternalField_1982;
            [NativeDisableUnsafePtrRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_70* InternalField_1983;
            [NativeDisableUnsafePtrRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_98* InternalField_1984;

            public void InternalMethod_1871()
            {
                InternalField_1948.Add(InternalField_1971);
                InternalField_1949.Add(default);

                InternalField_1942.Add(InternalField_1972.InternalField_213);
                InternalField_1942.Add(InternalField_1972.InternalField_214);
                InternalField_1942.InternalMethod_1899(InternalField_1972.InternalField_215);
                InternalField_1942.InternalMethod_1899(InternalField_1972.InternalField_216);

                InternalField_1943.Add(InternalField_1972.InternalField_217);
                InternalField_1943.Add(InternalField_1972.InternalField_218);
                InternalField_1943.InternalMethod_1900(InternalField_1972.InternalField_219);
                InternalField_1943.InternalMethod_1900(InternalField_1972.InternalField_220);

                InternalField_1944.InternalMethod_1901(InternalParameter_2123: 6);

                InternalField_1945.Add(InternalField_1972.InternalField_223);
                InternalField_1946.Add(InternalField_1972.InternalField_221);
                InternalField_1951.Add(float3.zero);

                InternalField_1947.Add(InternalField_1972.InternalField_222);
                InternalField_1960.Add(InternalField_1972.InternalField_224);

                InternalField_1952.Add(0);
                InternalField_1953.Add(0);
                InternalField_1954.Add(0);
                InternalField_1955.Add(0);
                InternalField_1961.Add(InternalType_447.InternalField_1787);

                InternalField_1956.Add(InternalField_1973);
                InternalField_1957.Add(InternalField_1974);
                InternalField_1958.Add(InternalField_1975);
                InternalField_1959.Add(false);
                InternalField_13.Add(default(InternalType_18));

                InternalField_1963.InternalMethod_811(false);

                if (InternalField_1969)
                {
                    InternalField_1968.Add(InternalField_1966.Length);
                }
                else 
                {
                    InternalField_1967.Add(InternalField_1966.Length);
                }

                InternalField_1966.Add(new InternalType_142()
                {
                    InternalField_427 = InternalField_1970,
                    InternalField_426 = InternalField_1969
                });

                InternalField_1964.Add(float4x4.identity);
                InternalField_1965.Add(float4x4.identity);

                InternalField_1983 = (InternalType_70*)InternalField_1948.GetUnsafePtr();
                InternalField_1979 = (InternalType_45.InternalType_47*)InternalField_1949.GetUnsafePtr();

                InternalField_1976 = (InternalType_53*)InternalField_1942.GetUnsafePtr();
                InternalField_1977 = (InternalType_53.InternalType_54*)InternalField_1943.GetUnsafePtr();
                InternalField_1978 = (InternalType_53.InternalType_55*)InternalField_1944.GetUnsafePtr();

                InternalField_1980 = (bool*)InternalField_1945.GetUnsafePtr();
                InternalField_1981 = (float3*)InternalField_1946.GetUnsafePtr();
                InternalField_1982 = (InternalType_99*)InternalField_1947.GetUnsafePtr();
                InternalField_1984 = (InternalType_98*)InternalField_1960.GetUnsafePtr();
            }

            [BurstCompile]
            [MonoPInvokeCallback(typeof(InternalType_175))]
            public static unsafe void InternalMethod_1872(void* InternalParameter_2069)
            {
                UnsafeUtility.AsRef<InternalType_465>(InternalParameter_2069).InternalMethod_1871();
            }
        }

        [BurstCompile]
        public struct InternalType_466
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53> InternalField_1985;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_54> InternalField_1986;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_55> InternalField_1987;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_1988;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1989;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_99> InternalField_1990;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_70> InternalField_1991;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_45.InternalType_47> InternalField_1992;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_133, InternalType_96> InternalField_1993;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1994;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_456> InternalField_1995;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1996;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1997;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1998;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_1999;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2000;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_2001;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2002;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_2003;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float4x4> InternalField_2004;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float4x4> InternalField_2005;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_142> InternalField_2006;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_2007;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_2008;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public TransformAccessArray InternalField_2009;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_18> InternalField_2011;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_98> InternalField_2012;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_447> InternalField_2013;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_165 InternalField_2014;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_133 InternalField_2015;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_2016;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_142 InternalField_2017;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeReference<UnsafeAtomicCounter32> InternalField_2018;

            public void InternalMethod_1873()
            {
                InternalField_1991.RemoveAtSwapBack(InternalField_2015);
                InternalField_1992.RemoveAtSwapBack(InternalField_2015);

                InternalField_1985.RemoveRangeSwapBack(InternalField_2015 * InternalType_448.InternalField_1800, InternalType_448.InternalField_1800);
                InternalField_1986.RemoveRangeSwapBack(InternalField_2015 * InternalType_448.InternalField_1800, InternalType_448.InternalField_1800);
                InternalField_1987.RemoveRangeSwapBack(InternalField_2015 * InternalType_448.InternalField_1800, InternalType_448.InternalField_1800);

                InternalField_1988.RemoveAtSwapBack(InternalField_2015);
                InternalField_1989.RemoveAtSwapBack(InternalField_2015);
                InternalField_1990.RemoveAtSwapBack(InternalField_2015);
                InternalField_2012.RemoveAtSwapBack(InternalField_2015);

                InternalField_1996.RemoveAtSwapBack(InternalField_2015);
                InternalField_1997.RemoveAtSwapBack(InternalField_2015);
                InternalField_1998.RemoveAtSwapBack(InternalField_2015);
                InternalField_1999.RemoveAtSwapBack(InternalField_2015);
                InternalField_2013.RemoveAtSwapBack(InternalField_2015);

                InternalField_2000.RemoveAtSwapBack(InternalField_2015);
                InternalField_2001.RemoveAtSwapBack(InternalField_2015);
                InternalField_2002.RemoveAtSwapBack(InternalField_2015);
                InternalField_2003.RemoveAtSwapBack(InternalField_2015);

                InternalField_1995.Remove(InternalField_2016);
                InternalField_1994.RemoveAtSwapBack(InternalField_2015);

                InternalField_2014.InternalMethod_812(InternalField_2015);

                InternalMethod_1874();

                ref InternalType_18 InternalVar_1 = ref InternalField_2011.ElementAt(InternalField_2015);

                if (InternalVar_1.InternalField_1838 == InternalField_2016)
                {
                    InternalVar_1.InternalField_1838 = InternalType_131.InternalField_415;
                    
                    unsafe
                    {
                        InternalVar_1.InternalField_1227 = null;
                        InternalVar_1.InternalField_1836 = null;
                    }

                    UnsafeUtility.ReleaseGCObject(InternalVar_1.InternalField_1837);
                    InternalVar_1.InternalField_1837 = 0;

                    InternalField_2018.InternalMethod_1030().SubSat(1, 0);
                }

                InternalField_2011.RemoveAtSwapBack(InternalField_2015);
            }

            private void InternalMethod_1874()
            {
                InternalField_2017 = InternalField_2006[InternalField_2015];

                InternalField_2006.RemoveAtSwapBack(InternalField_2015);
                InternalField_2005.RemoveAtSwapBack(InternalField_2015);
                InternalField_2004.RemoveAtSwapBack(InternalField_2015);

                if (InternalField_2015 < InternalField_2006.Length) 
                {
                    InternalType_142 InternalVar_1 = InternalField_2006[InternalField_2015];

                    if (InternalVar_1.InternalField_426)
                    {
                        InternalField_2008[InternalVar_1.InternalField_427] = InternalField_2015;
                    }
                    else
                    {
                        InternalField_2007[InternalVar_1.InternalField_427] = InternalField_2015;
                    }
                }

                int InternalVar_2 = -1;
                if (InternalField_2017.InternalField_426)
                {
                    InternalField_2008.RemoveAtSwapBack(InternalField_2017.InternalField_427);

                    if (InternalField_2017.InternalField_427 < InternalField_2008.Length) 
                    {
                        InternalVar_2 = InternalField_2008[InternalField_2017.InternalField_427];
                    }
                }
                else
                {
                    InternalField_2009.RemoveAtSwapBack(InternalField_2017.InternalField_427);
                    InternalField_2007.RemoveAtSwapBack(InternalField_2017.InternalField_427);

                    if (InternalField_2017.InternalField_427 < InternalField_2007.Length) 
                    {
                        InternalVar_2 = InternalField_2007[InternalField_2017.InternalField_427];
                    }
                }

                if (InternalVar_2 >= 0 && InternalVar_2 < InternalField_2006.Length)
                {
                    InternalType_142 InternalVar_3 = InternalField_2006[InternalVar_2];
                    InternalVar_3.InternalField_427 = InternalField_2017.InternalField_427;
                    InternalField_2006[InternalVar_2] = InternalVar_3;
                }
            }

            [BurstCompile]
            [MonoPInvokeCallback(typeof(InternalType_175))]
            public static unsafe void InternalMethod_1875(void* InternalParameter_2070)
            {
                UnsafeUtility.AsRef<InternalType_466>(InternalParameter_2070).InternalMethod_1873();
            }
        }

        [BurstCompile]
        public struct InternalType_733
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_18> InternalField_8;

            public void InternalMethod_7()
            {
                int InternalVar_1 = InternalField_8.Length;

                for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; InternalVar_2++)
                { 
                    ref InternalType_18 InternalVar_3 = ref InternalField_8.ElementAt(InternalVar_2);

                    if (InternalVar_3.InternalField_1837 == 0)
                    {
                        continue;
                    }

                    UnsafeUtility.ReleaseGCObject(InternalVar_3.InternalField_1837);
                }
            }

            [BurstCompile]
            [MonoPInvokeCallback(typeof(InternalType_175))]
            public static unsafe void InternalMethod_6(void* InternalParameter_1474)
            {
                UnsafeUtility.AsRef<InternalType_733>(InternalParameter_1474).InternalMethod_7();
            }
        }

        [BurstCompile]
        public struct InternalType_734
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_133 InternalField_5;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_18> InternalField_3;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_70> InternalField_1;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53> InternalField_0;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_54> InternalField_3345;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_99> InternalField_3346;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_3347;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_3348;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_98> InternalField_3349;

            public unsafe void InternalMethod_5()
            {
                InternalType_448.InternalType_449 InternalVar_1 = InternalType_448.InternalMethod_1747(InternalField_5, ref InternalField_0);

                InternalVar_1.InternalMethod_1807(ref InternalField_3345);
                InternalVar_1.InternalMethod_1796(ref InternalField_3346);
                InternalVar_1.InternalMethod_1800(ref InternalField_3347);
                InternalVar_1.InternalMethod_1803(ref InternalField_3348);
                InternalVar_1.InternalMethod_1798(ref InternalField_3349);

                ref InternalType_18 InternalVar_2 = ref InternalField_3.ElementAt(InternalField_5);

                InternalVar_1.InternalMethod_1794(ref UnsafeUtility.AsRef<InternalType_69>(InternalVar_2.InternalField_1836));
                UnsafeUtility.MemCpy(InternalVar_2.InternalField_1227, UnsafeUtility.AddressOf(ref InternalField_1.ElementAt(InternalField_5)), sizeof(InternalType_70));
            }

            [BurstCompile]
            [MonoPInvokeCallback(typeof(InternalType_175))]
            public static unsafe void InternalMethod_3328(void* InternalParameter_1473)
            {
                UnsafeUtility.AsRef<InternalType_734>(InternalParameter_1473).InternalMethod_5();
            }
        }
    }
}
