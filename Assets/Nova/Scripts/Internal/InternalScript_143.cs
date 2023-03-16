using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_11.InternalNamespace_15
{
    
    internal class InternalType_514
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static readonly InternalType_507 InternalField_2316 = InternalType_507.InternalMethod_996(InternalParameter_2276: 0.5f, InternalParameter_2275: 100.0f, InternalParameter_2274: 1.1f);
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private static readonly InternalType_509 InternalField_2315 = InternalType_509.InternalField_2305;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_508 InternalField_2314 = new InternalType_508();

        
        double InternalMethod_2013(double InternalParameter_2324) => 0.52f * math.pow(1 - InternalParameter_2324, 2);


        
        public double InternalMethod_2012(InternalType_513 InternalParameter_2323, double InternalParameter_2322)
        {
            if (InternalParameter_2322 == 0 || !InternalParameter_2323.InternalProperty_428)
            {
                return InternalParameter_2322;
            }

            InternalParameter_2323.InternalMethod_2004(InternalParameter_2322, out double InternalVar_1, out bool InternalVar_2);

            double InternalVar_3 = InternalVar_2
                ? InternalMethod_2013((InternalVar_1 - math.abs(InternalParameter_2322)) / InternalParameter_2323.InternalField_2311)
                : InternalMethod_2013(InternalVar_1 / InternalParameter_2323.InternalField_2311);
            double InternalVar_4 = math.sign(InternalParameter_2322);

            return InternalVar_4 * InternalMethod_2011(InternalVar_1, math.abs(InternalParameter_2322), InternalVar_3);
        }

        static double InternalMethod_2011(double InternalParameter_2321, double InternalParameter_2320, double InternalParameter_2319)
        {
            double InternalVar_1 = 0.0f;

            if (InternalParameter_2321 > 0)
            {
                double InternalVar_2 = InternalParameter_2321 / InternalParameter_2319;

                if (InternalParameter_2320 < InternalVar_2)
                {
                    return InternalParameter_2320 * InternalParameter_2319;
                }

                InternalVar_1 = InternalParameter_2321;
                InternalParameter_2320 -= InternalVar_2;
            }

            return InternalVar_1 + InternalParameter_2320;
        }

        
        public InternalType_512 InternalMethod_1822(InternalType_513 InternalParameter_449, double InternalParameter_448, double InternalParameter_447)
        {
            if (math.abs(InternalParameter_448) >= InternalField_2315.InternalField_2302 || InternalParameter_449.InternalProperty_428)
            {
                InternalField_2314.InternalMethod_1748(
                  InternalParameter_446: InternalField_2316,
                  InternalParameter_445: InternalParameter_449.InternalField_2313,
                  InternalParameter_444: InternalParameter_449.InternalField_2312,
                  InternalParameter_443: InternalParameter_448,
                  InternalParameter_442: InternalField_2315,
                  InternalParameter_447
                );

                return InternalField_2314;
            }

            return null;
        }

        

        
        public double InternalMethod_2008(double InternalParameter_2313)
        {
            return math.sign(InternalParameter_2313) * math.min(0.000816f * math.pow(math.abs(InternalParameter_2313), 1.967f), 40000.0f);
        }


        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        double InternalProperty_429 => 3.5f;
    }
}
