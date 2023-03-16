using Nova.Compat;
using Nova.InternalNamespace_17.InternalNamespace_20;
using Nova.InternalNamespace_17.InternalNamespace_21;
using Nova.InternalNamespace_25;
using Nova.InternalNamespace_0;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Linq;
using UnityEditor;
using UnityEngine;
using static Nova.InternalNamespace_17.InternalNamespace_20.InternalType_592;

namespace Nova.InternalNamespace_17.InternalNamespace_18
{
    internal static class InternalType_576
    {
        private static bool InternalMethod_3002(UIBlock InternalParameter_1067)
        {
            if (InternalParameter_1067.TryGetComponent(out ScreenSpace InternalVar_1) &&
                InternalVar_1.enabled &&
                InternalVar_1.Mode != ScreenSpace.FillMode.Manual)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool InternalMethod_3000(UIBlock InternalParameter_231)
        {
            if (InternalParameter_231.TryGetComponent(out ScreenSpace InternalVar_1) &&
                InternalVar_1.enabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void InternalMethod_2311(InternalType_600 InternalParameter_2682, UIBlock InternalParameter_2683, SerializedProperty InternalParameter_2684)
        {
            using (InternalType_553 foldout = InternalType_573.InternalMethod_2229("Size"))
            {
                if (!foldout)
                {
                    return;
                }

                using (new EditorGUI.IndentLevelScope(-EditorGUI.indentLevel))
                {
                    bool InternalVar_1 = InternalMethod_3002(InternalParameter_2683);

                    EditorGUI.BeginDisabledGroup(InternalVar_1);

                    InternalType_573.InternalMethod_2249(InternalParameter_2682, InternalParameter_2683, InternalType_573.InternalMethod_3332(InternalParameter_2683) ? InternalType_554.InternalField_2461 : InternalType_554.InternalField_2462);

                    if (InternalParameter_2683.Parent != null && !(InternalParameter_2683.Parent is TextBlock))
                    {
                        InternalMethod_2325(InternalParameter_2683.Parent.AutoSize, InternalParameter_2683.AutoSize, InternalParameter_2683.Size.Type);
                    }

                    ThreeD<bool> InternalVar_2 = InternalParameter_2682.InternalProperty_573 == new ThreeD<Axis>(Axis.X, Axis.Y, Axis.Z);

                    InternalType_602 InternalVar_3 = new InternalType_602() { InternalProperty_954 = InternalParameter_2682.InternalProperty_568 };
                    EditorGUI.BeginChangeCheck();
                    InternalMethod_2318(InternalVar_3, InternalVar_2, InternalType_573.InternalMethod_3332(InternalParameter_2683));
                    if (EditorGUI.EndChangeCheck())
                    {
                        ThreeD<AutoSize> InternalVar_4 = new ThreeD<AutoSize>((AutoSize)InternalVar_3.InternalProperty_581, (AutoSize)InternalVar_3.InternalProperty_583, (AutoSize)InternalVar_3.InternalProperty_585);


                        InternalMethod_2312(InternalParameter_2682.InternalProperty_550.InternalProperty_510, InternalVar_4.X);
                        InternalMethod_2312(InternalParameter_2682.InternalProperty_550.InternalProperty_512, InternalVar_4.Y);
                        InternalMethod_2312(InternalParameter_2682.InternalProperty_550.InternalProperty_514, InternalVar_4.Z);
                    }

                    ThreeD<bool> InternalVar_5 = InternalType_728.InternalMethod_3282(InternalParameter_2683.AutoSize == AutoSize.Expand, InternalParameter_2683.AutoSize == AutoSize.Shrink);

                    ThreeD<bool> InternalVar_6 = new ThreeD<bool>(InternalVar_5.X || InternalType_728.InternalMethod_3284(InternalVar_2.YZ),
                                                                 InternalVar_5.Y || InternalType_728.InternalMethod_3284(InternalVar_2.XZ),
                                                                 InternalVar_5.Z || InternalType_728.InternalMethod_3284(InternalVar_2.XY));

                    EditorGUI.BeginChangeCheck();
                    ThreeD<LengthType> InternalVar_7 = new ThreeD<LengthType>(InternalParameter_2682.InternalProperty_550.InternalProperty_510.InternalProperty_508, InternalParameter_2682.InternalProperty_550.InternalProperty_512.InternalProperty_508, InternalParameter_2682.InternalProperty_550.InternalProperty_514.InternalProperty_508);

                    bool InternalVar_8 = InternalType_573.InternalMethod_2388(InternalType_554.InternalType_561.InternalField_2503, InternalParameter_2682.InternalProperty_550, InternalParameter_2682.InternalProperty_558, InternalParameter_2683.CalculatedSize, InternalVar_6, InternalType_573.InternalMethod_3332(InternalParameter_2683), InternalType_534.InternalProperty_443);

                    EditorGUI.EndDisabledGroup();

                    if (EditorGUI.EndChangeCheck())
                    {
                        InternalType_534.InternalProperty_443 = InternalVar_8;

                        if (InternalParameter_2682.InternalProperty_954.serializedObject.targetObjects.Length == 1)
                        {
                            if (InternalParameter_2683.Parent == null && SceneViewUtils.IsInCurrentPrefabStage(InternalParameter_2683.gameObject))
                            {
                                ThreeD<LengthType> InternalVar_9 = new ThreeD<LengthType>(InternalParameter_2682.InternalProperty_550.InternalProperty_510.InternalProperty_508, InternalParameter_2682.InternalProperty_550.InternalProperty_512.InternalProperty_508, InternalParameter_2682.InternalProperty_550.InternalProperty_514.InternalProperty_508);

                                Vector3 InternalVar_10 = InternalParameter_2683.CalculatedSize.Percent;

                                ThreeD<bool> InternalVar_11 = InternalVar_9 != InternalVar_7;

                                Vector3 InternalVar_12 = new Vector3(InternalVar_10.x == 0 ? 0 : InternalVar_11.X ? 1 : InternalParameter_2682.InternalProperty_550.InternalProperty_510.InternalProperty_506 / InternalVar_10.x,
                                                                        InternalVar_10.y == 0 ? 0 : InternalVar_11.Y ? 1 : InternalParameter_2682.InternalProperty_550.InternalProperty_512.InternalProperty_506 / InternalVar_10.y,
                                                                        InternalVar_10.z == 0 ? 0 : InternalVar_11.Z ? 1 : InternalParameter_2682.InternalProperty_550.InternalProperty_514.InternalProperty_506 / InternalVar_10.z);

                                Vector3 InternalVar_13 = InternalParameter_2684.vector3Value;

                                Vector3 InternalVar_14 = new Vector3(InternalVar_9.X == LengthType.Value && InternalVar_7.X == LengthType.Value ? InternalParameter_2682.InternalProperty_550.InternalProperty_510.InternalProperty_506 : InternalVar_12.x * InternalVar_13.x,
                                                              InternalVar_9.Y == LengthType.Value && InternalVar_7.Y == LengthType.Value ? InternalParameter_2682.InternalProperty_550.InternalProperty_512.InternalProperty_506 : InternalVar_12.y * InternalVar_13.y,
                                                              InternalVar_9.Z == LengthType.Value && InternalVar_7.Z == LengthType.Value ? InternalParameter_2682.InternalProperty_550.InternalProperty_514.InternalProperty_506 : InternalVar_12.z * InternalVar_13.z);

                                InternalParameter_2684.vector3Value = InternalVar_14;
                            }
                        }
                    }

                    InternalType_573.InternalMethod_2235(InternalType_554.InternalType_561.InternalField_2505, InternalParameter_2682.InternalProperty_570);
                }
            }
        }

        private static void InternalMethod_2312(InternalType_594 InternalParameter_2685, AutoSize InternalParameter_2686)
        {
            if (InternalParameter_2686 == AutoSize.None)
            {
                return;
            }

            LengthType InternalVar_1 = InternalParameter_2686 == AutoSize.Expand ? LengthType.Percent : LengthType.Value;

            InternalParameter_2685.InternalProperty_508 = InternalVar_1;
            InternalParameter_2685.InternalProperty_954.serializedObject.ApplyModifiedProperties();

            Object[] InternalVar_2 = InternalParameter_2685.InternalProperty_954.serializedObject.targetObjects;

            for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_2.Length; ++InternalVar_3)
            {
                float InternalVar_4 = InternalType_573.InternalMethod_2262(InternalVar_2[InternalVar_3] as UIBlock, InternalParameter_2685.InternalProperty_954.propertyPath, InternalVar_1);
                InternalType_573.InternalMethod_2253(InternalVar_2[InternalVar_3], InternalParameter_2685.InternalProperty_507.propertyPath, InternalVar_4);
            }
        }

        public static void InternalMethod_2313(InternalType_600 InternalParameter_2687, UIBlock InternalParameter_2688)
        {
            using (InternalType_553 foldout = InternalType_573.InternalMethod_2229("Position"))
            {
                if (!foldout)
                {
                    return;
                }

                EditorGUI.BeginDisabledGroup(InternalMethod_3000(InternalParameter_2688));

                InternalType_5 InternalVar_1 = InternalParameter_2688.InternalMethod_3592();

                int InternalVar_2 = InternalVar_1 != null && InternalVar_1.InternalProperty_143.InternalProperty_155 ? InternalVar_1.InternalProperty_143.InternalField_225.InternalMethod_508() : -1;
                ThreeD<bool> InternalVar_3 = new ThreeD<bool>(InternalVar_2 == Axis.X.Index(),
                                                         InternalVar_2 == Axis.Y.Index(),
                                                         InternalVar_2 == Axis.Z.Index());

                InternalMethod_2314(InternalParameter_2687.InternalProperty_566, InternalVar_3, InternalType_573.InternalMethod_3332(InternalParameter_2688));

                EditorGUI.BeginChangeCheck();
                bool InternalVar_4 = InternalType_573.InternalMethod_2388(InternalType_554.InternalType_562.InternalField_2506, InternalParameter_2687.InternalProperty_552, InternalParameter_2687.InternalProperty_560, InternalParameter_2688.CalculatedPosition, InternalVar_3, InternalType_573.InternalMethod_3332(InternalParameter_2688), InternalType_534.InternalProperty_444);
                if (EditorGUI.EndChangeCheck())
                {
                    InternalType_534.InternalProperty_444 = InternalVar_4;

                    if (!UnityEditor.EditorTools.ToolManager.IsActiveTool(InternalType_713.InternalProperty_973))
                    {
                        UnityEditor.EditorTools.ToolManager.SetActiveTool<InternalType_713>();
                    }
                }

                EditorGUI.EndDisabledGroup();
            }
        }

        public static void InternalMethod_2314(InternalType_601 InternalParameter_2689, ThreeD<bool> InternalParameter_2690, bool InternalParameter_2691)
        {
            float InternalVar_1 = InternalType_573.InternalProperty_472;

            InternalType_573.InternalType_575.InternalMethod_2305();

            EditorGUI.BeginDisabledGroup(false);
            InternalType_573.InternalMethod_2226(InternalType_554.InternalType_562.InternalField_2507, InternalParameter_2689.InternalProperty_954);
            EditorGUI.EndDisabledGroup();

            InternalType_573.InternalType_575.InternalMethod_2304(InternalParameter_2691, out Rect InternalVar_2, out Rect InternalVar_3, out Rect InternalVar_4);

            InternalType_573.InternalProperty_472 = InternalType_573.InternalField_2550;
            EditorGUI.BeginDisabledGroup(InternalParameter_2690.X);
            InternalMethod_213(InternalVar_2, InternalType_554.InternalField_2464, InternalParameter_2689.InternalProperty_576, InternalType_554.InternalProperty_464[0]);
            EditorGUI.EndDisabledGroup();
            EditorGUI.BeginDisabledGroup(InternalParameter_2690.Y);
            InternalMethod_213(InternalVar_3, InternalType_554.InternalField_2465, InternalParameter_2689.InternalProperty_578, InternalType_554.InternalProperty_464[1]);
            EditorGUI.EndDisabledGroup();

            if (InternalParameter_2691)
            {
                EditorGUI.BeginDisabledGroup(InternalParameter_2690.Z);
                InternalMethod_213(InternalVar_4, InternalType_554.InternalField_2466, InternalParameter_2689.InternalProperty_580, InternalType_554.InternalProperty_464[2]);
                EditorGUI.EndDisabledGroup();
            }

            InternalType_573.InternalType_575.InternalMethod_2307();

            InternalType_573.InternalProperty_472 = InternalVar_1;
        }

        public static (int, int) InternalMethod_214(GUIContent InternalParameter_358, int InternalParameter_357, int InternalParameter_223, GUIContent[][] InternalParameter_176)
        {
            float InternalVar_1 = InternalType_573.InternalProperty_472;

            InternalType_573.InternalType_575.InternalMethod_2305();

            InternalType_573.InternalMethod_2225(InternalParameter_358);

            InternalType_573.InternalType_575.InternalMethod_2304(false, out Rect InternalVar_2, out Rect InternalVar_3, out Rect InternalVar_4);

            InternalType_573.InternalProperty_472 = InternalType_573.InternalField_2550;

            InternalParameter_357 = InternalMethod_204(InternalVar_2, InternalType_554.InternalField_2464, InternalParameter_176[0], InternalParameter_357);
            InternalParameter_223 = InternalMethod_204(InternalVar_3, InternalType_554.InternalField_2465, InternalParameter_176[1], InternalParameter_223);

            InternalType_573.InternalType_575.InternalMethod_2307();

            InternalType_573.InternalProperty_472 = InternalVar_1;

            return (InternalParameter_357, InternalParameter_223);
        }

        public static void InternalMethod_213(Rect InternalParameter_172, GUIContent InternalParameter_137, SerializedProperty InternalParameter_136, GUIContent[] InternalParameter_135)
        {
            GUIContent InternalVar_1 = EditorGUI.BeginProperty(InternalParameter_172, InternalParameter_137, InternalParameter_136);
            if (InternalParameter_137 != null)
            {
                EditorGUI.PrefixLabel(InternalParameter_172, InternalVar_1);
                float InternalVar_2 = EditorStyles.label.CalcSize(InternalVar_1).x + InternalType_573.InternalField_2557;
                InternalParameter_172.x += InternalVar_2;
                InternalParameter_172.width -= InternalVar_2;
            }

            int InternalVar_3 = InternalParameter_136.hasMultipleDifferentValues ? -1000 : InternalParameter_136.intValue + 1;

            EditorGUI.BeginChangeCheck();
            int InternalVar_4 = InternalType_573.InternalMethod_2256(InternalParameter_172, InternalVar_3, InternalParameter_135) - 1;
            if (EditorGUI.EndChangeCheck())
            {
                InternalParameter_136.intValue = InternalVar_4;
            }

            EditorGUI.EndProperty();
        }

        public static int InternalMethod_204(Rect InternalParameter_134, GUIContent InternalParameter_133, GUIContent[] InternalParameter_132, int InternalParameter_131)
        {
            if (InternalParameter_133 != null)
            {
                EditorGUI.PrefixLabel(InternalParameter_134, InternalParameter_133);
                float InternalVar_1 = EditorStyles.label.CalcSize(InternalParameter_133).x + InternalType_573.InternalField_2557;
                InternalParameter_134.x += InternalVar_1;
                InternalParameter_134.width -= InternalVar_1;
            }

            int InternalVar_2 = InternalType_573.InternalMethod_2256(InternalParameter_134, InternalParameter_131 + 1, InternalParameter_132) - 1;

            return InternalVar_2;
        }

        public static void InternalMethod_2318(InternalType_602 InternalParameter_2703, ThreeD<bool> InternalParameter_2704, bool InternalParameter_2705)
        {
            float InternalVar_1 = InternalType_573.InternalProperty_472;

            InternalType_573.InternalType_575.InternalMethod_2305();

            InternalType_573.InternalMethod_2226(InternalType_554.InternalType_561.InternalField_2504, InternalParameter_2703.InternalProperty_954);

            InternalType_573.InternalType_575.InternalMethod_2304(InternalParameter_2705, out Rect InternalVar_2, out Rect InternalVar_3, out Rect InternalVar_4);

            bool InternalVar_5 = InternalParameter_2704.X;
            bool InternalVar_6 = InternalParameter_2704.Y;
            bool InternalVar_7 = InternalParameter_2704.Z;

            InternalType_573.InternalProperty_472 = InternalType_573.InternalField_2550;
            EditorGUI.BeginDisabledGroup(!InternalVar_5 && (InternalVar_6 || InternalVar_7));
            InternalMethod_2319(InternalVar_2, Axis.X.Index(), InternalType_554.InternalField_2464, InternalParameter_2703.InternalProperty_582);
            EditorGUI.EndDisabledGroup();
            InternalType_573.InternalProperty_472 = InternalType_573.InternalField_2550;
            EditorGUI.BeginDisabledGroup(!InternalVar_6 && (InternalVar_5 || InternalVar_7));
            InternalMethod_2319(InternalVar_3, Axis.Y.Index(), InternalType_554.InternalField_2465, InternalParameter_2703.InternalProperty_584);
            EditorGUI.EndDisabledGroup();

            if (InternalParameter_2705)
            {
                EditorGUI.BeginDisabledGroup(!InternalVar_7 && (InternalVar_5 || InternalVar_6));
                InternalMethod_2319(InternalVar_4, Axis.Z.Index(), InternalType_554.InternalField_2466, InternalParameter_2703.InternalProperty_586);
                EditorGUI.EndDisabledGroup();
            }

            InternalType_573.InternalType_575.InternalMethod_2307();


            InternalType_573.InternalProperty_472 = InternalVar_1;
        }

        public static void InternalMethod_2319(Rect InternalParameter_2706, int InternalParameter_2707, GUIContent InternalParameter_2708, SerializedProperty InternalParameter_2709)
        {
            EditorGUI.BeginChangeCheck();
            GUIContent InternalVar_1 = EditorGUI.BeginProperty(InternalParameter_2706, InternalParameter_2708, InternalParameter_2709);
            EditorGUI.PrefixLabel(InternalParameter_2706, InternalParameter_2708);

            float InternalVar_2 = EditorStyles.label.CalcSize(InternalVar_1).x + InternalType_573.InternalField_2557;
            InternalParameter_2706.x += InternalVar_2;
            InternalParameter_2706.width -= InternalVar_2;

            int InternalVar_3 = InternalParameter_2709.hasMultipleDifferentValues ? -1000 : InternalParameter_2709.intValue - 1;

            int InternalVar_4 = InternalType_573.InternalMethod_2255(InternalParameter_2706, InternalVar_3, InternalType_554.InternalProperty_466[InternalParameter_2707], InternalParameter_2706.width * 0.5f, InternalParameter_2624: true) + 1;
            EditorGUI.EndProperty();
            if (EditorGUI.EndChangeCheck())
            {
                InternalParameter_2709.intValue = InternalVar_4;
            }
        }

        public static void InternalMethod_2320(InternalType_600 InternalParameter_2710, UIBlock InternalParameter_2711)
        {
            using (InternalType_553 foldout = InternalType_573.InternalMethod_2229("Padding & Margin"))
            {
                if (!foldout)
                {
                    return;
                }

                using (new EditorGUI.IndentLevelScope(-EditorGUI.indentLevel))
                {
                    EditorGUI.BeginChangeCheck();
                    (bool InternalVar_1, bool InternalVar_2) = InternalType_573.InternalMethod_2386(InternalType_554.InternalType_566.InternalField_2514, InternalParameter_2710.InternalProperty_554, InternalParameter_2710.InternalProperty_562, InternalParameter_2711.CalculatedPadding, InternalType_573.InternalMethod_3332(InternalParameter_2711), InternalType_534.InternalProperty_446, InternalType_534.InternalProperty_445);
                    if (EditorGUI.EndChangeCheck())
                    {
                        InternalType_534.InternalProperty_446 = InternalVar_1;
                        InternalType_534.InternalProperty_445 = InternalVar_2;

                        if (!UnityEditor.EditorTools.ToolManager.IsActiveTool(InternalNamespace_21.InternalType_701.InternalProperty_973))
                        {
                            UnityEditor.EditorTools.ToolManager.SetActiveTool<InternalType_710>();
                        }
                    }

                    EditorGUI.BeginChangeCheck();
                    (bool InternalVar_3, bool InternalVar_4) = InternalType_573.InternalMethod_2386(InternalType_554.InternalType_566.InternalField_2515, InternalParameter_2710.InternalProperty_556, InternalParameter_2710.InternalProperty_564, InternalParameter_2711.CalculatedMargin, InternalType_573.InternalMethod_3332(InternalParameter_2711), InternalType_534.InternalProperty_448, InternalType_534.InternalProperty_447);
                    if (EditorGUI.EndChangeCheck())
                    {
                        InternalType_534.InternalProperty_448 = InternalVar_3;
                        InternalType_534.InternalProperty_447 = InternalVar_4;

                        if (!UnityEditor.EditorTools.ToolManager.IsActiveTool(InternalNamespace_21.InternalType_701.InternalProperty_973))
                        {
                            UnityEditor.EditorTools.ToolManager.SetActiveTool<InternalType_710>();
                        }
                    }
                }
            }
        }

        public static void InternalMethod_2321(InternalType_603 InternalParameter_2712, UIBlock InternalParameter_2713)
        {
            EditorGUI.BeginChangeCheck();

            bool InternalVar_1 = InternalParameter_2712.InternalProperty_588.hasMultipleDifferentValues ? false : InternalParameter_2712.InternalProperty_588.boolValue;
            using InternalType_553 InternalVar_2 = InternalType_573.InternalMethod_2230("Auto Layout", InternalParameter_2712.InternalProperty_588);

            if (EditorGUI.EndChangeCheck() && InternalVar_1 != InternalParameter_2712.InternalProperty_588.boolValue)
            {
                if (InternalVar_1)
                {
                    InternalMethod_3327(InternalParameter_2712.InternalProperty_588.serializedObject);
                }
                else
                {
                    InternalMethod_2323(InternalParameter_2712.InternalProperty_588, -1, InternalParameter_2712.InternalProperty_597);
                }
            }

            if (!InternalVar_2)
            {
                return;
            }

            EditorGUI.BeginChangeCheck();

            bool InternalVar_3 = InternalMethod_2322(InternalParameter_2713, InternalParameter_2712, InternalType_534.InternalProperty_449);

            if (EditorGUI.EndChangeCheck())
            {
                InternalType_534.InternalProperty_449 = InternalVar_3;
            }
        }

        public static bool InternalMethod_2322(UIBlock InternalParameter_2714, InternalType_603 InternalParameter_2715, bool InternalParameter_2716)
        {
            float InternalVar_1 = InternalType_573.InternalProperty_472;

            float InternalVar_2 = InternalType_573.InternalProperty_471;
            float InternalVar_3 = InternalVar_2 / 8f;

            using (new EditorGUI.IndentLevelScope(-EditorGUI.indentLevel))
            {
                InternalType_573.InternalType_575.InternalMethod_2305();
                GUILayout.FlexibleSpace();

                float InternalVar_4 = EditorGUIUtility.singleLineHeight + (3 * InternalType_573.InternalField_2557);
                Rect InternalVar_5 = InternalType_573.InternalType_575.InternalMethod_2303(InternalParameter_2673: false, InternalParameter_2674: InternalVar_4, GUILayout.Width(3 * InternalVar_3));
                Rect InternalVar_6 = InternalType_573.InternalType_575.InternalMethod_2303(InternalParameter_2673: false, InternalParameter_2674: InternalVar_4, GUILayout.Width(3 * InternalVar_3));
                Rect InternalVar_7 = InternalType_573.InternalType_575.InternalMethod_2303(InternalParameter_2673: false, InternalParameter_2674: InternalVar_4, GUILayout.Width(2 * InternalVar_3));

                EditorGUI.BeginChangeCheck();

                Rect InternalVar_8 = InternalVar_5;
                InternalVar_8.xMin = 0;
                EditorGUI.BeginProperty(InternalVar_8, GUIContent.none, InternalParameter_2715.InternalProperty_588);
                int InternalVar_9 = InternalParameter_2715.InternalProperty_587.Index();
                InternalVar_9 = InternalVar_9 >= 0 ? InternalVar_9 : 0;
                int InternalVar_10 = InternalType_573.InternalMethod_2255(InternalVar_5, InternalVar_9, InternalType_554.InternalField_2463, InternalVar_3);
                EditorGUI.EndProperty();
                if (EditorGUI.EndChangeCheck())
                {
                    InternalParameter_2715.InternalProperty_587 = AxisIndex.GetAxis(InternalVar_10);

                    InternalMethod_2323(InternalParameter_2715.InternalProperty_588, InternalVar_9, InternalParameter_2715.InternalProperty_597);
                }

                Rect InternalVar_11 = InternalVar_6;
                InternalVar_11.y -= InternalType_573.InternalField_2557;
                InternalVar_11.height += 2 * InternalType_573.InternalField_2557;
                EditorGUI.BeginProperty(InternalVar_11, GUIContent.none, InternalParameter_2715.InternalProperty_598);
                InternalMethod_213(InternalVar_6, null, InternalParameter_2715.InternalProperty_598, InternalType_554.InternalProperty_464[InternalVar_9]);
                EditorGUI.EndProperty();

                Rect InternalVar_12 = InternalVar_7;
                InternalVar_12.xMax = InternalType_573.InternalProperty_473;
                EditorGUI.BeginProperty(InternalVar_12, GUIContent.none, InternalParameter_2715.InternalProperty_596);
                EditorGUI.BeginChangeCheck();
                int InternalVar_13 = InternalType_573.InternalMethod_2255(InternalVar_7, InternalParameter_2715.InternalProperty_595 ? 1 : 0, InternalType_554.InternalProperty_465[InternalVar_9], InternalVar_3);
                EditorGUI.EndProperty();

                if (EditorGUI.EndChangeCheck())
                {
                    InternalParameter_2715.InternalProperty_595 = InternalVar_13 == 1;
                }

                GUILayout.FlexibleSpace();
                InternalType_573.InternalType_575.InternalMethod_2307();

                InternalType_573.InternalType_575.InternalMethod_2308();

                InternalType_573.InternalType_575.InternalMethod_2305();

                bool InternalVar_14 = InternalParameter_2715.InternalProperty_593;

                InternalParameter_2716 = InternalType_573.InternalMethod_2228(InternalParameter_2716);

                InternalType_573.InternalMethod_2236(-InternalType_573.InternalType_575.InternalField_2593);

                float InternalVar_15 = EditorStyles.label.CalcSize(InternalType_554.InternalType_557.InternalField_2490).x;
                float InternalVar_16 = InternalVar_15 + InternalType_573.InternalField_2557 + InternalType_573.InternalField_2551;
                float InternalVar_17 = InternalType_573.InternalProperty_469 + InternalVar_15 - InternalType_573.InternalField_2557;

                EditorGUI.BeginDisabledGroup(InternalVar_14);
                InternalType_573.InternalProperty_472 = InternalVar_17;
                Rect InternalVar_18 = InternalType_573.InternalType_575.InternalMethod_2302();
                InternalVar_18.width -= InternalType_573.InternalField_2551;

                InternalType_554.InternalType_557.InternalField_2489.text = "Spacing";
                InternalType_573.InternalMethod_1930(InternalVar_18, InternalType_554.InternalType_557.InternalField_2489, InternalParameter_2715.InternalProperty_589, InternalParameter_2714.CalculatedSpacing, InternalParameter_2715.InternalProperty_591.InternalProperty_540, InternalParameter_2715.InternalProperty_591.InternalProperty_538);

                EditorGUI.EndDisabledGroup();

                if (InternalVar_14 && Event.current.type == EventType.Repaint)
                {
                    GUIStyle InternalVar_19 = InternalParameter_2715.InternalProperty_590.prefabOverride ? EditorStyles.boldLabel : EditorStyles.label;
                    InternalVar_19.Draw(InternalVar_18, InternalType_554.InternalType_557.InternalField_2489, false, false, false, false);
                }

                InternalType_573.InternalProperty_472 = InternalVar_16 - InternalType_573.InternalField_2551;
                Rect InternalVar_20 = InternalType_573.InternalType_575.InternalMethod_2302(GUILayout.Width(InternalVar_16));

                bool InternalVar_21 = InternalParameter_2714.TryGetComponent<ListView>(out _);

                EditorGUI.BeginDisabledGroup(InternalVar_21);

                EditorGUI.BeginChangeCheck();
                GUIContent InternalVar_22 = EditorGUI.BeginProperty(InternalVar_20, InternalVar_21 ? InternalType_554.InternalType_557.InternalField_464 : InternalType_554.InternalType_557.InternalField_2490, InternalParameter_2715.InternalProperty_594);
                bool InternalVar_23 = EditorGUI.Toggle(InternalVar_20, InternalVar_22, InternalParameter_2715.InternalProperty_593);
                EditorGUI.EndProperty();
                if (EditorGUI.EndChangeCheck())
                {
                    InternalParameter_2715.InternalProperty_593 = InternalVar_23;
                }

                EditorGUI.EndDisabledGroup();

                InternalType_573.InternalProperty_472 = InternalVar_1;

                InternalType_573.InternalType_575.InternalMethod_2307();

                if (InternalParameter_2716)
                {
                    EditorGUILayout.Space(1);
                    InternalType_573.InternalType_574.InternalMethod_3438(GUILayoutUtility.GetLastRect());
                    InternalType_573.InternalType_575.InternalMethod_2306(InternalType_573.InternalType_574.InternalProperty_475);
                    InternalType_573.InternalProperty_472 = InternalType_573.InternalProperty_469 + InternalVar_15 + InternalType_573.InternalField_2551 - InternalType_573.InternalField_2557;
                    InternalType_573.InternalMethod_2382(GUIContent.none, InternalParameter_2715.InternalProperty_589, InternalParameter_2715.InternalProperty_591, InternalParameter_2714.CalculatedSpacing, InternalParameter_2715.InternalProperty_589.InternalProperty_508 == LengthType.Value);
                    InternalType_573.InternalProperty_472 = InternalVar_1;
                    InternalType_573.InternalType_575.InternalMethod_2307();
                }

                InternalType_573.InternalType_575.InternalMethod_2310();

                InternalType_573.InternalMethod_2237(InternalType_554.InternalType_557.InternalField_2494, InternalParameter_2715.InternalProperty_600);
            }

            InternalType_573.InternalProperty_472 = InternalVar_1;

            return InternalParameter_2716;
        }

        
        private static void InternalMethod_3327(SerializedObject InternalParameter_1290)
        {
            UIBlock[] InternalVar_1 = InternalParameter_1290.targetObjects.Cast<UIBlock>().ToArray();

            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1.Length; ++InternalVar_2)
            {
                InternalType_521<InternalType_146> InternalVar_3 = InternalVar_1[InternalVar_2].InternalProperty_33;

                for (int InternalVar_4 = 0; InternalVar_4 < InternalVar_3.InternalProperty_433; ++InternalVar_4)
                {
                    if (!(InternalVar_3[InternalVar_4] is UIBlock child))
                    {
                        continue;
                    }

                    SerializedObject InternalVar_5 = new SerializedObject(child);
                    InternalType_595 InternalVar_6 = new InternalType_595() { InternalProperty_954 = InternalVar_5.FindProperty(InternalType_646.InternalType_657.InternalField_2984).FindPropertyRelative(InternalType_646.InternalType_654.InternalField_2964) };

                    Length3 InternalVar_7 = child.Position;

                    InternalVar_6.InternalProperty_510.InternalProperty_506 = InternalVar_7.X.Raw;
                    InternalVar_6.InternalProperty_510.InternalProperty_508 = InternalVar_7.X.Type;
                    InternalVar_6.InternalProperty_512.InternalProperty_506 = InternalVar_7.Y.Raw;
                    InternalVar_6.InternalProperty_512.InternalProperty_508 = InternalVar_7.Y.Type;
                    InternalVar_6.InternalProperty_514.InternalProperty_506 = InternalVar_7.Z.Raw;
                    InternalVar_6.InternalProperty_514.InternalProperty_508 = InternalVar_7.Z.Type;

                    InternalVar_5.ApplyModifiedProperties();
                }
            }
        }

        
        private static void InternalMethod_2323(SerializedProperty InternalParameter_2717, int InternalParameter_2718, int InternalParameter_2719)
        {
            UIBlock[] InternalVar_1 = InternalParameter_2717.serializedObject.targetObjects.Cast<UIBlock>().ToArray();

            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1.Length; ++InternalVar_2)
            {
                InternalType_521<InternalType_146> InternalVar_3 = InternalVar_1[InternalVar_2].InternalProperty_33;
                if (InternalVar_3.InternalProperty_433 == 0)
                {
                    continue;
                }

                InternalMethod_184<UIBlock>(InternalVar_3, InternalParameter_2717, InternalParameter_2718, InternalParameter_2719);
                InternalMethod_184<UIBlock2D>(InternalVar_3, InternalParameter_2717, InternalParameter_2718, InternalParameter_2719);
                InternalMethod_184<UIBlock3D>(InternalVar_3, InternalParameter_2717, InternalParameter_2718, InternalParameter_2719);
                InternalMethod_184<TextBlock>(InternalVar_3, InternalParameter_2717, InternalParameter_2718, InternalParameter_2719);
            }
        }

