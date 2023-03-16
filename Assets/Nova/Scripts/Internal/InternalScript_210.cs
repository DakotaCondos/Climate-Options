using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_400 : InternalType_193
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1439;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_373>> InternalField_1440;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_284> InternalField_1441;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_133, InternalType_304> InternalField_1442;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_371 InternalField_1443;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_376 InternalField_1444;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_348, InternalType_259> InternalField_1445;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_372 InternalField_1446;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_162<InternalType_288, InternalType_373> InternalField_1447;

        public void Execute(int index)
        {
            if (!InternalType_395.InternalMethod_999(index, ref InternalField_1439, ref InternalField_1440, out InternalType_131 InternalVar_1, out int InternalVar_2))
            {
                return;
            }

            InternalType_284 InternalVar_3 = InternalField_1441[InternalVar_1];
            if (!InternalVar_3.InternalMethod_1282(InternalVar_2, out InternalType_284.InternalType_285 InternalVar_4) ||
                !InternalVar_3.InternalMethod_1283(out InternalType_288 InternalVar_5, ref InternalVar_4))
            {
                return;
            }

            InternalField_1447 = InternalField_1440[InternalVar_1];

            ref InternalType_373 InternalVar_6 = ref InternalField_1447.InternalMethod_758(InternalVar_5);
            if (InternalVar_6.InternalField_1298 || InternalVar_6.InternalField_1297 == InternalType_266.InternalField_790 || !InternalVar_6.InternalField_1297.InternalMethod_1605())
            {
                return;
            }

            if (InternalVar_6.InternalField_1297 == InternalType_266.InternalField_789)
            {
                ref InternalType_375 InternalVar_7 = ref InternalField_1444.InternalField_1304.InternalMethod_748(InternalField_1445[InternalVar_6.InternalField_1295]);
                InternalMethod_1620(ref InternalVar_6, ref InternalVar_3, InternalVar_4, ref InternalVar_7);
            }
            else
            {
                InternalMethod_1621(ref InternalVar_6, ref InternalVar_3, InternalVar_4);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1620(ref InternalType_373 InternalParameter_1755, ref InternalType_284 InternalParameter_1756, InternalType_284.InternalType_285 InternalParameter_1757, ref InternalType_375 InternalParameter_1758)
        {
            InternalType_304 InternalVar_1 = InternalField_1442[InternalParameter_1755.InternalField_1294];
            ref InternalType_164<InternalType_288> InternalVar_2 = ref InternalField_1446.InternalMethod_1583(ref InternalParameter_1755, ref InternalField_1443);
            InternalVar_2.InternalMethod_705();

            while (InternalParameter_1756.InternalMethod_1283(out InternalType_288 InternalVar_3, ref InternalParameter_1757))
            {
                ref InternalType_373 InternalVar_4 = ref InternalField_1447.InternalMethod_758(InternalVar_3);
                if (InternalVar_4.InternalField_1298 ||
                    !InternalVar_4.InternalField_1297.InternalMethod_1605() ||
                    InternalVar_1 != InternalField_1442[InternalVar_4.InternalField_1294])
                {
                    continue;
                }

                if (InternalVar_4.InternalField_1297 == InternalType_266.InternalField_789)
                {
                    ref InternalType_375 InternalVar_5 = ref InternalField_1444.InternalField_1304.InternalMethod_748(InternalField_1445[InternalVar_4.InternalField_1295]);
                    if (!InternalVar_5.InternalMethod_1586(ref InternalParameter_1758))
                    {
                        continue;
                    }

                    InternalVar_2.InternalMethod_785(InternalVar_3);
                }
                else
                {
                    ref InternalType_306 InternalVar_5 = ref InternalField_1444.InternalField_1303.InternalMethod_748(InternalVar_4.InternalField_1294).InternalField_1300;
                    if (!InternalParameter_1758.InternalMethod_1585(ref InternalVar_5))
                    {
                        continue;
                    }

                    InternalVar_2.InternalMethod_785(InternalVar_3);
                    if (InternalVar_5.InternalMethod_1375(ref InternalParameter_1758.InternalField_1301.InternalField_1300))
                    {
                        break;
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1621(ref InternalType_373 InternalParameter_1759, ref InternalType_284 InternalParameter_1760, InternalType_284.InternalType_285 InternalParameter_1761)
        {
            InternalType_304 InternalVar_1 = InternalField_1442[InternalParameter_1759.InternalField_1294];
            ref InternalType_306 InternalVar_2 = ref InternalField_1444.InternalField_1303.InternalMethod_748(InternalParameter_1759.InternalField_1294).InternalField_1300;
            ref InternalType_164<InternalType_288> InternalVar_3 = ref InternalField_1446.InternalMethod_1583(ref InternalParameter_1759, ref InternalField_1443);
            InternalVar_3.InternalMethod_705();

            while (InternalParameter_1760.InternalMethod_1283(out InternalType_288 InternalVar_4, ref InternalParameter_1761))
            {
                ref InternalType_373 InternalVar_5 = ref InternalField_1447.InternalMethod_758(InternalVar_4);
                if (InternalVar_5.InternalField_1298 ||
                    !InternalVar_5.InternalField_1297.InternalMethod_1605() ||
                    InternalVar_1 != InternalField_1442[InternalVar_5.InternalField_1294])
                {
                    continue;
                }

                if (InternalVar_5.InternalField_1297 == InternalType_266.InternalField_789)
                {
                    ref InternalType_375 InternalVar_6 = ref InternalField_1444.InternalField_1304.InternalMethod_748(InternalField_1445[InternalVar_5.InternalField_1295]);
                    if (!InternalVar_6.InternalMethod_1585(ref InternalVar_2))
                    {
                        continue;
                    }

                    InternalVar_3.InternalMethod_785(InternalVar_4);
                }
                else
                {
                    ref InternalType_306 InternalVar_6 = ref InternalField_1444.InternalField_1303.InternalMethod_748(InternalVar_5.InternalField_1294).InternalField_1300;
                    if (!InternalVar_6.InternalMethod_1374(ref InternalVar_2))
                    {
                        continue;
                    }

                    InternalVar_3.InternalMethod_785(InternalVar_4);
                    if (InternalVar_6.InternalMethod_1375(ref InternalVar_2))
                    {
                        break;
                    }
                }
            }
        }
    }
}
