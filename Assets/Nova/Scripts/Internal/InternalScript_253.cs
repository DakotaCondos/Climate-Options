using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;

namespace Nova.InternalNamespace_0.InternalNamespace_5
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void InternalType_175(void* jobData);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void InternalType_176(void* jobData, int functionID);

    internal unsafe struct InternalType_735<T81> where T81 : class
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T81 InternalField_3352;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_735(T81 InternalParameter_1472)
        {
            try
            {
                InternalField_3352 = BurstCompiler.CompileFunctionPointer(InternalParameter_1472).Invoke;
            }
            catch
            {
                InternalField_3352 = InternalParameter_1472;
            }
        }
    }
}
