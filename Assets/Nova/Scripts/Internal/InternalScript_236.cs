using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Nova.InternalNamespace_0
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_80 : IEquatable<InternalType_80>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Color InternalField_266;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_267;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_486 InternalField_3412;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_108 InternalField_268;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_106 InternalField_269;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_107 InternalField_270;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_81 InternalField_271;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_272;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_273;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_80 other)
        {
            return
                InternalField_266.Equals(other.InternalField_266) &&
                InternalField_267 == other.InternalField_267 &&
                InternalField_3412.Equals(other.InternalField_3412) &&
                InternalField_268.Equals(other.InternalField_268) &&
                InternalField_269.Equals(other.InternalField_269) &&
                InternalField_270.Equals(other.InternalField_270) &&
                InternalField_271.Equals(other.InternalField_271) &&
                InternalField_272 == other.InternalField_272 &&
                InternalField_273 == other.InternalField_273;
        }
    }
}
