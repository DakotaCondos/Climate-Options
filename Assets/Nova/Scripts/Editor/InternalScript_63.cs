using Nova.InternalNamespace_0.InternalNamespace_7;
using System;
using UnityEditor;
using UnityEngine;

namespace Nova.InternalNamespace_17.InternalNamespace_18
{
    [CustomPropertyDrawer(typeof(InternalType_215))]
    internal class InternalType_579 : PropertyDrawer
    {
        private struct InternalType_580
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public Type InternalField_2602;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public SerializedProperty InternalField_2603;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static SerializedProperty InternalField_2601 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_581 InternalField_3311 = null;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            InternalMethod_3314(position, property, label);
        }

        public static void InternalMethod_3314(Rect InternalParameter_3447, SerializedProperty InternalParameter_3448, GUIContent InternalParameter_3449)
        {
            InternalParameter_3449 = EditorGUI.BeginProperty(InternalParameter_3447, InternalParameter_3449, InternalParameter_3448);
            InternalType_579.InternalField_2601 = InternalParameter_3448;
            InternalMethod_2345(InternalParameter_3447, InternalParameter_3449);
            EditorGUI.PropertyField(InternalParameter_3447, InternalParameter_3448, includeChildren: true);
            EditorGUI.EndProperty();
        }

        private static void InternalMethod_2345(Rect InternalParameter_2757, GUIContent InternalParameter_2758)
        {
            Rect InternalVar_1 = InternalParameter_2757;

            float InternalVar_2 = Mathf.Max(EditorStyles.boldLabel.CalcSize(InternalParameter_2758).x, InternalType_573.InternalProperty_472);

            InternalVar_1.x += InternalVar_2 + InternalType_573.InternalField_2557;
            InternalVar_1.width = InternalParameter_2757.width - InternalVar_2 - InternalType_573.InternalField_2557;
            InternalVar_1.height = EditorGUIUtility.singleLineHeight;

            using (new EditorGUI.IndentLevelScope(-EditorGUI.indentLevel))
            {
                (string InternalVar_3, string InternalVar_4) = InternalMethod_2352(InternalField_2601.managedReferenceFullTypename);

                bool InternalVar_5 = !string.IsNullOrEmpty(InternalVar_4);
                InternalVar_4 = !InternalVar_5 ? "None (Unassigned)" : InternalVar_4;

                bool InternalVar_6 = GUI.Button(InternalVar_1, new GUIContent(InternalVar_4.Substring(InternalVar_4.LastIndexOf(".") + 1), InternalVar_4 + "  ( " + InternalVar_3 + " )"), EditorStyles.popup);

                if (!InternalVar_6)
                {
                    return;
                }

                if (InternalField_3311 == null)
                {
                    Type InternalVar_7 = InternalMethod_2351(InternalField_2601.managedReferenceFieldTypename);
                    if (InternalVar_7 == null)
                    {
                        Debug.LogError($"SerializeReference type, [{InternalField_2601.managedReferenceFieldTypename}], not found.");
                        return;
                    }

                    InternalField_3311 = new InternalType_581(InternalVar_7);
                    InternalField_3311.InternalEvent_6 += InternalMethod_566;
                }

                InternalField_3311.Show(InternalVar_1);
            }
        }

        private static void InternalMethod_566(Type InternalParameter_79)
        {
            if (InternalParameter_79 != null)
            {
                InternalField_2601.managedReferenceValue = Activator.CreateInstance(InternalParameter_79);
                InternalField_2601.serializedObject.ApplyModifiedProperties();
            }
            else
            {
                InternalField_2601.managedReferenceValue = null;
                InternalField_2601.serializedObject.ApplyModifiedProperties();
            }
        }

        public static Type InternalMethod_2351(string InternalParameter_2765)
        {
            (string InternalVar_1, string InternalVar_2) = InternalMethod_2352(InternalParameter_2765);

            return Type.GetType($"{InternalVar_2}, {InternalVar_1}");
        }

        public static (string AssemblyName, string ClassName) InternalMethod_2352(string InternalParameter_2766)
        {
            if (string.IsNullOrEmpty(InternalParameter_2766))
            {
                return ("", "");
            }

            string[] InternalVar_1 = InternalParameter_2766.Split(char.Parse(" "));
            string InternalVar_2 = InternalVar_1[1];
            string InternalVar_3 = InternalVar_1[0];
            return (InternalVar_3, InternalVar_2);
        }
    }
}
