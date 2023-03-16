using Nova.InternalNamespace_17.InternalNamespace_20;
using UnityEditor;
using UnityEngine;

namespace Nova.InternalNamespace_17.InternalNamespace_18
{
    [CustomEditor(typeof(ItemView))]
    internal class InternalType_544 : InternalType_540
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private SerializedProperty InternalField_2214 = null;
        
        private void OnEnable()
        {
            InternalField_2214 = serializedObject.FindProperty(InternalType_646.InternalType_669.InternalField_3332);
        }

        public override void OnInspectorGUI()
        {
            float InternalVar_1 = EditorGUI.GetPropertyHeight(InternalField_2214, includeChildren: true);
            Rect InternalVar_2 = EditorGUILayout.GetControlRect(GUILayout.Height(InternalVar_1));
            
            InternalType_579.InternalMethod_3314(InternalVar_2, InternalField_2214, InternalType_554.InternalType_563.InternalField_715);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
