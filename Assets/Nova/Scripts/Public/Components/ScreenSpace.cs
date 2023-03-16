using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_10;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System;
using System.Reflection;
using UnityEngine;

namespace Nova
{
    /// <summary>
    /// Configures a <see cref="UIBlock"/> hierarchy to render in screen-space.
    /// </summary>
    [RequireComponent(typeof(UIBlock))]
    [RequireComponent(typeof(SortGroup))]
    [DisallowMultipleComponent]
    [AddComponentMenu("Nova/Screen Space")]
    [ExecuteAlways]
    [HelpURL("https://novaui.io/manual/ScreenSpace.html")]
    public class ScreenSpace : MonoBehaviour, InternalType_765
    {
        #region Public
        /// <summary>
        /// Configures how to resize a <see cref="Nova.UIBlock"/> to fill a camera's viewport.
        /// </summary>
        public enum FillMode
        {
            /// <summary>
            /// Maintain the width of the <see cref="UIBlock"/> at the <see cref="ReferenceResolution">ReferenceResolution</see> width, 
            /// adjusting the height to match the camera's aspect ratio.
            /// </summary>
            FixedWidth,
            /// <summary>
            /// Maintain the height of the <see cref="UIBlock"/> at the <see cref="ReferenceResolution">ReferenceResolution</see> height, 
            /// adjusting the width to match the camera's aspect ratio.
            /// </summary>
            FixedHeight,
            /// <summary>
            /// Set the <see cref="UIBlock">UIBlock's</see> <see cref="UIBlock.Size">Size</see> to the pixel-dimensions of the camera.
            /// </summary>
            MatchCameraResolution,
            /// <summary>
            /// Do not modify the <see cref="UIBlock">UIBlock's</see> <see cref="UIBlock.Size">Size</see> or scale.
            /// This can be used if you want to implement a custom resize behavior.
            /// </summary>
            Manual
        }

        /// <summary>
        /// The <see cref="Nova.UIBlock"/> on <c>this.gameObject</c> that will be positioned and sized to
        /// fill the <see cref="TargetCamera">TargetCamera</see>.
        /// </summary>
        public UIBlock UIBlock
        {
            get
            {
                if (InternalField_837 == null)
                {
                    InternalField_837 = GetComponent<UIBlock>();
                }

                return InternalField_837;
            }
        }

        /// <summary>
        /// The resolution to use as a reference when resizing the root UIBlock to match the camera's aspect ratio
        /// when <see cref="Mode">Mode</see> is set to <see cref="FillMode.FixedHeight"/> or <see cref="FillMode.FixedWidth"/>.
        /// </summary>
        public Vector2 ReferenceResolution
        {
            get => referenceResolution;
            set => referenceResolution = value;
        }

        /// <summary>
        /// The camera to render to.
        /// </summary>
        public Camera TargetCamera
        {
            get => targetCamera;
            set
            {
                if (targetCamera == value)
                {
                    return;
                }

                targetCamera = value;
                InternalMethod_1618();
            }
        }

        /// <summary>
        /// The <see cref="FillMode">FillMode</see> used for resizing <see cref="UIBlock">UIBlock</see> to fill
        /// <see cref="TargetCamera">TargetCamera</see>.
        /// </summary>
        public FillMode Mode
        {
            get => fillMode;
            set
            {
                fillMode = value;
            }
        }

        /// <summary>
        /// The distance in front of the camera at which to render the Nova content.
        /// </summary>
        public float PlaneDistance
        {
            get => planeDistance;
            set => planeDistance = value;
        }
        #endregion

        #region Internal
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Camera targetCamera = null;
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Vector2 referenceResolution = new Vector2(1920, 1080);
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private FillMode fillMode = FillMode.FixedWidth;
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float planeDistance = 1f;
        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private UIBlock InternalField_837 = null;
        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private SortGroup InternalField_1434 = null;
        [SerializeField]
        [HideInInspector]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool haveConfiguredSortGroup = false;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        int InternalType_765.InternalProperty_1156 => targetCamera.GetInstanceID();

        void InternalType_765.InternalMethod_3365() => InternalMethod_1617();

