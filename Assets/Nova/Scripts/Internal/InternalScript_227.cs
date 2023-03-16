using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal partial struct InternalType_410 : InternalType_193
    {
        private interface InternalType_412
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            float InternalProperty_339 { get; }
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            float InternalProperty_340 { get; }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            InternalType_366 InternalProperty_341 { get; }
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            ref InternalType_366 InternalProperty_342 { get; }

            
            InternalType_366 InternalMethod_1666(int InternalParameter_1846);


            
            InternalType_366 InternalMethod_1667(int InternalParameter_1847);
        }

        private struct InternalType_413 : InternalType_412
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_364 InternalField_1580;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_413(ref InternalType_364 InternalParameter_1848)
            {

                InternalField_1580 = InternalParameter_1848;
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalProperty_339
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => InternalField_1580.InternalField_1265;
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalProperty_340
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => InternalType_187.InternalField_497 * InternalField_1580.InternalField_1265;
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_366 InternalProperty_341
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    float InternalVar_1 = InternalProperty_340;
                    return new InternalType_366()
                    {
                        InternalField_1274 = InternalField_1580.InternalField_1264.InternalField_1274 + InternalVar_1,
                        InternalField_1275 = InternalField_1580.InternalField_1264.InternalField_1275 - InternalVar_1
                    };
                }
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public unsafe ref InternalType_366 InternalProperty_342
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (InternalType_413* ptr = &this)
                    {
                        return ref ptr->InternalField_1580.InternalField_1264;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_366 InternalMethod_1667(int InternalParameter_1847)
            {
                return InternalType_410.InternalMethod_1650(InternalParameter_1847, ref InternalField_1580.InternalField_1264, InternalField_1580.InternalField_1265);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_366 InternalMethod_1666(int InternalParameter_1846)
            {
                return InternalType_410.InternalMethod_1649(InternalParameter_1846, ref InternalField_1580.InternalField_1264, InternalField_1580.InternalField_1265);
            }
        }

        private struct InternalType_414 : InternalType_412
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_364 InternalField_1581;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_414(ref InternalType_364 InternalParameter_1849)
            {
                InternalField_1581 = InternalParameter_1849;
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalProperty_339
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => InternalField_1581.InternalField_1268.InternalField_1272;
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalProperty_340
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => InternalType_187.InternalField_497 * InternalField_1581.InternalField_1268.InternalField_1272;
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_366 InternalProperty_341
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    float InternalVar_1 = InternalProperty_340;
                    return new InternalType_366()
                    {
                        InternalField_1274 = InternalField_1581.InternalField_1268.InternalField_1271.InternalField_1274 + InternalVar_1,
                        InternalField_1275 = InternalField_1581.InternalField_1268.InternalField_1271.InternalField_1275 - InternalVar_1
                    };
                }
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public unsafe ref InternalType_366 InternalProperty_342
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (InternalType_414* ptr = &this)
                    {
                        return ref ptr->InternalField_1581.InternalField_1268.InternalField_1271;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_366 InternalMethod_1667(int InternalParameter_1847)
            {
                return InternalType_410.InternalMethod_1650(InternalParameter_1847, ref InternalField_1581.InternalField_1268.InternalField_1271, InternalField_1581.InternalField_1268.InternalField_1272);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_366 InternalMethod_1666(int InternalParameter_1846)
            {
                return InternalType_410.InternalMethod_1649(InternalParameter_1846, ref InternalField_1581.InternalField_1268.InternalField_1271, InternalField_1581.InternalField_1268.InternalField_1272);
            }
        }

        private struct InternalType_415 : InternalType_412
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_364 InternalField_1582;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_415(ref InternalType_364 InternalParameter_1850)
            {
                InternalField_1582 = InternalParameter_1850;
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalProperty_339
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => InternalField_1582.InternalField_1268.InternalField_1272;
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalProperty_340
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => InternalType_187.InternalField_497 * InternalField_1582.InternalField_1268.InternalField_1272;
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_366 InternalProperty_341
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    float InternalVar_1 = InternalProperty_340;
                    return new InternalType_366()
                    {
                        InternalField_1274 = InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1274 + InternalVar_1,
                        InternalField_1275 = InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1275 - InternalVar_1
                    };
                }
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public unsafe ref InternalType_366 InternalProperty_342
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (InternalType_415* ptr = &this)
                    {
                        return ref ptr->InternalField_1582.InternalField_1268.InternalField_1271;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_366 InternalMethod_1667(int InternalParameter_1847)
            {
                return InternalType_410.InternalMethod_1650(InternalParameter_1847, ref InternalField_1582.InternalField_1268.InternalField_1271, InternalField_1582.InternalField_1268.InternalField_1272);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_366 InternalMethod_1666(int InternalParameter_1846)
            {
                InternalType_366 InternalVar_1 = new InternalType_366()
                {
                    InternalField_1274 = InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1274 + InternalField_1582.InternalField_1268.InternalField_1272,
                    InternalField_1275 = InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1275 - InternalField_1582.InternalField_1268.InternalField_1272
                };

                switch (InternalParameter_1846)
                {
                    case 0:
                        return new InternalType_366()
                        {
                            InternalField_1274 = new float2(InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1275.x - InternalField_1582.InternalField_1268.InternalField_1273, InternalVar_1.InternalField_1274.y),
                            InternalField_1275 = new float2(InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1275.x, InternalVar_1.InternalField_1275.y)
                        };
                    case 1:
                        return new InternalType_366()
                        {
                            InternalField_1274 = new float2(InternalVar_1.InternalField_1274.x, InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1275.y - InternalField_1582.InternalField_1268.InternalField_1273),
                            InternalField_1275 = new float2(InternalVar_1.InternalField_1275.x, InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1275.y)
                        };
                    case 2:
                        return new InternalType_366()
                        {
                            InternalField_1274 = new float2(InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1274.x, InternalVar_1.InternalField_1274.y),
                            InternalField_1275 = new float2(InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1274.x + InternalField_1582.InternalField_1268.InternalField_1273, InternalVar_1.InternalField_1275.y)
                        };
                    case 3:
                        return new InternalType_366()
                        {
                            InternalField_1274 = new float2(InternalVar_1.InternalField_1274.x, InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1274.y),
                            InternalField_1275 = new float2(InternalVar_1.InternalField_1275.x, InternalField_1582.InternalField_1268.InternalField_1271.InternalField_1274.y + InternalField_1582.InternalField_1268.InternalField_1273)
                        };
                    default:
                        Debug.LogError("Invalid edge index");
                        return default;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static InternalType_366 InternalMethod_1649(int InternalParameter_1823, ref InternalType_366 InternalParameter_1824, float InternalParameter_1825)
        {
            if (InternalType_187.InternalMethod_914(InternalParameter_1825))
            {
                return InternalParameter_1824;
            }

            switch (InternalParameter_1823)
            {
                case 0:
                    return new InternalType_366()
                    {
                        InternalField_1274 = new float2(InternalParameter_1824.InternalField_1275.x - InternalParameter_1825, InternalParameter_1824.InternalField_1274.y + InternalParameter_1825),
                        InternalField_1275 = new float2(InternalParameter_1824.InternalField_1275.x, InternalParameter_1824.InternalField_1275.y - InternalParameter_1825),
                    };
                case 1:
                    return new InternalType_366()
                    {
                        InternalField_1274 = new float2(InternalParameter_1824.InternalField_1274.x + InternalParameter_1825, InternalParameter_1824.InternalField_1275.y - InternalParameter_1825),
                        InternalField_1275 = new float2(InternalParameter_1824.InternalField_1275.x - InternalParameter_1825, InternalParameter_1824.InternalField_1275.y),
                    };
                case 2:
                    return new InternalType_366()
                    {
                        InternalField_1274 = new float2(InternalParameter_1824.InternalField_1274.x, InternalParameter_1824.InternalField_1274.y + InternalParameter_1825),
                        InternalField_1275 = new float2(InternalParameter_1824.InternalField_1274.x + InternalParameter_1825, InternalParameter_1824.InternalField_1275.y - InternalParameter_1825),
                    };
                case 3:
                    return new InternalType_366()
                    {
                        InternalField_1274 = new float2(InternalParameter_1824.InternalField_1274.x + InternalParameter_1825, InternalParameter_1824.InternalField_1274.y),
                        InternalField_1275 = new float2(InternalParameter_1824.InternalField_1275.x - InternalParameter_1825, InternalParameter_1824.InternalField_1274.y + InternalParameter_1825),
                    };
                default:
                    Debug.LogError("Invalid edge index");
                    return default;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static InternalType_366 InternalMethod_1650(int InternalParameter_1826, ref InternalType_366 InternalParameter_1827, float InternalParameter_1828)
        {
            switch (InternalParameter_1826)
            {
                case 0:
                    return new InternalType_366()
                    {
                        InternalField_1274 = InternalParameter_1827.InternalField_1274,
                        InternalField_1275 = InternalParameter_1827.InternalField_1274 + InternalParameter_1828
                    };
                case 1:
                    return new InternalType_366()
                    {
                        InternalField_1274 = new float2(InternalParameter_1827.InternalField_1274.x, InternalParameter_1827.InternalField_1275.y - InternalParameter_1828),
                        InternalField_1275 = new float2(InternalParameter_1827.InternalField_1274.x + InternalParameter_1828, InternalParameter_1827.InternalField_1275.y),
                    };
                case 2:
                    return new InternalType_366()
                    {
                        InternalField_1274 = InternalParameter_1827.InternalField_1275 - InternalParameter_1828,
                        InternalField_1275 = InternalParameter_1827.InternalField_1275
                    };
                case 3:
                    return new InternalType_366()
                    {
                        InternalField_1274 = new float2(InternalParameter_1827.InternalField_1275.x - InternalParameter_1828, InternalParameter_1827.InternalField_1274.y),
                        InternalField_1275 = new float2(InternalParameter_1827.InternalField_1275.x, InternalParameter_1827.InternalField_1274.y + InternalParameter_1828),
                    };
                default:
                    Debug.LogError("Invalid corner index");
                    return default;
            }
        }
    }
}
