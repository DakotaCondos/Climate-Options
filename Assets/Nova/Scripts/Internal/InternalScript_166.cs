using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_771
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Matrix4x4 InternalField_1691;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public Vector4 InternalField_3586;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Color InternalField_320;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_3581;
    }

    internal struct InternalType_772<T107> where T107 : unmanaged
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3572;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3610;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3612;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3611;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3621;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3615;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3619;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3618;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3617;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3620;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3616;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3622;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_2212;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3660;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3661;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T107 InternalField_3662;

        public unsafe ref T107 this[int InternalParameter_3474]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (InternalType_772<T107>* array = &this) { return ref ((T107*)array)[InternalParameter_3474]; }
            }
        }
    }

    internal struct InternalType_337
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_3663;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_3664;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_772<InternalType_643> InternalField_3665;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_772<Matrix4x4> InternalField_3666;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_772<Vector4> InternalField_3667;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_772<Color> InternalField_3668;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_3683()
        {
            InternalField_3663 = 0;
            InternalField_3664 = -1;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_3684(InternalType_643 InternalParameter_3475, ref InternalType_771 InternalParameter_3476)
        {
            if (InternalField_3663 == InternalType_178.InternalField_3709)
            {
                return;
            }

            InternalMethod_3685(InternalField_3663++, InternalParameter_3475, ref InternalParameter_3476);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_3685(int InternalParameter_3477, InternalType_643 InternalParameter_3478, ref InternalType_771 InternalParameter_3479)
        {
            InternalField_3665[InternalParameter_3477] = InternalParameter_3478;
            InternalField_3666[InternalParameter_3477] = InternalParameter_3479.InternalField_1691;
            InternalField_3667[InternalParameter_3477] = InternalParameter_3479.InternalField_3586;
            InternalField_3668[InternalParameter_3477] = InternalParameter_3479.InternalField_320;

            if (InternalField_3664 == -1 && InternalParameter_3479.InternalField_3581)
            {
                InternalField_3664 = InternalParameter_3477;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_337 InternalField_3669 = new InternalType_337()
        {
            InternalField_3664 = -1
        };
    }

    internal class InternalType_773
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_3670;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_3671;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Matrix4x4[] InternalField_3672 = new Matrix4x4[InternalType_178.InternalField_3709];
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Vector4[] InternalField_3673 = new Vector4[InternalType_178.InternalField_3709];
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Vector4[] InternalField_3674 = new Vector4[InternalType_178.InternalField_3709];
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_643[] InternalField_3675 = new InternalType_643[InternalType_178.InternalField_3709];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void InternalMethod_3686(InternalType_337 InternalParameter_3480)
        {
            InternalField_3670 = InternalParameter_3480.InternalField_3663;
            InternalField_3671 = InternalParameter_3480.InternalField_3664;

            if (InternalField_3670 == 0)
            {
                return;
            }

            fixed (Matrix4x4* dest = InternalField_3672)
            {
                InternalType_188.InternalMethod_952(dest, (Matrix4x4*)&InternalParameter_3480.InternalField_3666, InternalField_3670);
            }

            fixed (Vector4* dest = InternalField_3673)
            {
                InternalType_188.InternalMethod_952(dest, (Vector4*)&InternalParameter_3480.InternalField_3667, InternalField_3670);
            }

            fixed (Vector4* dest = InternalField_3674)
            {
                InternalType_188.InternalMethod_952(dest, (Vector4*)&InternalParameter_3480.InternalField_3668, InternalField_3670);
            }

            fixed (InternalType_643* dest = InternalField_3675)
            {
                InternalType_188.InternalMethod_952(dest, (InternalType_643*)&InternalParameter_3480.InternalField_3665, InternalField_3670);
            }
        }
    }

    internal class InternalType_338 : InternalType_147
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_643> InternalField_1155;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_643, InternalType_109> InternalField_1164;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_643, InternalType_131> InternalField_1154;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_643, InternalType_771> InternalField_3676;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_643, InternalType_337> InternalField_1166;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public List<InternalType_773> InternalField_3677 = new List<InternalType_773>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_643, InternalType_306> InternalField_1165;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_161<InternalType_643, InternalType_643> InternalField_3678;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public List<Texture> InternalField_1153 = new List<Texture>();

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_274 InternalProperty_319 => InternalType_274.InternalProperty_190;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Stack<InternalType_643> InternalField_1152 = new Stack<InternalType_643>();

        public void InternalMethod_1498(InternalType_131 InternalParameter_1604, InternalType_109 InternalParameter_1605, Texture InternalParameter_1606)
        {
            InternalParameter_1606 = InternalParameter_1605.InternalField_349 ? InternalParameter_1606 : null;

            if (InternalField_1155.TryGetValue(InternalParameter_1604, out InternalType_643 InternalVar_1))
            {
                InternalType_109 InternalVar_2 = InternalField_1164[InternalVar_1];

                if (InternalParameter_1605.Equals(InternalVar_2) && InternalParameter_1606 == InternalField_1153[InternalVar_1])
                {
                    return;
                }

                InternalField_1164[InternalVar_1] = InternalParameter_1605;
                InternalField_1153[InternalVar_1] = InternalParameter_1606;
                InternalProperty_319.InternalField_862.InternalField_1284.InternalMethod_837(InternalParameter_1604);
            }
            else
            {
                if (InternalField_1152.Count > 0)
                {
                    InternalVar_1 = InternalField_1152.Pop();
                    InternalField_1164[InternalVar_1] = InternalParameter_1605;
                    InternalField_1154[InternalVar_1] = InternalParameter_1604;
                    InternalField_1153[InternalVar_1] = InternalParameter_1606;
                    InternalField_3678[InternalVar_1] = InternalType_643.InternalField_1148;
                }
                else
                {
                    InternalVar_1 = InternalField_1164.InternalProperty_216;
                    InternalField_1164.InternalMethod_751(InternalParameter_1605);
                    InternalField_3676.InternalMethod_751(default);
                    InternalField_3677.Add(new InternalType_773());
                    InternalField_1166.InternalMethod_751(default);
                    InternalField_1154.InternalMethod_751(InternalParameter_1604);
                    InternalField_1153.Add(InternalParameter_1606);
                    InternalField_3678.InternalMethod_751(InternalType_643.InternalField_1148);
                }

                InternalField_1155.Add(InternalParameter_1604, InternalVar_1);
                InternalProperty_319.InternalField_862.InternalField_1284.InternalMethod_837(InternalParameter_1604);
            }

            if (InternalParameter_1605.InternalField_349)
            {
                InternalField_1165[InternalVar_1] = default;
            }
            else
            {
                InternalField_1165.Remove(InternalVar_1);
            }
        }

        public void InternalMethod_1499(InternalType_131 InternalParameter_1607)
        {
            if (!InternalField_1155.TryGetValue(InternalParameter_1607, out InternalType_643 InternalVar_1))
            {
                return;
            }

            InternalField_1152.Push(InternalVar_1);
            InternalField_1153[InternalVar_1] = null;
            InternalField_1155.Remove(InternalParameter_1607);
            InternalField_1165.Remove(InternalVar_1);
            InternalProperty_319.InternalField_862.InternalField_1284.InternalMethod_837(InternalParameter_1607);
        }

        public void Dispose()
        {
            InternalField_1155.Dispose();
            InternalField_1164.Dispose();
            InternalField_1165.Dispose();
            InternalField_3676.Dispose();
            InternalField_1166.Dispose();
            InternalField_1154.Dispose();
            InternalField_3678.Dispose();
        }

        public void InternalMethod_702()
        {
            InternalField_1155.Init(InternalType_178.InternalField_3011);
            InternalField_1164.InternalMethod_703(InternalType_178.InternalField_3011);
            InternalField_1165.Init(InternalType_178.InternalField_3011);
            InternalField_3676.InternalMethod_703(InternalType_178.InternalField_3011);
            InternalField_1166.InternalMethod_703(InternalType_178.InternalField_3011);
            InternalField_1154.InternalMethod_703(InternalType_178.InternalField_3011);
            InternalField_3678.InternalMethod_703(InternalType_178.InternalField_3011);
        }
    }
}

