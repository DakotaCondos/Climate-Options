using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    internal static class InternalType_209
    {
        public static unsafe ref T InternalMethod_1030<T>(this NativeReference<T> InternalParameter_1038) where T : unmanaged
        {
            return ref UnsafeUtility.AsRef<T>(InternalParameter_1038.GetUnsafePtr());
        }

        public static unsafe T* InternalMethod_1031<T>(this NativeReference<T> InternalParameter_1039) where T : unmanaged
        {
            return (T*)InternalParameter_1039.GetUnsafePtrWithoutChecks();
        }

        public static unsafe void InternalMethod_1032<T>(ref this NativeReference<T> InternalParameter_1040) where T : unmanaged
        {
            InternalParameter_1040 = new NativeReference<T>(Allocator.Persistent);
        }

        public static unsafe void InternalMethod_1033<T>(ref this NativeReference<T> InternalParameter_1041, T InternalParameter_1042) where T : unmanaged
        {
            InternalParameter_1041 = new NativeReference<T>(InternalParameter_1042, Allocator.Persistent);
        }
    }
}
