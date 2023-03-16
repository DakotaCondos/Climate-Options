using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    
    internal struct InternalType_366
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float2 InternalField_1274;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float2 InternalField_1275;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float2 InternalProperty_722
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1275 - InternalField_1274;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalProperty_329
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1274.x;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalProperty_330
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1275.x;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalProperty_1079
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1274.y;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalProperty_1080
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1275.y;
        }

        
        public float2 InternalMethod_1571(int InternalParameter_1696)
        {
            switch (InternalParameter_1696)
            {
                case 0:
                    return InternalField_1274;
                case 1:
                    return new float2(InternalField_1274.x, InternalField_1275.y);
                case 2:
                    return InternalField_1275;
                default:
                    return new float2(InternalField_1275.x, InternalField_1274.y);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_366(float2 InternalParameter_1697, float2 InternalParameter_1698)
        {
            InternalField_1274 = InternalParameter_1697;
            InternalField_1275 = InternalParameter_1698;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_366(float InternalParameter_3003, float InternalParameter_3122, float InternalParameter_3123, float InternalParameter_3121)
        {
            InternalField_1274 = new float2(InternalParameter_3003, InternalParameter_3122);
            InternalField_1275 = new float2(InternalParameter_3123, InternalParameter_3121);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4 InternalMethod_1573(ref InternalType_366 InternalParameter_1699)
        {
            bool4 InternalVar_1 = default;
            InternalVar_1.xy = InternalType_187.InternalMethod_926(ref InternalField_1274, ref InternalParameter_1699.InternalField_1274);
            InternalVar_1.zw = InternalType_187.InternalMethod_926(ref InternalField_1275, ref InternalParameter_1699.InternalField_1275);
            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int InternalMethod_1574(ref InternalType_366 InternalParameter_1700)
        {
            if (InternalType_187.InternalMethod_922(InternalField_1274.x, InternalParameter_1700.InternalField_1274.x))
            {
                return 0;
            }
            else
            {
                return InternalField_1274.x.CompareTo(InternalParameter_1700.InternalField_1274.x);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1575(ref InternalType_366 InternalParameter_1701)
        {
            return !(math.any(InternalField_1274.InternalMethod_940(ref InternalParameter_1701.InternalField_1275)) || math.any(InternalParameter_1701.InternalField_1274.InternalMethod_940(ref InternalField_1275)));
        }
    }
}
