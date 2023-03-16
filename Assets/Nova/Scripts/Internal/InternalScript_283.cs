using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    internal static class InternalType_212
    {
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1042<T>(ref this UnsafeList<T> InternalParameter_1052, int InternalParameter_1053, T InternalParameter_1054) where T : unmanaged
        {
            ref UnsafeList<T> InternalVar_1 = ref InternalParameter_1052;

            if (InternalParameter_1053 == InternalVar_1.Length)
            {
                InternalVar_1.Add(InternalParameter_1054);
                unsafe
                {
                    InternalParameter_1052.Ptr = InternalVar_1.Ptr;
                    InternalParameter_1052.Length = InternalVar_1.Length;
                    InternalParameter_1052.Capacity = InternalVar_1.Capacity;
                }
                return;
            }

            if (InternalParameter_1053 < 0 || InternalParameter_1053 > InternalVar_1.Length)
            {
                Debug.LogError($"Expected within range [0, {InternalVar_1.Length}) but got {InternalParameter_1053}");
                return;
            }

            InternalVar_1.Add(default);

            unsafe
            {
                int InternalVar_2 = UnsafeUtility.SizeOf<T>();
                T* InternalVar_3 = InternalVar_1.Ptr;
                T* InternalVar_4 = InternalVar_3 + InternalParameter_1053;
                T* InternalVar_5 = InternalVar_4 + 1;
                UnsafeUtility.MemMove(InternalVar_5, InternalVar_4, InternalVar_2 * (InternalVar_1.Length - InternalParameter_1053 - 1)); 
            }

            InternalVar_1[InternalParameter_1053] = InternalParameter_1054;

            unsafe
            {
                InternalParameter_1052.Ptr = InternalVar_1.Ptr;
                InternalParameter_1052.Length = InternalVar_1.Length;
                InternalParameter_1052.Capacity = InternalVar_1.Capacity;
            }

            return;
        }
    }
}
