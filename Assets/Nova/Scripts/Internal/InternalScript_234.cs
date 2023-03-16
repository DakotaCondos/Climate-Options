using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Nova.InternalNamespace_0
{
    internal enum InternalType_114
    {
        InternalField_368 = 0,
        InternalField_369 = 1
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_107 : System.IEquatable<InternalType_107>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Color InternalField_337;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_338;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_339;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_48 InternalField_340;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_341;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_114 InternalField_342;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_186
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_341 && InternalField_342 == InternalType_114.InternalField_368;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_187
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_341 && InternalField_342 == InternalType_114.InternalField_369;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_107 other)
        {
            return
                InternalField_337.Equals(other.InternalField_337) &&
                InternalField_338 == other.InternalField_338 &&
                InternalField_339 == other.InternalField_339 &&
                InternalField_340.InternalMethod_377(ref other.InternalField_340) &&
                InternalField_341 == other.InternalField_341 &&
                InternalField_342 == other.InternalField_342;
        }
    }
}