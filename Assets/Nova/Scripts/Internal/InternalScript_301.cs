using System.Runtime.CompilerServices;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal static class InternalType_409
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const InternalType_266 InternalField_2242 = InternalType_266.InternalField_786 | InternalType_266.InternalField_789;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_1925(InternalType_266 InternalParameter_498, InternalType_104 InternalParameter_468)
        {
            if (InternalType_333.InternalProperty_1033)
            {
                return InternalParameter_468 == InternalType_104.InternalField_323;
            }


            InternalType_105 InternalVar_1;
            if ((InternalParameter_498 & InternalField_2242) != 0)
            {
                InternalVar_1 = InternalType_24.InternalProperty_945.InternalField_2252;
            }
            else if (InternalParameter_498 == InternalType_266.InternalField_787)
            {
                InternalVar_1 = InternalType_24.InternalProperty_945.InternalField_2250;
            }
            else if ((InternalParameter_498 & InternalType_266.InternalField_791) != 0)
            {
                InternalVar_1 = InternalType_24.InternalProperty_945.InternalField_2251;
            }
            else
            {
                Debug.LogError($"Unknown VisualType of: {InternalParameter_498.InternalMethod_1923()}");
                return false;
            }

            return (InternalParameter_468.InternalMethod_1924() & InternalVar_1) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_105 InternalMethod_1924(this InternalType_104 InternalParameter_467)
        {
            switch (InternalParameter_467)
            {
                case InternalType_104.InternalField_323:
                    return InternalType_105.InternalField_2253;
                case InternalType_104.InternalField_324:
                    return InternalType_105.InternalField_329;
                case InternalType_104.InternalField_325:
                    return InternalType_105.InternalField_330;
                case InternalType_104.InternalField_326:
                    return InternalType_105.InternalField_331;
                case InternalType_104.InternalField_327:
                    return InternalType_105.InternalField_332;
                default:
                    return InternalType_105.InternalField_328;
            }
        }
    }
}
