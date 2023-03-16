using Nova.InternalNamespace_0.InternalNamespace_10;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace Nova.InternalNamespace_0
{

    internal enum InternalType_104
    {
        InternalField_323 = 0,
        InternalField_324 = 1,
        InternalField_325 = 2,
        InternalField_326 = 3,
        InternalField_327 = 4,
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_73 : System.IEquatable<InternalType_73>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Color InternalField_240;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public float InternalField_241;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public float InternalField_242;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_104 InternalField_243;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ShadowCastingMode InternalField_244;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_245;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_104 InternalProperty_1032
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalType_333.InternalProperty_1033 ? InternalType_104.InternalField_323 : InternalField_243;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalProperty_158
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_241;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalProperty_159
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_241;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalProperty_160
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_242;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalProperty_161
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_242;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_162
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalProperty_1032 != InternalType_104.InternalField_323;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_163
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalProperty_162 && InternalProperty_1032 != InternalType_104.InternalField_324;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_73 other)
        {
            return
                InternalField_240.Equals(other.InternalField_240) &&
                InternalField_241 == other.InternalField_241 &&
                InternalField_242 == other.InternalField_242 &&
                InternalProperty_1032 == other.InternalProperty_1032 &&
                InternalField_244 == other.InternalField_244 &&
                InternalField_245 == other.InternalField_245;
        }
    }
}
