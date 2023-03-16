using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_356
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_131 InternalField_577;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_306 InternalField_1244;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1246;

        public InternalType_356(InternalType_131 InternalParameter_2204)
        {
            InternalField_577 = InternalParameter_2204;
            InternalField_1244 = default;
            InternalField_1246 = 0;
        }
    }

    
    internal struct InternalType_19 : IEquatable<InternalType_19>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_806;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_304 InternalField_795;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_19 other)
        {
            return InternalField_806 == other.InternalField_806 && InternalField_795 == other.InternalField_795;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            int InternalVar_1 = 13;
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_806.GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_795.GetHashCode();
            return InternalVar_1;
        }

        public override string ToString()
        {
            return $"{InternalField_806}: {InternalField_795}";
        }
    }

    internal static class InternalType_357
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T InternalMethod_1007<T>(this ref NovaHashMap<InternalType_131, InternalType_162<InternalType_304, T>> InternalParameter_995, ref InternalType_19 InternalParameter_994) where T : unmanaged
        {
            return ref InternalParameter_995[InternalParameter_994.InternalField_806].InternalMethod_758(InternalParameter_994.InternalField_795);
        }
    }
}