using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_10;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_11
{
    internal struct InternalType_432
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1663;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_1664;
    }

    [BurstCompile]
    internal unsafe struct InternalType_446 : InternalType_437<InternalType_432, InternalType_442>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_432 InternalField_1764;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1879;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_774 InternalField_3699;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_270 InternalField_1766;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_55> InternalField_1767;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_133> InternalField_1768;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float3> InternalField_1769;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float3> InternalField_1770;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1771;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1772;

        [NativeDisableUnsafePtrRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float4x4* InternalField_1773;
        [NativeDisableUnsafePtrRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float4x4* InternalField_1774;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float3 InternalField_1775;

        public InternalType_432 InternalMethod_1710()
        {
            InternalField_1773 = (float4x4*)InternalField_1771.GetUnsafeReadOnlyPtr();
            InternalField_1774 = (float4x4*)InternalField_1772.GetUnsafeReadOnlyPtr();
            InternalField_1775 = InternalType_187.InternalField_530;

            return InternalField_1764;
        }

        public InternalType_447 InternalMethod_1711(ref InternalType_432 colliderLocalSpace, InternalType_133 InternalParameter_1937)
        {
            InternalType_447 InternalVar_1 = InternalType_447.InternalField_1787;

            float3 InternalVar_2 = InternalField_1769[InternalParameter_1937] * 0.5f;
            float3 InternalVar_3 = InternalVar_2 * 0.5f;
            float3 InternalVar_4 = InternalField_1770[InternalParameter_1937];

            int InternalVar_5 = InternalVar_2.z == 0 ? 2 : 1;

            for (int InternalVar_6 = 0; InternalVar_6 < InternalType_447.InternalField_1776; InternalVar_6 += InternalVar_5)
            {
                float3 InternalVar_7 = InternalType_447.InternalField_1789[InternalVar_6];
                InternalType_441 InternalVar_8 = new InternalType_441(InternalVar_4 + (InternalVar_3 * InternalVar_7), InternalVar_2);
                InternalVar_1[InternalVar_6] = InternalVar_8.InternalMethod_1721(colliderLocalSpace.InternalField_1663, colliderLocalSpace.InternalField_1664);
            }

            return InternalVar_1;
        }

        public bool InternalMethod_1713(ref InternalType_432 colliderLocalSpace, InternalType_133 InternalParameter_1943, InternalType_131 InternalParameter_1944, out InternalType_442 InternalParameter_1945)
        {
            InternalParameter_1945 = default;

            int InternalVar_1 = InternalField_1766.InternalField_847[InternalParameter_1943].InternalField_983.InternalField_232;

            if (((1 << InternalVar_1) & InternalField_1879) == 0)
            {
                return false;
            }

            InternalType_441 InternalVar_2 = new InternalType_441(InternalType_448.InternalMethod_1751(InternalParameter_1943, ref InternalField_1767).InternalProperty_398.InternalProperty_124);

            bool InternalVar_3 = InternalVar_2.InternalMethod_1721(colliderLocalSpace.InternalField_1663, colliderLocalSpace.InternalField_1664);
            bool InternalVar_4 = InternalVar_3;

            float InternalVar_5 = float.MaxValue;
            float3 InternalVar_6 = InternalType_187.InternalField_535;
            float3 InternalVar_7 = InternalType_187.InternalField_535;

            if (InternalVar_3)
            {
                float4x4 InternalVar_8 = *(InternalField_1774 + InternalParameter_1943);
                float3 InternalVar_9 = InternalVar_2.InternalMethod_1722(colliderLocalSpace.InternalField_1663);
                float3 InternalVar_10 = InternalType_441.InternalMethod_1725(ref InternalVar_2, ref InternalVar_9);
                InternalVar_6 = math.transform(InternalVar_8, InternalVar_9);
                InternalVar_7 = math.normalize(math.rotate(InternalVar_8, InternalVar_10));
                InternalVar_5 = math.length(InternalField_1764.InternalField_1663 - InternalVar_6);

                InternalVar_4 = InternalType_443.InternalMethod_3692(InternalParameter_1943, InternalType_643.InternalField_1148, ref InternalVar_6, ref InternalField_3699, ref InternalField_1768, ref InternalField_1767, InternalField_1773);
            }

            if (InternalVar_4)
            {
                InternalParameter_1945.InternalField_1706 = InternalParameter_1944;
                InternalParameter_1945.InternalField_1686 = InternalField_1766.InternalMethod_1939(InternalParameter_1943);
                InternalParameter_1945.InternalField_1708 = InternalVar_6;
                InternalParameter_1945.InternalField_1709 = InternalVar_7;
                InternalParameter_1945.InternalField_1707 = InternalVar_5;
            }

            return InternalVar_4;
        }

        public bool InternalMethod_1712(ref InternalType_432 colliderWorldSpace, InternalType_133 InternalParameter_1939, InternalType_131 InternalParameter_1940, out InternalType_432 colliderLocalSpace)
        {
            InternalType_441 InternalVar_1 = new InternalType_441(InternalField_1770[InternalParameter_1939], InternalField_1769[InternalParameter_1939]);

            float3 InternalVar_2 = math.transform(*(InternalField_1773 + InternalParameter_1939), colliderWorldSpace.InternalField_1663);
            float InternalVar_3 = colliderWorldSpace.InternalField_1664 * math.cmin(InternalType_187.InternalMethod_894(ref UnsafeUtility.AsRef<float4x4>(InternalField_1773 + InternalParameter_1939)));

            if (InternalVar_1.InternalMethod_1721(InternalVar_2, InternalVar_3))
            {
                colliderLocalSpace = new InternalType_432() { InternalField_1663 = InternalVar_2, InternalField_1664 = InternalVar_3 };
                return true;
            }

            colliderLocalSpace = default;
            return false;
        }

        public void InternalMethod_1714(ref InternalType_432 colliderWorldSpace, InternalType_133 InternalParameter_1947, out InternalType_432 colliderLocalSpace)
        {
            float3 InternalVar_1 = math.transform(*(InternalField_1773 + InternalParameter_1947), colliderWorldSpace.InternalField_1663);
            float InternalVar_2 = colliderWorldSpace.InternalField_1664 * math.cmin(InternalType_187.InternalMethod_894(ref UnsafeUtility.AsRef<float4x4>(InternalField_1773 + InternalParameter_1947)));

            colliderLocalSpace = new InternalType_432() { InternalField_1663 = InternalVar_1, InternalField_1664 = InternalVar_2 };
        }
    }
}
