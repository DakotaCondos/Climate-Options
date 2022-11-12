using Nova.InternalNamespace_17.InternalNamespace_20;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Nova.InternalNamespace_17.InternalNamespace_18
{
    [CustomEditor(typeof(Scroller)), CanEditMultipleObjects]
    internal class InternalType_545 : InternalType_191<Scroller>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private List<MonoBehaviour> InternalField_2404 = new List<MonoBehaviour>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static GUIContent InternalField_2918 = new GUIContent("Pointer Click");
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static GUIContent InternalField_2406 = new GUIContent("Pointer Drag");
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static GUIContent InternalField_2407 = new GUIContent("Mouse Wheel or Joystick");
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static GUIContent InternalField_2408 = new GUIContent("Scrollbar");

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static GUIContent InternalField_2409 = new GUIContent("Overscroll Effect", "The behavior applied when there's no more content to scroll in the scrolling direction");

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static GUIContent InternalField_2410 = new GUIContent("Drag Scrolling", "Allow Interactions.Point drag events to trigger a scroll.\n\nE.g. Dragging on a touch screen.");

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static GUIContent InternalField_2411 = new GUIContent("Vector Scrolling", "Allow Interactions.Scroll vector events to trigger a scroll.\n\nE.g. Scroll wheel on a mouse.");
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static GUIContent InternalField_2412 = new GUIContent("Vector Scroll Multiplier", "The speed multiplier for vector scrolling");

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static GUIContent InternalField_2413 = new GUIContent("Draggable Scrollbar", "Indicates whether or not the Scroller should handle drag events on the Scrollbar Visual automatically.");
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static GUIContent InternalField_2414 = new GUIContent("Scrollbar Visual", "The visual representing the scroll position of content relative to the viewport. The Scroller component will adjust this visual's size/position along the scrolling axis");

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        SerializedProperty InternalField_2213 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        SerializedProperty InternalField_2819 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        SerializedProperty InternalField_2416 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        SerializedProperty InternalField_2417 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        SerializedProperty InternalField_2418 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        SerializedProperty InternalField_2419 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        SerializedProperty InternalField_2420 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        SerializedProperty InternalField_2421 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        SerializedProperty InternalField_2422 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        SerializedProperty InternalField_2423 = null;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalProperty_1039 => !serializedObject.isEditingMultipleObjects;

        protected override void OnEnable()
        {
            base.OnEnable();

            InternalField_2213 = serializedObject.FindProperty(InternalType_646.InternalType_693.InternalField_3336);
            InternalField_2819 = serializedObject.FindProperty(InternalType_646.InternalType_693.InternalField_3360);

            InternalField_2416 = serializedObject.FindProperty(InternalType_646.InternalType_693.InternalField_3171);

            InternalField_2417 = serializedObject.FindProperty(InternalType_646.InternalType_693.InternalField_3172);
            InternalField_2418 = serializedObject.FindProperty(InternalType_646.InternalType_691.InternalField_3164);
            InternalField_2419 = serializedObject.FindProperty(InternalType_646.InternalType_691.InternalField_3165);

            InternalField_2420 = serializedObject.FindProperty(InternalType_646.InternalType_693.InternalField_3173);
            InternalField_2421 = serializedObject.FindProperty(InternalType_646.InternalType_693.InternalField_3174);

            InternalField_2423 = serializedObject.FindProperty(InternalType_646.InternalType_693.InternalField_3176);
            InternalField_2422 = serializedObject.FindProperty(InternalType_646.InternalType_693.InternalField_3175);

            InternalMethod_2180();
        }

        public override void OnInspectorGUI()
        {

            EditorGUI.BeginChangeCheck();

            EditorGUILayout.LabelField(InternalField_2918, EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(InternalField_2819, InternalField_2924);

            EditorGUILayout.Separator();
            EditorGUILayout.LabelField(InternalField_2406, EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(InternalField_2417, InternalField_2410);

            if (InternalField_2417.boolValue)
            {
                InternalType_573.InternalMethod_2233(InternalField_2217, InternalField_2418, 0, InternalField_3344);
                InternalType_573.InternalMethod_2233(InternalField_2216, InternalField_2419, 0, InternalField_3344);
            }

            EditorGUILayout.Separator();
            EditorGUILayout.LabelField(InternalField_2407, EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(InternalField_2420, InternalField_2411);

            if (InternalField_2420.boolValue)
            {
                EditorGUILayout.PropertyField(InternalField_2421, InternalField_2412);
            }

            InternalMethod_2176();

            EditorGUILayout.Separator();
            EditorGUILayout.Separator();
            EditorGUILayout.PropertyField(InternalField_2416, InternalField_2409);
            EditorGUILayout.PropertyField(InternalField_2213, InternalField_2218);

            if (EditorGUI.EndChangeCheck())
            {
                InternalMethod_1220();
            }
        }

        protected override void InternalMethod_1220()
        {
            base.InternalMethod_1220();

            InternalMethod_2180();
        }

        private void InternalMethod_2176()
        {
            bool InternalVar_1 = false;
            bool InternalVar_2 = false;

            if (InternalField_2423.boolValue || InternalField_2423.hasMultipleDifferentValues)
            {
                for (int InternalVar_3 = 0; InternalVar_3 < InternalField_2385.Count; ++InternalVar_3)
                {
                    Scroller InternalVar_4 = InternalField_2385[InternalVar_3];
                    MonoBehaviour InternalVar_5 = InternalVar_4.ScrollbarVisual;

                    if (InternalVar_5 == null || !InternalVar_4.DraggableScrollbar)
                    {
                        continue;
                    }

                    Interactable InternalVar_6 = InternalVar_5.GetComponentInChildren<Interactable>();

                    if (InternalVar_4.DraggableScrollbar && InternalVar_6 == null)
                    {
                        InternalVar_1 = true;
                        break;
                    }

                    if (InternalVar_4.UIBlock.AutoLayout.Axis.TryGetIndex(out int InternalVar_7) && !InternalVar_6.Draggable[InternalVar_7])
                    {
                        InternalVar_2 = true;
                        break;
                    }
                }
            }

            EditorGUILayout.Separator();
            EditorGUILayout.LabelField(InternalField_2408, EditorStyles.boldLabel);

            if (InternalVar_1)
            {
                InternalType_573.InternalMethod_3336("Scrollbar Visual is missing an Interactable component");
            }
            else if (InternalVar_2)
            {
                InternalType_573.InternalMethod_3336("The Scrollbar Visual's Interactable component must be configured to be draggable along the scrolling axis.");
            }

            InternalMethod_829();
            InternalMethod_832();
        }

        private void InternalMethod_829()
        {
            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(InternalField_2423, InternalField_2413);

            if (!EditorGUI.EndChangeCheck() || !InternalProperty_1039)
            {
                return;
            }

            InternalMethod_834();
        }

        private void InternalMethod_832()
        {
            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(InternalField_2422, InternalField_2414);

            if (!(EditorGUI.EndChangeCheck() && InternalProperty_1039 && InternalField_2422.objectReferenceValue is UIBlock scrollbarBlock))
            {
                return;
            }

            if (scrollbarBlock.transform.parent == null ||
                scrollbarBlock.transform.parent.GetComponent<UIBlock>() == null)
            {
                EditorUtility.DisplayDialog($"Scrollbar must have parent {nameof(UIBlock)}", $"The scrollbar visual is positioned and sized relative to the bounds of its parent {nameof(UIBlock)}.\n\nPlease ensure the scrollbar is a child of a {nameof(UIBlock)}.", "Okay");
                InternalField_2422.objectReferenceValue = null;
            }
            else
            {
                InternalMethod_834();
            }
        }

        private void InternalMethod_834()
        {
            if (!(InternalField_2423.boolValue && InternalField_2422.objectReferenceValue is UIBlock scrollbarBlock))
            {
                return;
            }

            Scroller InternalVar_1 = target as Scroller;

            if (!scrollbarBlock.TryGetComponent(out Interactable InternalVar_2))
            {
                bool InternalVar_3 = EditorUtility.DisplayDialog($"Scrollbar missing {nameof(Interactable)} Component", $"The scrollbar must have an {nameof(Interactable)} component in order to be draggable.\n\nWould you like to add an {nameof(Interactable)} component to the scrollbar?", "Yes", "No");

                if (InternalVar_3)
                {
                    InternalVar_2 = Undo.AddComponent<Interactable>(scrollbarBlock.gameObject);

                    if (InternalVar_1.UIBlock.AutoLayout.Enabled && InternalVar_1.UIBlock.AutoLayout.Axis != Axis.None)
                    {
                        ThreeD<bool> InternalVar_4 = new ThreeD<bool>();
                        InternalVar_4[InternalVar_1.UIBlock.AutoLayout.Axis.Index()] = true;
                        InternalVar_2.Draggable = InternalVar_4;
                    }
                }
            }

            if (InternalVar_2 == null)
            {
                return;
            }

            if (!InternalVar_1.UIBlock.AutoLayout.Enabled || InternalVar_1.UIBlock.AutoLayout.Axis == Axis.None)
            {
                return;
            }

            Axis InternalVar_5 = InternalVar_1.UIBlock.AutoLayout.Axis;
            ThreeD<bool> InternalVar_6 = InternalVar_2.Draggable;
            if (!InternalVar_6[InternalVar_5.Index()])
            {
                bool InternalVar_7 = EditorUtility.DisplayDialog($"Scrollbar not marked draggable", $"The {nameof(Interactable)} on the scrollbar must be marked as draggable on the scrolling axis.\n\nWould you like to make the scrollbar's {nameof(Interactable)} draggable on {InternalVar_1.UIBlock.AutoLayout.Axis}?", "Yes", "No");

                if (InternalVar_7)
                {
                    InternalVar_6[InternalVar_5.Index()] = true;

                    Undo.RecordObject(InternalVar_2, "Mark scrollbar draggable");
                    InternalVar_2.Draggable = InternalVar_6;
                }
            }
        }

        private void InternalMethod_2180()
        {
            InternalField_2404.Clear();

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_2385.Count; ++InternalVar_1)
            {
                if (InternalField_2385[InternalVar_1].ScrollbarVisual == null)
                {
                    continue;
                }

                InternalField_2404.Add(InternalField_2385[InternalVar_1].ScrollbarVisual);
            }
        }
    }
}
