using Unity.Jobs;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    internal static class InternalType_205
    {
        public static void InternalMethod_993(this ref JobHandle InternalParameter_966, JobHandle InternalParameter_967)
        {
            InternalParameter_966 = JobHandle.CombineDependencies(InternalParameter_966, InternalParameter_967);
        }

        public static void InternalMethod_994(this ref JobHandle InternalParameter_968, JobHandle InternalParameter_969, JobHandle InternalParameter_970)
        {
            InternalParameter_968 = JobHandle.CombineDependencies(InternalParameter_968, InternalParameter_969, InternalParameter_970);
        }
    }
}

