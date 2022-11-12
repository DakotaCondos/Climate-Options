using Nova.InternalNamespace_17.InternalNamespace_22;
using UnityEditor;
using UnityEngine;
using static Nova.InternalNamespace_17.InternalNamespace_20.InternalType_592;

namespace Nova.InternalNamespace_17.InternalNamespace_18
{
    [CustomPropertyDrawer(typeof(AutoLayout))]
    internal class InternalType_584 : InternalType_583<InternalType_603>
    {
        protected override float InternalMethod_2353(GUIContent InternalParameter_2767)
        {
            if (!InternalField_2605)
            {
                return EditorGUI.GetPropertyHeight(InternalField_2604.InternalProperty_954, InternalParameter_2767, false);
            }

            return 8f * InternalType_720.InternalField_3298;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_2605 = true;
        protected override void OnGUI(Rect position, GUIContent label)
        {
            InternalField_2605 = EditorGUI.Foldout(position, InternalField_2605, label, true);

            if (!InternalField_2605)
            {
                EditorGUI.EndFoldoutHeaderGroup();
                return;
            }

            position.InternalMethod_3251();

            EditorGUI.indentLevel++;

            float InternalVar_1 = (position.width - EditorGUIUtility.labelWidth) / 3f;
            EditorGUI.PrefixLabel(position, InternalType_554.InternalType_557.InternalField_2491);
            Rect InternalVar_2 = new Rect(position.x + InternalType_573.InternalProperty_472, position.y, position.width - InternalType_573.InternalProperty_472, position.height);
            EditorGUI.BeginChangeCheck();
            EditorGUI.BeginProperty(InternalVar_2, GUIContent.none, InternalField_2604.InternalProperty_588);
            int InternalVar_3 = InternalField_2604.InternalProperty_587.Index();
            InternalVar_3 = InternalVar_3 >= 0 ? InternalVar_3 : 0;
            int InternalVar_4 = InternalType_573.InternalMethod_2255(InternalVar_2, InternalVar_3, InternalType_554.InternalField_2463, InternalVar_1);
            EditorGUI.EndProperty();
            if (EditorGUI.EndChangeCheck())
            {
                InternalField_2604.InternalProperty_587 = AxisIndex.GetAxis(InternalVar_4);
            }

            position.InternalMethod_3251();

            EditorGUI.PrefixLabel(position, InternalType_554.InternalType_557.InternalField_2492);

            Rect InternalVar_5 = new Rect(position.x + InternalType_573.InternalProperty_472, position.y, position.width - InternalType_573.InternalProperty_472, position.height);
            EditorGUI.BeginChangeCheck();
            EditorGUI.BeginProperty(InternalVar_5, GUIContent.none, InternalField_2604.InternalProperty_598);
            int InternalVar_6 = InternalType_573.InternalMethod_2255(InternalVar_5, InternalField_2604.InternalProperty_597 + 1, InternalType_554.InternalProperty_464[InternalVar_3], InternalVar_1);
            EditorGUI.EndProperty();
            if (EditorGUI.EndChangeCheck())
            {
                InternalField_2604.InternalProperty_597 = InternalVar_6 - 1;
            }

            position.InternalMethod_3251();
            EditorGUI.PrefixLabel(position, InternalType_554.InternalType_557.InternalField_2493);

            float InternalVar_7 = (position.width - EditorGUIUtility.labelWidth) / 2f;

            Rect InternalVar_8 = new Rect(position.x + InternalType_573.InternalProperty_472, position.y, position.width - InternalType_573.InternalProperty_472, position.height);
            EditorGUI.BeginChangeCheck();
            EditorGUI.BeginProperty(InternalVar_8, GUIContent.none, InternalField_2604.InternalProperty_596);
            int InternalVar_9 = InternalType_573.InternalMethod_2255(InternalVar_8, InternalField_2604.InternalProperty_595 ? 1 : 0, InternalType_554.InternalProperty_465[InternalVar_3], InternalVar_7);
            EditorGUI.EndProperty();
            if (EditorGUI.EndChangeCheck())
            {
                InternalField_2604.InternalProperty_595 = InternalVar_9 == 1;
            }

            position.InternalMethod_3251();

            EditorGUI.PropertyField(position, InternalField_2604.InternalProperty_594);
            position.InternalMethod_3251();
            EditorGUI.BeginDisabledGroup(InternalField_2604.InternalProperty_593);
            EditorGUI.PropertyField(position, InternalField_2604.InternalProperty_590);
            EditorGUI.EndDisabledGroup();
            position.InternalMethod_3251();
            EditorGUI.PropertyField(position, InternalField_2604.InternalProperty_592);
            position.InternalMethod_3251();
            EditorGUI.PropertyField(position, InternalField_2604.InternalProperty_600);
            EditorGUI.indentLevel--;

            EditorGUI.EndFoldoutHeaderGroup();
        }
    }
}