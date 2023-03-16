using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nova.InternalNamespace_0
{
    [Flags]
    internal enum InternalType_105 : int
    {
        InternalField_328 = 0,
        InternalField_2253 = 1,
        InternalField_329 = 2 * InternalField_2253,
        InternalField_330 = 2 * InternalField_329,
        InternalField_331 = 2 * InternalField_330,
        InternalField_332 = 2 * InternalField_331,
    }

    internal enum InternalType_499 : int
    {
        InternalField_2481 = 0,
        InternalField_2478 = 1,
    }

    [Flags]
    internal enum InternalType_116 : int
    {
        InternalField_378 = 0,
        InternalField_2767 = 1,
        InternalField_380 = 2 * InternalField_2767,
        InternalField_381 = 2 * InternalField_380,
        InternalField_2333 = 2 * InternalField_381,
        InternalField_2332 = 2 * InternalField_2333,
    }

    
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_115
    {
        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_116 InternalField_370;
        #endregion

        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        public bool InternalField_3088;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_499 InternalField_3087;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_373;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_374;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_375;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_376;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_105 InternalField_2252;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_105 InternalField_2251;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_105 InternalField_2250;
        #endregion

        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        public int InternalField_2768;
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_554(InternalType_116 InternalParameter_423) => (InternalField_370 & InternalParameter_423) != 0;
    }
}
