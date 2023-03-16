using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_5
{
    internal struct InternalType_190
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double InternalField_552;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly double InternalField_553;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalProperty_242
        {
            get
            {
                return (float)InternalField_552;
            }
            set
            {
                InternalField_552 = value;
            }
        }

        public InternalType_190(double InternalParameter_914 = 0, float InternalParameter_915 = 0.5f)
        {
            InternalField_552 = InternalParameter_914;
            InternalField_553 = Mathf.Clamp(InternalParameter_915, 0, 1);

        }

        public void InternalMethod_957(double InternalParameter_916)
        {
            InternalField_552 = (InternalField_552 * (1 - InternalField_553)) + (InternalField_553 * InternalParameter_916);
        }
    }
}
