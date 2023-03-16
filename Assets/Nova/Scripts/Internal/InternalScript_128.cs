using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Nova.InternalNamespace_0.InternalNamespace_12
{
    internal partial class InternalType_460
    {
        [BurstCompile]
        internal struct InternalType_474 : InternalType_193
        {
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_224> InternalField_2122;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_2123;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, int> InternalField_2124;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2125;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_2126;

            
            [NativeDisableContainerSafetyRestriction]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<UnsafeAtomicCounter32> InternalField_2127;
            public void Execute(int dirtyIndex)
            {
                InternalType_133 InternalVar_1 = InternalField_2123[dirtyIndex];
                InternalType_224 InternalVar_2 = InternalField_2122[InternalVar_1];
                InternalType_131 InternalVar_3 = InternalVar_2.InternalField_589;

                if (!InternalVar_3.InternalProperty_192)
                {
                    UnityEngine.Debug.LogError("Batch Root ID invalid");
                    return;
                }

                int InternalVar_4 = InternalField_2124[InternalVar_3];
                InternalField_2127.ElementAt(InternalVar_4).Add(1);

                InternalType_133 InternalVar_5 = InternalField_2126[InternalVar_3];
                InternalType_131 InternalVar_6 = InternalField_2125[InternalVar_5].InternalField_586;
                while (InternalVar_6.InternalProperty_192)
                {
                    InternalType_133 InternalVar_7 = InternalField_2126[InternalVar_6];
                    InternalType_131 InternalVar_8 = InternalField_2122[InternalVar_7].InternalField_589;
                    InternalVar_6 = InternalField_2125[InternalVar_7].InternalField_586;

                    int InternalVar_9 = InternalField_2124[InternalVar_8];
                    InternalField_2127.ElementAt(InternalVar_9).Add(1);
                }
            }
        }

        [BurstCompile]
        internal struct InternalType_475 : InternalType_192
        {
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_131> InternalField_2128;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_131> InternalField_2129;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<UnsafeAtomicCounter32> InternalField_2130;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_2131;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_2132;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, int> InternalField_2133;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_224> InternalField_2134;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, int> InternalField_2135;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_131> InternalField_2136;

            public void Execute()
            {
                int InternalVar_1 = InternalField_2129.Length;
                for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; ++InternalVar_2)
                {
                    InternalType_131 InternalVar_3 = InternalField_2129[InternalVar_2];

                    if (InternalField_2133.TryGetValue(InternalVar_3, out int InternalVar_4))
                    {
                        InternalField_2136[InternalVar_4] = InternalVar_3;
                    }
                }

                int InternalVar_5 = InternalField_2128.Length;
                for (int InternalVar_6 = 0; InternalVar_6 < InternalVar_5; ++InternalVar_6)
                {
                    InternalType_131 InternalVar_7 = InternalField_2128[InternalVar_6];

                    InternalType_131 InternalVar_8 = InternalVar_7;
                    int InternalVar_9 = InternalVar_6;

                    while (InternalVar_8.InternalProperty_192)
                    {
                        unsafe
                        {
                            if (*InternalField_2130[InternalVar_9].Counter >= 1)
                            {
                                InternalField_2136[InternalVar_6] = InternalVar_7;
                                break;
                            }
                        }

                        InternalType_133 InternalVar_10 = InternalField_2132[InternalVar_8];
                        InternalType_131 InternalVar_11 = InternalField_2131[InternalVar_10].InternalField_586;

                        if (!InternalField_2132.TryGetValue(InternalVar_11, out InternalType_133 InternalVar_12))
                        {
                            break;
                        }

                        InternalVar_8 = InternalField_2134[InternalVar_12].InternalField_589;
                        InternalVar_9 = InternalField_2135[InternalVar_8];
                    }
                }

                for (int InternalVar_6 = InternalField_2136.Length - 1; InternalVar_6 >= 0; --InternalVar_6)
                {
                    if (!InternalField_2136[InternalVar_6].InternalProperty_192)
                    {
                        InternalField_2136.RemoveAtSwapBack(InternalVar_6);
                    }
                }
            }
        }
    }
}
