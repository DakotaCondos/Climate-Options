using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [System.Flags]
    internal enum InternalType_363
    {
        InternalField_1260 = 1,
        InternalField_1261 = 2 * InternalField_1260,
        InternalField_1262 = 2 * InternalField_1261,
        InternalField_1263 = 2 * InternalField_1262,
    }

    
    
    internal struct InternalType_364 : System.IComparable<InternalType_364>
    {
        public struct InternalType_365
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_366 InternalField_1271;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalField_1272;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalField_1273;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_366 InternalField_1264;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_1265;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_348 InternalField_1266;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_288 InternalField_1267;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_365 InternalField_1268;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public short InternalField_1269;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_363 InternalField_1270;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public unsafe ref InternalType_366 InternalProperty_322
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (InternalType_364* ptr = &this)
                {
                    return ref InternalProperty_324 ? ref ptr->InternalField_1268.InternalField_1271 : ref ptr->InternalField_1264;
                }
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public unsafe ref InternalType_366 InternalProperty_323
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (InternalType_364* ptr = &this)
                {
                    return ref InternalProperty_328 ? ref ptr->InternalField_1268.InternalField_1271 : ref ptr->InternalField_1264;
                }
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_324
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (InternalField_1270 & InternalType_363.InternalField_1262) != 0;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_325
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (InternalField_1270 & (InternalType_363.InternalField_1260 | InternalType_363.InternalField_1263)) != 0;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_326
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (InternalField_1270 & InternalType_363.InternalField_1261) != 0;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_327
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (InternalField_1270 & InternalType_363.InternalField_1260) != 0;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_328
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (InternalField_1270 & InternalType_363.InternalField_1263) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1568(ref InternalType_364 InternalParameter_1695)
        {
            return InternalField_1269 != InternalParameter_1695.InternalField_1269 ? InternalField_1269 < InternalParameter_1695.InternalField_1269 : InternalField_1267 < InternalParameter_1695.InternalField_1267;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(InternalType_364 other)
        {
            return InternalField_1264.InternalMethod_1574(ref other.InternalField_1264);
        }
    }
}