        private void OnEnable()
        {
            UIBlock.InternalMethod_116();

            if (InternalField_1434 == null)
            {
                InternalField_1434 = GetComponent<SortGroup>();
            }

            if (!haveConfiguredSortGroup)
            {
                haveConfiguredSortGroup = true;
                InternalField_1434.RenderOverOpaqueGeometry = true;
                InternalField_1434.RenderQueue = InternalType_776.InternalField_3710;
            }

            if (targetCamera == null)
            {
                targetCamera = Camera.main;
            }

            InternalMethod_1618();
        }

        private void OnDisable()
        {
            InternalMethod_1619(InternalField_837.InternalProperty_29);

            if (NovaApplication.IsEditor)
            {
                InternalType_131 InternalVar_1 = UIBlock.InternalProperty_29;
                NovaApplication.EditorDelayCall += () =>
                {
                    if (this == null)
                    {
                        InternalMethod_1619(InternalVar_1);
                    }
                };
            }
        }

        internal void InternalMethod_1618()
        {
            if (!UIBlock.InternalProperty_25 || !enabled)
            {
                return;
            }

            if (targetCamera != null)
            {
                InternalType_274.InternalProperty_190.InternalMethod_3647(UIBlock.InternalProperty_29, this);
            }
            else
            {
                InternalMethod_1619(UIBlock.InternalProperty_29);
            }
        }

        private void InternalMethod_1619(InternalType_131 InternalParameter_1753)
        {
            if (InternalType_274.InternalProperty_190 == null)
            {
                return;
            }

            InternalType_274.InternalProperty_190.InternalMethod_3648(InternalParameter_1753, this);
        }

        private void InternalMethod_1617(bool InternalParameter_1752 = false)
        {
            if (UIBlock == null || targetCamera == null)
            {
                return;
            }

            ref Layout InternalVar_1 = ref InternalField_837.Layout;

            InternalVar_1.Alignment = Alignment.Center;
            InternalVar_1.AutoSize = AutoSize.None;
            InternalVar_1.AspectRatioAxis = Axis.None;
            InternalVar_1.SizeMinMax = MinMax3.Unclamped;
            InternalVar_1.PositionMinMax = MinMax3.Unclamped;

            if (InternalParameter_1752)
            {
                InternalField_837.TrySetWorldPosition(targetCamera.transform.position + targetCamera.transform.forward * planeDistance);
            }
            else
            {
                InternalField_837.transform.position = targetCamera.transform.position + targetCamera.transform.forward * planeDistance;
            }

            InternalField_837.transform.rotation = targetCamera.transform.rotation;

            if (fillMode == FillMode.Manual)
            {
                return;
            }

            Vector2 InternalVar_2 = new Vector2(targetCamera.pixelWidth, targetCamera.pixelHeight);

            ref Length3 InternalVar_3 = ref InternalField_837.Size;
            switch (fillMode)
            {
                case FillMode.MatchCameraResolution:
                {
                    InternalVar_3.XY.Value = InternalVar_2;
                    break;
                }
                case FillMode.FixedHeight:
                {
                    InternalVar_3.Y.Value = ReferenceResolution.y;

                    float InternalVar_4 = InternalVar_2.x / InternalVar_2.y;
                    InternalVar_3.X.Value = InternalVar_4 * InternalVar_3.Y.Value;
                    break;
                }
                case FillMode.FixedWidth:
                {
                    InternalVar_3.X.Value = ReferenceResolution.x;

                    float InternalVar_4 = InternalVar_2.y / InternalVar_2.x;
                    InternalVar_3.Y.Value = InternalVar_4 * InternalVar_3.X.Value;
                    break;
                }
            }

            if (targetCamera.orthographic)
            {
                float InternalVar_4 = 2f * targetCamera.orthographicSize / InternalVar_3.Y.Value;
                InternalField_837.transform.localScale = new Vector3(InternalVar_4, InternalVar_4, InternalVar_4);
            }
            else
            {
                float InternalVar_4 = 2f * planeDistance * Mathf.Tan(.5f * targetCamera.fieldOfView * Mathf.Deg2Rad) / InternalVar_3.Y.Value;
                InternalField_837.transform.localScale = new Vector3(InternalVar_4, InternalVar_4, InternalVar_4);
            }
        }

        private void Reset()
        {
            InternalMethod_1617(InternalParameter_1752: true);
        }

        [Obfuscation]
        private void OnDidApplyAnimationProperties()
        {
            InternalMethod_1618();
        }
#endregion
    }
}
