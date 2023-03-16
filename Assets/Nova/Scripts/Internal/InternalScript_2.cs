using Nova.InternalNamespace_0.InternalNamespace_4;
using System;


namespace Nova.InternalNamespace_0.InternalNamespace_1
{
    internal readonly struct InternalType_125 : IEquatable<InternalType_125>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_125 InternalField_403 = default;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly InternalType_152<InternalType_125> InternalField_404;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool InternalField_405;

        public static implicit operator InternalType_152<InternalType_125>(InternalType_125 InternalParameter_489)
        {
            return InternalParameter_489.InternalField_404;
        }

        public static explicit operator InternalType_125(InternalType_152<InternalType_125> InternalParameter_490)
        {
            return InternalMethod_599(InternalParameter_490);
        }

        private InternalType_125(InternalType_152<InternalType_125> InternalParameter_491, bool InternalParameter_492)
        {
            InternalField_404 = InternalParameter_491;
            InternalField_405 = InternalParameter_492;
        }

        public static InternalType_125 InternalMethod_599(InternalType_152<InternalType_125> InternalParameter_493)
        {
            return new InternalType_125(InternalParameter_493, InternalParameter_492: false);
        }

        public static InternalType_125 InternalMethod_600(InternalType_152<InternalType_125> InternalParameter_494)
        {
            return new InternalType_125(InternalParameter_494, InternalParameter_492: true);
        }

        public static InternalType_125 InternalMethod_601()
        {
            return new InternalType_125(InternalType_152<InternalType_125>.InternalMethod_716(), InternalParameter_492: false);
        }

        public static InternalType_125 InternalMethod_602()
        {
            return new InternalType_125(InternalType_152<InternalType_125>.InternalMethod_716(), InternalParameter_492: true);
        }

        public bool Equals(InternalType_125 other)
        {
            return InternalField_404.Equals(other.InternalField_404);
        }

        public override int GetHashCode()
        {
            int InternalVar_1 = 13;
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_404.GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_405.GetHashCode();
            return InternalVar_1;
        }
    }
}