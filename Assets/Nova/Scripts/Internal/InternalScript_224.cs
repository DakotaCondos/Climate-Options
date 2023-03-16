using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_405 : InternalType_192
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_133> InternalField_1500;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_133> InternalField_1501;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1502;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1503;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1504;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_133> InternalField_1505;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_224> InternalField_1506;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_222> InternalField_1507;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1508;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_304> InternalField_1509;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_358> InternalField_1510;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_304, InternalType_356>> InternalField_1511;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_380> InternalField_1512;

        public void Execute()
        {
            InternalField_1509.Clear();
            InternalField_1510.Clear();

            InternalMethod_1639();
            InternalMethod_1638();
            InternalMethod_1637();
        }

        private void InternalMethod_1637()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1501.Length; ++InternalVar_1)
            {
                InternalType_133 InternalVar_2 = InternalField_1501[InternalVar_1];
                InternalType_131 InternalVar_3 = InternalField_1507.ElementAt(InternalVar_2).InternalField_585;

                if (InternalField_1510.ContainsKey(InternalVar_3))
                {
                    continue;
                }

                ref InternalType_224 InternalVar_4 = ref InternalField_1506.ElementAt(InternalVar_2);
                InternalType_380 InternalVar_5 = InternalField_1512[InternalVar_4.InternalField_589];

                ref float4x4 InternalVar_6 = ref InternalField_1503.ElementAt(InternalVar_2);

                bool InternalVar_7 = false;
                for (int InternalVar_8 = 0; InternalVar_8 < InternalVar_5.InternalProperty_334; ++InternalVar_8)
                {
                    ref InternalType_379 InternalVar_9 = ref InternalVar_5.InternalField_1316.InternalMethod_758(InternalVar_8);

                    if (!InternalType_187.InternalMethod_945(ref InternalVar_6, ref InternalVar_9.InternalField_1311))
                    {
                        continue;
                    }

                    quaternion InternalVar_10 = new quaternion(InternalVar_9.InternalField_1311);
                    quaternion InternalVar_11 = new quaternion(InternalVar_6);
                    quaternion InternalVar_12 = math.mul(InternalVar_11, InternalVar_10);

                    if (!InternalType_187.InternalMethod_949(ref InternalVar_12))
                    {
                        continue;
                    }

                    InternalField_1510[InternalVar_3] = InternalVar_8;
                    InternalVar_7 = true;
                    break;
                }

                if (InternalVar_7)
                {
                    continue;
                }

                InternalMethod_1640(ref InternalVar_5, ref InternalVar_6, ref InternalField_1504.ElementAt(InternalVar_2), InternalVar_3, InternalVar_4.InternalField_589);
            }
        }

        private void InternalMethod_1638()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1500.Length; ++InternalVar_1)
            {
                InternalType_133 InternalVar_2 = InternalField_1500[InternalVar_1];
                InternalType_131 InternalVar_3 = InternalField_1507.ElementAt(InternalVar_2).InternalField_585;

                if (InternalField_1509.ContainsKey(InternalVar_3))
                {
                    continue;
                }

                ref InternalType_224 InternalVar_4 = ref InternalField_1506.ElementAt(InternalVar_2);
                InternalType_162<InternalType_304, InternalType_356> InternalVar_5 = InternalField_1511[InternalVar_4.InternalField_589];

                ref float4x4 InternalVar_6 = ref InternalField_1503.ElementAt(InternalVar_2);

                bool InternalVar_7 = false;
                for (int InternalVar_8 = 0; InternalVar_8 < InternalVar_5.InternalProperty_216; ++InternalVar_8)
                {
                    ref InternalType_356 InternalVar_9 = ref InternalVar_5.InternalMethod_758(InternalVar_8);
                    InternalType_133 InternalVar_10 = InternalField_1505[InternalVar_9.InternalField_577];
                    ref float4x4 InternalVar_11 = ref InternalField_1504.ElementAt(InternalVar_10);
                    if (!InternalType_187.InternalMethod_945(ref InternalVar_6, ref InternalVar_11))
                    {
                        continue;
                    }

                    InternalField_1509[InternalVar_3] = InternalVar_8;
                    InternalVar_7 = true;
                    break;
                }

                if (InternalVar_7)
                {
                    continue;
                }

                InternalMethod_1547(ref InternalVar_5, InternalVar_3, InternalVar_4.InternalField_589);
            }
        }

        private void InternalMethod_1639()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1502.Length; ++InternalVar_1)
            {
                InternalType_131 InternalVar_2 = InternalField_1502[InternalVar_1];

                if (!InternalField_1508.AsArray().Contains(InternalVar_2))
                {
                    continue;
                }

                InternalType_133 InternalVar_3 = InternalField_1505[InternalVar_2];

                ref float4x4 InternalVar_4 = ref InternalField_1503.ElementAt(InternalVar_3);
                ref float4x4 InternalVar_5 = ref InternalField_1504.ElementAt(InternalVar_3);

                InternalType_162<InternalType_304, InternalType_356> InternalVar_6 = InternalField_1511.InternalMethod_1557(InternalVar_2);
                InternalMethod_1547(ref InternalVar_6, InternalVar_2, InternalVar_2);

                InternalType_380 InternalVar_7 = InternalField_1512.InternalMethod_1557(InternalVar_2);
                InternalMethod_1640(ref InternalVar_7, ref InternalVar_4, ref InternalVar_5, InternalVar_2, InternalVar_2);
            }
        }

        private void InternalMethod_1640(ref InternalType_380 InternalParameter_1801, ref float4x4 InternalParameter_1802, ref float4x4 InternalParameter_1803, InternalType_131 InternalParameter_1804, InternalType_131 InternalParameter_1805)
        {
            InternalField_1510.Add(InternalParameter_1804, InternalParameter_1801.InternalProperty_334);
            InternalParameter_1801.InternalMethod_1599(ref InternalParameter_1802, ref InternalParameter_1803);
            InternalField_1512[InternalParameter_1805] = InternalParameter_1801;
        }

        private void InternalMethod_1547(ref InternalType_162<InternalType_304, InternalType_356> InternalParameter_1808, InternalType_131 InternalParameter_1807, InternalType_131 InternalParameter_1806)
        {
            InternalField_1509.Add(InternalParameter_1807, InternalParameter_1808.InternalProperty_216);
            InternalParameter_1808.InternalMethod_761(new InternalType_356(InternalParameter_1807));
            InternalField_1511[InternalParameter_1806] = InternalParameter_1808;
        }
    }
}

