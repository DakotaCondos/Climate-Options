using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nova.InternalNamespace_25
{
    internal static partial class InternalType_728
    {
        public static bool InternalMethod_3284(TwoD<bool> InternalParameter_3066)
        {
            return InternalParameter_3066.X || InternalParameter_3066.Y;
        }

        public static bool InternalMethod_3285(TwoD<bool> InternalParameter_3067)
        {
            return !(InternalParameter_3067.X || InternalParameter_3067.Y);
        }

        public static TwoD<bool> InternalMethod_3286(TwoD<bool> InternalParameter_3068)
        {
            return new TwoD<bool>(!InternalParameter_3068.X, !InternalParameter_3068.Y);
        }

        public static TwoD<bool> InternalMethod_3287(TwoD<bool> InternalParameter_3069, TwoD<bool> InternalParameter_3070)
        {
            return new TwoD<bool>(InternalParameter_3069.X && InternalParameter_3070.X, InternalParameter_3069.Y && InternalParameter_3070.Y);
        }

        public static TwoD<bool> InternalMethod_3288(TwoD<bool> InternalParameter_3071, TwoD<bool> InternalParameter_3072)
        {
            return new TwoD<bool>(InternalParameter_3071.X || InternalParameter_3072.X, InternalParameter_3071.Y || InternalParameter_3072.Y);
        }

        public static ThreeD<T> InternalMethod_3289<T>(ThreeD<T> InternalParameter_3073, ThreeD<T> InternalParameter_3074, ThreeD<bool> InternalParameter_3075) where T : unmanaged
        {
            return new ThreeD<T>(InternalParameter_3075.X ? InternalParameter_3074.X : InternalParameter_3073.X,
                                 InternalParameter_3075.Y ? InternalParameter_3074.Y : InternalParameter_3073.Y,
                                 InternalParameter_3075.Z ? InternalParameter_3074.Z : InternalParameter_3073.Z);
        }

        public static TwoD<T> InternalMethod_3290<T>(TwoD<T> InternalParameter_3076, TwoD<T> InternalParameter_3077, TwoD<bool> InternalParameter_3078) where T : unmanaged
        {
            return new TwoD<T>(InternalParameter_3078.X ? InternalParameter_3077.X : InternalParameter_3076.X,
                               InternalParameter_3078.Y ? InternalParameter_3077.Y : InternalParameter_3076.Y);
        }
    }

    internal static class InternalType_730
    {
        public static bool InternalMethod_3295<T>(this TwoD<T> InternalParameter_3086, TwoD<T> InternalParameter_3087) where T : unmanaged
        {
            return InternalType_728.InternalMethod_3285(InternalParameter_3086 == InternalParameter_3087);
        }

        public static bool InternalMethod_3296<T>(this TwoD<T> InternalParameter_3088, TwoD<T> InternalParameter_3089) where T : unmanaged
        {
            return InternalType_728.InternalMethod_3284(InternalParameter_3088 == InternalParameter_3089);
        }

        public static Unity.Mathematics.bool2 InternalMethod_3297(this TwoD<bool> InternalParameter_3090)
        {
            return new Unity.Mathematics.bool2(InternalParameter_3090.X, InternalParameter_3090.Y);
        }
    }
}
