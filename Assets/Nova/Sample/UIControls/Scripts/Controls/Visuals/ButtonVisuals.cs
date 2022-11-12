using Nova;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace NovaSamples.UIControls
{
    /// <summary>
    /// An <see cref="ItemVisuals"/> for a simple button control.
    /// </summary>
    [System.Serializable]
    [MovedFrom(false, null, "Assembly-CSharp")]
    public class ButtonVisuals : ItemVisuals
    {
        [Header("Styles")]
        [Tooltip("The default Background color.")]
        public Color DefaultColor;
        [Tooltip("The color to apply to the Background when this button is hovered.")]
        public Color HoveredColor;
        [Tooltip("The color to apply to the Background when this button is pressed.")]
        public Color PressedColor;

        [Tooltip("The button's background UIBlock.")]
        public UIBlock2D Background = null;
        [Tooltip("The TextBlock to display the button's label.")]
        public TextBlock Label = null;

        /// <summary>
        /// A utility method to indicate a hovered visual state of <see cref="ButtonVisuals"/> object.
        /// </summary>
        /// <param name="evt">The hover event.</param>
        /// <param name="button">The <see cref="ItemVisuals"/> receiving the press event.</param>
        /// <param name="index">Unused here, but this is the index into the data source of list view invoking this event.</param>
        public static void HandleHovered(Gesture.OnHover evt, ButtonVisuals button, int index) => HandleHovered(evt, button);

        /// <summary>
        /// A utility method to indicate a hovered visual state of <see cref="ButtonVisuals"/> object.
        /// </summary>
        /// <param name="evt">The hover event.</param>
        /// <param name="button">The <see cref="ItemVisuals"/> receiving the press event.</param>
        public static void HandleHovered(Gesture.OnHover evt, ButtonVisuals button)
        {
            button.Background.Color = button.HoveredColor;
        }

        /// <summary>
        /// A utility method to restore the visual state of <see cref="ButtonVisuals"/> object when it's unhovered.
        /// </summary>
        /// <param name="evt">The unhover event.</param>
        /// <param name="button">The <see cref="ItemVisuals"/> receiving the press event.</param>
        /// <param name="index">Unused here, but this is the index into the data source of list view invoking this event.</param>
        public static void HandleUnhovered(Gesture.OnUnhover evt, ButtonVisuals button, int index) => HandleUnhovered(evt, button);

        /// <summary>
        /// A utility method to restore the visual state of <see cref="ButtonVisuals"/> object when it's unhovered.
        /// </summary>
        /// <param name="evt">The unhover event.</param>
        /// <param name="button">The <see cref="ItemVisuals"/> receiving the press event.</param>
        public static void HandleUnhovered(Gesture.OnUnhover evt, ButtonVisuals button)
        {
            button.Background.Color = button.DefaultColor;
        }

        /// <summary>
        /// A utility method to indicate a pressed visual state of <see cref="ButtonVisuals"/> object.
        /// </summary>
        /// <param name="evt">The press event.</param>
        /// <param name="button">The <see cref="ItemVisuals"/> receiving the press event.</param>
        /// <param name="index">Unused here, but this is the index into the data source of list view invoking this event.</param>
        public static void HandlePressed(Gesture.OnPress evt, ButtonVisuals button, int index) => HandlePressed(evt, button);

        /// <summary>
        /// A utility method to indicate a pressed visual state of <see cref="ButtonVisuals"/> object.
        /// </summary>
        /// <param name="evt">The press event.</param>
        /// <param name="button">The <see cref="ItemVisuals"/> receiving the press event.</param>
        public static void HandlePressed(Gesture.OnPress evt, ButtonVisuals button)
        {
            button.Background.Color = button.PressedColor;
        }

        /// <summary>
        /// A utility method to restore the visual state of <see cref="ButtonVisuals"/> object when its active gesture is released.
        /// </summary>
        /// <param name="evt">The release event.</param>
        /// <param name="button">The <see cref="ItemVisuals"/> receiving the release event.</param>
        /// <param name="index">Unused here, but this is the index into the data source of list view invoking this event.</param>
        public static void HandleReleased(Gesture.OnRelease evt, ButtonVisuals button, int index) => HandleReleased(evt, button);

        /// <summary>
        /// A utility method to restore the visual state of <see cref="ButtonVisuals"/> object when its active gesture is released.
        /// </summary>
        /// <param name="evt">The release event.</param>
        /// <param name="button">The <see cref="ItemVisuals"/> receiving the release event.</param>
        public static void HandleReleased(Gesture.OnRelease evt, ButtonVisuals button)
        {
            button.Background.Color = evt.Hovering ? button.HoveredColor : button.DefaultColor;
        }

        /// <summary>
        /// A utility method to restore the visual state of <see cref="ButtonVisuals"/> object when its active gesture is canceled.
        /// </summary>
        /// <param name="evt">The cancel event.</param>
        /// <param name="button">The <see cref="ItemVisuals"/> receiving the cancel gesture event.</param>
        /// <param name="index">Unused here, but this is the index into the data source of list view invoking this event.</param>
        public static void HandlePressCanceled(Gesture.OnCancel evt, ButtonVisuals button, int index) => HandlePressCanceled(evt, button);

        /// <summary>
        /// A utility method to restore the visual state of <see cref="ButtonVisuals"/> object when its active gesture is canceled.
        /// </summary>
        /// <param name="evt">The cancel event.</param>
        /// <param name="button">The <see cref="ItemVisuals"/> receiving the cancel gesture event.</param>
        public static void HandlePressCanceled(Gesture.OnCancel evt, ButtonVisuals button)
        {
            button.Background.Color = button.DefaultColor;
        }
    }
}
