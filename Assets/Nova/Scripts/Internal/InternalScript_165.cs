using AOT;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_318 : IDisposable
    {
        public struct InternalType_319
        {
            
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        public InternalType_310 InternalField_1073;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly InternalType_319 InternalField_1074 = new InternalType_319()
            {
                InternalField_1073 = InternalType_310.InternalField_1023,
            };
        }

        private struct InternalType_320 : IEquatable<InternalType_310>
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_310 InternalField_1075;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_1076;

            public bool Equals(InternalType_310 other) => InternalField_1075.Equals(other);

            public override string ToString()
            {
                return InternalField_1076.ToString();
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeReference<InternalType_103> InternalField_1065;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_311 InternalField_1066;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_315 InternalField_1067;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_1068;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeReference<InternalType_319> InternalField_1069;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_282> InternalField_1070;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_282> InternalField_1071;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_320> InternalField_1072;

        private void InternalMethod_1429()
        {
            InternalField_1069.Value = InternalType_319.InternalField_1074;

            ref InternalType_103 InternalVar_1 = ref InternalField_1065.InternalMethod_1030();

            if (!InternalField_1066.InternalField_1025.InternalProperty_307)
            {
                InternalMethod_1433(ref InternalVar_1);
                return;
            }

            if (!InternalField_1067.InternalField_1044.TryGetValue(InternalField_1066.InternalField_1025, out InternalType_315.InternalType_316 InternalVar_2))
            {
                InternalVar_2 = default;
            }

            bool InternalVar_3 = true;
            if (InternalMethod_1435(ref InternalVar_1, out InternalType_311 InternalVar_4))
            {
                if (InternalVar_4.Equals(InternalField_1066))
                {
                    return;
                }

                InternalVar_2.InternalField_1060 += 1;
                InternalVar_3 = false;
                InternalField_1067.InternalField_1044[InternalField_1066.InternalField_1025] = InternalVar_2;
                InternalMethod_1433(ref InternalVar_1);
            }

            InternalVar_1 = InternalField_1067.InternalMethod_1424();
            InternalField_1067.InternalField_1042.Add(InternalVar_1, InternalField_1066);

            if (InternalVar_3)
            {
                InternalVar_2.InternalField_1060 += 1;
                InternalField_1067.InternalField_1044[InternalField_1066.InternalField_1025] = InternalVar_2;
            }

            if (InternalMethod_1434(ref InternalField_1066))
            {
                InternalMethod_1430(InternalField_1066.InternalField_1025, 1);
            }
        }

        private void InternalMethod_1430(InternalType_310 InternalParameter_1518, int InternalParameter_1519)
        {
            if (InternalField_1072.InternalMethod_1011(InternalParameter_1518, out int InternalVar_1))
            {
                ref InternalType_320 InternalVar_2 = ref InternalField_1072.ElementAt(InternalVar_1);
                InternalVar_2.InternalField_1076 += InternalParameter_1519;


                if (InternalVar_2.InternalField_1076 == 0)
                {
                    InternalField_1072.RemoveAtSwapBack(InternalVar_1);
                }
            }
            else
            {
                InternalField_1072.Add(new InternalType_320()
                {
                    InternalField_1075 = InternalParameter_1518,
                    InternalField_1076 = InternalParameter_1519
                });
            }
        }

        private void InternalMethod_1431(ref InternalType_321 InternalParameter_1520, out InternalType_282 InternalParameter_1521, out InternalType_313 InternalParameter_1522)
        {
            InternalParameter_1521 = InternalField_1067.InternalMethod_1425();
            InternalParameter_1522 = InternalField_1067.InternalField_1051.InternalMethod_1024();
            InternalField_1067.InternalMethod_1426(InternalParameter_1520.InternalField_1079, out InternalParameter_1522.InternalField_1039);
            InternalParameter_1522.InternalField_1038 = InternalParameter_1520;
            InternalField_1067.InternalField_1046[InternalParameter_1521] = 0;
            InternalField_1067.InternalField_1050.Add(InternalParameter_1520, InternalParameter_1521);
        }

        private void InternalMethod_1432()
        {
            InternalField_1069.Value = InternalType_319.InternalField_1074;
            ref InternalType_103 InternalVar_1 = ref InternalField_1065.InternalMethod_1030();
            InternalMethod_1433(ref InternalVar_1);
        }

        private void InternalMethod_1433(ref InternalType_103 InternalParameter_1523)
        {
            if (!InternalMethod_1435(ref InternalParameter_1523, out InternalType_311 InternalVar_1))
            {
                return;
            }

            InternalField_1067.InternalField_1042.Remove(InternalParameter_1523);
            InternalParameter_1523 = InternalNamespace_0.InternalType_103.InternalField_322;

            if (!InternalField_1067.InternalField_1044.TryGetValue(InternalVar_1.InternalField_1025, out InternalType_315.InternalType_316 InternalVar_2))
            {
                Debug.LogError("Failed to get ref counts for texture");
                return;
            }

            InternalVar_2.InternalField_1060 -= 1;
            if (InternalMethod_1434(ref InternalVar_1))
            {
                InternalMethod_1430(InternalVar_1.InternalField_1025, -1);
            }

            InternalField_1067.InternalField_1044[InternalVar_1.InternalField_1025] = InternalVar_2;

            if (InternalVar_2.InternalField_1060 > 0)
            {
                return;
            }

            InternalField_1069.InternalMethod_1030().InternalField_1073 = InternalVar_1.InternalField_1025;
        }

        private bool InternalMethod_1434(ref InternalType_311 InternalParameter_1524)
        {
            if (InternalParameter_1524.InternalField_1026 == InternalType_695.InternalField_2939 || !InternalType_24.InternalProperty_945.InternalField_3088)
            {
                return false;
            }

            if (!InternalField_1067.InternalProperty_957)
            {
                return false;
            }

            if (!InternalField_1067.InternalField_1043[InternalParameter_1524.InternalField_1025].InternalField_1080)
            {
                return false;
            }

            if (InternalField_1068)
            {
                return true;
            }

            if (!InternalField_1067.InternalField_1043.TryGetValue(InternalParameter_1524.InternalField_1025, out InternalType_321 InternalVar_1) ||
                !InternalField_1067.InternalMethod_1426(InternalVar_1.InternalField_1079, out InternalType_317 InternalVar_2))
            {
                return false;
            }

            if (!InternalVar_2.InternalField_1062 && InternalType_24.InternalProperty_945.InternalMethod_554(InternalType_116.InternalField_2767))
            {
                Debug.LogWarning($"Platform does not support texture format. {InternalType_178.InternalField_484}");
            }
            return InternalVar_2.InternalField_1062;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool InternalMethod_1435(ref InternalType_103 InternalParameter_1525, out InternalType_311 InternalParameter_1526)
        {
            if (!InternalParameter_1525.InternalProperty_185)
            {
                InternalParameter_1526 = default;
                return false;
            }

            bool InternalVar_1 = InternalField_1067.InternalField_1042.TryGetValue(InternalParameter_1525, out InternalParameter_1526);
            if (!InternalVar_1)
            {
                Debug.LogError("Failed to get image descriptor for image");
            }
            return InternalVar_1;
        }

        private void InternalMethod_1436(InternalType_282 InternalParameter_1527, ref InternalType_313 InternalParameter_1528)
        {
            InternalField_1070.Add(InternalParameter_1527);
            InternalField_1067.InternalField_1050.Remove(InternalParameter_1528.InternalField_1038);

            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_1528.InternalField_1034.InternalProperty_216; ++InternalVar_1)
            {
                InternalType_310 InternalVar_2 = InternalParameter_1528.InternalField_1034[InternalVar_1];
                InternalField_1067.InternalField_1047.Remove(InternalVar_2);

                InternalField_1067.InternalField_1045.Remove(InternalVar_2);
            }

            InternalField_1067.InternalField_1046.Remove(InternalParameter_1527);
            InternalField_1067.InternalField_1049.Remove(InternalParameter_1527);
            InternalField_1067.InternalField_1051.InternalMethod_1027(ref InternalParameter_1528);
        }

        private void InternalMethod_1437()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1072.Length; ++InternalVar_1)
            {
                ref InternalType_320 InternalVar_2 = ref InternalField_1072.ElementAt(InternalVar_1);
                if (InternalVar_2.InternalField_1076 >= 0)
                {
                    continue;
                }

                bool InternalVar_3 = false;
                if (InternalField_1067.InternalField_1044.TryGetValue(InternalVar_2.InternalField_1075, out InternalType_315.InternalType_316 InternalVar_4))
                {
                    InternalVar_4.InternalField_1059 += InternalVar_2.InternalField_1076;
                    InternalField_1067.InternalField_1044[InternalVar_2.InternalField_1075] = InternalVar_4;
                    InternalVar_3 = InternalVar_4.InternalField_1059 == 0;
                }
                else
                {
                    InternalVar_3 = InternalField_1067.InternalField_1045.ContainsKey(InternalVar_2.InternalField_1075);
                }

                if (!InternalVar_3)
                {
                    continue;
                }

                if (!InternalField_1067.InternalField_1045.InternalMethod_3110(InternalVar_2.InternalField_1075, out InternalType_282 InternalVar_5))
                {
                    Debug.LogError("Failed to get TexturePack ID");
                    return;
                }


                if (!InternalField_1067.InternalField_1049.TryGetValue(InternalVar_5, out InternalType_313 InternalVar_6))
                {
                    Debug.LogError("Failed to get TexturePack");
                    return;
                }

                InternalField_1067.InternalField_1047.Remove(InternalVar_2.InternalField_1075);
                InternalVar_6.InternalMethod_1420(InternalVar_2.InternalField_1075);
                InternalField_1067.InternalField_1046[InternalVar_5] = InternalVar_6.InternalProperty_310;
                InternalField_1067.InternalField_1049[InternalVar_5] = InternalVar_6;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1072.Length; ++InternalVar_1)
            {
                ref InternalType_320 InternalVar_2 = ref InternalField_1072.ElementAt(InternalVar_1);
                if (InternalVar_2.InternalField_1076 <= 0)
                {
                    continue;
                }

                if (!InternalField_1067.InternalField_1044.TryGetValue(InternalVar_2.InternalField_1075, out InternalType_315.InternalType_316 InternalVar_3))
                {
                    Debug.LogError("Missing ref count for texture");
                    continue;
                }

                int InternalVar_4 = InternalVar_3.InternalField_1059;
                InternalVar_3.InternalField_1059 += InternalVar_2.InternalField_1076;
                InternalField_1067.InternalField_1044[InternalVar_2.InternalField_1075] = InternalVar_3;
                if (InternalVar_4 > 0)
                {
                    continue;
                }

                InternalMethod_1438(InternalVar_2.InternalField_1075);
            }

            InternalField_1072.Clear();
        }

        private void InternalMethod_1438(InternalType_310 InternalParameter_1529)
        {
            InternalType_321 InternalVar_1 = InternalField_1067.InternalField_1043[InternalParameter_1529];

            InternalType_313 InternalVar_2 = default;
            if (InternalField_1067.InternalField_1050.TryGetValue(InternalVar_1, out InternalType_282 InternalVar_3))
            {
                if (!InternalField_1067.InternalField_1049.TryGetValue(InternalVar_3, out InternalVar_2))
                {
                    Debug.LogError("Failed to get TexturePack for pack ID");
                    return;
                }
            }
            else
            {
                InternalMethod_1431(ref InternalVar_1, out InternalVar_3, out InternalVar_2);
            }

            InternalType_314 InternalVar_4 = InternalVar_2.InternalMethod_1419(InternalParameter_1529);
            InternalField_1067.InternalField_1047.Add(InternalParameter_1529, InternalVar_4);


            InternalField_1067.InternalField_1045.Add(InternalParameter_1529, InternalVar_3);
            InternalField_1067.InternalField_1046[InternalVar_3] = InternalVar_2.InternalProperty_310;
            InternalField_1067.InternalField_1049[InternalVar_3] = InternalVar_2;
        }

        private void InternalMethod_1439()
        {
            InternalField_1070.Clear();
            InternalField_1071.Clear();

            InternalMethod_1437();

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1067.InternalField_1048.Length; ++InternalVar_1)
            {
                InternalType_282 InternalVar_2 = InternalField_1067.InternalField_1048[InternalVar_1];
                if (!InternalField_1067.InternalField_1049.TryGetValue(InternalVar_2, out InternalType_313 InternalVar_3))
                {
                    Debug.LogError("PackID not found");
                    continue;
                }

                if (InternalVar_3.InternalProperty_310 < 1)
                {
                    InternalMethod_1436(InternalVar_2, ref InternalVar_3);
                    InternalField_1067.InternalField_1048.RemoveAtSwapBack(InternalVar_1--);
                    continue;
                }

                if (InternalVar_3.InternalProperty_309)
                {
                    InternalField_1071.Add(InternalVar_2);
                }

                InternalField_1067.InternalField_1049[InternalVar_2] = InternalVar_3;
            }
        }

        private void InternalMethod_1440()
        {
            InternalField_1072.Clear();
            InternalField_1070.Clear();
            InternalField_1071.Clear();

            while (InternalField_1067.InternalField_1048.Length != 0)
            {
                InternalType_282 InternalVar_1 = InternalField_1067.InternalField_1048[0];
                if (!InternalField_1067.InternalField_1049.TryGetValue(InternalVar_1, out InternalType_313 InternalVar_2))
                {
                    Debug.LogError("PackID not found");
                    continue;
                }

                InternalMethod_1436(InternalVar_1, ref InternalVar_2);
                InternalField_1067.InternalField_1048.RemoveAtSwapBack(0);
            }

            using var InternalVar_3 = InternalField_1067.InternalField_1042.GetKeyArray(Allocator.Temp);
            for (int InternalVar_4 = 0; InternalVar_4 < InternalVar_3.Length; ++InternalVar_4)
            {
                InternalType_103 InternalVar_5 = InternalVar_3[InternalVar_4];
                InternalType_311 InternalVar_6 = InternalField_1067.InternalField_1042[InternalVar_5];
                if (!InternalField_1067.InternalField_1044.TryGetValue(InternalVar_6.InternalField_1025, out InternalType_315.InternalType_316 InternalVar_7))
                {
                    Debug.LogError("Failed to get ref counts for texture");
                    continue;
                }

                InternalVar_7.InternalField_1059 -= 1;
                InternalField_1067.InternalField_1044[InternalVar_6.InternalField_1025] = InternalVar_7;
            }
        }

        private void InternalMethod_1441()
        {
            InternalField_1072.Clear();
            InternalField_1070.Clear();
            InternalField_1071.Clear();

            using var InternalVar_1 = InternalField_1067.InternalField_1042.GetKeyArray(Allocator.Temp);

            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1.Length; ++InternalVar_2)
            {
                InternalType_103 InternalVar_3 = InternalVar_1[InternalVar_2];
                InternalType_311 InternalVar_4 = InternalField_1067.InternalField_1042[InternalVar_3];

                if (!InternalMethod_1434(ref InternalVar_4))
                {
                    continue;
                }

                if (!InternalField_1067.InternalField_1044.TryGetValue(InternalVar_4.InternalField_1025, out InternalType_315.InternalType_316 InternalVar_5))
                {
                    Debug.LogError("Failed to get ref counts for texture");
                    continue;
                }

                InternalVar_5.InternalField_1059 += 1;
                InternalField_1067.InternalField_1044[InternalVar_4.InternalField_1025] = InternalVar_5;

                if (InternalVar_5.InternalField_1059 > 1)
                {
                    continue;
                }

                InternalMethod_1438(InternalVar_4.InternalField_1025);
            }

            InternalMethod_1439();
        }

        public InternalType_318(ref InternalType_315 InternalParameter_1530, bool InternalParameter_1531)
        {
            InternalField_1068 = InternalParameter_1531;
            InternalField_1067 = InternalParameter_1530;
            InternalField_1065 = default;
            InternalField_1069 = default;
            InternalField_1066 = default;
            InternalField_1070 = default;
            InternalField_1071 = default;
            InternalField_1072 = default;

            InternalField_1065.InternalMethod_1032();
            InternalField_1069.InternalMethod_1032();
            InternalField_1070.InternalMethod_1020();
            InternalField_1071.InternalMethod_1020();
            InternalField_1072.InternalMethod_1020();
        }

        public void Dispose()
        {
            InternalField_1065.Dispose();
            InternalField_1069.Dispose();
            InternalField_1070.Dispose();
            InternalField_1071.Dispose();
            InternalField_1072.Dispose();
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_1443(void* InternalParameter_1532)
        {
            UnsafeUtility.AsRef<InternalType_318>(InternalParameter_1532).InternalMethod_1429();
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_1444(void* InternalParameter_1533)
        {
            UnsafeUtility.AsRef<InternalType_318>(InternalParameter_1533).InternalMethod_1432();
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_1445(void* InternalParameter_1534)
        {
            UnsafeUtility.AsRef<InternalType_318>(InternalParameter_1534).InternalMethod_1439();
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_1446(void* InternalParameter_1535)
        {
            UnsafeUtility.AsRef<InternalType_318>(InternalParameter_1535).InternalMethod_1440();
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_1447(void* InternalParameter_1536)
        {
            UnsafeUtility.AsRef<InternalType_318>(InternalParameter_1536).InternalMethod_1441();
        }
    }
}

