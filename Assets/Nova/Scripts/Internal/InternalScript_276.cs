using UnityEngine;

namespace Nova.InternalNamespace_25
{
    internal static partial class InternalType_728
    {
        public static bool InternalMethod_3277(ThreeD<bool> InternalParameter_3057)
        {
            return InternalParameter_3057.X && InternalParameter_3057.Y && InternalParameter_3057.Z;
        }

        public static bool InternalMethod_3278(ThreeD<bool> InternalParameter_3058)
        {
            return InternalParameter_3058.X || InternalParameter_3058.Y || InternalParameter_3058.Z;
        }

        public static bool InternalMethod_3279(ThreeD<bool> InternalParameter_3059)
        {
            return !(InternalParameter_3059.X || InternalParameter_3059.Y || InternalParameter_3059.Z);
        }

        public static ThreeD<bool> InternalMethod_3280(ThreeD<bool> InternalParameter_3060)
        {
            return new ThreeD<bool>(!InternalParameter_3060.X, !InternalParameter_3060.Y, !InternalParameter_3060.Z);
        }

        public static ThreeD<bool> InternalMethod_3281(ThreeD<bool> InternalParameter_3061, ThreeD<bool> InternalParameter_3062)
        {
            return new ThreeD<bool>(InternalParameter_3061.X && InternalParameter_3062.X, InternalParameter_3061.Y && InternalParameter_3062.Y, InternalParameter_3061.Z && InternalParameter_3062.Z);
        }

        public static ThreeD<bool> InternalMethod_3282(ThreeD<bool> InternalParameter_3063, ThreeD<bool> InternalParameter_3064)
        {
            return new ThreeD<bool>(InternalParameter_3063.X || InternalParameter_3064.X, InternalParameter_3063.Y || InternalParameter_3064.Y, InternalParameter_3063.Z || InternalParameter_3064.Z);
        }

        public static Vector3 InternalMethod_3283(ThreeD<bool> InternalParameter_3065)
        {
            return new Vector3(InternalParameter_3065.X ? 1 : 0, InternalParameter_3065.Y ? 1 : 0, InternalParameter_3065.Z ? 1 : 0);
        }
    }

    internal static class InternalType_729
    {
        public static bool InternalMethod_3291<T>(this ThreeD<T> InternalParameter_3079, ThreeD<T> InternalParameter_3080) where T : unmanaged
        {
            return InternalType_728.InternalMethod_3278(InternalParameter_3079 == InternalParameter_3080);
        }

        public static bool InternalMethod_3292<T>(this ThreeD<T> InternalParameter_3081, ThreeD<T> InternalParameter_3082) where T : unmanaged
        {
            return InternalType_728.InternalMethod_3277(InternalParameter_3081 == InternalParameter_3082);
        }

        public static bool InternalMethod_3293<T>(this ThreeD<T> InternalParameter_3083, ThreeD<T> InternalParameter_3084) where T : unmanaged
        {
            return InternalType_728.InternalMethod_3279(InternalParameter_3083 == InternalParameter_3084);
        }

        public static Unity.Mathematics.bool3 InternalMethod_3294(this ThreeD<bool> InternalParameter_3085)
        {
            return new Unity.Mathematics.bool3(InternalParameter_3085.X, InternalParameter_3085.Y, InternalParameter_3085.Z);
        }
    }
}
