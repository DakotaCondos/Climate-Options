using AOT;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Nova.InternalNamespace_0.InternalNamespace_12
{
    internal partial class InternalType_479
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_175> InternalField_2164; 

        public struct InternalType_480 : InternalType_147
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_3639;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_131> InternalField_3628;
            
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        public NativeList<InternalType_133> InternalField_2165;
            
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        private NativeList<int> InternalField_2166;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<UnsafeAtomicCounter32> InternalField_2167;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_131> InternalField_3629;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_481 InternalField_2169;

            public void InternalMethod_1916()
            {
                InternalField_2169.InternalField_2174 = InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_596;

                unsafe
                {
                    InternalField_2164.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_2169));
                }
            }

            public void InternalMethod_702()
            {
                InternalField_2165 = new NativeList<InternalType_133>(InternalType_178.InternalField_3013, Allocator.Persistent);
                InternalField_3639 = new NativeList<InternalType_133>(InternalType_178.InternalField_3013, Allocator.Persistent);
                InternalField_3628 = new NativeList<InternalType_131>(InternalType_178.InternalField_3013, Allocator.Persistent);

                InternalField_2166 = new NativeList<int>(InternalType_178.InternalField_3012, Allocator.Persistent);
                InternalField_2167 = new NativeList<UnsafeAtomicCounter32>(InternalType_178.InternalField_3012, Allocator.Persistent);
                InternalField_3629 = new NativeList<InternalType_131>(InternalType_178.InternalField_3012, Allocator.Persistent);

                InternalField_2169 = new InternalType_481()
                {
                    InternalField_2170 = InternalField_2165,
                    InternalField_3631 = InternalField_3639,
                    InternalField_3630 = InternalField_3628,

                    InternalField_2171 = InternalField_2166,
                    InternalField_2172 = InternalField_2167,
                    InternalField_2173 = InternalField_3629,
                };
            }

            public void Dispose()
            {
                InternalField_2165.Dispose();
                InternalField_3639.Dispose();
                InternalField_3628.Dispose();

                InternalField_2166.Dispose();
                InternalField_2167.Dispose();
                InternalField_3629.Dispose();
            }

            [BurstCompile]
            public struct InternalType_481 : InternalType_192
            {
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<InternalType_133> InternalField_2170;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<InternalType_131> InternalField_3630;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<InternalType_133> InternalField_3631;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<int> InternalField_2171;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<UnsafeAtomicCounter32> InternalField_2172;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<InternalType_131> InternalField_2173;

                [ReadOnly]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<InternalType_131> InternalField_2174;

                public unsafe void Execute()
                {
                    InternalField_2170.Clear();
                    InternalField_3630.Clear();
                    InternalField_3631.Clear();

                    int InternalVar_1 = InternalField_2174.Length;

                    InternalField_2171.Length = InternalVar_1;
                    InternalField_2172.Length = InternalVar_1;
                    InternalField_2173.Length = InternalVar_1;

                    int* InternalVar_2 = (int*)InternalField_2171.GetUnsafePtr();
                    for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_1; ++InternalVar_3)
                    {
                        InternalField_2173[InternalVar_3] = InternalType_131.InternalField_415;
                        InternalField_2171[InternalVar_3] = 0;
                        InternalField_2172[InternalVar_3] = new UnsafeAtomicCounter32(InternalVar_2 + InternalVar_3);
                    }
                }

                [BurstCompile]
                [MonoPInvokeCallback(typeof(InternalType_175))]
                public static unsafe void InternalMethod_1917(void* InternalParameter_2145)
                {
                    UnsafeUtility.CopyPtrToStructure(InternalParameter_2145, out InternalType_481 InternalVar_1);
                    InternalVar_1.Execute();
                }
            }
        }
    }
}
