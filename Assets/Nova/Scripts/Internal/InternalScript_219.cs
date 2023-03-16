using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_420 : InternalType_193
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1591;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_373>> InternalField_1592;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_418> InternalField_1593;

        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_302> InternalField_1594;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_164<InternalType_383>> InternalField_1595;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_164<InternalType_383> InternalField_1596;

        public void Execute(int index)
        {
            InternalType_131 InternalVar_1 = InternalField_1591[index];
            InternalField_1596 = InternalField_1595.InternalMethod_1557(InternalVar_1);
            InternalType_162<InternalType_288, InternalType_373> InternalVar_2 = InternalField_1592[InternalVar_1];

            InternalType_302 InternalVar_3 = InternalField_1594[InternalVar_1];
            for (int InternalVar_4 = 0; InternalVar_4 < InternalVar_3.InternalField_992.InternalProperty_216; ++InternalVar_4)
            {
                ref InternalType_300 InternalVar_5 = ref InternalVar_3.InternalField_992.InternalMethod_758(InternalVar_4);
                ref InternalType_276 InternalVar_6 = ref InternalVar_3.InternalField_991.InternalMethod_758(InternalVar_5.InternalField_986);

                if (InternalVar_6.InternalField_902 != InternalType_266.InternalField_786)
                {
                    continue;
                }

                ref InternalType_164<InternalType_288> InternalVar_7 = ref InternalVar_3.InternalField_993.InternalMethod_758(InternalVar_5.InternalField_987);
                ref InternalType_307 InternalVar_8 = ref InternalVar_3.InternalField_995.InternalMethod_800(InternalVar_5.InternalField_987);
                InternalVar_8.InternalField_1007 = InternalField_1596.InternalProperty_216;

                for (int InternalVar_9 = 0; InternalVar_9 < InternalVar_7.InternalProperty_216; ++InternalVar_9)
                {
                    ref InternalType_373 InternalVar_10 = ref InternalVar_2.InternalMethod_758(InternalVar_7[InternalVar_9]);
                    InternalField_1596.InternalMethod_787(ref InternalField_1593.InternalMethod_748(InternalVar_10.InternalField_1295).InternalField_1586);
                }

                InternalVar_8.InternalField_1008 = InternalField_1596.InternalProperty_216 - InternalVar_8.InternalField_1007;
            }

            InternalField_1595[InternalVar_1] = InternalField_1596;
            InternalField_1594[InternalVar_1] = InternalVar_3;
        }
    }
}
