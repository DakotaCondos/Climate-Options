using Nova.InternalNamespace_0.InternalNamespace_10;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    internal static class InternalType_195
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color InternalMethod_968(this Color InternalParameter_928, float InternalParameter_929)
        {
            InternalParameter_928.a = InternalParameter_929;
            return InternalParameter_928;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 InternalMethod_969(ref this Color InternalParameter_930)
        {
            return new float4(InternalParameter_930.r, InternalParameter_930.g, InternalParameter_930.b, InternalParameter_930.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color InternalMethod_970(this Color InternalParameter_931, float InternalParameter_932)
        {
            Color.RGBToHSV(InternalParameter_931, out float InternalVar_1, out float InternalVar_2, out float InternalVar_3);
            return Color.HSVToRGB(InternalVar_1, InternalVar_2, InternalParameter_932);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color InternalMethod_971(this Color InternalParameter_933, float InternalParameter_934)
        {
            Color.RGBToHSV(InternalParameter_933, out float InternalVar_1, out float InternalVar_2, out float InternalVar_3);
            return Color.HSVToRGB(InternalVar_1, InternalParameter_934, InternalVar_3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_972(this Color InternalParameter_935)
        {
            return InternalParameter_935.a < 1f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_973(this Color InternalParameter_936)
        {
            return InternalParameter_936.a == 1f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_281 InternalMethod_974(this Color InternalParameter_937)
        {
            return InternalParameter_937.InternalMethod_973() ? InternalType_281.InternalField_920 : InternalType_281.InternalField_921;
        }
    }
}
