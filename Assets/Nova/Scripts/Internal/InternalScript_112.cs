using Nova.InternalNamespace_16;
using Nova.InternalNamespace_0;
using Nova.InternalNamespace_0.InternalNamespace_4;
using System;
using System.Collections.Generic;

namespace Nova
{
    internal class InternalType_727 : InternalType_74
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private UIBlock InternalField_3233;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_522 InternalField_3182 = null;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_153<InternalType_75> InternalField_3177 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<uint, InternalType_152<InternalType_94>> InternalField_3168 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_153<uint> InternalField_3163 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<uint, InternalNamespace_0.InternalType_78> InternalField_3093 = null;

        public event InternalType_14.InternalType_12 InternalEvent_2 = null;
        public event InternalType_14.InternalType_23 InternalEvent_3 = null;
        public event InternalType_14.InternalType_25 InternalEvent_4 = null;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        InternalType_521<InternalType_75> InternalType_74.InternalProperty_164 => InternalField_3177 == null ? InternalType_521<InternalType_75>.InternalProperty_435 : InternalField_3177.InternalProperty_221;
        void InternalType_74.InternalMethod_460(InternalType_75 InternalParameter_320)
        {
            if (InternalField_3177 == null)
            {
                InternalField_3177 = new InternalType_153<InternalType_75>(1);
            }

            InternalField_3177.Add(InternalParameter_320);
        }

        void InternalType_74.InternalMethod_461(InternalType_75 InternalParameter_321)
        {
            if (InternalField_3177 == null)
            {
                return;
            }

            InternalField_3177.Remove(InternalParameter_321);
        }

        void InternalType_74.InternalMethod_467(InternalNamespace_0.InternalType_78 InternalParameter_327)
        {
            if (InternalField_3168 == null || InternalField_3093 == null)
            {
                return;
            }

            InternalType_14.InternalType_13 InternalVar_1 = InternalType_14.InternalMethod_191(InternalField_3233, InternalParameter_327);

            if (!InternalField_3168.TryGetValue(InternalParameter_327.InternalField_257, out InternalType_152<InternalType_94> InternalVar_2) || !InternalVar_2.InternalProperty_220)
            {
                InternalEvent_4?.Invoke(ref InternalVar_1);

                return;
            }

            InternalType_169<InternalType_94>.InternalMethod_821(InternalVar_2);

            if (InternalField_3093.Remove(InternalParameter_327.InternalField_257))
            {
                InternalField_3163.Remove(InternalParameter_327.InternalField_257);
            }

            InternalField_3168.Remove(InternalParameter_327.InternalField_257);

            InternalEvent_4?.Invoke(ref InternalVar_1);
        }

        void InternalType_74.InternalMethod_468()
        {
            if (InternalField_3093 == null)
            {
                return;
            }

            InternalType_521<uint> InternalVar_1 = InternalField_3163.InternalProperty_221;

            while (InternalVar_1.InternalProperty_433 > 0)
            {
                uint InternalVar_2 = InternalVar_1[InternalVar_1.InternalProperty_433 - 1];

                ((InternalType_74)this).InternalMethod_467(InternalField_3093[InternalVar_2]);
            }
        }

        bool InternalType_74.InternalMethod_463<T>()
        {

            Type InternalVar_1 = typeof(T);

            if (InternalVar_1 == typeof(bool))
            {
                return InternalEvent_2 != null;
            }

            if (InternalVar_1 == typeof(InternalType_95<UnityEngine.Vector3>))
            {
                return InternalEvent_3 != null;
            }

            return false;
        }

