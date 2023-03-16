using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_10;
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
    internal struct InternalType_438 : IComparer<InternalType_438>, InternalType_439
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_1684;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_1685;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_3582;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_498 InternalField_1687;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1688;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1689;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        InternalType_131 InternalType_439.InternalProperty_344 => InternalField_1684;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        float3 InternalType_439.InternalProperty_345 => InternalField_1688;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        float3 InternalType_439.InternalProperty_346 => InternalField_1689;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        float InternalType_439.InternalProperty_347 => InternalField_1685;

        public int Compare(InternalType_438 x, InternalType_438 y)
        {
            bool InternalVar_1 = InternalType_187.InternalMethod_922(x.InternalField_3582, y.InternalField_3582);

            if (x.InternalField_1687.InternalProperty_684 != y.InternalField_1687.InternalProperty_684 || (InternalVar_1 && InternalType_187.InternalMethod_922(x.InternalField_1685, y.InternalField_1685)))
            {
                return y.InternalField_1687.CompareTo(x.InternalField_1687);
            }
            else
            {
                return InternalVar_1 ? x.InternalField_1685.CompareTo(y.InternalField_1685) : x.InternalField_3582.CompareTo(y.InternalField_3582);
            }
        }
    }

    [BurstCompile]
    internal unsafe struct InternalType_440 : InternalType_437<InternalType_434, InternalType_438>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const float InternalField_3583 = 0.001f;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const int InternalField_3584 = 4;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Ray InternalField_1690;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_3585;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_774 InternalField_3692;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_270 InternalField_1692;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_55> InternalField_1693;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_133> InternalField_1694;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_222> InternalField_3587;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, bool> InternalField_3588;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, bool> InternalField_3589;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float3> InternalField_1695;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float3> InternalField_1696;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1697;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1698;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_3590;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, float> InternalField_3591;

        [NativeDisableUnsafePtrRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float4x4* InternalField_1699;
        [NativeDisableUnsafePtrRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float4x4* InternalField_1700;


        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_3592;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_1701;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_3593;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_3693;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_3594;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_3595;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_643 InternalField_3596;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float3 InternalField_1702;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_434 InternalField_1703;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_434 InternalMethod_1710()
        {
            InternalField_3591.Clear();

            InternalField_1703 = new InternalType_434(InternalField_1690);
            InternalField_1699 = (float4x4*)InternalField_1697.GetUnsafeReadOnlyPtr();
            InternalField_1700 = (float4x4*)InternalField_1698.GetUnsafeReadOnlyPtr();
            InternalField_1702 = InternalType_187.InternalField_530;

            InternalType_643 InternalVar_1 = !InternalField_3593 && InternalField_3594.InternalProperty_192 ?
                                              InternalField_3692.InternalField_3694[InternalField_1694[InternalField_3594]] :
                                              InternalType_643.InternalField_1148;
            
            InternalField_3596 = InternalType_643.InternalField_1148;

            if (InternalVar_1.InternalProperty_761)
            {
                InternalType_337 InternalVar_2 = InternalField_3692.InternalField_3696[InternalVar_1];

                for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_2.InternalField_3663; ++InternalVar_3)
                {
                    InternalType_643 InternalVar_4 = InternalVar_2.InternalField_3665[InternalVar_3];
                    if (InternalField_3692.InternalField_3697[InternalVar_4].InternalField_349)
                    {
                        InternalField_3596 = InternalVar_4;
                        break;
                    }
                }
            }

            InternalField_3693 = InternalField_1701.InternalProperty_192 && InternalField_1701 != InternalField_3594 && InternalField_3588.TryGetValue(InternalField_1701, out bool InternalVar_5) && InternalVar_5;

            return InternalField_1703;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_447 InternalMethod_1711(ref InternalType_434 ray, InternalType_133 InternalParameter_1937)
        {
            InternalType_131 InternalVar_1 = InternalField_3587[InternalParameter_1937].InternalField_585;

            if (InternalVar_1 == InternalField_1701 && InternalField_3693)
            {
                return InternalType_447.InternalField_1787;
            }

            if (InternalVar_1 != InternalField_3594 && InternalField_3588.TryGetValue(InternalField_3587[InternalParameter_1937].InternalField_585, out bool InternalVar_2) && !InternalVar_2)
            {
                return InternalType_447.InternalField_1787;
            }

            InternalType_447 InternalVar_3 = InternalType_447.InternalField_1787;

            float3 InternalVar_4 = InternalField_1695[InternalParameter_1937] * InternalType_187.InternalField_526;
            float3 InternalVar_5 = InternalVar_4 * InternalType_187.InternalField_526;

            float3 InternalVar_6 = InternalField_1696[InternalParameter_1937];

            int InternalVar_7 = InternalVar_4.z == 0 ? 2 : 1;

            InternalType_441 InternalVar_8 = new InternalType_441() { InternalField_1704 = InternalVar_5 };

            float3 InternalVar_9 = ray.InternalField_1676;

            for (int InternalVar_10 = 0; InternalVar_10 < InternalType_447.InternalField_1776; InternalVar_10 += InternalVar_7)
            {
                float3 InternalVar_11 = InternalType_447.InternalField_1789[InternalVar_10];
                InternalVar_8.InternalField_1705 = InternalVar_6 + InternalVar_5 * InternalVar_11;

                bool InternalVar_12 = InternalVar_8.InternalMethod_1721(InternalVar_9);
                bool InternalVar_13 = math.dot(InternalVar_8.InternalProperty_349 - InternalVar_9, ray.InternalField_1675) > 0;
                InternalVar_13 = InternalVar_13 ? true : math.dot(InternalVar_8.InternalProperty_348 - InternalVar_9, ray.InternalField_1675) > 0;

                InternalVar_3[InternalVar_10] = InternalVar_12 || InternalVar_13;
            }

            return InternalVar_3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1713(ref InternalType_434 ray, InternalType_133 InternalParameter_1943, InternalType_131 InternalParameter_1944, out InternalType_438 InternalParameter_1945)
        {
            InternalParameter_1945 = default;

            if (InternalParameter_1944 == InternalField_1701 || (InternalField_3595 && InternalParameter_1944 == InternalField_3594) || (InternalField_3592 && !InternalField_3589.ContainsKey(InternalParameter_1944)))
            {
                return false;
            }

            int InternalVar_1 = InternalField_1692.InternalField_847[InternalParameter_1943].InternalField_983.InternalField_232;

            if (((1 << InternalVar_1) & InternalField_3585) == 0)
            {
                return false;
            }

            if (!InternalMethod_3617(InternalParameter_1943, ref ray, out float InternalVar_2, out float3 InternalVar_3, out float3 InternalVar_4))
            {
                return false;
            }

            float InternalVar_5 = 0;

            if (InternalField_3590 && InternalField_3594.InternalProperty_192)
            {
                InternalMethod_3690(InternalParameter_1943, InternalField_3594, out InternalType_131 InternalVar_6);

                if (!InternalField_3591.TryGetValue(InternalVar_6, out InternalVar_5))
                {
                    InternalType_133 InternalVar_7 = InternalField_1694[InternalVar_6];
                    InternalMethod_1714(ref InternalField_1703, InternalVar_7, out InternalType_434 InternalVar_8);
                    InternalMethod_3617(InternalVar_7, ref InternalVar_8, out InternalVar_5, out _, out _);
                    InternalField_3591.Add(InternalVar_6, InternalVar_5);
                }

            }

            InternalParameter_1945.InternalField_1684 = InternalParameter_1944;
            InternalParameter_1945.InternalField_1687 = InternalField_1692.InternalMethod_1939(InternalParameter_1943);
            InternalParameter_1945.InternalField_1685 = InternalVar_2;
            InternalParameter_1945.InternalField_3582 = InternalVar_5;
            InternalParameter_1945.InternalField_1689 = InternalVar_4;
            InternalParameter_1945.InternalField_1688 = InternalVar_3;

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool InternalMethod_3690(InternalType_133 InternalParameter_3488, InternalType_131 InternalParameter_3489, out InternalType_131 InternalParameter_3490)
        {
            return InternalNamespace_0.InternalNamespace_9.InternalType_227.InternalType_228.InternalMethod_3602(ref InternalField_3587, ref InternalField_1694, InternalParameter_3488, InternalParameter_3489, out InternalParameter_3490);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool InternalMethod_3617(InternalType_133 InternalParameter_3391, ref InternalType_434 InternalParameter_3392, out float InternalParameter_3393, out float3 InternalParameter_3394, out float3 InternalParameter_3395)
        {
            InternalParameter_3393 = float.PositiveInfinity;
            InternalParameter_3394 = InternalType_187.InternalField_530;
            InternalParameter_3395 = InternalType_187.InternalField_530;

            InternalType_448.InternalType_453 InternalVar_1 = InternalType_448.InternalMethod_1751(InternalParameter_3391, ref InternalField_1693);
            float3 InternalVar_2 = InternalType_187.InternalMethod_3641(InternalVar_1.InternalProperty_398.InternalProperty_124, InternalField_3583);

            InternalType_441 InternalVar_3 = new InternalType_441(InternalVar_2);

            float3 InternalVar_4 = InternalVar_3.InternalMethod_1722(InternalParameter_3392.InternalField_1676);
            float3 InternalVar_5 = math.select(InternalVar_4 - InternalParameter_3392.InternalField_1676, -InternalParameter_3392.InternalField_1676, InternalVar_3.InternalField_1704 == InternalType_187.InternalMethod_874(InternalParameter_3392.InternalField_1676));

            if (math.dot(InternalParameter_3392.InternalField_1675, InternalVar_5) <= 0)
            {
                return false;
            }

            float InternalVar_6 = InternalMethod_3619(ref InternalVar_3, InternalVar_4, ref InternalParameter_3392);

            float3 InternalVar_7 = InternalParameter_3392.InternalMethod_1706(InternalVar_6);

            float4x4 InternalVar_8 = *(InternalField_1700 + InternalParameter_3391);
            InternalParameter_3394 = math.transform(InternalVar_8, InternalVar_4);
            float3 InternalVar_9 = math.transform(InternalVar_8, InternalVar_7);
            float3 InternalVar_10 = InternalType_441.InternalMethod_1725(ref InternalVar_3, ref InternalVar_4);
            InternalParameter_3395 = math.normalize(math.rotate(InternalVar_8, InternalVar_10));

            if (!InternalMethod_3691(InternalParameter_3391, InternalParameter_3394))
            {
                return false;
            }

            InternalParameter_3393 = math.lengthsq(InternalVar_9 - InternalField_1703.InternalField_1676);
            return true;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InternalMethod_3618(ref float3 InternalParameter_3396, ref InternalType_434 InternalParameter_3397)
        {
            float3 InternalVar_1 = InternalParameter_3396 - InternalParameter_3397.InternalField_1676;

            float InternalVar_2 = math.dot(InternalVar_1, InternalParameter_3397.InternalField_1675);

            return InternalType_187.InternalMethod_914(InternalVar_2) ? 0.5f * math.length(InternalVar_1) : 0.5f * math.lengthsq(InternalVar_1) / InternalVar_2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool InternalMethod_3691(InternalType_133 InternalParameter_3491, float3 InternalParameter_3492)
        {
            InternalType_643 InternalVar_1 = InternalField_3692.InternalField_3694[InternalParameter_3491];

            if (!InternalVar_1.InternalProperty_761)
            {
                return true;
            }

            return InternalType_443.InternalMethod_3692(InternalParameter_3491, InternalField_3596, ref InternalParameter_3492, ref InternalField_3692, ref InternalField_1694, ref InternalField_1693, InternalField_1699);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InternalMethod_3619(ref InternalType_441 InternalParameter_3398, float3 InternalParameter_3399, ref InternalType_434 InternalParameter_3400)
        {
            float InternalVar_1 = 0;
            float InternalVar_2 = InternalMethod_3618(ref InternalParameter_3399, ref InternalParameter_3400);

            for (int InternalVar_3 = 1; !InternalType_187.InternalMethod_914(InternalVar_1 - InternalVar_2) && InternalVar_3 < InternalField_3584; ++InternalVar_3)
            {
                InternalVar_1 = InternalVar_2;
                InternalParameter_3399 = InternalParameter_3398.InternalMethod_1722(InternalParameter_3400.InternalMethod_1706(InternalVar_1));
                InternalVar_2 = InternalMethod_3618(ref InternalParameter_3399, ref InternalParameter_3400);
            }

            return InternalVar_2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1712(ref InternalType_434 ray, InternalType_133 InternalParameter_1939, InternalType_131 InternalParameter_1940, out InternalType_434 rayInLocalSpace)
        {
            rayInLocalSpace = default;

            float3 InternalVar_1 = InternalType_187.InternalMethod_3641(math.transform(*(InternalField_1699 + InternalParameter_1939), ray.InternalField_1676), InternalField_3583);
            float3 InternalVar_2 = InternalType_187.InternalMethod_3641(math.normalize(math.rotate(*(InternalField_1699 + InternalParameter_1939), ray.InternalField_1675)), InternalField_3583);

            InternalType_441 InternalVar_3 = new InternalType_441(InternalField_1696[InternalParameter_1939], InternalField_1695[InternalParameter_1939]);

            float InternalVar_4 = math.dot(InternalVar_2, InternalVar_3.InternalProperty_348 - InternalVar_1);
            float InternalVar_5 = math.dot(InternalVar_2, InternalVar_3.InternalProperty_349 - InternalVar_1);
            bool InternalVar_6 = InternalVar_4 > 0 || InternalVar_5 > 0 || InternalVar_3.InternalMethod_1721(InternalVar_1);

            if (InternalVar_6)
            {
                rayInLocalSpace = new InternalType_434() { InternalField_1676 = InternalVar_1, InternalField_1675 = InternalVar_2 };
            }

            return InternalVar_6;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1714(ref InternalType_434 ray, InternalType_133 InternalParameter_1947, out InternalType_434 rayInLocalSpace)
        {
            float4x4 InternalVar_1 = *(InternalField_1699 + InternalParameter_1947);

            float3 InternalVar_2 = InternalType_187.InternalMethod_3641(math.transform(*(InternalField_1699 + InternalParameter_1947), ray.InternalField_1676), InternalField_3583);
            float3 InternalVar_3 = InternalType_187.InternalMethod_3641(math.normalize(math.rotate(*(InternalField_1699 + InternalParameter_1947), ray.InternalField_1675)), InternalField_3583);

            rayInLocalSpace = new InternalType_434() { InternalField_1676 = InternalVar_2, InternalField_1675 = InternalVar_3 };
        }
    }

    internal struct InternalType_441
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1704;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1705;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalProperty_348 => InternalField_1705 - InternalField_1704;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalProperty_349 => InternalField_1705 + InternalField_1704;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1721(float3 InternalParameter_1949, float InternalParameter_1950 = 0)
        {
            float3 InternalVar_1 = InternalParameter_1950;
            return math.all(InternalParameter_1949 + InternalVar_1 >= InternalProperty_348 & InternalParameter_1949 - InternalVar_1 <= InternalProperty_349);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 InternalMethod_1722(float3 InternalParameter_1951)
        {
            return InternalType_187.InternalMethod_886(InternalParameter_1951, InternalProperty_348, InternalProperty_349);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 InternalMethod_3621(float3 InternalParameter_3403)
        {
            float3 InternalVar_1 = InternalMethod_1722(InternalParameter_3403);
            float3 InternalVar_2 = InternalField_1705 + InternalType_187.InternalMethod_889(InternalVar_1) * InternalField_1704;

            float3 InternalVar_3 = InternalType_187.InternalMethod_874(InternalVar_2 - InternalVar_1);
            float InternalVar_4 = math.cmax(InternalVar_3);

            if (InternalVar_4 > 0)
            {
                InternalVar_1 = math.select(InternalVar_1, InternalVar_2, InternalVar_3 < InternalVar_4);
            }

            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1723(InternalType_441 InternalParameter_1952)
        {
            return math.all(InternalProperty_349 >= InternalParameter_1952.InternalProperty_348 & InternalProperty_348 <= InternalParameter_1952.InternalProperty_349);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_441(float3 InternalParameter_1953, float3 InternalParameter_1954)
        {
            InternalField_1705 = InternalParameter_1953;
            InternalField_1704 = InternalType_187.InternalField_526 * InternalParameter_1954;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_441(float3 InternalParameter_3404)
        {
            InternalField_1705 = InternalType_187.InternalField_530;
            InternalField_1704 = InternalType_187.InternalField_526 * InternalParameter_3404;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InternalMethod_1725(ref InternalType_441 InternalParameter_1955, ref float3 InternalParameter_1956)
        {
            if (InternalParameter_1955.InternalField_1704.z == 0)
            {
                return InternalType_187.InternalField_506;
            }

            float3 InternalVar_1 = InternalParameter_1956 - InternalParameter_1955.InternalField_1705;
            float3 InternalVar_2 = InternalType_187.InternalField_532 * InternalParameter_1955.InternalField_1704;
            return InternalMethod_1726(ref InternalVar_2, ref InternalVar_1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InternalMethod_1726(ref float3 InternalParameter_1957, ref float3 InternalParameter_1958)
        {
            if (InternalParameter_1957.z == 0)
            {
                return InternalType_187.InternalField_506;
            }

            float3 InternalVar_1 = InternalType_187.InternalMethod_889(InternalParameter_1958);
            float3 InternalVar_2 = InternalVar_1 * InternalType_187.InternalField_526 * InternalParameter_1957;
            float3 InternalVar_3 = math.normalize(InternalVar_1 * InternalType_187.InternalMethod_887(InternalType_187.InternalMethod_927(ref InternalParameter_1958, ref InternalVar_2)));

            return InternalVar_3;
        }
    }
}
