using AOT;
using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_12
{
    [BurstCompile]
    internal partial class InternalType_460
    {
        [BurstCompile]
        internal struct InternalType_467 : InternalType_192
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_2019;
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_478> InternalField_2020;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_2021;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53> InternalField_2022;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_54> InternalField_2023;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_53.InternalType_55> InternalField_2024;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2025;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_2026;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<bool> InternalField_2027;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_99> InternalField_2028;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_98> InternalField_2029;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_70> InternalField_2030;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_45.InternalType_47> InternalField_2031;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_133, InternalType_96> InternalField_2032;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_456> InternalField_2033;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2034;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2035;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2036;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_142> InternalField_2037;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_2038;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2039;

            [NativeDisableContainerSafetyRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2040;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_2041;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_133, InternalType_131> InternalField_2042;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_18> InternalField_2044;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_220> InternalField_2045;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_2046;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeReference<bool> InternalField_2047;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Execute()
            {
                InternalField_2047.Value = false;

                bool InternalVar_1 = InternalField_2021.InternalProperty_192;

                NativeList<InternalType_133> InternalVar_2 = InternalField_2046;
                int InternalVar_3 = InternalVar_2.Length;

                if (InternalVar_3 == 0)
                {
                    return;
                }

                InternalMethod_1877(out InternalType_468 InternalVar_4);

                bool InternalVar_5 = false;
                for (int InternalVar_6 = 0; InternalVar_6 < InternalVar_3; ++InternalVar_6)
                {
                    InternalType_133 InternalVar_7 = InternalVar_2[InternalVar_6];
                    InternalVar_5 |= InternalVar_4.InternalMethod_1881(InternalVar_7, InternalParameter_2077: InternalVar_1);
                }

                InternalField_2047.Value = InternalVar_5;

                InternalMethod_1878(out InternalType_469 InternalVar_8);

                for (int InternalVar_9 = InternalVar_3 - 1; InternalVar_9 >= 0; --InternalVar_9)
                {
                    InternalVar_8.InternalMethod_1885(InternalVar_2[InternalVar_9], InternalParameter_2088: InternalVar_1);
                }

                if (InternalVar_1)
                {
                    InternalMethod_1880(out InternalType_471 InternalVar_9);

                    InternalType_133 InternalVar_10 = InternalField_2041[InternalField_2021];

                    if (!InternalField_2037[InternalVar_10].InternalField_426)
                    {
                        InternalVar_9.InternalMethod_1895(InternalVar_10, InternalParameter_2107: InternalVar_1);

                        InternalMethod_1879(out InternalType_470 InternalVar_11);
                        InternalVar_11.InternalMethod_1892(InternalVar_10, InternalParameter_2100: true);
                    }
                    else
                    {
                        InternalType_131 InternalVar_11 = InternalField_2040.ElementAt(InternalVar_10).InternalField_586;
                        InternalType_133 InternalVar_12 = InternalField_2041[InternalVar_11];
                        InternalType_164<InternalType_133> InternalVar_13 = InternalField_2040.ElementAt(InternalVar_12).InternalField_587;

                        InternalVar_3 = InternalVar_13.InternalProperty_216;
                        for (int InternalVar_14 = 0; InternalVar_14 < InternalVar_3; ++InternalVar_14)
                        {
                            InternalVar_9.InternalMethod_1895(InternalVar_13[InternalVar_14], InternalParameter_2107: InternalVar_1);
                        }
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void InternalMethod_1876(out InternalType_464 InternalParameter_2071)
            {
                InternalParameter_2071 = default;
                InternalParameter_2071.InternalField_1931 = InternalField_2029;
                InternalParameter_2071.InternalField_1928 = InternalField_2028;
                InternalParameter_2071.InternalField_1926 = InternalField_2022;
                InternalParameter_2071.InternalField_1927 = InternalField_2023;
                InternalParameter_2071.InternalField_1930 = InternalField_2026;
                InternalParameter_2071.InternalField_1934 = InternalField_2038;
                InternalParameter_2071.InternalField_1929 = InternalField_2025;
                InternalParameter_2071.InternalField_1932 = InternalField_2030;

                InternalField_2032.Clear();

                InternalParameter_2071.InternalField_1933 = InternalField_2032;
                InternalParameter_2071.InternalField_1935 = InternalField_2040;
                InternalParameter_2071.InternalField_1940 = InternalField_2041;

                InternalParameter_2071.InternalField_1941 = InternalField_2046;
                InternalParameter_2071.InternalField_1939 = InternalField_2042;
                InternalParameter_2071.InternalField_1937 = InternalField_2044;
                InternalParameter_2071.InternalField_1938 = InternalField_2045;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1877(out InternalType_468 InternalParameter_2072)
            {
                InternalParameter_2072 = default;
                InternalParameter_2072.InternalField_2048 = InternalField_2019;
                InternalParameter_2072.InternalField_2049 = InternalField_2020;
                InternalParameter_2072.InternalField_2050 = InternalField_2022;
                InternalParameter_2072.InternalField_2051 = InternalField_2023;
                InternalParameter_2072.InternalField_2052 = InternalField_2024;
                InternalParameter_2072.InternalField_2053 = InternalField_2026;
                InternalParameter_2072.InternalField_2054 = InternalField_2025;
                InternalParameter_2072.InternalField_2055 = InternalField_2028;
                InternalParameter_2072.InternalField_2057 = InternalField_2034;
                InternalParameter_2072.InternalField_2058 = InternalField_2030;
                InternalParameter_2072.InternalField_2059 = InternalField_2031;
                InternalParameter_2072.InternalField_2056 = InternalField_2029;
                InternalParameter_2072.InternalField_2060 = InternalField_2040;
                InternalParameter_2072.InternalField_2061 = InternalField_2041;
                InternalParameter_2072.InternalField_2063 = InternalField_2037;
                InternalParameter_2072.InternalField_2064 = InternalField_2045;

                InternalParameter_2072.InternalField_2066 = InternalField_2039;
                InternalParameter_2072.InternalField_2065 = InternalField_2038;
                InternalParameter_2072.InternalField_2067 = InternalField_2027;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1878(out InternalType_469 InternalParameter_2073)
            {
                InternalParameter_2073 = default;
                InternalParameter_2073.InternalField_2068 = InternalField_2022;
                InternalParameter_2073.InternalField_2069 = InternalField_2023;
                InternalParameter_2073.InternalField_2070 = InternalField_2024;
                InternalParameter_2073.InternalField_2071 = InternalField_2026;
                InternalParameter_2073.InternalField_2072 = InternalField_2025;
                InternalParameter_2073.InternalField_2073 = InternalField_2028;
                InternalParameter_2073.InternalField_2075 = InternalField_2034;
                InternalParameter_2073.InternalField_2074 = InternalField_2029;
                InternalParameter_2073.InternalField_2076 = InternalField_2038;
                InternalParameter_2073.InternalField_2077 = InternalField_2037;
                InternalParameter_2073.InternalField_2078 = InternalField_2040;
                InternalParameter_2073.InternalField_2079 = InternalField_2041;
                InternalParameter_2073.InternalField_2081 = InternalField_2030;
                InternalParameter_2073.InternalField_2082 = InternalField_2031;
                InternalParameter_2073.InternalField_2083 = InternalField_2032;
                InternalParameter_2073.InternalField_2085 = InternalField_2045;
                InternalParameter_2073.InternalField_2084 = InternalField_2033;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1879(out InternalType_470 InternalParameter_2074)
            {
                InternalParameter_2074 = default;
                InternalParameter_2074.InternalField_2095 = InternalField_2024;
                InternalParameter_2074.InternalField_2098 = InternalField_2026;
                InternalParameter_2074.InternalField_2099 = InternalField_2025;
                InternalParameter_2074.InternalField_2097 = InternalField_2038;
                InternalParameter_2074.InternalField_2096 = InternalField_2039;
                InternalParameter_2074.InternalField_2100 = InternalField_2040;
                InternalParameter_2074.InternalField_2094 = InternalField_2036;
                InternalParameter_2074.InternalField_2093 = InternalField_2035;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1880(out InternalType_471 InternalParameter_2075)
            {
                InternalParameter_2075 = default;
                InternalParameter_2075.InternalField_2102 = InternalField_2024;
                InternalParameter_2075.InternalField_75 = InternalField_2023;
                InternalParameter_2075.InternalField_2103 = InternalField_2022;
                InternalParameter_2075.InternalField_2104 = InternalField_2026;
                InternalParameter_2075.InternalField_2105 = InternalField_2025;
                InternalParameter_2075.InternalField_2106 = InternalField_2038;
                InternalParameter_2075.InternalField_2107 = InternalField_2037;
                InternalParameter_2075.InternalField_2108 = InternalField_2040;
                InternalParameter_2075.InternalField_2109 = InternalField_2041;
                InternalParameter_2075.InternalField_2110 = InternalField_2046;
                InternalParameter_2075.InternalField_2111 = InternalField_2045;
                InternalParameter_2075.InternalField_2114 = InternalField_2039;
                InternalParameter_2075.InternalField_2112 = InternalField_2019;
                InternalParameter_2075.InternalField_2113 = InternalField_2020;
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void InternalType_472(void* jobData, void* elementID, int secondPass);

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_472))]
        public static unsafe void InternalMethod_1866(void* InternalParameter_2061, void* InternalParameter_2062, int InternalParameter_2063)
        {
            ref InternalType_467 InternalVar_1 = ref UnsafeUtility.AsRef<InternalType_467>(InternalParameter_2061);

            UnsafeUtility.CopyPtrToStructure(InternalParameter_2062, out InternalType_131 InternalVar_2);

            if (InternalParameter_2063 == 0)
            {
                InternalVar_1.InternalMethod_1876(out InternalType_464 InternalVar_3);
                InternalVar_3.InternalField_1925 = InternalVar_2;
                InternalVar_3.Execute();
            }

            InternalVar_1.InternalField_2021 = InternalVar_2;
            InternalVar_1.Execute();
            InternalVar_1.InternalField_2021 = InternalType_131.InternalField_415;
        }
    }
}
