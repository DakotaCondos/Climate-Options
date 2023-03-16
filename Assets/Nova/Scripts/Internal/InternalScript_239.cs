using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Nova.InternalNamespace_0
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_82 : System.IEquatable<InternalType_82>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Color InternalField_277;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_278;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_279;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_82 other)
        {
            return
                InternalField_277.Equals(other.InternalField_277) &&
                InternalField_278 == other.InternalField_278 &&
                InternalField_279 == other.InternalField_279;
        }
    }
}