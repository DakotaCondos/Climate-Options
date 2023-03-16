using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Unity.Collections;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    
    internal struct InternalType_336
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1160;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_373>> InternalField_1161;

        public bool InternalMethod_1495(int InternalParameter_1599, out InternalType_131 InternalParameter_1600, out InternalType_288 InternalParameter_1601)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1160.Length; ++InternalVar_1)
            {
                InternalParameter_1600 = InternalField_1160[InternalVar_1];
                InternalType_162<InternalType_288, InternalType_373> InternalVar_2 = InternalField_1161[InternalParameter_1600];
                if (InternalParameter_1599 >= InternalVar_2.InternalProperty_216)
                {
                    InternalParameter_1599 -= InternalVar_2.InternalProperty_216;
                    continue;
                }

                InternalParameter_1601 = InternalParameter_1599;
                return true;
            }

            Debug.LogError($"Failed to get VisualIndex for ${InternalParameter_1599}");
            InternalParameter_1601 = InternalType_288.InternalField_937;
            InternalParameter_1600 = InternalType_131.InternalField_415;
            return false;
        }
    }
}

