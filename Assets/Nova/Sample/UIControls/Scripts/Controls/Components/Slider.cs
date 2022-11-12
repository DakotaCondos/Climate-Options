using Nova;
using UnityEngine;
using UnityEngine.Events;

namespace NovaSamples.UIControls
{
    /// <summary>
    /// A UI control which reacts to user input and updates an underlying float value as it receives drag events.
    /// </summary>
    public class Slider : UIControl<SliderVisuals>
    {
        [Tooltip("Event fired when the slider value changes. Provides the new value.")]
        public UnityEvent<float> OnValueChanged = null;

        [Tooltip("If true, pressing anywhere in the draggable region will update the slider value (common on Desktop).\nIf false, the user must drag within the draggable region for the slider to update (common on Mobile).")]
        public bool UpdateOnPress = true;

        [SerializeField]
        [Tooltip("The numeric value associated with the slider.")]
        private float value;

        /// <summary>
        /// The numeric value associated with the slider.
        /// </summary>
        public float Value
        {
            get
            {
                return value;
            }
            set
            {
                // Clamp within range before assigning
                float clampedValue = Mathf.Clamp(value, Min, Max);

                if (this.value == clampedValue)
                {
                    return;
                }

                this.value = clampedValue;

                UpdateFillBar();

                // Notify listeners
                OnValueChanged?.Invoke(this.value);
            }
        }

        [SerializeField]
        [Tooltip("The mininum value for the given slider.")]
        private float Min = 0;
        [SerializeField]
        [Tooltip("The maximum value for the given slider.")]
        private float Max = 100;

        [SerializeField]
        [Tooltip("The string format to use when displaying the slider value to the end user.")]
        private string unitsFormat = "{0:0.00}";

        private void OnEnable()
        {
            // Subscribe to desired events
            View.UIBlock.AddGestureHandler<Gesture.OnHover, SliderVisuals>(SliderVisuals.HandleSliderHovered);
            View.UIBlock.AddGestureHandler<Gesture.OnUnhover, SliderVisuals>(SliderVisuals.HandleSliderUnhovered);
            View.UIBlock.AddGestureHandler<Gesture.OnPress, SliderVisuals>(HandleSliderPressed);
            View.UIBlock.AddGestureHandler<Gesture.OnRelease, SliderVisuals>(SliderVisuals.HandleSliderReleased);
            View.UIBlock.AddGestureHandler<Gesture.OnDrag, SliderVisuals>(HandleSliderDragged);
            View.UIBlock.AddGestureHandler<Gesture.OnCancel, SliderVisuals>(SliderVisuals.HandleSliderPressCanceled);

            UpdateFillBar();
        }

        private void OnDisable()
        {
            // Unsubscribe from events
            View.UIBlock.RemoveGestureHandler<Gesture.OnHover, SliderVisuals>(SliderVisuals.HandleSliderHovered);
            View.UIBlock.RemoveGestureHandler<Gesture.OnUnhover, SliderVisuals>(SliderVisuals.HandleSliderUnhovered);
            View.UIBlock.RemoveGestureHandler<Gesture.OnPress, SliderVisuals>(HandleSliderPressed);
            View.UIBlock.RemoveGestureHandler<Gesture.OnRelease, SliderVisuals>(SliderVisuals.HandleSliderReleased);
            View.UIBlock.RemoveGestureHandler<Gesture.OnDrag, SliderVisuals>(HandleSliderDragged);
            View.UIBlock.RemoveGestureHandler<Gesture.OnCancel, SliderVisuals>(SliderVisuals.HandleSliderPressCanceled);
        }

        /// <summary>
        /// Update the visual state to indicate a press is being received. 
        /// Moves the slider value to the pressed position if configured to do so.
        /// </summary>
        /// <param name="evt">The press event data.</param>
        /// <param name="sliderVisuals">The visuals being pressed.</param>
        private void HandleSliderPressed(Gesture.OnPress evt, SliderVisuals sliderVisuals)
        {
            // Update the knob color
            sliderVisuals.Knob.Color = sliderVisuals.PressedColor;

            if (!UpdateOnPress)
            {
                // Exit early because we've configured this to explicitly wait for drag events
                return;
            }

            // Update the slider
            UpdateSliderPosition(sliderVisuals, evt.PointerWorldPosition);
        }

        /// <summary>
        /// Update the slider based on the amount it's been dragged.
        /// </summary>
        /// <param name="evt">The drag event data.</param>
        /// <param name="sliderVisuals">The visuals associated with the drag event.</param>
        private void HandleSliderDragged(Gesture.OnDrag evt, SliderVisuals sliderVisuals)
        {
            UpdateSliderPosition(sliderVisuals, evt.PointerPositions.Current);
        }

        /// <summary>
        /// Update the <see cref="Value"/> and visuals according to the slider position.
        /// </summary>
        /// <param name="sliderVisuals">The visuals to update.</param>
        /// <param name="updatedWorldPosition">The position used to determine the new <see cref="Value"/>.</param>
        private void UpdateSliderPosition(SliderVisuals sliderVisuals, Vector3 updatedWorldPosition)
        {
            // Convert the current drag position into slider local space
            Vector3 pointerLocalPosition = sliderVisuals.DraggableRange.transform.InverseTransformPoint(updatedWorldPosition);

            // Use the padded width because the visuals will be updated relative to the padded parent width
            float draggableWidth = sliderVisuals.DraggableRange.PaddedSize.x;

            // Get the pointer's distance from the left edge of the control
            float sliderPositionFromLeft = pointerLocalPosition.x + 0.5f * draggableWidth;

            // Convert the distance from the left edge into a percent from the left edge
            float sliderPercent = Mathf.Clamp01(sliderPositionFromLeft / draggableWidth);

            // Update the slider control to the new value within its min/max range
            Value = Mathf.Lerp(Min, Max, sliderPercent);
        }

        /// <summary>
        /// Update the fill bar width to match the <see cref="Value"/>.
        /// </summary>
        private void UpdateFillBar()
        {
            SliderVisuals sliderControl = View.Visuals as SliderVisuals;

            // Update the control's fillbar to reflect its new slider value
            sliderControl.FillBar.Size.X.Percent = Mathf.Clamp01((this.value - Min) / (Max - Min));

            if (sliderControl.Units != null)
            {
                // Update the control's unit text to display the numeric
                // value associated with the slider control
                sliderControl.Units.Text = string.Format(unitsFormat, Value);
            }
        }
    }
}
