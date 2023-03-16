using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_11.InternalNamespace_15
{
    
    internal readonly struct InternalType_513
    {
        
        public InternalType_513(double2 InternalParameter_2312, double InternalParameter_2311, double InternalParameter_2310)
        {
            InternalField_2313 = InternalParameter_2312;
            InternalField_2312 = InternalParameter_2311;
            InternalField_2311 = InternalParameter_2310;
        }

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public readonly double2 InternalField_2313;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public readonly double InternalField_2312;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public readonly double InternalField_2311;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool InternalProperty_428 => InternalField_2312 < InternalField_2313.x || InternalField_2312 > InternalField_2313.y;

        public readonly void InternalMethod_2004(double InternalParameter_2309, out double InternalParameter_2308, out bool InternalParameter_2307)
        {
            double InternalVar_1 = math.max(InternalField_2313.x - InternalField_2312, 0.0f);
            double InternalVar_2 = math.max(InternalField_2312 - InternalField_2313.y, 0.0f);

            InternalParameter_2308 = math.max(InternalVar_1, InternalVar_2);
            InternalParameter_2307 = (InternalVar_1 > 0.0 && InternalParameter_2309 < 0.0) || (InternalVar_2 > 0.0 && InternalParameter_2309 > 0.0);
        }

        public override string ToString()
        {
            return InternalField_2312.ToString();
        }
    }
}
