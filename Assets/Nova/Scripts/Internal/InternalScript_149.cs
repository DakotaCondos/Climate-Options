using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Nova.InternalNamespace_0.InternalNamespace_4
{
    
    internal readonly ref struct InternalType_521<T91>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static InternalType_521<T91> InternalProperty_435 => default;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly IList<T91> InternalField_2331;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly IList<T91> InternalProperty_434
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_2331;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly int InternalProperty_433
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_2331 == null ? 0 : InternalField_2331.Count;
        }

        public readonly T91 this[int InternalParameter_2375]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_2331[InternalParameter_2375];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int InternalMethod_2048(T91 InternalParameter_2374)
        {
            return InternalField_2331.IndexOf(InternalParameter_2374);
        }

        public InternalType_521(IList<T91> InternalParameter_2373)
        {
            this.InternalField_2331 = InternalParameter_2373;
        }

        public readonly void InternalMethod_2046(T91[] InternalParameter_2372, int InternalParameter_2371 = 0)
        {
            InternalField_2331.CopyTo(InternalParameter_2372, InternalParameter_2371);
        }

        public readonly void InternalMethod_2045(List<T91> InternalParameter_2370, int InternalParameter_2369 = 0)
        {
            InternalParameter_2370.InsertRange(InternalParameter_2369, InternalField_2331);
        }
    }
}
