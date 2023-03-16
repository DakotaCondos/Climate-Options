using AOT;
using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal static partial class InternalType_362
    {
        [BurstCompile]
        internal struct InternalType_295 : InternalType_147
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_341 InternalField_1132;
            
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        public NativeList<InternalType_131> InternalField_3376;
            
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        public NativeList<InternalType_131> InternalField_968;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_133> InternalField_1243;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float4x4> InternalField_1242;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<float4x4> InternalField_2168;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_302> InternalField_967;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_101> InternalField_966;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_162<InternalType_304, InternalType_356>> InternalField_965;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, InternalType_408> InternalField_964;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<InternalType_131, int> InternalField_3377;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NovaHashMap<InternalType_131, InternalType_162<InternalType_305, InternalType_361>> InternalField_963;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NovaHashMap<InternalType_131, InternalType_162<InternalType_304, InternalType_297>> InternalField_962;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NativeList<InternalType_162<InternalType_305, InternalType_361>> InternalField_961;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NativeList<InternalType_162<InternalType_304, InternalType_297>> InternalField_960;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NativeList<InternalType_19> InternalField_959;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private InternalType_377 InternalField_958;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NativeList<InternalType_19> InternalField_957;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NovaHashMap<InternalType_19, byte> InternalField_956;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NovaHashMap<InternalType_19, byte> InternalField_955;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private NativeList<InternalType_19> InternalField_954;

            private void InternalMethod_1324()
            {
                InternalField_1132.InternalField_1254 = math.inverse(InternalField_1132.InternalField_1255);
                InternalField_959.Clear();
                InternalField_968.Clear();

                for (int InternalVar_1 = 0; InternalVar_1 < InternalField_3376.Length; ++InternalVar_1)
                {
                    InternalType_131 InternalVar_2 = InternalField_3376[InternalVar_1];

                    if (!InternalMethod_3364(InternalVar_2))
                    {
                        continue;
                    }

                    InternalField_968.Add(InternalVar_2);
                    InternalMethod_1311(InternalVar_2);
                }

                InternalMethod_1312();

                InternalMethod_1321();

                InternalMethod_1322();

                InternalMethod_1323();

            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private bool InternalMethod_3364(InternalType_131 InternalParameter_232)
            {
                if (InternalField_1132.InternalField_3375 == CameraType.SceneView)
                {
                    return true;
                }

                if (!InternalField_964.TryGetValue(InternalParameter_232, out InternalType_408 InternalVar_1))
                {
                    return true;
                }

                if (!InternalField_3377.TryGetValue(InternalVar_1.InternalField_1555, out int InternalVar_2))
                {
                    return true;
                }

                return InternalVar_2 == InternalField_1132.InternalField_3374;
            }

            
            private void InternalMethod_1323()
            {
                for (int InternalVar_1 = 0; InternalVar_1 < InternalField_968.Length; ++InternalVar_1)
                {
                    InternalType_131 InternalVar_2 = InternalField_968[InternalVar_1];
                    if (!InternalField_967.TryGetValue(InternalVar_2, out InternalType_302 InternalVar_3))
                    {
                        continue;
                    }

                    InternalType_162<InternalType_305, InternalType_361> InternalVar_4 = InternalField_963.InternalMethod_1297(InternalVar_2, InternalVar_3.InternalProperty_304);
                    InternalType_162<InternalType_304, InternalType_297> InternalVar_5 = InternalField_962[InternalVar_2];
                    InternalType_162<InternalType_304, InternalType_356> InternalVar_6 = InternalField_965[InternalVar_2];
                    for (int InternalVar_7 = 0; InternalVar_7 < InternalVar_3.InternalField_992.InternalProperty_216; ++InternalVar_7)
                    {
                        ref InternalType_300 InternalVar_8 = ref InternalVar_3.InternalField_992.InternalMethod_758(InternalVar_7);
                        ref InternalType_276 InternalVar_9 = ref InternalVar_3.InternalField_991.InternalMethod_758(InternalVar_8.InternalField_986);

                        ref InternalType_361 InternalVar_10 = ref InternalVar_4.InternalMethod_758(InternalVar_8.InternalField_987);

                        if (!InternalVar_9.InternalField_902.InternalMethod_1605())
                        {
                            ref InternalType_356 InternalVar_11 = ref InternalVar_6.InternalMethod_758(InternalVar_8.InternalField_988);
                            InternalType_133 InternalVar_12 = InternalField_1243[InternalVar_11.InternalField_577];
                            ref float4x4 InternalVar_13 = ref InternalField_2168.ElementAt(InternalVar_12);

                            InternalVar_10 = new InternalType_361()
                            {
                                InternalField_1259 = InternalType_306.InternalMethod_1379(ref InternalVar_13, ref InternalVar_8.InternalField_578).InternalMethod_1364(),
                                InternalField_1258 = false
                            };
                            continue;
                        }

                        ref InternalType_297 InternalVar_14 = ref InternalVar_5.InternalMethod_758(InternalVar_8.InternalField_988);

                        if (!InternalVar_14.InternalField_1179.InternalProperty_779)
                        {
                            InternalVar_10 = InternalType_361.InternalField_1256;
                            continue;
                        }

                        float3 InternalVar_15 = InternalType_178.InternalField_477 * InternalVar_14.InternalField_1178.InternalField_945;
                        float3 InternalVar_16 = InternalVar_8.InternalField_989 * InternalVar_15 + InternalVar_14.InternalField_1178.InternalField_946;

                        if (!InternalType_187.InternalMethod_935(ref InternalVar_16))
                        {
                            Debug.LogError($"BoundCenter for drawcall was invalid: {InternalVar_16}");
                        }

                        InternalVar_10 = new InternalType_361()
                        {
                            InternalField_1259 = new Bounds(InternalVar_16, InternalVar_14.InternalField_1245),
                            InternalField_1258 = InternalVar_14.InternalField_1176
                        };
                    }

                    InternalField_963[InternalVar_2] = InternalVar_4;
                }
            }

            
            private void InternalMethod_1322()
            {
                InternalField_957.Clear();
                InternalField_956.Clear();
                InternalField_955.Clear();
                InternalField_957.AddRange(InternalField_959.AsArray());

                while (InternalField_957.Length != 0)
                {
                    InternalType_19 InternalVar_1 = InternalField_957.InternalMethod_1018();
                    ref InternalType_297 InternalVar_2 = ref InternalField_962.InternalMethod_1007(ref InternalVar_1);

                    if (InternalField_956.ContainsKey(InternalVar_1) || !InternalVar_2.InternalField_1179.InternalProperty_779)
                    {
                        InternalField_957.InternalMethod_1019();
                        continue;
                    }

                    bool InternalVar_4 = InternalField_958.InternalMethod_3325(InternalVar_1, out InternalType_164<InternalType_19> InternalVar_3);
                    if (InternalVar_4 && !InternalField_955.ContainsKey(InternalVar_1))
                    {
                        bool InternalVar_5 = true;
                        for (int InternalVar_6 = 0; InternalVar_6 < InternalVar_3.InternalProperty_216; ++InternalVar_6)
                        {
                            if (!InternalField_956.ContainsKey(InternalVar_3[InternalVar_6]))
                            {
                                InternalField_957.Add(InternalVar_3[InternalVar_6]);
                                InternalVar_5 = false;
                            }
                        }

                        InternalField_955.Add(InternalVar_1, 0);

                        if (!InternalVar_5)
                        {
                            continue;
                        }
                    }

                    InternalField_957.InternalMethod_1019();
                    InternalField_956.Add(InternalVar_1, 1);

                    if (InternalVar_4)
                    {
                        for (int InternalVar_5 = 0; InternalVar_5 < InternalVar_3.InternalProperty_216; ++InternalVar_5)
                        {
                            ref InternalType_19 InternalVar_6 = ref InternalVar_3.InternalMethod_800(InternalVar_5);
                            ref InternalType_297 InternalVar_7 = ref InternalField_962.InternalMethod_1007(ref InternalVar_6);
                            int InternalVar_8 = InternalField_965.InternalMethod_1007(ref InternalVar_6).InternalField_1246;
                            InternalField_1132.InternalMethod_1588(ref InternalVar_2, ref InternalVar_7, InternalVar_8);
                        }
                    }

                    float3 InternalVar_9 = InternalField_1132.InternalMethod_1590(ref InternalVar_2);
                    float3 InternalVar_10 = math.transform(InternalField_1132.InternalField_1254, InternalVar_2.InternalField_1179.InternalField_1175);

                    if (!InternalType_187.InternalMethod_935(ref InternalVar_10))
                    {
                        Debug.LogError($"BoundCenter for CoplanarSet was invalid: {InternalVar_10}");
                    }

                    if (!InternalType_187.InternalMethod_935(ref InternalVar_9))
                    {
                        Debug.LogError($"OffsetDirection for CoplanarSet was invalid: {InternalVar_9}");
                    }

                    InternalVar_2.InternalField_1178 = new InternalType_291()
                    {
                        InternalField_946 = InternalVar_10,
                        InternalField_945 = InternalVar_9,
                    };
                }
            }

            
            private void InternalMethod_1321()
            {
                InternalField_958.InternalMethod_1592();

                for (int InternalVar_1 = 0; InternalVar_1 < InternalField_954.Length; ++InternalVar_1)
                {
                    ref InternalType_19 InternalVar_2 = ref InternalField_954.ElementAt(InternalVar_1);

                    if (InternalField_965.InternalMethod_1007(ref InternalVar_2).InternalField_1246 == 0)
                    {
                        continue;
                    }

                    ref InternalType_297 InternalVar_3 = ref InternalField_962.InternalMethod_1007(ref InternalVar_2);
                    if (!InternalVar_3.InternalField_1179.InternalProperty_779)
                    {
                        continue;
                    }


                    InternalType_101 InternalVar_4 = InternalMethod_1320(InternalVar_2.InternalField_806);

                    for (int InternalVar_5 = InternalVar_1 + 1; InternalVar_5 < InternalField_954.Length; ++InternalVar_5)
                    {
                        ref InternalType_19 InternalVar_6 = ref InternalField_954.ElementAt(InternalVar_5);
                        if (InternalField_965.InternalMethod_1007(ref InternalVar_6).InternalField_1246 == 0)
                        {
                            continue;
                        }

                        ref InternalType_297 InternalVar_7 = ref InternalField_962.InternalMethod_1007(ref InternalVar_6);
                        if (!InternalVar_7.InternalField_1179.InternalProperty_779)
                        {
                            continue;
                        }

                        if (InternalVar_7.InternalField_1179.InternalField_1174 > InternalVar_3.InternalField_1179.InternalField_1173 &&
                            !InternalType_187.InternalMethod_922(InternalVar_7.InternalField_1179.InternalField_1174, InternalVar_3.InternalField_1179.InternalField_1173))
                        {
                            break;
                        }

                        InternalType_101 InternalVar_8 = InternalMethod_1320(InternalVar_6.InternalField_806);
                        if (InternalVar_8.InternalField_317 != InternalVar_4.InternalField_317)
                        {
                            continue;
                        }

                        if (!InternalVar_3.InternalField_985.InternalMethod_1374(ref InternalVar_7.InternalField_985))
                        {
                            continue;
                        }


                        InternalMethod_1315(ref InternalVar_3.InternalField_1177, ref InternalVar_7.InternalField_1177, out bool InternalVar_9, out bool InternalVar_10);
                        if (!InternalVar_9)
                        {
                            continue;
                        }

                        if (InternalVar_3.InternalField_1177.InternalField_948 == InternalVar_7.InternalField_1177.InternalField_948)
                        {
                            if (InternalVar_4.InternalField_316 != InternalVar_8.InternalField_316)
                            {
                                InternalVar_10 = InternalVar_4.InternalField_316 > InternalVar_8.InternalField_316;
                            }
                            else
                            {
                                InternalType_408 InternalVar_11 = InternalField_964[InternalVar_2.InternalField_806];
                                InternalType_408 InternalVar_12 = InternalField_964[InternalVar_6.InternalField_806];

                                if (InternalVar_11.InternalField_1555 == InternalVar_12.InternalField_1555)
                                {
                                    InternalVar_10 = InternalVar_11.InternalField_1556 > InternalVar_12.InternalField_1556;
                                }
                            }

                            if (InternalVar_3.InternalField_1176 && InternalVar_7.InternalField_1176)
                            {
                                InternalVar_10 = !InternalVar_10;
                            }
                        }

                        if (InternalVar_10)
                        {
                            InternalField_958.InternalMethod_3326(InternalVar_2, InternalVar_6);
                        }
                        else
                        {
                            InternalField_958.InternalMethod_3326(InternalVar_6, InternalVar_2);
                        }
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private InternalType_101 InternalMethod_1320(InternalType_131 InternalParameter_1391)
            {
                if (InternalField_966.TryGetValue(InternalParameter_1391, out InternalType_101 InternalVar_1))
                {
                    return InternalVar_1;
                }
                else
                {
                    return InternalType_101.InternalField_318;
                }
            }

            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static void InternalMethod_1315(ref InternalType_292 InternalParameter_1390, ref InternalType_292 InternalParameter_1389, out bool InternalParameter_1388, out bool InternalParameter_1387)
            {
                InternalType_290 InternalVar_2 = InternalParameter_1390.InternalMethod_1304(ref InternalParameter_1389.InternalField_947, out float3x4 InternalVar_1);

                if (InternalVar_2.InternalProperty_300)
                {
                    float InternalVar_3 = InternalType_187.InternalMethod_948(ref InternalVar_1);
                    float InternalVar_4 = InternalType_187.InternalMethod_948(ref InternalParameter_1389.InternalField_947);
                    InternalParameter_1388 = true;
                    InternalParameter_1387 = InternalVar_3 < InternalVar_4;
                    return;
                }

                if (InternalVar_2.InternalProperty_301)
                {
                    InternalParameter_1388 = true;
                    InternalMethod_1314(ref InternalVar_2, ref InternalParameter_1389, ref InternalVar_1, out float InternalVar_3, out float InternalVar_4);
                    InternalParameter_1387 = InternalVar_4 < InternalVar_3;
                    return;
                }

                InternalType_290 InternalVar_6 = InternalParameter_1389.InternalMethod_1304(ref InternalParameter_1390.InternalField_947, out float3x4 InternalVar_5);
                if (InternalVar_6.InternalProperty_300)
                {
                    float InternalVar_7 = InternalType_187.InternalMethod_948(ref InternalParameter_1390.InternalField_947);
                    float InternalVar_8 = InternalType_187.InternalMethod_948(ref InternalVar_5);
                    InternalParameter_1388 = true;
                    InternalParameter_1387 = InternalVar_7 < InternalVar_8;
                    return;
                }

                if (InternalVar_6.InternalProperty_301)
                {
                    InternalParameter_1388 = true;
                    InternalMethod_1314(ref InternalVar_6, ref InternalParameter_1390, ref InternalVar_5, out float InternalVar_7, out float InternalVar_8);
                    InternalParameter_1387 = InternalVar_7 < InternalVar_8;
                    return;
                }

                float3 InternalVar_9 = float3.zero;
                ref float3 InternalVar_10 = ref InternalParameter_1390.InternalField_947[0];
                ref float3 InternalVar_11 = ref InternalParameter_1390.InternalField_947[2];
                float3 InternalVar_12 = default;
                float3 InternalVar_13 = default;

                if (InternalType_187.InternalMethod_910(ref InternalVar_10, ref InternalVar_11, ref InternalVar_1[0], ref InternalVar_1[2], out InternalVar_12) &&
                    InternalParameter_1389.InternalField_948.InternalMethod_1316(ref InternalVar_9, ref InternalVar_12, out InternalVar_13))
                {
                    InternalParameter_1388 = true;
                    InternalParameter_1387 = InternalVar_12.InternalMethod_942(ref InternalVar_13);
                    return;
                }

                if (InternalType_187.InternalMethod_910(ref InternalVar_10, ref InternalVar_11, ref InternalVar_1[1], ref InternalVar_1[3], out InternalVar_12) &&
                    InternalParameter_1389.InternalField_948.InternalMethod_1316(ref InternalVar_9, ref InternalVar_12, out InternalVar_13))
                {
                    InternalParameter_1388 = true;
                    InternalParameter_1387 = InternalVar_12.InternalMethod_942(ref InternalVar_13);
                    return;
                }

                ref float3 InternalVar_14 = ref InternalParameter_1390.InternalField_947[1];
                ref float3 InternalVar_15 = ref InternalParameter_1390.InternalField_947[3];
                if (InternalType_187.InternalMethod_910(ref InternalVar_14, ref InternalVar_15, ref InternalVar_1[0], ref InternalVar_1[2], out InternalVar_12) &&
                    InternalParameter_1389.InternalField_948.InternalMethod_1316(ref InternalVar_9, ref InternalVar_12, out InternalVar_13))
                {
                    InternalParameter_1388 = true;
                    InternalParameter_1387 = InternalVar_12.InternalMethod_942(ref InternalVar_13);
                    return;
                }
                if (InternalType_187.InternalMethod_910(ref InternalVar_14, ref InternalVar_15, ref InternalVar_1[1], ref InternalVar_1[3], out InternalVar_12) &&
                    InternalParameter_1389.InternalField_948.InternalMethod_1316(ref InternalVar_9, ref InternalVar_12, out InternalVar_13))
                {
                    InternalParameter_1388 = true;
                    InternalParameter_1387 = InternalVar_12.InternalMethod_942(ref InternalVar_13);
                    return;
                }

                InternalParameter_1388 = false;
                InternalParameter_1387 = default;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static void InternalMethod_1314(ref InternalType_290 InternalParameter_1384, ref InternalType_292 InternalParameter_1383, ref float3x4 InternalParameter_1382, out float InternalParameter_1381, out float InternalParameter_1380)
            {
                InternalParameter_1381 = 0;
                InternalParameter_1380 = 0;

                for (int InternalVar_1 = 0; InternalVar_1 < 4; ++InternalVar_1)
                {
                    if (InternalParameter_1384[InternalVar_1] != InternalType_267.InternalField_939)
                    {
                        continue;
                    }

                    InternalParameter_1381 += math.lengthsq(InternalParameter_1383.InternalField_947[InternalVar_1]);
                    InternalParameter_1380 += math.lengthsq(InternalParameter_1382[InternalVar_1]);
                }
            }

            private void InternalMethod_1312()
            {
                InternalField_954.InternalMethod_1021(ref InternalField_959);

                InternalField_954.Sort(new InternalType_294()
                {
                    InternalField_953 = InternalField_962,
                });
            }

            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private void InternalMethod_1311(InternalType_131 InternalParameter_1379)
            {
                if (!InternalField_965.TryGetValue(InternalParameter_1379, out InternalType_162<InternalType_304, InternalType_356> InternalVar_1))
                {
                    return;
                }

                InternalType_162<InternalType_304, InternalType_297> InternalVar_2 = InternalField_962.InternalMethod_1297(InternalParameter_1379, InternalVar_1.InternalProperty_216);
                InternalType_162<InternalType_304, InternalType_356> InternalVar_3 = InternalField_965[InternalParameter_1379];

                for (int InternalVar_4 = 0; InternalVar_4 < InternalVar_1.InternalProperty_216; ++InternalVar_4)
                {
                    if (InternalVar_3.InternalMethod_758(InternalVar_4).InternalField_1246 == 0)
                    {
                        continue;
                    }

                    InternalField_959.Add(new InternalType_19()
                    {
                        InternalField_806 = InternalParameter_1379,
                        InternalField_795 = InternalVar_4
                    });

                    ref InternalType_356 InternalVar_5 = ref InternalVar_1.InternalMethod_758(InternalVar_4);
                    InternalType_133 InternalVar_6 = InternalField_1243[InternalVar_5.InternalField_577];

                    ref float4x4 InternalVar_7 = ref InternalField_2168.ElementAt(InternalVar_6);
                    ref float4x4 InternalVar_8 = ref InternalField_1242.ElementAt(InternalVar_6);

                    float4x4 InternalVar_9 = math.mul(InternalField_1132.InternalField_1255, InternalVar_7);
                    float4x4 InternalVar_10 = math.mul(InternalVar_9, InternalVar_5.InternalField_1244.InternalMethod_1368());
                    float4 InternalVar_11 = InternalVar_10.InternalMethod_897(2);

                    ref InternalType_297 InternalVar_12 = ref InternalVar_2.InternalMethod_758(InternalVar_4);
                    if (math.all(InternalVar_11 < float4.zero))
                    {
                        InternalVar_12.InternalField_1179 = InternalType_296.InternalField_1171;
                        continue;
                    }

                    InternalType_293 InternalVar_13 = InternalType_293.InternalMethod_1319(ref InternalVar_9);

                    InternalVar_12.InternalField_1245 = InternalType_306.InternalMethod_1377(ref InternalVar_7, ref InternalVar_5.InternalField_1244).InternalMethod_1363();

                    InternalVar_12.InternalField_1177 = new InternalType_292(ref InternalVar_10, ref InternalVar_13);

                    InternalVar_10.c0.z = -InternalVar_10.c0.z;
                    InternalVar_10.c1.z = -InternalVar_10.c1.z;
                    InternalVar_10.c2.z = -InternalVar_10.c2.z;
                    InternalVar_10.c3.z = -InternalVar_10.c3.z;

                    float4x4 InternalVar_14 = math.mul(InternalField_1132.InternalField_1637, InternalVar_10);
                    InternalVar_14.c0 /= InternalVar_14.c0.w;
                    InternalVar_14.c1 /= InternalVar_14.c1.w;
                    InternalVar_14.c2 /= InternalVar_14.c2.w;
                    InternalVar_14.c3 /= InternalVar_14.c3.w;
                    InternalVar_12.InternalField_985 = new InternalType_306(ref InternalVar_14);


                    float3 InternalVar_15 = InternalType_187.InternalMethod_944(ref InternalVar_8, ref InternalField_1132.InternalField_1254, float3.zero);
                    InternalVar_12.InternalField_1176 = InternalVar_15.z > 0f;

                    InternalVar_12.InternalField_1179 = InternalField_1132.InternalMethod_1548(ref InternalVar_12.InternalField_1177);
                }

                InternalField_962[InternalParameter_1379] = InternalVar_2;
            }

            private struct InternalType_294 : IComparer<InternalType_19>
            {
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NovaHashMap<InternalType_131, InternalType_162<InternalType_304, InternalType_297>> InternalField_953;

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public int Compare(InternalType_19 x, InternalType_19 y)
                {
                    ref InternalType_296 InternalVar_1 = ref InternalField_953.InternalMethod_1007(ref x).InternalField_1179;
                    ref InternalType_296 InternalVar_2 = ref InternalField_953.InternalMethod_1007(ref y).InternalField_1179;
                    return (int)math.sign(InternalVar_1.InternalField_1174 - InternalVar_2.InternalField_1174);
                }
            }

            [BurstCompile]
            [MonoPInvokeCallback(typeof(InternalType_175))]
            public static unsafe void InternalMethod_1310(void* InternalParameter_1378)
            {
                UnsafeUtility.AsRef<InternalType_295>(InternalParameter_1378).InternalMethod_1324();
            }

            #region Public
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_162<InternalType_305, InternalType_361> InternalMethod_1309(InternalType_131 InternalParameter_1377) => InternalField_963[InternalParameter_1377];

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void InternalMethod_1308(InternalType_131 InternalParameter_1376)
            {
                InternalField_963.Add(InternalParameter_1376, InternalField_961.InternalMethod_1026());
                InternalField_962.Add(InternalParameter_1376, InternalField_960.InternalMethod_1026());
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void InternalMethod_1306(InternalType_131 InternalParameter_1373)
            {
                if (InternalField_963.InternalMethod_3110(InternalParameter_1373, out InternalType_162<InternalType_305, InternalType_361> InternalVar_1))
                {
                    InternalField_961.InternalMethod_1027(ref InternalVar_1);
                }

                if (InternalField_962.InternalMethod_3110(InternalParameter_1373, out InternalType_162<InternalType_304, InternalType_297> InternalVar_2))
                {
                    InternalField_960.InternalMethod_1027(ref InternalVar_2);
                }
            }

            public void InternalMethod_702()
            {
                InternalField_968.InternalMethod_1020();
                InternalField_963.Init();
                InternalField_962.Init();

                InternalField_961.InternalMethod_1020();
                InternalField_960.InternalMethod_1020();

                InternalField_959.InternalMethod_1020();
                InternalField_958.InternalMethod_702();
                InternalField_957.InternalMethod_1020();
                InternalField_956.Init();
                InternalField_955.Init();

                InternalField_954.InternalMethod_1020();
            }

            public void Dispose()
            {
                InternalField_968.Dispose();
                InternalField_963.Dispose();
                InternalField_962.Dispose();

                InternalField_961.InternalMethod_1022();
                InternalField_960.InternalMethod_1022();

                InternalField_959.Dispose();
                InternalField_958.Dispose();
                InternalField_957.Dispose();
                InternalField_956.Dispose();
                InternalField_955.Dispose();

                InternalField_954.Dispose();
            }
            #endregion
        }
    }
}

