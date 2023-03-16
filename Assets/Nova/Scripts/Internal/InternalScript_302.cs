using Nova.InternalNamespace_0.InternalNamespace_5;
using System;
using System.Runtime.CompilerServices;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [Flags]
    internal enum InternalType_322
    {
        InternalField_1082 = 0,
        InternalField_1083 = 1,
        InternalField_1084 = InternalField_1083 * 2,
        InternalField_1086 = InternalField_1084 * 2,
        InternalField_1087 = InternalField_1086 * 2,
        InternalField_1088 = InternalField_1087 * 2,
        InternalField_1089 = InternalField_1088 * 2,
        InternalField_1090 = InternalField_1089 * 2,
        InternalField_1091 = InternalField_1090 * 2,
        InternalField_1092 = InternalField_1091 * 2,
        InternalField_3418 = InternalField_1092 * 2,

        InternalField_1093 = InternalField_1086 | InternalField_1087,
    }

    internal struct InternalType_323 : IEquatable<InternalType_323>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_266 InternalField_1094;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_104 InternalField_1095;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_281 InternalField_1096;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_732
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (InternalField_1094 & (InternalType_266.InternalField_786 | InternalType_266.InternalField_791)) != 0;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_731
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (InternalField_1094 & InternalType_266.InternalField_791) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_323 other)
        {
            return
                InternalField_1094 == other.InternalField_1094 &&
                InternalField_1095 == other.InternalField_1095 &&
                InternalField_1096 == other.InternalField_1096;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string InternalMethod_1926()
        {
            if (InternalField_1095 == InternalType_104.InternalField_323)
            {
                return $"Hidden/{InternalType_178.InternalField_467}/{InternalType_178.InternalField_467}{InternalField_1094.InternalMethod_1923()}{InternalField_1095.InternalMethod_1922()}";
            }
            else
            {
                return $"Hidden/{InternalType_178.InternalField_467}/{InternalType_178.InternalField_467}{InternalField_1094.InternalMethod_1923()}{InternalField_1095.InternalMethod_1922()}{InternalField_1096.InternalMethod_3324()}";
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            int InternalVar_1 = 13;
            InternalVar_1 = (InternalVar_1 * 7) + ((int)InternalField_1094).GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + ((int)InternalField_1095).GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + ((int)InternalField_1096).GetHashCode();
            return InternalVar_1;
        }
    }

    internal struct InternalType_324 : IEquatable<InternalType_324>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_323 InternalField_2244;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_322 InternalField_1100;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1101;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_583;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_257 InternalField_1102; 

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_737
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (InternalField_1100 & (InternalType_322.InternalField_1083 | InternalType_322.InternalField_1084)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_324 other)
        {
            return
                InternalField_2244.Equals(other.InternalField_2244) &&
                InternalField_1100 == other.InternalField_1100 &&
                InternalField_1101 == other.InternalField_1101 &&
                InternalField_583 == other.InternalField_583 &&
                InternalField_1102.Equals(other.InternalField_1102);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            int InternalVar_1 = 13;
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_2244.GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + ((int)InternalField_1100).GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_1101.GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_583.GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_1102.GetHashCode();
            return InternalVar_1;
        }
    }

    internal static class InternalType_332
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string InternalMethod_1923(this InternalType_266 InternalParameter_466)
        {
            switch (InternalParameter_466)
            {
                case InternalType_266.InternalField_788:
                case InternalType_266.InternalField_790:
                    return "TextBlock";
                case InternalType_266.InternalField_787:
                    return "UIBlock3D";
                case InternalType_266.InternalField_786:
                    return "UIBlock2D";
                case InternalType_266.InternalField_789:
                    return "DropShadow";
                default:
                    return null;
            }
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string InternalMethod_1922(this InternalType_104 InternalParameter_457)
        {
            switch (InternalParameter_457)
            {
                case InternalType_104.InternalField_323: return "Unlit";
                case InternalType_104.InternalField_324: return "Lambert";
                case InternalType_104.InternalField_325: return "BlinnPhong";
                case InternalType_104.InternalField_326: return "Standard";
                case InternalType_104.InternalField_327: return "StandardSpecular";
                default: return "Unknown";
            }
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string InternalMethod_3324(this InternalType_281 InternalParameter_3129)
        {
            return InternalParameter_3129 == InternalType_281.InternalField_921 ? "Transparent" : "Opaque";
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_72 InternalMethod_1921(this InternalType_266 InternalParameter_456)
        {
            switch (InternalParameter_456)
            {
                case InternalType_266.InternalField_786:
                case InternalType_266.InternalField_789:
                    return InternalType_72.InternalField_237;
                case InternalType_266.InternalField_787:
                    return InternalType_72.InternalField_239;
                case InternalType_266.InternalField_788:
                case InternalType_266.InternalField_790:
                    return InternalType_72.InternalField_238;
                default:
                    return InternalType_72.InternalField_236;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string InternalMethod_853(this InternalType_72 InternalParameter_3131)
        {
            switch (InternalParameter_3131)
            {
                case InternalType_72.InternalField_237:
                    return "UIBlock2D";
                case InternalType_72.InternalField_239:
                    return "UIBlock3D";
                case InternalType_72.InternalField_238:
                    return "TextBlock";
                case InternalType_72.InternalField_236:
                default:
                    return string.Empty;
            }
        }
    }
}
