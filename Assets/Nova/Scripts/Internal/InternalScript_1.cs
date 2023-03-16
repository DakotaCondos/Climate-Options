using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System;

namespace Nova.InternalNamespace_0.InternalNamespace_4
{
    
    [Serializable]
    internal class InternalType_154<T16>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const int InternalField_446 = 4;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_223 { get; private set; } = 0;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_224 => InternalField_447.Length;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private T16[] InternalField_447 = new T16[InternalField_446];
        public T16 this[int InternalParameter_567]
        {
            get
            {
                if (InternalParameter_567 < 0 || InternalParameter_567 >= InternalProperty_223)
                {
                    throw new ArgumentOutOfRangeException("index", $"Attemping to get element at index: {InternalParameter_567}. Index must be within range [0, {InternalProperty_223 - 1}] for this ArrayBuffer instance.");
                }

                return InternalField_447[InternalParameter_567];
            }
            set
            {
                if (InternalParameter_567 < 0 || InternalParameter_567 >= InternalProperty_223)
                {
                    throw new ArgumentOutOfRangeException("index", $"Attemping to set element at index: {InternalParameter_567}. Index must be within range [0, {InternalProperty_223 - 1}] for this ArrayBuffer instance.");
                }

                InternalField_447[InternalParameter_567] = value;
            }
        }

        public void InternalMethod_732(T16 InternalParameter_568)
        {
            if (InternalField_447 == null || InternalProperty_223 == InternalField_447.Length)
            {
                InternalMethod_738();
            }

            InternalField_447[InternalProperty_223++] = InternalParameter_568;
        }

        public void InternalMethod_733(int InternalParameter_569)
        {
            if (InternalParameter_569 < 0 || InternalParameter_569 >= InternalProperty_223)
            {
                return;
            }

            InternalField_447[InternalParameter_569] = InternalField_447[--InternalProperty_223];
        }

        public void InternalMethod_2044(InternalType_521<T16> InternalParameter_2368)
        {
            if (InternalField_447 == null || InternalProperty_223 + InternalParameter_2368.InternalProperty_433 > InternalField_447.Length)
            {
                InternalMethod_737(InternalProperty_223 + InternalParameter_2368.InternalProperty_433);
            }

            InternalParameter_2368.InternalMethod_2046(InternalField_447, InternalProperty_223);

            InternalProperty_223 += InternalParameter_2368.InternalProperty_433;
        }

        public void InternalMethod_735()
        {
            InternalField_447.InternalMethod_967(default);
            InternalProperty_223 = 0;
        }

        public T16[] InternalMethod_736()
        {
            return InternalField_447;
        }

        private void InternalMethod_737(int InternalParameter_571)
        {
            T16[] InternalVar_1 = new T16[InternalParameter_571];
            Array.Copy(InternalField_447, InternalVar_1, InternalField_447.Length);
            InternalField_447 = InternalVar_1;
        }

        private void InternalMethod_738()
        {
            InternalMethod_737(2 * InternalField_447.Length);
        }
    }
}
