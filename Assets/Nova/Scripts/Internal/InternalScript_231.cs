using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Nova.InternalNamespace_0
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_108 : IEquatable<InternalType_108>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Color InternalField_343;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_48 InternalField_344;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_48 InternalField_345;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public float InternalField_346;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_347;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_108 other)
        {
            return
                InternalField_343.Equals(other.InternalField_343) &&
                InternalField_344.InternalMethod_377(ref other.InternalField_344) &&
                InternalField_345.InternalMethod_377(ref other.InternalField_345) &&
                InternalField_346 == other.InternalField_346 &&
                InternalField_347 == other.InternalField_347;
        }
    }
}
