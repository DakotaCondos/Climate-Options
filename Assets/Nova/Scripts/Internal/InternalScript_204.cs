using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_313 : InternalType_147, InternalType_150
    {
        public struct InternalType_20 : IEquatable<InternalType_310>
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_310 InternalField_3342;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_314 InternalField_3343;

            public InternalType_20(InternalType_310 InternalParameter_1049, InternalType_314 InternalParameter_717)
            {
                InternalField_3342 = InternalParameter_1049;
                InternalField_3343 = InternalParameter_717;
            }

            public bool Equals(InternalType_310 other)
            {
                return InternalField_3342 == other;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_321 InternalField_1038;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_317 InternalField_1039;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<InternalType_310> InternalField_1034;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_162<InternalType_314, InternalType_310> InternalField_1035;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<InternalType_20> InternalField_1036;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_1037;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_310
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1034.InternalProperty_216;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_309
        {
            get
            {
                if (InternalField_1034.InternalProperty_216 < 2)
                {
                    return false;
                }

                if (InternalField_1037)
                {
                    InternalField_1036.InternalMethod_705();
                    for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1035.InternalProperty_216; ++InternalVar_1)
                    {
                        InternalField_1036.InternalMethod_785(new InternalType_20(InternalField_1035[InternalVar_1], InternalVar_1));
                    }
                    return true;
                }
                else
                {
                    return InternalField_1036.InternalProperty_216 > 0;
                }
            }
        }

        public void InternalMethod_1417()
        {
            InternalField_1037 = false;
            InternalField_1036.InternalMethod_705();
        }

        public void InternalMethod_705()
        {
            InternalField_1034.InternalMethod_705();
            InternalField_1035.InternalMethod_705();
            InternalField_1036.InternalMethod_705();
            InternalField_1037 = false;
        }

        public InternalType_314 InternalMethod_1419(InternalType_310 InternalParameter_1510)
        {
            InternalField_1034.InternalMethod_785(InternalParameter_1510);

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1035.InternalProperty_216; InternalVar_1++)
            {
                if (InternalField_1035[InternalVar_1].InternalProperty_307)
                {
                    continue;
                }

                InternalField_1035[InternalVar_1] = InternalParameter_1510;
                InternalField_1036.InternalMethod_785(new InternalType_20(InternalParameter_1510, InternalVar_1));
                return InternalVar_1;
            }

            InternalField_1037 = true;
            InternalField_1035.InternalMethod_761(InternalParameter_1510);
            return InternalField_1035.InternalProperty_216 - 1;
        }

        public void InternalMethod_1420(InternalType_310 InternalParameter_1511)
        {
            if (!InternalField_1035.InternalMethod_762(InternalParameter_1511, out int InternalVar_1))
            {
                Debug.LogError("Tried to remove untracked texture from TexturePack");
                return;
            }

            InternalField_1035[InternalVar_1] = InternalType_310.InternalField_1023;

            if (InternalField_1034.InternalMethod_769(InternalParameter_1511, out int InternalVar_2))
            {
                InternalField_1034.InternalMethod_786(InternalVar_2);
            }

            if (InternalField_1036.InternalMethod_769(InternalParameter_1511, out InternalVar_1))
            {
                InternalField_1036.InternalMethod_786(InternalVar_1);
            }
        }

        public void InternalMethod_702()
        {
            InternalField_1034.InternalMethod_702();
            InternalField_1035.InternalMethod_703();
            InternalField_1036.InternalMethod_702();
            InternalField_1037 = false;
        }

        public void Dispose()
        {
            InternalField_1034.Dispose();
            InternalField_1035.Dispose();
            InternalField_1036.Dispose();
        }
    }
}

