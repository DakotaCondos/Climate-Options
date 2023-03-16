using System.Runtime.CompilerServices;
using Unity.Burst;

namespace Nova.InternalNamespace_0.InternalNamespace_9
{
    internal interface InternalType_219<T99> where T99 : InternalType_219<T99>
    {
        
        InternalType_220 InternalMethod_1046(ref T99 InternalParameter_1061);

        
        InternalType_220 InternalMethod_1047(ref T99 InternalParameter_1062);
    }

    [BurstCompile]
    internal struct InternalType_220
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_220 InternalField_3625 = 0;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_220 InternalField_3626 = 1 << 0;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly InternalType_220 InternalField_579 = 1 << 1;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_220 InternalField_580 = 1 << 2;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_220 InternalField_581 = InternalField_580;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte InternalField_582;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_220(byte InternalParameter_1063)
        {
            return new InternalType_220() { InternalField_582 = InternalParameter_1063 };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte(InternalType_220 InternalParameter_1064)
        {
            return InternalParameter_1064.InternalField_582;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool InternalProperty_249
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_582 != InternalField_3625.InternalField_582;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool InternalProperty_250
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_582 == InternalField_579.InternalField_582 || InternalField_582 == InternalField_580.InternalField_582;
        }

        public override string ToString()
        {
            string InternalVar_1 = InternalField_582 == InternalField_3625 ? "None" :
                          InternalField_582 == InternalField_3626 ? "Self" :
                          InternalField_582 == InternalField_579 ? "Parent" :
                          InternalField_582 == InternalField_580 ? "ParentAndChildren" :
                          "Unknown";

            return $"Dependency.{InternalVar_1}";
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_220 InternalMethod_1052(InternalType_220 InternalParameter_1065, InternalType_220 InternalParameter_1066)
        {
            return InternalParameter_1065.InternalField_582 > InternalParameter_1066.InternalField_582 ? InternalParameter_1065 : InternalParameter_1066;
        }
    }
}
