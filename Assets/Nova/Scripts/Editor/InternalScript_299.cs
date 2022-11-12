using Nova.InternalNamespace_0.InternalNamespace_1;

namespace Nova.InternalNamespace_17.InternalNamespace_22
{
    internal static class InternalType_102
    {
        [UnityEditor.InitializeOnLoadMethod]
        private static void InternalMethod_3314()
        {
            UnityEditor.EditorApplication.playModeStateChanged += (state) =>
            {
                bool InternalVar_1 = state == UnityEditor.PlayModeStateChange.EnteredEditMode || state == UnityEditor.PlayModeStateChange.ExitingPlayMode;

                if (InternalVar_1 && InternalType_120.InternalField_406 != null)
                {
                    InternalType_120.InternalField_406.Dispose();
                }
            };
        }
    }
}

