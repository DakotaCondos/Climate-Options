using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;

namespace Nova.InternalNamespace_0.InternalNamespace_5
{
    internal unsafe static class InternalType_188
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_952<T>(T* InternalParameter_910, T* InternalParameter_911, int InternalParameter_912 = 1) where T : unmanaged
        {
            UnsafeUtility.MemCpy(InternalParameter_910, InternalParameter_911, InternalParameter_912 * sizeof(T));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref TTo InternalMethod_953<TFrom, TTo>(this ref TFrom InternalParameter_913) where TFrom : unmanaged where TTo : unmanaged
        {
            return ref UnsafeUtility.As<TFrom, TTo>(ref InternalParameter_913);
        }
    }
}

