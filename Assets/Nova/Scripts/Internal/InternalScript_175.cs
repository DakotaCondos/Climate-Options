using Nova.InternalNamespace_0.InternalNamespace_2;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_455 : IDisposable
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private ulong InternalField_2043;

        public InternalType_455(ulong InternalParameter_1659)
        {
            this.InternalField_2043 = InternalParameter_1659;
        }

        public void Dispose()
        {
            if (InternalField_2043 != 0)
            {
                UnsafeUtility.ReleaseGCObject(InternalField_2043);
                InternalField_2043 = 0;
            }
        }
    }

    internal unsafe struct InternalType_352<T55> where T55 : unmanaged
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_1228;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ulong InternalField_2010;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T55* InternalField_1962;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref T55 InternalProperty_1030
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref (*InternalField_1962);
        }

        public InternalType_352(InternalType_134 InternalParameter_1654, ref T55 InternalParameter_1653)
        {
            InternalField_1228 = InternalParameter_1654.InternalProperty_195;
            UnsafeUtility.PinGCObjectAndGetAddress(InternalParameter_1654, out InternalField_2010);
            InternalField_1962 = (T55*)UnsafeUtility.AddressOf(ref InternalParameter_1653);
        }
    }
}

