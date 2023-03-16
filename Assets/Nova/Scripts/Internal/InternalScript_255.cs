using Nova.Compat;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_5
{
    internal static class InternalType_179
    {
        
        public static void InternalMethod_847(Object InternalParameter_696)
        {
            if (NovaApplication.IsEditor)
            {
                if (Application.isPlaying)
                {
                    Object.Destroy(InternalParameter_696);
                }
                else
                {
                    Object.DestroyImmediate(InternalParameter_696);
                }
            }
            else
            {
                Object.Destroy(InternalParameter_696);
            }
        }

        public static void InternalMethod_848(Object InternalParameter_697)
        {
            if (InternalParameter_697 != null)
            {
                InternalMethod_847(InternalParameter_697);
            }
        }
    }
}

