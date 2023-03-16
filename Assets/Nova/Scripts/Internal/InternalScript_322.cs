using AOT;
using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_10;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_11
{
    [BurstCompile]
    internal struct InternalType_763
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, bool> InternalField_3603;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_133> InternalField_3604;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_222> InternalField_3605;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_133> InternalField_3606;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_55> InternalField_3607;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_3608;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_3609;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_774 InternalField_3700;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_133 InternalField_3613;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_3614;

        private unsafe void InternalMethod_3633()
        {
            InternalField_3614 = InternalType_131.InternalField_415;

            InternalField_3604.Clear();

            if (!InternalField_3613.InternalProperty_194)
            {
                return;
            }

            InternalField_3604.InternalMethod_1013(ref InternalField_3605.ElementAt(InternalField_3613).InternalField_587);

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_3604.Length; ++InternalVar_1)
            {
                InternalType_133 InternalVar_2 = InternalField_3604.ElementAt(InternalVar_1);
                ref InternalType_222 InternalVar_3 = ref InternalField_3605.ElementAt(InternalVar_2);

                if (InternalField_3603.ContainsKey(InternalVar_3.InternalField_585) && InternalMethod_3634(InternalVar_2))
                {
                    InternalField_3614 = InternalVar_3.InternalField_585;
                    break;
                }

                InternalField_3604.InternalMethod_1017(InternalVar_1 + 1, InternalVar_3.InternalField_587.InternalProperty_232, InternalVar_3.InternalProperty_253);
            }
        }

        private bool InternalMethod_3634(InternalType_133 InternalParameter_3420)
        {
            InternalType_643 InternalVar_1 = InternalField_3700.InternalField_3694[InternalParameter_3420];

            if (!InternalVar_1.InternalProperty_761)
            {
                return true;
            }

            InternalType_337 InternalVar_2 = InternalField_3700.InternalField_3696[InternalVar_1];

            for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_2.InternalField_3663; ++InternalVar_3)
            {
                InternalType_643 InternalVar_4 = InternalVar_2.InternalField_3665[InternalVar_3];

                if (!InternalField_3700.InternalField_3697[InternalVar_4].InternalField_349)
                {
                    continue;
                }

                InternalType_133 InternalVar_5 = InternalField_3606[InternalField_3700.InternalField_3695[InternalVar_4]];

                float4x4 InternalVar_6 = InternalField_3608[InternalVar_5];
                float4x4 InternalVar_7 = InternalField_3609[InternalParameter_3420];

                float3 InternalVar_8 = InternalType_448.InternalMethod_1751(InternalParameter_3420, ref InternalField_3607).InternalProperty_398.InternalProperty_124 * InternalType_187.InternalField_526;
                float2 InternalVar_9 = InternalType_448.InternalMethod_1751(InternalVar_5, ref InternalField_3607).InternalProperty_398.InternalProperty_124.xy * InternalType_187.InternalField_521;

                float2 InternalVar_10 = InternalType_187.InternalMethod_944(ref InternalVar_6, ref InternalVar_7, -InternalVar_8).xy;
                float2 InternalVar_11 = InternalType_187.InternalMethod_944(ref InternalVar_6, ref InternalVar_7, InternalVar_8).xy;

                if (!InternalType_443.InternalMethod_3693(InternalVar_10, InternalVar_9) || !InternalType_443.InternalMethod_3693(InternalVar_11, InternalVar_9))
                {
                    return false;
                }
            }

            return true;
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_3635(void* InternalParameter_3421)
        {
            UnsafeUtility.AsRef<InternalType_763>(InternalParameter_3421).InternalMethod_3633();
        }
    }

    [BurstCompile]
    internal struct InternalType_775
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, bool> InternalField_3701;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_299<InternalType_71>> InternalField_3702;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_222> InternalField_3703;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_133> InternalField_3704;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_3705;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_133 InternalField_3706;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_3707;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_3708;

        private void InternalMethod_3694()
        {
            InternalField_3708.Clear();

            if (!InternalField_3706.InternalProperty_194)
            {
                return;
            }

            InternalType_222 InternalVar_1 = InternalField_3703.ElementAt(InternalField_3706);

            if (InternalField_3707 == InternalVar_1.InternalField_585)
            {
                return;
            }

            while (InternalVar_1.InternalField_586.InternalProperty_192 && InternalVar_1.InternalField_586 != InternalField_3707)
            {
                InternalType_133 InternalVar_2 = InternalField_3704[InternalVar_1.InternalField_586];
                InternalVar_1 = InternalField_3703.ElementAt(InternalVar_2);

                if (InternalField_3701.TryGetValue(InternalVar_1.InternalField_585, out bool InternalVar_3))
                {
                    int InternalVar_4 = InternalField_3702[InternalVar_2].InternalField_983.InternalField_232;

                    if (((1 << InternalVar_4) & InternalField_3705) == 0)
                    {
                        continue;
                    }

                    InternalField_3708.Add(InternalVar_1.InternalField_585);
                }
            }
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_3695(void* InternalParameter_3502)
        {
            UnsafeUtility.AsRef<InternalType_775>(InternalParameter_3502).InternalMethod_3694();
        }
    }
}
