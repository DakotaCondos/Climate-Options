
using Nova.Compat;
using Nova.InternalNamespace_16;
using Nova.InternalNamespace_25;
using Nova.InternalNamespace_0;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Collections.Generic;
using UnityEngine;

namespace Nova
{
    /// <summary>
    /// Defines on which event a "click" should be triggered
    /// </summary>
    public enum ClickBehavior
    {
        /// <summary>
        /// On release, correlated with a pointer up event
        /// </summary>
        OnRelease,
        /// <summary>
        /// On press, correlated with a pointer down event
        /// </summary>
        OnPress,
        /// <summary>
        /// Don't trigger "click" events
        /// </summary>
        None,
    }

    /// <summary>
    /// The animation applied to content once it's scrolled past the edges of its viewport
    /// </summary>
    public enum OverscrollEffect
    {
        /// <summary>
        /// An iOS-like bounce effect
        /// </summary>
        Bounce,
        /// <summary>
        /// A stay-in-bounds effect
        /// </summary>
        Clamp
    };

    /// <summary>
    /// An abstract base class for gesture/interaction receiver components
    /// </summary>
    [DisallowMultipleComponent, RequireComponent(typeof(UIBlock))]
    public abstract class GestureRecognizer : MonoBehaviour
    {
        /// <summary>
        /// When <c>ObstructDrags == <see langword="true"/></c>, drag gestures will not be routed to content behind the attached <see cref="UIBlock"/>.<br/>
        /// When false, content behind the attached <see cref="UIBlock"/> can receive drag gestures if it is <i>draggable</i> in a direction this component is not.
        /// </summary>
        /// <remarks>Does not impact the <i>draggable</i> state of this component.</remarks>
        [SerializeField]
        public bool ObstructDrags = false;

        /// <summary>
        /// The threshold that must be surpassed to initiate a drag event.
        /// </summary>
        /// <remarks>This threshold is generally used for high precision input devices, E.g. mouse, touchscreen, XR controller, and most other <b>ray</b> based input.</remarks>
        /// <see cref="InputAccuracy"/>
        /// <see cref="LowAccuracyDragThreshold"/>
        [SerializeField]
        public float DragThreshold = 1;

        /// <summary>
        /// The threshold that must be surpassed to initiate a drag event with a less physically stable input device.
        /// </summary>
        /// <remarks>
        /// This "Low Accuracy" threshold is generally used for lower accuracy input devices, E.g. XR hand tracking and other <b>sphere collider</b> based input.<br/><br/>
        /// To get the most reliable behavior between potentially conflicting press, drag,
        /// and scroll gestures while using the <see cref="Interaction.Point(Sphere, uint, object, int, InputAccuracy)"/> path,
        /// the entry point of the overlapping target <see cref="UIBlock"/>s
        /// <b>must</b> all be coplanar. If the entry points aren't coplanar, say a scrollable <see cref="ListView"/>'s 
        /// front face is positioned behind a draggable list item's front face, attempts to scroll the <see cref="ListView"/>
        /// will likely fail, and the list item will be dragged instead.
        /// </remarks>
        /// <see cref="InputAccuracy"/>
        /// <see cref="DragThreshold"/>
        [SerializeField]
        public float LowAccuracyDragThreshold = 30;

        /// <summary>
        /// Determines when this interactable should trigger click events
        /// </summary>
        /// <seealso cref="Gesture.OnClick"/>
        [SerializeField]
        public ClickBehavior ClickBehavior = ClickBehavior.OnRelease;

        /// <summary>
        /// The attached <see cref="Nova.UIBlock"/> receiving the interaction events, <see cref="IEvent.Receiver"/>
        /// </summary>
        public UIBlock UIBlock
        {
            get
            {
                if (InternalField_2995 == null)
                {
                    InternalField_2995 = GetComponent<UIBlock>();
                }

                return InternalField_2995;
            }
        }

