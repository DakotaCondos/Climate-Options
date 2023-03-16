using Nova.InternalNamespace_0.InternalNamespace_5;
using System;
using System.Runtime.InteropServices;

namespace Nova.InternalNamespace_0
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_101 : IEquatable<InternalType_101>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_316;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_317;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_491;

        public bool Equals(InternalType_101 other)
        {
            return 
                InternalField_316 == other.InternalField_316 &&
                InternalField_491 == other.InternalField_491 && 
                InternalField_317 == other.InternalField_317;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal static readonly InternalType_101 InternalField_318 = new InternalType_101()
        {
            InternalField_316 = 0,
            InternalField_317 = InternalType_178.InternalField_472,
            InternalField_491 = false,
        };
    }
}
