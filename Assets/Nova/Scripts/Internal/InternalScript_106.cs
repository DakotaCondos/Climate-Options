using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Nova.InternalNamespace_0.InternalNamespace_9
{
    internal partial class InternalType_227
    {
        [BurstCompile]
        internal struct InternalType_250 : InternalType_193, IJob
        {
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_730;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_731;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, int> InternalField_732;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_733;

            [NativeDisableParallelForRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_224> InternalField_734;

            public unsafe void Execute()
            {
                int InternalVar_1 = InternalField_733.Length;
                for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; ++InternalVar_2)
                {
                    Execute(InternalVar_2);
                }
            }

            public unsafe void Execute(int dirtyElementIndex)
            {
                InternalType_133 InternalVar_1 = InternalField_733[dirtyElementIndex];
                InternalType_222 InternalVar_2 = InternalField_730[InternalVar_1];

                bool InternalVar_3 = InternalVar_2.InternalProperty_253 > 0;
                bool InternalVar_4 = InternalVar_2.InternalField_586.InternalProperty_192;

                bool InternalVar_5 = InternalField_732.ContainsKey(InternalVar_2.InternalField_585);
                if (!InternalVar_5)
                {
                    if (!InternalVar_4)
                    {

                        ref InternalType_224 InternalVar_6 = ref InternalField_734.ElementAt(InternalVar_1);
                        InternalVar_6.InternalField_589 = InternalType_131.InternalField_415;
                        InternalVar_6.InternalField_590 = InternalType_223.InternalField_588;

                        return;
                    }

                    if (!InternalVar_3)
                    {
                        return;
                    }
                }

                InternalMethod_1138(InternalVar_2.InternalField_585, out InternalType_131 InternalVar_7, out int InternalVar_8);

                if (InternalVar_5)
                {
                    ref InternalType_224 InternalVar_9 = ref InternalField_734.ElementAt(InternalVar_1);
                    InternalVar_9.InternalField_589 = InternalVar_2.InternalField_585;
                    InternalVar_9.InternalField_590 = InternalVar_8;
                }

                InternalMethod_1139(InternalVar_1, InternalVar_7, InternalVar_8);
            }

            
            private void InternalMethod_1138(InternalType_131 InternalParameter_1223, out InternalType_131 InternalParameter_1224, out int InternalParameter_1225)
            {
                InternalParameter_1225 = -1;
                InternalParameter_1224 = InternalType_131.InternalField_415;

                while (!InternalParameter_1224.InternalProperty_192 && InternalField_731.TryGetValue(InternalParameter_1223, out InternalType_133 InternalVar_1))
                {
                    InternalType_222 InternalVar_2 = InternalField_730[InternalVar_1];

                    InternalParameter_1225++;
                    InternalParameter_1224 = !InternalParameter_1224.InternalProperty_192 && InternalField_732.ContainsKey(InternalParameter_1223) ? InternalParameter_1223 : InternalParameter_1224;

                    InternalParameter_1223 = InternalVar_2.InternalField_586;
                }
            }

            private void InternalMethod_1139(InternalType_133 InternalParameter_1226, InternalType_131 InternalParameter_1227, int InternalParameter_1228)
            {
                InternalType_222 InternalVar_1 = InternalField_730[InternalParameter_1226];

                int InternalVar_2 = InternalParameter_1228 + 1;
                int InternalVar_3 = InternalVar_1.InternalField_587.InternalProperty_216;
                for (int InternalVar_4 = 0; InternalVar_4 < InternalVar_3; ++InternalVar_4)
                {
                    InternalType_133 InternalVar_5 = InternalVar_1.InternalField_587[InternalVar_4];
                    InternalType_131 InternalVar_6 = InternalField_730[InternalVar_5].InternalField_585;

                    ref InternalType_224 InternalVar_7 = ref InternalField_734.ElementAt(InternalVar_5);

                    InternalVar_7.InternalField_590 = InternalVar_2;

                    if (!InternalField_732.ContainsKey(InternalVar_6))
                    {
                        InternalVar_7.InternalField_589 = InternalParameter_1227;
                    }
                }
            }
        }
    }
}
