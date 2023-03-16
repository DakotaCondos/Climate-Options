using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal static class InternalType_325
    {
        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private const string InternalField_1103 = "NOVA_CLIP_RECT";
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const string InternalField_1104 = "NOVA_CLIP_MASK";
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const string InternalField_1106 = "NOVA_DYNAMIC_IMAGE";
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const string InternalField_1107 = "NOVA_STATIC_IMAGE";
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const string InternalField_1108 = "NOVA_INNER_SHADOW";
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const string InternalField_1109 = "NOVA_SUPER_SAMPLE";
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const string InternalField_1110 = "NOVA_OUTER_BORDER";
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const string InternalField_1111 = "NOVA_INNER_BORDER";
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const string InternalField_1112 = "NOVA_CENTER_BORDER";
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const string InternalField_3417 = "NOVA_RADIAL_FILL";
        #endregion

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private static List<Material> InternalField_1113 = new List<Material>(InternalType_178.InternalField_3012);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static List<Shader> InternalField_1114 = new List<Shader>(InternalType_178.InternalField_3012);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static List<InternalType_172<InternalType_327, InternalType_324>> InternalField_1115 = new List<InternalType_172<InternalType_327, InternalType_324>>(InternalType_178.InternalField_3012);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static List<InternalType_323> InternalField_1116 = new List<InternalType_323>(InternalType_178.InternalField_3012);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static NovaHashMap<InternalType_324, InternalType_326> InternalField_1117;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static NovaHashMap<InternalType_323, InternalType_327> InternalField_1118;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static NativeList<InternalType_172<InternalType_327, InternalType_324>> InternalField_1119;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static NativeList<InternalType_323> InternalField_1120;

        public static Material InternalMethod_1450(InternalType_326 InternalParameter_1538)
        {
            Material InternalVar_1 = InternalField_1113[InternalParameter_1538];
            if (InternalVar_1 == null)
            {
                InternalType_172<InternalType_327, InternalType_324> InternalVar_2 = InternalField_1115[InternalParameter_1538];
                InternalVar_1 = InternalMethod_1455(InternalVar_2.InternalField_462, ref InternalVar_2.InternalField_463);
                InternalField_1113[InternalParameter_1538] = InternalVar_1;
            }
            return InternalVar_1;
        }

        private static Shader InternalMethod_1451(InternalType_327 InternalParameter_1539)
        {
            Shader InternalVar_1 = InternalField_1114[InternalParameter_1539];
            if (InternalVar_1 == null)
            {
                InternalType_323 InternalVar_2 = InternalField_1116[InternalParameter_1539];
                InternalVar_1 = InternalMethod_1460(ref InternalVar_2);
                InternalField_1114[InternalParameter_1539] = InternalVar_1;
            }
            return InternalVar_1;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static InternalType_326 InternalProperty_314
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1113.Count;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static InternalType_327 InternalProperty_315
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1114.Count;
        }

        public static void InternalMethod_1454()
        {
            InternalMethod_1458();

            if (InternalField_1119.Length == 0)
            {
                return;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1119.Length; ++InternalVar_1)
            {
                ref InternalType_172<InternalType_327, InternalType_324> InternalVar_2 = ref InternalField_1119.ElementAt(InternalVar_1);
                Material InternalVar_3 = InternalMethod_1455(InternalVar_2.InternalField_462, ref InternalVar_2.InternalField_463);
                InternalField_1117.Add(InternalVar_2.InternalField_463, InternalField_1113.Count);
                InternalField_1113.Add(InternalVar_3);
                InternalField_1115.Add(InternalVar_2);
            }

            InternalField_1119.Clear();
        }

        private static Material InternalMethod_1455(InternalType_327 InternalParameter_1540, ref InternalType_324 InternalParameter_1541)
        {
            Material InternalVar_1 = null;
            if (!InternalParameter_1541.InternalField_2244.InternalProperty_731)
            {
                InternalVar_1 = new Material(InternalMethod_1451(InternalParameter_1540));
                InternalVar_1.hideFlags = HideFlags.DontSaveInEditor;
            }
            else if (InternalType_274.InternalProperty_190.InternalField_875.TryGetValue(InternalParameter_1541.InternalField_1102, out Material InternalVar_2))
            {
                InternalMethod_1462(InternalVar_2, InternalParameter_1541.InternalField_1102);
                InternalVar_1 = new Material(InternalVar_2);
                InternalVar_1.hideFlags = HideFlags.DontSaveInEditor;
                InternalVar_1.shader = InternalMethod_1451(InternalParameter_1540);
            }
            else
            {
                Debug.LogError("Failed to get font material");
                InternalVar_1 = new Material(InternalMethod_1451(InternalParameter_1540));
                InternalVar_1.hideFlags = HideFlags.DontSaveInEditor;
            }

            InternalMethod_1456(InternalVar_1, ref InternalParameter_1541);
            return InternalVar_1;
        }

        private enum InternalType_173 : int
        {
            InternalField_490 = 0,
            InternalField_489 = 1,
            InternalField_493 = 2,
            InternalField_492 = 3,
            InternalField_1031 = 4,
            InternalField_818 = 5,
            InternalField_1231 = 6,
            InternalField_1897 = 7,
            InternalField_296 = 8
        }

        private static void InternalMethod_1456(Material InternalParameter_1542, ref InternalType_324 InternalParameter_1543)
        {
            if (InternalParameter_1543.InternalField_2244.InternalField_1096 == InternalType_281.InternalField_920)
            {
                InternalParameter_1542.SetOverrideTag("RenderType", "Opaque");
                InternalParameter_1542.SetInt(InternalType_331.InternalField_2508, 1);
                InternalParameter_1542.SetInt(InternalType_331.InternalField_2403, (int)BlendMode.One);
                InternalParameter_1542.SetInt(InternalType_331.InternalField_2402, (int)(BlendMode.Zero));

                InternalParameter_1542.SetInt(InternalType_331.InternalField_2336, (int)BlendMode.One);
                InternalParameter_1542.SetInt(InternalType_331.InternalField_2222, (int)BlendMode.One);
            }
            else
            {
                InternalParameter_1542.SetOverrideTag("RenderType", "Transparent");
                InternalParameter_1542.SetInt(InternalType_331.InternalField_2508, 0);
                BlendMode InternalVar_1 = InternalParameter_1543.InternalField_2244.InternalProperty_732 ? BlendMode.One : BlendMode.SrcAlpha;
                InternalParameter_1542.SetInt(InternalType_331.InternalField_2403, (int)InternalVar_1);
                InternalParameter_1542.SetInt(InternalType_331.InternalField_2402, (int)(BlendMode.OneMinusSrcAlpha));

                InternalParameter_1542.SetInt(InternalType_331.InternalField_2336, (int)InternalVar_1);
                InternalParameter_1542.SetInt(InternalType_331.InternalField_2222, (int)BlendMode.One);
            }

            InternalParameter_1542.SetInt(InternalType_331.InternalField_584, (int)(InternalParameter_1543.InternalField_583 ? InternalType_173.InternalField_490 : InternalType_173.InternalField_1031));

            if (InternalParameter_1543.InternalField_2244.InternalField_1094 == InternalType_266.InternalField_787 && !InternalParameter_1543.InternalProperty_737)
            {
                InternalParameter_1542.SetInt(InternalType_331.InternalField_2243, (int)CullMode.Back);
            }
            else
            {
                InternalParameter_1542.SetInt(InternalType_331.InternalField_2243, (int)CullMode.Off);
            }

            InternalParameter_1542.renderQueue = InternalParameter_1543.InternalField_1101;

            InternalMethod_1457(InternalParameter_1542, InternalParameter_1543.InternalField_1100, InternalType_322.InternalField_1083, InternalField_1103);
            InternalMethod_1457(InternalParameter_1542, InternalParameter_1543.InternalField_1100, InternalType_322.InternalField_1084, InternalField_1104);
            InternalMethod_1457(InternalParameter_1542, InternalParameter_1543.InternalField_1100, InternalType_322.InternalField_1086, InternalField_1106);
            InternalMethod_1457(InternalParameter_1542, InternalParameter_1543.InternalField_1100, InternalType_322.InternalField_1087, InternalField_1107);
            InternalMethod_1457(InternalParameter_1542, InternalParameter_1543.InternalField_1100, InternalType_322.InternalField_1088, InternalField_1108);
            InternalMethod_1457(InternalParameter_1542, InternalParameter_1543.InternalField_1100, InternalType_322.InternalField_1089, InternalField_1109);
            InternalMethod_1457(InternalParameter_1542, InternalParameter_1543.InternalField_1100, InternalType_322.InternalField_1090, InternalField_1110);
            InternalMethod_1457(InternalParameter_1542, InternalParameter_1543.InternalField_1100, InternalType_322.InternalField_1091, InternalField_1111);
            InternalMethod_1457(InternalParameter_1542, InternalParameter_1543.InternalField_1100, InternalType_322.InternalField_1092, InternalField_1112);
            InternalMethod_1457(InternalParameter_1542, InternalParameter_1543.InternalField_1100, InternalType_322.InternalField_3418, InternalField_3417);
            InternalParameter_1542.enableInstancing = true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1457(Material InternalParameter_1544, InternalType_322 InternalParameter_1545, InternalType_322 InternalParameter_1546, string InternalParameter_1547)
        {
            if ((InternalParameter_1545 & InternalParameter_1546) != 0)
            {
                InternalParameter_1544.EnableKeyword(InternalParameter_1547);
            }
            else
            {
                InternalParameter_1544.DisableKeyword(InternalParameter_1547);
            }
        }

        private static void InternalMethod_1458()
        {
            if (InternalField_1120.Length == 0)
            {
                return;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1120.Length; ++InternalVar_1)
            {
                ref InternalType_323 InternalVar_2 = ref InternalField_1120.ElementAt(InternalVar_1);

#pragma warning disable CS0162 
                if (NovaApplication.ConstIsEditor)
                {
                    if (InternalType_24.InternalProperty_945.InternalMethod_554(InternalType_116.InternalField_381) &&
                        !InternalType_409.InternalMethod_1925(InternalVar_2.InternalField_1094, InternalVar_2.InternalField_1095))
                    {
                        Debug.LogWarning($"{InternalVar_2.InternalField_1095.InternalMethod_1922()} lighting model being used on {InternalVar_2.InternalField_1094.InternalMethod_1921().InternalMethod_853()}, but it is not marked to be included in builds. If you wish to use this lighting model in builds, you can specify to include it in NovaSettings. {InternalType_178.InternalField_484}");
                    }
                }
                else if (!InternalType_409.InternalMethod_1925(InternalVar_2.InternalField_1094, InternalVar_2.InternalField_1095))
                {
                    Debug.LogError($"{InternalVar_2.InternalField_1095.InternalMethod_1922()} lighting model being used on {InternalVar_2.InternalField_1094.InternalMethod_1921().InternalMethod_853()}, but it was not marked to be included in builds. You can specify to include it in NovaSettings.");
                }
#pragma warning restore CS0162 

                Shader InternalVar_3 = InternalMethod_1460(ref InternalVar_2);
                if (InternalVar_3 == null)
                {
                    continue;
                }

                InternalField_1118.Add(InternalVar_2, InternalField_1114.Count);
                InternalField_1114.Add(InternalVar_3);
                InternalField_1116.Add(InternalVar_2);
            }

            InternalField_1120.Clear();
        }

        private static Shader InternalMethod_1460(ref InternalType_323 InternalParameter_1549)
        {
            string InternalVar_1 = InternalParameter_1549.InternalMethod_1926();
            Shader InternalVar_2 = Shader.Find(InternalVar_1);
            if (InternalVar_2 == null)
            {
                Debug.LogError($"Could not find shader {InternalVar_1}. Please ensure the project has been imported correctly");
            }
            return InternalVar_2;
        }

        public static bool InternalMethod_1954(int InternalParameter_741, Material InternalParameter_740)
        {
            bool InternalVar_1 = false;
            InternalType_257 InternalVar_2 = InternalType_257.InternalField_748;
            for (int InternalVar_3 = 0; InternalVar_3 < InternalField_1113.Count; InternalVar_3++)
            {
                InternalType_172<InternalType_327, InternalType_324> InternalVar_4 = InternalField_1115[InternalVar_3];
                if (InternalVar_4.InternalField_463.InternalField_1102 != InternalParameter_741)
                {
                    continue;
                }

                InternalVar_1 = true;
                Material InternalVar_5 = InternalField_1113[InternalVar_3];
                InternalVar_5.CopyPropertiesFromMaterial(InternalParameter_740);
                InternalVar_2 = InternalVar_4.InternalField_463.InternalField_1102;
                InternalMethod_1456(InternalVar_5, ref InternalVar_4.InternalField_463);
            }

            if (!InternalVar_1)
            {
                return false;
            }

            InternalMethod_1462(InternalParameter_740, InternalVar_2);
            return true;
        }

        private static void InternalMethod_1462(Material InternalParameter_1552, InternalType_257 InternalParameter_1553)
        {
            if (!InternalType_24.InternalProperty_945.InternalMethod_554(InternalType_116.InternalField_380) ||
                InternalMethod_1950(InternalParameter_1552.shader))
            {
                return;
            }

            InternalType_133 InternalVar_1 = InternalMethod_1463(InternalParameter_1553);
            GameObject InternalVar_2 = null;

            if (InternalVar_1.InternalProperty_194)
            {
                InternalType_131 InternalVar_3 = InternalType_253.InternalProperty_190.InternalProperty_259.InternalMethod_667(InternalVar_1);
                InternalVar_2 = InternalType_274.InternalProperty_190.InternalField_413[InternalVar_3].InternalProperty_202.gameObject;
            }

            Debug.LogWarning($"Unsupported text shader [{InternalParameter_1552.shader.name}] being used, Nova only supports [{InternalType_178.InternalField_479}]. {InternalType_178.InternalField_484}", InternalVar_2);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static Shader InternalField_2245 = null;

        public static Shader InternalMethod_1953()
        {
            if (InternalField_2245 != null)
            {
                return InternalField_2245;
            }

            InternalField_2245 = Shader.Find(InternalType_178.InternalField_479);
            return InternalField_2245;
        }

        public static bool InternalMethod_1950(Shader InternalParameter_550)
        {
            if (InternalField_2245 == null)
            {
                if (InternalParameter_550.name == InternalType_178.InternalField_479)
                {
                    InternalField_2245 = InternalParameter_550;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return InternalField_2245 == InternalParameter_550;
            }
        }

        private static InternalType_133 InternalMethod_1463(InternalType_257 InternalParameter_1554)
        {
            InternalType_161<InternalType_348, InternalType_79> InternalVar_1 = InternalType_274.InternalProperty_190.InternalField_865.InternalField_1193;
            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1.InternalProperty_216; ++InternalVar_2)
            {
                ref InternalType_79 InternalVar_3 = ref InternalVar_1.InternalMethod_748(InternalVar_2); ;
                for (int InternalVar_4 = 0; InternalVar_4 < InternalVar_3.InternalField_261.InternalProperty_216; ++InternalVar_4)
                {
                    if (!InternalVar_3.InternalField_261.InternalMethod_800(InternalVar_4).InternalField_354.Equals(InternalParameter_1554))
                    {
                        continue;
                    }

                    return InternalType_274.InternalProperty_190.InternalField_865.InternalField_1194[InternalVar_2];
                }
            }

            return InternalType_133.InternalField_418;
        }

        public static void InternalMethod_1467()
        {
            InternalField_1117.Init(InternalType_178.InternalField_3012);
            InternalField_1118.Init(InternalType_178.InternalField_3012);
            InternalField_1119.InternalMethod_1020(InternalType_178.InternalField_3012);
            InternalField_1120.InternalMethod_1020(InternalType_178.InternalField_3012);
        }

        public static void InternalMethod_1468()
        {
            InternalField_1117.Dispose();
            InternalField_1118.Dispose();
            InternalField_1119.Dispose();
            InternalField_1120.Dispose();

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1113.Count; ++InternalVar_1)
            {
                InternalType_179.InternalMethod_847(InternalField_1113[InternalVar_1]);
            }

            InternalField_1113.Clear();
            InternalField_1114.Clear();
            InternalField_1115.Clear();
            InternalField_1116.Clear();
        }
    }
}

