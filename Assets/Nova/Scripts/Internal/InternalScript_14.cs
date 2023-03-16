using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_4
{
    internal interface InternalType_160<T25> : IComparable<T25>, IEquatable<T25> where T25 : InternalType_160<T25>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        int InternalProperty_227 { get; }
    }

    
    
    internal unsafe struct InternalType_161<T26,T27> : InternalType_148, InternalType_149
        where T26 : unmanaged, InternalType_160<T26>
        where T27 : unmanaged
    {
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<T27> InternalField_450;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<T27> InternalProperty_228
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_450;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_216
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_450.Length;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                InternalField_450.Length = value;
            }
        }

        public void InternalMethod_705()
        {
            InternalField_450.Clear();
        }

        public T27 this[T26 InternalParameter_573]
        {
            get
            {
                return InternalField_450[InternalParameter_573.InternalProperty_227];
            }
            set
            {
                InternalField_450[InternalParameter_573.InternalProperty_227] = value;
            }
        }

        public bool InternalMethod_747(T26 InternalParameter_574, out T27* InternalParameter_575)
        {
            if (InternalParameter_574.InternalProperty_227 >= InternalField_450.Length)
            {
                Debug.LogError($"Tried to read at index {InternalParameter_574.InternalProperty_227}, length was {InternalField_450.Length}");
                InternalParameter_575 = null;
                return false;
            }
            InternalParameter_575 = (T27*)InternalField_450.GetUnsafePtr() + InternalParameter_574.InternalProperty_227;
            return true;
        }

        public ref T27 InternalMethod_748(T26 InternalParameter_576)
        {
            return ref InternalField_450.ElementAt(InternalParameter_576.InternalProperty_227);
        }

        public void InternalMethod_749(T26 InternalParameter_577)
        {
            InternalField_450.RemoveAtSwapBack(InternalParameter_577.InternalProperty_227);
        }

        public void InternalMethod_750(ref T27 InternalParameter_578)
        {
            InternalField_450.Add(InternalParameter_578);
        }

        public void InternalMethod_751(T27 InternalParameter_579)
        {
            InternalField_450.Add(InternalParameter_579);
        }

        public void Dispose()
        {
            InternalField_450.Dispose();
        }

        public void InternalMethod_703(int InternalParameter_552 = 0)
        {
            InternalField_450.InternalMethod_1020(InternalParameter_552);
        }
    }

    
    internal unsafe struct InternalType_162<T28,T29> : InternalType_148, InternalType_149
    where T28 : unmanaged, InternalType_160<T28>
    where T29 : unmanaged
    {
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<T29> InternalField_451;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T29* InternalProperty_230
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_451.InternalProperty_232;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_216
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_451.InternalProperty_216;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                InternalField_451.InternalProperty_216 = value;
            }
        }

        public void InternalMethod_705()
        {
            InternalField_451.InternalMethod_705();
        }

        public void InternalMethod_754(int InternalParameter_580)
        {
            InternalField_451.InternalMethod_793(InternalParameter_580);
        }

        public T29 this[T28 InternalParameter_581]
        {
            get
            {
                return InternalField_451[InternalParameter_581.InternalProperty_227];
            }
            set
            {
                InternalField_451[InternalParameter_581.InternalProperty_227] = value;
            }
        }

        public bool InternalMethod_757(T28 InternalParameter_582, out T29* InternalParameter_583)
        {
            if (InternalParameter_582.InternalProperty_227 >= InternalField_451.InternalProperty_216)
            {
                Debug.LogError($"Tried to read at index {InternalParameter_582.InternalProperty_227}, length was {InternalField_451.InternalProperty_216}");
                InternalParameter_583 = null;
                return false;
            }
            InternalParameter_583 = InternalField_451.InternalProperty_232 + InternalParameter_582.InternalProperty_227;
            return true;
        }

        public ref T29 InternalMethod_758(T28 InternalParameter_584)
        {
            return ref InternalField_451.InternalMethod_800(InternalParameter_584.InternalProperty_227);
        }

        public void InternalMethod_759(T28 InternalParameter_585)
        {
            InternalField_451.InternalMethod_786(InternalParameter_585.InternalProperty_227);
        }

        public void InternalMethod_760(ref T29 InternalParameter_586)
        {
            InternalField_451.InternalMethod_785(InternalParameter_586);
        }

        public void InternalMethod_761(T29 InternalParameter_587)
        {
            InternalField_451.InternalMethod_785(InternalParameter_587);
        }

        public void Dispose()
        {
            InternalField_451.Dispose();
        }

        public void InternalMethod_703(int InternalParameter_552 = 0)
        {
            InternalField_451.InternalMethod_775(InternalParameter_552);
        }
    }

    internal static partial class InternalType_163
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_762<K, V, U>(ref this InternalType_162<K, V> InternalParameter_588, U InternalParameter_589, out int InternalParameter_590, int InternalParameter_591 = 0)
            where K : unmanaged, InternalType_160<K>
            where V : unmanaged, IEquatable<U>
        {
            return InternalParameter_588.InternalField_451.InternalMethod_769(InternalParameter_589, out InternalParameter_590, InternalParameter_591);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_763<K, V>(ref this InternalType_162<K, V> InternalParameter_592)
            where K : unmanaged, InternalType_160<K>
            where V : unmanaged
        {
            UnsafeUtility.MemClear(InternalParameter_592.InternalProperty_230, sizeof(V) * InternalParameter_592.InternalProperty_216);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_764<K, V>(this ref InternalType_161<K, V> InternalParameter_593) where K : unmanaged, InternalType_160<K> where V : unmanaged, IDisposable
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_593.InternalProperty_216; ++InternalVar_1)
            {
                InternalParameter_593.InternalProperty_228.ElementAt(InternalVar_1).Dispose();
            }
            InternalParameter_593.InternalMethod_705();
            InternalParameter_593.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_765<K, V>(this ref InternalType_162<K, V> InternalParameter_594) where K : unmanaged, InternalType_160<K> where V : unmanaged, IDisposable
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_594.InternalProperty_216; ++InternalVar_1)
            {
                InternalParameter_594.InternalField_451.InternalMethod_800(InternalVar_1).Dispose();
            }
            InternalParameter_594.InternalMethod_705();
            InternalParameter_594.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_766<K, V>(this ref InternalType_162<K, V> InternalParameter_595, ref InternalType_164<V> InternalParameter_596)
            where K : unmanaged, InternalType_160<K>
            where V : unmanaged, InternalType_150
        {
            InternalParameter_595.InternalField_451.InternalMethod_780(ref InternalParameter_596);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_767<K, V>(ref this InternalType_162<K, V> InternalParameter_597)
            where K : unmanaged, InternalType_160<K>
            where V : unmanaged, InternalType_147
        {
            V InternalVar_1 = default;
            InternalVar_1.InternalMethod_702();
            InternalParameter_597.InternalMethod_761(InternalVar_1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_768<K, V>(ref this InternalType_161<K, V> InternalParameter_598)
            where K : unmanaged, InternalType_160<K>
            where V : unmanaged, InternalType_147
        {
            V InternalVar_1 = default;
            InternalVar_1.InternalMethod_702();
            InternalParameter_598.InternalMethod_751(InternalVar_1);
        }
    }
}

