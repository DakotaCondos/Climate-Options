using Nova;
using UnityEngine;
#if !ENABLE_LEGACY_INPUT_MANAGER
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;
#endif

namespace NovaSamples.UIControls
{
    /// <summary>
    /// Simple input manager example for the <see cref="TextField"/> sample.
    /// </summary>
    public class InputManager : MonoBehaviour
    {
        /// <summary>
        /// Fired after mouse clicks. Can be used to determine when focus is lost.
        /// </summary>
        public static System.Action<UIBlock> OnPostClick;

        [Header("Mouse")]
        [SerializeField]
        [Tooltip("Handle mouse input events.")]
        private bool mouseEnabled = true;
        [SerializeField]
        [Tooltip("Inverts the mouse wheel scroll direction.")]
        private bool invertScrolling = true;

        [Header("Touch")]
        [SerializeField]
        [Tooltip("Handle touch input events.")]
        private bool touchEnabled = true;

        [Space]
        [SerializeField]
        private Camera cam = null;

        private void OnEnable()
        {
            if (cam == null)
            {
                cam = Camera.current;
            }

            if (cam == null)
            {
                cam = Camera.main;
            }

#if !ENABLE_LEGACY_INPUT_MANAGER
            EnhancedTouchSupport.Enable();
#endif
        }

        private void Update()
        {
            UpdateMouse();
            UpdateTouch();
        }

#region Mouse
        private const uint MousePointerControlID = 1;
        private const uint ScrollWheelControlID = 2;

#if ENABLE_LEGACY_INPUT_MANAGER
        private bool MousePresent => Input.mousePresent;
        private Vector2 MousePosition => Input.mousePosition;
        private Vector2 MouseScrollDelta => Input.mouseScrollDelta;
        private bool LeftMouseButtonValue => Input.GetMouseButton(0);
        private bool LeftMouseButtonUp => Input.GetMouseButtonUp(0);
#else
        private bool MousePresent => Mouse.current != null;
        private Vector2 MousePosition => Mouse.current.position.ReadValue();
        private Vector2 MouseScrollDelta => Mouse.current.scroll.ReadValue().normalized;
        private bool LeftMouseButtonValue => Mouse.current.leftButton.isPressed;
        private bool LeftMouseButtonUp => Mouse.current.leftButton.wasReleasedThisFrame;
#endif

        private void UpdateMouse()
        {
            if (!(mouseEnabled && MousePresent))
            {
                return;
            }

            
            // Get the current world-space ray of the mouse
            Ray mouseRay = cam.ScreenPointToRay(MousePosition);

            // Get the current scroll wheel delta
            Vector2 mouseScrollDelta = MouseScrollDelta;

            if (mouseScrollDelta != Vector2.zero)
            {
                // Invert scrolling for a mouse-type experience,
                // otherwise will scroll track-pad style.
                if (invertScrolling)
                {
                    mouseScrollDelta.y *= -1f;
                }

                // Create a new Interaction.Update from the mouse ray and scroll wheel control id
                Interaction.Update scrollInteraction = new Interaction.Update(mouseRay, ScrollWheelControlID);

                // Feed the scroll update and scroll delta into Nova's Interaction APIs
                Interaction.Scroll(scrollInteraction, mouseScrollDelta);
            }

            // Create a new Interaction.Update from the mouse ray and pointer control id
            Interaction.Update pointInteraction = new Interaction.Update(mouseRay, MousePointerControlID);

            // Feed the pointer update and pressed state to Nova's Interaction APIs
            Interaction.Point(pointInteraction, LeftMouseButtonValue);

            if (LeftMouseButtonUp)
            {
                // If the mouse button was released this frame, fire the OnPostClick
                // event with the hit UIBlock (or null if there wasn't one)
                Interaction.TryGetActiveReceiver(MousePointerControlID, out UIBlockHit hit);
                OnPostClick?.Invoke(hit.UIBlock);
            }
        }
        #endregion

        #region Touch

#if ENABLE_LEGACY_INPUT_MANAGER
        private bool TouchSupported => Input.touchSupported;
        private int TouchCount => Input.touchCount;
        private Touch GetTouch(int index) => Input.GetTouch(index);
        private Vector2 GetTouchPosition(Touch touch) => touch.position;
        private uint GetTouchID(Touch touch) => (uint)touch.fingerId;
#else
        private bool TouchSupported => Touchscreen.current != null;
        private int TouchCount => Touch.activeTouches.Count;
        private Touch GetTouch(int index) => Touch.activeTouches[index];
        private Vector2 GetTouchPosition(Touch touch) => touch.screenPosition;
        private uint GetTouchID(Touch touch) => (uint)touch.touchId;
#endif

        private void UpdateTouch()
        {
            if (!touchEnabled || !TouchSupported)
            {
                return;
            }

            for (int i = 0; i < TouchCount; i++)
            {
                Touch touch = GetTouch(i);

                // Convert the touch point to a world-space ray.
                Ray ray = Camera.main.ScreenPointToRay(GetTouchPosition(touch));

                // Create a new Interaction from the ray and the finger's ID
                Interaction.Update update = new Interaction.Update(ray, GetTouchID(touch));

                // Get the current touch phase
                TouchPhase touchPhase = touch.phase;

                // If the touch phase hasn't ended and hasn't been canceled, then pointerDown == true.
                bool pointerDown = touchPhase != TouchPhase.Canceled && touchPhase != TouchPhase.Ended;

                // Feed the update and pressed state to Nova's Interaction APIs
                Interaction.Point(update, pointerDown);

                if (!pointerDown)
                {
                    // If the finger is off the screen, send a follow up hover that
                    // won't hit anything and cancel to indicate the interaction is over.
                    // This is to assist with cross platform compatibility for hover events,
                    // since touch events are driven by press/release and don't provide the same
                    // kind of "pointer exit" data as an unpressed mouse pointer
                    update.Ray = default;
                    Interaction.Point(update, false);
                    Interaction.Cancel(update);
                }
            }
        }
#endregion
    }
}

