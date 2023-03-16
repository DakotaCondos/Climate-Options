using Nova.InternalNamespace_0.InternalNamespace_2;
using System.Collections.Generic;

namespace Nova.InternalNamespace_0
{
    internal class InternalType_61 : InternalType_136<InternalType_61>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal List<InternalType_130> InternalField_203 = new List<InternalType_130>()
        {
            new InternalNamespace_9.InternalType_253(),
            new InternalNamespace_12.InternalType_457(),
            new InternalNamespace_10.InternalType_274(),
        };

        protected override void InternalMethod_657()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_203.Count; ++InternalVar_1)
            {
                InternalField_203[InternalVar_1].Dispose();
            }
        }

        protected override void InternalMethod_656()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_203.Count; ++InternalVar_1)
            {
                InternalField_203[InternalVar_1].InternalMethod_702();
            }
        }
    }
}

