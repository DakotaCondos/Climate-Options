using Nova;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace NovaSamples.UIControls
{
    /// <summary>
    /// The <see cref="ItemVisuals"/> type used to display a draggable <see cref="SliderSetting"/> control.
    /// </summary>
    [System.Serializable]
    [MovedFrom(false, null, "Assembly-CSharp")]
    public class SliderVisuals : ItemVisuals
    {
        [Tooltip("The draggable bounds of the slider control.")]
        public UIBlock2D DraggableRange = null;
        [Tooltip("The UIBlock2D within the SliderBounds to indicate the selected slider value.")]
        public UIBlock2D FillBar = null;
        [Tooltip("The UIBlock2D positioned at moving edge of a fill bar.")]
        public UIBlock2D Knob = null;
        [Tooltip("The Textblock used to display the numerical value and units of the slider's selected value.")]
        public TextBlock Units = null;

        [Header("Styles")]
        [Tooltip("The default Background color.")]
        public Color DefaultColor;
        [Tooltip("The color to apply to the Background when this slider is hovered.")]
        public Color HoveredColor;
        [Tooltip("The color to apply to the Background when this slider is pressed.")]
        public Color PressedColor;

        public static void HandleSliderHovered(Gesture.OnHover evt, SliderVisuals sliderVisuals)
        {
            sliderVisuals.Knob.Color = sliderVisuals.HoveredColor;
        }

        public static void HandleSliderUnhovered(Gesture.OnUnhover evt, SliderVisuals sliderVisuals)
        {
            sliderVisuals.Knob.Color = sliderVisuals.DefaultColor;
        }

        public static void HandleSliderReleased(Gesture.OnRelease evt, SliderVisuals sliderVisuals)
        {
            sliderVisuals.Knob.Color = evt.Hovering ? sliderVisuals.HoveredColor : sliderVisuals.DefaultColor;
        }

        public static void HandleSliderPressCanceled(Gesture.OnCancel evt, SliderVisuals sliderVisuals)
        {
            sliderVisuals.Knob.Color = sliderVisuals.DefaultColor;
        }
    }
}
