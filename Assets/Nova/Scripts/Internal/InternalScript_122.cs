using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_11
{
    internal struct InternalType_444 : IComparer<InternalType_444>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_1726;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_1727;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_1728;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1729;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1730;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1731;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_1732;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1733;

        public int Compare(InternalType_444 x, InternalType_444 y)
        {
            float InternalVar_1 = InternalType_187.InternalMethod_871(x.InternalField_1728);
            float InternalVar_2 = InternalType_187.InternalMethod_871(y.InternalField_1728);

            float InternalVar_3 = InternalType_187.InternalMethod_871(x.InternalField_1727);
            float InternalVar_4 = InternalType_187.InternalMethod_871(y.InternalField_1727);

            if (InternalType_187.InternalMethod_871(InternalVar_3 - InternalVar_4) < InternalType_187.InternalField_494)
            {
                if (InternalType_187.InternalMethod_871(InternalVar_1 - InternalVar_2) < InternalType_187.InternalField_494)
                {
                    return x.InternalField_1733.CompareTo(y.InternalField_1733);
                }

                return InternalVar_1.CompareTo(InternalVar_2);
            }

            return InternalVar_3.CompareTo(InternalVar_4);
        }

        public override string ToString()
        {
            return $"{InternalField_1732}, {InternalField_1733}, Hit: {InternalField_1727.ToString("F5")}, Edge: {InternalField_1728.ToString("F5")}";
        }
    }

    [BurstCompile]
    internal unsafe struct InternalType_445 : InternalType_437<InternalType_434, InternalType_444>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const float InternalField_1734 = 100;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_55> InternalField_1735;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float3> InternalField_1736;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float3> InternalField_1737;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1738;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1739;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_222> InternalField_1740;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_133> InternalField_1741;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_224> InternalField_1742;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<quaternion> InternalField_1743;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float3> InternalField_1744;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float3> InternalField_1745;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<bool> InternalField_1746;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, bool> InternalField_1747;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Ray InternalField_1748;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float4x4 InternalField_1749;

        [NativeDisableUnsafePtrRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float4x4* InternalField_1750;
        [NativeDisableUnsafePtrRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float4x4* InternalField_1751;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float3 InternalField_1752;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float3 InternalField_1753;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float4x4 InternalField_1754;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float4x4 InternalField_1755;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float3 InternalField_1756;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float3 InternalField_1757;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float3 InternalField_1758;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private quaternion InternalField_1759;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_1760;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_133 InternalField_1761;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float4x4 InternalField_1762;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_434 InternalField_1763;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_434 InternalMethod_1710()
        {
            InternalField_1763 = new InternalType_434(InternalField_1748);

            InternalField_1752 = InternalType_187.InternalField_530;
            InternalField_1753 = InternalType_187.InternalField_530;

            InternalField_1750 = (float4x4*)InternalField_1738.GetUnsafeReadOnlyPtr();
            InternalField_1751 = (float4x4*)InternalField_1739.GetUnsafeReadOnlyPtr();

            return InternalField_1763;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_447 InternalMethod_1711(ref InternalType_434 ray, InternalType_133 InternalParameter_1937)
        {
            return InternalType_447.InternalField_1788;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1713(ref InternalType_434 ray, InternalType_133 InternalParameter_1943, InternalType_131 InternalParameter_1944, out InternalType_444 InternalParameter_1945)
        {
            InternalParameter_1945 = default;

            if (InternalField_1747.ContainsKey(InternalParameter_1944))
            {
                return false;
            }

            InternalType_448.InternalType_453 InternalVar_1 = InternalType_448.InternalMethod_1751(InternalParameter_1943, ref InternalField_1735);

            float3 InternalVar_2 = 0.5f * InternalField_1757;
            float3 InternalVar_3 = InternalField_1754.c3.xyz;

            if (!InternalType_187.InternalMethod_903(ref InternalField_1749, InternalVar_3 - InternalVar_2, InternalVar_3 + InternalVar_2))
            {
                return false;
            }

            InternalParameter_1945.InternalField_1733 = InternalType_223.InternalField_588;

            float InternalVar_4 = float.MaxValue;
            float3 InternalVar_5 = InternalType_187.InternalField_530;
            float InternalVar_6 = float.MaxValue;
            bool InternalVar_7 = false;

            float4x4 InternalVar_8 = float4x4.identity;

            float3 InternalVar_9 = InternalVar_1.InternalProperty_398.InternalProperty_124;
            float3 InternalVar_10 = InternalField_1753;

            float3 InternalVar_11 = InternalVar_10;

            if (InternalType_187.InternalMethod_902(ref ray.InternalField_1677, ref ray.InternalField_1680, ref InternalVar_10, ref InternalVar_9, out float InternalVar_12))
            {
                InternalVar_7 = true;
                InternalVar_4 = InternalVar_12;

                InternalVar_5 = ray.InternalMethod_1706(InternalVar_4);

                InternalVar_6 = InternalMethod_1727(ref InternalField_1754, InternalVar_10, InternalVar_9, InternalVar_5);

                InternalParameter_1945.InternalField_1731 = InternalVar_9;
            }

            if (InternalType_187.InternalMethod_902(ref ray.InternalField_1677, ref ray.InternalField_1680, ref InternalVar_10, ref InternalField_1752, out float InternalVar_13))
            {
                InternalVar_7 = true;

                float InternalVar_14 = InternalVar_4;
                InternalVar_4 = InternalType_187.InternalMethod_869(InternalVar_13, InternalVar_4);

                if (InternalVar_14 != InternalVar_4)
                {
                    InternalVar_5 = ray.InternalMethod_1706(InternalVar_4);

                    InternalVar_6 = InternalMethod_1727(ref InternalField_1754, InternalVar_10, InternalField_1752, InternalVar_5);
                }
            }

            if (!InternalVar_1.InternalProperty_400.InternalProperty_137.Equals(InternalType_187.InternalField_530))
            {
                float3 InternalVar_14 = InternalVar_10 + InternalVar_1.InternalProperty_400.InternalProperty_139;
                float3 InternalVar_15 = InternalVar_9 - InternalVar_1.InternalProperty_400.InternalProperty_137;

                if (InternalType_187.InternalMethod_902(ref ray.InternalField_1677, ref ray.InternalField_1680, ref InternalVar_14, ref InternalVar_15, out float InternalVar_16))
                {
                    InternalVar_7 = true;

                    float InternalVar_17 = InternalVar_4;
                    InternalVar_4 = InternalType_187.InternalMethod_869(InternalVar_16, InternalVar_4);

                    if (InternalVar_17 != InternalVar_4)
                    {
                        InternalVar_5 = ray.InternalMethod_1706(InternalVar_4);

                        InternalVar_6 = InternalMethod_1727(ref InternalField_1754, InternalVar_10, InternalVar_9, InternalVar_5);

                        InternalVar_11 = InternalVar_14;
                        InternalParameter_1945.InternalField_1731 = InternalVar_15;
                    }
                }
            }

            bool InternalVar_18 = math.any(InternalField_1756 != InternalVar_9) && InternalField_1760;

            if (InternalVar_18)
            {
                InternalMethod_1728(ref InternalField_1763, ref UnsafeUtility.AsRef<float4x4>(InternalField_1750 + InternalField_1761), out ray);

                InternalVar_10 = InternalField_1744[InternalParameter_1943];

                float3 InternalVar_19 = InternalField_1756 * InternalField_1745[InternalParameter_1943];

                if (InternalType_187.InternalMethod_902(ref ray.InternalField_1677, ref ray.InternalField_1680, ref InternalVar_10, ref InternalVar_19, out float InternalVar_20))
                {
                    InternalVar_7 = true;

                    float InternalVar_21 = InternalVar_4;
                    InternalVar_4 = InternalType_187.InternalMethod_869(InternalVar_20, InternalVar_4);

                    if (InternalVar_21 != InternalVar_4)
                    {
                        InternalVar_5 = ray.InternalMethod_1706(InternalVar_4);

                        InternalVar_6 = InternalMethod_1727(ref InternalVar_8, InternalVar_10, InternalVar_19, InternalVar_5);

                        InternalParameter_1945.InternalField_1726 = true;
                        InternalVar_11 = InternalVar_10;
                        InternalParameter_1945.InternalField_1731 = InternalVar_19;
                    }
                }
            }

            if (!InternalVar_1.InternalProperty_401.InternalProperty_137.Equals(InternalType_187.InternalField_530))
            {
                float3 InternalVar_19 = InternalField_1756 * InternalField_1745[InternalParameter_1943] + InternalVar_1.InternalProperty_401.InternalProperty_137;
                float3 InternalVar_20 = InternalVar_10 - InternalVar_1.InternalProperty_401.InternalProperty_139;

                if (InternalType_187.InternalMethod_902(ref ray.InternalField_1677, ref ray.InternalField_1680, ref InternalVar_20, ref InternalVar_19, out float InternalVar_21))
                {
                    InternalVar_7 = true;

                    float InternalVar_22 = InternalVar_4;
                    InternalVar_4 = InternalType_187.InternalMethod_869(InternalVar_21, InternalVar_4);

                    if (InternalVar_22 != InternalVar_4)
                    {
                        InternalVar_5 = ray.InternalMethod_1706(InternalVar_4);

                        InternalVar_6 = InternalMethod_1727(ref InternalVar_8, InternalVar_20, InternalVar_19, InternalVar_5);

                        InternalParameter_1945.InternalField_1726 = InternalVar_18;
                        InternalVar_11 = InternalVar_20;
                        InternalParameter_1945.InternalField_1731 = InternalVar_19;
                    }
                }
            }

            if (InternalVar_7)
            {
                float3 InternalVar_19 = math.transform(InternalParameter_1945.InternalField_1726 ? InternalVar_8 : InternalField_1754, math.round(InternalVar_5 * InternalField_1734) / InternalField_1734);

                InternalParameter_1945.InternalField_1732 = InternalParameter_1944;

                InternalParameter_1945.InternalField_1727 = math.length(InternalVar_19 - InternalField_1763.InternalField_1676);
                InternalParameter_1945.InternalField_1729 = InternalVar_19;
                InternalParameter_1945.InternalField_1733 = InternalField_1742[InternalParameter_1943].InternalField_590;
                InternalParameter_1945.InternalField_1728 = InternalVar_6;
                InternalParameter_1945.InternalField_1730 = InternalVar_11;
            }

            return InternalVar_7;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private float InternalMethod_1727(ref float4x4 InternalParameter_1959, float3 InternalParameter_1960, float3 InternalParameter_1961, float3 InternalParameter_1962)
        {
            InternalType_441 InternalVar_1 = new InternalType_441(InternalParameter_1960, InternalParameter_1961);

            return math.length(math.transform(InternalParameter_1959, (float3)InternalVar_1.InternalMethod_1722(InternalParameter_1962)) - math.transform(InternalParameter_1959, InternalParameter_1962));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1712(ref InternalType_434 ray, InternalType_133 InternalParameter_1939, InternalType_131 InternalParameter_1940, out InternalType_434 rayInLocalSpace)
        {
            rayInLocalSpace = default;
            if (InternalField_1747.ContainsKey(InternalParameter_1940))
            {
                return false;
            }

            InternalType_448.InternalType_453 InternalVar_1 = InternalType_448.InternalMethod_1751(InternalParameter_1939, ref InternalField_1735);

            InternalField_1755 = *(InternalField_1750 + InternalParameter_1939);
            InternalField_1754 = *(InternalField_1751 + InternalParameter_1939);

            float3 InternalVar_2 = InternalField_1737[InternalParameter_1939] - InternalVar_1.InternalProperty_401.InternalProperty_139;
            float3 InternalVar_3 = InternalType_187.InternalMethod_898(ref InternalField_1754, InternalVar_2);

            float3 InternalVar_4 = InternalType_187.InternalMethod_894(ref InternalField_1754);

            InternalField_1760 = InternalField_1741.TryGetValue(InternalField_1740[InternalParameter_1939].InternalField_586, out InternalField_1761);

            float3 InternalVar_5 = InternalType_187.InternalField_531;

            if (InternalField_1760)
            {
                InternalField_1762 = *(InternalField_1751 + InternalField_1761);
                InternalVar_5 = InternalType_187.InternalMethod_894(ref InternalField_1762);
            }

            InternalField_1756 = InternalVar_1.InternalMethod_1831(ref InternalField_1743, ref InternalField_1746);
            InternalField_1757 = (InternalVar_4 * InternalField_1756) + (InternalVar_5 * InternalVar_1.InternalProperty_401.InternalProperty_137);

            float3 InternalVar_6 = math.max(InternalField_1736[InternalParameter_1939] * InternalVar_4, InternalField_1757);
            float3 InternalVar_7 = InternalType_187.InternalField_526 * InternalVar_6;

            if (InternalType_187.InternalMethod_903(ref InternalField_1749, InternalVar_3 - InternalVar_7, InternalVar_3 + InternalVar_7))
            {
                InternalMethod_1728(ref ray, ref InternalField_1755, out rayInLocalSpace);

                return InternalType_187.InternalMethod_902(ref rayInLocalSpace.InternalField_1677, ref rayInLocalSpace.InternalField_1680, ref InternalField_1753, ref InternalVar_6, out _);
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1728(ref InternalType_434 InternalParameter_1963, ref float4x4 InternalParameter_1964, out InternalType_434 InternalParameter_1965)
        {
            float3 InternalVar_1 = math.transform(InternalParameter_1964, InternalParameter_1963.InternalField_1676);
            float3 InternalVar_2 = math.normalize(math.rotate(InternalParameter_1964, InternalParameter_1963.InternalField_1675));

            InternalVar_2 = math.normalize(math.select(InternalType_187.InternalField_530, InternalVar_2, InternalVar_2 == InternalType_187.InternalMethod_865(InternalVar_2)));

            float3 InternalVar_3 = InternalType_187.InternalField_531;
            InternalVar_2 = math.select(InternalVar_2, InternalType_187.InternalField_530, InternalType_187.InternalMethod_3643(ref InternalVar_2));
            InternalVar_2 = math.select(InternalVar_2, math.sign(InternalVar_2) * InternalVar_3, InternalType_187.InternalMethod_927(ref InternalVar_2, ref InternalVar_3));

            InternalParameter_1965 = new InternalType_434(InternalVar_1, InternalVar_2);
        }

        public void InternalMethod_1714(ref InternalType_434 ray, InternalType_133 InternalParameter_1947, out InternalType_434 rayInLocalSpace)
        {
            InternalType_448.InternalType_453 InternalVar_1 = InternalType_448.InternalMethod_1751(InternalParameter_1947, ref InternalField_1735);

            InternalField_1755 = *(InternalField_1750 + InternalParameter_1947);
            InternalField_1754 = *(InternalField_1751 + InternalParameter_1947);

            float3 InternalVar_2 = InternalType_187.InternalMethod_894(ref InternalField_1754);

            InternalField_1760 = InternalField_1741.TryGetValue(InternalField_1740[InternalParameter_1947].InternalField_586, out InternalField_1761);

            float3 InternalVar_3 = InternalType_187.InternalField_531;

            if (InternalField_1760)
            {
                InternalField_1762 = *(InternalField_1751 + InternalField_1761);
                InternalVar_3 = InternalType_187.InternalMethod_894(ref InternalField_1762);
            }

            InternalField_1756 = InternalVar_1.InternalMethod_1831(ref InternalField_1743, ref InternalField_1746);
            InternalField_1757 = (InternalVar_2 * InternalField_1756) + (InternalVar_3 * InternalVar_1.InternalProperty_401.InternalProperty_137);

            InternalMethod_1728(ref ray, ref InternalField_1755, out rayInLocalSpace);
        }
    }
}
