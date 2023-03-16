using Nova.InternalNamespace_0.InternalNamespace_5;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_11.InternalNamespace_15
{

    
    internal class InternalType_508 : InternalType_512
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private const double InternalField_2301 = 5000.0f;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private double2 InternalField_2300; 

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                InternalType_507 InternalField_2299;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_510 InternalField_2298 = new InternalType_510();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_500 InternalField_2297 = new InternalType_500();
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private double InternalField_2296;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const double InternalField_2235 = 0.135;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const double InternalField_2234 = InternalField_2235 / 8;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly float InternalField_2233 = (float)math.log(InternalField_2234);

        
        public void InternalMethod_1748(InternalType_507 InternalParameter_446, double2 InternalParameter_445, double InternalParameter_444, double InternalParameter_443, InternalType_509 InternalParameter_442, double InternalParameter_441)
        {
            this.InternalField_2300 = InternalParameter_445;
            this.InternalField_2299 = InternalParameter_446;

            if (InternalParameter_444 < InternalParameter_445.x)
            {
                InternalMethod_1944(InternalParameter_444, InternalParameter_443);
                InternalField_2296 = double.NegativeInfinity;
            }
            else if (InternalParameter_444 > InternalParameter_445.y)
            {
                InternalMethod_1164(InternalParameter_444, InternalParameter_443);
                InternalField_2296 = double.NegativeInfinity;
            }
            else
            {
                InternalField_2298.InternalMethod_2000(InternalParameter_441, InternalParameter_444, InternalParameter_443, InternalParameter_442);

                double InternalVar_1 = InternalField_2298.InternalProperty_427;

                if (InternalParameter_443 > 0.0f && InternalVar_1 > InternalParameter_445.y)
                {
                    InternalField_2296 = InternalField_2298.InternalMethod_1996(InternalParameter_445.y);
                    InternalMethod_1164(InternalParameter_445.y,
                      math.min(InternalField_2298.InternalMethod_2001(InternalField_2296), InternalField_2301));
                }
                else if (InternalParameter_443 < 0.0f && InternalVar_1 < InternalParameter_445.x)
                {
                    InternalField_2296 = InternalField_2298.InternalMethod_1996(InternalParameter_445.x);
                    InternalMethod_1944(InternalParameter_445.x,
                      math.min(InternalField_2298.InternalMethod_2001(InternalField_2296), InternalField_2301));
                }
                else
                {
                    InternalField_2296 = double.PositiveInfinity;
                }
            }
        }

        private void InternalMethod_1944(double InternalParameter_2281, double InternalParameter_2280)
        {
            InternalField_2297.InternalMethod_232(InternalField_2299, InternalParameter_2281, InternalField_2300.x, InternalParameter_2280);
        }

        private void InternalMethod_1164(double InternalParameter_2279, double InternalParameter_2278)
        {
            InternalField_2297.InternalMethod_232(InternalField_2299, InternalParameter_2279, InternalField_2300.y, InternalParameter_2278);
        }

        
        InternalType_512 InternalMethod_1085(ref double InternalParameter_2277)
        {
            InternalType_512 InternalVar_1;

            if (InternalParameter_2277 > InternalField_2296)
            {
                if (math.isfinite(InternalField_2296))
                {
                    InternalParameter_2277 -= InternalField_2296;
                }
                InternalVar_1 = InternalField_2297;
            }
            else
            {
                InternalVar_1 = InternalField_2298;
            }

            return InternalVar_1;
        }

        public double InternalMethod_2002(double InternalParameter_2305) => InternalMethod_1085(ref InternalParameter_2305).InternalMethod_2002(InternalParameter_2305);

        public double InternalMethod_2001(double InternalParameter_2304) => InternalMethod_1085(ref InternalParameter_2304).InternalMethod_2001(InternalParameter_2304);

        public bool InternalMethod_2003(double InternalParameter_2306) => InternalMethod_1085(ref InternalParameter_2306).InternalMethod_2003(InternalParameter_2306);
    }
}
