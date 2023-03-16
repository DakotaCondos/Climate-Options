using AOT;
using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_329 : InternalType_147
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1129;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, int> InternalField_1130;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_275 InternalField_1131;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_362.InternalType_295 InternalField_794;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1133;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1134;

        private void InternalMethod_1475()
        {
            InternalMethod_1477();
            InternalMethod_1476();
        }

        private void InternalMethod_1476()
        {
            InternalField_1134.Clear();

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1129.Length; ++InternalVar_1)
            {
                InternalType_131 InternalVar_2 = InternalField_1129[InternalVar_1];
                if (InternalField_1131.InternalMethod_1268(InternalVar_2))
                {
                    continue;
                }

                InternalField_1134.Add(InternalVar_2);
                InternalField_1131.InternalMethod_1269(InternalVar_2);
                InternalField_794.InternalMethod_1308(InternalVar_2);
            }
        }

        private void InternalMethod_1477()
        {
            InternalField_1133.Clear();

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1131.InternalField_877.Length; ++InternalVar_1)
            {
                InternalType_131 InternalVar_2 = InternalField_1131.InternalField_877[InternalVar_1];
                if (!InternalField_1130.ContainsKey(InternalVar_2))
                {
                    InternalField_1133.Add(InternalVar_2);
                }
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1133.Length; ++InternalVar_1)
            {
                InternalType_131 InternalVar_2 = InternalField_1133[InternalVar_1];
                InternalField_1131.InternalMethod_1270(InternalVar_2);
                InternalField_794.InternalMethod_1306(InternalVar_2);
            }
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_1478(void* InternalParameter_1562)
        {
            UnsafeUtility.AsRef<InternalType_329>(InternalParameter_1562).InternalMethod_1475();
        }

        public void InternalMethod_702()
        {
            InternalField_1133.InternalMethod_1020();
            InternalField_1134.InternalMethod_1020();
        }

        public void Dispose()
        {
            InternalField_1133.Dispose();
            InternalField_1134.Dispose();
        }
    }
}

