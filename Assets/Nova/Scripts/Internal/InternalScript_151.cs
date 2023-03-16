using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_283
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_369 InternalField_924;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public short InternalField_925;
    }

    internal struct InternalType_284 : InternalType_147, InternalType_150
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_164<InternalType_287> InternalField_926;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_164<InternalType_287> InternalField_927;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_705()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_927.InternalProperty_216; ++InternalVar_1)
            {
                InternalType_287 InternalVar_2 = InternalField_927[InternalVar_1];
                InternalVar_2.InternalMethod_1288();
                InternalField_926.InternalMethod_785(InternalVar_2);
            }
            InternalField_927.InternalMethod_705();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int InternalMethod_1280(InternalType_283 InternalParameter_1342)
        {
            int InternalVar_1 = 0;
            for (int InternalVar_2 = 0; InternalVar_2 < InternalField_927.InternalProperty_216; ++InternalVar_2)
            {
                ref InternalType_287 InternalVar_3 = ref InternalField_927.InternalMethod_800(InternalVar_2);
                if (InternalVar_3.InternalField_935 < InternalParameter_1342.InternalField_925)
                {
                    InternalVar_1 += InternalVar_3.InternalProperty_297;
                    continue;
                }
                InternalVar_1 += InternalParameter_1342.InternalField_924;
                break;
            }
            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1281(InternalType_288 InternalParameter_1343, short InternalParameter_1344)
        {
            if (InternalField_927.InternalMethod_769(InternalParameter_1344, out int InternalVar_1))
            {
                ref InternalType_287 InternalVar_2 = ref InternalField_927.InternalMethod_800(InternalVar_1);
                InternalVar_2.InternalField_934.InternalMethod_761(InternalParameter_1343);
            }
            else
            {
                if (!InternalField_926.InternalMethod_792(out InternalType_287 InternalVar_2))
                {
                    InternalVar_2.InternalMethod_702();
                }
                InternalVar_2.InternalField_935 = InternalParameter_1344;
                InternalVar_2.InternalField_934.InternalMethod_761(InternalParameter_1343);
                InternalField_927.InternalMethod_785(InternalVar_2);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1282(int InternalParameter_1345, out InternalType_285 InternalParameter_1346)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_927.InternalProperty_216; ++InternalVar_1)
            {
                ref InternalType_287 InternalVar_2 = ref InternalField_927.InternalMethod_800(InternalVar_1);
                if (InternalParameter_1345 >= InternalVar_2.InternalProperty_297)
                {
                    InternalParameter_1345 -= InternalVar_2.InternalProperty_297;
                    continue;
                }

                InternalParameter_1346 = new InternalType_285()
                {
                    InternalField_929 = InternalVar_1,
                    InternalField_928 = InternalParameter_1345,
                };
                return true;
            }

            InternalParameter_1346 = InternalType_285.InternalField_930;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1283(out InternalType_288 InternalParameter_1347, ref InternalType_285 InternalParameter_1348)
        {
            if (InternalParameter_1348.InternalField_929 < 0)
            {
                InternalParameter_1347 = InternalType_288.InternalField_937;
                return false;
            }

            ref InternalType_287 InternalVar_1 = ref InternalField_927.InternalMethod_800(InternalParameter_1348.InternalField_929);
            if (InternalParameter_1348.InternalField_928 < 0)
            {
                InternalParameter_1348.InternalField_929 -= 1;
                if (InternalParameter_1348.InternalField_929 < 0)
                {
                    InternalParameter_1347 = InternalType_288.InternalField_937;
                    return false;
                }

                InternalParameter_1348.InternalField_928 = InternalField_927.InternalMethod_800(InternalParameter_1348.InternalField_929).InternalProperty_297 - 1;
                return InternalMethod_1283(out InternalParameter_1347, ref InternalParameter_1348);
            }

            InternalParameter_1347 = InternalVar_1.InternalField_934[InternalParameter_1348.InternalField_928--];
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1284(int InternalParameter_1349, out InternalType_288 InternalParameter_1350, out InternalType_286 InternalParameter_1351)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_927.InternalProperty_216; ++InternalVar_1)
            {
                ref InternalType_287 InternalVar_2 = ref InternalField_927.InternalMethod_800(InternalVar_1);
                if (InternalParameter_1349 >= InternalVar_2.InternalProperty_297)
                {
                    InternalParameter_1349 -= InternalVar_2.InternalProperty_297;
                    continue;
                }

                InternalParameter_1350 = InternalVar_2.InternalField_934[InternalParameter_1349];

                InternalParameter_1351 = new InternalType_286()
                {
                    InternalField_932 = InternalVar_1,
                    InternalField_931 = InternalParameter_1349 + 1,
                };
                return true;
            }

            InternalParameter_1351 = InternalType_286.InternalField_933;
            InternalParameter_1350 = InternalType_288.InternalField_937;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1285(out InternalType_288 InternalParameter_1352, ref InternalType_286 InternalParameter_1353)
        {
            if (InternalParameter_1353.InternalField_932 >= InternalField_927.InternalProperty_216)
            {
                InternalParameter_1352 = InternalType_288.InternalField_937;
                return false;
            }

            ref InternalType_287 InternalVar_1 = ref InternalField_927.InternalMethod_800(InternalParameter_1353.InternalField_932);
            if (InternalParameter_1353.InternalField_931 >= InternalVar_1.InternalProperty_297)
            {
                InternalParameter_1353.InternalField_931 = 0;
                InternalParameter_1353.InternalField_932 += 1;
                return InternalMethod_1285(out InternalParameter_1352, ref InternalParameter_1353);
            }

            InternalParameter_1352 = InternalVar_1.InternalField_934[InternalParameter_1353.InternalField_931++];
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1286()
        {
            InternalField_927.InternalField_452.Sort();
        }

        public void Dispose()
        {
            InternalField_926.InternalMethod_776();
            InternalField_927.InternalMethod_776();
        }

        public void InternalMethod_702()
        {
            InternalField_926.InternalMethod_702();
            InternalField_927.InternalMethod_775(1);
        }

        public struct InternalType_287 : InternalType_147, IEquatable<short>, IComparable<InternalType_287>
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_162<InternalType_369, InternalType_288> InternalField_934;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public short InternalField_935;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalProperty_297
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => InternalField_934.InternalProperty_216;
            }

            public void InternalMethod_1288()
            {
                InternalField_934.InternalMethod_705();
                InternalField_935 = 0;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int CompareTo(InternalType_287 other)
            {
                return InternalField_935.CompareTo(other.InternalField_935);
            }

            public void Dispose()
            {
                InternalField_934.Dispose();
            }

            public bool Equals(short other)
            {
                return InternalField_935 == other;
            }

            public void InternalMethod_702()
            {
                InternalField_934.InternalMethod_703();
            }
        }

        public struct InternalType_285
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_369 InternalField_928;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_929;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly InternalType_285 InternalField_930 = new InternalType_285()
            {
                InternalField_928 = -1,
                InternalField_929 = -1,
            };
        }

        public struct InternalType_286
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_369 InternalField_931;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_932;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly InternalType_286 InternalField_933 = new InternalType_286()
            {
                InternalField_931 = -1,
                InternalField_932 = -1,
            };
        }
    }
}

