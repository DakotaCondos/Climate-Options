using AOT;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_421 : InternalType_192
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_133> InternalField_1598;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_222> InternalField_1599;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_79> InternalField_2238;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_55> InternalField_1600;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_54> InternalField_1601;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53> InternalField_1602;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_99> InternalField_1603;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_670> InternalField_761;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_172<InternalType_131, InternalType_670>> InternalField_387;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_161<InternalType_348, bool2> InternalField_2237;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<InternalType_172<InternalType_131, float2>> InternalField_2236;


        public void Execute()
        {
            InternalField_387.Clear();

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_761.InternalProperty_216; ++InternalVar_1)
            {
                InternalType_348 InternalVar_2 = InternalVar_1;
                InternalType_133 InternalVar_3 = InternalField_1598[InternalVar_2];

                InternalMethod_1671(InternalVar_3, InternalVar_2);
            }
        }

        public void InternalMethod_1671(InternalType_133 InternalParameter_1851, InternalType_348 InternalParameter_1852)
        {
            InternalType_448.InternalType_449 InternalVar_1 = InternalType_448.InternalMethod_1749(InternalParameter_1851, ref InternalField_1602, ref InternalField_1600);
            InternalVar_1.InternalMethod_1807(ref InternalField_1601);
            InternalVar_1.InternalMethod_1796(ref InternalField_1603);

            bool2 InternalVar_2 = InternalVar_1.InternalProperty_354.InternalProperty_177.xy;
            InternalType_670 InternalVar_3 = InternalType_670.InternalMethod_2348(InternalVar_1.InternalProperty_376.InternalProperty_124.xy, InternalVar_1.InternalProperty_364.InternalProperty_121.xy, InternalVar_2);
            ref InternalType_670 InternalVar_4 = ref InternalField_761.InternalMethod_748(InternalParameter_1852);

            ref bool2 InternalVar_5 = ref InternalField_2237.InternalMethod_748(InternalParameter_1852);

            if (!InternalVar_2.Equals(InternalVar_5))
            {
                bool2 InternalVar_6 = InternalVar_2 & !InternalVar_5 & InternalVar_1.InternalProperty_376.InternalProperty_124.xy == float2.zero;

                if (math.any(InternalVar_6))
                {
                    InternalField_2236.Add(new InternalType_172<InternalType_131, float2>(InternalField_1599[InternalParameter_1851].InternalField_585, InternalField_2238[InternalParameter_1852].InternalField_262.InternalMethod_1363().xy));
                }

                InternalVar_5 = InternalVar_2;
            }




            if (InternalVar_3 == InternalVar_4)
            {
                return;
            }

            InternalVar_4 = InternalVar_3;

            InternalField_387.Add(new InternalType_172<InternalType_131, InternalType_670>(InternalField_1599[InternalParameter_1851].InternalField_585, InternalVar_3));
        }

        public struct InternalType_422
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_299<InternalType_71>> InternalField_1606;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_1607;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void InternalType_423(void* jobData, void* dirtyElements);


        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_423))]
        public static unsafe void InternalMethod_1672(void* InternalParameter_1853, void* InternalParameter_1854)
        {
            UnsafeUtility.CopyPtrToStructure(InternalParameter_1853, out InternalType_421 InternalVar_1);
            UnsafeUtility.CopyPtrToStructure(InternalParameter_1854, out InternalType_422 InternalVar_2);

            InternalVar_1.InternalField_387.Clear();

            int InternalVar_3 = InternalVar_2.InternalField_1607.Length;

            for (int InternalVar_4 = 0; InternalVar_4 < InternalVar_3; ++InternalVar_4)
            {
                InternalType_133 InternalVar_5 = InternalVar_2.InternalField_1607[InternalVar_4];
                ref InternalType_299<InternalType_71> InternalVar_6 = ref InternalVar_2.InternalField_1606.ElementAt(InternalVar_5);

                if (InternalVar_6.InternalField_983.InternalField_234 != InternalType_72.InternalField_238)
                {
                    continue;
                }

                InternalVar_1.InternalMethod_1671(InternalVar_5, InternalVar_6.InternalField_984);
            }
        }
    }
}

