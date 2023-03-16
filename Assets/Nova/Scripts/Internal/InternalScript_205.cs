using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_398 : InternalType_192
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_808;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1421;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1422;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_133> InternalField_1423;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1424;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_224> InternalField_1425;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_133> InternalField_1426;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_3679;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_3680;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_133, InternalType_259> InternalField_3681;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_770<InternalType_394> InternalField_3682;


        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1427;

        public void Execute()
        {
            InternalMethod_1611();
        }

        private void InternalMethod_1611()
        {
            InternalField_1427.Clear();

            if (InternalField_808)
            {
                InternalMethod_1612(ref InternalField_1424);
            }
            else
            {
                InternalMethod_1612(ref InternalField_1421);
                InternalMethod_1612(ref InternalField_1422);

                for (int InternalVar_1 = 0; InternalVar_1 < InternalField_3679.Length; ++InternalVar_1)
                {
                    InternalType_131 InternalVar_2 = InternalField_3679[InternalVar_1];
                    if (!InternalMethod_1613(InternalVar_2))
                    {
                        continue;
                    }

                    InternalType_133 InternalVar_3 = InternalField_1426[InternalVar_2];

                    float4x4 InternalVar_4 = InternalField_3680[InternalVar_3];
                    float3 InternalVar_5 = InternalType_187.InternalMethod_894(ref InternalVar_4);
                    if (math.any(InternalVar_5 == float3.zero))
                    {
                        continue;
                    }

                    float4x4 InternalVar_6 = InternalField_3682[InternalField_3681[InternalVar_3]].InternalField_1385;
                    float3 InternalVar_7 = InternalType_187.InternalMethod_894(ref InternalVar_6);
                    if (math.any(math.isnan(InternalVar_7) | InternalVar_7 == float3.zero))
                    {
                        InternalField_1427.Add(InternalVar_2);
                    }
                }

                for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1423.Length; ++InternalVar_1)
                {
                    InternalType_224 InternalVar_2 = InternalField_1425[InternalField_1423[InternalVar_1]];
                    if (!InternalMethod_1613(InternalVar_2.InternalField_589))
                    {
                        continue;
                    }
                    InternalField_1427.Add(InternalVar_2.InternalField_589);
                }
            }
        }

        private void InternalMethod_1612(ref NativeList<InternalType_131> InternalParameter_1747)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_1747.Length; ++InternalVar_1)
            {
                if (!InternalMethod_1613(InternalParameter_1747[InternalVar_1]))
                {
                    continue;
                }
                InternalField_1427.Add(InternalParameter_1747[InternalVar_1]);
            }
        }

        private bool InternalMethod_1613(InternalType_131 InternalParameter_1748)
        {
            if (InternalField_1427.AsArray().Contains(InternalParameter_1748) || !InternalField_1424.AsArray().Contains(InternalParameter_1748))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

