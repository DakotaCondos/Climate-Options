using Nova.InternalNamespace_0.InternalNamespace_5;
using UnityEngine;

namespace Nova.InternalNamespace_0
{
    internal static partial class InternalType_14
    {
        public delegate void InternalType_12(ref InternalType_16<bool> evt);
        public delegate void InternalType_23(ref InternalType_16<InternalType_755<Vector3>> evt);
        
        public delegate void InternalType_25(ref InternalType_13 evt);

        internal static InternalType_13 InternalMethod_191(InternalType_5 InternalParameter_95, InternalType_78 InternalParameter_138) => new InternalType_13() { InternalProperty_46 = InternalParameter_95, InternalProperty_47 = InternalParameter_95, InternalField_69 = InternalParameter_138 };
        internal static InternalType_16<TInput> InternalMethod_188<TInput>(InternalType_5 InternalParameter_139, InternalType_76<TInput>? InternalParameter_1306, InternalType_76<TInput>? InternalParameter_1305, InternalType_78 InternalParameter_1310) where TInput : unmanaged, System.IEquatable<TInput>
        {
            return new InternalType_16<TInput>()
            {
                InternalProperty_101 = InternalParameter_139,
                InternalProperty_100 = InternalParameter_139,
                InternalField_70 = InternalParameter_1306,
                InternalField_67 = InternalParameter_1305,
                InternalField_3029 = InternalParameter_1310
            };
        }

        public struct InternalType_13
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_78 InternalField_69;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_5 InternalProperty_46 { get; set; }
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_5 InternalProperty_47 { get; set; }
        }

        public struct InternalType_16<T85> where T85 : unmanaged, System.IEquatable<T85>
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_78 InternalField_3029;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_76<T85>? InternalField_70;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_76<T85>? InternalField_67;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_5 InternalProperty_101 { get; set; }
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_5 InternalProperty_100 { get; set; }

            public Vector3 InternalMethod_339()
            {
                if (!InternalField_70.HasValue || !InternalField_67.HasValue || InternalProperty_100 == null)
                {
                    return Vector3.zero;
                }

                Vector3 InternalVar_1 = InternalProperty_100.InternalProperty_202.InverseTransformPoint(InternalField_67.Value.InternalField_248) - InternalProperty_100.InternalProperty_202.InverseTransformPoint(InternalField_70.Value.InternalField_248);

                return InternalType_187.InternalMethod_3642(InternalVar_1);
            }
        }
    }
}