        private static void InternalMethod_184<T>(InternalType_521<InternalType_146> InternalParameter_130, SerializedProperty InternalParameter_129, int InternalParameter_128, int InternalParameter_127) where T : UIBlock
        {
            T[] InternalVar_1 = InternalParameter_130.InternalProperty_434.Where((x) => typeof(T).IsAssignableFrom(x.GetType()) && x.GetType().IsAssignableFrom(typeof(T))).Cast<T>().ToArray();

            if (InternalVar_1 == null || InternalVar_1.Length == 0)
            {
                return;
            }

            SerializedObject InternalVar_2 = new SerializedObject(InternalVar_1);
            InternalType_595 InternalVar_3 = new InternalType_595() { InternalProperty_954 = InternalVar_2.FindProperty(InternalType_646.InternalType_657.InternalField_2984).FindPropertyRelative(InternalType_646.InternalType_654.InternalField_2964) };
            InternalType_601 InternalVar_4 = new InternalType_601() { InternalProperty_954 = InternalVar_2.FindProperty(InternalType_646.InternalType_657.InternalField_2984).FindPropertyRelative(InternalType_646.InternalType_654.InternalField_2971) };

            InternalNamespace_0.InternalType_96 InternalVar_5 = (InternalNamespace_0.InternalType_96)InternalParameter_129.intValue;

            switch (InternalParameter_128)
            {
                case 0: 
                    InternalVar_3.InternalProperty_510.InternalProperty_506 = 0;
                    break;
                case 1: 
                    InternalVar_3.InternalProperty_512.InternalProperty_506 = 0;
                    break;
                case 2: 
                    InternalVar_3.InternalProperty_514.InternalProperty_506 = 0;
                    break;
                default:
                    InternalVar_3.InternalProperty_510.InternalProperty_506 = 0;
                    InternalVar_3.InternalProperty_512.InternalProperty_506 = 0;
                    InternalVar_3.InternalProperty_514.InternalProperty_506 = 0;
                    break;
            }

            switch (InternalVar_5)
            {
                case InternalNamespace_0.InternalType_96.InternalField_305: 
                    InternalVar_4.InternalProperty_576.intValue = InternalParameter_127;
                    break;
                case InternalNamespace_0.InternalType_96.InternalField_306: 
                    InternalVar_4.InternalProperty_578.intValue = InternalParameter_127;
                    break;
                case InternalNamespace_0.InternalType_96.InternalField_307: 
                    InternalVar_4.InternalProperty_580.intValue = InternalParameter_127;
                    break;
                default:
                    break;
            }

            InternalVar_2.ApplyModifiedProperties();
        }

