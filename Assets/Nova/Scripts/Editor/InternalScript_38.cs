using Nova.InternalNamespace_17.InternalNamespace_20;
using UnityEditor;

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
            EditorGUILayout.PropertyField(InternalField_2214, InternalType_554.InternalType_563.InternalField_715);
            serializedObject.ApplyModifiedProperties();
        }
    }
}
