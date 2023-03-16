using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    internal static class InternalType_208
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_1011<TList, TFind>(ref this NativeList<TList> InternalParameter_1004, TFind InternalParameter_1005, out int InternalParameter_1006) where TList : unmanaged, IEquatable<TFind>
        {
            InternalParameter_1006 = Unity.Collections.NativeArrayExtensions.IndexOf(InternalParameter_1004.AsArray(), InternalParameter_1005);
            return InternalParameter_1006 >= 0 && InternalParameter_1006 < InternalParameter_1004.Length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_1012<T>(ref this NativeList<T> InternalParameter_1007, out T InternalParameter_1008) where T : unmanaged
        {
            if (InternalParameter_1007.Length > 0)
            {
                InternalParameter_1008 = InternalParameter_1007[InternalParameter_1007.Length - 1];
                InternalParameter_1007.RemoveAtSwapBack(InternalParameter_1007.Length - 1);
                return true;
            }
            else
            {
                InternalParameter_1008 = default;
                return false;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_1013<T>(ref this NativeList<T> InternalParameter_1009, ref InternalType_164<T> InternalParameter_1010) where T : unmanaged
        {
            InternalParameter_1009.AddRange(InternalParameter_1010.InternalProperty_232, InternalParameter_1010.InternalProperty_216);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_1014<T>(ref this NativeList<T> InternalParameter_1011, ref InternalType_164<T> InternalParameter_1012) where T : unmanaged
        {
            for (int InternalVar_1 = InternalParameter_1012.InternalProperty_216 - 1; InternalVar_1 >= 0; --InternalVar_1)
            {
                InternalParameter_1011.Add(InternalParameter_1012.InternalMethod_800(InternalVar_1));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static T* InternalMethod_1015<T>(ref this NativeList<T> InternalParameter_1013) where T : unmanaged
        {
            return (T*)InternalParameter_1013.GetUnsafePtr();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1016<T>(ref this NativeList<T> InternalParameter_1014, int InternalParameter_1015, T InternalParameter_1016) where T : unmanaged
        {
            unsafe
            {
                InternalParameter_1014.InternalMethod_1017(InternalParameter_1015, &InternalParameter_1016, 1);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void InternalMethod_1017<T>(this ref NativeList<T> InternalParameter_1017, int InternalParameter_1018, T* InternalParameter_1019, int InternalParameter_1020) where T : unmanaged
        {
            if (InternalParameter_1018 == InternalParameter_1017.Length)
            {
                InternalParameter_1017.AddRange(InternalParameter_1019, InternalParameter_1020);
                return;
            }

            if (InternalParameter_1018 < 0 || InternalParameter_1018 > InternalParameter_1017.Length)
            {
                Debug.LogError($"Expected within range [0, {InternalParameter_1017.Length}) but got {InternalParameter_1018}");
                return;
            }

            InternalParameter_1017.Length += InternalParameter_1020;

            int InternalVar_1 = UnsafeUtility.SizeOf<T>();

            T* InternalVar_2 = (T*)InternalParameter_1017.GetUnsafePtr();
            T* InternalVar_3 = InternalVar_2 + InternalParameter_1018;
            T* InternalVar_4 = InternalVar_3 + InternalParameter_1020;
            UnsafeUtility.MemMove(InternalVar_4, InternalVar_3, InternalVar_1 * (InternalParameter_1017.Length - InternalParameter_1018 - InternalParameter_1020));
            UnsafeUtility.MemCpy(InternalVar_3, InternalParameter_1019, InternalParameter_1020 * InternalVar_1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T InternalMethod_1018<T>(this ref NativeList<T> InternalParameter_1021) where T : unmanaged
        {
            return InternalParameter_1021[InternalParameter_1021.Length - 1];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1019<T>(this ref NativeList<T> InternalParameter_1022) where T : unmanaged
        {
            InternalParameter_1022.RemoveAt(InternalParameter_1022.Length - 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1020<T>(this ref NativeList<T> InternalParameter_1023, int InternalParameter_1024 = 0) where T : unmanaged
        {
            InternalParameter_1023 = new NativeList<T>(InternalParameter_1024, Allocator.Persistent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1021<T>(this ref NativeList<T> InternalParameter_1025, ref NativeList<T> InternalParameter_1026) where T : unmanaged
        {
            InternalParameter_1025.Length = InternalParameter_1026.Length;
            InternalParameter_1025.AsArray().CopyFrom(InternalParameter_1026.AsArray());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1022<T>(this ref NativeList<T> InternalParameter_1027) where T : unmanaged, IDisposable
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_1027.Length; ++InternalVar_1)
            {
                InternalParameter_1027[InternalVar_1].Dispose();
            }
            InternalParameter_1027.Clear();
            InternalParameter_1027.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1023<T>(this ref NativeList<T> InternalParameter_1028) where T : unmanaged, IDisposable
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_1028.Length; ++InternalVar_1)
            {
                InternalParameter_1028[InternalVar_1].Dispose();
            }
            InternalParameter_1028.Clear();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T InternalMethod_1024<T>(this NativeList<T> InternalParameter_1029) where T : unmanaged, InternalType_147
        {
            if (!InternalParameter_1029.InternalMethod_1012(out T InternalVar_1))
            {
                InternalVar_1.InternalMethod_702();
            }
            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_164<T> InternalMethod_1025<T>(this NativeList<InternalType_164<T>> InternalParameter_1030) where T : unmanaged
        {
            if (!InternalParameter_1030.InternalMethod_1012(out InternalType_164<T> InternalVar_1))
            {
                InternalVar_1.InternalMethod_702();
            }
            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_162<T, V> InternalMethod_1026<T, V>(this NativeList<InternalType_162<T, V>> InternalParameter_1031)
                where T : unmanaged, InternalType_160<T>
                where V : unmanaged
        {
            if (!InternalParameter_1031.InternalMethod_1012(out InternalType_162<T, V> InternalVar_1))
            {
                InternalVar_1.InternalMethod_703();
            }
            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1027<T>(this NativeList<T> InternalParameter_1032, ref T InternalParameter_1033) where T : unmanaged, InternalType_150
        {
            InternalParameter_1033.InternalMethod_705();
            InternalParameter_1032.Add(InternalParameter_1033);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1028<T>(this NativeList<T> InternalParameter_1034, T InternalParameter_1035) where T : unmanaged, InternalType_150
        {
            InternalParameter_1035.InternalMethod_705();
            InternalParameter_1034.Add(InternalParameter_1035);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1029<T>(this NativeList<InternalType_164<T>> InternalParameter_1036, ref InternalType_164<T> InternalParameter_1037) where T : unmanaged
        {
            InternalParameter_1037.InternalMethod_705();
            InternalParameter_1036.Add(InternalParameter_1037);
        }
    }
}

