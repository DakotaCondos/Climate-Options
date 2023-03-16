#define inline


using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine.Jobs;

namespace Nova.InternalNamespace_0.InternalNamespace_12
{
    
    internal partial class InternalType_479 : InternalType_126<InternalType_479>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_480 InternalField_2148;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_131> InternalField_2149;

        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_460.InternalType_467 InternalField_2150;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_460.InternalType_472> InternalField_2151;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_460.InternalType_474 InternalField_2152;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_460.InternalType_475 InternalField_2153;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_460.InternalType_471 InternalField_2154;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_460.InternalType_470 InternalField_2155;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_460.InternalType_473 InternalField_2156;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_460.InternalType_476 InternalField_2157;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_482.InternalType_483 InternalField_2158;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_482.InternalType_485 InternalField_2159;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_482.InternalType_484 InternalField_2160;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_410 => InternalType_457.InternalProperty_190.InternalProperty_405 || InternalType_253.InternalProperty_190.InternalProperty_193;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private JobHandle InternalField_2161;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private JobHandle InternalField_2162;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private JobHandle InternalField_2163;

        public override void Dispose()
        {
            InternalField_2148.Dispose();
            InternalField_2149.Dispose();
        }

        public override void InternalMethod_603()
        {
            InternalField_406 = this;

            unsafe
            {
                InternalField_2164 = new InternalType_735<InternalType_175>(InternalType_480.InternalType_481.InternalMethod_1917);
                InternalField_2151 = new InternalType_735<InternalType_460.InternalType_472>(InternalType_460.InternalMethod_1866);
            }

            InternalField_2148.InternalMethod_702();
            InternalField_2149 = new NativeList<InternalType_131>(4, Allocator.Persistent);

            #region 
            InternalField_2154 = new InternalType_460.InternalType_471()
            {
                InternalField_2102 = InternalType_457.InternalProperty_190.InternalField_1843,
                InternalField_2103 = InternalType_457.InternalProperty_190.InternalField_1841,
                InternalField_75 = InternalType_457.InternalProperty_190.InternalField_1842,
                InternalField_2112 = NovaApplication.IsEditor,
                InternalField_2113 = InternalType_457.InternalProperty_190.InternalProperty_409.InternalField_1895,
                InternalField_2105 = InternalType_457.InternalProperty_190.InternalField_1845,
                InternalField_2104 = InternalType_457.InternalProperty_190.InternalField_1844,

                InternalField_2114 = InternalType_457.InternalProperty_190.InternalField_1856,
                InternalField_2106 = InternalType_457.InternalProperty_190.InternalField_1857,
                InternalField_2107 = InternalType_457.InternalProperty_190.InternalField_432,

                InternalField_2108 = InternalType_253.InternalProperty_190.InternalProperty_263,
                InternalField_2109 = InternalType_253.InternalProperty_190.InternalProperty_264,

                InternalField_2111 = InternalType_457.InternalProperty_190.InternalProperty_404,

                InternalField_2110 = InternalField_2148.InternalField_2165,
            };

            InternalField_2155 = new InternalType_460.InternalType_470()
            {
                InternalField_2095 = InternalType_457.InternalProperty_190.InternalField_1843,
                InternalField_2098 = InternalType_457.InternalProperty_190.InternalField_1844,
                InternalField_2096 = InternalType_457.InternalProperty_190.InternalField_1856,
                InternalField_2097 = InternalType_457.InternalProperty_190.InternalField_1857,
                InternalField_2099 = InternalType_457.InternalProperty_190.InternalField_1845,

                InternalField_2093 = InternalType_457.InternalProperty_190.InternalField_1852,
                InternalField_2094 = InternalType_457.InternalProperty_190.InternalField_1853,

                InternalField_2100 = InternalType_253.InternalProperty_190.InternalProperty_263,

                InternalField_2101 = InternalField_2148.InternalField_2165,
            };

            InternalField_2156 = new InternalType_460.InternalType_473()
            {
                InternalField_2119 = InternalType_457.InternalProperty_190.InternalField_1843,
                InternalField_2118 = InternalType_457.InternalProperty_190.InternalField_1856,
                InternalField_2117 = InternalType_457.InternalProperty_190.InternalField_1857,
                InternalField_3637 = InternalType_457.InternalProperty_190.InternalField_1858,

                InternalField_2115 = InternalType_457.InternalProperty_190.InternalField_1854,
                InternalField_2116 = InternalType_457.InternalProperty_190.InternalField_1855,

                InternalField_2120 = InternalType_253.InternalProperty_190.InternalProperty_263,
                InternalField_2121 = InternalField_2148.InternalField_2165,
            };

            InternalField_2150 = new InternalType_460.InternalType_467()
            {
                InternalField_2019 = NovaApplication.IsEditor,
                InternalField_2020 = InternalType_457.InternalProperty_190.InternalProperty_409.InternalField_1895,
                InternalField_2022 = InternalType_457.InternalProperty_190.InternalField_1841,
                InternalField_2023 = InternalType_457.InternalProperty_190.InternalField_1842,
                InternalField_2024 = InternalType_457.InternalProperty_190.InternalField_1843,

                InternalField_2028 = InternalType_457.InternalProperty_190.InternalField_1846,
                InternalField_2025 = InternalType_457.InternalProperty_190.InternalField_1845,
                InternalField_2026 = InternalType_457.InternalProperty_190.InternalField_1844,
                InternalField_2029 = InternalType_457.InternalProperty_190.InternalField_1860,

                InternalField_2030 = InternalType_457.InternalProperty_190.InternalField_1847,
                InternalField_2031 = InternalType_457.InternalProperty_190.InternalField_1848,
                InternalField_2032 = InternalType_457.InternalProperty_190.InternalField_1849,

                InternalField_2037 = InternalType_457.InternalProperty_190.InternalField_432,
                InternalField_2038 = InternalType_457.InternalProperty_190.InternalField_1857,
                InternalField_2039 = InternalType_457.InternalProperty_190.InternalField_1856,
                InternalField_2027 = InternalType_457.InternalProperty_190.InternalField_1859,

                InternalField_2040 = InternalType_253.InternalProperty_190.InternalProperty_263,
                InternalField_2041 = InternalType_253.InternalProperty_190.InternalProperty_264,

                InternalField_2042 = InternalType_457.InternalProperty_190.InternalField_1881,
                InternalField_2044 = InternalType_457.InternalProperty_190.InternalField_1882,
                InternalField_2045 = InternalType_457.InternalProperty_190.InternalProperty_404,

                InternalField_2046 = InternalField_2148.InternalField_2165,

                InternalField_2033 = InternalType_457.InternalProperty_190.InternalField_1850,
                InternalField_2034 = InternalType_457.InternalProperty_190.InternalField_1851,
                InternalField_2047 = InternalType_457.InternalProperty_190.InternalField_1884,

                InternalField_2035 = InternalType_457.InternalProperty_190.InternalField_1852,
                InternalField_2036 = InternalType_457.InternalProperty_190.InternalField_1853,
            };

            InternalField_2158 = new InternalType_482.InternalType_483()
            {
                InternalField_2180 = InternalType_457.InternalProperty_190.InternalField_1857,
                InternalField_2181 = InternalType_457.InternalProperty_190.InternalField_1856,
                InternalField_2182 = InternalType_457.InternalProperty_190.InternalField_1858,
                InternalField_2183 = InternalType_457.InternalProperty_190.InternalField_430,
                InternalField_2184 = InternalType_457.InternalProperty_190.InternalField_431,

                InternalField_2177 = InternalType_457.InternalProperty_190.InternalField_1844,
                InternalField_2185 = InternalType_457.InternalProperty_190.InternalProperty_404,
                InternalField_2186 = InternalType_457.InternalProperty_190.InternalField_1859,
                InternalField_383 = InternalType_457.InternalProperty_190.InternalField_1862.InternalMethod_805(),

                InternalField_2187 = InternalType_457.InternalProperty_190.InternalField_1841,
                InternalField_2188 = InternalType_457.InternalProperty_190.InternalField_1842,
                InternalField_2189 = InternalType_457.InternalProperty_190.InternalField_1843,
                InternalField_2190 = InternalType_457.InternalProperty_190.InternalField_1845,

                InternalField_2175 = InternalType_253.InternalProperty_190.InternalProperty_263,
                InternalField_2176 = InternalType_253.InternalProperty_190.InternalProperty_264,

                InternalField_2178 = InternalType_457.InternalProperty_190.InternalField_434,
                InternalField_2179 = InternalType_457.InternalProperty_190.InternalField_432,
                InternalField_2191 = InternalType_457.InternalProperty_190.InternalField_1876,

                InternalField_2192 = InternalType_457.InternalProperty_190.InternalField_1894,
            };

            InternalField_2160 = new InternalType_482.InternalType_484()
            {
                InternalField_2193 = InternalType_457.InternalProperty_190.InternalField_1856,
                InternalField_2195 = InternalType_253.InternalProperty_190.InternalProperty_263,
                InternalField_2196 = InternalType_253.InternalProperty_190.InternalProperty_264,

                InternalField_2198 = InternalType_457.InternalProperty_190.InternalField_432,
                InternalField_2197 = InternalType_457.InternalProperty_190.InternalField_434,
                InternalField_2199 = InternalType_457.InternalProperty_190.InternalProperty_404,

                InternalField_2194 = InternalType_457.InternalProperty_190.InternalField_431,
            };

            InternalField_2152 = new InternalType_460.InternalType_474()
            {
                InternalField_2122 = InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_594,
                InternalField_2125 = InternalType_253.InternalProperty_190.InternalProperty_263,
                InternalField_2126 = InternalType_253.InternalProperty_190.InternalProperty_264,

                InternalField_2123 = InternalType_457.InternalProperty_190.InternalField_1883,

                InternalField_2124 = InternalType_254.InternalField_406.InternalField_743,
            };

            InternalField_2153 = new InternalType_460.InternalType_475()
            {
                InternalField_2128 = InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_596,
                InternalField_2134 = InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_594,
                InternalField_2135 = InternalType_254.InternalField_406.InternalField_743,

                InternalField_2131 = InternalType_253.InternalProperty_190.InternalProperty_263,
                InternalField_2132 = InternalType_253.InternalProperty_190.InternalProperty_264,
            };

            InternalField_2157 = new InternalType_460.InternalType_476()
            {
                InternalField_2137 = InternalType_457.InternalProperty_190.InternalField_1861,

                InternalField_2138 = InternalType_457.InternalProperty_190.InternalField_1854,
                InternalField_2139 = InternalType_457.InternalProperty_190.InternalField_1855,
                InternalField_2140 = InternalType_457.InternalProperty_190.InternalField_1856,
                InternalField_2141 = InternalType_457.InternalProperty_190.InternalField_1857,
                InternalField_3638 = InternalType_457.InternalProperty_190.InternalField_1858,
                InternalField_2144 = InternalField_2148.InternalField_2165,

                InternalField_2142 = InternalType_253.InternalProperty_190.InternalProperty_263,
                InternalField_2143 = InternalType_253.InternalProperty_190.InternalProperty_264,
            };

            InternalField_2159 = new InternalType_482.InternalType_485()
            {
                InternalField_2206 = InternalType_457.InternalProperty_190.InternalField_1856,
                InternalField_2204 = InternalType_457.InternalProperty_190.InternalField_1857,
                InternalField_2205 = InternalType_457.InternalProperty_190.InternalField_1858,

                InternalField_2200 = InternalType_253.InternalProperty_190.InternalProperty_263,
                InternalField_2201 = InternalType_253.InternalProperty_190.InternalProperty_264,
                InternalField_3640 = InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_594,
                
                InternalField_2202 = InternalType_457.InternalProperty_190.InternalField_432,
                InternalField_2207 = InternalType_457.InternalProperty_190.InternalField_430,
                InternalField_2208 = InternalType_457.InternalProperty_190.InternalField_431,

                InternalField_2209 = InternalType_457.InternalProperty_190.InternalProperty_404,
            };

            #endregion
        }

