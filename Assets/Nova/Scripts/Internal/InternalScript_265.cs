using System.Collections.Generic;

namespace Nova.InternalNamespace_0.InternalNamespace_5
{
    internal struct InternalType_189<T43> : IEqualityComparer<T43> where T43 : UnityEngine.Object
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_189<T43> InternalField_551 = default;

        public bool Equals(T43 x, T43 y)
        {
            return x == y;
        }

        public int GetHashCode(T43 obj)
        {
            return obj == null ? 0 : obj.GetHashCode();
        }
    }
}
