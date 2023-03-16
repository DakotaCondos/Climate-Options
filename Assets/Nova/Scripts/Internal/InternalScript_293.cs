using Nova.InternalNamespace_0.InternalNamespace_5;

namespace Nova.InternalNamespace_0.InternalNamespace_11.InternalNamespace_15
{
    internal class InternalType_500 : InternalType_512
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_501 InternalField_2264 = new InternalType_501();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_502 InternalField_554 = new InternalType_502();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_504 InternalField_104 = new InternalType_504();

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                protected InternalType_509 InternalField_87 = InternalType_509.InternalField_2305;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        protected double InternalField_86;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        protected InternalType_503 InternalField_85;

        public void InternalMethod_232(InternalType_507 InternalParameter_917, double InternalParameter_570, double InternalParameter_371, double InternalParameter_370)
        {
            InternalField_86 = InternalParameter_371;
            InternalField_85 = InternalMethod_226(InternalParameter_917, InternalParameter_570 - InternalParameter_371, InternalParameter_370);
        }

        public virtual double InternalMethod_2001(double InternalParameter_2304) => InternalField_85.InternalMethod_2001(InternalParameter_2304);

        public virtual double InternalMethod_2002(double InternalParameter_2305) => InternalMethod_2003(InternalParameter_2305) ? InternalField_86 : InternalField_86 + InternalField_85.InternalMethod_2002(InternalParameter_2305);

        public bool InternalMethod_2003(double InternalParameter_2306)
        {
            double InternalVar_1 = InternalField_85.InternalMethod_2002(InternalParameter_2306);
            double InternalVar_2 = InternalField_85.InternalMethod_2001(InternalParameter_2306);

            return InternalType_187.InternalMethod_915(InternalVar_1, InternalField_87.InternalField_2304) && InternalType_187.InternalMethod_915(InternalVar_2, InternalField_87.InternalField_2302);
        }

        private InternalType_503 InternalMethod_226(InternalType_507 InternalParameter_369, double InternalParameter_368, double InternalParameter_367)
        {
            double InternalVar_1 = InternalParameter_369.InternalField_2293 * InternalParameter_369.InternalField_2293 - 4 * InternalParameter_369.InternalField_2295 * InternalParameter_369.InternalField_2294;

            if (InternalVar_1 == 0.0f)
            {
                InternalField_104.InternalMethod_316(InternalParameter_369, InternalParameter_368, InternalParameter_367);
                return InternalField_104;
            }

            if (InternalVar_1 > 0.0f)
            {
                InternalField_2264.InternalMethod_316(InternalParameter_369, InternalParameter_368, InternalParameter_367);
                return InternalField_2264;
            }

            InternalField_554.InternalMethod_316(InternalParameter_369, InternalParameter_368, InternalParameter_367);
            return InternalField_554;
        }
    }
}
