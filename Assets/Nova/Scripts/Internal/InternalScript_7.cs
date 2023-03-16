using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_5
{
    internal struct InternalType_174<T36> : InternalType_148 where T36 : unmanaged, IEquatable<T36>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<T36> InternalField_465;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NovaHashMap<T36, int> InternalField_466;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_240
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_465.Length;
        }

        public T36 this[int InternalParameter_684]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_465[InternalParameter_684];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_837(T36 InternalParameter_685)
        {
            int InternalVar_1 = InternalField_465.Length;

            if (InternalField_466.TryAdd(InternalParameter_685, InternalVar_1))
            {
                InternalField_465.Add(InternalParameter_685);
                return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_3375(InternalType_164<T36> InternalParameter_2163)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_2163.InternalProperty_216; ++InternalVar_1)
            {
                InternalMethod_837(InternalParameter_2163[InternalVar_1]);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_838(T36 InternalParameter_686)
        {
            if (!InternalField_466.TryGetValue(InternalParameter_686, out int InternalVar_1))
            {
                return false;
            }

            InternalField_466.Remove(InternalParameter_686);
            InternalField_465.RemoveAtSwapBack(InternalVar_1);

            if (InternalVar_1 < InternalField_465.Length)
            {
                InternalField_466[InternalField_465[InternalVar_1]] = InternalVar_1;
            }

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_839(T36 InternalParameter_687)
        {
            return InternalField_466.ContainsKey(InternalParameter_687);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_840()
        {
            InternalField_465.Clear();
            InternalField_466.Clear();
        }

        public void Dispose()
        {
            InternalField_465.Dispose();
            InternalField_466.Dispose();
        }

        public static InternalType_174<T36> InternalMethod_841(int InternalParameter_688 = 16) => new InternalType_174<T36>()
        {
            InternalField_465 = new NativeList<T36>(InternalParameter_688, Allocator.Persistent),
            InternalField_466 = new NovaHashMap<T36, int>(InternalParameter_688, Allocator.Persistent),
        };

        public void InternalMethod_703(int InternalParameter_552 = 0)
        {
            InternalField_465.InternalMethod_1020(InternalParameter_552);
            InternalField_466.Init(InternalParameter_552);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator NativeList<T36>(InternalType_174<T36> InternalParameter_689) => InternalParameter_689.InternalField_465;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator NovaHashMap<T36, int>(InternalType_174<T36> InternalParameter_1692) => InternalParameter_1692.InternalField_466;
    }
}

