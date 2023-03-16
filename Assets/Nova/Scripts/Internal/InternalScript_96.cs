using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nova.InternalNamespace_0.InternalNamespace_9
{
    
    [StructLayoutAttribute(LayoutKind.Sequential)]
    
    internal struct InternalType_222 : IDisposable
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_585;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_586;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<InternalType_133> InternalField_587;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_253
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return InternalField_587.InternalProperty_216;
            }
        }

        public void Dispose()
        {
            InternalField_587.Dispose();
        }

        public static InternalType_222 InternalMethod_1059(InternalType_131 InternalParameter_1069)
        {
            return new InternalType_222()
            {
                InternalField_585 = InternalParameter_1069,
                InternalField_586 = InternalType_131.InternalField_415,
            };
        }
    }
}
