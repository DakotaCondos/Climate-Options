using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_4
{
    internal unsafe struct InternalType_164<T95> : InternalType_147, InternalType_149 where T95 : unmanaged
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public UnsafeList<T95> InternalField_452;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_216
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_452.Length;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => InternalField_452.Resize(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_785(T95 InternalParameter_633) => InternalField_452.Add(InternalParameter_633);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_786(int InternalParameter_634)
        {
            if (InternalMethod_803(InternalParameter_634))
            {
                InternalField_452.RemoveAtSwapBack(InternalParameter_634);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_787(ref InternalType_164<T95> InternalParameter_635)
        {
            if (InternalParameter_635.InternalProperty_216 > 0)
            {
                InternalField_452.AddRange(InternalParameter_635.InternalProperty_232, InternalParameter_635.InternalProperty_216);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_788(ref NativeList<T95> InternalParameter_636)
        {
            if (InternalParameter_636.Length > 0)
            {
                InternalField_452.AddRange(InternalParameter_636.InternalMethod_1015(), InternalParameter_636.Length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_789(T95* InternalParameter_637, int InternalParameter_638)
        {
            if (InternalParameter_638 > 0)
            {
                InternalField_452.AddRange(InternalParameter_637, InternalParameter_638);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_790(void* InternalParameter_639, int InternalParameter_640)
        {
            InternalField_452.AddRangeNoResize(InternalParameter_639, InternalParameter_640);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_791(int InternalParameter_641)
        {
            if (InternalMethod_803(InternalParameter_641))
            {
                InternalField_452.RemoveAt(InternalParameter_641);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_792(out T95 InternalParameter_642)
        {
            if (InternalField_452.Length > 0)
            {
                InternalParameter_642 = InternalField_452[InternalField_452.Length - 1];
                InternalField_452.RemoveAtSwapBack(InternalField_452.Length - 1);
                return true;
            }
            else
            {
                InternalParameter_642 = default;
                return false;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_793(int InternalParameter_643)
        {
            InternalProperty_216 = InternalParameter_643;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_794(ref InternalType_164<T95> InternalParameter_644)
        {
            for (int InternalVar_1 = InternalParameter_644.InternalProperty_216 - 1; InternalVar_1 >= 0; --InternalVar_1)
            {
                InternalField_452.Add(InternalParameter_644[InternalVar_1]);
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T95* InternalProperty_232
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_452.Ptr;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_233
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_452.Capacity;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => InternalField_452.Capacity = value;
        }

        public T95 this[int InternalParameter_645]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (InternalMethod_803(InternalParameter_645))
                {
                    return InternalField_452[InternalParameter_645];
                }
                else
                {
                    return default;
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (InternalMethod_803(InternalParameter_645))
                {
                    InternalField_452[InternalParameter_645] = value;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T95 InternalMethod_800(int InternalParameter_646)
        {
            if (InternalMethod_803(InternalParameter_646))
            {
                return ref InternalField_452.ElementAt(InternalParameter_646);
            }
            else
            {
                return ref InternalField_452.ElementAt(InternalParameter_646);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_801(int InternalParameter_647, T95 InternalParameter_648) => InternalField_452.InternalMethod_1042(InternalParameter_647, InternalParameter_648);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_705() => InternalField_452.Clear();

        public InternalType_164(int InternalParameter_649, Allocator InternalParameter_650, NativeArrayOptions InternalParameter_651 = NativeArrayOptions.UninitializedMemory)
        {
            InternalField_452 = new UnsafeList<T95>(InternalParameter_649 > 0 ? InternalParameter_649 : 1, InternalParameter_650 == Allocator.Persistent ? InternalType_167.InternalField_457 : InternalParameter_650, InternalParameter_651);
        }

        public void Dispose()
        {
            InternalField_452.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool InternalMethod_803(int InternalParameter_652)
        {
            if (InternalParameter_652 >= 0 && InternalParameter_652 < InternalField_452.Length)
            {
                return true;
            }
            else
            {
                Debug.LogError($"Index out of range. Requested {InternalParameter_652}, but list was length {InternalField_452.Length}");
                return false;
            }
        }

        public RawPtrArrayWrapper<T95> InternalMethod_804()
        {
            return new RawPtrArrayWrapper<T95>(InternalField_452.Ptr, InternalField_452.Length);
        }

        public void InternalMethod_702()
        {
            InternalField_452 = new UnsafeList<T95>(1, InternalType_167.InternalField_457, NativeArrayOptions.UninitializedMemory);
        }
    }


    internal static partial class InternalType_163
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_769<T, U>(ref this InternalType_164<T> InternalParameter_599, U InternalParameter_600, out int InternalParameter_601, int InternalParameter_602 = 0) where T : unmanaged, IEquatable<U>
        {
            InternalParameter_602 = math.max(0, InternalParameter_602);
            unsafe
            {
                int InternalVar_1 = InternalParameter_599.InternalProperty_216;
                T* InternalVar_2 = InternalParameter_599.InternalProperty_232;

                for (int InternalVar_3 = InternalParameter_602; InternalVar_3 < InternalVar_1; ++InternalVar_3)
                {
                    if (InternalVar_2[InternalVar_3].Equals(InternalParameter_600))
                    {
                        InternalParameter_601 = InternalVar_3;
                        return true;
                    }
                }
            }

            InternalParameter_601 = -1;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_770<T, C>(ref this InternalType_164<T> InternalParameter_603, T InternalParameter_604, C InternalParameter_605, out int InternalParameter_606, int InternalParameter_607 = 0)
            where T : unmanaged
            where C : unmanaged, System.Collections.Generic.IComparer<T>
        {
            InternalParameter_607 = math.max(0, InternalParameter_607);
            unsafe
            {
                int InternalVar_1 = InternalParameter_603.InternalProperty_216;
                T* InternalVar_2 = InternalParameter_603.InternalProperty_232;

                for (int InternalVar_3 = InternalParameter_607; InternalVar_3 < InternalVar_1; ++InternalVar_3)
                {
                    if (InternalParameter_605.Compare(InternalVar_2[InternalVar_3], InternalParameter_604) == 0)
                    {
                        InternalParameter_606 = InternalVar_3;
                        return true;
                    }
                }
            }

            InternalParameter_606 = -1;
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_771<T>(this ref InternalType_164<T> InternalParameter_608, T[] InternalParameter_609, int InternalParameter_610, int InternalParameter_611 = 0, int InternalParameter_612 = 0) where T : unmanaged
        {
            if (InternalParameter_609 == null)
            {
                Debug.LogError("Tried to copy from null array");
                return;
            }

            if (InternalParameter_608.InternalProperty_216 < (InternalParameter_611 + InternalParameter_610) || InternalParameter_609.Length < (InternalParameter_612 + InternalParameter_610))
            {
                Debug.LogError($"Tried to copy {InternalParameter_610} elements with a source length of {InternalParameter_609.Length} and dest length of {InternalParameter_608.InternalProperty_216}");
                return;
            }

            fixed (T* srcPtr = InternalParameter_609)
            {
                InternalType_188.InternalMethod_952(InternalParameter_608.InternalProperty_232 + InternalParameter_611, srcPtr + InternalParameter_612, InternalParameter_610);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_772<T>(this ref InternalType_164<T> InternalParameter_613) where T : unmanaged
        {
            InternalParameter_613 = new InternalType_164<T>(0, Allocator.Persistent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_773<T>(this ref InternalType_164<T> InternalParameter_614, T InternalParameter_615) where T : unmanaged
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_614.InternalProperty_216; ++InternalVar_1)
            {
                InternalParameter_614[InternalVar_1] = InternalParameter_615;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_774<T>(this ref InternalType_164<T> InternalParameter_616) where T : unmanaged
        {
            UnsafeUtility.MemClear(InternalParameter_616.InternalProperty_232, sizeof(T) * InternalParameter_616.InternalProperty_216);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_775<T>(this ref InternalType_164<T> InternalParameter_617, int InternalParameter_618 = 0) where T : unmanaged
        {
            InternalParameter_617 = new InternalType_164<T>(InternalParameter_618, Allocator.Persistent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_776<T>(this ref InternalType_164<T> InternalParameter_619) where T : unmanaged, IDisposable
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_619.InternalProperty_216; ++InternalVar_1)
            {
                InternalParameter_619[InternalVar_1].Dispose();
            }
            InternalParameter_619.InternalMethod_705();
            InternalParameter_619.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_777<T>(this ref InternalType_164<T> InternalParameter_620, T* InternalParameter_621) where T : unmanaged
        {
            UnsafeUtility.MemCpy(InternalParameter_621, InternalParameter_620.InternalProperty_232, sizeof(T) * InternalParameter_620.InternalProperty_216);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_778<T>(this ref InternalType_164<T> InternalParameter_622) where T : unmanaged, IComparable<T>
        {
            InternalParameter_622.InternalField_452.Sort();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_779<T, U>(this ref InternalType_164<T> InternalParameter_623, U InternalParameter_624) where T : unmanaged where U : System.Collections.Generic.IComparer<T>
        {
            InternalParameter_623.InternalField_452.Sort(InternalParameter_624);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_780<T>(this ref InternalType_164<T> InternalParameter_625, ref InternalType_164<T> InternalParameter_626) where T : unmanaged, InternalType_150
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_625.InternalProperty_216; ++InternalVar_1)
            {
                ref T InternalVar_2 = ref InternalParameter_625.InternalMethod_800(InternalVar_1);
                InternalVar_2.InternalMethod_705();
                InternalParameter_626.InternalMethod_785(InternalVar_2);
            }
            InternalParameter_625.InternalMethod_705();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static InternalType_164<U> InternalMethod_781<T, U>(this InternalType_164<T> InternalParameter_627) where T : unmanaged where U : unmanaged
        {
            return new InternalType_164<U>()
            {
                InternalField_452 = new UnsafeList<U>((U*)InternalParameter_627.InternalProperty_232, InternalParameter_627.InternalProperty_216),
            };
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_782<T, U>(ref this InternalType_164<T> InternalParameter_628, U InternalParameter_629) where T : unmanaged, IEquatable<U>
        {
            if (!InternalParameter_628.InternalMethod_769(InternalParameter_629, out int InternalVar_1))
            {
                return false;
            }
            InternalParameter_628.InternalMethod_786(InternalVar_1);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_783<T>(this ref InternalType_164<T> InternalParameter_630, int InternalParameter_631, int InternalParameter_632) where T : unmanaged
        {
            T InternalVar_1 = InternalParameter_630.InternalMethod_800(InternalParameter_631);
            InternalParameter_630.InternalMethod_800(InternalParameter_631) = InternalParameter_630.InternalMethod_800(InternalParameter_632);
            InternalParameter_630.InternalMethod_800(InternalParameter_632) = InternalVar_1;
        }
    }
}