        public void InternalMethod_1904(InternalType_131 InternalParameter_2125, bool InternalParameter_2126)
        {
            unsafe
            {
                InternalField_2151.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_2150), UnsafeUtility.AddressOf(ref InternalParameter_2125), InternalParameter_2126 ? 1 : 0);
            }
        }

        public override void InternalMethod_605(ref InternalType_128 engineUpdateInfo)
        {
            if (!InternalProperty_410)
            {
                return;
            }

            JobHandle InternalVar_1 = InternalMethod_1910(ref InternalField_2148, ref engineUpdateInfo, engineUpdateInfo.InternalField_410);
            JobHandle InternalVar_2 = InternalMethod_1911(ref InternalField_2148, InternalVar_1);

            engineUpdateInfo.InternalField_410 = InternalMethod_1907(InternalVar_2);
        }

        public override void InternalMethod_606(ref InternalType_128 engineUpdateInfo)
        {
            if (InternalProperty_410)
            {
                InternalMethod_1905(ref engineUpdateInfo);
            }
            else if (InternalType_457.InternalProperty_190.InternalProperty_193)
            {
                InternalMethod_1906(ref engineUpdateInfo);
            }
        }

        
        private void InternalMethod_1905(ref InternalType_128 InternalParameter_2127)
        {
            JobHandle InternalVar_1 = InternalParameter_2127.InternalField_410;

            if (InternalType_457.InternalProperty_190.InternalProperty_407)
            {
                InternalVar_1 = InternalMethod_1907(InternalVar_1);
            }

            InternalVar_1 = InternalMethod_1908(ref InternalField_2148.InternalField_2165, InternalVar_1);

            JobHandle InternalVar_2 = InternalField_2156.InternalMethod_1982(InternalVar_1);

            InternalField_2162 = InternalMethod_1913(ref InternalField_2148, InternalVar_2);

            InternalField_2163 = InternalField_2155.InternalMethod_1984(InternalField_2148.InternalField_2165.Length, InternalField_407, InternalVar_1);

            InternalField_2161 = InternalMethod_1914(InternalVar_1);

            InternalParameter_2127.InternalField_410 = InternalMethod_1050(ref InternalField_2148, InternalField_2161);
        }

        
        private void InternalMethod_1906(ref InternalType_128 InternalParameter_2128)
        {
            InternalField_2148.InternalField_3629.Clear();
            InternalField_2148.InternalField_3629.AddRange(InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_596.InternalField_465.AsArray());
            JobHandle InternalVar_1 = InternalMethod_1911(ref InternalField_2148, InternalParameter_2128.InternalField_410);

            InternalField_2161 = InternalMethod_1914(InternalVar_1);

            InternalParameter_2128.InternalField_410 = InternalMethod_1050(ref InternalField_2148);
        }

        public override JobHandle InternalMethod_604(JobHandle InternalParameter_495)
        {
            InternalType_457.InternalProperty_190.InternalMethod_1845();

            if (NovaApplication.IsEditor)
            {   
                InternalType_457.InternalProperty_190.InternalProperty_206.InternalMethod_683();
                InternalType_457.InternalProperty_190.InternalProperty_409.InternalMethod_1862();
            }

            InternalParameter_495 = InternalMethod_1909(InternalParameter_495);
            InternalParameter_495 = InternalType_457.InternalProperty_190.InternalMethod_1841(InternalParameter_495);
            InternalField_2148.InternalMethod_1916();
            return InternalParameter_495;
        }

        public override void InternalMethod_607()
        {
            InternalField_2161.Complete();
            InternalField_2162.Complete();
            InternalField_2163.Complete();
        }

        public override void InternalMethod_608()
        {
            if (NovaApplication.IsEditor)
            {
                InternalType_457.InternalProperty_190.InternalProperty_206.InternalMethod_684();
            }

            InternalType_457.InternalProperty_190.InternalMethod_635();
        }

        #region 
        private JobHandle InternalMethod_1907(JobHandle InternalParameter_2129)
        {
            JobHandle InternalVar_1 = InternalParameter_2129;

            InternalVar_1 = InternalField_2150.InternalMethod_1982(InternalVar_1);

            return InternalVar_1;
        }

        private JobHandle InternalMethod_1908(ref NativeList<InternalType_133> InternalParameter_2130, JobHandle InternalParameter_2131)
        {
            JobHandle InternalVar_1 = InternalMethod_1912(ref InternalParameter_2130, InternalParameter_2131);

            return InternalVar_1;
        }

        private JobHandle InternalMethod_1909(JobHandle InternalParameter_2132)
        {
            return InternalField_2158.ScheduleReadOnly(InternalType_457.InternalProperty_190.InternalField_433, InternalField_407, InternalParameter_2132);
        }

        private JobHandle InternalMethod_1910(ref InternalType_480 InternalParameter_2133, ref InternalType_128 InternalParameter_2134, JobHandle InternalParameter_2135)
        {
            JobHandle InternalVar_1 = InternalParameter_2135;

            int InternalVar_2 = InternalType_457.InternalProperty_190.InternalField_1883.Length;

            if (InternalVar_2 > 0)
            {
                InternalField_2152.InternalField_2127 = InternalParameter_2133.InternalField_2167;
                InternalVar_1 = InternalField_2152.InternalMethod_1984(InternalVar_2, InternalField_407, InternalVar_1);
            }

            InternalField_2153.InternalField_2129 = InternalParameter_2134.InternalField_408;
            InternalField_2153.InternalField_2133 = InternalType_254.InternalField_406.InternalField_743;
            InternalField_2153.InternalField_2130 = InternalParameter_2133.InternalField_2167;
            InternalField_2153.InternalField_2136 = InternalParameter_2133.InternalField_3629;

            InternalVar_1 = InternalField_2153.InternalMethod_1982(InternalVar_1);

            return InternalVar_1;
        }

        private JobHandle InternalMethod_1911(ref InternalType_480 InternalParameter_2136, JobHandle InternalParameter_2137)
        {
            return InternalType_253.InternalProperty_190.InternalMethod_1159(ref InternalParameter_2136.InternalField_3629, ref InternalParameter_2136.InternalField_2165, InternalParameter_2137);
        }

        private JobHandle InternalMethod_1912(ref NativeList<InternalType_133> InternalParameter_2138, JobHandle InternalParameter_2139)
        {
            InternalField_2154.InternalField_2110 = InternalParameter_2138;

            return InternalField_2154.InternalMethod_1984(InternalParameter_2138.Length, InternalField_407, InternalParameter_2139);
        }

        private JobHandle InternalMethod_1913(ref InternalType_480 InternalParameter_2140, JobHandle InternalParameter_2141)
        {
            return InternalField_2157.InternalMethod_1984(InternalParameter_2140.InternalField_2165.Length, InternalField_407, InternalParameter_2141);
        }

        private JobHandle InternalMethod_1914(JobHandle InternalParameter_2142)
        {
            return InternalField_2160.Schedule(InternalType_457.InternalProperty_190.InternalField_433, InternalParameter_2142);
        }

        private JobHandle InternalMethod_1050(ref InternalType_480 InternalParameter_1670, JobHandle InternalParameter_1669 = default)
        {
            InternalField_2159.InternalField_2203 = InternalParameter_1670.InternalField_2165;
            InternalField_2159.InternalField_3632 = InternalParameter_1670.InternalField_3639;
            InternalField_2159.InternalField_3633 = InternalParameter_1670.InternalField_3628;

            return InternalField_2159.InternalMethod_1982(InternalParameter_1669);
        }
        #endregion
    }
}