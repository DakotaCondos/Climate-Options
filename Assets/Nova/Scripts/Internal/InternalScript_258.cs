using Nova.InternalNamespace_0.InternalNamespace_4;
using Unity.Collections;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_5
{
    internal static class InternalType_177
    {
        
        public unsafe static bool InternalMethod_844<T>(ref ComputeBuffer InternalParameter_691, int InternalParameter_692) where T : unmanaged
        {
            if (InternalParameter_692 == 0 || (InternalParameter_691 != null && InternalParameter_691.count >= InternalParameter_692))
            {
                return false;
            }

            bool InternalVar_1 = false;
            if (InternalParameter_691 != null)
            {
                InternalVar_1 = true;
                InternalParameter_691.Dispose();
            }

            InternalParameter_691 = new ComputeBuffer(InternalParameter_692, sizeof(T));
            return InternalVar_1;
        }

        public static bool InternalMethod_845<T>(ref ComputeBuffer InternalParameter_693, ref InternalType_164<T> InternalParameter_694) where T : unmanaged
        {
            bool InternalVar_1 = InternalMethod_844<T>(ref InternalParameter_693, InternalParameter_694.InternalProperty_216);
            if (InternalParameter_694.InternalProperty_216 == 0 || InternalParameter_693 == null)
            {
                return InternalVar_1;
            }

            using (var dataAsArray = InternalParameter_694.InternalMethod_804())
            {
                InternalParameter_693.SetData(dataAsArray.Array, 0, 0, InternalParameter_694.InternalProperty_216);
            }
            return InternalVar_1;
        }

        public static void InternalMethod_846(this ComputeBuffer InternalParameter_695)
        {
            if (InternalParameter_695 != null)
            {
                InternalParameter_695.Dispose();
            }
        }
    }
}

