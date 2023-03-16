using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_9
{
    internal partial class InternalType_227
    {
        [BurstCompile]
        internal struct InternalType_251 : InternalType_192
        {
            
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_131> InternalField_735;

            
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_736;

            
            [WriteOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, int> InternalField_737;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_738;

            public void Execute()
            {
                InternalField_737.Clear();

                int InternalVar_1 = InternalField_735.Length;
                for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; ++InternalVar_2)
                {
                    InternalType_131 InternalVar_3 = InternalField_735[InternalVar_2];
                    if (InternalField_736.ContainsKey(InternalVar_3))
                    {
                        InternalField_737.Add(InternalVar_3, InternalVar_2);
                    }
                }
            }
        }
    }
}
