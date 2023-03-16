using Nova.InternalNamespace_0.InternalNamespace_5;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nova.InternalNamespace_0
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_486 : IEquatable<InternalType_486>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_48 InternalField_3413;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public float InternalField_3414;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public float InternalField_3415;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_3416;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_1066
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_3416 && !InternalNamespace_5.InternalType_187.InternalMethod_922(InternalNamespace_5.InternalType_187.InternalMethod_871(InternalField_3415), 360f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_486 other)
        {
            return
                InternalField_3413.InternalMethod_377(ref other.InternalField_3413) &&
                InternalField_3414.Equals(other.InternalField_3414) &&
                InternalField_3415.Equals(other.InternalField_3415) &&
                InternalField_3416.Equals(other.InternalField_3416);
        }
    }
}

