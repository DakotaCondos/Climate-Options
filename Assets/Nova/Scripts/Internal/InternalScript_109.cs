using AOT;
using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Nova.InternalNamespace_0.InternalNamespace_11
{
    [BurstCompile]
    internal unsafe struct InternalType_433<T57,T58,T59> : IJob
        where T57 : struct, InternalType_437<T58, T59>
        where T59 : unmanaged, IComparer<T59>
        where T58 : unmanaged
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T57 InternalField_1665;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_133> InternalField_1666;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<T59> InternalField_1667;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_447> InternalField_1668;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1669;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_222> InternalField_1670;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_133> InternalField_1671;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private T58 InternalField_1672;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private T59 InternalField_1673;

        public void Execute()
        {
            InternalField_1666.Clear();
            InternalField_1667.Clear();

            InternalField_1672 = InternalField_1665.InternalMethod_1710();

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1669.Length; ++InternalVar_1)
            {
                InternalField_1666.Add(InternalField_1671[InternalField_1669[InternalVar_1]]);
            }

            InternalMethod_1700();

            InternalField_1667.Sort(default(T59));

            InternalField_1666.Clear();
        }

        private void InternalMethod_1700()
        {
            int InternalVar_1 = InternalField_1666.Length;
            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; ++InternalVar_2)
            {
                InternalType_133 InternalVar_3 = InternalField_1666[InternalVar_2];
                InternalType_222 InternalVar_4 = InternalField_1670[InternalVar_3];

                InternalType_164<InternalType_133> InternalVar_5 = InternalVar_4.InternalField_587;

                T58 InternalVar_6;
                if (InternalVar_5.InternalProperty_216 > 0)
                {
                    if (!InternalField_1665.InternalMethod_1712(ref InternalField_1672, InternalVar_3, InternalVar_4.InternalField_585, out InternalVar_6))
                    {
                        continue;
                    }

                    InternalType_447 InternalVar_7 = InternalField_1665.InternalMethod_1711(ref InternalVar_6, InternalVar_3);

                    InternalVar_1 += InternalMethod_1701(ref InternalVar_5, InternalVar_7);
                }
                else
                {
                    InternalField_1665.InternalMethod_1714(ref InternalField_1672, InternalVar_3, out InternalVar_6);
                }

                InternalMethod_1702(ref InternalVar_6, InternalVar_3, InternalVar_4.InternalField_585);
            }
        }

        private int InternalMethod_1701(ref InternalType_164<InternalType_133> InternalParameter_1922, InternalType_447 InternalParameter_1923)
        {
            int InternalVar_1 = InternalParameter_1922.InternalProperty_216;

            int InternalVar_2 = 0;
            for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_1; ++InternalVar_3)
            {
                InternalType_133 InternalVar_4 = InternalParameter_1922[InternalVar_3];
                if (!InternalField_1668[InternalVar_4].InternalMethod_1736(InternalParameter_1923))
                {
                    continue;
                }

                InternalField_1666.Add(InternalVar_4);
                InternalVar_2++;
            }

            return InternalVar_2;
        }

        private void InternalMethod_1702(ref T58 InternalParameter_1924, InternalType_133 InternalParameter_1925, InternalType_131 InternalParameter_1926)
        {
            if (!InternalField_1665.InternalMethod_1713(ref InternalParameter_1924, InternalParameter_1925, InternalParameter_1926, out InternalField_1673))
            {
                return;
            }

            InternalField_1667.Add(InternalField_1673);
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_1703(void* InternalParameter_1927)
        {
            UnsafeUtility.AsRef<InternalType_433<T57, T58, T59>>(InternalParameter_1927).Execute();
        }
    }
}
