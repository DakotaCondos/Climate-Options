using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using System.Collections.Generic;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_2
{
    internal partial interface InternalType_141
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalProperty_204 { get; }
    }

    internal abstract partial class InternalType_143<T12,T13>
    {
        public class InternalType_144
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_153<InternalType_131> InternalField_436 = null;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private HashSet<int> InternalField_2246 = null;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_143<T12, T13> InternalField_437 = null;

            public void InternalMethod_683()
            {
                if (!NovaApplication.IsEditor)
                {
                    return;
                }

                for (int InternalVar_1 = 0; InternalVar_1 < InternalField_436.Count; ++InternalVar_1)
                {
                    InternalType_141 InternalVar_2 = InternalField_437.InternalField_413[InternalField_436[InternalVar_1]];
                    int InternalVar_3 = InternalField_437.InternalField_432[InternalVar_2.InternalProperty_196].InternalField_427;
                    InternalField_437.InternalField_433[InternalVar_3] = InternalVar_2.InternalProperty_202;
                }
            }

            public void InternalMethod_684()
            {
                if (!NovaApplication.IsEditor)
                {
                    return;
                }

                for (int InternalVar_1 = 0; InternalVar_1 < InternalField_436.Count; ++InternalVar_1)
                {
                    InternalType_141 InternalVar_2 = InternalField_437.InternalField_413[InternalField_436[InternalVar_1]];
                    int InternalVar_3 = InternalField_437.InternalField_432[InternalVar_2.InternalProperty_196].InternalField_427;
                    InternalField_437.InternalField_433[InternalVar_3] = null;
                }
            }

            public void InternalMethod_685(InternalType_141 InternalParameter_549)
            {
                if (!NovaApplication.IsEditor)
                {
                    return;
                }

                if (InternalParameter_549.InternalProperty_203 || !InternalParameter_549.InternalProperty_196.InternalProperty_194)
                {
                    return;
                }

                int InternalVar_1 = InternalField_437.InternalField_432[InternalParameter_549.InternalProperty_196].InternalField_427;

                Transform InternalVar_2 = InternalParameter_549.InternalProperty_204 ? InternalParameter_549.InternalProperty_202 : null;
                Transform InternalVar_3 = InternalField_437.InternalField_433[InternalVar_1];

                if (InternalVar_3 == InternalVar_2)
                {
                    return;
                }

                bool InternalVar_4 = InternalVar_3 != null;

                InternalField_437.InternalField_433[InternalVar_1] = InternalVar_2;

                if (InternalVar_4)
                {
                    InternalField_436.Add(InternalParameter_549.InternalProperty_195);
                }
                else
                {
                    InternalField_436.Remove(InternalParameter_549.InternalProperty_195);
                }
            }

            public void InternalMethod_1962(InternalType_141 InternalParameter_1318)
            {
                if (!NovaApplication.IsEditor)
                {
                    return;
                }

                Transform InternalVar_1 = InternalParameter_1318.InternalProperty_202;

                if (InternalVar_1 != null)
                {
                    InternalField_2246.Add(InternalVar_1.GetInstanceID());
                }

                InternalMethod_685(InternalParameter_1318);
            }

            public void InternalMethod_1961(InternalType_131 InternalParameter_1301, Transform InternalParameter_1295)
            {
                if (!NovaApplication.IsEditor)
                {
                    return;
                }

                if (InternalParameter_1295 != null)
                {
                    InternalField_2246.Remove(InternalParameter_1295.GetInstanceID());
                }

                InternalField_436.Remove(InternalParameter_1301);
            }

            public bool InternalMethod_1960(Transform InternalParameter_1294)
            {
                if (!NovaApplication.IsEditor)
                {
                    return false;
                }

                if (InternalParameter_1294 == null)
                {
                    return false;
                }

                return InternalField_2246.Contains(InternalParameter_1294.GetInstanceID());
            }

            public void InternalMethod_687(InternalType_143<T12, T13> InternalParameter_551)
            {
                if (!NovaApplication.IsEditor)
                {
                    return;
                }

                InternalField_437 = InternalParameter_551;
                InternalField_436 = new InternalType_153<InternalType_131>();
                InternalField_2246 = new HashSet<int>();
            }

            public void InternalMethod_688()
            {
                if (!NovaApplication.IsEditor)
                {
                    return;
                }

                InternalField_436.Clear();
                InternalField_2246.Clear();
            }
        }
    }
}
