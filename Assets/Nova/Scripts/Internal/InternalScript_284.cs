using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal unsafe struct InternalType_407 : InternalType_193
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_792;

        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_133, int> InternalField_1526;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_220> InternalField_1527;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_299<InternalType_71>> InternalField_1528;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_55> InternalField_1529;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_360 InternalField_1530;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_79> InternalField_1531;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_80> InternalField_1532;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_82> InternalField_1533;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_371 InternalField_1534;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_133, InternalType_73> InternalField_1535;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_222> InternalField_1536;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53.InternalType_54> InternalField_1537;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_53> InternalField_1538;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_99> InternalField_1539;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1540;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_359 InternalField_1541;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, byte> InternalField_3304;

        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_272<InternalType_384> InternalField_1542;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_272<InternalType_385> InternalField_1543;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_272<InternalType_387> InternalField_1544;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_272<InternalType_258> InternalField_1545;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_272<InternalType_389> InternalField_1546;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_272<InternalType_394> InternalField_1547;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_133 InternalField_1548;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_131 InternalField_1549;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_1550;

        public void Execute(int index)
        {
            InternalField_1548 = index;

            InternalField_1550 = InternalField_1526.ContainsKey(InternalField_1548);
            bool InternalVar_1 = InternalField_1527[InternalField_1548] >= InternalType_220.InternalField_3626;
            if (!InternalField_1550 && !InternalVar_1 && !InternalField_792)
            {
                return;
            }

            InternalField_1549 = InternalField_1536[InternalField_1548].InternalField_585;

            InternalType_299<InternalType_71> InternalVar_2 = InternalField_1528[InternalField_1548];

            if (!InternalVar_2.InternalField_983.InternalField_235)
            {
                return;
            }

            if (NovaApplication.ConstIsEditor && InternalField_3304.ContainsKey(InternalField_1549))
            {
                return;
            }

            switch (InternalVar_2.InternalField_983.InternalField_234)
            {
                case InternalType_72.InternalField_237:
                    InternalMethod_1646(ref InternalVar_2);
                    break;
                case InternalType_72.InternalField_239:
                    InternalMethod_1642(ref InternalVar_2);
                    break;
                case InternalType_72.InternalField_238:
                    InternalMethod_1643(ref InternalVar_2);
                    break;
            }

            ref InternalType_73 InternalVar_3 = ref InternalField_1535.InternalMethod_748(InternalField_1548);
            if (InternalVar_3.InternalProperty_163)
            {
                InternalType_259 InternalVar_4 = InternalField_1534.InternalField_1287[InternalField_1548];
                ref InternalType_393 InternalVar_5 = ref InternalField_1547.InternalMethod_1253(InternalVar_4).InternalField_1386;
                switch (InternalVar_3.InternalProperty_1032)
                {
                    case InternalType_104.InternalField_324:
                        break;
                    case InternalType_104.InternalField_325:
                        InternalVar_5.InternalField_1382.InternalField_1373 = InternalVar_3.InternalProperty_158;
                        InternalVar_5.InternalField_1382.InternalField_1374 = InternalVar_3.InternalProperty_160;
                        break;
                    case InternalType_104.InternalField_326:
                        InternalVar_5.InternalField_1383.InternalField_1376 = InternalVar_3.InternalProperty_159;
                        InternalVar_5.InternalField_1383.InternalField_1377 = InternalVar_3.InternalProperty_161;
                        break;
                    case InternalType_104.InternalField_327:
                        InternalVar_5.InternalField_1384.InternalField_1379.InternalMethod_1601(ref InternalVar_3.InternalField_240);
                        InternalVar_5.InternalField_1384.InternalField_1380 = InternalVar_3.InternalProperty_159;
                        break;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1642(ref InternalType_299<InternalType_71> InternalParameter_1811)
        {
            InternalType_82 InternalVar_1 = InternalField_1533[InternalParameter_1811.InternalField_984];
            ref InternalType_389 InternalVar_2 = ref InternalField_1546.InternalMethod_1253(InternalField_1534.InternalField_1289[InternalParameter_1811.InternalField_984]);

            float3 InternalVar_3 = InternalType_448.InternalMethod_1751(InternalField_1548, ref InternalField_1529).InternalProperty_398.InternalProperty_124;
            float InternalVar_4 = 0.5f * math.cmin(InternalVar_3.xy);
            float InternalVar_5 = InternalVar_1.InternalMethod_1480(InternalVar_4);
            float InternalVar_6 = InternalVar_1.InternalMethod_1481(InternalVar_3.z, InternalVar_5);

            InternalVar_2.InternalField_1370.InternalMethod_1601(ref InternalVar_1.InternalField_277);
            InternalVar_2.InternalField_1368 = InternalVar_5;
            InternalVar_2.InternalField_1369 = InternalVar_6;
            InternalVar_2.InternalField_1367 = InternalVar_3;
            InternalMethod_1645(ref InternalVar_2.InternalField_1371);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1643(ref InternalType_299<InternalType_71> InternalParameter_1812)
        {
            ref InternalType_79 InternalVar_1 = ref InternalField_1531.InternalMethod_748(InternalParameter_1812.InternalField_984);

            int InternalVar_2 = InternalVar_1.InternalField_3197;
            if (InternalVar_2 == 0)
            {
                return;
            }

            float InternalVar_3 = math.length(InternalField_1540.ElementAt(InternalField_1548).c1.xyz);
            InternalVar_3 = math.isnan(InternalVar_3) ? 0f : InternalVar_3;

            if (InternalField_1550)
            {
                InternalMethod_1644(ref InternalParameter_1812, 1f);
            }
            else
            {
                float InternalVar_4 = InternalType_187.InternalMethod_871(InternalVar_3 / InternalVar_1.InternalField_264);
                InternalVar_4 = math.isnan(InternalVar_4) ? 0f : InternalVar_4;
                InternalMethod_1644(ref InternalParameter_1812, InternalVar_4);
                return;
            }

            InternalType_164<InternalType_259> InternalVar_5 = InternalField_1534.InternalField_1291[InternalParameter_1812.InternalField_984];
            if (InternalVar_2 != InternalVar_5.InternalProperty_216)
            {
                Debug.LogError("Text vert count didn't match shader indices length");
            }

            InternalType_448.InternalType_449 InternalVar_6 = InternalType_448.InternalMethod_1747(InternalField_1548, ref InternalField_1538);
            InternalVar_6.InternalMethod_1807(ref InternalField_1537);
            InternalVar_6.InternalMethod_1796(ref InternalField_1539);

            float3 InternalVar_7 = new float3(InternalVar_1.InternalMethod_2606(InternalVar_6.InternalProperty_354.InternalProperty_177.xy), 0f);
            int InternalVar_8 = math.min(InternalVar_5.InternalProperty_216, InternalVar_2);
            for (int InternalVar_9 = 0; InternalVar_9 < InternalVar_8; ++InternalVar_9)
            {
                ref InternalType_258 InternalVar_10 = ref InternalField_1545.InternalMethod_1253(InternalVar_5[InternalVar_9]);
                InternalVar_10.InternalProperty_272 = InternalField_1534.InternalField_1287[InternalField_1548];
                InternalVar_1.InternalMethod_482(InternalVar_9, ref InternalVar_10, ref InternalVar_7);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1644(ref InternalType_299<InternalType_71> InternalParameter_1813, float InternalParameter_1814)
        {
            InternalType_164<InternalType_259> InternalVar_1 = InternalField_1534.InternalField_1291[InternalParameter_1813.InternalField_984];
            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1.InternalProperty_216; ++InternalVar_2)
            {
                ref InternalType_258 InternalVar_3 = ref InternalField_1545.InternalMethod_1253(InternalVar_1[InternalVar_2]);
                InternalVar_3.InternalMethod_1177(InternalParameter_1814);
            }
        }

        private void InternalMethod_1645(ref InternalType_259 InternalParameter_1815)
        {
            InternalParameter_1815 = InternalField_1534.InternalField_1287[InternalField_1548];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1646(ref InternalType_299<InternalType_71> InternalParameter_1816)
        {
            ref InternalType_80 InternalVar_1 = ref InternalField_1532.InternalMethod_748(InternalParameter_1816.InternalField_984);
            ref InternalType_384 InternalVar_2 = ref InternalField_1542.InternalMethod_1253(InternalField_1534.InternalField_1288[InternalParameter_1816.InternalField_984]);

            InternalMethod_1645(ref InternalVar_2.InternalField_1340);

            float2 InternalVar_3 = InternalType_448.InternalMethod_1751(InternalField_1548, ref InternalField_1529).InternalProperty_398.InternalProperty_124.xy;

            bool InternalVar_6 = InternalField_1541.InternalMethod_1556(InternalVar_1.InternalField_271.InternalField_276, out InternalType_311 InternalVar_4, out InternalType_321 InternalVar_5);
            if (InternalVar_6)
            {
                InternalVar_1.InternalMethod_1489(ref InternalVar_3, InternalVar_4.InternalProperty_308);
            }

            float2 InternalVar_7 = InternalType_187.InternalField_521 * InternalVar_3;
            float InternalVar_8 = math.cmin(InternalVar_7);
            float InternalVar_9 = InternalVar_1.InternalMethod_1479(InternalVar_8);

            if (InternalVar_6 && InternalVar_1.InternalField_271.InternalField_275 == InternalType_695.InternalField_2831 && InternalField_1530.InternalMethod_1558(InternalVar_4.InternalField_1025, out InternalType_314 InternalVar_10))
            {
                InternalVar_2.InternalField_1341 = InternalVar_10.InternalField_1040;
            }

            InternalVar_2.InternalField_1337 = InternalVar_9;

            if (InternalVar_1.InternalField_273)
            {
                InternalVar_2.InternalField_1334.InternalMethod_1601(ref InternalVar_1.InternalField_266);
                if (InternalVar_1.InternalField_268.InternalField_347)
                {
                    InternalVar_2.InternalField_1335.InternalMethod_1601(ref InternalVar_1.InternalField_268.InternalField_343);
                }
                else
                {
                    InternalVar_2.InternalField_1335 = InternalVar_2.InternalField_1334;
                }
            }
            else
            {
                InternalVar_2.InternalField_1334 = InternalType_382.InternalField_1323;
                InternalVar_2.InternalField_1335 = InternalType_382.InternalField_1323;
            }

            float2 InternalVar_11 = InternalVar_1.InternalField_268.InternalMethod_1484(ref InternalVar_3);
            float2 InternalVar_12 = InternalVar_1.InternalField_268.InternalMethod_1485(ref InternalVar_3);
            InternalVar_2.InternalField_1328 = InternalVar_12;
            InternalVar_2.InternalField_1329 = math.select(float2.zero, InternalType_187.InternalField_522 / InternalVar_11, InternalVar_11 > float2.zero);

            math.sincos(math.radians(InternalVar_1.InternalField_268.InternalField_346), out InternalVar_2.InternalField_1330.x, out InternalVar_2.InternalField_1330.y);

            InternalVar_2.InternalField_1327 = InternalVar_3;

            if (InternalVar_1.InternalField_3412.InternalProperty_1066)
            {
                InternalVar_2.InternalField_3419 = InternalVar_1.InternalField_3412.InternalMethod_3394(ref InternalVar_3);

                float InternalVar_13 = -InternalVar_1.InternalField_3412.InternalField_3414;
                float InternalVar_14 = InternalVar_1.InternalField_3412.InternalField_3415;
                if (InternalVar_14 < 0f)
                {
                    InternalVar_13 -= InternalVar_14;
                    InternalVar_14 = -InternalVar_14;
                }
                InternalVar_2.InternalField_3420 = math.radians(InternalVar_13);
                InternalVar_2.InternalField_3421 = -math.radians(InternalVar_14);
            }

            if (InternalVar_1.InternalField_269.InternalField_335)
            {
                InternalVar_2.InternalField_1342.InternalMethod_1601(ref InternalVar_1.InternalField_269.InternalField_333);
                InternalVar_2.InternalField_1343 = InternalVar_1.InternalField_269.InternalMethod_1482(InternalVar_8);

                InternalVar_1.InternalField_269.InternalMethod_1491(ref InternalVar_9, ref InternalVar_3, InternalVar_2.InternalField_1343);
            }

            float2 InternalVar_15 = InternalVar_1.InternalField_270.InternalMethod_1483(InternalVar_8);
            if (InternalVar_1.InternalField_270.InternalProperty_187)
            {
                InternalVar_2.InternalField_1336.InternalMethod_1601(ref InternalVar_1.InternalField_270.InternalField_337);
                InternalVar_2.InternalField_1331 = InternalVar_1.InternalField_270.InternalMethod_1486(ref InternalVar_3);
                InternalVar_2.InternalField_1338 = InternalVar_15.x;
                InternalVar_2.InternalField_1339 = InternalVar_15.y;
            }
            else
            {
                InternalVar_2.InternalField_1336 = InternalVar_2.InternalField_1334;
                InternalVar_2.InternalField_1331 = float2.zero;
                InternalVar_2.InternalField_1338 = 0;
                InternalVar_2.InternalField_1339 = 0;
            }

            if (InternalVar_1.InternalField_270.InternalProperty_186)
            {
                if (!InternalField_1534.InternalField_1290.TryGetValue(InternalParameter_1816.InternalField_984, out InternalType_259 InternalVar_16))
                {
                    Debug.LogError("Failed to get shadow shader index");
                    return;
                }

                if (!InternalField_1544.InternalMethod_1252(InternalVar_16, out InternalType_387* InternalVar_17))
                {
                    Debug.LogError("Failed to get shadow shader pointer");
                    return;
                }

                ref InternalType_385 InternalVar_18 = ref InternalField_1543.InternalMethod_1253(InternalVar_16);
                InternalVar_18 = new InternalType_385()
                {
                    InternalField_1344 = InternalVar_1.InternalField_270.InternalMethod_1486(ref InternalVar_3),
                    InternalField_1349 = InternalVar_9,
                    InternalField_1345 = InternalType_187.InternalField_521 * InternalVar_3,
                    InternalField_1347 = InternalVar_15.x,
                    InternalField_1348 = InternalVar_15.y,
                    InternalField_1351 = InternalVar_1.InternalField_273 ? 0f : 1f,
                };
                InternalVar_18.InternalField_1346.InternalMethod_1601(ref InternalVar_1.InternalField_270.InternalField_337);

                InternalMethod_1645(ref InternalVar_18.InternalField_1350);

                InternalVar_18.InternalField_3422 = InternalVar_2.InternalField_3419;
                InternalVar_18.InternalField_3423 = InternalVar_2.InternalField_3420;
                InternalVar_18.InternalField_3424 = InternalVar_2.InternalField_3421;

                InternalMethod_1647((InternalType_386*)InternalVar_17, ref InternalVar_1, ref InternalVar_3, ref InternalVar_15, InternalVar_9);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1647(InternalType_386* InternalParameter_1817, ref InternalType_80 InternalParameter_1818, ref float2 InternalParameter_1819, ref float2 InternalParameter_1820, float InternalParameter_1821)
        {
            float2 InternalVar_1 = InternalType_187.InternalField_521 * InternalParameter_1819;

            float4 InternalVar_2 = new float4(InternalVar_1.xx * InternalField_1551, float2.zero);
            float4 InternalVar_3 = new float4(float2.zero, InternalVar_1.yy * InternalField_1551);
            float2 InternalVar_4 = InternalParameter_1819 - 2 * InternalParameter_1821;
            float2 InternalVar_5 = InternalVar_1 - InternalParameter_1821;

            float InternalVar_6 = math.csum(InternalParameter_1820);
            float InternalVar_7 = InternalParameter_1821 + InternalVar_6;

            float2 InternalVar_8 = InternalParameter_1818.InternalField_270.InternalMethod_1486(ref InternalParameter_1819);

            float InternalVar_9 = InternalType_187.InternalMethod_871(InternalVar_8.y);
            float4 InternalVar_10 = new float4(InternalVar_6 + InternalField_1551 * InternalVar_8.x, InternalVar_4.xx - InternalType_187.InternalMethod_871(InternalVar_8.x));
            InternalVar_10 = InternalVar_10.InternalMethod_980();
            float4 InternalVar_11 = new float4(InternalVar_4.y - InternalVar_9, InternalVar_6 + InternalField_1551 * InternalVar_8.y);
            InternalVar_11 = InternalVar_11.InternalMethod_980();

            float4 InternalVar_12 = new float4(InternalVar_2.xy + InternalField_1552 * InternalVar_10.xy, .5f * InternalVar_8.x);
            float4 InternalVar_13 = new float4(.5f * InternalVar_8.y, InternalVar_3.zw + InternalField_1552 * InternalVar_11.zw);

            float2 InternalVar_14 = InternalType_187.InternalMethod_873(InternalVar_8);
            float2 InternalVar_15 = math.sign(InternalVar_8);

            bool4 InternalVar_16 = InternalVar_15.x == InternalField_1553;
            bool4 InternalVar_17 = InternalVar_15.y == InternalField_1554;

            float2 InternalVar_18 = (InternalVar_14 - InternalVar_4).InternalMethod_979();

            float4 InternalVar_19 = math.select(InternalVar_8.x, InternalVar_18.x * InternalField_1553, InternalVar_16);
            float4 InternalVar_20 = math.select(float4.zero, InternalVar_14.x - InternalVar_18.x, InternalVar_16);

            float4 InternalVar_21 = math.select(InternalVar_8.y, InternalVar_18.y * InternalField_1554, InternalVar_17);
            float4 InternalVar_22 = math.select(float4.zero, InternalVar_14.y - InternalVar_18.y, InternalVar_17);

            float4 InternalVar_23 = new float4(InternalVar_7);
            float4 InternalVar_24 = InternalVar_23 + InternalVar_20;
            float4 InternalVar_25 = InternalVar_23 + InternalVar_22;

            float4 InternalVar_26 = InternalField_1553 * (InternalVar_5.xxxx + InternalType_187.InternalField_539 * InternalVar_24) + InternalVar_19;
            float4 InternalVar_27 = InternalField_1554 * (InternalVar_5.yyyy + InternalType_187.InternalField_539 * InternalVar_25) + InternalVar_21;

            for (int InternalVar_28 = 0; InternalVar_28 < 2; ++InternalVar_28)
            {
                InternalParameter_1817->InternalField_1353 = new float2(InternalVar_26[InternalVar_28], InternalVar_13[InternalVar_28]);
                InternalParameter_1817->InternalField_1354 = new float2(InternalVar_24[InternalVar_28], InternalVar_11[InternalVar_28]);
                InternalParameter_1817 += 1;
            }

            for (int InternalVar_28 = 2; InternalVar_28 < 4; ++InternalVar_28)
            {
                InternalParameter_1817->InternalField_1353 = new float2(InternalVar_12[InternalVar_28], InternalVar_27[InternalVar_28 - 1]);
                InternalParameter_1817->InternalField_1354 = new float2(InternalVar_10[InternalVar_28], InternalVar_25[InternalVar_28 - 1]);
                InternalParameter_1817 += 1;
            }

            for (int InternalVar_28 = 0; InternalVar_28 < 4; ++InternalVar_28)
            {
                InternalParameter_1817->InternalField_1353 = new float2(InternalVar_26[InternalVar_28], InternalVar_27[InternalVar_28]);
                InternalParameter_1817->InternalField_1354 = new float2(InternalVar_24[InternalVar_28], InternalVar_25[InternalVar_28]);
                InternalParameter_1817 += 1;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static readonly float2 InternalField_1551 = new float2(1f, -1f);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static readonly float2 InternalField_1552 = InternalType_187.InternalField_521 * InternalField_1551;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static readonly float4 InternalField_1553 = new float4(InternalField_1551, InternalField_1551);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static readonly float4 InternalField_1554 = new float4(1, 1, -1, -1);
    }
}

