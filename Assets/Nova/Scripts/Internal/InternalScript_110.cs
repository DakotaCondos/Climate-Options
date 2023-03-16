using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_11
{
    
    [StructLayoutAttribute(LayoutKind.Explicit)]
    internal struct InternalType_434 : InternalType_435
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_434 InternalField_1674 = new InternalType_434(InternalType_187.InternalField_530, InternalType_187.InternalField_503);

        [FieldOffset(0)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1675;

        [FieldOffset(3 * sizeof(float))]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1676;
        [FieldOffset(6 * sizeof(float))]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3x2 InternalField_1677;
        [FieldOffset(3 * sizeof(float))]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3x3 InternalField_1678; 
        
        [FieldOffset(12 * sizeof(float))]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1679;
        [FieldOffset(15 * sizeof(float))]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3x2 InternalField_1680;
        [FieldOffset(12 * sizeof(float))]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3x3 InternalField_1681; 

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_434(InternalType_436 InternalParameter_1928) : this(InternalParameter_1928.InternalField_1682, InternalParameter_1928.InternalField_1683) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_434(float3 InternalParameter_1929, float3 InternalParameter_1930)
        {
            InternalField_1681 = default;
            InternalField_1678 = default;

            InternalField_1675 = InternalParameter_1930;
            InternalField_1676 = InternalParameter_1929;
            InternalField_1679 = InternalType_187.InternalField_531 / InternalField_1675;

            InternalType_187.InternalMethod_896(InternalField_1676, out InternalField_1677);
            InternalType_187.InternalMethod_896(InternalField_1679, out InternalField_1680);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 InternalMethod_1706(float InternalParameter_1931)
        {
            return InternalField_1676 + (InternalField_1675 * InternalParameter_1931);
        }
    }

    internal struct InternalType_436 : InternalType_435
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1682;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1683;

        public InternalType_436(float3 InternalParameter_1932, float3 InternalParameter_1933)
        {
            InternalField_1682 = InternalParameter_1932;
            InternalField_1683 = InternalParameter_1933;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 InternalMethod_1708(float InternalParameter_1934)
        {
            return InternalField_1682 + InternalField_1683 * InternalParameter_1934;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_436(UnityEngine.Ray InternalParameter_1935)
        {
            return new InternalType_436() { InternalField_1682 = InternalParameter_1935.origin, InternalField_1683 = InternalParameter_1935.direction };
        }
    }

    internal interface InternalType_437<T60,T61> where T60 : unmanaged where T61 : unmanaged
    {
        T60 InternalMethod_1710();
        InternalType_447 InternalMethod_1711(ref T60 InternalParameter_1936, InternalType_133 InternalParameter_1937);
        bool InternalMethod_1712(ref T60 InternalParameter_1938, InternalType_133 InternalParameter_1939, InternalType_131 InternalParameter_1940, out T60 InternalParameter_1941);
        bool InternalMethod_1713(ref T60 InternalParameter_1942, InternalType_133 InternalParameter_1943, InternalType_131 InternalParameter_1944, out T61 InternalParameter_1945);
        void InternalMethod_1714(ref T60 InternalParameter_1946, InternalType_133 InternalParameter_1947, out T60 InternalParameter_1948);
    }

    internal interface InternalType_435 { }
}
