using AOT;
using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using static Nova.InternalNamespace_0.InternalNamespace_9.InternalType_227;

namespace Nova.InternalNamespace_0.InternalNamespace_8
{
    internal enum InternalType_216 { InternalField_560, InternalField_561, InternalField_562 };

    internal struct InternalType_217
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Vector3 InternalField_563;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_216 InternalField_564;
    }

    [BurstCompile]
    internal struct InternalType_218 : IJob
    {
        [WriteOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_217> InternalField_565;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_55> InternalField_566;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<bool> InternalField_567;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<quaternion> InternalField_568;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_228.InternalType_229 InternalField_569;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_571;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_572;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_573;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_574;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_575;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_3362;

        public void Execute()
        {
            InternalType_133 InternalVar_1 = InternalField_569.InternalField_637[InternalField_572];
            InternalType_164<InternalType_133> InternalVar_2 = InternalField_569.InternalField_635[InternalVar_1].InternalField_587;

            InternalType_448.InternalType_453 InternalVar_3 = InternalType_448.InternalMethod_1751(InternalVar_1, ref InternalField_566);
            float3 InternalVar_4 = InternalVar_3.InternalProperty_398.InternalProperty_124;
            float3 InternalVar_5 = math.select(InternalVar_4, InternalType_187.InternalField_538, InternalVar_4 == InternalType_187.InternalField_530);
            InternalVar_5[InternalField_573] = InternalVar_4[InternalField_573] + 2 * InternalField_571;

            float InternalVar_6 = InternalVar_3.InternalProperty_402[InternalField_573];
            float InternalVar_7 = InternalVar_3.InternalProperty_400.InternalProperty_139[InternalField_573];

            Bounds InternalVar_8 = new Bounds(Vector3.zero, InternalVar_5);
            float InternalVar_9 = InternalVar_8.min[InternalField_573];
            float InternalVar_10 = InternalVar_8.max[InternalField_573];

            InternalField_565.Clear();

            int InternalVar_11 = InternalVar_2.InternalProperty_216;

            for (int InternalVar_12 = 0; InternalVar_12 < InternalVar_11; ++InternalVar_12)
            {
                InternalType_133 InternalVar_13 = InternalVar_2[InternalVar_12];

                InternalType_448.InternalType_453 InternalVar_14 = InternalType_448.InternalMethod_1751(InternalVar_13, ref InternalField_566);

                float3 InternalVar_15 = InternalVar_14.InternalMethod_1832(ref InternalField_568, ref InternalField_567);
                float InternalVar_16 = InternalVar_15[InternalField_573];
                float InternalVar_17 = InternalVar_14.InternalProperty_399[InternalField_573].InternalField_153;
                float InternalVar_18 = InternalVar_14.InternalProperty_401.InternalProperty_139[InternalField_573];

                float InternalVar_19 = InternalType_182.InternalMethod_857(InternalVar_17, InternalVar_16, InternalVar_6, InternalVar_18 + InternalVar_7, InternalField_3362) + InternalField_575;

                float InternalVar_20 = InternalVar_19 - 0.5f * InternalVar_16;
                float InternalVar_21 = InternalVar_19 + 0.5f * InternalVar_16;

                float InternalVar_22 = InternalField_574 < 0 ? InternalVar_21 : InternalVar_20;
                float InternalVar_23 = InternalField_574 < 0 ? InternalVar_21 : InternalVar_20;

                float InternalVar_24 = InternalField_574 < 0 ? InternalVar_10 : InternalVar_9;
                float InternalVar_25 = InternalField_574 < 0 ? InternalVar_9 : InternalVar_10;

                float InternalVar_26 = (InternalVar_23 - InternalVar_25) * InternalField_574;
                float InternalVar_27 = (InternalVar_22 - InternalVar_24) * InternalField_574;

                bool InternalVar_28 = InternalVar_26 > 0;
                bool InternalVar_29 = InternalVar_27 >= 0;

                InternalField_565.Add(InternalField_569.InternalField_635[InternalVar_13].InternalField_585, new InternalType_217()
                {
                    InternalField_563 = InternalVar_15,
                    InternalField_564 = InternalVar_28 ? InternalType_216.InternalField_562 :
                            InternalVar_29 ? InternalType_216.InternalField_561 :
                            InternalType_216.InternalField_560,
                });
            }
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_1045(void* InternalParameter_1060)
        {
            UnsafeUtility.CopyPtrToStructure(InternalParameter_1060, out InternalType_218 InternalVar_1);
            InternalVar_1.Execute();
        }
    }

}
