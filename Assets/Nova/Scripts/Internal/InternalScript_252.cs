using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_418 : InternalType_147, InternalType_150
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<int> InternalField_1585;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<InternalType_383> InternalField_1586;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1587;

        public void InternalMethod_705()
        {
            InternalField_1585.InternalMethod_705();
            InternalField_1586.InternalMethod_705();
        }

        public void Dispose()
        {
            InternalField_1585.Dispose();
            InternalField_1586.Dispose();
        }

        public void InternalMethod_702()
        {
            InternalField_1585.InternalMethod_702();
            InternalField_1586.InternalMethod_702();
        }
    }

    internal struct InternalType_417
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_366 InternalField_1583;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_1584;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float2 InternalField_3434;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float2 InternalField_3435;
    }

    internal struct InternalType_419 : InternalType_147, InternalType_150
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<InternalType_417> InternalField_1588;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<float> InternalField_1589;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<float> InternalField_1590;

        public void InternalMethod_705()
        {
            InternalField_1588.InternalMethod_705();
            InternalField_1589.InternalMethod_705();
            InternalField_1590.InternalMethod_705();
        }

        public void Dispose()
        {
            InternalField_1588.Dispose();
            InternalField_1589.Dispose();
            InternalField_1590.Dispose();
        }

        public void InternalMethod_702()
        {
            InternalField_1588.InternalMethod_702();
            InternalField_1589.InternalMethod_702();
            InternalField_1590.InternalMethod_702();
        }
    }

    [BurstCompile]
    internal partial struct InternalType_410 : InternalType_193
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1561;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_373>> InternalField_1562;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_380> InternalField_1563;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_259> InternalField_1564;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1565;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_80> InternalField_2239;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_359 InternalField_3433;

        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_418> InternalField_1566;

        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_419> InternalField_1567;

        [NativeSetThreadIndex]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1568;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_379 InternalField_1569;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_419 InternalField_1570;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_259 InternalField_1571;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_418 InternalField_1572;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_133 InternalField_1573;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float4x4 InternalField_1574;

        public void Execute(int index)
        {
            if (!InternalField_1561.InternalMethod_1004(ref InternalField_1563, ref index, out InternalField_1569, out InternalType_131 InternalVar_1))
            {
                return;
            }

            InternalField_1570 = InternalField_1567.ElementAt(InternalField_1568);
            InternalField_1570.InternalMethod_705();

            InternalType_288 InternalVar_2 = InternalField_1569.InternalField_1314[index];
            ref InternalType_373 InternalVar_3 = ref InternalField_1562[InternalVar_1].InternalMethod_758(InternalVar_2);
            InternalField_1573 = InternalVar_3.InternalField_1294;

            ref float4x4 InternalVar_4 = ref InternalField_1565.ElementAt(InternalField_1573);
            InternalField_1574 = math.mul(InternalVar_4, InternalField_1569.InternalField_1311);

            InternalMethod_1651(ref InternalVar_3);

            InternalField_1567[InternalField_1568] = InternalField_1570;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1651(ref InternalType_373 InternalParameter_1829)
        {
            InternalField_1572 = InternalField_1566.InternalMethod_748(InternalParameter_1829.InternalField_1295);
            ref InternalType_364 InternalVar_1 = ref InternalField_1569.InternalField_1315.InternalField_1308.InternalMethod_800(InternalField_1572.InternalField_1587);

            InternalField_1571 = InternalField_1564[InternalVar_1.InternalField_1266];

            InternalType_80 InternalVar_2 = InternalField_2239[InternalParameter_1829.InternalField_1295];

            InternalType_417 InternalVar_3 = new InternalType_417()
            {
                InternalField_1583 = InternalVar_1.InternalProperty_322,
                InternalField_1584 = InternalVar_2.InternalField_272 ? false : true,
            };

            if (InternalField_3433.InternalMethod_1556(InternalVar_2.InternalField_271.InternalField_276, out InternalType_311 InternalVar_4, out InternalType_321 InternalVar_5))
            {
                if (InternalVar_2.InternalField_271.InternalField_274.InternalField_367 == InternalType_112.InternalField_3426 ||
                    InternalVar_2.InternalField_271.InternalField_274.InternalField_367 == InternalType_112.InternalField_3427)
                {
                    float2 InternalVar_6 = InternalType_187.InternalField_521 * InternalVar_1.InternalField_1264.InternalProperty_722;

                    InternalType_366 InternalVar_7 = InternalVar_1.InternalProperty_322;

                    InternalType_366 InternalVar_8 = new InternalType_366(
                        InternalVar_4.InternalField_1024.x, InternalVar_4.InternalField_1024.y,
                        InternalVar_4.InternalField_1024.xMax, InternalVar_4.InternalField_1024.yMax
                        );
                    float2 InternalVar_9 = InternalVar_5.InternalField_1077;
                    InternalVar_8.InternalField_1274 = InternalType_187.InternalField_523 * InternalVar_8.InternalField_1274 / InternalVar_9 - InternalType_187.InternalField_522;
                    InternalVar_8.InternalField_1275 = InternalType_187.InternalField_523 * InternalVar_8.InternalField_1275 / InternalVar_9 - InternalType_187.InternalField_522;

                    InternalType_737 InternalVar_10 = InternalType_187.InternalField_3436 * InternalVar_4.InternalField_3429.InternalField_3430 / InternalVar_9.xyxy;
                    InternalType_737 InternalVar_11 = InternalVar_4.InternalField_3429.InternalField_3430 / InternalVar_2.InternalField_271.InternalField_274.InternalField_3428;

                    bool2 InternalVar_12 = InternalVar_11.InternalProperty_1076 > InternalVar_1.InternalField_1264.InternalProperty_722;
                    float4 InternalVar_13 = InternalVar_11.InternalField_3430 / InternalVar_11.InternalProperty_1076.xyxy * InternalVar_1.InternalField_1264.InternalProperty_722.xyxy;
                    InternalVar_11.InternalField_3430 = math.select(InternalVar_11.InternalField_3430, InternalVar_13, InternalVar_12.xyxy);

                    InternalType_366 InternalVar_14 = new InternalType_366(
                        InternalVar_1.InternalField_1264.InternalField_1274 + InternalVar_11.InternalProperty_1073,
                         InternalVar_1.InternalField_1264.InternalField_1275 - InternalVar_11.InternalProperty_1075
                        );

                    InternalType_366 InternalVar_15 = new InternalType_366(
                        InternalType_187.InternalField_519 + InternalVar_11.InternalProperty_1073 / InternalVar_6,
                        InternalType_187.InternalField_522 - InternalVar_11.InternalProperty_1075 / InternalVar_6
                        );
                    InternalType_366 InternalVar_16 = new InternalType_366(
                        InternalVar_8.InternalField_1274 + InternalVar_10.InternalProperty_1073,
                        InternalVar_8.InternalField_1275 - InternalVar_10.InternalProperty_1075
                        );

                    InternalVar_3.InternalField_3435 = InternalMethod_3413(
                        new InternalType_366(InternalVar_8.InternalProperty_329, InternalVar_16.InternalProperty_1080, InternalVar_16.InternalProperty_329, InternalVar_8.InternalProperty_1080),
                        new InternalType_366(-1f, InternalVar_15.InternalProperty_1080, InternalVar_15.InternalProperty_329, 1f),
                        out InternalVar_3.InternalField_3434
                        );
                    InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_7.InternalProperty_329, InternalVar_14.InternalProperty_1080, InternalVar_14.InternalProperty_329, InternalVar_7.InternalProperty_1080);
                    InternalMethod_1882(InternalVar_3);

                    InternalVar_3.InternalField_3435 = InternalMethod_3413(
                        new InternalType_366(InternalVar_16.InternalProperty_330, InternalVar_16.InternalProperty_1080, InternalVar_8.InternalProperty_330, InternalVar_8.InternalProperty_1080),
                        new InternalType_366(InternalVar_15.InternalProperty_330, InternalVar_15.InternalProperty_1080, 1f, 1f),
                        out InternalVar_3.InternalField_3434
                        );
                    InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_14.InternalProperty_330, InternalVar_14.InternalProperty_1080, InternalVar_7.InternalProperty_330, InternalVar_7.InternalProperty_1080);
                    InternalMethod_1882(InternalVar_3);

                    InternalVar_3.InternalField_3435 = InternalMethod_3413(
                        new InternalType_366(InternalVar_16.InternalProperty_330, InternalVar_8.InternalProperty_1079, InternalVar_8.InternalProperty_330, InternalVar_16.InternalProperty_1079),
                        new InternalType_366(InternalVar_15.InternalProperty_330, -1f, 1f, InternalVar_15.InternalProperty_1079),
                        out InternalVar_3.InternalField_3434
                        );
                    InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_14.InternalProperty_330, InternalVar_7.InternalProperty_1079, InternalVar_7.InternalProperty_330, InternalVar_14.InternalProperty_1079);
                    InternalMethod_1882(InternalVar_3);

                    InternalVar_3.InternalField_3435 = InternalMethod_3413(
                        new InternalType_366(InternalVar_8.InternalProperty_329, InternalVar_8.InternalProperty_1079, InternalVar_16.InternalProperty_329, InternalVar_16.InternalProperty_1079),
                        new InternalType_366(-1f, -1f, InternalVar_15.InternalProperty_329, InternalVar_15.InternalProperty_1079),
                        out InternalVar_3.InternalField_3434
                        );
                    InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_7.InternalProperty_329, InternalVar_7.InternalProperty_1079, InternalVar_14.InternalProperty_329, InternalVar_14.InternalProperty_1079);
                    InternalMethod_1882(InternalVar_3);

                    if (InternalVar_2.InternalField_271.InternalField_274.InternalField_367 == InternalType_112.InternalField_3427)
                    {
                        float2 InternalVar_17 = (new float2(InternalVar_4.InternalField_1024.width, InternalVar_4.InternalField_1024.height) - new float2(InternalVar_4.InternalField_3429.InternalProperty_1078, InternalVar_4.InternalField_3429.InternalProperty_1077)) / InternalVar_2.InternalField_271.InternalField_274.InternalField_3428;
                        float2 InternalVar_18 = InternalVar_17 / InternalVar_6;

                        int2 InternalVar_19 = (int2)math.ceil(InternalVar_14.InternalProperty_722 / InternalVar_17);

                        InternalVar_19 = math.max(InternalVar_19, InternalType_187.InternalField_510);
                        for (int InternalVar_20 = 0; InternalVar_20 < InternalVar_19.x; ++InternalVar_20)
                        {
                            for (int InternalVar_21 = 0; InternalVar_21 < InternalVar_19.y; ++InternalVar_21)
                            {
                                float2 InternalVar_22 = new float2(InternalVar_20, InternalVar_21);

                                float2 InternalVar_23 = InternalVar_15.InternalField_1274 + InternalVar_22 * InternalVar_18;
                                InternalType_366 InternalVar_24 = new InternalType_366(InternalVar_23,
                                        math.min(InternalVar_23 + InternalVar_18, InternalVar_15.InternalField_1275));

                                float2 InternalVar_25 = InternalVar_24.InternalProperty_722 / InternalVar_18;
                                InternalType_366 InternalVar_26 = new InternalType_366(
                                    InternalVar_16.InternalField_1274,
                                    InternalVar_16.InternalField_1274 + InternalVar_25 * InternalVar_16.InternalProperty_722);
                                InternalVar_3.InternalField_3435 = InternalMethod_3413(InternalVar_26, InternalVar_24, out InternalVar_3.InternalField_3434);

                                float2 InternalVar_27 = InternalVar_14.InternalField_1274 + InternalVar_22 * InternalVar_17;
                                InternalType_366 InternalVar_28 = new InternalType_366(InternalVar_27, math.min(InternalVar_27 + InternalVar_17, InternalVar_14.InternalField_1275));
                                InternalVar_3.InternalField_1583 = InternalVar_28;
                                InternalMethod_1882(InternalVar_3);

                                if (InternalVar_20 == 0)
                                {
                                    InternalVar_3.InternalField_3435 = InternalMethod_3413(
                                        new InternalType_366(
                                            InternalVar_8.InternalProperty_329,
                                            InternalVar_16.InternalProperty_1079,
                                            InternalVar_16.InternalProperty_329,
                                            InternalVar_26.InternalProperty_1080),
                                        new InternalType_366(-1f, InternalVar_24.InternalProperty_1079, InternalVar_15.InternalProperty_329, InternalVar_24.InternalProperty_1080),
                                        out InternalVar_3.InternalField_3434
                                        );
                                    InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_7.InternalProperty_329, InternalVar_28.InternalProperty_1079, InternalVar_14.InternalProperty_329, InternalVar_28.InternalProperty_1080);
                                    InternalMethod_1882(InternalVar_3);

                                    InternalVar_3.InternalField_3435 = InternalMethod_3413(
                                        new InternalType_366(InternalVar_16.InternalProperty_330, InternalVar_16.InternalProperty_1079, InternalVar_8.InternalProperty_330, InternalVar_26.InternalProperty_1080),
                                        new InternalType_366(InternalVar_15.InternalProperty_330, InternalVar_24.InternalProperty_1079, 1f, InternalVar_24.InternalProperty_1080),
                                        out InternalVar_3.InternalField_3434
                                        );
                                    InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_14.InternalProperty_330, InternalVar_28.InternalProperty_1079, InternalVar_7.InternalProperty_330, InternalVar_28.InternalProperty_1080);
                                    InternalMethod_1882(InternalVar_3);
                                }

                                if (InternalVar_21 == 0)
                                {
                                    InternalVar_3.InternalField_3435 = InternalMethod_3413(
                                        new InternalType_366(InternalVar_16.InternalProperty_329, InternalVar_16.InternalProperty_1080, InternalVar_26.InternalProperty_330, InternalVar_8.InternalProperty_1080),
                                        new InternalType_366(InternalVar_24.InternalProperty_329, InternalVar_15.InternalProperty_1080, InternalVar_24.InternalProperty_330, 1f),
                                        out InternalVar_3.InternalField_3434
                                        );
                                    InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_28.InternalProperty_329, InternalVar_14.InternalProperty_1080, InternalVar_28.InternalProperty_330, InternalVar_7.InternalProperty_1080);
                                    InternalMethod_1882(InternalVar_3);

                                    InternalVar_3.InternalField_3435 = InternalMethod_3413(
                                        new InternalType_366(InternalVar_16.InternalProperty_329, InternalVar_8.InternalProperty_1079, InternalVar_26.InternalProperty_330, InternalVar_16.InternalProperty_1079),
                                        new InternalType_366(InternalVar_24.InternalProperty_329, -1f, InternalVar_24.InternalProperty_330, InternalVar_15.InternalProperty_1079),
                                        out InternalVar_3.InternalField_3434
                                        );
                                    InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_28.InternalProperty_329, InternalVar_7.InternalProperty_1079, InternalVar_28.InternalProperty_330, InternalVar_14.InternalProperty_1079);
                                    InternalMethod_1882(InternalVar_3);
                                }
                            }
                        }
                    }
                    else
                    {
                        InternalVar_3.InternalField_3435 = InternalMethod_3413(InternalVar_16, InternalVar_15, out InternalVar_3.InternalField_3434);
                        InternalVar_3.InternalField_1583 = InternalVar_14;
                        InternalMethod_1882(InternalVar_3);

                        InternalVar_3.InternalField_3435 = InternalMethod_3413(
                            new InternalType_366(InternalVar_8.InternalProperty_329, InternalVar_16.InternalProperty_1079, InternalVar_16.InternalProperty_329, InternalVar_16.InternalProperty_1080),
                            new InternalType_366(-1f, InternalVar_15.InternalProperty_1079, InternalVar_15.InternalProperty_329, InternalVar_15.InternalProperty_1080),
                            out InternalVar_3.InternalField_3434
                            );
                        InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_7.InternalProperty_329, InternalVar_14.InternalProperty_1079, InternalVar_14.InternalProperty_329, InternalVar_14.InternalProperty_1080);
                        InternalMethod_1882(InternalVar_3);

                        InternalVar_3.InternalField_3435 = InternalMethod_3413(
                            new InternalType_366(InternalVar_16.InternalProperty_329, InternalVar_16.InternalProperty_1080, InternalVar_16.InternalProperty_330, InternalVar_8.InternalProperty_1080),
                            new InternalType_366(InternalVar_15.InternalProperty_329, InternalVar_15.InternalProperty_1080, InternalVar_15.InternalProperty_330, 1f),
                            out InternalVar_3.InternalField_3434
                            );
                        InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_14.InternalProperty_329, InternalVar_14.InternalProperty_1080, InternalVar_14.InternalProperty_330, InternalVar_7.InternalProperty_1080);
                        InternalMethod_1882(InternalVar_3);

                        InternalVar_3.InternalField_3435 = InternalMethod_3413(
                            new InternalType_366(InternalVar_16.InternalProperty_330, InternalVar_16.InternalProperty_1079, InternalVar_8.InternalProperty_330, InternalVar_16.InternalProperty_1080),
                            new InternalType_366(InternalVar_15.InternalProperty_330, InternalVar_15.InternalProperty_1079, 1f, InternalVar_15.InternalProperty_1080),
                            out InternalVar_3.InternalField_3434
                            );
                        InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_14.InternalProperty_330, InternalVar_14.InternalProperty_1079, InternalVar_7.InternalProperty_330, InternalVar_14.InternalProperty_1080);
                        InternalMethod_1882(InternalVar_3);

                        InternalVar_3.InternalField_3435 = InternalMethod_3413(
                            new InternalType_366(InternalVar_16.InternalProperty_329, InternalVar_8.InternalProperty_1079, InternalVar_16.InternalProperty_330, InternalVar_16.InternalProperty_1079),
                            new InternalType_366(InternalVar_15.InternalProperty_329, -1f, InternalVar_15.InternalProperty_330, InternalVar_15.InternalProperty_1079),
                            out InternalVar_3.InternalField_3434
                            );
                        InternalVar_3.InternalField_1583 = new InternalType_366(InternalVar_14.InternalProperty_329, InternalVar_7.InternalProperty_1079, InternalVar_14.InternalProperty_330, InternalVar_14.InternalProperty_1079);
                        InternalMethod_1882(InternalVar_3);
                    }
                }
                else
                {
                    float2 InternalVar_6 = InternalVar_5.InternalField_1077;
                    float2 InternalVar_7 = InternalType_187.InternalField_521 * InternalVar_6;
                    float2 InternalVar_8 = ((float2)InternalVar_4.InternalField_1024.center - InternalVar_7) / InternalVar_7;
                    float2 InternalVar_9 = InternalVar_6 / (float2)InternalVar_4.InternalField_1024.size;
                    float2 InternalVar_10 = InternalType_187.InternalField_522 / InternalVar_9;
                    InternalVar_3.InternalField_3435 = InternalVar_8 + InternalVar_10 * InternalVar_2.InternalField_271.InternalField_274.InternalField_365;
                    InternalVar_3.InternalField_3434 = InternalVar_10 * math.select(float2.zero, InternalType_187.InternalField_522 / InternalVar_2.InternalField_271.InternalField_274.InternalField_366, InternalVar_2.InternalField_271.InternalField_274.InternalField_366 != float2.zero);

                    if (InternalVar_2.InternalField_271.InternalField_274.InternalField_367 == InternalType_112.InternalField_364)
                    {
                        float InternalVar_11 = InternalVar_1.InternalField_1264.InternalProperty_722.x / InternalVar_1.InternalField_1264.InternalProperty_722.y;
                        float InternalVar_12 = InternalVar_4.InternalProperty_308 / InternalVar_11;
                        if (InternalVar_12 > 1)
                        {
                            InternalVar_3.InternalField_3434.x /= InternalVar_12;
                        }
                        else
                        {
                            InternalVar_3.InternalField_3434.y *= InternalVar_12;
                        }
                    }

                    InternalMethod_1882(InternalVar_3);
                }
            }
            else
            {
                InternalMethod_1882(InternalVar_3);
            }

            InternalMethod_1655(ref InternalField_1572, ref InternalVar_1);
            InternalMethod_1656(ref InternalField_1572, ref InternalVar_1);

            InternalMethod_1652();

            InternalField_1566.InternalMethod_748(InternalParameter_1829.InternalField_1295) = InternalField_1572;
        }

        
        private float2 InternalMethod_3413(InternalType_366 InternalParameter_2922, InternalType_366 InternalParameter_2921, out float2 InternalParameter_3024)
        {
            InternalParameter_3024 = (InternalParameter_2922.InternalField_1275 - InternalParameter_2922.InternalField_1274) / (InternalParameter_2921.InternalField_1275 - InternalParameter_2921.InternalField_1274);
            return InternalParameter_2922.InternalField_1275 - InternalParameter_2921.InternalField_1275 * InternalParameter_3024;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1652()
        {
            if (InternalField_1570.InternalField_1588.InternalProperty_216 == 0)
            {
                return;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1570.InternalField_1588.InternalProperty_216; ++InternalVar_1)
            {
                ref InternalType_417 InternalVar_2 = ref InternalField_1570.InternalField_1588.InternalMethod_800(InternalVar_1);

                InternalField_1570.InternalField_1589.InternalMethod_785(InternalVar_2.InternalField_1583.InternalField_1274.x);
                InternalField_1570.InternalField_1590.InternalMethod_785(InternalVar_2.InternalField_1583.InternalField_1274.y);
                InternalField_1570.InternalField_1589.InternalMethod_785(InternalVar_2.InternalField_1583.InternalField_1275.x);
                InternalField_1570.InternalField_1590.InternalMethod_785(InternalVar_2.InternalField_1583.InternalField_1275.y);
            }

            InternalField_1570.InternalField_1589.InternalMethod_778();
            InternalField_1570.InternalField_1590.InternalMethod_778();
            InternalMethod_1653(ref InternalField_1570.InternalField_1589);
            InternalMethod_1653(ref InternalField_1570.InternalField_1590);

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1570.InternalField_1588.InternalProperty_216; ++InternalVar_1)
            {
                ref InternalType_417 InternalVar_2 = ref InternalField_1570.InternalField_1588.InternalMethod_800(InternalVar_1);

                int2 InternalVar_3 = default;
                InternalVar_3.x = InternalMethod_1918(ref InternalField_1570.InternalField_1589, InternalVar_2.InternalField_1583.InternalField_1275.x);
                InternalVar_3.y = InternalMethod_1918(ref InternalField_1570.InternalField_1590, InternalVar_2.InternalField_1583.InternalField_1275.y);
                InternalMethod_1654(ref InternalVar_2, ref InternalVar_3);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private int InternalMethod_1918(ref InternalType_164<float> InternalParameter_452, float InternalParameter_451)
        {
            float InternalVar_1 = InternalType_187.InternalMethod_871(InternalParameter_452[0] - InternalParameter_451);
            float InternalVar_2 = InternalVar_1;
            int InternalVar_3 = 0;
            for (int InternalVar_4 = 1; InternalVar_4 < InternalParameter_452.InternalProperty_216; ++InternalVar_4)
            {
                float InternalVar_5 = InternalType_187.InternalMethod_871(InternalParameter_452[InternalVar_4] - InternalParameter_451);

                bool InternalVar_6 = InternalVar_5 < InternalVar_1;
                InternalVar_1 = math.select(InternalVar_1, InternalVar_5, InternalVar_6);
                InternalVar_3 = math.select(InternalVar_3, InternalVar_4, InternalVar_6);

                if (InternalVar_5 > InternalVar_2)
                {
                    break;
                }
                InternalVar_2 = InternalVar_5;
            }

            return InternalVar_3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1653(ref InternalType_164<float> InternalParameter_1830)
        {
            float InternalVar_1 = InternalParameter_1830[0];
            int InternalVar_2 = 1;
            for (int InternalVar_3 = 1; InternalVar_3 < InternalParameter_1830.InternalProperty_216; ++InternalVar_3)
            {
                float InternalVar_4 = InternalParameter_1830[InternalVar_3];
                if (!InternalType_187.InternalMethod_922(InternalVar_4, InternalVar_1))
                {
                    InternalParameter_1830[InternalVar_2++] = InternalVar_4;
                }

                InternalVar_1 = InternalParameter_1830[InternalVar_3];
            }

            InternalParameter_1830.InternalProperty_216 = InternalVar_2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1654(ref InternalType_417 InternalParameter_1831, ref int2 InternalParameter_1832)
        {
            InternalType_383 InternalVar_1 = new InternalType_383()
            {
                InternalField_1325 = InternalField_1571,
                InternalField_1326 = InternalParameter_1831.InternalField_1584 ? 0f : 1f,
                InternalField_3432 = InternalParameter_1831.InternalField_3435,
                InternalField_3431 = InternalParameter_1831.InternalField_3434,
            };


            for (int InternalVar_2 = InternalParameter_1832.x - 1; InternalVar_2 >= 0; --InternalVar_2)
            {
                float InternalVar_3 = InternalField_1570.InternalField_1589[InternalVar_2];

                for (int InternalVar_4 = InternalParameter_1832.y - 1; InternalVar_4 >= 0; --InternalVar_4)
                {
                    float InternalVar_5 = InternalField_1570.InternalField_1590[InternalVar_4];

                    float InternalVar_6 = InternalField_1570.InternalField_1589[InternalVar_2 + 1];
                    float InternalVar_7 = InternalField_1570.InternalField_1590[InternalVar_4 + 1];

                    InternalVar_1.InternalField_1324 = math.transform(InternalField_1574, new float3(InternalVar_6, InternalVar_7, 0)).xy;
                    InternalField_1572.InternalField_1586.InternalMethod_785(InternalVar_1);

                    InternalVar_1.InternalField_1324 = math.transform(InternalField_1574, new float3(InternalVar_6, InternalVar_5, 0)).xy;
                    InternalField_1572.InternalField_1586.InternalMethod_785(InternalVar_1);

                    InternalVar_1.InternalField_1324 = math.transform(InternalField_1574, new float3(InternalVar_3, InternalVar_5, 0)).xy;
                    InternalField_1572.InternalField_1586.InternalMethod_785(InternalVar_1);

                    InternalVar_1.InternalField_1324 = math.transform(InternalField_1574, new float3(InternalVar_3, InternalVar_7, 0)).xy;
                    InternalField_1572.InternalField_1586.InternalMethod_785(InternalVar_1);

                    if (InternalType_187.InternalMethod_922(InternalVar_5, InternalParameter_1831.InternalField_1583.InternalField_1274.y))
                    {
                        break;
                    }
                }

                if (InternalType_187.InternalMethod_922(InternalVar_3, InternalParameter_1831.InternalField_1583.InternalField_1274.x))
                {
                    break;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1655(ref InternalType_418 InternalParameter_1833, ref InternalType_364 InternalParameter_1834)
        {
            if (!InternalParameter_1834.InternalProperty_326)
            {
                return;
            }

            InternalType_413 InternalVar_1 = new InternalType_413(ref InternalParameter_1834);
            for (int InternalVar_2 = 0; InternalVar_2 < InternalParameter_1833.InternalField_1585.InternalProperty_216; ++InternalVar_2)
            {
                ref InternalType_364 InternalVar_3 = ref InternalField_1569.InternalField_1315.InternalField_1308.InternalMethod_800(InternalParameter_1833.InternalField_1585[InternalVar_2]);

                InternalType_411 InternalVar_4 = InternalMethod_1661(ref InternalVar_3);
                switch (InternalVar_4)
                {
                    case InternalType_411.InternalField_1579:
                        InternalType_414 InternalVar_5 = new InternalType_414(ref InternalVar_3);
                        InternalMethod_1657(ref InternalVar_1, ref InternalVar_5);
                        break;
                    case InternalType_411.InternalField_1577:
                        InternalType_413 InternalVar_6 = new InternalType_413(ref InternalVar_3);
                        InternalMethod_1657(ref InternalVar_1, ref InternalVar_6);
                        break;
                    case InternalType_411.InternalField_1578:
                        InternalType_415 InternalVar_7 = new InternalType_415(ref InternalVar_3);
                        InternalMethod_1657(ref InternalVar_1, ref InternalVar_7);
                        break;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1656(ref InternalType_418 InternalParameter_1835, ref InternalType_364 InternalParameter_1836)
        {
            if (!InternalParameter_1836.InternalProperty_324)
            {
                return;
            }

            InternalType_415 InternalVar_1 = new InternalType_415(ref InternalParameter_1836);
            for (int InternalVar_2 = 0; InternalVar_2 < InternalParameter_1835.InternalField_1585.InternalProperty_216; ++InternalVar_2)
            {
                ref InternalType_364 InternalVar_3 = ref InternalField_1569.InternalField_1315.InternalField_1308.InternalMethod_800(InternalParameter_1835.InternalField_1585[InternalVar_2]);

                InternalType_411 InternalVar_4 = InternalMethod_1661(ref InternalVar_3);
                switch (InternalVar_4)
                {
                    case InternalType_411.InternalField_1579:
                        InternalType_414 InternalVar_5 = new InternalType_414(ref InternalVar_3);
                        InternalMethod_1657(ref InternalVar_1, ref InternalVar_5);
                        break;
                    case InternalType_411.InternalField_1577:
                        InternalType_413 InternalVar_6 = new InternalType_413(ref InternalVar_3);
                        InternalMethod_1657(ref InternalVar_1, ref InternalVar_6);
                        break;
                    case InternalType_411.InternalField_1578:
                        InternalType_415 InternalVar_7 = new InternalType_415(ref InternalVar_3);
                        InternalMethod_1657(ref InternalVar_1, ref InternalVar_7);
                        break;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1657<T, U>(ref T InternalParameter_1837, ref U InternalParameter_1838)
            where T : unmanaged, InternalType_412
            where U : unmanaged, InternalType_412
        {
            ref InternalType_366 InternalVar_1 = ref InternalParameter_1837.InternalProperty_342;
            ref InternalType_366 InternalVar_2 = ref InternalParameter_1838.InternalProperty_342;

            bool4 InternalVar_3 = InternalVar_1.InternalMethod_1573(ref InternalVar_2);
            if (!math.any(InternalVar_3))
            {
                return;
            }

            InternalType_366 InternalVar_4 = InternalParameter_1838.InternalProperty_341;
            bool4 InternalVar_6 = InternalMethod_1660(ref InternalVar_1, ref InternalVar_4, out float4 InternalVar_5);
            float4 InternalVar_7 = InternalParameter_1838.InternalProperty_340;

            bool InternalVar_8 = !InternalType_187.InternalMethod_914(InternalParameter_1838.InternalProperty_339);

            if (InternalVar_8)
            {
                bool4 InternalVar_9 = InternalType_187.InternalMethod_929(ref InternalVar_5, ref InternalVar_7);
                for (int InternalVar_10 = 0; InternalVar_10 < 4; ++InternalVar_10)
                {
                    if (!InternalVar_9[InternalVar_10])
                    {
                        continue;
                    }

                    InternalType_366 InternalVar_11 = InternalParameter_1838.InternalMethod_1666(InternalVar_10);
                    InternalMethod_1658(ref InternalVar_11);
                }
            }
            else
            {
                InternalType_366 InternalVar_9 = InternalParameter_1838.InternalMethod_1666(0);
                InternalMethod_1658(ref InternalVar_9);
            }

            if (!InternalVar_8 || !InternalType_187.InternalMethod_922(InternalParameter_1837.InternalProperty_339, InternalParameter_1838.InternalProperty_339))
            {
                return;
            }

            for (int InternalVar_9 = 0; InternalVar_9 < 4; ++InternalVar_9)
            {
                float2 InternalVar_10 = InternalVar_1.InternalMethod_1571(InternalVar_9);
                float2 InternalVar_11 = InternalVar_2.InternalMethod_1571(InternalVar_9);

                if (!InternalType_187.InternalMethod_924(ref InternalVar_10, ref InternalVar_11))
                {
                    continue;
                }

                InternalType_366 InternalVar_12 = InternalParameter_1837.InternalMethod_1667(InternalVar_9);
                InternalMethod_1658(ref InternalVar_12);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1658(ref InternalType_366 InternalParameter_1839)
        {
            float2 InternalVar_1 = InternalParameter_1839.InternalProperty_722;
            if (math.any(InternalType_187.InternalMethod_918(ref InternalVar_1)))
            {
                return;
            }

            int InternalVar_2 = InternalField_1570.InternalField_1588.InternalProperty_216;
            for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_2; ++InternalVar_3)
            {
                InternalType_417 InternalVar_4 = InternalField_1570.InternalField_1588[InternalVar_3];
                if (!InternalVar_4.InternalField_1583.InternalMethod_1575(ref InternalParameter_1839))
                {
                    continue;
                }

                InternalField_1570.InternalField_1588.InternalMethod_783(InternalVar_3, InternalVar_2 - 1);
                InternalField_1570.InternalField_1588.InternalMethod_786(InternalVar_2 - 1);
                InternalVar_2 -= 1;
                InternalVar_3 -= 1;

                InternalMethod_1659(ref InternalVar_4, ref InternalParameter_1839);

                InternalVar_4.InternalField_1583 = new InternalType_366(math.max(InternalVar_4.InternalField_1583.InternalField_1274, InternalParameter_1839.InternalField_1274), math.min(InternalVar_4.InternalField_1583.InternalField_1275, InternalParameter_1839.InternalField_1275));
                InternalVar_4.InternalField_1584 = true;
                InternalMethod_1882(InternalVar_4);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1659(ref InternalType_417 InternalParameter_1840, ref InternalType_366 InternalParameter_1841)
        {
            bool4 InternalVar_2 = InternalMethod_1660(ref InternalParameter_1840.InternalField_1583, ref InternalParameter_1841, out float4 InternalVar_1);

            InternalType_417 InternalVar_3 = InternalParameter_1840;

            if (InternalVar_2.x)
            {
                InternalVar_3.InternalField_1583 = new InternalType_366(new float2(InternalParameter_1841.InternalField_1275.x, InternalParameter_1840.InternalField_1583.InternalField_1274.y + InternalVar_1.w), new float2(InternalParameter_1840.InternalField_1583.InternalField_1275.x, InternalParameter_1840.InternalField_1583.InternalField_1275.y - InternalVar_1.y));
                InternalMethod_1882(InternalVar_3);
            }

            if (InternalVar_2.y)
            {
                InternalVar_3.InternalField_1583 = new InternalType_366(new float2(InternalParameter_1840.InternalField_1583.InternalField_1274.x, InternalParameter_1841.InternalField_1275.y), InternalParameter_1840.InternalField_1583.InternalField_1275);
                InternalMethod_1882(InternalVar_3);
            }

            if (InternalVar_2.z)
            {
                InternalVar_3.InternalField_1583 = new InternalType_366(new float2(InternalParameter_1840.InternalField_1583.InternalField_1274.x, InternalParameter_1840.InternalField_1583.InternalField_1274.y + InternalVar_1.w), new float2(InternalParameter_1841.InternalField_1274.x, InternalParameter_1840.InternalField_1583.InternalField_1275.y - InternalVar_1.y));
                InternalMethod_1882(InternalVar_3);
            }

            if (InternalVar_2.w)
            {
                InternalVar_3.InternalField_1583 = new InternalType_366(InternalParameter_1840.InternalField_1583.InternalField_1274, new float2(InternalParameter_1840.InternalField_1583.InternalField_1275.x, InternalParameter_1841.InternalField_1274.y));
                InternalMethod_1882(InternalVar_3);
            }
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1882(InternalType_417 InternalParameter_450)
        {
            float2 InternalVar_1 = InternalParameter_450.InternalField_1583.InternalProperty_722;
            if (math.any(InternalType_187.InternalMethod_918(ref InternalVar_1)))
            {
                return;
            }

            InternalField_1570.InternalField_1588.InternalMethod_785(InternalParameter_450);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4 InternalMethod_1660(ref InternalType_366 InternalParameter_1842, ref InternalType_366 InternalParameter_1843, out float4 InternalParameter_1844)
        {
            InternalParameter_1844 = default;
            InternalParameter_1844.xy = InternalParameter_1842.InternalField_1275 - InternalParameter_1843.InternalField_1275;
            InternalParameter_1844.zw = InternalParameter_1843.InternalField_1274 - InternalParameter_1842.InternalField_1274;
            InternalParameter_1844 = math.max(InternalParameter_1844, float4.zero);
            return !InternalType_187.InternalMethod_920(ref InternalParameter_1844);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private InternalType_411 InternalMethod_1661(ref InternalType_364 InternalParameter_1845)
        {
            if (InternalParameter_1845.InternalProperty_327)
            {
                return InternalParameter_1845.InternalProperty_328 ? InternalType_411.InternalField_1579 : InternalType_411.InternalField_1577;
            }
            else if (InternalParameter_1845.InternalProperty_328)
            {
                return InternalType_411.InternalField_1578;
            }
            else
            {
                return InternalType_411.InternalField_1576;
            }
        }

        private enum InternalType_411
        {
            InternalField_1576,
            InternalField_1577,
            InternalField_1578,
            InternalField_1579,
        }
    }
}

