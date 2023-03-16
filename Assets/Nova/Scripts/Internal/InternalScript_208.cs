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
    internal struct InternalType_402 : InternalType_193
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1458;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_380> InternalField_1459;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_373>> InternalField_1460;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_133, InternalType_643> InternalField_1461;

        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_418> InternalField_1462;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_378 InternalField_1463;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_162<InternalType_288, InternalType_373> InternalField_1464;

        public void Execute(int index)
        {
            if (!InternalMethod_1626(index, out InternalType_358 InternalVar_1, out InternalType_380 InternalVar_2, out InternalType_131 InternalVar_3))
            {
                return;
            }

            InternalField_1464 = InternalField_1460[InternalVar_3];

            ref InternalType_379 InternalVar_4 = ref InternalVar_2.InternalField_1316.InternalMethod_758(InternalVar_1);
            InternalField_1463 = InternalVar_4.InternalField_1315;
            InternalField_1463.InternalField_1308.InternalMethod_778();

            for (int InternalVar_5 = 0; InternalVar_5 < InternalField_1463.InternalField_1308.InternalProperty_216; ++InternalVar_5)
            {
                ref InternalType_364 InternalVar_6 = ref InternalField_1463.InternalField_1308.InternalMethod_800(InternalVar_5);
                InternalField_1462.InternalMethod_748(InternalVar_6.InternalField_1266).InternalField_1587 = InternalVar_5;
                InternalMethod_1624(ref InternalVar_6, InternalVar_5);
                InternalField_1463.InternalField_1309.InternalMethod_785(new InternalType_172<InternalType_364, int>(InternalVar_6, InternalVar_5));
            }

            InternalField_1463.InternalField_1309.InternalMethod_705();

            InternalVar_4.InternalField_1315 = InternalField_1463;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1624(ref InternalType_364 InternalParameter_1768, int InternalParameter_1769)
        {
            InternalType_643 InternalVar_1 = InternalField_1461[InternalField_1464[InternalParameter_1768.InternalField_1267].InternalField_1294];

            for (int InternalVar_2 = 0; InternalVar_2 < InternalField_1463.InternalField_1309.InternalProperty_216; ++InternalVar_2)
            {
                ref InternalType_172<InternalType_364, int> InternalVar_3 = ref InternalField_1463.InternalField_1309.InternalMethod_800(InternalVar_2);

                if (InternalVar_3.InternalField_462.InternalField_1264.InternalProperty_330 <= InternalParameter_1768.InternalField_1264.InternalProperty_329)
                {
                    InternalField_1463.InternalField_1309.InternalMethod_786(InternalVar_2--);
                    continue;
                }

                if (InternalField_1461[InternalField_1464[InternalVar_3.InternalField_462.InternalField_1267].InternalField_1294] != InternalVar_1)
                {
                    continue;
                }

                if (InternalParameter_1768.InternalMethod_1568(ref InternalVar_3.InternalField_462))
                {
                    InternalMethod_1625(ref InternalParameter_1768, ref InternalVar_3.InternalField_462, InternalVar_3.InternalField_463);
                }
                else
                {
                    InternalMethod_1625(ref InternalVar_3.InternalField_462, ref InternalParameter_1768, InternalParameter_1769);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1625(ref InternalType_364 InternalParameter_1770, ref InternalType_364 InternalParameter_1771, int InternalParameter_1772)
        {
            if (!InternalParameter_1771.InternalProperty_325 || !InternalParameter_1770.InternalProperty_322.InternalMethod_1575(ref InternalParameter_1771.InternalProperty_323))
            {
                return;
            }

            InternalField_1462.InternalMethod_748(InternalParameter_1770.InternalField_1266).InternalField_1585.InternalMethod_785(InternalParameter_1772);
        }

        private bool InternalMethod_1626(int InternalParameter_1773, out InternalType_358 InternalParameter_1774, out InternalType_380 InternalParameter_1775, out InternalType_131 InternalParameter_1776)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1458.Length; ++InternalVar_1)
            {
                InternalParameter_1776 = InternalField_1458[InternalVar_1];
                InternalParameter_1775 = InternalField_1459[InternalParameter_1776];

                if (InternalParameter_1773 >= InternalParameter_1775.InternalProperty_334)
                {
                    InternalParameter_1773 -= InternalParameter_1775.InternalProperty_334;
                    continue;
                }

                InternalParameter_1774 = InternalParameter_1773;
                return true;
            }

            InternalParameter_1775 = default;
            InternalParameter_1776 = InternalType_131.InternalField_415;
            InternalParameter_1774 = default;
            return false;
        }
    }
}

