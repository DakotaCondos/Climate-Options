using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0
{
    internal enum InternalType_112
    {
        InternalField_362 = 0,
        InternalField_363 = 1,
        InternalField_364 = 2,
        InternalField_3426 = 3,
        InternalField_3427 = 4,
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_113 : System.IEquatable<InternalType_113>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float2 InternalField_365;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float2 InternalField_366;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_3428;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_112 InternalField_367;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_113 other)
        {
            return
                InternalField_365.Equals(other.InternalField_365) &&
                InternalField_366.Equals(other.InternalField_366) &&
                InternalField_367 == other.InternalField_367 &&
                InternalField_3428 == other.InternalField_3428;
        }
    }
}