using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

namespace Nova
{
    namespace InternalNamespace_0.InternalNamespace_12
    {
        internal static class InternalType_448
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private const int InternalField_1796 = 0;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private const int InternalField_1797 = 1;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private const int InternalField_1798 = 1;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private const int InternalField_1799 = 2;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public const int InternalField_1800 = 6;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public const int InternalField_1801 = 3;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static InternalType_449 InternalMethod_1747(InternalType_133 InternalParameter_1988, ref NativeList<InternalType_53> InternalParameter_1989)
            {
                return new InternalType_449(InternalParameter_1988, ref InternalParameter_1989);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static InternalType_452 InternalMethod_1951(InternalType_133 InternalParameter_2190, ref NativeList<InternalType_53> InternalParameter_2089, ref NativeList<InternalType_53.InternalType_54> InternalParameter_2080)
            {
                return new InternalType_452(InternalParameter_2190, ref InternalParameter_2089, ref InternalParameter_2080);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static InternalType_449 InternalMethod_1749(InternalType_133 InternalParameter_1992, ref NativeList<InternalType_53> InternalParameter_1993, ref NativeList<InternalType_53.InternalType_55> InternalParameter_1994)
            {
                InternalType_449 InternalVar_1 = new InternalType_449(InternalParameter_1992, ref InternalParameter_1993);
                InternalVar_1.InternalMethod_1805(InternalParameter_1994);

                return InternalVar_1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe InternalType_449 InternalMethod_1750(InternalType_133 InternalParameter_1995, InternalType_53* InternalParameter_1996)
            {
                return new InternalType_449(InternalParameter_1995, InternalParameter_1996);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static InternalType_453 InternalMethod_1751(InternalType_133 InternalParameter_1997, ref NativeList<InternalType_53.InternalType_55> InternalParameter_1998)
            {
                return new InternalType_453(InternalParameter_1997, ref InternalParameter_1998);
            }

            public unsafe struct InternalType_452
            {
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private int InternalField_1828;

                [NoAlias]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_53* InternalField_1829;
                [NoAlias]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_53.InternalType_54* InternalField_265;

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53 InternalProperty_385
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return UnsafeUtility.AsRef<InternalType_53>(InternalProperty_391);

                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53.InternalType_54 InternalProperty_760
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return UnsafeUtility.AsRef<InternalType_53.InternalType_54>(InternalProperty_245);

                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53 InternalProperty_386
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {

                        return UnsafeUtility.AsRef<InternalType_53>(InternalProperty_392);

                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56 InternalProperty_387
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {

                        return UnsafeUtility.AsRef<InternalType_56>(InternalProperty_393);

                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56 InternalProperty_388
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return UnsafeUtility.AsRef<InternalType_56>(InternalProperty_394);
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private int InternalProperty_389
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1828 * InternalField_1800;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private int InternalProperty_390
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1828 * InternalField_1801;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_53* InternalProperty_391
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1829 + InternalProperty_389 + InternalField_1796;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_53.InternalType_54* InternalProperty_245
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_265 + InternalProperty_389 + InternalField_1796;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_53* InternalProperty_392
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1829 + InternalProperty_389 + InternalField_1797;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_56* InternalProperty_393
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => ((InternalType_56*)InternalField_1829) + InternalProperty_390 + InternalField_1798;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_56* InternalProperty_394
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => ((InternalType_56*)InternalField_1829) + InternalProperty_390 + InternalField_1799;
                }

                public InternalType_452(InternalType_133 InternalParameter_2079, ref NativeList<InternalType_53> InternalParameter_2078, ref NativeList<InternalType_53.InternalType_54> InternalParameter_2033)
                {
                    InternalField_1828 = InternalParameter_2079;
                    InternalField_1829 = (InternalType_53*)InternalParameter_2078.GetUnsafeReadOnlyPtr();
                    InternalField_265 = (InternalType_53.InternalType_54*)InternalParameter_2033.GetUnsafeReadOnlyPtr();
                }
            }

            internal unsafe struct InternalType_449
            {
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private int InternalField_1802;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_133 InternalProperty_353
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1802;
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set => InternalField_1802 = value;
                }

                [NoAlias]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_53* InternalField_1803;
                [NoAlias]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_53.InternalType_54* InternalField_1804;
                [NoAlias]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_53.InternalType_55* InternalField_1805;
                [NoAlias]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_99* InternalField_1806;
                [NoAlias]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_98* InternalField_1807;
                [NoAlias]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private float3* InternalField_1808;
                [NoAlias]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private bool* InternalField_1809;
                [NoAlias]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private float3* InternalField_1810;

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_99 InternalProperty_354
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => ref UnsafeUtility.AsRef<InternalType_99>(InternalField_1806 + InternalProperty_353);
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref float3 InternalProperty_355
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => ref UnsafeUtility.AsRef<float3>(InternalField_1808 + InternalProperty_353);
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref bool InternalProperty_356
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => ref UnsafeUtility.AsRef<bool>(InternalField_1809 + InternalProperty_353);
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_98 InternalProperty_357
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => ref UnsafeUtility.AsRef<InternalType_98>(InternalField_1807 + InternalProperty_353);
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private int InternalProperty_358
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1802 * InternalField_1800;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private int InternalProperty_359
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1802 * InternalField_1801;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_53 InternalProperty_360
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_53>(InternalProperty_368);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_53 InternalProperty_361
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_53>(InternalProperty_369);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_56 InternalProperty_362
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_56>(InternalProperty_370);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_56 InternalProperty_363
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_56>(InternalProperty_371);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_53.InternalType_54 InternalProperty_364
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_53.InternalType_54>(InternalProperty_372);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_53.InternalType_54 InternalProperty_365
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_53.InternalType_54>(InternalProperty_373);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private ref InternalType_56.InternalType_57 InternalProperty_366
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_56.InternalType_57>(InternalProperty_374);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_56.InternalType_57 InternalProperty_367
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_56.InternalType_57>(InternalProperty_375);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private unsafe InternalType_53* InternalProperty_368
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1803 + InternalProperty_358 + InternalField_1796;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private unsafe InternalType_53* InternalProperty_369
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1803 + InternalProperty_358 + InternalField_1797;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private unsafe InternalType_56* InternalProperty_370
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => ((InternalType_56*)InternalField_1803) + InternalProperty_359 + InternalField_1798;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private unsafe InternalType_56* InternalProperty_371
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => ((InternalType_56*)InternalField_1803) + InternalProperty_359 + InternalField_1799;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private unsafe InternalType_53.InternalType_54* InternalProperty_372
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1804 + InternalProperty_358 + InternalField_1796;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private unsafe InternalType_53.InternalType_54* InternalProperty_373
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1804 + InternalProperty_358 + InternalField_1797;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private unsafe InternalType_56.InternalType_57* InternalProperty_374
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => ((InternalType_56.InternalType_57*)InternalField_1804) + InternalProperty_359 + InternalField_1798;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private unsafe InternalType_56.InternalType_57* InternalProperty_375
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => ((InternalType_56.InternalType_57*)InternalField_1804) + InternalProperty_359 + InternalField_1799;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_53.InternalType_55 InternalProperty_376
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_53.InternalType_55>(InternalField_1805 + InternalProperty_358 + InternalField_1796);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_53.InternalType_55 InternalProperty_377
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_53.InternalType_55>(InternalField_1805 + InternalProperty_358 + InternalField_1797);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_56.InternalType_58 InternalProperty_378
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_56.InternalType_58>(((InternalType_56.InternalType_58*)InternalField_1805) + InternalProperty_359 + InternalField_1798);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref InternalType_56.InternalType_58 InternalProperty_379
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return ref UnsafeUtility.AsRef<InternalType_56.InternalType_58>(((InternalType_56.InternalType_58*)InternalField_1805) + InternalProperty_359 + InternalField_1799);
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public bool3 InternalProperty_380
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return InternalProperty_360.InternalProperty_118 | InternalField_1806[InternalProperty_353].InternalProperty_179;
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public bool3 InternalProperty_381
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return InternalProperty_360.InternalProperty_118 | InternalProperty_361.InternalProperty_118 | InternalProperty_362.InternalProperty_126 | InternalProperty_363.InternalProperty_126 | InternalField_1806[InternalProperty_353].InternalProperty_179;
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public float3 InternalProperty_382
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return InternalProperty_376.InternalProperty_124 - InternalProperty_378.InternalProperty_137;
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public ref float3 InternalProperty_383
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref UnsafeUtility.AsRef<float3>(InternalField_1810 + InternalProperty_353);
                    }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public float3 InternalMethod_1784(ref NativeList<quaternion> InternalParameter_1999, ref NativeList<bool> InternalParameter_2000)
                {
                    if (!InternalParameter_2000[InternalProperty_353])
                    {
                        return InternalProperty_376.InternalProperty_124;
                    }

                    return InternalType_182.InternalMethod_859(InternalProperty_376.InternalProperty_124, InternalParameter_1999[InternalProperty_353]);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1785(float3 InternalParameter_2001)
                {
                    ref InternalType_53 InternalVar_1 = ref InternalProperty_360;

                    InternalProperty_377 = InternalType_53.InternalMethod_389(InternalProperty_361, InternalProperty_365, InternalParameter_2001);

                    InternalProperty_379 = InternalType_56.InternalMethod_410(InternalProperty_363, InternalProperty_367, InternalParameter_2001);

                    InternalMethod_1789(ref InternalVar_1, InternalParameter_2001);

                    InternalProperty_376 = InternalType_53.InternalMethod_389(InternalVar_1, InternalProperty_364, InternalParameter_2001);

                    InternalProperty_378 = InternalType_56.InternalMethod_410(InternalProperty_362, InternalProperty_366, InternalProperty_376.InternalProperty_124);

                    InternalProperty_383 = InternalParameter_2001;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1786()
                {
                    InternalProperty_378 = InternalType_56.InternalMethod_410(InternalProperty_362, InternalProperty_366, InternalProperty_376.InternalProperty_124);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1787(float3 InternalParameter_2002)
                {
                    InternalProperty_377 = InternalType_53.InternalMethod_389(InternalProperty_361, InternalProperty_365, InternalParameter_2002);
                    InternalProperty_383 = InternalParameter_2002;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1788(float3 InternalParameter_2003, bool3 InternalParameter_1766)
                {
                    InternalMethod_1789(ref InternalProperty_360, InternalParameter_2003);
                    InternalType_53.InternalType_55 InternalVar_1 = InternalProperty_376;
                    InternalType_53.InternalType_55 InternalVar_2 = InternalType_53.InternalMethod_389(InternalProperty_360, InternalProperty_364, InternalParameter_2003);

                    InternalProperty_376 = new InternalType_53.InternalType_55()
                    {
                        InternalField_177 = InternalParameter_1766.x ? InternalVar_2.InternalField_177 : InternalVar_1.InternalField_177,
                        InternalField_178 = InternalParameter_1766.y ? InternalVar_2.InternalField_178 : InternalVar_1.InternalField_178,
                        InternalField_179 = InternalParameter_1766.z ? InternalVar_2.InternalField_179 : InternalVar_1.InternalField_179,
                    };

                    InternalProperty_383 = InternalParameter_2003;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                private void InternalMethod_1789(ref InternalType_53 InternalParameter_2004, float3 InternalParameter_2005)
                {
                    ref InternalType_99 InternalVar_1 = ref InternalProperty_354;
                    ref InternalType_98 InternalVar_2 = ref InternalProperty_357;

                    if (!math.any(InternalVar_1.InternalProperty_179))
                    {
                        InternalMethod_1790(ref InternalParameter_2004, ref InternalVar_2, ref InternalVar_1, InternalParameter_2005);
                    }
                    else
                    {

                        InternalParameter_2004.InternalProperty_118 = InternalParameter_2004.InternalProperty_118 | InternalVar_1.InternalProperty_178;
                        InternalParameter_2004.InternalProperty_115 = math.select(InternalParameter_2004.InternalProperty_115, InternalType_187.InternalField_531 - InternalProperty_379.InternalProperty_138, InternalVar_1.InternalProperty_178);

                        InternalMethod_1790(ref InternalParameter_2004, ref InternalVar_2, ref InternalVar_1, InternalParameter_2005);

                    }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                private void InternalMethod_1790(ref InternalType_53 InternalParameter_2006, ref InternalType_98 InternalParameter_2007, ref InternalType_99 InternalParameter_2008, float3 InternalParameter_2009)
                {
                    if (!InternalParameter_2007.InternalProperty_173)
                    {
                        return;
                    }

                    int InternalVar_1 = InternalParameter_2007.InternalField_309.InternalMethod_508();
                    int2 InternalVar_2 = InternalParameter_2007.InternalProperty_174;

                    InternalType_45.InternalType_47 InternalVar_3 = new InternalType_45.InternalType_47(InternalParameter_2006[InternalVar_1], InternalProperty_364[InternalVar_1], InternalParameter_2009[InternalVar_1]);

                    for (int InternalVar_4 = 0; InternalVar_4 < 2; ++InternalVar_4)
                    {
                        int InternalVar_5 = InternalVar_2[InternalVar_4];
                        InternalType_45 InternalVar_6 = InternalParameter_2006[InternalVar_5];

                        InternalVar_6.InternalField_146 = InternalType_59.InternalField_201;

                        InternalVar_6.InternalField_145 = InternalVar_3.InternalField_153 * InternalParameter_2007.InternalField_308[InternalVar_5];
                        InternalVar_6.InternalField_145 = InternalType_187.InternalMethod_932(InternalVar_6.InternalField_145) ? InternalVar_6.InternalField_145 : 0;

                        InternalParameter_2006[InternalVar_5] = InternalVar_6;

                        InternalParameter_2008[InternalVar_5] = InternalNamespace_0.InternalType_83.InternalField_280;
                    }
                }


                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public InternalType_220 InternalMethod_1791(ref InternalType_450 InternalParameter_2010)
                {
                    if (!InternalProperty_376.InternalProperty_124.Equals(InternalParameter_2010.InternalField_1811.InternalProperty_124) ||
                        !InternalProperty_378.InternalProperty_133.Equals(InternalParameter_2010.InternalField_1813.InternalProperty_133))
                    {
                        return InternalType_220.InternalField_580;
                    }

                    if (!InternalProperty_377.InternalProperty_124.Equals(InternalParameter_2010.InternalField_1812.InternalProperty_124) ||
                        !InternalProperty_379.InternalProperty_133.Equals(InternalParameter_2010.InternalField_1814.InternalProperty_133))
                    {
                        return InternalType_220.InternalField_579;
                    }

                    return InternalType_220.InternalField_3625;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public InternalType_220 InternalMethod_1792(ref InternalType_451 InternalParameter_2011, bool InternalParameter_2012 = false)
                {
                    InternalType_220 InternalVar_1 = InternalType_220.InternalField_3625;

                    if (!InternalProperty_361.InternalMethod_377(ref InternalParameter_2011.InternalField_1817) ||
                        !InternalProperty_365.InternalMethod_377(ref InternalParameter_2011.InternalField_1821) ||
                        !InternalProperty_363.InternalMethod_377(ref InternalParameter_2011.InternalField_1819) ||
                        !InternalProperty_367.InternalMethod_377(ref InternalParameter_2011.InternalField_1823) ||
                        math.any(InternalProperty_355 != InternalParameter_2011.InternalField_1824))
                    {
                        if (!InternalParameter_2012)
                        {
                            InternalProperty_361 = InternalParameter_2011.InternalField_1817;
                        }

                        InternalProperty_365 = InternalParameter_2011.InternalField_1821;
                        InternalProperty_363 = InternalParameter_2011.InternalField_1819;
                        InternalProperty_367 = InternalParameter_2011.InternalField_1823;
                        InternalProperty_355 = InternalParameter_2011.InternalField_1824;
                        InternalVar_1 = InternalType_220.InternalField_579;
                    }

                    if (!InternalProperty_360.InternalMethod_377(ref InternalParameter_2011.InternalField_1816) ||
                        !InternalProperty_364.InternalMethod_377(ref InternalParameter_2011.InternalField_1820) ||
                        !InternalProperty_362.InternalMethod_377(ref InternalParameter_2011.InternalField_1818) ||
                        !InternalProperty_366.InternalMethod_377(ref InternalParameter_2011.InternalField_1822) ||
                        InternalProperty_354 != InternalParameter_2011.InternalField_1825 ||
                        InternalProperty_357 != InternalParameter_2011.InternalField_1827 ||
                        InternalProperty_356 != InternalParameter_2011.InternalField_1826)
                    {
                        InternalProperty_360 = InternalParameter_2011.InternalField_1816;
                        InternalProperty_364 = InternalParameter_2011.InternalField_1820;
                        InternalProperty_362 = InternalParameter_2011.InternalField_1818;
                        InternalProperty_366 = InternalParameter_2011.InternalField_1822;
                        InternalProperty_354 = InternalParameter_2011.InternalField_1825;
                        InternalProperty_356 = InternalParameter_2011.InternalField_1826;
                        InternalProperty_357 = InternalParameter_2011.InternalField_1827;

                        InternalVar_1 = InternalType_220.InternalField_580;
                    }

                    return InternalVar_1;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public InternalType_450 InternalMethod_1793()
                {
                    return new InternalType_450()
                    {
                        InternalField_1811 = InternalProperty_376,
                        InternalField_1812 = InternalProperty_377,
                        InternalField_1813 = InternalProperty_378,
                        InternalField_1814 = InternalProperty_379,
                        InternalField_1815 = InternalProperty_354,
                    };
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1794(ref InternalType_69 InternalParameter_2013)
                {
                    InternalType_69* InternalVar_1 = (InternalType_69*)UnsafeUtility.AddressOf(ref InternalParameter_2013);
                    UnsafeUtility.MemCpy(&InternalVar_1->InternalField_213, InternalField_1803 + (InternalField_1800 * InternalProperty_353), InternalField_1800 * InternalType_53.InternalField_166);
                    UnsafeUtility.MemCpy(&InternalVar_1->InternalField_217, InternalField_1804 + (InternalField_1800 * InternalProperty_353), InternalField_1800 * InternalType_53.InternalType_54.InternalField_171);

                    InternalParameter_2013.InternalField_222 = *(InternalField_1806 + InternalProperty_353);
                    InternalParameter_2013.InternalField_221 = (int3)(*(InternalField_1808 + InternalProperty_353));
                    InternalParameter_2013.InternalField_224 = *(InternalField_1807 + InternalProperty_353);
                    InternalParameter_2013.InternalField_223 = *(InternalField_1809 + InternalProperty_353);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public static ref InternalType_451 InternalMethod_1795(ref InternalType_69 InternalParameter_2014)
                {
                    return ref UnsafeUtility.As<InternalType_69, InternalType_451>(ref InternalParameter_2014);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1796(ref NativeList<InternalType_99> InternalParameter_2015)
                {
                    InternalField_1806 = (InternalType_99*)InternalParameter_2015.GetUnsafePtr();
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1797(InternalType_99* InternalParameter_2016)
                {
                    InternalField_1806 = InternalParameter_2016;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1798(ref NativeList<InternalType_98> InternalParameter_2017)
                {
                    InternalField_1807 = (InternalType_98*)InternalParameter_2017.GetUnsafePtr();
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1799(InternalType_98* InternalParameter_2018)
                {
                    InternalField_1807 = InternalParameter_2018;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1800(ref NativeList<float3> InternalParameter_2019)
                {
                    InternalField_1808 = (float3*)InternalParameter_2019.GetUnsafePtr();
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1801(float3* InternalParameter_2020)
                {
                    InternalField_1808 = InternalParameter_2020;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1802(ref NativeList<float3> InternalParameter_2021)
                {
                    InternalField_1810 = (float3*)InternalParameter_2021.GetUnsafePtr();
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1803(ref NativeList<bool> InternalParameter_2022)
                {
                    InternalField_1809 = (bool*)InternalParameter_2022.GetUnsafePtr();
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1804(bool* InternalParameter_2023)
                {
                    InternalField_1809 = InternalParameter_2023;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1805(NativeList<InternalType_53.InternalType_55> InternalParameter_2024)
                {
                    InternalField_1805 = (InternalType_53.InternalType_55*)InternalParameter_2024.GetUnsafePtr();
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1806(InternalType_53.InternalType_55* InternalParameter_2025)
                {
                    InternalField_1805 = InternalParameter_2025;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1807(ref NativeList<InternalType_53.InternalType_54> InternalParameter_2026)
                {
                    InternalField_1804 = (InternalType_53.InternalType_54*)InternalParameter_2026.GetUnsafePtr();
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public void InternalMethod_1808(InternalType_53.InternalType_54* InternalParameter_2027)
                {
                    InternalField_1804 = InternalParameter_2027;
                }

                public InternalType_449(InternalType_133 InternalParameter_2028, ref NativeList<InternalType_53> InternalParameter_2029)
                {
                    InternalField_1802 = InternalParameter_2028;
                    InternalField_1803 = (InternalType_53*)InternalParameter_2029.GetUnsafePtr();
                    InternalField_1804 = null;
                    InternalField_1805 = null;
                    InternalField_1808 = null;
                    InternalField_1806 = null;
                    InternalField_1807 = null;
                    InternalField_1809 = null;
                    InternalField_1810 = null;
                }

                public InternalType_449(InternalType_133 InternalParameter_2030, InternalType_53* InternalParameter_2031)
                {
                    InternalField_1802 = InternalParameter_2030;
                    InternalField_1803 = InternalParameter_2031;
                    InternalField_1804 = null;
                    InternalField_1805 = null;
                    InternalField_1808 = null;
                    InternalField_1806 = null;
                    InternalField_1807 = null;
                    InternalField_1809 = null;
                    InternalField_1810 = null;
                }
            }

            [StructLayoutAttribute(LayoutKind.Sequential)]
            public struct InternalType_451
            {
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53 InternalField_1816;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53 InternalField_1817;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56 InternalField_1818;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56 InternalField_1819;

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53.InternalType_54 InternalField_1820;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53.InternalType_54 InternalField_1821;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56.InternalType_57 InternalField_1822;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56.InternalType_57 InternalField_1823;

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public int3 InternalField_1824;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_99 InternalField_1825;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public bool InternalField_1826;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_98 InternalField_1827;

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public bool3 InternalProperty_384
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return InternalField_1816.InternalProperty_118 | InternalField_1817.InternalProperty_118 | InternalField_1818.InternalProperty_126 | InternalField_1819.InternalProperty_126 | !InternalField_1825.InternalProperty_176;
                    }
                }
            }

            [StructLayoutAttribute(LayoutKind.Sequential)]
            public struct InternalType_450
            {
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53.InternalType_55 InternalField_1811;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_53.InternalType_55 InternalField_1812;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56.InternalType_58 InternalField_1813;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_56.InternalType_58 InternalField_1814;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_99 InternalField_1815;
            }

            
            internal unsafe ref struct InternalType_453
            {
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_133 InternalField_1830;

                [NoAlias]
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private readonly InternalType_53.InternalType_55* InternalField_1831;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private readonly InternalType_56.InternalType_58* InternalProperty_395 => (InternalType_56.InternalType_58*)InternalField_1831;

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private readonly int InternalProperty_396
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1830 * InternalField_1800;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private readonly int InternalProperty_397
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1830 * InternalField_1801;
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public readonly InternalType_53.InternalType_55 InternalProperty_398
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1831[InternalProperty_396 + InternalField_1796];
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public readonly InternalType_53.InternalType_55 InternalProperty_399
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get => InternalField_1831[InternalProperty_396 + InternalField_1797];
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public readonly InternalType_56.InternalType_58 InternalProperty_400
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return InternalProperty_395[InternalProperty_397 + InternalField_1798];
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public readonly InternalType_56.InternalType_58 InternalProperty_401
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        unsafe
                        {
                            return InternalProperty_395[InternalProperty_397 + InternalField_1799];
                        }
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public readonly float3 InternalProperty_402
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return InternalProperty_398.InternalProperty_124 - InternalProperty_400.InternalProperty_137;
                    }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public readonly float3 InternalMethod_1831(ref NativeList<quaternion> InternalParameter_2034, ref NativeList<bool> InternalParameter_2035)
                {
                    if (!InternalParameter_2035[InternalField_1830])
                    {
                        return InternalProperty_398.InternalProperty_124;
                    }

                    return InternalType_182.InternalMethod_859(InternalProperty_398.InternalProperty_124, InternalParameter_2034[InternalField_1830]);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public readonly float3 InternalMethod_1832(ref NativeList<quaternion> InternalParameter_2036, ref NativeList<bool> InternalParameter_2037)
                {
                    return InternalMethod_1831(ref InternalParameter_2036, ref InternalParameter_2037) + InternalProperty_401.InternalProperty_137;
                }

                public InternalType_453(InternalType_133 InternalParameter_2038, ref NativeList<InternalType_53.InternalType_55> InternalParameter_2039)
                {
                    InternalField_1830 = InternalParameter_2038;
                    InternalField_1831 = (InternalType_53.InternalType_55*)InternalParameter_2039.GetUnsafeReadOnlyPtr();
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        internal struct InternalType_454
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_53.InternalType_55 InternalField_1832;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_53.InternalType_55 InternalField_1833;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_56.InternalType_58 InternalField_1834;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_56.InternalType_58 InternalField_1835;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public Vector3 InternalProperty_403 => InternalField_1832.InternalProperty_124 - InternalField_1834.InternalProperty_137;
        }

        internal unsafe struct InternalType_18
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_1838;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public ulong InternalField_1837;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_69* InternalField_1836;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_70* InternalField_1227;
        }
    }
}