using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_770<T106>
        where T106 : unmanaged
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_161<InternalType_259, T106> InternalField_3553;

        public T106 this[InternalType_259 InternalParameter_3471]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_3553[InternalParameter_3471];
        }

        public InternalType_770(ref InternalType_161<InternalType_259, T106> InternalParameter_3472)
        {
            this.InternalField_3553 = InternalParameter_3472;
        }
    }

    internal struct InternalType_272<T97>
        where T97 : unmanaged
    {
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_161<InternalType_259, T97> InternalField_856;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeReference<int> InternalField_857;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1251()
        {
            if (InternalField_857.Value == 0)
            {
                Interlocked.Exchange(ref InternalField_857.InternalMethod_1030(), 1);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T97 InternalMethod_1253(InternalType_259 InternalParameter_2219)
        {
            InternalMethod_1251();
            return ref InternalField_856.InternalMethod_748(InternalParameter_2219);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool InternalMethod_1252(InternalType_259 InternalParameter_1304, out T97* InternalParameter_1311)
        {
            InternalMethod_1251();
            return InternalField_856.InternalMethod_747(InternalParameter_1304, out InternalParameter_1311);
        }

        public InternalType_272(ref InternalType_161<InternalType_259, T97> InternalParameter_1316, ref NativeReference<int> InternalParameter_1317)
        {
            this.InternalField_856 = InternalParameter_1316;
            this.InternalField_857 = InternalParameter_1317;
        }
    }

    internal struct InternalType_186<T82,T83> : InternalType_148
        where T82 : unmanaged
        where T83 : unmanaged
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_161<InternalType_259, T82> InternalField_850;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_259> InternalField_851;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeReference<int> InternalField_854;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_852;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private ComputeBuffer InternalProperty_292
        {
            get => InternalField_853[InternalField_852];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1247()
        {
            InternalField_854.Value = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1243()
        {
            InternalField_854.Value = 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T82 InternalMethod_1242(InternalType_259 InternalParameter_2191)
        {
            InternalMethod_1243();
            return ref InternalField_850.InternalMethod_748(InternalParameter_2191);
        }

        
        public unsafe bool InternalMethod_1249(bool InternalParameter_2192 = false)
        {
            if (InternalField_850.InternalProperty_216 == 0 || (InternalField_854.Value == 0 && !InternalParameter_2192))
            {
                return false;
            }

            bool InternalVar_1 = false;
            ComputeBuffer InternalVar_2 = InternalProperty_292;

            NativeArray<T82> InternalVar_3 = InternalField_850.InternalProperty_228.AsArray();
            NativeArray<T83> InternalVar_4 = InternalVar_3.Reinterpret<T83>(sizeof(T82));
            if (InternalVar_2 == null || InternalVar_2.count < InternalVar_4.Length)
            {
                if (InternalVar_2 != null)
                {
                    InternalVar_1 = true;
                    InternalVar_2.Dispose();
                }
                InternalVar_2 = new ComputeBuffer(Mathf.Max(InternalVar_4.Length, InternalType_178.InternalField_3013), sizeof(T83), ComputeBufferType.Structured);
                InternalField_853[InternalField_852] = InternalVar_2;
            }

            InternalVar_2.SetData(InternalVar_4, 0, 0, InternalVar_4.Length);
            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_259 InternalMethod_1246()
        {
            InternalMethod_1243();
            if (!InternalField_851.InternalMethod_1012(out InternalType_259 InternalVar_1))
            {
                InternalVar_1 = InternalField_850.InternalProperty_216;
                InternalField_850.InternalMethod_751(default);
            }
            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void InternalMethod_1237(ref InternalType_164<InternalType_259> InternalParameter_2193, int InternalParameter_2194)
        {
            InternalMethod_1243();
            if (InternalField_851.Length > 0)
            {
                int InternalVar_1 = math.max(0, InternalField_851.Length - InternalParameter_2194);
                int InternalVar_2 = InternalField_851.Length - InternalVar_1;
                InternalParameter_2193.InternalMethod_789(InternalField_851.InternalMethod_1015() + InternalVar_1, InternalVar_2);
                InternalParameter_2194 -= InternalVar_2;
                InternalField_851.Length -= InternalVar_2;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_2194; InternalVar_1++)
            {
                InternalParameter_2193.InternalMethod_785(InternalMethod_1246());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1245(InternalType_259 InternalParameter_2195)
        {
            InternalField_851.Add(InternalParameter_2195);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void InternalMethod_1244(InternalType_164<InternalType_259> InternalParameter_2196, int InternalParameter_2197, int InternalParameter_2198)
        {
            InternalField_851.AddRange(InternalParameter_2196.InternalProperty_232 + InternalParameter_2197, InternalParameter_2198);
        }

        public InternalType_272<T82> InternalMethod_1248()
        {
            return new InternalType_272<T82>(ref InternalField_850, ref InternalField_854);
        }

        public InternalType_770<T82> InternalMethod_3560()
        {
            return new InternalType_770<T82>(ref InternalField_850);
        }

        public void Dispose()
        {
            InternalField_850.Dispose();
            InternalField_851.Dispose();
            InternalField_854.Dispose();
            InternalMethod_1239(InternalField_852);
        }

        public unsafe void InternalMethod_703(int InternalParameter_552 = 0)
        {
            InternalField_852 = InternalMethod_1240();
            InternalField_850.InternalMethod_703(InternalParameter_552);
            InternalField_851.InternalMethod_1020(16);
            InternalField_854.InternalMethod_1032();

        }

        public static implicit operator ComputeBuffer(InternalType_186<T82, T83> InternalParameter_2217) => InternalParameter_2217.InternalProperty_292;

        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private static List<int> InternalField_855 = new List<int>(InternalType_178.InternalField_3012);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static List<ComputeBuffer> InternalField_853 = new List<ComputeBuffer>(InternalType_178.InternalField_3012);

        private static void InternalMethod_1239(int InternalParameter_2218)
        {
            ComputeBuffer InternalVar_1 = InternalField_853[InternalParameter_2218];
            InternalVar_1.InternalMethod_846();
            InternalField_855.Add(InternalParameter_2218);
        }

        private static int InternalMethod_1240()
        {
            if (!InternalField_855.InternalMethod_995(out int InternalVar_1))
            {
                InternalVar_1 = InternalField_853.Count;
                InternalField_853.Add(null);
            }
            return InternalVar_1;
        }

        public static void InternalMethod_1238()
        {
            InternalField_853.InternalMethod_997();
            InternalField_853.Clear();
        }
        #endregion
    }
}

