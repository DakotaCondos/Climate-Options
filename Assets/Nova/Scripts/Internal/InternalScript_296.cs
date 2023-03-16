using Nova.InternalNamespace_0.InternalNamespace_5;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_11.InternalNamespace_15
{
    internal interface InternalType_506
    {
        InternalType_513 InternalMethod_965();
    }

    internal class InternalType_505
    {
        #region 
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        private const float InternalField_2292 = 0.2f;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private const float InternalField_2291 = 0.5f;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private const float InternalField_2290 = 0.05f;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private const float InternalField_2289 = 24.0f;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private const double InternalField_2288 = 0.9;
        #endregion

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_506 InternalField_2287;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_514 InternalField_2286 = new InternalType_514();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_513 InternalField_2285;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_512 InternalField_2284;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_2283;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float InternalField_2282;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float InternalField_2281;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_2280 = false;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float InternalField_2279 = 0;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float InternalField_2278;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double InternalField_2277;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_2276 = false;

        private double InternalMethod_964(float InternalParameter_2273) => InternalField_2284 == null ? 0 : InternalField_2286.InternalMethod_2008(InternalField_2284.InternalMethod_2001(InternalParameter_2273));

        private void InternalMethod_963()
        {
            InternalField_2285 = InternalField_2287.InternalMethod_965();
        }

        private bool InternalMethod_962(float InternalParameter_2272) => InternalField_2284 == null ? false : !InternalField_2284.InternalMethod_2003(InternalParameter_2272);

        public float InternalMethod_961(float InternalParameter_2271)
        {
            float InternalVar_1 = InternalParameter_2271 - InternalField_2281;

            if (!InternalMethod_962(InternalVar_1))
            {
                return 0;
            }

            return (float)-InternalField_2284.InternalMethod_2001(InternalVar_1);
        }


        
        public float InternalMethod_960(float InternalParameter_2270)
        {
            if (InternalField_2284 == null)
            {
                return (float)InternalField_2285.InternalField_2312;
            }

            float InternalVar_1 = InternalParameter_2270 - InternalField_2281;

            if (InternalField_2284.InternalMethod_2003(InternalVar_1))
            {
                InternalField_2284 = default;
                InternalMethod_963();
                return (float)InternalField_2285.InternalField_2312;
            }

            InternalType_513 InternalVar_2 = InternalField_2287.InternalMethod_965();

            if (math.any(math.isinf(InternalVar_2.InternalField_2313) != math.isinf(InternalField_2285.InternalField_2313)))
            {
                InternalMethod_1648((float)-InternalField_2284.InternalMethod_2001(InternalVar_1), InternalParameter_2270);

                InternalVar_1 = 0;
            }

            return InternalMethod_495(InternalField_2284.InternalMethod_2002(InternalVar_1));
        }

        public float InternalMethod_959(float InternalParameter_2269, float InternalParameter_2268)
        {
            InternalMethod_958(InternalParameter_2269, InternalParameter_2268);

            InternalParameter_2269 = InternalMethod_734(InternalParameter_2269, InternalParameter_2268);

            InternalField_2282 = InternalParameter_2268;

            InternalMethod_963();
            InternalField_2284 = null;

            return InternalMethod_495(InternalField_2285.InternalField_2312 - InternalField_2286.InternalMethod_2012(InternalField_2285, InternalParameter_2269));
        }

        
        private void InternalMethod_958(float InternalParameter_2209, float InternalParameter_1258)
        {
            if (InternalField_2283 && InternalParameter_2209 == 0f &&
                (InternalParameter_1258 == 0f || InternalParameter_1258 - InternalField_2282 > InternalField_2292))
            {
                InternalField_2283 = false;
            }
        }

        
        private float InternalMethod_734(float InternalParameter_1257, float InternalParameter_1256)
        {
            if (InternalParameter_1256 == 0)
            {
                return InternalParameter_1257;
            }

            if (InternalParameter_1257 == 0.0f)
            {
                if (InternalField_2280 && InternalParameter_1256 - InternalField_2282 > InternalField_2290)
                {
                    InternalField_2280 = false;
                    InternalField_2279 = 0.0f;
                }
                return 0.0f;
            }
            else
            {
                if (InternalField_2280)
                {
                    return InternalParameter_1257;
                }

                InternalField_2279 = InternalField_2279 + InternalParameter_1257;
                if (math.abs(InternalField_2279) > InternalField_2278)
                {
                    InternalField_2280 = true;
                    InternalField_2279 = 0;
                    if (InternalField_2278 == 0 || math.abs(InternalParameter_1257) > InternalField_2289)
                    {
                        return InternalParameter_1257;
                    }
                    else
                    {
                        return math.min(InternalField_2278 / 3.0f, math.abs(InternalParameter_1257)) * math.sign(InternalParameter_1257);
                    }
                }
                else
                {
                    return 0.0f;
                }
            }
        }

        public void InternalMethod_717(float InternalParameter_1104, float InternalParameter_1103)
        {
            InternalField_2280 = false;
            InternalField_2278 = InternalParameter_1103;
            InternalField_2277 = InternalMethod_964(InternalParameter_1104);
            InternalField_2283 = InternalField_2277 != 0;
            InternalField_2279 = 0;
        }

        public void InternalMethod_1648(float InternalParameter_440, float InternalParameter_439, double InternalParameter_438 = InternalType_508.InternalField_2235)
        {
            double InternalVar_1 = -InternalParameter_440;

            if (InternalField_2283)
            {
                bool InternalVar_2 = math.sign(InternalVar_1) == math.sign(InternalField_2277);
                bool InternalVar_3 = math.abs(InternalVar_1) > math.abs(InternalField_2277) * InternalField_2291;
                if (InternalVar_2 && InternalVar_3)
                {
                    InternalVar_1 += InternalField_2277!;
                }
            }

            InternalField_2281 = InternalParameter_439;
            InternalMethod_963();
            InternalField_2284 = InternalField_2286.InternalMethod_1822(InternalField_2285, InternalVar_1, InternalParameter_438);
        }

        public void InternalMethod_533(float InternalParameter_923)
        {
            InternalMethod_1648(0, InternalParameter_923);
        }

        public void InternalMethod_500()
        {
            InternalField_2280 = false;
            InternalField_2283 = default;
            InternalField_2282 = default;
            InternalField_2281 = default;
            InternalField_2284 = default;
            InternalField_2278 = default;
            InternalField_2277 = default;
            InternalField_2279 = default;
            InternalMethod_963();
        }

        private float InternalMethod_495(double InternalParameter_922)
        {
            if (InternalParameter_922 < InternalField_2285.InternalField_2312 && InternalField_2285.InternalField_2312 <= InternalField_2285.InternalField_2313.x) 
            {
                InternalParameter_922 = 2 * InternalParameter_922 - InternalField_2285.InternalField_2312;
            }
            if (InternalField_2285.InternalField_2313.y <= InternalField_2285.InternalField_2312 && InternalField_2285.InternalField_2312 < InternalParameter_922) 
            {
                InternalParameter_922 = 2 * InternalParameter_922 - InternalField_2285.InternalField_2312;
            }
            if (InternalParameter_922 < InternalField_2285.InternalField_2313.x && InternalField_2285.InternalField_2313.x < InternalField_2285.InternalField_2312) 
            {
                InternalParameter_922 = 2 * InternalParameter_922 - InternalField_2285.InternalField_2313.x;
            }
            if (InternalField_2285.InternalField_2312 < InternalField_2285.InternalField_2313.y && InternalField_2285.InternalField_2313.y < InternalParameter_922) 
            {
                InternalParameter_922 = 2 * InternalParameter_922 - InternalField_2285.InternalField_2313.y;
            }

            double InternalVar_1 = InternalField_2276 ? 0 : InternalField_2285.InternalField_2311 * InternalField_2288;
            InternalParameter_922 = InternalType_187.InternalMethod_885(InternalParameter_922, InternalField_2285.InternalField_2313.x - InternalVar_1, InternalField_2285.InternalField_2313.y + InternalVar_1);
            return (float)InternalParameter_922;
        }

        public InternalType_505(InternalType_506 InternalParameter_921)
        {
            this.InternalField_2287 = InternalParameter_921;
        }
    }
}
