using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_3
{
    internal struct InternalType_151
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte InternalField_438;
        public bool this[int InternalParameter_553]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (InternalField_438 & (1 << InternalParameter_553)) != 0;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                InternalField_438 = (byte) (value ? InternalField_438 | (1 << InternalParameter_553) : InternalField_438 & ~(1 << InternalParameter_553));
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool InternalProperty_218
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return InternalField_438 == 0x00;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool InternalProperty_219
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return InternalField_438 == 0xFF;
            }
        }

        public readonly int InternalMethod_710()
        {
            return math.countbits((uint)InternalField_438);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_151 operator &(InternalType_151 InternalParameter_554, InternalType_151 InternalParameter_555)
        {
            return new InternalType_151()
            {
                InternalField_438 = (byte)(InternalParameter_554.InternalField_438 & InternalParameter_555.InternalField_438)
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte(InternalType_151 InternalParameter_556)
        {
            return InternalParameter_556.InternalField_438;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_151(byte InternalParameter_557)
        {
            return new InternalType_151() { InternalField_438 = InternalParameter_557 };
        }

        private int InternalMethod_714(int InternalParameter_558)
        {
            return this[InternalParameter_558] ? 1 : 0;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_151 InternalField_439 = new InternalType_151() { InternalField_438 = 0x00 };
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_151 InternalField_440 = new InternalType_151() { InternalField_438 = 0xFF };

        public override string ToString()
        {
            return $"[{InternalMethod_714(0)}, {InternalMethod_714(1)}, {InternalMethod_714(2)}, {InternalMethod_714(3)}, {InternalMethod_714(4)}, {InternalMethod_714(5)}, {InternalMethod_714(6)}, {InternalMethod_714(7)}]";
        }
    }
}
