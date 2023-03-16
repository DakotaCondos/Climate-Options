using System;
using System.Runtime.InteropServices;

namespace Nova.InternalNamespace_0
{
    
    [Flags]
    internal enum InternalType_72 : byte
    {
        InternalField_236 = 0,

        InternalField_237 = 1,
        InternalField_238 = 2,

        InternalField_239 = 4,
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_71
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_232;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public short InternalField_233;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_72 InternalField_234;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_235;

        public static InternalType_71 InternalMethod_452(InternalType_72 InternalParameter_318) => new InternalType_71()
        {
            InternalField_234 = InternalParameter_318,
            InternalField_235 = true,
        };

        public bool InternalMethod_453(ref InternalType_71 InternalParameter_319)
        {
            return
                InternalField_232 == InternalParameter_319.InternalField_232 &&
                InternalField_233 == InternalParameter_319.InternalField_233 &&
                InternalField_234 == InternalParameter_319.InternalField_234 &&
                InternalField_235 == InternalParameter_319.InternalField_235;

        }
    }
}
