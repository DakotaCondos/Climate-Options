using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    
    internal class InternalType_312 : IDisposable, InternalType_150
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Texture2DArray InternalField_1028 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_1029 = false;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private List<Texture2D> InternalField_1030 = new List<Texture2D>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_310, Texture2D> InternalField_1032 = new Dictionary<InternalType_310, Texture2D>();


        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private List<InternalType_265> InternalField_1033 = new List<InternalType_265>(InternalType_178.InternalField_3011);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_282 InternalField_3341;

        public void InternalMethod_705()
        {

            InternalField_1033.Clear();
            InternalField_1029 = false;

            InternalType_179.InternalMethod_848(InternalField_1028);
            InternalField_1028 = null;

            if (NovaApplication.IsEditor)
            {
                for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1030.Count; ++InternalVar_1)
                {
                    InternalType_179.InternalMethod_848(InternalField_1030[InternalVar_1]);
                }
                InternalField_1030.Clear();

                foreach (var InternalVar_2 in InternalField_1032.Values)
                {
                    InternalType_179.InternalMethod_848(InternalVar_2);
                }
            }
        }

        public void InternalMethod_1406()
        {
            if (!InternalField_1029 || InternalField_1028 == null)
            {
                return;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1033.Count; ++InternalVar_1)
            {
                if (InternalField_1029)
                {
                    InternalField_1033[InternalVar_1].InternalMethod_1206(InternalField_1028);
                }
            }
        }

        public void InternalMethod_1407(InternalType_265 InternalParameter_1498)
        {
            InternalField_1033.Add(InternalParameter_1498);
            if (InternalField_1028 != null)
            {
                InternalParameter_1498.InternalMethod_1206(InternalField_1028);
            }
        }

        public void InternalMethod_1408(InternalType_265 InternalParameter_1499)
        {
            int InternalVar_1 = InternalField_1033.IndexOf(InternalParameter_1499);
            if (InternalVar_1 == -1)
            {
                return;
            }

            InternalField_1033.RemoveAtSwapBack(InternalVar_1);
        }

        public void InternalMethod_1409()
        {
            InternalField_1029 = false;
        }

        public void InternalMethod_1410(ref InternalType_313 InternalParameter_1500)
        {
            if (InternalParameter_1500.InternalField_1034.InternalProperty_216 < 2)
            {
                InternalType_179.InternalMethod_848(InternalField_1028);
                return;
            }

            if (!InternalType_24.InternalProperty_945.InternalField_3088)
            {
                return;
            }

            InternalMethod_1412(ref InternalParameter_1500);

            if (NovaApplication.IsEditor && !InternalParameter_1500.InternalField_1039.InternalField_1062)
            {
                InternalMethod_1415(ref InternalParameter_1500);
                return;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_1500.InternalField_1036.InternalProperty_216; ++InternalVar_1)
            {
                InternalType_313.InternalType_20 InternalVar_2 = InternalParameter_1500.InternalField_1036[InternalVar_1];

                if (InternalVar_2.InternalField_3343 >= InternalField_1028.depth)
                {
                    Debug.LogError($"Tried to copy {InternalVar_2.InternalField_3343} into size {InternalField_1028.depth} texture");
                    continue;
                }

                if (!InternalType_274.InternalProperty_190.InternalField_876.InternalMethod_1382(InternalVar_2.InternalField_3342, out Texture InternalVar_3))
                {
                    Debug.LogError($"TexturePack tried to copy texture which wasn't tracked");
                    continue;
                }

                InternalMethod_1411(ref InternalParameter_1500, InternalVar_3, InternalVar_2.InternalField_3343);
            }
        }

        private void InternalMethod_1411(ref InternalType_313 InternalParameter_1501, Texture InternalParameter_1502, int InternalParameter_1503)
        {
            if (!InternalParameter_1501.InternalField_1038.InternalProperty_313 || InternalParameter_1501.InternalField_1039.InternalField_1061 == 0)
            {
                Graphics.CopyTexture(InternalParameter_1502, 0, InternalField_1028, InternalParameter_1503);
                return;
            }

            int2 InternalVar_1 = InternalParameter_1501.InternalField_1039.InternalField_1061;
            for (int InternalVar_2 = 0; InternalVar_2 < InternalParameter_1502.mipmapCount; ++InternalVar_2)
            {
                switch (InternalType_24.InternalProperty_945.InternalField_3087)
                {
                    case InternalType_499.InternalField_2481:
                    {
                        Graphics.CopyTexture(InternalParameter_1502,
                            srcElement: 0,
                            srcMip: InternalVar_2,
                            InternalField_1028,
                            dstElement: InternalParameter_1503,
                            dstMip: InternalVar_2);
                        break;
                    }
                    case InternalType_499.InternalField_2478:
                    {
                        int2 InternalVar_3 = math.max(1, InternalParameter_1501.InternalField_1038.InternalField_1077 >> InternalVar_2);
                        if (math.any((InternalVar_3 % InternalVar_1) != int2.zero))
                        {
                            continue;
                        }
                        Graphics.CopyTexture(InternalParameter_1502,
                            srcElement: 0,
                            srcMip: InternalVar_2,
                            InternalField_1028,
                            dstElement: InternalParameter_1503,
                            dstMip: InternalVar_2);
                        break;
                    }
                }
            }
        }


        private bool InternalMethod_1412(ref InternalType_313 InternalParameter_1504)
        {
            if (InternalField_1028 != null && InternalParameter_1504.InternalProperty_310 <= InternalField_1028.depth)
            {
                return false;
            }

            if (InternalField_1028 != null)
            {
                InternalField_1029 = true;
                InternalType_179.InternalMethod_847(InternalField_1028);
            }

            TextureFormat InternalVar_1;

            if (NovaApplication.IsEditor)
            {
                InternalVar_1 = InternalParameter_1504.InternalField_1039.InternalField_1062 ? InternalParameter_1504.InternalField_1039.InternalField_1064 : TextureFormat.RGBA32;
            }
            else
            {
                InternalVar_1 = InternalParameter_1504.InternalField_1039.InternalField_1064;
            }

            InternalField_1028 = new Texture2DArray(InternalParameter_1504.InternalField_1038.InternalField_1077.x, InternalParameter_1504.InternalField_1038.InternalField_1077.y, InternalParameter_1504.InternalField_1034.InternalProperty_216, InternalVar_1, InternalParameter_1504.InternalField_1038.InternalProperty_313, InternalParameter_1504.InternalField_1039.InternalField_1063);
            InternalField_1028.wrapMode = TextureWrapMode.Clamp;
            InternalField_1028.hideFlags = HideFlags.DontSave;

            if (!NovaApplication.IsEditor || InternalParameter_1504.InternalField_1039.InternalField_1062)
            {
                InternalField_1028.Apply(false, true);
            }
            return true;
        }

        private Texture2D InternalMethod_1413(ref InternalType_313 InternalParameter_1505)
        {
            int InternalVar_1 = -1;
            float InternalVar_2 = 0f;
            for (int InternalVar_3 = 0; InternalVar_3 < InternalField_1030.Count; ++InternalVar_3)
            {
                Texture2D InternalVar_4 = InternalField_1030[InternalVar_3];
                if (InternalVar_4 == null)
                {
                    InternalField_1030.RemoveAtSwapBack(InternalVar_3--);
                    continue;
                }

                bool InternalVar_5 = InternalVar_4.width >= InternalParameter_1505.InternalField_1038.InternalField_1077.x && InternalVar_4.height >= InternalParameter_1505.InternalField_1038.InternalField_1077.y && (InternalVar_4.mipmapCount > 1) == InternalParameter_1505.InternalField_1038.InternalProperty_313;
                if (!InternalVar_5)
                {
                    continue;
                }

                float InternalVar_6 = (float)(InternalParameter_1505.InternalField_1038.InternalField_1077.x * InternalParameter_1505.InternalField_1038.InternalField_1077.y) / (float)(InternalVar_4.width * InternalVar_4.height);
                if (InternalVar_6 < InternalVar_2)
                {
                    continue;
                }

                InternalVar_1 = InternalVar_3;
                InternalVar_2 = InternalVar_6;
            }

            if (InternalVar_1 != -1)
            {
                Texture2D InternalVar_3 = InternalField_1030[InternalVar_1];
                InternalField_1030.RemoveAtSwapBack(InternalVar_1);
                return InternalVar_3;
            }
            else
            {
                return new Texture2D(InternalParameter_1505.InternalField_1038.InternalField_1077.x, InternalParameter_1505.InternalField_1038.InternalField_1077.y, TextureFormat.RGBA32, InternalParameter_1505.InternalField_1038.InternalProperty_313, InternalParameter_1505.InternalField_1039.InternalField_1063);
            }
        }

        private unsafe Texture2D InternalMethod_1414(ref InternalType_313 InternalParameter_1506, InternalType_310 InternalParameter_1507, Texture2D InternalParameter_1508)
        {

            RenderTexture InternalVar_1 = RenderTexture.GetTemporary(
                InternalParameter_1508.width,
                InternalParameter_1508.height,
                0,
                RenderTextureFormat.ARGB32,
                InternalParameter_1506.InternalField_1039.InternalField_1063 ? RenderTextureReadWrite.Linear : RenderTextureReadWrite.sRGB);

            if (InternalParameter_1506.InternalField_1038.InternalProperty_313 && !InternalVar_1.useMipMap)
            {
                if (InternalVar_1.IsCreated())
                {
                    InternalVar_1.Release();
                }
                InternalVar_1.useMipMap = true;
            }

            InternalVar_1.autoGenerateMips = false;
            Texture2D InternalVar_2 = InternalMethod_1413(ref InternalParameter_1506);

            Graphics.Blit(InternalParameter_1508, InternalVar_1);
            if (InternalParameter_1506.InternalField_1038.InternalProperty_313)
            {
                InternalVar_1.GenerateMips();
            }
            RenderTexture InternalVar_3 = RenderTexture.active;
            RenderTexture.active = InternalVar_1;

            if ((SystemInfo.copyTextureSupport & UnityEngine.Rendering.CopyTextureSupport.RTToTexture) != 0)
            {
                Graphics.CopyTexture(InternalVar_1, InternalVar_2);
            }
            else
            {
                InternalVar_2.ReadPixels(new Rect(0, 0, InternalVar_1.width, InternalVar_1.height), 0, 0, recalculateMipMaps: InternalParameter_1506.InternalField_1038.InternalProperty_313);
            }

            if (InternalVar_3 == InternalVar_1)
            {
                RenderTexture.active = null;
            }
            else
            {
                RenderTexture.active = InternalVar_3;
            }
            RenderTexture.ReleaseTemporary(InternalVar_1);

            InternalField_1032.Add(InternalParameter_1507, InternalVar_2);
            return InternalVar_2;
        }

        public void InternalMethod_3653()
        {
            InternalField_1032.Clear();
        }

        private void InternalMethod_1415(ref InternalType_313 InternalParameter_1509)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_1509.InternalField_1036.InternalProperty_216; ++InternalVar_1)
            {
                InternalType_313.InternalType_20 InternalVar_2 = InternalParameter_1509.InternalField_1036[InternalVar_1];

                if (InternalVar_2.InternalField_3343 >= InternalField_1028.depth)
                {
                    Debug.LogError($"TexturePack {InternalField_3341} tried to copy {InternalVar_2.InternalField_3343} into size {InternalField_1028.depth} texture");
                    continue;
                }

                if (!InternalField_1032.TryGetValue(InternalVar_2.InternalField_3342, out Texture2D InternalVar_3) ||
                    InternalVar_3 == null)
                {
                    InternalField_1032.Remove(InternalVar_2.InternalField_3342);

                    if (!InternalType_274.InternalProperty_190.InternalField_876.InternalMethod_1382(InternalVar_2.InternalField_3342, out Texture InternalVar_4))
                    {
                        Debug.LogError($"TexturePack {InternalField_3341} not tracking texture");
                        continue;
                    }
                    InternalVar_3 = InternalMethod_1414(ref InternalParameter_1509, InternalVar_2.InternalField_3342, InternalVar_4 as Texture2D);
                }
                Graphics.CopyTexture(InternalVar_3, 0, InternalField_1028, InternalVar_2.InternalField_3343);
            }

            if ((SystemInfo.copyTextureSupport & UnityEngine.Rendering.CopyTextureSupport.RTToTexture) == 0)
            {
                InternalField_1028.Apply();
            }
        }

        public void Dispose()
        {
            InternalMethod_705();
        }
    }
}
