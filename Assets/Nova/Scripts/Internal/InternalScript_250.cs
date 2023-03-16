using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_426 : InternalType_193
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_133, int> InternalField_1625;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_220> InternalField_1626;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_299<InternalType_71>> InternalField_1627;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_79> InternalField_1628;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_54> InternalField_1629;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_99> InternalField_1630;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53> InternalField_1631;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1632;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_55> InternalField_1633;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_80> InternalField_1634;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_348, InternalType_259> InternalField_1635;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_359 InternalField_1636;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_376 InternalField_3624;

        public void Execute(int index)
        {
            InternalType_133 InternalVar_1 = index;

            if (!InternalField_1625.ContainsKey(InternalVar_1) &&
                InternalField_1626[InternalVar_1] == InternalType_220.InternalField_3625)
            {
                return;
            }

            ref InternalType_299<InternalType_71> InternalVar_2 = ref InternalField_1627.ElementAt(InternalVar_1);
            switch (InternalVar_2.InternalField_983.InternalField_234)
            {
                case InternalType_72.InternalField_238:
                    InternalMethod_1681(InternalVar_1, ref InternalVar_2);
                    break;
                case InternalType_72.InternalField_237:
                    InternalMethod_1683(InternalVar_1, ref InternalVar_2);
                    break;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1681(InternalType_133 InternalParameter_1871, ref InternalType_299<InternalType_71> InternalParameter_1872)
        {
            ref InternalType_79 InternalVar_1 = ref InternalField_1628.InternalMethod_748(InternalParameter_1872.InternalField_984);
            InternalType_448.InternalType_449 InternalVar_2 = InternalType_448.InternalMethod_1747(InternalParameter_1871, ref InternalField_1631);
            InternalVar_2.InternalMethod_1807(ref InternalField_1629);
            InternalVar_2.InternalMethod_1796(ref InternalField_1630);

            float2 InternalVar_3 = InternalVar_1.InternalMethod_2606(InternalVar_2.InternalProperty_354.InternalProperty_177.xy);
            InternalType_306 InternalVar_4 = InternalType_306.InternalMethod_1381(ref InternalVar_3, ref InternalVar_1.InternalField_262);
            ref float4x4 InternalVar_5 = ref InternalField_1632.ElementAt(InternalParameter_1871);
            float4x4 InternalVar_6 = math.mul(InternalVar_5, InternalVar_4.InternalMethod_1368());
            InternalField_3624.InternalField_1303.InternalMethod_748(InternalParameter_1871).InternalField_1299 = InternalVar_6;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1683(InternalType_133 InternalParameter_1875, ref InternalType_299<InternalType_71> InternalParameter_1876)
        {
            float2 InternalVar_1 = InternalMethod_1684(InternalParameter_1875).xy;
            ref InternalType_80 InternalVar_2 = ref InternalField_1634.InternalMethod_748(InternalParameter_1876.InternalField_984);
            if (InternalField_1636.InternalMethod_1555(InternalVar_2.InternalField_271.InternalField_276, out InternalType_311 InternalVar_3))
            {
                InternalVar_2.InternalMethod_1489(ref InternalVar_1, InternalVar_3.InternalProperty_308);
            }

            float2 InternalVar_4 = InternalType_187.InternalField_521 * InternalVar_1;

            float InternalVar_5 = math.cmin(InternalVar_4.xy);
            float InternalVar_6 = InternalVar_2.InternalMethod_1479(InternalVar_5);

            if (InternalVar_2.InternalField_269.InternalField_335)
            {
                float InternalVar_7 = InternalVar_2.InternalField_269.InternalMethod_1482(InternalVar_5);
                InternalVar_2.InternalField_269.InternalMethod_1491(ref InternalVar_6, ref InternalVar_1, InternalVar_7);
                InternalVar_4 = InternalType_187.InternalField_521 * InternalVar_1;
            }

            InternalType_306 InternalVar_8 = new InternalType_306(-InternalVar_4, InternalVar_4);
            ref float4x4 InternalVar_9 = ref InternalField_1632.ElementAt(InternalParameter_1875);
            float4x4 InternalVar_10 = math.mul(InternalVar_9, InternalVar_8.InternalMethod_1368());
            InternalField_3624.InternalField_1303.InternalMethod_748(InternalParameter_1875).InternalField_1299 = InternalVar_10;

            if (!InternalVar_2.InternalField_270.InternalProperty_186)
            {
                return;
            }

            InternalType_375 InternalVar_11 = new InternalType_375();
            float2 InternalVar_12 = InternalVar_2.InternalField_270.InternalMethod_1486(ref InternalVar_1);

            float2 InternalVar_13 = InternalVar_4.xy - InternalType_187.InternalField_497 * InternalVar_6;
            InternalType_306 InternalVar_14 = new InternalType_306(-InternalVar_13, InternalVar_13);
            InternalVar_14 = InternalType_306.InternalMethod_1381(ref InternalVar_12, ref InternalVar_14);
            InternalVar_11.InternalField_1302.InternalField_1299 = math.mul(InternalVar_9, InternalVar_14.InternalMethod_1368());

            float InternalVar_15 = math.csum(InternalVar_2.InternalField_270.InternalMethod_1483(InternalVar_5));
            float2 InternalVar_16 = InternalVar_4.xy + InternalVar_15;
            InternalType_306 InternalVar_17 = new InternalType_306(-InternalVar_16, InternalVar_16);
            InternalVar_17 = InternalType_306.InternalMethod_1381(ref InternalVar_12, ref InternalVar_17);
            InternalVar_11.InternalField_1301.InternalField_1299 = math.mul(InternalVar_9, InternalVar_17.InternalMethod_1368());

            InternalField_3624.InternalField_1304.InternalMethod_748(InternalField_1635[InternalParameter_1876.InternalField_984]) = InternalVar_11;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private float3 InternalMethod_1684(InternalType_133 InternalParameter_1877)
        {
            InternalType_448.InternalType_453 InternalVar_1 = InternalType_448.InternalMethod_1751(InternalParameter_1877, ref InternalField_1633);
            return InternalVar_1.InternalProperty_398.InternalProperty_124;
        }
    }
}

