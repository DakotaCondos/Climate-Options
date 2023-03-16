using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_377 : InternalType_147
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_164<InternalType_19>> InternalField_1305;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_1306;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_19, int> InternalField_1307;

        public InternalType_164<InternalType_19> this[InternalType_19 InternalParameter_1716] => InternalField_1305[InternalField_1307[InternalParameter_1716]];

        public NativeArray<InternalType_19> InternalMethod_1589(Allocator InternalParameter_1717)
        {
            return InternalField_1307.GetKeyArray(InternalParameter_1717);
        }

        public bool InternalMethod_3325(InternalType_19 InternalParameter_1365, out InternalType_164<InternalType_19> InternalParameter_1364)
        {
            if (!InternalField_1307.TryGetValue(InternalParameter_1365, out int InternalVar_1))
            {
                InternalParameter_1364 = default;
                return false;
            }

            InternalParameter_1364 = InternalField_1305[InternalVar_1];
            return true;
        }

        public void InternalMethod_3326(InternalType_19 InternalParameter_1363, InternalType_19 InternalParameter_1362)
        {
            if (InternalField_1307.TryGetValue(InternalParameter_1363, out int InternalVar_1))
            {
                InternalField_1305.ElementAt(InternalVar_1).InternalMethod_785(InternalParameter_1362);
            }
            else
            {
                InternalField_1307.Add(InternalParameter_1363, InternalField_1306);
                if (InternalField_1306 >= InternalField_1305.Length)
                {
                    InternalType_164<InternalType_19> InternalVar_2 = new InternalType_164<InternalType_19>(0, Allocator.Persistent);
                    InternalVar_2.InternalMethod_785(InternalParameter_1362);
                    InternalField_1305.Add(InternalVar_2);
                }
                else
                {
                    InternalField_1305.ElementAt(InternalField_1306).InternalMethod_785(InternalParameter_1362);
                }
                InternalField_1306 += 1;
            }
        }

        public void InternalMethod_1592()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1305.Length; ++InternalVar_1)
            {
                InternalField_1305.ElementAt(InternalVar_1).InternalMethod_705();
            }
            InternalField_1306 = 0;
            InternalField_1307.Clear();
        }

        public void InternalMethod_702()
        {
            InternalField_1305.InternalMethod_1020();
            InternalField_1306 = 0;
            InternalField_1307.Init();
        }

        public void Dispose()
        {
            InternalField_1305.InternalMethod_1022();
            InternalField_1307.Dispose();
        }
    }
}