using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Nova.Compat
{
    internal static class TMPUtils
    {
        public static bool WordWrapEnabled(this TextMeshPro tmp)
        {
#if TMP_UV4
            return tmp.textWrappingMode != TextWrappingModes.NoWrap;
#else
            return tmp.enableWordWrapping;
#endif
        }

        public static void DisableWordWrap(this TextMeshPro tmp)
        {
#if TMP_UV4
            tmp.textWrappingMode = TextWrappingModes.NoWrap;
#else
            tmp.enableWordWrapping = false;
#endif
        }

        public unsafe static void CopyUV0(Vector2* dest, ref TMP_MeshInfo textNodeMeshUpdate)
        {
#if TMP_UV4
            for (int i = 0; i < textNodeMeshUpdate.vertices.Length; ++i)
            {
                dest[i] = (Vector2)textNodeMeshUpdate.uvs0[i];
            }
#else
            fixed (Vector2* src = textNodeMeshUpdate.uvs0)
            {
                UnsafeUtility.MemCpy(dest, src, sizeof(Vector2) * textNodeMeshUpdate.vertices.Length);
            }
#endif
        }
    }
}

