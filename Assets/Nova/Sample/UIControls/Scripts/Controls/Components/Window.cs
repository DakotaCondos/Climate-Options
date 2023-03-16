using Nova;
using UnityEngine;

namespace NovaSamples.UIControls
{
    /// <summary>
    /// A simple positionable and resizable window component
    /// </summary>
    /// <seealso cref="WindowBar"/>
    /// <seealso cref="WindowResizeRegion"/>
    [RequireComponent(typeof(UIBlock))]
    public class Window : MonoBehaviour
    {
        /// <summary>
        /// The <see cref="UIBlock"/> attached to this game object. 
        /// </summary>
        private UIBlock uiBlock = null;

        /// <summary>
        /// The <see cref="UIBlock"/> attached to this game object. 
        /// </summary>
        public UIBlock UIBlock
        {
            get
            {
                if (uiBlock == null)
                {
                    uiBlock = GetComponent<UIBlock>();
                }
                return uiBlock;
            }
        }

        private void OnEnable()
        {
            // Subscribe to gestures
            UIBlock.AddGestureHandler<Gesture.OnDrag, WindowBar>(HandleWindowDragged);
            UIBlock.AddGestureHandler<Gesture.OnDrag, WindowResizeRegion>(HandleResizeRegionDragged);
            UIBlock.AddGestureHandler<Gesture.OnHover, WindowResizeRegion>(HandleResizeRegionHovered);
            UIBlock.AddGestureHandler<Gesture.OnUnhover, WindowResizeRegion>(HandleResizeRegionUnhovered);
        }

        private void OnDisable()
        {
            // Unsubscribe from gestures
            UIBlock.RemoveGestureHandler<Gesture.OnDrag, WindowBar>(HandleWindowDragged);
            UIBlock.RemoveGestureHandler<Gesture.OnDrag, WindowResizeRegion>(HandleResizeRegionDragged);
            UIBlock.RemoveGestureHandler<Gesture.OnHover, WindowResizeRegion>(HandleResizeRegionHovered);
            UIBlock.RemoveGestureHandler<Gesture.OnUnhover, WindowResizeRegion>(HandleResizeRegionUnhovered);

            // Restore the default cursor
            SetCursor(null);
        }

        /// <summary>
        /// Move this window by the amount it was dragged
        /// </summary>
        private void HandleWindowDragged(Gesture.OnDrag evt, WindowBar windowBar)
        {
            UIBlock.TrySetLocalPosition(UIBlock.transform.localPosition + evt.DragDeltaLocalSpace);
        }

        /// <summary>
        /// Resize the window from the draggable region
        /// </summary>
        private void HandleResizeRegionDragged(Gesture.OnDrag evt, WindowResizeRegion region)
        {
            // Determine which region was dragged based on its local position relative to the center of this window
            Vector3 regionLocalPosition = UIBlock.transform.InverseTransformPoint(region.View.transform.position);
            Vector3 regionVector = Sign(regionLocalPosition);

            // Adjust the window size
            Vector3 sizeDelta = Vector3.Scale(evt.DragDeltaLocalSpace, regionVector);
            Vector3 currentSize = UIBlock.CalculatedSize.Value;
            UIBlock.Size = currentSize + sizeDelta;

            // Adjust the window's position such that the opposite side of the drag region remains in the same position
            Vector3 rawPositionDelta = evt.DragDeltaLocalSpace * 0.5f;
            Vector3 positionDelta = ClampPositionDelta(rawPositionDelta, sizeDelta, currentSize, UIBlock.SizeMinMax);
            UIBlock.TrySetLocalPosition(UIBlock.transform.localPosition + positionDelta);
        }

        /// <summary>
        /// Change the cursor to indicate how the window will resize if it's clicked and draggged
        /// </summary>
        private void HandleResizeRegionHovered(Gesture.OnHover evt, WindowResizeRegion region)
        {
            SetCursor(region.Cursor);
        }

        /// <summary>
        /// Restore the cursor when a resize region is unhovered
        /// </summary>
        private void HandleResizeRegionUnhovered(Gesture.OnUnhover evt, WindowResizeRegion region)
        {
            SetCursor(null);
        }

        private static Vector3 Sign(Vector3 v) => new Vector3(Sign(v.x), Sign(v.y), Sign(v.z));

        /// <summary>
        /// Unity's <see cref="Mathf.Sign(float)"/> method returns <c>1</c> when the provided float <paramref name="f"/> is <c>0</c>.
        /// </summary>
        /// <param name="f">The float to check the sign of.</param>
        /// <returns>The sign of <paramref name="f"/>.</returns>
        private static float Sign(float f) => f < 0 ? -1 : f > 0 ? 1 : 0;

        /// <summary>
        /// Clamp the <paramref name="rawPositionDelta"/> such that the position only changes as much as the UIBlock is resized.
        /// </summary>
        /// <remarks>
        /// Handles the case where if the UIBlock has a minimum (or maximum) size, we don't want to continue moving the UIBlock once that minimum (or maximum) size is reached while the user is making the window smaller (or larger).
        /// </remarks>
        private static Vector3 ClampPositionDelta(Vector3 positionDelta, Vector3 sizeDelta, Vector3 currentSize, MinMax3 sizeRange)
        {
            return new Vector3(ClampPositionDelta(positionDelta.x, sizeDelta.x, currentSize.x, sizeRange.X),
                               ClampPositionDelta(positionDelta.y, sizeDelta.y, currentSize.y, sizeRange.Y),
                               ClampPositionDelta(positionDelta.z, sizeDelta.z, currentSize.z, sizeRange.Z));
        }

        /// <summary>
        /// Clamp the <paramref name="rawPositionDelta"/> such that the position only changes as much as the UIBlock is resized.
        /// </summary>
        /// <remarks>
        /// Handles the case where if the UIBlock has a minimum (or maximum) size, we don't want to continue moving the UIBlock once that minimum (or maximum) size is reached while the user is making the window smaller (or larger).
        /// </remarks>
        private static float ClampPositionDelta(float rawPositionDelta, float sizeDelta, float currentSize, MinMax range)
        {
            float clampedSizeDelta = range.Clamp(sizeDelta + currentSize) - currentSize;
            float clampedPositionDeltaRange = clampedSizeDelta * 0.5f;

            float min = Mathf.Min(clampedPositionDeltaRange, -clampedPositionDeltaRange);
            float max = Mathf.Max(clampedPositionDeltaRange, -clampedPositionDeltaRange);

            return Mathf.Clamp(rawPositionDelta, min, max);
        }

        /// <summary>
        /// Assign the cursor to a custom texture, or set it to null to restore the default cursor.
        /// </summary>
        /// <param name="cursorTexture">The texture to assign to the cursor</param>
        private static void SetCursor(Texture2D cursorTexture)
        {
            // offset is 0 if the texture is null, otherwise we want to center the cursor texture
            Vector2 offset = cursorTexture == null ? Vector2.zero : new Vector2(cursorTexture.width, cursorTexture.height) * 0.5f;

            Cursor.SetCursor(cursorTexture, offset, CursorMode.Auto);
        }
    }
}
