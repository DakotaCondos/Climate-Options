using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
#pragma warning disable CS0660 
#pragma warning disable CS0661 

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_670
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float4 InternalField_2829;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_762
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => !math.any(math.isnan(InternalField_2829));
        }

        public override string ToString() => InternalField_2829.ToString();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_670 InternalParameter_2563, InternalType_670 InternalParameter_2518) => !(InternalParameter_2563 == InternalParameter_2518);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_670 InternalParameter_2239, InternalType_670 InternalParameter_2234) => InternalType_187.InternalMethod_928(ref InternalParameter_2239.InternalField_2829, ref InternalParameter_2234.InternalField_2829);

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InternalMethod_1957(float2 InternalParameter_1278)
        {
            return math.select(float2.zero, InternalParameter_1278, InternalParameter_1278 < InternalType_187.InternalField_2247);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_670 InternalMethod_1956(float2 InternalParameter_1277)
        {
            return InternalMethod_2347(InternalMethod_1957(InternalParameter_1277));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InternalMethod_1955(float2 InternalParameter_1274, float2 InternalParameter_1102, bool2 InternalParameter_973)
        {
            float2 InternalVar_1 = InternalMethod_1957(InternalParameter_1102);
            return math.select(InternalParameter_1274, InternalVar_1, InternalParameter_973);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_670 InternalMethod_2348(float2 InternalParameter_2229, float2 InternalParameter_2225, bool2 InternalParameter_2224)
        {
            return InternalMethod_2347(InternalMethod_1955(InternalParameter_2229, InternalParameter_2225, InternalParameter_2224));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_670 InternalMethod_2347(float2 InternalParameter_2223) => new InternalType_670()
        {
            InternalField_2829 = (-InternalType_187.InternalField_521 * InternalParameter_2223).xyxy,
        };

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_670 InternalField_2828 = new InternalType_670()
        {
            InternalField_2829 = InternalType_187.InternalField_2231
        };
    }
}
