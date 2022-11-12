using System.Collections;
using UnityEngine;

namespace NovaSamples.UIControls
{
    /// <summary>
    /// Provides text input on mobile using the <see cref="TouchScreenKeyboard"/> apis.
    /// </summary>
    public class TextFieldMobileInput : TextFieldInputProvider
    {
        [SerializeField]
        [Tooltip("The type of virtual keyboard to bring up when the reference Text Field is focused.")]
        private TouchScreenKeyboardType keyboardType = TouchScreenKeyboardType.Default;
        [SerializeField]
        [Tooltip("Enable the system keyboard's auto correct functionality?")]
        private bool autoCorrect = true;
        [SerializeField]
        [Tooltip("Should the text be masked (e.g. for passwords)?")]
        private bool secure = false;

        /// <summary>
        /// The coroutine tracking tracking the keyboard visibility and listening for input events.
        /// </summary>
        private Coroutine inputRoutine = null;

        /// <summary>
        /// The active touchscreen keyboard
        /// </summary>
        private TouchScreenKeyboard keyboard = null;

        /// <summary>
        /// Tracks if we are currently updating the <see cref="TextField"/> from the touch screen keyboard.
        /// Used for ignoring the <see cref="TextField.OnTextSelectionChanged"/> event.
        /// </summary>
        private bool updatingText = false;

        protected override void OnEnable()
        {
            if (!TouchScreenKeyboard.isSupported)
            {
                // If touchscreen keyboard not supported on this device, do nothing
                return;
            }

            base.OnEnable();

            // Subscribe to selection changed so we can update the touch screen
            // keyboard whenever the input field selection changes
            inputField.OnTextSelectionChanged += UpdateTouchScreenKeyboardSelection;
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            inputField.OnTextSelectionChanged -= UpdateTouchScreenKeyboardSelection;
        }

        /// <summary>
        /// Kickoff the input update loop.
        /// </summary>
        protected override void HandleFocused()
        {
            if (keyboard != null)
            {
                Debug.LogWarning("Got focus event when keyboard already existed");
                return;
            }

            inputRoutine = StartCoroutine(InputLoop());
        }

        /// <summary>
        /// Stop the input update loop and hide the touch screen
        /// keyboard.
        /// </summary>
        protected override void HandleFocusLost()
        {
            if (inputRoutine != null)
            {
                StopCoroutine(inputRoutine);
                inputRoutine = null;
            }

            if (keyboard != null)
            {
                keyboard.active = false;
                keyboard = null;
            }
        }

        /// <summary>
        /// Updates the touch screen keyboard's selection from the text input field.
        /// </summary>
        private void UpdateTouchScreenKeyboardSelection()
        {
            if (keyboard == null || keyboard.status != TouchScreenKeyboard.Status.Visible)
            {
                return;
            }

            if (updatingText)
            {
                // We are in the process of updating the input field,
                // so ignore this event
                return;
            }

            // Get the display string selection positions
            inputField.GetSelectionLeftRight(out TextPosition left, out TextPosition right);

            // Convert the display string positions to raw string positions
            int start = inputField.StringIndexFromTextPosition(left);
            int count = inputField.StringIndexFromTextPosition(right) - start;

            // Update the keyboard selection
            keyboard.selection = new RangeInt(start, count);
        }

        /// <summary>
        /// Coroutine to listen for keyboard visibility and input events.
        /// </summary>
        /// <returns></returns>
        private IEnumerator InputLoop()
        {
            // Open the touch screen keyboard
            keyboard = TouchScreenKeyboard.Open(inputField.Text, keyboardType, autoCorrect, allowNewlines, secure, alert: false);

            // Update the touch screen keyboard selection
            UpdateTouchScreenKeyboardSelection();

            // Loop indefinitely, the loop will stop when the coroutine is stopped.
            while (true)
            {
                if (keyboard.status != TouchScreenKeyboard.Status.Visible)
                {
                    // The touch screen keyboard was hidden (for example, if the user clicks somewhere else
                    // on the screen), so unfocus the text input field (our unfocus event handler will 
                    // stop this coroutine and do other cleanup).
                    selector.RemoveFocus();
                    yield break;
                }

                if (keyboard.text != inputField.Text)
                {
                    // The keyboard text and input field text don't match, so update the input field
                    updatingText = true;
                    inputField.Text = keyboard.text;
                    updatingText = false;
                }

                // Convert the touch screen keyboard positions to display string positions
                TextPosition left = inputField.TextPositionFromStringIndex(keyboard.selection.start);
                TextPosition right = inputField.TextPositionFromStringIndex(keyboard.selection.end);

                if (left.IsValid && right.IsValid)
                {
                    // Update the input field cursor positions
                    inputField.SetCursorPosition(right, left);
                }

                yield return null;
            }
        }
    }
}
