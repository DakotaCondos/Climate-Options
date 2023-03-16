//#if UNITY_EDITOR
namespace Nova
{
    using System.Collections;
    using UnityEngine;


    public static class AnimationExtensions
    {
        public static void ScaleSizeTo(this UIBlock2D uiBlock2D, Length3 targetSize, float duration)
        {
            uiBlock2D.GetComponent<MonoBehaviour>().StartCoroutine(ScaleSizeToCoroutine(uiBlock2D, targetSize, duration));
        }

        private static IEnumerator ScaleSizeToCoroutine(UIBlock2D uiBlock2D, Length3 targetSize, float duration)
        {
            //Vector3 originalScale = transform.localScale;
            Vector3 originalLength = uiBlock2D.Size.Value;
            float timer = 0f;

            while (timer < duration)
            {
                timer += Time.deltaTime;
                float t = Mathf.Clamp01(timer / duration);
                //transform.localScale = Vector3.Lerp(originalScale, targetScale, t);
                uiBlock2D.Size = Vector3.Lerp(originalLength, targetSize.Value, t);
                yield return null;
            }

            //transform.localScale = targetSize;
            uiBlock2D.Size = targetSize;
        }
    }
}
// current file contents
//#endif