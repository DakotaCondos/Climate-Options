using System;
using UnityEngine;

namespace Nova.InternalNamespace_0
{
    internal enum InternalType_77
    {
        InternalField_251 = 0, 
        InternalField_252 = 1, 
        InternalField_254 = 2, 
        InternalField_255 = 3, 
        InternalField_253 = 4, 
    }

    internal static class InternalType_86
    {
        public static bool InternalMethod_490(this InternalType_77 InternalParameter_353)
        {
            return InternalParameter_353 != InternalType_77.InternalField_251;
        }

        public static bool InternalMethod_491(this InternalType_77 InternalParameter_354)
        {
            return InternalParameter_354.InternalMethod_492() || InternalParameter_354 == InternalType_77.InternalField_253;
        }

        public static bool InternalMethod_492(this InternalType_77 InternalParameter_355)
        {
            return InternalParameter_355 == InternalType_77.InternalField_255 || InternalParameter_355 == InternalType_77.InternalField_254;
        }

        public static int InternalMethod_493(this InternalType_77 InternalParameter_356)
        {
            return (int)InternalParameter_356;
        }
    }

    internal interface InternalType_75
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalProperty_741 { get; }

        InternalType_77 InternalMethod_3340<T>(Ray InternalParameter_329, InternalType_76<T> InternalParameter_328, InternalType_76<T> InternalParameter_2232, Transform InternalParameter_2233) where T : unmanaged, IEquatable<T>;
    }
}