        private static void InternalMethod_2325(ThreeD<AutoSize> InternalParameter_2724, ThreeD<AutoSize> InternalParameter_2725, ThreeD<LengthType> InternalParameter_2726)
        {
            bool InternalVar_1 = false;
            bool InternalVar_2 = false;
            bool InternalVar_3 = false;

            bool InternalVar_4 = InternalParameter_2724.X == AutoSize.Shrink && (InternalParameter_2726.X == LengthType.Percent || InternalVar_1);
            bool InternalVar_5 = InternalParameter_2724.Y == AutoSize.Shrink && (InternalParameter_2726.Y == LengthType.Percent || InternalVar_2);
            bool InternalVar_6 = InternalParameter_2724.Z == AutoSize.Shrink && (InternalParameter_2726.Z == LengthType.Percent || InternalVar_3);

            if (!InternalVar_4 && !InternalVar_5 && !InternalVar_6)
            {
                return;
            }

            bool InternalVar_7 = (InternalVar_4 && InternalVar_5) || (InternalVar_4 && InternalVar_6) || (InternalVar_5 && InternalVar_6);
            string InternalVar_8 = InternalVar_7 ? "axes" : "axis";
            string InternalVar_9 = InternalVar_7 ? "are" : "is";

            string InternalVar_10 = (InternalVar_4 && InternalParameter_2725.X == AutoSize.Expand) || (InternalVar_5 && InternalParameter_2725.Y == AutoSize.Expand) || (InternalVar_6 && InternalParameter_2725.Z == AutoSize.Expand) ? " (or Expand)" : string.Empty;

            string InternalVar_11 = $"Percent{InternalVar_10}";
            string InternalVar_12 = InternalVar_4 ? InternalVar_5 ? InternalVar_6 ? "X, Y, and Z" : "X and Y" : InternalVar_6 ? "X and Z" : "X" : InternalVar_5 ? InternalVar_6 ? "Y and Z" : "Y" : "Z";
            string InternalVar_13 = InternalVar_7 ? "s" : string.Empty;
            string InternalVar_14 = $"The {InternalVar_12} {InternalVar_8} {InternalVar_9} set to {InternalVar_11}, while its parent is set to Shrink in the same direction{InternalVar_13}. These properties conflict and could lead to undesired behavior.";

            InternalType_573.InternalMethod_3336(InternalVar_14);
        }
    }
}

