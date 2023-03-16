using Nova.InternalNamespace_0.InternalNamespace_4;
using System;
using System.Collections.Generic;

namespace Nova.InternalNamespace_0.InternalNamespace_11
{
    internal class InternalType_761<T105> where T105 : class, InternalType_5
    {
        public struct InternalType_762 : IEquatable<InternalType_762>
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public uint InternalField_3601;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_3602;

            public InternalType_762(uint InternalParameter_3417, int InternalParameter_3418)
            {
                InternalField_3601 = InternalParameter_3417;
                InternalField_3602 = InternalParameter_3418;
            }

            public static implicit operator InternalType_762(uint InternalParameter_3419)
            {
                return new InternalType_762() { InternalField_3601 = InternalParameter_3419 };
            }

            public bool Equals(InternalType_762 other)
            {
                return InternalField_3601 == other.InternalField_3601;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<uint, List<T105>> InternalField_3599 = new Dictionary<uint, List<T105>>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<T105, InternalType_153<InternalType_762>> InternalField_3600 = new Dictionary<T105, InternalType_153<InternalType_762>>();

        public void InternalMethod_3623(uint InternalParameter_3405, T105 InternalParameter_3406, int InternalParameter_3407)
        {
            if (!InternalField_3599.TryGetValue(InternalParameter_3405, out List<T105> InternalVar_1))
            {
                InternalVar_1 = new List<T105>();
                InternalField_3599.Add(InternalParameter_3405, InternalVar_1);
            }

            if (!InternalField_3600.TryGetValue(InternalParameter_3406, out InternalType_153<InternalType_762> InternalVar_2))
            {
                InternalVar_2 = InternalType_156<InternalType_153<InternalType_762>, InternalType_762>.InternalMethod_740();
                InternalField_3600[InternalParameter_3406] = InternalVar_2;
            }

            if (!InternalVar_2.Contains(InternalParameter_3405))
            {
                InternalVar_2.Add(new InternalType_762(InternalParameter_3405, InternalParameter_3407));
            }

            InternalVar_1.Remove(InternalParameter_3406);
            InternalVar_1.Add(InternalParameter_3406);
        }

        public T105 InternalMethod_3624(uint InternalParameter_3408)
        {
            T105 InternalVar_1 = InternalMethod_3627(InternalParameter_3408);

            if (InternalVar_1 != null)
            {
                InternalMethod_3625(InternalParameter_3408, InternalVar_1);
            }

            return InternalVar_1;
        }

        public void InternalMethod_3625(uint InternalParameter_3409, T105 InternalParameter_3410)
        {
            if (!InternalField_3599.TryGetValue(InternalParameter_3409, out List<T105> InternalVar_1))
            {
                return;
            }

            if (InternalField_3600.TryGetValue(InternalParameter_3410, out InternalType_153<InternalType_762> InternalVar_2))
            {
                InternalVar_2.Remove(InternalParameter_3409);

                if (InternalVar_2.Count == 0)
                {
                    InternalField_3600.Remove(InternalParameter_3410);
                    InternalType_156<InternalType_153<InternalType_762>, InternalType_762>.InternalMethod_741(InternalVar_2);
                }
            }

            InternalVar_1.Remove(InternalParameter_3410);
        }

        public void InternalMethod_3626(uint InternalParameter_3411)
        {
            if (!InternalField_3599.TryGetValue(InternalParameter_3411, out List<T105> InternalVar_1))
            {
                return;
            }

            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1.Count; ++InternalVar_2)
            {
                T105 InternalVar_3 = InternalVar_1[InternalVar_2];

                if (InternalField_3600.TryGetValue(InternalVar_3, out InternalType_153<InternalType_762> InternalVar_4))
                {
                    InternalVar_4.Remove(InternalParameter_3411);

                    if (InternalVar_4.Count == 0)
                    {
                        InternalField_3600.Remove(InternalVar_3);
                        InternalType_156<InternalType_153<InternalType_762>, InternalType_762>.InternalMethod_741(InternalVar_4);
                    }
                }
            }

            InternalVar_1.Clear();
        }

        public T105 InternalMethod_3627(uint InternalParameter_3412)
        {
            if (!InternalField_3599.TryGetValue(InternalParameter_3412, out List<T105> InternalVar_1) || InternalVar_1.Count == 0)
            {
                return null;
            }

            for (int InternalVar_2 = InternalVar_1.Count - 1; InternalVar_2 >= 0; InternalVar_2--)
            {
                T105 InternalVar_3 = InternalVar_1[InternalVar_2];

                if (InternalVar_3 != null)
                {
                    return InternalVar_3;
                }

                InternalVar_1.RemoveAt(InternalVar_2);
            }

            return null;
        }

        public T105 InternalMethod_3628(uint InternalParameter_3413, int InternalParameter_3414)
        {
            if (!InternalField_3599.TryGetValue(InternalParameter_3413, out List<T105> InternalVar_1) || InternalVar_1.Count <= InternalParameter_3414)
            {
                return null;
            }

            return InternalVar_1[InternalVar_1.Count - 1 - InternalParameter_3414];
        }

        public int InternalMethod_3629(uint InternalParameter_3415)
        {
            if (!InternalField_3599.TryGetValue(InternalParameter_3415, out List<T105> InternalVar_1))
            {
                return 0;
            }

            return InternalVar_1.Count;
        }

        public InternalType_521<InternalType_762> InternalMethod_3630(T105 InternalParameter_3416)
        {
            if (InternalField_3600.TryGetValue(InternalParameter_3416, out InternalType_153<InternalType_762> InternalVar_1))
            {
                return InternalVar_1.InternalProperty_221;
            }

            return InternalType_521<InternalType_762>.InternalProperty_435;
        }
    }
}