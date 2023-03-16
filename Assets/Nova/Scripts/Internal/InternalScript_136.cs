using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_3;
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
#pragma warning disable CS0660, CS0661  
    internal struct InternalType_447
#pragma warning restore CS0660, CS0661  
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const int InternalField_1776 = 8;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const int InternalField_1777 = 4;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_151 InternalField_1778;
        public bool this[int InternalParameter_1966]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return InternalField_1778[InternalParameter_1966];
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                InternalField_1778[InternalParameter_1966] = value;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_351 => InternalField_1778.InternalMethod_710();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1732(int InternalParameter_1967, bool InternalParameter_1968, bool InternalParameter_1969)
        {
            byte InternalVar_1 = InternalMethod_1733(InternalParameter_1967);
            InternalVar_1 = (byte)math.select(~InternalVar_1, InternalVar_1, InternalParameter_1968);
            InternalField_1778 = (byte)math.select(InternalField_1778 & ~InternalVar_1, InternalField_1778 | InternalVar_1, InternalParameter_1969);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static byte InternalMethod_1733(int InternalParameter_1970)
        {
            int3 InternalVar_1 = math.select(InternalType_187.InternalField_516, InternalField_1779, InternalType_187.InternalField_498 == InternalParameter_1970);

            return (byte)(InternalVar_1.x | InternalVar_1.y | InternalVar_1.z);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static readonly int3 InternalField_1779 = new int3(InternalField_1780, InternalField_1781, InternalField_1782);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const byte InternalField_1780 = 0xF0; 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const byte InternalField_1781 = 0xCC; 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const byte InternalField_1782 = 0xAA; 

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static readonly int3 InternalField_1783 = new int3(InternalField_1784, InternalField_1785, InternalField_1786);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const byte InternalField_1784 = 0x04;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const byte InternalField_1785 = 0x02;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const byte InternalField_1786 = 0x01;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool InternalProperty_352
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return InternalField_1778.InternalProperty_218;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_447 InternalMethod_1735(InternalType_447 InternalParameter_1971)
        {
            return this & InternalParameter_1971;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1736(InternalType_447 InternalParameter_1972)
        {
            return (this.InternalField_1778 & InternalParameter_1972.InternalField_1778) != InternalType_151.InternalField_439;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_447 operator &(InternalType_447 InternalParameter_1973, InternalType_447 InternalParameter_1974)
        {
            return InternalParameter_1973.InternalField_1778 & InternalParameter_1974.InternalField_1778;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_447 InternalField_1787 = new InternalType_447() { InternalField_1778 = InternalType_151.InternalField_439 };
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_447 InternalField_1788 = new InternalType_447() { InternalField_1778 = InternalType_151.InternalField_440 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_151(InternalType_447 InternalParameter_1975)
        {
            return InternalParameter_1975.InternalField_1778;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_447(InternalType_151 InternalParameter_1976)
        {
            return new InternalType_447() { InternalField_1778 = InternalParameter_1976 };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_447(byte InternalParameter_1977)
        {
            return (InternalType_151)InternalParameter_1977;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_447 InternalParameter_1978, InternalType_447 InternalParameter_1979)
        {
            return InternalParameter_1978.InternalField_1778 == InternalParameter_1979.InternalField_1778;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_447 InternalParameter_1980, InternalType_447 InternalParameter_1981)
        {
            return InternalParameter_1980.InternalField_1778 != InternalParameter_1981.InternalField_1778;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly float3[] InternalField_1789 = new float3[] { new float3(-1, -1, -1),
                                                                 new float3(-1, -1, 1),
                                                                 new float3(-1, 1, -1),
                                                                 new float3(-1, 1, 1),
                                                                 new float3(1, -1, -1),
                                                                 new float3(1, -1, 1),
                                                                 new float3(1, 1, -1),
                                                                 new float3(1, 1, 1) };

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly float3x4 InternalField_1790 = new float3x4(new float3(-1, -1, -1),
                                                                   new float3(-1, -1, 1),
                                                                   new float3(-1, 1, 1),
                                                                   new float3(-1, 1, -1));

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly float3x4 InternalField_1791 = new float3x4(new float3(1, -1, -1),
                                                                    new float3(1, -1, 1),
                                                                    new float3(1, 1, 1),
                                                                    new float3(1, 1, -1));

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly float3x4 InternalField_1792 = new float3x4(new float3(-1, -1, 1),
                                                                   new float3(-1, 1, 1),
                                                                   new float3(1, 1, 1),
                                                                   new float3(1, -1, 1));

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly float3x4 InternalField_1793 = new float3x4(new float3(-1, -1, -1),
                                                                    new float3(-1, 1, -1),
                                                                    new float3(1, 1, -1),
                                                                    new float3(1, -1, -1));

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly float3x4 InternalField_1794 = new float3x4(new float3(-1, -1, -1),
                                                                     new float3(-1, -1, 1),
                                                                     new float3(1, -1, 1),
                                                                     new float3(1, -1, -1));

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly float3x4 InternalField_1795 = new float3x4(new float3(-1, 1, -1),
                                                                  new float3(-1, 1, 1),
                                                                  new float3(1, 1, 1),
                                                                  new float3(1, 1, -1));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InternalMethod_1743(int InternalParameter_1982, int InternalParameter_1983, float InternalParameter_1984)
        {
            if (InternalParameter_1983 == 0)
            {
                if (InternalParameter_1984 < 0)
                {
                    return InternalField_1790[InternalParameter_1982];
                }

                return InternalField_1791[InternalParameter_1982];
            }

            if (InternalParameter_1983 == 1)
            {
                if (InternalParameter_1984 < 0)
                {
                    return InternalField_1794[InternalParameter_1982];
                }

                return InternalField_1795[InternalParameter_1982];
            }

            if (InternalParameter_1984 < 0)
            {
                return InternalField_1793[InternalParameter_1982];
            }

            return InternalField_1792[InternalParameter_1982];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InternalMethod_1744(int InternalParameter_1985)
        {
            return math.select(InternalType_187.InternalField_529, InternalType_187.InternalField_531, (new int3(InternalParameter_1985) & InternalField_1783) != InternalType_187.InternalField_516);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int InternalMethod_1745(int3 InternalParameter_1986)
        {
            return InternalMethod_1746(InternalParameter_1986 > InternalType_187.InternalField_516);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int InternalMethod_1746(bool3 InternalParameter_1987)
        {
            int3 InternalVar_1 = math.select(InternalType_187.InternalField_516, InternalField_1783, InternalParameter_1987);

            return (byte)(InternalVar_1.x | InternalVar_1.y | InternalVar_1.z);
        }
    }

    internal partial class InternalType_460
    {
        [BurstCompile]
        internal struct InternalType_476 : InternalType_193
        {
            [WriteOnly]
            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_447> InternalField_2137;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2138;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2139;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_2140;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<quaternion> InternalField_2141;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float3> InternalField_3638;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2142;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_2143;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_2144;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Execute(int dirtyIndex)
            {
                InternalType_133 InternalVar_1 = InternalField_2144[dirtyIndex];
                InternalType_222 InternalVar_2 = InternalField_2142[InternalVar_1];

                if (!InternalField_2143.TryGetValue(InternalVar_2.InternalField_586, out InternalType_133 InternalVar_3))
                {
                    InternalField_2137[InternalVar_1] = InternalType_447.InternalField_1788;
                    return;
                }

                InternalType_447 InternalVar_4 = InternalType_447.InternalField_1787;

                float3 InternalVar_5 = InternalField_2139[InternalVar_3];
                bool InternalVar_6 = InternalField_2138[InternalVar_3].z == 0;

                float3 InternalVar_7 = InternalField_3638[InternalVar_1];
                float3 InternalVar_8 = InternalVar_7 * InternalField_2139[InternalVar_1] + InternalField_2140[InternalVar_1];
                float3 InternalVar_9 = InternalVar_7 * InternalField_2138[InternalVar_1] * InternalType_187.InternalField_526;

                int InternalVar_10 = InternalVar_6 ? 2 : 1;

                for (int InternalVar_11 = 0; InternalVar_11 < InternalType_447.InternalField_1776; InternalVar_11 += InternalVar_10)
                {
                    float3 InternalVar_12 = InternalVar_8 + (InternalVar_9 * InternalType_447.InternalField_1789[InternalVar_11]);

                    int InternalVar_13 = InternalType_447.InternalMethod_1746(InternalVar_12 > InternalVar_5);
                    InternalVar_4[InternalVar_13] = true;
                }

                InternalField_2137[InternalVar_1] = InternalVar_4;
            }
        }
    }
}
