using Nova.Compat;
using System;

namespace Nova.InternalNamespace_0.InternalNamespace_5
{
    internal static class InternalType_180
    {
        
        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static bool InternalField_485;

        
        public static void InternalMethod_849()
        {
            if (!NovaApplication.IsEditor)
            {
                return;
            }

            if (InternalField_485 || NovaApplication.IsPlaying)
            {
                return;
            }

            InternalField_485 = true;
            NovaApplication.EditorDelayCall += () =>
            {
                NovaApplication.QueueEditorPlayerLoop();
                InternalField_485 = false;
            };

        }
    }
}