        void InternalType_74.InternalMethod_466<TInput>(InternalNamespace_0.InternalType_78 InternalParameter_325, InternalType_76<TInput>? InternalParameter_326)
        {
            if (InternalField_3168 == null)
            {
                InternalField_3168 = new Dictionary<uint, InternalType_152<InternalType_94>>(1);
                InternalField_3093 = new Dictionary<uint, InternalNamespace_0.InternalType_78>(1);
                InternalField_3163 = new InternalType_153<uint>(1);
            }

            InternalType_76<TInput>? InternalVar_1 = null;

            uint InternalVar_2 = InternalParameter_325.InternalField_257;

            if (InternalField_3168.TryGetValue(InternalVar_2, out InternalType_152<InternalType_94> InternalVar_3) && InternalVar_3.InternalProperty_220)
            {
                if (InternalType_169<InternalType_94>.InternalType_171<InternalType_76<TInput>>.InternalMethod_826(InternalVar_3, out InternalType_76<TInput> InternalVar_4))
                {
                    if (InternalParameter_326.Value == InternalVar_4)
                    {
                        return;
                    }

                    InternalVar_1 = InternalVar_4;

                    InternalType_169<InternalType_94>.InternalType_171<InternalType_76<TInput>>.InternalMethod_824(InternalVar_3);
                }
                else
                {
                    InternalType_169<InternalType_94>.InternalMethod_821(InternalVar_3);
                }
            }
            else if (!InternalParameter_326.HasValue)
            {
                return;
            }

            if (InternalParameter_326.HasValue)
            {
                InternalField_3168[InternalVar_2] = InternalType_169<InternalType_94>.InternalType_171<InternalType_76<TInput>>.InternalMethod_823(InternalParameter_326.Value);
                InternalField_3163.Add(InternalVar_2);
                InternalField_3093[InternalVar_2] = InternalParameter_325;
            }
            else
            {
                InternalField_3093.Remove(InternalVar_2);
                InternalField_3163.Remove(InternalVar_2);
                InternalField_3168[InternalVar_2] = InternalType_152<InternalType_94>.InternalField_441;
            }


            Type InternalVar_5 = typeof(TInput);

            if (InternalVar_5 == typeof(bool))
            {
                InternalType_76<bool>? InternalVar_6 = null;
                InternalType_76<bool>? InternalVar_7 = null;

                if (InternalVar_1.HasValue)
                {
                    _ = InternalVar_1.Value.InternalMethod_474(out InternalVar_6);
                }

                if (InternalParameter_326.HasValue)
                {
                    _ = InternalParameter_326.Value.InternalMethod_474(out InternalVar_7);
                }

                InternalType_14.InternalType_16<bool> InternalVar_8 = InternalType_14.InternalMethod_188(InternalField_3233, InternalVar_6, InternalVar_7, InternalParameter_325);
                InternalEvent_2?.Invoke(ref InternalVar_8);

                return;
            }

            if (InternalVar_5 == typeof(InternalType_95<UnityEngine.Vector3>))
            {
                InternalType_76<InternalType_95<UnityEngine.Vector3>>? InternalVar_6 = null;
                InternalType_76<InternalType_95<UnityEngine.Vector3>>? InternalVar_7 = null;

                if (InternalVar_1.HasValue)
                {
                    _ = InternalVar_1.Value.InternalMethod_474(out InternalVar_6);
                }

                if (InternalParameter_326.HasValue)
                {
                    _ = InternalParameter_326.Value.InternalMethod_474(out InternalVar_7);
                }

                InternalType_14.InternalType_16<InternalType_95<UnityEngine.Vector3>> InternalVar_8 = InternalType_14.InternalMethod_188(InternalField_3233, InternalVar_6, InternalVar_7, InternalParameter_325);
                InternalEvent_3?.Invoke(ref InternalVar_8);

                return;
            }
        }

        InternalType_76<T>? InternalType_74.InternalMethod_464<T>(uint contextID)
        {
            if (InternalField_3168 != null && InternalField_3168.TryGetValue(contextID, out InternalType_152<InternalType_94> InternalVar_1) && InternalVar_1.InternalProperty_220)
            {
                return InternalType_169<InternalType_94>.InternalType_171<InternalType_76<T>>.InternalMethod_825(InternalVar_1);
            }

            return null;
        }

        bool InternalType_74.InternalMethod_465(uint InternalParameter_323, out InternalNamespace_0.InternalType_78 InternalParameter_324)
        {
            if (InternalField_3093 == null)
            {
                InternalParameter_324 = default;
                return false;
            }

            return InternalField_3093.TryGetValue(InternalParameter_323, out InternalParameter_324);
        }

        public InternalType_727(InternalType_522 InternalParameter_2381, UIBlock InternalParameter_2378)
        {
            this.InternalField_3182 = InternalParameter_2381;
            this.InternalField_3233 = InternalParameter_2378;
        }
    }
}
