using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_70 : InternalType_219<InternalType_70>, InternalType_52
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_96 InternalField_225;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_226;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45.InternalType_46 InternalField_227;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_228;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_229;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_230;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_231;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool InternalProperty_155
        {
            get
            {
                return InternalField_225.InternalMethod_508() != -1;
            }
        }

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool InternalProperty_156
        {
            get
            {
                return (InternalField_225 == InternalType_96.InternalField_306) ^ (InternalField_230 == 1) ^ InternalField_229;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal readonly int InternalProperty_1147 => InternalField_225 == InternalType_96.InternalField_306 ? -1 : 1;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal readonly int InternalProperty_1148
        {
            get
            {
                int InternalVar_1 = InternalField_229 ? -1 : 1;
                return InternalProperty_1147 * InternalVar_1;
            }
        }

        public readonly bool3 InternalMethod_449() => InternalProperty_155 ? InternalField_225.InternalMethod_508() == InternalType_187.InternalField_498 : false;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool InternalProperty_157 => InternalProperty_155 && InternalField_230 == 0;

        public InternalType_45.InternalType_47 InternalMethod_451(float InternalParameter_317)
        {
            return new InternalType_45.InternalType_47(InternalField_226, InternalField_227, InternalParameter_317);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_220 InternalMethod_1046(ref InternalType_70 InternalParameter_1061)
        {
            InternalType_220 InternalVar_1 = InternalMethod_1047(ref InternalParameter_1061);

            if (!InternalVar_1.InternalProperty_250)
            {
                return InternalVar_1;
            }

            InternalField_225 = InternalParameter_1061.InternalField_225;
            InternalField_230 = InternalParameter_1061.InternalField_230;
            InternalField_226 = InternalParameter_1061.InternalField_226;
            InternalField_227 = InternalParameter_1061.InternalField_227;
            InternalField_228 = InternalParameter_1061.InternalField_228;
            InternalField_229 = InternalParameter_1061.InternalField_229;
            InternalField_231 = InternalParameter_1061.InternalField_231;

            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_220 InternalMethod_1047(ref InternalType_70 valueToDiff)
        {
            return this.InternalMethod_422(ref valueToDiff) ? InternalType_220.InternalField_580 : InternalType_220.InternalField_3625;
        }
    }
}