using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
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
    internal struct InternalType_401 : InternalType_193
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1448;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_299<InternalType_71>> InternalField_1449;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1450;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_55> InternalField_1451;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_80> InternalField_1452;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_373>> InternalField_1453;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_359 InternalField_1454;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_380> InternalField_1455;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_418> InternalField_1456;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_379 InternalField_1457;

        public void Execute(int index)
        {
            if (!InternalField_1448.InternalMethod_1004(ref InternalField_1455, ref index, out InternalField_1457, out InternalType_131 InternalVar_1))
            {
                return;
            }

            InternalType_288 InternalVar_2 = InternalField_1457.InternalField_1314[index];
            ref InternalType_373 InternalVar_3 = ref InternalField_1453[InternalVar_1].InternalMethod_758(InternalVar_2);
            InternalField_1456.InternalMethod_748(InternalVar_3.InternalField_1295).InternalMethod_705();
            ref InternalType_299<InternalType_71> InternalVar_4 = ref InternalField_1449.ElementAt(InternalVar_3.InternalField_1294);

            InternalType_364 InternalVar_5 = InternalMethod_1622(InternalVar_2, ref InternalVar_3, ref InternalVar_4);
            InternalField_1457.InternalField_1315.InternalField_1308.InternalMethod_800(index) = InternalVar_5;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private InternalType_364 InternalMethod_1622(InternalType_288 InternalParameter_1762, ref InternalType_373 InternalParameter_1763, ref InternalType_299<InternalType_71> InternalParameter_1764)
        {
            InternalType_448.InternalType_453 InternalVar_1 = InternalType_448.InternalMethod_1751(InternalParameter_1763.InternalField_1294, ref InternalField_1451);
            float2 InternalVar_2 = InternalVar_1.InternalProperty_398.InternalProperty_124.xy;

            ref InternalType_80 InternalVar_3 = ref InternalField_1452.InternalMethod_748(InternalParameter_1763.InternalField_1295);
            bool InternalVar_6 = InternalField_1454.InternalMethod_1556(InternalVar_3.InternalField_271.InternalField_276, out InternalType_311 InternalVar_4, out InternalType_321 InternalVar_5);
            if (InternalVar_6)
            {
                InternalVar_3.InternalMethod_1489(ref InternalVar_2, InternalVar_4.InternalProperty_308);
            }

            float2 InternalVar_7 = InternalType_187.InternalField_521 * InternalVar_2;
            float InternalVar_8 = math.cmin(InternalVar_7);

            ref float4x4 InternalVar_9 = ref InternalField_1450.ElementAt(InternalParameter_1763.InternalField_1294);

            float InternalVar_10 = InternalVar_3.InternalMethod_1479(InternalVar_8);
            float InternalVar_11 = InternalType_187.InternalMethod_933(ref InternalVar_9) * InternalType_187.InternalMethod_933(ref InternalField_1457.InternalField_1312);

            InternalType_364 InternalVar_12 = new InternalType_364()
            {
                InternalField_1266 = InternalParameter_1763.InternalField_1295,
                InternalField_1265 = InternalVar_11 * InternalVar_10,
                InternalField_1267 = InternalParameter_1762,
                InternalField_1269 = InternalParameter_1764.InternalField_983.InternalField_233,
            };

            if (InternalVar_3.InternalField_273)
            {
                InternalVar_12.InternalField_1270 |= InternalType_363.InternalField_1261;

                if (InternalMethod_1919(ref InternalVar_3, InternalVar_6, ref InternalVar_5))
                {
                    InternalVar_12.InternalField_1270 |= InternalType_363.InternalField_1260;
                }
            }


            float3 InternalVar_13 = InternalType_187.InternalMethod_944(ref InternalField_1457.InternalField_1312, ref InternalVar_9, new float3(-InternalVar_7, 0f));
            float3 InternalVar_14 = InternalType_187.InternalMethod_944(ref InternalField_1457.InternalField_1312, ref InternalVar_9, new float3(InternalVar_7, 0f));

            InternalVar_12.InternalField_1264 = new InternalType_366(InternalVar_13.xy, InternalVar_14.xy);

            if (!InternalVar_3.InternalField_269.InternalField_335)
            {
                return InternalVar_12;
            }

            InternalVar_12.InternalField_1270 |= InternalType_363.InternalField_1262;

            if (InternalVar_3.InternalField_269.InternalField_333.InternalMethod_973() && !InternalVar_3.InternalField_3412.InternalProperty_1066)
            {
                InternalVar_12.InternalField_1270 |= InternalType_363.InternalField_1263;
            }

            float InternalVar_15 = InternalVar_3.InternalField_269.InternalMethod_1482(InternalVar_8);
            InternalVar_3.InternalField_269.InternalMethod_1490(InternalVar_10, InternalVar_15, ref InternalVar_2, out float InternalVar_16, out float InternalVar_17);

            InternalVar_12.InternalField_1268.InternalField_1273 = InternalVar_15 * InternalVar_11;
            InternalVar_12.InternalField_1268.InternalField_1272 = InternalVar_17 * InternalVar_11;

            float2 InternalVar_18 = InternalType_187.InternalField_521 * InternalVar_2;

            float3 InternalVar_19 = InternalType_187.InternalMethod_944(ref InternalField_1457.InternalField_1312, ref InternalVar_9, new float3(-InternalVar_18, 0f));
            float3 InternalVar_20 = InternalType_187.InternalMethod_944(ref InternalField_1457.InternalField_1312, ref InternalVar_9, new float3(InternalVar_18, 0f));
            InternalVar_12.InternalField_1268.InternalField_1271 = new InternalType_366(InternalVar_19.xy, InternalVar_20.xy);

            return InternalVar_12;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool InternalMethod_1919(ref InternalType_80 InternalParameter_455, bool InternalParameter_454, ref InternalType_321 InternalParameter_453)
        {
            if (!InternalParameter_455.InternalField_266.InternalMethod_973())
            {
                return false;
            }

            if (InternalParameter_455.InternalField_3412.InternalProperty_1066)
            {
                return false;
            }

            if (InternalParameter_455.InternalField_268.InternalField_347 && !InternalParameter_455.InternalField_268.InternalField_343.InternalMethod_973())
            {
                return false;
            }

            if (InternalParameter_454 && InternalParameter_453.InternalField_1081)
            {
                return false;
            }

            return true;
        }
    }
}

