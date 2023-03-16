using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_347 : InternalType_343<InternalType_79, InternalType_348>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_79> InternalField_1193;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_133> InternalField_1194;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_186<InternalType_258, InternalType_260> InternalField_1195;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_164<InternalType_259>> InternalField_1196;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_670> InternalField_1151;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_172<InternalType_131, InternalType_670>> InternalField_1150;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<InternalType_172<InternalType_131, float2>> InternalField_2241;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_161<InternalType_348, bool2> InternalField_2240;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_110> InternalField_1199;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_79> InternalField_1200;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_164<InternalType_259>> InternalField_1201;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_174<InternalType_131> InternalField_1202;

        public void InternalMethod_1506()
        {
            InternalField_1202.InternalMethod_840();
            InternalField_1195.InternalMethod_1247();

        }

        public unsafe void InternalMethod_1519(ref InternalType_342 InternalParameter_1628)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1202.InternalProperty_240; ++InternalVar_1)
            {
                if (!InternalParameter_1628.InternalField_1181.TryGetValue(InternalField_1202[InternalVar_1], out InternalType_133 InternalVar_2))
                {
                    continue;
                }

                InternalParameter_1628.InternalField_1184.InternalField_1282.InternalMethod_837(InternalVar_2);
                InternalType_131 InternalVar_3 = InternalParameter_1628.InternalField_1182[InternalVar_2].InternalField_589;
                InternalParameter_1628.InternalField_1184.InternalField_1283.InternalMethod_837(InternalVar_3);

                InternalType_348 InternalVar_4 = InternalParameter_1628.InternalField_1183[InternalVar_2].InternalField_984;
                ref InternalType_79 InternalVar_5 = ref InternalField_1193.InternalMethod_748(InternalVar_4);
                ref InternalType_164<InternalType_259> InternalVar_6 = ref InternalField_1196.InternalMethod_748(InternalVar_4);

                int InternalVar_7 = InternalVar_5.InternalField_3197;
                if (InternalVar_7 == InternalVar_6.InternalProperty_216)
                {
                    continue;
                }

                InternalParameter_1628.InternalField_1184.InternalField_1283.InternalMethod_837(InternalParameter_1628.InternalField_1182[InternalVar_2].InternalField_589);

                int InternalVar_8 = InternalVar_7 - InternalVar_6.InternalProperty_216;
                if (InternalVar_8 > 0)
                {
                    InternalField_1195.InternalMethod_1237(ref InternalVar_6, InternalVar_8);
                }
                else if (InternalVar_8 < 0)
                {
                    InternalField_1195.InternalMethod_1244(InternalVar_6, InternalVar_7, -InternalVar_8);
                    InternalVar_6.InternalProperty_216 = InternalVar_7;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref InternalType_79 InternalMethod_1520(InternalType_131 InternalParameter_1629, InternalType_348 InternalParameter_1630, int InternalParameter_1631)
        {
            ref InternalType_79 InternalVar_1 = ref InternalField_1193.InternalMethod_748(InternalParameter_1630);

            if (InternalParameter_1631 != -1)
            {
                int InternalVar_2 = InternalVar_1.InternalField_261.InternalProperty_216 - InternalParameter_1631;
                if (InternalVar_2 > 0)
                {
                    for (int InternalVar_3 = InternalVar_1.InternalField_261.InternalProperty_216 - 1; InternalVar_3 >= InternalParameter_1631; InternalVar_3--)
                    {
                        InternalField_1199.InternalMethod_1027(ref InternalVar_1.InternalField_261.InternalMethod_800(InternalVar_3));
                    }

                    InternalVar_1.InternalField_261.InternalProperty_216 = InternalParameter_1631;
                }
                else if (InternalVar_2 < 0)
                {
                    for (int InternalVar_3 = 0; InternalVar_3 < -InternalVar_2; ++InternalVar_3)
                    {
                        InternalVar_1.InternalField_261.InternalMethod_785(InternalField_1199.InternalMethod_1024());
                    }
                }
            }

            InternalField_1202.InternalMethod_837(InternalParameter_1629);
            return ref InternalVar_1;
        }

        public InternalType_348 InternalMethod_1005(InternalType_133 InternalParameter_925)
        {
            InternalType_79 InternalVar_1 = InternalField_1200.InternalMethod_1024();
            InternalType_348 InternalVar_2 = InternalField_1193.InternalProperty_216;
            InternalField_1193.InternalMethod_751(InternalVar_1);
            InternalField_1151.InternalMethod_751(InternalType_670.InternalField_2828);
            InternalField_2240.InternalMethod_751(default);
            InternalField_1194.InternalMethod_751(InternalParameter_925);
            InternalField_1196.InternalMethod_751(InternalField_1201.InternalMethod_1025());
            return InternalVar_2;
        }

        public bool InternalMethod_1505(InternalType_131 InternalParameter_1612, InternalType_348 InternalParameter_1613, out InternalType_133 InternalParameter_1614)
        {
            ref InternalType_79 InternalVar_1 = ref InternalField_1193.InternalMethod_748(InternalParameter_1613);
            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1.InternalField_261.InternalProperty_216; ++InternalVar_2)
            {
                ref InternalType_110 InternalVar_3 = ref InternalVar_1.InternalField_261.InternalMethod_800(InternalVar_2);
                InternalField_1199.InternalMethod_1027(ref InternalVar_3);
            }

            InternalField_1200.InternalMethod_1027(ref InternalVar_1);
            InternalField_1193.InternalMethod_749(InternalParameter_1613);
            InternalField_1151.InternalMethod_749(InternalParameter_1613);
            InternalField_2240.InternalMethod_749(InternalParameter_1613);

            InternalType_164<InternalType_259> InternalVar_4 = InternalField_1196[InternalParameter_1613];
            InternalField_1195.InternalMethod_1244(InternalVar_4, 0, InternalVar_4.InternalProperty_216);
            InternalField_1201.InternalMethod_1029(ref InternalVar_4);
            InternalField_1196.InternalMethod_749(InternalParameter_1613);
            InternalField_1194.InternalMethod_749(InternalParameter_1613);

            if (InternalParameter_1613 == InternalField_1193.InternalProperty_216)
            {
                InternalParameter_1614 = -1;
                return false;
            }
            else
            {
                InternalParameter_1614 = InternalField_1194[InternalParameter_1613];
                return true;
            }
        }

        public void InternalMethod_1523(InternalType_348 InternalParameter_1635, InternalType_133 InternalParameter_1636)
        {
            if (!InternalType_181.InternalMethod_850(InternalParameter_1635, InternalField_1194.InternalProperty_216))
            {
                Debug.LogError($"Tried to set global index from sublist index {InternalParameter_1635} when list was length {InternalField_1194.InternalProperty_216}");
                return;
            }

            InternalField_1194[InternalParameter_1635] = InternalParameter_1636;
        }

        public void Dispose()
        {
            InternalField_1193.Dispose();
            InternalField_1151.Dispose();
            InternalField_2240.Dispose();
            InternalField_1150.Dispose();
            InternalField_2241.Dispose();
            InternalField_1195.Dispose();
            InternalField_1196.InternalMethod_764();
            InternalField_1202.Dispose();
            InternalField_1194.Dispose();
            InternalField_1199.InternalMethod_1022();
            InternalField_1200.InternalMethod_1022();
            InternalField_1201.InternalMethod_1022();
        }

        public void InternalMethod_702()
        {
            InternalField_1193.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_1151.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_2240.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_1150.InternalMethod_1020(InternalType_178.InternalField_3012);
            InternalField_2241.InternalMethod_1020(InternalType_178.InternalField_3012);
            InternalField_1195.InternalMethod_703(InternalType_178.InternalField_3013);
            InternalField_1196.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_1202.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_1194.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_1199.InternalMethod_1020(InternalType_178.InternalField_3012);
            InternalField_1200.InternalMethod_1020(InternalType_178.InternalField_3012);
            InternalField_1201.InternalMethod_1020(InternalType_178.InternalField_3012);
        }
    }
}

