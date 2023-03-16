using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_11.InternalNamespace_15
{
    internal struct InternalType_507
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public double InternalField_2295;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public double InternalField_2294;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public double InternalField_2293;

        public static InternalType_507 InternalMethod_996(double InternalParameter_2276, double InternalParameter_2275, double InternalParameter_2274 = 1)
        {
            return new InternalType_507()
            {
                InternalField_2295 = InternalParameter_2276,
                InternalField_2294 = InternalParameter_2275,
                InternalField_2293 = InternalParameter_2274 * 2.0f * math.sqrt(InternalParameter_2276 * InternalParameter_2275)
            };
        }
    }
}
