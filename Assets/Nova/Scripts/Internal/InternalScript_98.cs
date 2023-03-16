using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Nova.InternalNamespace_0.InternalNamespace_9
{
    internal static class InternalType_223
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const int InternalField_588 = -1;
    }

    internal struct InternalType_224
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_589;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_590;


        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_224 InternalField_591 = new InternalType_224()
        {
            InternalField_589 = InternalType_131.InternalField_415,
            InternalField_590 = -1,
        };

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_224 InternalField_592 = new InternalType_224()
        {
            InternalField_589 = InternalType_131.InternalField_415,
            InternalField_590 = -1
        };
    }

    
    internal struct InternalType_225 : InternalType_147, InternalType_132
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeReference<bool> InternalField_593;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_193 => InternalField_593.Value && InternalField_596.InternalProperty_240 > 0;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_224> InternalField_594;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_220> InternalField_595;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_174<InternalType_131> InternalField_596;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_174<InternalType_131> InternalField_597;
        public InternalType_226 InternalMethod_1060() => new InternalType_226(this);

        
        public void InternalMethod_1061(InternalType_131 InternalParameter_1070, InternalType_133 InternalParameter_1071)
        {
            if (!InternalField_596.InternalMethod_837(InternalParameter_1070))
            {
                return;
            }

            InternalMethod_1067(InternalParameter_1070);
            InternalMethod_1065(InternalParameter_1071);
        }

        public void InternalMethod_635()
        {
            InternalField_597.InternalMethod_840();
            InternalField_593.Value = false;

            unsafe
            {
                UnsafeUtility.MemSet(InternalField_595.GetUnsafePtr(), 0, InternalField_595.Length * UnsafeUtility.SizeOf<InternalType_220>());
            }
        }

        
        public void InternalMethod_1062(InternalType_131 InternalParameter_1072, InternalType_133 InternalParameter_1073)
        {
            if (!InternalField_596.InternalMethod_838(InternalParameter_1072))
            {
                return;
            }

            InternalMethod_1067(InternalParameter_1072);
            InternalMethod_1065(InternalParameter_1073);
        }

        
        public void InternalMethod_1063()
        {
            InternalField_594.Add(InternalType_224.InternalField_592);
            InternalField_595.Add(InternalType_220.InternalField_581);

            InternalField_593.Value = true;
        }

        
        public void InternalMethod_1064(InternalType_133 InternalParameter_1074)
        {
            InternalType_224 InternalVar_1 = InternalField_594[InternalParameter_1074];

            InternalField_594.RemoveAtSwapBack(InternalParameter_1074);
            InternalField_595.RemoveAtSwapBack(InternalParameter_1074);

            InternalMethod_1067(InternalVar_1.InternalField_589);

            InternalField_593.Value = true;
        }

        public void InternalMethod_1065(InternalType_133 InternalParameter_1075)
        {
            if (!InternalParameter_1075.InternalProperty_194)
            {
                return;
            }

            InternalField_595[InternalParameter_1075] = InternalType_220.InternalField_581;

            InternalMethod_1067(InternalField_594[InternalParameter_1075].InternalField_589);
        }

        public void InternalMethod_1066(InternalType_133 InternalParameter_1076, InternalType_133 InternalParameter_1077)
        {
            InternalMethod_1065(InternalParameter_1076);
            InternalMethod_1065(InternalParameter_1077);
        }

        public void InternalMethod_1067(InternalType_131 InternalParameter_1078)
        {
            if (!InternalParameter_1078.InternalProperty_192)
            {
                return;
            }

            InternalField_597.InternalMethod_837(InternalParameter_1078);
            InternalField_593.Value = true;
        }

        public void InternalMethod_702()
        {
            InternalField_594 = new NativeList<InternalType_224>(InternalType_178.InternalField_3013, Allocator.Persistent);
            InternalField_595 = new NativeList<InternalType_220>(InternalType_178.InternalField_3013, Allocator.Persistent);
            InternalField_596 = InternalType_174<InternalType_131>.InternalMethod_841(InternalType_178.InternalField_3012);

            InternalField_593 = new NativeReference<bool>(Allocator.Persistent);
            InternalField_597 = InternalType_174<InternalType_131>.InternalMethod_841(InternalType_178.InternalField_3012);
        }

        public void Dispose()
        {
            InternalField_594.Dispose();
            InternalField_595.Dispose();
            InternalField_596.Dispose();

            InternalField_593.Dispose();
            InternalField_597.Dispose();
        }

        public struct InternalType_226
        {
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_224> InternalField_598;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_174<InternalType_131> InternalField_599;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_174<InternalType_131> InternalField_600;

            public InternalType_226(in InternalType_225 InternalParameter_1079)
            {
                InternalField_598 = InternalParameter_1079.InternalField_594;
                InternalField_599 = InternalParameter_1079.InternalField_596;
                InternalField_600 = InternalParameter_1079.InternalField_597;
            }

            public unsafe void InternalMethod_1069(ref NativeList<InternalType_131> InternalParameter_1080)
            {
                int InternalVar_1 = InternalField_600.InternalProperty_240;
                for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; ++InternalVar_2)
                {
                    InternalType_131 InternalVar_3 = InternalField_600[InternalVar_2];

                    if (!InternalField_599.InternalMethod_839(InternalVar_3))
                    {
                        continue;
                    }

                    InternalParameter_1080.Add(InternalVar_3);

                }
            }
        }
    }
}
