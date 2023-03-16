using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    internal static class InternalType_197
    {
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InternalMethod_978(ref this float3 InternalParameter_945, float3 InternalParameter_946)
        {
            return InternalMethod_983(InternalParameter_945 / InternalParameter_946);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InternalMethod_979(this float2 InternalParameter_947)
        {
            return math.max(InternalParameter_947, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 InternalMethod_980(ref this float4 InternalParameter_948)
        {
            return math.max(InternalParameter_948, 0);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InternalMethod_981(this float InternalParameter_949, float InternalParameter_950)
        {

            float InternalVar_1 = InternalParameter_949 * InternalParameter_950;
            return float.IsNaN(InternalVar_1 * 0) ? 0 : InternalVar_1;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InternalMethod_983(float3 InternalParameter_952)
        {
            return math.select(InternalParameter_952, InternalType_187.InternalField_530, InternalMethod_986(InternalParameter_952 * 0));
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 InternalMethod_984(float3 InternalParameter_953)
        {
            return new bool3(InternalMethod_985(InternalParameter_953.x), InternalMethod_985(InternalParameter_953.y), InternalMethod_985(InternalParameter_953.z));
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_985(float InternalParameter_954)
        {
            return InternalParameter_954 == float.PositiveInfinity || InternalParameter_954 == float.NegativeInfinity;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 InternalMethod_986(float3 InternalParameter_955)
        {
            return new bool3(float.IsNaN(InternalParameter_955.x), float.IsNaN(InternalParameter_955.y), float.IsNaN(InternalParameter_955.z));
        }
    }
}