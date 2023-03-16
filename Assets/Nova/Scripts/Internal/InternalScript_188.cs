using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    
    internal struct InternalType_276 : IEquatable<InternalType_276>, IEquatable<InternalType_282>, IEquatable<InternalType_257>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_643 InternalField_900;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_901;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_266 InternalField_902;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_322 InternalField_903;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_278 InternalField_904;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_279 InternalField_905;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_280 InternalField_906;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_277 InternalField_907;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_276 InternalField_908 = new InternalType_276()
        {
            InternalField_900 = InternalType_643.InternalField_1148,
            InternalField_901 = 0,
            InternalField_902 = InternalType_266.InternalField_785,
            InternalField_903 = InternalType_322.InternalField_1082,
            InternalField_904 = InternalType_278.InternalField_915,
            InternalField_905 = InternalType_279.InternalField_917,
            InternalField_906 = InternalType_280.InternalField_919,
            InternalField_907 = InternalType_277.InternalField_912,
        };

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_281 InternalProperty_293
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_902 == InternalType_266.InternalField_787 ? InternalField_905.InternalField_916 : InternalType_281.InternalField_921;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_294
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_900.InternalProperty_761;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_295
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_907.InternalField_909 != InternalType_104.InternalField_323;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool Equals(InternalType_276 other)
        {
            if (InternalField_900 != other.InternalField_900 ||
                InternalField_901 != other.InternalField_901 ||
                InternalField_902 != other.InternalField_902 ||
                InternalField_903 != other.InternalField_903)
            {
                return false;
            }

            if (!InternalField_907.Equals(other.InternalField_907))
            {
                return false;
            }

            switch (InternalField_902)
            {
                case InternalType_266.InternalField_786:
                    return InternalField_904.Equals(other.InternalField_904);
                case InternalType_266.InternalField_787:
                    return InternalField_905.Equals(other.InternalField_905);
                case InternalType_266.InternalField_788:
                case InternalType_266.InternalField_790:
                    return InternalField_906.Equals(other.InternalField_906);
                case InternalType_266.InternalField_789:
                    return true;
                default:
                    return false;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_282 other)
        {
            if (InternalField_902 != InternalType_266.InternalField_786 || (InternalField_903 & InternalType_322.InternalField_1087) == 0)
            {
                return false;
            }
            return InternalField_904.InternalField_913 == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_257 other)
        {
            if ((InternalField_902 & InternalType_266.InternalField_791) == 0)
            {
                return false;
            }

            return InternalField_906.Equals(other);
        }

        public struct InternalType_277 : IEquatable<InternalType_277>
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_104 InternalField_909;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public ShadowCastingMode InternalField_910;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_911;

            public bool Equals(InternalType_277 other)
            {
                return InternalField_909 == other.InternalField_909 &&
                    InternalField_910 == other.InternalField_910 &&
                    InternalField_911 == other.InternalField_911;
            }

            public static implicit operator InternalType_277(InternalType_73 InternalParameter_1335)
            {
                if (InternalParameter_1335.InternalProperty_1032 == InternalType_104.InternalField_323)
                {
                    return new InternalType_277()
                    {
                        InternalField_909 = InternalType_104.InternalField_323,
                        InternalField_911 = false,
                        InternalField_910 = ShadowCastingMode.Off,
                    };
                }
                else
                {
                    return new InternalType_277()
                    {
                        InternalField_909 = InternalParameter_1335.InternalProperty_1032,
                        InternalField_911 = InternalParameter_1335.InternalField_245,
                        InternalField_910 = InternalParameter_1335.InternalField_244,
                    };
                }
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly InternalType_277 InternalField_912 = new InternalType_277()
            {
                InternalField_909 = InternalType_104.InternalField_323,
                InternalField_911 = false,
                InternalField_910 = ShadowCastingMode.Off,
            };
        }

        public struct InternalType_278 : IEquatable<InternalType_278>
        {
            
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        public InternalType_282 InternalField_913;
            
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        public InternalType_310 InternalField_914;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(InternalType_278 other)
            {
                return InternalField_913 == other.InternalField_913 && InternalField_914 == other.InternalField_914;
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly InternalType_278 InternalField_915 = new InternalType_278()
            {
                InternalField_913 = InternalType_282.InternalField_923,
                InternalField_914 = InternalType_310.InternalField_1023,
            };
        }

        public struct InternalType_279 : IEquatable<InternalType_279>
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_281 InternalField_916;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(InternalType_279 other) => InternalField_916 == other.InternalField_916;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly InternalType_279 InternalField_917 = new InternalType_279()
            {
                InternalField_916 = InternalType_281.InternalField_920,
            };
        }

        public struct InternalType_280 : IEquatable<InternalType_280>, IEquatable<InternalType_257>
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_257 InternalField_918;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(InternalType_280 other)
            {
                return InternalField_918 == other.InternalField_918;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(InternalType_257 other)
            {
                return InternalField_918 == other;
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly InternalType_280 InternalField_919 = new InternalType_280()
            {
                InternalField_918 = InternalType_257.InternalField_748,
            };
        }
    }
}