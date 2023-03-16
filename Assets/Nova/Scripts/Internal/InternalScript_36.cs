using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;

namespace Nova.InternalNamespace_0.InternalNamespace_2
{
    internal partial interface InternalType_141 : InternalType_134
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        Transform InternalProperty_202 { get; }
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalProperty_203 { get; }
    }

    internal struct InternalType_142
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_426;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_427;

        public override string ToString()
        {
            return $"Virtual: {InternalField_426}, Index: {InternalField_427}";
        }
    }

    
    internal abstract partial class InternalType_143<T12,T13> : InternalType_129<T12, T13>
        where T12 : InternalType_129<T12, T13>
        where T13 : InternalType_141
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<float4x4> InternalField_430;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_431;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_142> InternalField_432;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public TransformAccessArray InternalField_433;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_133> InternalField_434;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_133> InternalField_435;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_205 => InternalField_432.Length;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_144 InternalProperty_206 { get; } = new InternalType_144();

        protected override void InternalMethod_615(T13 InternalParameter_499)
        {
            int InternalVar_1;
            if (InternalParameter_499.InternalProperty_203)
            {
                InternalVar_1 = InternalField_435.Length;
                InternalField_435.Add(InternalField_432.Length);
            }
            else 
            {
                InternalVar_1 = InternalField_433.length;
                InternalField_433.Add(InternalParameter_499.InternalProperty_202);
                InternalField_434.Add(InternalField_432.Length);
            }

            InternalField_432.Add(new InternalType_142()
            {
                InternalField_426 = InternalParameter_499.InternalProperty_203,
                InternalField_427 = InternalVar_1
            });

            if (NovaApplication.IsEditor)
            {
                InternalProperty_206.InternalMethod_685(InternalParameter_499);
            }

            InternalField_430.Add(float4x4.identity);
            InternalField_431.Add(float4x4.identity);
        }

        
        protected int InternalMethod_681(T13 InternalParameter_547)
        {
            int InternalVar_1;
            if (InternalParameter_547.InternalProperty_203)
            {
                InternalVar_1 = InternalField_435.Length;
            }
            else 
            {
                InternalVar_1 = InternalField_433.length;
                InternalField_433.Add(InternalParameter_547.InternalProperty_202);
            }

            return InternalVar_1;
        }

        public float4x4 InternalMethod_682(T13 InternalParameter_548)
        {
            if (!InternalParameter_548.InternalProperty_196.InternalProperty_194)
            {
                return float4x4.identity;
            }

            return InternalField_431.ElementAt(InternalParameter_548.InternalProperty_196);
        }

        protected override void InternalMethod_616(InternalType_131 InternalParameter_500, InternalType_133 InternalParameter_501)
        {
            InternalType_142 InternalVar_1 = InternalField_432[InternalParameter_501];

            InternalField_432.RemoveAtSwapBack(InternalParameter_501);
            InternalField_430.RemoveAtSwapBack(InternalParameter_501);
            InternalField_431.RemoveAtSwapBack(InternalParameter_501);

            if (InternalParameter_501 < InternalField_432.Length) 
            {
                InternalType_142 InternalVar_2 = InternalField_432[InternalParameter_501];

                if (InternalVar_2.InternalField_426)
                {
                    InternalField_435[InternalVar_2.InternalField_427] = InternalParameter_501;
                }
                else
                {
                    InternalField_434[InternalVar_2.InternalField_427] = InternalParameter_501;
                }
            }

            int InternalVar_3 = -1;
            if (InternalVar_1.InternalField_426)
            {
                InternalField_435.RemoveAtSwapBack(InternalVar_1.InternalField_427);

                if (InternalVar_1.InternalField_427 < InternalField_435.Length) 
                {
                    InternalVar_3 = InternalField_435[InternalVar_1.InternalField_427];
                }
            }
            else
            {
                if (NovaApplication.IsEditor)
                {
                    InternalProperty_206.InternalMethod_1961(InternalParameter_500, InternalField_433[InternalVar_1.InternalField_427]);
                }

                InternalField_433.RemoveAtSwapBack(InternalVar_1.InternalField_427);
                InternalField_434.RemoveAtSwapBack(InternalVar_1.InternalField_427);

                if (InternalVar_1.InternalField_427 < InternalField_434.Length) 
                {
                    InternalVar_3 = InternalField_434[InternalVar_1.InternalField_427];
                }
            }

            if (InternalVar_3 >= 0 && InternalVar_3 < InternalField_432.Length)
            {
                InternalType_142 InternalVar_4 = InternalField_432[InternalVar_3];
                InternalVar_4.InternalField_427 = InternalVar_1.InternalField_427;
                InternalField_432[InternalVar_3] = InternalVar_4;
            }
        }

        public Transform InternalMethod_1963(InternalType_133 InternalParameter_1319)
        {
            if (!InternalParameter_1319.InternalProperty_194)
            {
                return null;
            }

            InternalType_142 InternalVar_1 = InternalField_432[InternalParameter_1319];

            if (InternalVar_1.InternalField_426)
            {
                return null;
            }

            return InternalField_433[InternalVar_1.InternalField_427];
        }

        public override void InternalMethod_702()
        {
            base.InternalMethod_702();
            InternalField_432 = new NativeList<InternalType_142>(InternalType_178.InternalField_3013, Allocator.Persistent);
            InternalField_430 = new NativeList<float4x4>(InternalType_178.InternalField_3013, Allocator.Persistent);
            InternalField_431 = new NativeList<float4x4>(InternalType_178.InternalField_3013, Allocator.Persistent);
            InternalField_433 = new TransformAccessArray(InternalType_178.InternalField_3013);
            InternalField_434 = new NativeList<InternalType_133>(InternalType_178.InternalField_3013, Allocator.Persistent);
            InternalField_435 = new NativeList<InternalType_133>(InternalType_178.InternalField_3013, Allocator.Persistent);

            if (NovaApplication.IsEditor)
            {
                InternalProperty_206.InternalMethod_687(this);
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            InternalField_432.Dispose();
            InternalField_430.Dispose();
            InternalField_431.Dispose();
            InternalField_433.Dispose();
            InternalField_434.Dispose();
            InternalField_435.Dispose();

            if (NovaApplication.IsEditor)
            {
                InternalProperty_206.InternalMethod_688();
            }
        }
    }
}