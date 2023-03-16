using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0
{
    internal enum InternalType_96
    {
        InternalField_304 = 0,
        InternalField_305 = 1,
        InternalField_306 = 2,
        InternalField_307 = 3
    }

    internal static class InternalType_97
    {
        public static int InternalMethod_508(this InternalType_96 InternalParameter_379)
        {
            switch (InternalParameter_379)
            {
                case InternalType_96.InternalField_305:
                    return 0;
                case InternalType_96.InternalField_306:
                    return 1;
                case InternalType_96.InternalField_307:
                    return 2;
            }

            return -1;
        }

        public static InternalType_96 InternalMethod_509(int InternalParameter_380)
        {
            switch (InternalParameter_380)
            {
                case 0:
                    return InternalType_96.InternalField_305;
                case 1:
                    return InternalType_96.InternalField_306;
                case 2:
                    return InternalType_96.InternalField_307;
            }

            return InternalType_96.InternalField_304;
        }
    }

    internal enum InternalType_83
    {
        InternalField_280 = 0,
        InternalField_281 = 1,
        InternalField_282 = 2,
    }

    
    [StructLayoutAttribute(LayoutKind.Sequential)]
    [System.Serializable]
    internal struct InternalType_69
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53 InternalField_213;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53 InternalField_214;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56 InternalField_215;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56 InternalField_216;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53.InternalType_54 InternalField_217;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53.InternalType_54 InternalField_218;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56.InternalType_57 InternalField_219;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56.InternalType_57 InternalField_220;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public int3 InternalField_221;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_99 InternalField_222;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public bool InternalField_223;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_98 InternalField_224;
    }

#pragma warning disable CS0660, CS0661 
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_98
#pragma warning restore CS0660, CS0661 
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_308;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_96 InternalField_309;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_173 => InternalField_309 == InternalType_96.InternalField_305 || InternalField_309 == InternalType_96.InternalField_306 || InternalField_309 == InternalType_96.InternalField_307;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int2 InternalProperty_174
        {
            get
            {
                switch (InternalField_309)
                {
                    case InternalType_96.InternalField_306:
                        return InternalType_187.InternalField_498.xz;
                    case InternalType_96.InternalField_307:
                        return InternalType_187.InternalField_498.xy;
                    default:
                        return InternalType_187.InternalField_498.yz;
                }
            }
        }

        public static bool operator ==(InternalType_98 InternalParameter_381, InternalType_98 InternalParameter_382)
        {
            return InternalParameter_381.InternalField_309 == InternalParameter_382.InternalField_309 && math.all(InternalParameter_381.InternalField_308 == InternalParameter_382.InternalField_308);
        }

        public static bool operator !=(InternalType_98 InternalParameter_383, InternalType_98 InternalParameter_384)
        {
            return InternalParameter_383.InternalField_309 != InternalParameter_384.InternalField_309 || math.any(InternalParameter_383.InternalField_308 != InternalParameter_384.InternalField_308);
        }
    }

    [StructLayoutAttribute(LayoutKind.Explicit)]
    [System.Serializable]
#pragma warning disable CS0660, CS0661 
    internal struct InternalType_99
#pragma warning restore CS0660, CS0661 
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal const int InternalField_310 = sizeof(InternalType_83);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal const int InternalField_311 = 3 * InternalField_310;

        [FieldOffset(0 * InternalField_310)]
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_83 X;

        [FieldOffset(1 * InternalField_310)]
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_83 Y;

        [FieldOffset(2 * InternalField_310)]
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_83 Z;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_99(InternalType_83 InternalParameter_385)
        {
            X = InternalParameter_385;
            Y = InternalParameter_385;
            Z = InternalParameter_385;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_99(InternalType_83 InternalParameter_386, InternalType_83 InternalParameter_387, InternalType_83 InternalParameter_388)
        {
            X = InternalParameter_386;
            Y = InternalParameter_387;
            Z = InternalParameter_388;
        }

        public InternalType_83 this[int InternalParameter_389]
        {
            readonly get
            {
                switch (InternalParameter_389)
                {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    case 2:
                        return Z;

                }

                return InternalType_83.InternalField_280;
            }
            set
            {
                switch (InternalParameter_389)
                {
                    case 0:
                        X = value;
                        break;
                    case 1:
                        Y = value;
                        break;
                    case 2:
                        Z = value;
                        break;

                }
            }
        }

        public static implicit operator InternalType_99(InternalType_83 InternalParameter_390)
        {
            return new InternalType_99(InternalParameter_390);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator ==(InternalType_83 InternalParameter_391, InternalType_99 InternalParameter_392)
        {
            return new bool3(InternalParameter_392.X == InternalParameter_391, InternalParameter_392.Y == InternalParameter_391, InternalParameter_392.Z == InternalParameter_391);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator !=(InternalType_83 InternalParameter_393, InternalType_99 InternalParameter_394)
        {
            return new bool3(InternalParameter_394.X != InternalParameter_393, InternalParameter_394.Y != InternalParameter_393, InternalParameter_394.Z != InternalParameter_393);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator ==(InternalType_99 InternalParameter_395, InternalType_83 InternalParameter_396)
        {
            return new bool3(InternalParameter_395.X == InternalParameter_396, InternalParameter_395.Y == InternalParameter_396, InternalParameter_395.Z == InternalParameter_396);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator !=(InternalType_99 InternalParameter_397, InternalType_83 InternalParameter_398)
        {
            return new bool3(InternalParameter_397.X != InternalParameter_398, InternalParameter_397.Y != InternalParameter_398, InternalParameter_397.Z != InternalParameter_398);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_99 InternalParameter_399, InternalType_99 InternalParameter_400)
        {
            return InternalParameter_399.X == InternalParameter_400.X && InternalParameter_399.Y == InternalParameter_400.Y && InternalParameter_399.Z == InternalParameter_400.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_99 InternalParameter_401, InternalType_99 InternalParameter_402)
        {
            return !(InternalParameter_401 == InternalParameter_402);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool3 InternalProperty_176
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => this == InternalType_83.InternalField_280;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool3 InternalProperty_177
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => this == InternalType_83.InternalField_282;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool3 InternalProperty_178
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => this == InternalType_83.InternalField_281;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool3 InternalProperty_179
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => this != InternalType_83.InternalField_280 & this != InternalType_83.InternalField_282;
        }

        public override string ToString()
        {
            return $"AutoSize3({X.ToString()}, {Y.ToString()}, {Z.ToString()})";
        }
    }
}
