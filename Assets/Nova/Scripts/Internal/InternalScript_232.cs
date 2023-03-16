using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Nova.InternalNamespace_0
{
    internal enum InternalType_111
    {
        InternalField_359 = 0,
        InternalField_360 = 1,
        InternalField_361 = 2,
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_106 : System.IEquatable<InternalType_106>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Color InternalField_333;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_334;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_335;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_111 InternalField_336;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_106 other)
        {
            return
                InternalField_333.Equals(other.InternalField_333) &&
                InternalField_334 == other.InternalField_334 &&
                InternalField_335 == other.InternalField_335 &&
                InternalField_336 == other.InternalField_336;
        }
    }
}
