using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_11.InternalNamespace_15
{
    internal class InternalType_504 : InternalType_503
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double InternalField_2275, InternalField_2274, InternalField_2273;

        public override void InternalMethod_316(InternalType_507 InternalParameter_920, double InternalParameter_919, double InternalParameter_918)
        {
            InternalField_2275 = -InternalParameter_920.InternalField_2293 / (2.0f * InternalParameter_920.InternalField_2295);
            InternalField_2274 = InternalParameter_919;
            InternalField_2273 = InternalParameter_918 / (InternalField_2275 * InternalParameter_919);
        }

        public override double InternalMethod_2002(double InternalParameter_2305)
        {
            return (InternalField_2274 + InternalField_2273 * InternalParameter_2305) * math.pow(math.E, InternalField_2275 * InternalParameter_2305);
        }

        public override double InternalMethod_2001(double InternalParameter_2304)
        {
            double InternalVar_1 = math.pow(math.E, InternalField_2275 * InternalParameter_2304);
            return InternalField_2275 * (InternalField_2274 + InternalField_2273 * InternalParameter_2304) * InternalVar_1 + InternalField_2273 * InternalVar_1;
        }
    }

    internal class InternalType_502 : InternalType_503
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double InternalField_2272, InternalField_2271, InternalField_2270, InternalField_2269;

        public override void InternalMethod_316(InternalType_507 description, double InternalParameter_919, double InternalParameter_918)
        {
            double InternalVar_1 = 4.0f * description.InternalField_2295 * description.InternalField_2294;
            double InternalVar_2 = description.InternalField_2293 * description.InternalField_2293;

            InternalField_2272 = math.sqrt(math.max(InternalVar_1 - InternalVar_2, 1)) / (2.0f * description.InternalField_2295);
            InternalField_2271 = -(description.InternalField_2293 / 2.0f * description.InternalField_2295);
            InternalField_2270 = InternalParameter_919;
            InternalField_2269 = (InternalParameter_918 - InternalField_2271 * InternalParameter_919) / InternalField_2272;
        }

        public override double InternalMethod_2002(double InternalParameter_2305)
        {
            return math.pow(math.E, InternalField_2271 * InternalParameter_2305) * (InternalField_2270 * math.cos(InternalField_2272 * InternalParameter_2305) + InternalField_2269 * math.sin(InternalField_2272 * InternalParameter_2305));
        }

        public override double InternalMethod_2001(double InternalParameter_2304)
        {
            double InternalVar_1 = math.pow(math.E, InternalField_2271 * InternalParameter_2304);
            double InternalVar_2 = math.cos(InternalField_2272 * InternalParameter_2304);
            double InternalVar_3 = math.sin(InternalField_2272 * InternalParameter_2304);
            return InternalVar_1 * (InternalField_2269 * InternalField_2272 * InternalVar_2 - InternalField_2270 * InternalField_2272 * InternalVar_3) + InternalField_2271 * InternalVar_1 * (InternalField_2269 * InternalVar_3 + InternalField_2270 * InternalVar_2);
        }
    }

    internal class InternalType_501 : InternalType_503
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double InternalField_2268, InternalField_2267, InternalField_2266, InternalField_2265;

        public override void InternalMethod_316(InternalType_507 InternalParameter_920, double InternalParameter_919, double InternalParameter_918)
        {
            double InternalVar_1 = InternalParameter_920.InternalField_2293 * InternalParameter_920.InternalField_2293 - 4.0f * InternalParameter_920.InternalField_2295 * InternalParameter_920.InternalField_2294;

            InternalField_2268 = (-InternalParameter_920.InternalField_2293 - math.sqrt(InternalVar_1)) / (2.0f * InternalParameter_920.InternalField_2295);
            InternalField_2267 = (-InternalParameter_920.InternalField_2293 + math.sqrt(InternalVar_1)) / (2.0f * InternalParameter_920.InternalField_2295);
            InternalField_2265 = (InternalParameter_918 - InternalField_2268 * InternalParameter_919) / (InternalField_2267 - InternalField_2268);
            InternalField_2266 = InternalParameter_919 - InternalField_2265;
        }

        public override double InternalMethod_2002(double InternalParameter_2305)
        {
            return InternalField_2266 * math.pow(math.E, InternalField_2268 * InternalParameter_2305) +
                   InternalField_2265 * math.pow(math.E, InternalField_2267 * InternalParameter_2305);
        }

        public override double InternalMethod_2001(double InternalParameter_2304)
        {
            return InternalField_2266 * InternalField_2268 * math.pow(math.E, InternalField_2268 * InternalParameter_2304) +
                   InternalField_2265 * InternalField_2267 * math.pow(math.E, InternalField_2267 * InternalParameter_2304);
        }
    }

    internal abstract class InternalType_503 : InternalType_511
    {
        public abstract double InternalMethod_2002(double InternalParameter_2305);
        public abstract double InternalMethod_2001(double InternalParameter_2304);

        public abstract void InternalMethod_316(InternalType_507 InternalParameter_920, double InternalParameter_919, double InternalParameter_918);
    }
}
