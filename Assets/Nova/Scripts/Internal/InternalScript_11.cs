using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_4
{
    internal struct InternalType_165 : IDisposable
    {
        public struct InternalType_166
        {
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NativeList<BitField32> InternalField_455;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NativeList<int> InternalField_456;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalProperty_237
            {
                get => InternalField_456[0];
                set
                {
                    InternalMethod_815(value, out int InternalVar_1, out int InternalVar_2);

                    InternalField_455.Length = math.select(InternalVar_1, InternalVar_1 + 1, InternalVar_2 != 0);
                    InternalField_456[0] = InternalField_455.Length;
                }
            }

            public bool this[int InternalParameter_663]
            {
                get
                {
                    if (InternalParameter_663 < 0)
                    {
                        Debug.LogError($"Value {InternalParameter_663} must be positive.");
                    }
                    if ((uint)InternalParameter_663 >= (uint)InternalField_456[0])
                    {
                        Debug.LogError($"Value {InternalParameter_663} is out of range in NativeBitList of '{InternalField_456[0]}' Length.");
                    }

                    InternalMethod_815(InternalParameter_663, out int InternalVar_1, out int InternalVar_2);

                    BitField32 InternalVar_3 = InternalField_455[InternalVar_1];
                    return InternalVar_3.IsSet(InternalVar_2);
                }
            }

            public InternalType_166(InternalType_165 InternalParameter_664)
            {
                InternalField_455 = InternalParameter_664.InternalField_453;
                InternalField_456 = InternalParameter_664.InternalField_454;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<BitField32> InternalField_453;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<int> InternalField_454;

        public InternalType_166 InternalMethod_805() => new InternalType_166(this);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_235
        {
            get => InternalField_454[0];
            set
            {
                InternalMethod_815(value, out int InternalVar_1, out int InternalVar_2);

                InternalField_453.Length = math.select(InternalVar_1, InternalVar_1 + 1, InternalVar_2 != 0);
                InternalField_454[0] = InternalField_453.Length;
            }
        }

        public bool this[int InternalParameter_653]
        {
            get
            {
                if (InternalParameter_653 < 0)
                {
                    Debug.LogError($"Value {InternalParameter_653} must be positive.");
                }
                if ((uint)InternalParameter_653 >= (uint)InternalField_454[0])
                {
                    Debug.LogError($"Value {InternalParameter_653} is out of range in NativeBitList of '{InternalField_454[0]}' Length.");
                }

                InternalMethod_815(InternalParameter_653, out int InternalVar_1, out int InternalVar_2);

                BitField32 InternalVar_3 = InternalField_453[InternalVar_1];
                return InternalVar_3.IsSet(InternalVar_2);
            }
            set
            {
                if (InternalParameter_653 < 0)
                {
                    Debug.LogError($"Value {InternalParameter_653} must be positive.");
                }
                if ((uint)InternalParameter_653 >= (uint)InternalField_454[0])
                {
                    Debug.LogError($"Value {InternalParameter_653} is out of range in NativeBitList of '{InternalField_454}' Length.");
                }

                InternalMethod_815(InternalParameter_653, out int InternalVar_1, out int InternalVar_2);

                BitField32 InternalVar_3 = InternalField_453[InternalVar_1];
                InternalVar_3.SetBits(InternalVar_2, value);
                InternalField_453[InternalVar_1] = InternalVar_3;
            }
        }

        public InternalType_165(int InternalParameter_654, Allocator InternalParameter_655)
        {
            InternalField_453 = new NativeList<BitField32>(InternalMethod_814(InternalParameter_654), InternalParameter_655);
            InternalField_454 = new NativeList<int>(1, InternalParameter_655);
            InternalField_454.Add(0);
        }

        public void InternalMethod_811(bool InternalParameter_656)
        {
            int InternalVar_1 = InternalField_454[0];
            InternalMethod_815(InternalVar_1, out int InternalVar_2, out int InternalVar_3);

            if (InternalVar_2 >= InternalField_453.Length)
            {
                InternalField_453.Add(new BitField32());
            }

            BitField32 InternalVar_4 = InternalField_453[InternalVar_2];
            InternalVar_4.SetBits(InternalVar_3, InternalParameter_656);
            InternalField_453[InternalVar_2] = InternalVar_4;

            InternalVar_1++;

            InternalField_454[0] = InternalVar_1;
        }

        public void InternalMethod_812(int InternalParameter_657)
        {
            int InternalVar_1 = InternalField_454[0];
            this[InternalParameter_657] = this[InternalVar_1 - 1];
            InternalVar_1--;

            InternalField_454[0] = InternalVar_1;

        }

        public void InternalMethod_813(bool InternalParameter_658)
        {
            unsafe
            {
                UnsafeUtility.MemSet(InternalField_453.GetUnsafePtr(), InternalParameter_658 ? (byte)0xFF : (byte)0x00, InternalField_453.Length * sizeof(uint));
            }
        }

        private static int InternalMethod_814(int InternalParameter_659)
        {
            InternalMethod_815(InternalParameter_659, out int InternalVar_1, out int InternalVar_2);
            return math.select(InternalVar_1 + 1, InternalVar_1, InternalVar_2 == 0);
        }

        private static void InternalMethod_815(int InternalParameter_660, out int InternalParameter_661, out int InternalParameter_662)
        {
            InternalParameter_661 = InternalParameter_660 / 32;
            InternalParameter_662 = InternalParameter_660 % 32;
        }

        public void Dispose()
        {
            InternalField_453.Dispose();
            InternalField_454.Dispose();
        }
    }
}
