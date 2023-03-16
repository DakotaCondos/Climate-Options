using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_11.InternalNamespace_15
{
    
    internal class InternalType_510 : InternalType_512
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_509 InternalField_2310;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double InternalField_2309;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double InternalField_2308;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double InternalField_2307;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double InternalField_2306;

        
        public void InternalMethod_2000(double InternalParameter_2303, double InternalParameter_2302, double InternalParameter_2301, InternalType_509 InternalParameter_2300)
        {
            this.InternalField_2309 = InternalParameter_2303;
            InternalField_2308 = math.log(InternalParameter_2303);
            this.InternalField_2307 = InternalParameter_2302;
            this.InternalField_2306 = InternalParameter_2301;
            this.InternalField_2310 = InternalParameter_2300;
        }


        
        public void InternalMethod_1999(double InternalParameter_2299, double InternalParameter_2298, double InternalParameter_2297, double InternalParameter_2296)
        {
            InternalMethod_2000(InternalMethod_1998(InternalParameter_2299, InternalParameter_2298, InternalParameter_2297, InternalParameter_2296),
                 InternalParameter_2299,
                 InternalParameter_2297,
                 InternalParameter_2300: new InternalType_509() { InternalField_2302 = math.abs(InternalParameter_2296) });
        }

        static double InternalMethod_1998(double InternalParameter_2295, double InternalParameter_2294, double InternalParameter_2293, double InternalParameter_2292)
        {
            double InternalVar_1 = math.pow(math.E, (InternalParameter_2293 - InternalParameter_2292) / (InternalParameter_2295 - InternalParameter_2294));

            return double.IsInfinity(InternalVar_1) ? 0 : InternalVar_1;
        }

        public double InternalMethod_2002(double InternalParameter_2305) => InternalField_2307 + InternalField_2306 * math.pow(InternalField_2309, InternalParameter_2305) / InternalField_2308 - InternalField_2306 / InternalField_2308;

        public double InternalMethod_2001(double InternalParameter_2304) => InternalField_2306 * math.pow(InternalField_2309, InternalParameter_2304);

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public double InternalProperty_427 => InternalField_2307 - InternalField_2306 / InternalField_2308;

        
        public double InternalMethod_1996(double InternalParameter_2291)
        {
            if (InternalParameter_2291 == InternalField_2307)
            {
                return 0.0f;
            }

            if (InternalField_2306 == 0.0f || (InternalField_2306 > 0 ? (InternalParameter_2291 < InternalField_2307 || InternalParameter_2291 > InternalProperty_427) : (InternalParameter_2291 > InternalField_2307 || InternalParameter_2291 < InternalProperty_427)))
            {
                return double.PositiveInfinity;
            }

            return (double) (math.log(InternalField_2308 * (InternalParameter_2291 - InternalField_2307) / InternalField_2306 + 1.0f) / InternalField_2308);
        }

        public bool InternalMethod_2003(double InternalParameter_2306)
        {
            double InternalVar_1 = math.abs(InternalMethod_2001(InternalParameter_2306));
            return InternalVar_1 < InternalField_2310.InternalField_2302;
        }
    }
}
