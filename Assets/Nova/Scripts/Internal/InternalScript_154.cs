using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_300 : IEquatable<InternalType_301>, IEquatable<InternalType_302.InternalType_303>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_306 InternalField_578;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_301 InternalField_986;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_305 InternalField_987;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_304 InternalField_988;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public int InternalField_989;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_301 other)
        {
            return InternalField_986 == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_302.InternalType_303 other)
        {
            return InternalField_986 == other.InternalField_1000 && InternalField_988 == other.InternalField_999;
        }
    }

    internal struct InternalType_307
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1007;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1008;
    }

    
    internal struct InternalType_302 : InternalType_147, InternalType_150
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_162<InternalType_301, InternalType_276> InternalField_991;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_162<InternalType_305, InternalType_300> InternalField_992;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_162<InternalType_305, InternalType_164<InternalType_288>> InternalField_993;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_162<InternalType_305, InternalType_162<InternalType_368, InternalType_259>> InternalField_994;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<InternalType_307> InternalField_995;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_164<InternalType_162<InternalType_368, InternalType_259>> InternalField_996;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_164<InternalType_164<InternalType_288>> InternalField_997;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_998;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_304
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_992.InternalProperty_216;
        }

        public void InternalMethod_1345()
        {
            int InternalVar_1 = 0;
            for (int InternalVar_2 = 0; InternalVar_2 < InternalField_994.InternalProperty_216; ++InternalVar_2)
            {
                if (InternalField_991[InternalField_992[InternalVar_2].InternalField_986].InternalField_902 == InternalType_266.InternalField_786)
                {
                    InternalField_995.InternalMethod_785(default);
                    continue;
                }

                InternalField_995.InternalMethod_785(new InternalType_307()
                {
                    InternalField_1007 = InternalVar_1,
                    InternalField_1008 = InternalField_994[InternalVar_2].InternalProperty_216
                });
                InternalVar_1 += InternalField_994[InternalVar_2].InternalProperty_216;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_301 InternalMethod_1346(ref InternalType_276 InternalParameter_1415)
        {
            if (InternalField_991.InternalMethod_762(InternalParameter_1415, out int InternalVar_1))
            {
                return InternalVar_1;
            }
            else
            {
                InternalField_991.InternalMethod_761(InternalParameter_1415);
                return InternalField_991.InternalProperty_216 - 1;
            }
        }

        public void InternalMethod_1347(ref ComputeBuffer InternalParameter_1416)
        {
            InternalType_177.InternalMethod_844<InternalType_259>(ref InternalParameter_1416, InternalField_998);
            int InternalVar_1 = 0;
            for (int InternalVar_2 = 0; InternalVar_2 < InternalField_994.InternalProperty_216; ++InternalVar_2)
            {
                InternalType_162<InternalType_368, InternalType_259> InternalVar_3 = InternalField_994[InternalVar_2];
                if (InternalVar_3.InternalProperty_216 == 0)
                {
                    continue;
                }

                using (var indicesAsArray = InternalVar_3.InternalField_451.InternalMethod_804())
                {
                    InternalParameter_1416.SetData(indicesAsArray.Array, 0, InternalVar_1, InternalVar_3.InternalProperty_216);
                }
                InternalVar_1 += InternalVar_3.InternalProperty_216;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1348(InternalType_301 InternalParameter_1417, InternalType_304 InternalParameter_1418, InternalType_305 InternalParameter_1419, out InternalType_305 InternalParameter_1420)
        {
            InternalType_303 InternalVar_1 = new InternalType_303()
            {
                InternalField_999 = InternalParameter_1418,
                InternalField_1000 = InternalParameter_1417,
            };

            bool InternalVar_3 = InternalField_992.InternalMethod_762(InternalVar_1, out int InternalVar_2, InternalParameter_1419);
            InternalParameter_1420 = InternalVar_2;
            return InternalVar_3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_305 InternalMethod_1349(InternalType_301 InternalParameter_1421, InternalType_304 InternalParameter_1422)
        {
            InternalType_305 InternalVar_1 = InternalField_992.InternalProperty_216;
            InternalField_992.InternalMethod_761(new InternalType_300()
            {
                InternalField_987 = InternalVar_1,
                InternalField_986 = InternalParameter_1421,
                InternalField_988 = InternalParameter_1422
            });

            if (!InternalField_996.InternalMethod_792(out InternalType_162<InternalType_368, InternalType_259> InternalVar_2))
            {
                InternalVar_2.InternalMethod_703();
            }
            InternalField_994.InternalMethod_761(InternalVar_2);

            if (InternalField_991.InternalMethod_758(InternalParameter_1421).InternalField_902 == InternalType_266.InternalField_786)
            {
                if (!InternalField_997.InternalMethod_792(out InternalType_164<InternalType_288> InternalVar_3))
                {
                    InternalVar_3.InternalMethod_702();
                }
                InternalField_993.InternalMethod_761(InternalVar_3);
            }
            else
            {
                InternalField_993.InternalMethod_761(default);
            }
            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1350(InternalType_259 InternalParameter_1423, ref InternalType_305 InternalParameter_1424, ref InternalType_306 InternalParameter_1425)
        {
            InternalField_998 += 1;
            InternalField_994.InternalMethod_758(InternalParameter_1424).InternalMethod_761(InternalParameter_1423);
            InternalField_992.InternalMethod_758(InternalParameter_1424).InternalField_578.InternalMethod_1376(ref InternalParameter_1425);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1351(ref InternalType_305 InternalParameter_1426, ref InternalType_306 InternalParameter_1427, ref InternalType_288 InternalParameter_1428)
        {
            InternalField_992.InternalMethod_758(InternalParameter_1426).InternalField_578.InternalMethod_1376(ref InternalParameter_1427);
            InternalField_993.InternalMethod_758(InternalParameter_1426).InternalMethod_785(InternalParameter_1428);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_307 InternalMethod_1352(InternalType_305 InternalParameter_1429)
        {
            return InternalField_995[InternalParameter_1429];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_705()
        {
            InternalField_998 = 0;

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_992.InternalProperty_216; ++InternalVar_1)
            {
                ref InternalType_276 InternalVar_2 = ref InternalField_991.InternalMethod_758(InternalField_992.InternalMethod_758(InternalVar_1).InternalField_986);
                if (InternalVar_2.InternalField_902 != InternalType_266.InternalField_786)
                {
                    continue;
                }

                ref InternalType_164<InternalType_288> InternalVar_3 = ref InternalField_993.InternalMethod_758(InternalVar_1);
                InternalVar_3.InternalMethod_705();
                InternalField_997.InternalMethod_785(InternalVar_3);
            }
            InternalField_993.InternalMethod_705();

            InternalField_992.InternalMethod_705();
            InternalField_994.InternalMethod_766(ref InternalField_996);
            InternalField_993.InternalMethod_705();
            InternalField_995.InternalMethod_705();
            InternalField_991.InternalMethod_705();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            InternalField_991.Dispose();
            InternalField_992.Dispose();
            InternalField_994.InternalMethod_765();
            InternalField_993.InternalMethod_765();
            InternalField_996.InternalMethod_776();
            InternalField_995.Dispose();
            InternalField_997.InternalMethod_776();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_702()
        {
            InternalField_991.InternalMethod_703();
            InternalField_992.InternalMethod_703();
            InternalField_994.InternalMethod_703();
            InternalField_993.InternalMethod_703();
            InternalField_995.InternalMethod_702();
            InternalField_996.InternalMethod_702();
            InternalField_997.InternalMethod_702();
        }

        public struct InternalType_303
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_304 InternalField_999;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_301 InternalField_1000;
        }
    }
}

