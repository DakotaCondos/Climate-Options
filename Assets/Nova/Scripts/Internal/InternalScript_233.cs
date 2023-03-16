using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nova.InternalNamespace_0
{

    internal enum InternalType_695
    {
        InternalField_2939 = 0,
        InternalField_2831 = 1,
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_103 : IComparable<InternalType_103>, IEquatable<InternalType_103>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_321;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_103 InternalField_322 = -1;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_185
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_321 != -1;
        }

        public bool Equals(InternalType_103 other)
        {
            return InternalField_321 == other.InternalField_321;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return InternalField_321.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(InternalType_103 other)
        {
            return InternalField_321 - other.InternalField_321;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_103(int InternalParameter_413) => new InternalType_103()
        {
            InternalField_321 = InternalParameter_413,
        };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int(InternalType_103 InternalParameter_414) => InternalParameter_414.InternalField_321;

        public override string ToString()
        {
            return InternalField_321.ToString();
        }
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_81 : System.IEquatable<InternalType_81>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_113 InternalField_274;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_695 InternalField_275;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_103 InternalField_276;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_168
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_276.InternalProperty_185;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_81 other)
        {
            return
                InternalField_274.Equals(other.InternalField_274) &&
                InternalField_275 == other.InternalField_275 &&
                InternalField_276 == other.InternalField_276;
        }
    }
}
