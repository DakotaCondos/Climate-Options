using Nova;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Nova.InternalNamespace_17.InternalNamespace_18
{ 
    internal abstract class InternalType_191<T79> : InternalType_539<T79> where T79 : GestureRecognizer
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private List<T79> InternalField_2219 = new List<T79>();

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const float InternalField_3344 = 89;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly GUIContent InternalField_2218 = new GUIContent("Obstruct Drags", "When true, drag gestures will not be routed to content behind the attached UIBlock.\nWhen false, content behind the attached UIBlock can receive drag gestures if it is \"draggable\" in a direction this component is not.\nDoes not impact the \"draggable\" state of this component.");
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly GUIContent InternalField_2217 = new GUIContent("Drag Threshold", "The threshold that must be surpassed to initiate a drag event.\n\nThis threshold is generally used for high precision input devices, E.g. mouse, touchscreen, VR controller, and most other ray based input.");
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly GUIContent InternalField_2216 = new GUIContent("Low Accuracy Drag Threshold", "The threshold that must be surpassed to initiate a drag event.\n\nThis \"Low Accuracy\" threshold is generally used for noisier (i.e. less physically stable) input devices, E.g. VR handtracking and other sphere collider based input.");
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly GUIContent InternalField_2924 = new GUIContent("Click Behavior", "Determines when this interactable should trigger click events.");

        protected override void OnEnable()
        {
            base.OnEnable();

            if (Application.IsPlaying(target))
            {
                Undo.undoRedoPerformed += InternalMethod_1220;
            }
        }


        private void OnDisable()
        {
            Undo.undoRedoPerformed -= InternalMethod_1220;
        }

        protected virtual void InternalMethod_1220()
        {
            InternalMethod_1193();
            serializedObject.ApplyModifiedProperties();
            InternalMethod_1183();
        }

        
        private void InternalMethod_1193()
        {
            if (!Application.isPlaying)
            {
                return;
            }

            InternalField_2219.Clear();

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_2385.Count; ++InternalVar_1)
            {
                T79 InternalVar_2 = InternalField_2385[InternalVar_1];
                if (!InternalVar_2.isActiveAndEnabled)
                {
                    continue;
                }

                Undo.RecordObject(InternalVar_2, "Inspector");

                InternalVar_2.enabled = false;
                InternalField_2219.Add(InternalVar_2);
            }
        }

        
        private void InternalMethod_1183()
        {
            if (!Application.isPlaying)
            {
                return;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_2219.Count; ++InternalVar_1)
            {
                T79 InternalVar_2 = InternalField_2219[InternalVar_1];
                InternalVar_2.enabled = true;
            }
        }
    }
}
