#define CACHE_NAME

using Nova.InternalNamespace_0;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using System;
using System.Diagnostics;
using UnityEngine;

namespace Nova
{
    
    [Serializable]
    internal abstract class InternalType_34 : InternalType_145, IDisposable
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const int InternalField_121 = -1;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalType_145.InternalProperty_208 => false;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalType_145.InternalProperty_207 => InternalProperty_82.InternalProperty_197 && InternalProperty_82.InternalProperty_210 == null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        InternalType_145 InternalType_145.InternalProperty_211 => InternalType_253.InternalProperty_190.InternalMethod_1157(InternalProperty_83);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        InternalType_145 InternalType_145.InternalProperty_210 => InternalType_253.InternalProperty_190.InternalMethod_1158(InternalProperty_83);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_122 = InternalField_121;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_209 => InternalField_122;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private protected InternalType_145 InternalProperty_82
        {
            get
            {
                return this;
            }
        }

        public void InternalMethod_282(int InternalParameter_208)
        {
            InternalField_122 = InternalParameter_208;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalType_68.InternalProperty_151 => true;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalType_68.InternalProperty_152 => InternalProperty_82.InternalProperty_210 == null || InternalProperty_82.InternalProperty_210.InternalProperty_152;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalType_68.InternalProperty_153 => true;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalType_68.InternalProperty_154 => InternalProperty_85;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        Transform InternalType_141.InternalProperty_202 => null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalType_141.InternalProperty_203 => true;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalType_141.InternalProperty_204 => true;

        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_131 InternalField_123 = InternalType_131.InternalField_415;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        InternalType_131 InternalType_134.InternalProperty_195 => InternalProperty_83;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal InternalType_131 InternalProperty_83
        {
            get
            {
                if (!InternalField_123.InternalProperty_192)
                {
                    InternalField_123 = InternalType_131.InternalMethod_630();
                }

                return InternalField_123;
            }
        }

        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_133 InternalField_124;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        InternalType_133 InternalType_134.InternalProperty_196 => InternalField_124;
        void InternalType_134.InternalMethod_642(InternalType_133 InternalParameter_525) => InternalField_124 = InternalParameter_525;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalType_134.InternalProperty_197 => InternalType_253.InternalProperty_190.InternalMethod_625(this);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        string InternalType_135.InternalProperty_198 => InternalProperty_82.InternalProperty_210 != null ? $"{InternalProperty_82.InternalProperty_210.InternalProperty_198}.Virtual({InternalProperty_82.InternalProperty_209})" : "Detached Virtual Block";


        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal int InternalProperty_84 => InternalType_253.InternalProperty_190.InternalMethod_1160(InternalProperty_83);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]

        [field: NonSerialized]
        private protected bool InternalProperty_85 { get; private set; } = false;

        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private protected bool InternalField_125 = false;
        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_126 = false;
        public void InternalMethod_287()
        {
            if (InternalField_126 || InternalField_125)
            {
                return;
            }

            InternalField_126 = true;


            InternalProperty_85 = false;

            InternalProperty_82.InternalMethod_644();

            InternalField_125 = true;
            InternalField_126 = false;
        }

        void InternalType_134.InternalMethod_644() => InternalMethod_288();
        void InternalType_134.InternalMethod_645() => InternalMethod_289();

        private protected abstract void InternalMethod_288();
        private protected abstract void InternalMethod_289();
        internal abstract void InternalMethod_290();
        private protected abstract void InternalMethod_291(InternalType_131 InternalParameter_209);
        private protected abstract void InternalMethod_292();
        internal abstract InternalType_34 InternalMethod_293();

        public void Dispose()
        {
            InternalProperty_85 = true;

            InternalProperty_82.InternalMethod_645();

            InternalField_125 = false;
            InternalField_126 = false;
        }

    }
}
