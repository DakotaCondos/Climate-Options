using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_9
{
    internal struct InternalType_252
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const int InternalField_739 = -1;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<InternalType_131> InternalField_740;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_741;
    }

    internal partial class InternalType_227
    {
        internal struct InternalType_228 : InternalType_147
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_222> InternalField_628;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_174<InternalType_131> InternalField_629;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<int> InternalField_630;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_252> InternalField_631;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_632;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_225 InternalField_633;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NativeList<InternalType_164<InternalType_133>> InternalField_634;

            public struct InternalType_229
            {
                [ReadOnly]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<InternalType_222> InternalField_635;
                [ReadOnly]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NovaHashMap<InternalType_131, InternalType_252> InternalField_636;
                [ReadOnly]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NovaHashMap<InternalType_131, InternalType_133> InternalField_637;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_225.InternalType_226 InternalField_638;

                public InternalType_131 InternalMethod_1129(InternalType_131 InternalParameter_1209, bool InternalParameter_1210 = false)
                {
                    InternalType_131 InternalVar_1 = InternalMethod_1130(InternalParameter_1209);

                    if (!InternalParameter_1210)
                    {
                        while (InternalMethod_1131(InternalVar_1) && InternalField_637.TryGetValue(InternalVar_1, out InternalType_133 InternalVar_2))
                        {
                            InternalVar_1 = InternalField_635[InternalVar_2].InternalField_586;
                        }
                    }

                    return InternalVar_1;
                }

                public InternalType_131 InternalMethod_1130(InternalType_131 InternalParameter_1211)
                {
                    if (InternalField_637.TryGetValue(InternalParameter_1211, out InternalType_133 InternalVar_1))
                    {
                        if (InternalVar_1 < 0 || InternalVar_1 > InternalField_635.Length)
                        {
                            return InternalType_131.InternalField_415;
                        }

                        return InternalField_635[InternalVar_1].InternalField_586;
                    }

                    return InternalType_131.InternalField_415;
                }

                public bool InternalMethod_1131(InternalType_131 InternalParameter_1212)
                {
                    if (InternalField_637.TryGetValue(InternalParameter_1212, out InternalType_133 InternalVar_1))
                    {
                        return InternalMethod_1132(InternalField_635[InternalVar_1].InternalField_586);
                    }

                    return false;
                }

                public bool InternalMethod_1132(InternalType_131 InternalParameter_1213)
                {
                    return InternalField_636.ContainsKey(InternalParameter_1213);
                }

                public bool InternalMethod_3603(InternalType_133 InternalParameter_3345, InternalType_131 InternalParameter_3346, out InternalType_131 InternalParameter_3347)
                {
                    return InternalType_228.InternalMethod_3602(ref InternalField_635, ref InternalField_637, InternalParameter_3345, InternalParameter_3346, out InternalParameter_3347);
                }

                public InternalType_229(in InternalType_228 InternalParameter_1216)
                {
                    InternalField_635 = InternalParameter_1216.InternalField_628;
                    InternalField_636 = InternalParameter_1216.InternalField_631;
                    InternalField_637 = InternalParameter_1216.InternalField_632;
                    InternalField_638 = InternalParameter_1216.InternalField_633.InternalMethod_1060();
                }
            }

            public InternalType_229 InternalMethod_1120() => new InternalType_229(this);

            public bool InternalMethod_1121(InternalType_131 InternalParameter_1200)
            {
                if (InternalField_632.TryGetValue(InternalParameter_1200, out InternalType_133 InternalVar_1))
                {
                    return InternalMethod_1122(InternalField_628[InternalVar_1].InternalField_586);
                }

                return false;
            }

            public bool InternalMethod_1122(InternalType_131 InternalParameter_1201)
            {
                return InternalField_631.ContainsKey(InternalParameter_1201);
            }

            
            public InternalType_131 InternalMethod_1123(InternalType_131 InternalParameter_1202, bool InternalParameter_1203 = false)
            {
                InternalType_131 InternalVar_1 = InternalMethod_1125(InternalParameter_1202);

                if (!InternalParameter_1203)
                {
                    while (InternalMethod_1121(InternalVar_1) && InternalField_632.TryGetValue(InternalVar_1, out InternalType_133 InternalVar_2))
                    {
                        InternalVar_1 = InternalField_628[InternalVar_2].InternalField_586;
                    }
                }

                return InternalVar_1;
            }

            
            public InternalType_131 InternalMethod_1124(InternalType_133 InternalParameter_1204, bool InternalParameter_1205 = false)
            {
                InternalType_131 InternalVar_1 = InternalMethod_1126(InternalParameter_1204);

                if (!InternalParameter_1205)
                {
                    while (InternalMethod_1121(InternalVar_1) && InternalField_632.TryGetValue(InternalVar_1, out InternalType_133 InternalVar_2))
                    {
                        InternalVar_1 = InternalField_628[InternalVar_2].InternalField_586;
                    }
                }

                return InternalVar_1;
            }

            public InternalType_131 InternalMethod_1125(InternalType_131 InternalParameter_1206)
            {
                if (InternalField_632.TryGetValue(InternalParameter_1206, out InternalType_133 InternalVar_1))
                {
                    if (InternalVar_1 < 0 || InternalVar_1 > InternalField_628.Length)
                    {
                        return InternalType_131.InternalField_415;
                    }

                    return InternalField_628[InternalVar_1].InternalField_586;
                }

                return InternalType_131.InternalField_415;
            }

            public InternalType_131 InternalMethod_1126(InternalType_133 InternalParameter_1207)
            {
                if (!InternalParameter_1207.InternalProperty_194)
                {
                    return InternalType_131.InternalField_415;
                }

                return InternalField_628.ElementAt(InternalParameter_1207).InternalField_586;
            }

            public static bool InternalMethod_3602(ref NativeList<InternalType_222> InternalParameter_3340, ref NovaHashMap<InternalType_131, InternalType_133> InternalParameter_3341, InternalType_133 InternalParameter_3342, InternalType_131 InternalParameter_3343, out InternalType_131 InternalParameter_3344)
            {
                InternalType_222 InternalVar_1 = InternalParameter_3340[InternalParameter_3342];

                if (InternalVar_1.InternalField_585 == InternalParameter_3343)
                {
                    InternalParameter_3344 = InternalVar_1.InternalField_585;
                    return true;
                }

                while (InternalVar_1.InternalField_586.InternalProperty_192)
                {
                    if (InternalVar_1.InternalField_586 == InternalParameter_3343)
                    {
                        InternalParameter_3344 = InternalVar_1.InternalField_585;
                        return true;
                    }

                    InternalVar_1 = InternalParameter_3340[InternalParameter_3341[InternalVar_1.InternalField_586]];
                }

                InternalParameter_3344 = InternalType_131.InternalField_415;
                return false;
            }

            public InternalType_164<InternalType_133> InternalMethod_1127()
            {
                if (InternalField_634.Length == 0)
                {
                    return new InternalType_164<InternalType_133>(0, Allocator.Persistent);
                }

                InternalType_164<InternalType_133> InternalVar_1 = InternalField_634.InternalMethod_1018();
                InternalField_634.InternalMethod_1019();

                InternalVar_1.InternalMethod_705();

                return InternalVar_1;
            }

            public void InternalMethod_1128(ref InternalType_164<InternalType_133> InternalParameter_1208)
            {
                InternalField_634.Add(InternalParameter_1208);
            }

            public void InternalMethod_702()
            {
                InternalField_634 = new NativeList<InternalType_164<InternalType_133>>(InternalType_178.InternalField_3013, Allocator.Persistent);
                InternalField_628 = new NativeList<InternalType_222>(InternalType_178.InternalField_3013, Allocator.Persistent);
                InternalField_630 = new NativeList<int>(InternalType_178.InternalField_3013, Allocator.Persistent);
                InternalField_629 = InternalType_174<InternalType_131>.InternalMethod_841(InternalType_178.InternalField_3012);
                InternalField_632 = new NovaHashMap<InternalType_131, InternalType_133>(InternalType_178.InternalField_3013, Allocator.Persistent);
                InternalField_631 = new NovaHashMap<InternalType_131, InternalType_252>(InternalType_178.InternalField_3011, Allocator.Persistent);
                InternalField_633.InternalMethod_702();
            }

            public void Dispose()
            {
                InternalField_631.Dispose();
                InternalField_632.Dispose();
                InternalField_634.InternalMethod_1022();
                InternalField_630.Dispose();
                InternalField_628.InternalMethod_1022();
                InternalField_629.Dispose();
                InternalField_633.Dispose();
            }
        }
    }
}
