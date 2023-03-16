using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_346
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_133, InternalType_73> InternalField_1189;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_161<InternalType_133, InternalType_367> InternalField_1190;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_352<InternalType_73>> InternalField_1191;

        public ref InternalType_73 InternalMethod_1511(InternalType_133 InternalParameter_1620)
        {
            ref InternalType_367 InternalVar_1 = ref InternalField_1190.InternalMethod_748(InternalParameter_1620);
            if (InternalVar_1 >= 0)
            {
                return ref InternalField_1191.ElementAt(InternalVar_1).InternalProperty_1030;
            }
            else
            {
                return ref InternalField_1189.InternalMethod_748(InternalParameter_1620);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref InternalType_73 InternalMethod_1540(InternalType_255 InternalParameter_1911)
        {
            ref InternalType_367 InternalVar_1 = ref InternalField_1190.InternalMethod_748(InternalParameter_1911.InternalProperty_196);
            if (InternalVar_1 >= 0)
            {
                return ref InternalField_1191.ElementAt(InternalVar_1).InternalProperty_1030;
            }

            InternalVar_1 = InternalField_1191.Length;

            InternalType_352<InternalType_73> InternalVar_2 = new InternalType_352<InternalType_73>(InternalParameter_1911, ref InternalParameter_1911.InternalProperty_268);
            InternalField_1191.Add(InternalVar_2);
            return ref InternalVar_2.InternalProperty_1030;
        }

        public unsafe void InternalMethod_1513(ref InternalType_342 InternalParameter_1623)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1191.Length; ++InternalVar_1)
            {
                ref InternalType_352<InternalType_73> InternalVar_2 = ref InternalField_1191.ElementAt(InternalVar_1);
                using InternalType_455 InternalVar_3 = new InternalType_455(InternalVar_2.InternalField_2010);

                if (!InternalVar_2.InternalField_1228.InternalProperty_192 ||
                    !InternalParameter_1623.InternalField_1181.TryGetValue(InternalVar_2.InternalField_1228, out InternalType_133 InternalVar_4))
                {
                    continue;
                }

                InternalField_1190[InternalVar_4] = InternalType_367.InternalField_1277;
                if (!InternalField_1189.InternalMethod_747(InternalVar_4, out InternalType_73* InternalVar_5))
                {
                    continue;
                }

                InternalVar_2.InternalProperty_1030.InternalMethod_1293();

                if (InternalVar_2.InternalProperty_1030.Equals(*InternalVar_5))
                {
                    continue;
                }

                if (InternalVar_2.InternalProperty_1030.InternalProperty_1032 != InternalVar_5->InternalProperty_1032 ||
                    InternalVar_2.InternalProperty_1030.InternalField_245 != InternalVar_5->InternalField_245 ||
                    InternalVar_2.InternalProperty_1030.InternalField_244 != InternalVar_5->InternalField_244)
                {
                    InternalType_131 InternalVar_6 = InternalParameter_1623.InternalField_1182[InternalVar_4].InternalField_589;
                    InternalParameter_1623.InternalField_1184.InternalField_1283.InternalMethod_837(InternalVar_6);
                }

                InternalType_188.InternalMethod_952(InternalVar_5, InternalVar_2.InternalField_1962);
                InternalParameter_1623.InternalField_1184.InternalField_1282.InternalMethod_837(InternalVar_4);
            }
        }


        public InternalType_133 InternalMethod_2951(InternalType_133 InternalParameter_991, ref InternalType_73 InternalParameter_990)
        {
            InternalField_1189.InternalMethod_751(InternalParameter_990);
            InternalField_1190.InternalMethod_751(InternalType_367.InternalField_1277);
            return InternalParameter_991;
        }

        public void InternalMethod_1515()
        {
            InternalField_1191.Clear();
        }

        public void InternalMethod_1516()
        {
            InternalField_1189.Dispose();

            InternalField_1190.Dispose();
            InternalField_1191.Dispose();
        }

        public void InternalMethod_1517()
        {
            InternalField_1189.InternalMethod_703(InternalType_178.InternalField_3013);
            InternalField_1190.InternalMethod_703(InternalType_178.InternalField_3013);
            InternalField_1191.InternalMethod_1020(InternalType_178.InternalField_3012);
        }

        public void InternalMethod_1518(InternalType_133 InternalParameter_1627)
        {
            InternalField_1189.InternalMethod_749(InternalParameter_1627);
            InternalType_367 InternalVar_1 = InternalField_1190[InternalParameter_1627];
            InternalField_1190.InternalMethod_749(InternalParameter_1627);
            if (InternalVar_1 >= 0)
            {
                InternalField_1191.ElementAt(InternalVar_1).InternalField_1228 = InternalType_131.InternalField_415;
            }
        }
    }
}