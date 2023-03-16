using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal unsafe struct InternalType_351 : InternalType_343<InternalType_82, InternalType_348>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_82> InternalField_1220;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_186<InternalType_389, InternalType_389> InternalField_1221;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_259> InternalField_1222;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_161<InternalType_348, InternalType_133> InternalField_1223;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_161<InternalType_348, InternalType_367> InternalField_1224;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_352<InternalType_82>> InternalField_1225;

        public ref InternalType_82 InternalMethod_1539(InternalType_348 InternalParameter_1658)
        {
            ref InternalType_367 InternalVar_1 = ref InternalField_1224.InternalMethod_748(InternalParameter_1658);
            if (InternalVar_1 >= 0)
            {
                return ref InternalField_1225.ElementAt(InternalVar_1).InternalProperty_1030;
            }
            else
            {
                return ref InternalField_1220.InternalMethod_748(InternalParameter_1658);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref InternalType_82 InternalMethod_1512(InternalType_9 InternalParameter_1908, InternalType_348 InternalParameter_1660)
        {
            ref InternalType_367 InternalVar_1 = ref InternalField_1224.InternalMethod_748(InternalParameter_1660);
            if (InternalVar_1 >= 0)
            {
                return ref InternalField_1225.ElementAt(InternalVar_1).InternalProperty_1030;
            }

            InternalVar_1 = InternalField_1225.Length;

            InternalType_352<InternalType_82> InternalVar_2 = new InternalType_352<InternalType_82>(InternalParameter_1908, ref InternalParameter_1908.InternalProperty_270);
            InternalField_1225.Add(InternalVar_2);
            return ref InternalVar_2.InternalProperty_1030;
        }

        public InternalType_348 InternalMethod_1682(InternalType_133 InternalParameter_1873, ref InternalType_82 InternalParameter_1663)
        {
            InternalType_348 InternalVar_1 = InternalField_1220.InternalProperty_216;
            InternalField_1220.InternalMethod_751(InternalParameter_1663);
            InternalField_1222.InternalMethod_751(InternalField_1221.InternalMethod_1246());
            InternalField_1224.InternalMethod_751(InternalType_367.InternalField_1277);
            InternalField_1223.InternalMethod_751(InternalParameter_1873);
            return InternalVar_1;
        }

        public void InternalMethod_1506()
        {
            InternalField_1225.Clear();
            InternalField_1221.InternalMethod_1247();
        }

        public void InternalMethod_1542(ref InternalType_342 InternalParameter_1664)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1225.Length; ++InternalVar_1)
            {
                ref InternalType_352<InternalType_82> InternalVar_2 = ref InternalField_1225.ElementAt(InternalVar_1);
                using InternalType_455 InternalVar_3 = new InternalType_455(InternalVar_2.InternalField_2010);

                if (!InternalVar_2.InternalField_1228.InternalProperty_192 ||
                    !InternalParameter_1664.InternalField_1181.TryGetValue(InternalVar_2.InternalField_1228, out InternalType_133 InternalVar_4))
                {
                    continue;
                }

                InternalType_348 InternalVar_5 = InternalParameter_1664.InternalField_1183[InternalVar_4].InternalField_984;
                InternalField_1224[InternalVar_5] = InternalType_367.InternalField_1277;
                if (!InternalField_1220.InternalMethod_747(InternalVar_5, out InternalType_82* InternalVar_6))
                {
                    continue;
                }

                InternalVar_2.InternalProperty_1030.InternalMethod_1292();

                if (InternalVar_2.InternalProperty_1030.Equals(*InternalVar_6))
                {
                    continue;
                }

                InternalType_188.InternalMethod_952(InternalVar_6, InternalVar_2.InternalField_1962);
                InternalParameter_1664.InternalField_1184.InternalField_1282.InternalMethod_837(InternalVar_4);
                InternalType_131 InternalVar_7 = InternalParameter_1664.InternalField_1182[InternalVar_4].InternalField_589;
                InternalParameter_1664.InternalField_1184.InternalField_1283.InternalMethod_837(InternalVar_7);
            }
        }

        public bool InternalMethod_1505(InternalType_131 InternalParameter_1612, InternalType_348 InternalParameter_1613, out InternalType_133 InternalParameter_1614)
        {
            InternalField_1220.InternalMethod_749(InternalParameter_1613);
            InternalField_1221.InternalMethod_1245(InternalField_1222[InternalParameter_1613]);
            InternalField_1222.InternalMethod_749(InternalParameter_1613);
            InternalField_1223.InternalMethod_749(InternalParameter_1613);

            InternalType_367 InternalVar_1 = InternalField_1224[InternalParameter_1613];
            InternalField_1224.InternalMethod_749(InternalParameter_1613);
            if (InternalVar_1 >= 0)
            {
                InternalField_1225.ElementAt(InternalVar_1).InternalField_1228 = InternalType_131.InternalField_415;
            }

            if (InternalParameter_1613 == InternalField_1220.InternalProperty_216)
            {
                InternalParameter_1614 = -1;
                return false;
            }
            else
            {
                InternalParameter_1614 = InternalField_1223[InternalParameter_1613];
                return true;
            }
        }

        public void InternalMethod_1543(InternalType_348 InternalParameter_1665, InternalType_133 InternalParameter_1666)
        {
            if (!InternalType_181.InternalMethod_850(InternalParameter_1665, InternalField_1223.InternalProperty_216))
            {
                Debug.LogError($"Tried to set global index from sublist index {InternalParameter_1665} when list was length {InternalField_1223.InternalProperty_216}");
                return;
            }

            InternalField_1223[InternalParameter_1665] = InternalParameter_1666;
        }

        public void Dispose()
        {
            InternalField_1221.Dispose();

            InternalField_1220.Dispose();
            InternalField_1222.Dispose();
            InternalField_1223.Dispose();
            InternalField_1224.Dispose();
            InternalField_1225.Dispose();
        }

        public void InternalMethod_702()
        {
            InternalField_1221.InternalMethod_703(InternalType_178.InternalField_3012);

            InternalField_1220.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_1222.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_1223.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_1224.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_1225.InternalMethod_1020(InternalType_178.InternalField_3012);
        }
    }
}