        /// <summary>
        /// Prevent users from inherting
        /// </summary>
        internal GestureRecognizer() { }


        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_14.InternalType_12 InternalField_2415 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private protected InternalType_14.InternalType_12 InternalProperty_766
        {
            get
            {
                if (InternalField_2415 == null)
                {
                    InternalField_2415 = InternalMethod_158;
                }

                return InternalField_2415;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_14.InternalType_25 InternalField_2439 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private protected InternalType_14.InternalType_25 InternalProperty_770
        {
            get
            {
                if (InternalField_2439 == null)
                {
                    InternalField_2439 = InternalMethod_156;
                }

                return InternalField_2439;
            }
        }
        #endregion

        [System.NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private UIBlock InternalField_2995 = null;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private protected bool InternalProperty_911 => UIBlock.InternalProperty_25 && isActiveAndEnabled;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private protected virtual bool InternalProperty_937 => false;

        private protected struct InternalType_492
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_2810;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_2811;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_2809;

            public override string ToString()
            {
                return $"State(H: {InternalField_2810}, P: {InternalField_2811}, D: {InternalField_2809})";
            }
        }

        [System.NonSerialized, HideInInspector]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<uint, InternalType_492> InternalField_2817 = new Dictionary<uint, InternalType_492>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private protected Dictionary<uint, InternalType_492> InternalProperty_921 => InternalField_2817;

        [System.NonSerialized, HideInInspector]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private List<uint> InternalField_2816 = new List<uint>();

        [System.NonSerialized, HideInInspector]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_2818 = int.MaxValue;

        private void OnEnable()
        {
            InternalMethod_2750();
        }

        private void OnDisable()
        {
            while (InternalField_2816.Count > 0)
            {
                uint InternalVar_1 = InternalField_2816[InternalField_2816.Count - 1];

                if (!UIBlock.InternalProperty_23.InternalMethod_465(InternalVar_1, out InternalNamespace_0.InternalType_78 InternalVar_2))
                {
                    InternalVar_2 = new InternalNamespace_0.InternalType_78(InternalVar_1);
                }

                InternalType_14.InternalType_13 InternalVar_3 = InternalType_14.InternalMethod_191(UIBlock, InternalVar_2);
                InternalMethod_156(ref InternalVar_3);
            }

            InternalMethod_2664();
        }
        private void InternalMethod_158(ref InternalType_14.InternalType_16<bool> InternalParameter_100)
        {
            if (!isActiveAndEnabled)
            {
                return;
            }

            InternalType_76<bool>? InternalVar_1 = InternalParameter_100.InternalField_67;
            InternalType_76<bool> InternalVar_2 = InternalVar_1.GetValueOrDefault();
            InternalType_76<bool>? InternalVar_3 = InternalParameter_100.InternalField_70;
            InternalType_76<bool> InternalVar_4 = InternalVar_3.GetValueOrDefault();

            uint InternalVar_5 = InternalParameter_100.InternalField_3029.InternalField_257;

            bool InternalVar_7 = InternalField_2817.TryGetValue(InternalVar_5, out InternalType_492 InternalVar_6);

            bool InternalVar_8 = InternalVar_1.HasValue;
            bool InternalVar_9 = InternalVar_2.InternalField_247;

            if (InternalVar_2.InternalField_246)
            {
                InternalMethod_1884(InternalVar_2.InternalField_248, ref InternalVar_6, ref InternalParameter_100.InternalField_3029);
            }

            bool InternalVar_10 = InternalVar_4.InternalField_248 != InternalVar_2.InternalField_248;

            if (InternalVar_8 && InternalVar_10 && InternalVar_6.InternalField_2810 && (InternalVar_2.InternalField_246 || InternalVar_9))
            {
                InternalMethod_2737(InternalVar_2.InternalField_248, ref InternalParameter_100.InternalField_3029);
            }

            if (InternalVar_6.InternalField_2810 && InternalVar_9)
            {
                InternalMethod_2656(InternalVar_2.InternalField_248, ref InternalVar_6, ref InternalParameter_100.InternalField_3029);
            }

            InternalMethod_155(ref InternalParameter_100, ref InternalVar_6);

            if (InternalVar_6.InternalField_2811 && !InternalVar_9)
            {
                InternalMethod_2621(ref InternalVar_6, InternalVar_2.InternalField_246, InternalVar_8, ref InternalParameter_100.InternalField_3029);
            }

            if (InternalVar_6.InternalField_2810 && !InternalVar_2.InternalField_246 && !InternalVar_9)
            {
                InternalMethod_470(ref InternalVar_6, ref InternalParameter_100.InternalField_3029);
            }

            if (InternalVar_8 && InternalField_2816.Contains(InternalVar_5) == InternalVar_7)
            {
                if (!InternalVar_7)
                {
                    InternalField_2816.Add(InternalVar_5);
                }

                InternalField_2817[InternalVar_5] = InternalVar_6;
            }
            else if (InternalVar_7)
            {
                InternalField_2817.Remove(InternalVar_5);
                InternalField_2816.Remove(InternalVar_5);
            }
        }

        private void InternalMethod_156(ref InternalType_14.InternalType_13 InternalParameter_99)
        {
            if (!InternalField_2817.TryGetValue(InternalParameter_99.InternalField_69.InternalField_257, out InternalType_492 InternalVar_1))
            {
                return;
            }

            InternalField_2817.Remove(InternalParameter_99.InternalField_69.InternalField_257);
            InternalField_2816.Remove(InternalParameter_99.InternalField_69.InternalField_257);

            if (InternalVar_1.InternalField_2810 || InternalVar_1.InternalField_2811 || InternalVar_1.InternalField_2809 || InternalProperty_937)
            {
                InternalMethod_2662(ref InternalParameter_99.InternalField_69);

                UIBlock.InternalMethod_91(Gesture.InternalMethod_3197(InternalParameter_99.InternalField_69.InternalMethod_2179(), UIBlock));
            }
        }

        private void InternalMethod_1884(Vector3 InternalParameter_2146, ref InternalType_492 InternalParameter_29, ref InternalNamespace_0.InternalType_78 InternalParameter_28)
        {
            if (InternalParameter_29.InternalField_2810)
            {
                return;
            }

            InternalParameter_29.InternalField_2810 = true;


            UIBlock.InternalMethod_91(Gesture.InternalMethod_3266(InternalParameter_28.InternalMethod_2179(), UIBlock, InternalParameter_2146));
        }

        private void InternalMethod_470(ref InternalType_492 InternalParameter_27, ref InternalNamespace_0.InternalType_78 InternalParameter_26)
        {
            if (!InternalParameter_27.InternalField_2810)
            {
                return;
            }


            UIBlock.InternalMethod_91(Gesture.InternalMethod_3265(InternalParameter_26.InternalMethod_2179(), UIBlock));
            InternalParameter_27.InternalField_2810 = false;
        }

        private void InternalMethod_2656(Vector3 InternalParameter_25, ref InternalType_492 InternalParameter_24, ref InternalNamespace_0.InternalType_78 InternalParameter_23)
        {
            if (InternalParameter_24.InternalField_2811)
            {
                return;
            }

            InternalField_2818 = Time.frameCount;

            InternalParameter_24.InternalField_2811 = true;


            UIBlock.InternalMethod_91(Gesture.InternalMethod_3264(InternalParameter_23.InternalMethod_2179(), UIBlock, InternalParameter_25));

            if (!InternalParameter_24.InternalField_2809 && ClickBehavior == ClickBehavior.OnPress)
            {

                UIBlock.InternalMethod_91(Gesture.InternalMethod_3226(InternalParameter_23.InternalMethod_2179(), UIBlock));
            }
        }

        private void InternalMethod_2621(ref InternalType_492 InternalParameter_22, bool InternalParameter_909, bool InternalParameter_908, ref InternalNamespace_0.InternalType_78 InternalParameter_907)
        {
            if (!InternalParameter_22.InternalField_2811)
            {
                return;
            }

            Gesture.OnRelease InternalVar_1 = Gesture.InternalMethod_3227(InternalParameter_907.InternalMethod_2179(), UIBlock, InternalParameter_909, InternalParameter_22.InternalField_2809);

            UIBlock.InternalMethod_91(InternalVar_1);

            if (!InternalParameter_909)
            {
                InternalMethod_470(ref InternalParameter_22, ref InternalParameter_907);
            }

            bool InternalVar_2 = Time.frameCount - InternalField_2818 >= InternalNamespace_0.InternalType_24.InternalProperty_945.InternalField_2768;

            InternalField_2818 = int.MaxValue;

            InternalParameter_22.InternalField_2811 = false;

            if (InternalParameter_908 && InternalParameter_909 && !InternalParameter_22.InternalField_2809 && ClickBehavior == ClickBehavior.OnRelease)
            {
                if (InternalVar_2)
                {

                    UIBlock.InternalMethod_91(Gesture.InternalMethod_3226(InternalParameter_907.InternalMethod_2179(), UIBlock));
                }
                else
                {
                    InternalType_14.InternalType_13 InternalVar_3 = InternalType_14.InternalMethod_191(UIBlock, InternalParameter_907);
                    InternalMethod_156(ref InternalVar_3);
                }
            }

            InternalMethod_2661(ref InternalParameter_22, ref InternalVar_1);
            InternalParameter_22.InternalField_2809 = false;
        }

        private protected virtual void InternalMethod_2661(ref InternalType_492 InternalParameter_906, ref Gesture.OnRelease InternalParameter_951) { }
        private protected virtual void InternalMethod_2662(ref InternalNamespace_0.InternalType_78 InternalParameter_1327) { }

        private void InternalMethod_2737(Vector3 InternalParameter_1326, ref InternalNamespace_0.InternalType_78 InternalParameter_1289)
        {

            UIBlock.InternalMethod_91(Gesture.InternalMethod_3267(InternalParameter_1289.InternalMethod_2179(), UIBlock, InternalParameter_1326));
        }

        private protected abstract void InternalMethod_155(ref InternalType_14.InternalType_16<bool> InternalParameter_98, ref InternalType_492 InternalParameter_97);

        private protected abstract void InternalMethod_2750();
        private protected abstract void InternalMethod_2664();
    }

    internal interface InternalType_493 : InternalType_523, InternalType_273, InternalType_75 { }

    /// <summary>
    /// Triggers pointer-based gesture events (e.g. hover, click, drag, etc.) on the attached <see cref="UIBlock"/>
    /// </summary>
    /// <seealso cref="Gesture.OnClick"/>
    /// <seealso cref="Gesture.OnPress"/>
    /// <seealso cref="Gesture.OnRelease"/>
    /// <seealso cref="Gesture.OnHover"/>
    /// <seealso cref="Gesture.OnUnhover"/>
    /// <seealso cref="Gesture.OnMove"/>
    /// <seealso cref="Gesture.OnDrag"/>
    /// <seealso cref="Gesture.OnCancel"/>

    [AddComponentMenu("Nova/Interactable")]
    [HelpURL("https://novaui.io/manual/InputOverview.html#interactable--scroller")]
    public sealed class Interactable : GestureRecognizer, InternalType_493
    {
        [SerializeField, InternalType_22]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private ThreeD<bool> draggable = false;

        /// <summary>
        /// Acts as a bit-mask indicating which axes can trigger drag events once a "drag threshold" is surpassed.
        /// </summary>
        /// <remarks>if <c><see cref="Draggable"/>[axis]</c> is <c><see langword="false"/></c>, the "drag threshold" along that <c>axis</c> is infinite and will never trigger a drag event.</remarks>
        /// <seealso cref="GestureRecognizer.DragThreshold"/>
        /// <seealso cref="GestureRecognizer.LowAccuracyDragThreshold"/>
        /// <seealso cref="Gesture.OnDrag"/>
        public ThreeD<bool> Draggable
        {
            get
            {
                return draggable;
            }
            set
            {
                if (draggable.Equals(value))
                {
                    return;
                }

                if (isActiveAndEnabled)
                {
                    if (draggable.InternalMethod_3291(true) && value.InternalMethod_3292(false))
                    {
                        UIBlock.InternalProperty_23.InternalMethod_461(this);
                    }

                    if (draggable.InternalMethod_3292(false) && value.InternalMethod_3291(true))
                    {
                        UIBlock.InternalProperty_23.InternalMethod_460(this);
                    }
                }

                draggable = value;
            }
        }

        [System.NonSerialized, HideInInspector]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<uint, Vector3> InternalField_2933 = new Dictionary<uint, Vector3>();

        private protected override void InternalMethod_2750()
        {
            UIBlock.InternalMethod_89(this);

            if (Draggable.InternalMethod_3291(true))
            {
                UIBlock.InternalProperty_23.InternalMethod_460(this);
            }

            UIBlock.InternalProperty_23.InternalEvent_2 += InternalProperty_766;
            UIBlock.InternalProperty_23.InternalEvent_4 += InternalProperty_770;
        }

        private protected override void InternalMethod_2664()
        {
            UIBlock.InternalMethod_90(this);

            if (Draggable.InternalMethod_3291(true))
            {
                UIBlock.InternalProperty_23.InternalMethod_461(this);
            }

            UIBlock.InternalProperty_23.InternalEvent_2 -= InternalProperty_766;
            UIBlock.InternalProperty_23.InternalEvent_4 -= InternalProperty_770;
        }

        private protected override void InternalMethod_155(ref InternalType_14.InternalType_16<bool> InternalParameter_98, ref InternalType_492 InternalParameter_97)
        {
            if (!isActiveAndEnabled)
            {
                return;
            }

            InternalType_76<bool>? InternalVar_1 = InternalParameter_98.InternalField_67;
            InternalType_76<bool> InternalVar_2 = InternalVar_1.GetValueOrDefault();
            InternalType_76<bool>? InternalVar_3 = InternalParameter_98.InternalField_70;
            InternalType_76<bool> InternalVar_4 = InternalVar_3.GetValueOrDefault();

            bool InternalVar_5 = InternalVar_1.HasValue;
            bool InternalVar_6 = InternalVar_4.InternalField_248 != InternalVar_2.InternalField_248;

            if (InternalVar_5 && InternalVar_6 && InternalParameter_97.InternalField_2811 && InternalVar_2.InternalProperty_166)
            {
                Vector3 InternalVar_7 = InternalVar_3.HasValue ? InternalVar_4.InternalField_248 : InternalVar_2.InternalField_248;
                InternalMethod_2663(ref InternalParameter_97, InternalVar_7, InternalVar_2.InternalField_248, ref InternalParameter_98.InternalField_3029);
            }
        }

        private protected override void InternalMethod_2661(ref InternalType_492 InternalParameter_906, ref Gesture.OnRelease InternalParameter_951)
        {
            InternalField_2933.Remove(InternalParameter_951.Interaction.ControlID);
        }

        private protected override void InternalMethod_2662(ref InternalNamespace_0.InternalType_78 interaction)
        {
            InternalField_2933.Remove(interaction.InternalField_257);
        }

        private void InternalMethod_2663(ref InternalType_492 InternalParameter_712, Vector3 InternalParameter_713, Vector3 InternalParameter_714, ref InternalNamespace_0.InternalType_78 InternalParameter_330)
        {
            if (!InternalParameter_712.InternalField_2809)
            {
                InternalField_2933.Add(InternalParameter_330.InternalField_257, InternalParameter_714);
                InternalParameter_712.InternalField_2809 = true;
            }

            Gesture.Positions InternalVar_1 = new Gesture.Positions()
            {
                Start = InternalField_2933[InternalParameter_330.InternalField_257],
                Previous = InternalParameter_713,
                Current = InternalParameter_714
            };


            UIBlock.InternalMethod_91(Gesture.InternalMethod_3198(InternalParameter_330.InternalMethod_2179(), UIBlock, ref InternalVar_1, Draggable));
        }

        InternalType_77 InternalType_75.InternalMethod_3340<T>(Ray InternalParameter_329, InternalType_76<T> InternalParameter_328, InternalType_76<T> InternalParameter_2232, Transform InternalParameter_2233)
        {
            InternalType_77 InternalVar_1 = InternalType_77.InternalField_251;

            if (typeof(T) != typeof(bool))
            {
                return InternalVar_1;
            }

            Vector3 InternalVar_2 = InternalType_728.InternalMethod_3283(Draggable);

            if (InternalVar_2 != Vector3.zero)
            {
                Vector3 InternalVar_3 = UIBlock.transform.TransformDirection(InternalVar_2.normalized);
                Vector3 InternalVar_4 = InternalParameter_329.direction;
                Vector3 InternalVar_5 = InternalParameter_329.origin;
                Vector3 InternalVar_6 = Vector3.Cross(InternalVar_4, InternalVar_3);

                if (InternalVar_6 == Vector3.zero)
                {
                    InternalVar_2 = !Draggable.X ? Vector3.right : !Draggable.Y ? Vector3.up : Vector3.forward;
                    InternalVar_4 = UIBlock.transform.TransformDirection(InternalVar_2);
                    InternalVar_5 = InternalParameter_328.InternalField_248;
                    InternalVar_6 = Vector3.Cross(InternalVar_4, InternalVar_3);
                }

                Vector3 InternalVar_7 = InternalType_187.InternalMethod_881(InternalParameter_2232.InternalField_248 - InternalVar_5);
                float InternalVar_8 = InternalType_187.InternalMethod_907(InternalVar_4, InternalVar_7, InternalVar_6);
                InternalVar_8 = Mathf.Min(InternalVar_8, 180 - InternalVar_8);

                InternalVar_1 = InternalVar_8 >= InternalMethod_2350(ref InternalParameter_2232) ? InternalType_77.InternalField_255 : InternalType_77.InternalField_252;
            }

            return InternalVar_1;
        }

        private float InternalMethod_2350<T>(ref InternalType_76<T> InternalParameter_2157) where T : unmanaged, System.IEquatable<T> => InternalParameter_2157.InternalField_250 ? LowAccuracyDragThreshold : DragThreshold;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalType_75.InternalProperty_741 => ObstructDrags;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        System.Type InternalType_523.InternalProperty_439 => typeof(UIBlock);

        bool InternalType_523.InternalMethod_1635(InternalType_273 receiver, System.Type _, out InternalType_273 target)
        {
            target = UIBlock;
            return true;
        }

        #region 

        #endregion
    }
}
