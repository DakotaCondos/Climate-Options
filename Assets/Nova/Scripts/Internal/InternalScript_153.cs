using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal class InternalType_308 : IDisposable
    {
        
        private class InternalType_309
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public Texture InternalField_1021;
        }


        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_310, InternalType_309> InternalField_1009 = new Dictionary<InternalType_310, InternalType_309>(InternalType_178.InternalField_3012);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_282, InternalType_312> InternalField_1010 = new Dictionary<InternalType_282, InternalType_312>(InternalType_178.InternalField_3012);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private List<InternalType_312> InternalField_1011 = new List<InternalType_312>(InternalType_178.InternalField_3012);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_2224 = false;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_2223 = false;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_315 InternalField_1014 = default;


        #region 
        [FixedAddressValueType]
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_318 InternalField_1015;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_175> InternalField_1016;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_175> InternalField_1017;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_175> InternalField_1018;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_175> InternalField_1019;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_175> InternalField_1020;
        #endregion

        #region 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_24(InternalType_310 InternalParameter_2430)
        {
            return InternalField_1009.TryGetValue(InternalParameter_2430, out InternalType_309 InternalVar_1) && InternalVar_1.InternalField_1021 != null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1382(InternalType_310 InternalParameter_1468, out Texture InternalParameter_1469)
        {
            if (InternalField_1009.TryGetValue(InternalParameter_1468, out InternalType_309 InternalVar_1))
            {
                InternalParameter_1469 = InternalVar_1.InternalField_1021;
                return InternalParameter_1469 != null;
            }
            else
            {
                InternalParameter_1469 = null;
                return false;
            }
        }

        public void InternalMethod_2334(Sprite InternalParameter_2216, InternalType_695 InternalParameter_2215, ref InternalType_103 InternalParameter_2214)
        {
            InternalType_311 InternalVar_1 = new InternalType_311(InternalParameter_2215);

            Texture InternalVar_2 = null;
            if (InternalParameter_2216 != null && InternalParameter_2216.texture != null)
            {
                InternalVar_2 = InternalParameter_2216.texture;
                InternalVar_1.InternalField_1025 = InternalVar_2.GetInstanceID();
                InternalVar_1.InternalField_1420 = InternalParameter_2216.GetInstanceID();
                InternalVar_1.InternalField_1024 = InternalParameter_2216.rect;
                InternalVar_1.InternalField_3429 = InternalParameter_2216.border;
            }
            InternalMethod_1385(InternalVar_2, ref InternalVar_1, ref InternalParameter_2214);
        }

        public void InternalMethod_2332(Texture InternalParameter_2213, InternalType_695 InternalParameter_2212, ref InternalType_103 InternalParameter_2211)
        {
            InternalType_311 InternalVar_1 = new InternalType_311(InternalParameter_2212);

            if (InternalParameter_2213 != null)
            {
                InternalVar_1.InternalField_1025 = InternalParameter_2213.GetInstanceID();
                InternalVar_1.InternalField_1024 = new Rect(Vector2.zero, new Vector2(InternalParameter_2213.width, InternalParameter_2213.height));
            }

            InternalMethod_1385(InternalParameter_2213, ref InternalVar_1, ref InternalParameter_2211);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1385(Texture InternalParameter_1476, ref InternalType_311 InternalParameter_1477, ref InternalType_103 InternalParameter_1478)
        {
            if (InternalParameter_1477.InternalField_1025.InternalProperty_307)
            {
                InternalMethod_1388(InternalParameter_1477.InternalField_1025, InternalParameter_1476);
            }

            InternalField_1015.InternalField_1065.Value = InternalParameter_1478;
            InternalField_1015.InternalField_1066 = InternalParameter_1477;

            unsafe
            {
                InternalField_1016.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_1015));
            }

            InternalMethod_1387(ref InternalParameter_1478);
        }

        public void InternalMethod_1386(ref InternalType_103 InternalParameter_1479)
        {
            InternalField_1015.InternalField_1065.Value = InternalParameter_1479;

            unsafe
            {
                InternalField_1017.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_1015));
            }

            InternalMethod_1387(ref InternalParameter_1479);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1387(ref InternalType_103 InternalParameter_1480)
        {
            InternalParameter_1480 = InternalField_1015.InternalField_1065.Value;

            ref InternalType_318.InternalType_319 InternalVar_1 = ref InternalField_1015.InternalField_1069.InternalMethod_1030();

            if (InternalVar_1.InternalField_1073.InternalProperty_307 && InternalField_1009.TryGetValue(InternalVar_1.InternalField_1073, out InternalType_309 InternalVar_2))
            {
                InternalVar_2.InternalField_1021 = null;
            }
        }

        private void InternalMethod_1388(InternalType_310 InternalParameter_1481, Texture InternalParameter_1482)
        {
            if (InternalField_1009.TryGetValue(InternalParameter_1481, out InternalType_309 InternalVar_1))
            {
                InternalVar_1.InternalField_1021 = InternalParameter_1482;
                return;
            }


            InternalField_1009.Add(InternalParameter_1481, new InternalType_309()
            {
                InternalField_1021 = InternalParameter_1482,
            });

            if (!InternalField_1014.InternalField_1043.ContainsKey(InternalParameter_1481))
            {
                InternalType_321 InternalVar_2 = new InternalType_321(InternalParameter_1482);
                InternalField_1014.InternalField_1043.Add(InternalParameter_1481, InternalVar_2);
            }

            InternalMethod_1389(InternalParameter_1482);
        }

        private void InternalMethod_1389(Texture InternalParameter_1483)
        {
            if (InternalField_1014.InternalMethod_1426(InternalParameter_1483.graphicsFormat, out InternalType_317 InternalVar_1))
            {
                return;
            }

            InternalVar_1.InternalField_1063 = !GraphicsFormatUtility.IsSRGBFormat(InternalParameter_1483.graphicsFormat);

            if (InternalParameter_1483 is Texture2D tex2D)
            {
                InternalVar_1.InternalField_1062 = SystemInfo.SupportsTextureFormat(tex2D.format);
                InternalVar_1.InternalField_1064 = tex2D.format;
            }
            else
            {
                InternalVar_1.InternalField_1062 = false;
            }

            if (GraphicsFormatUtility.IsCompressedFormat(InternalParameter_1483.graphicsFormat) &&
                !GraphicsFormatUtility.IsPVRTCFormat(InternalParameter_1483.graphicsFormat))
            {
                InternalVar_1.InternalField_1061 = (int)math.max(GraphicsFormatUtility.GetBlockHeight(InternalParameter_1483.graphicsFormat), GraphicsFormatUtility.GetBlockWidth(InternalParameter_1483.graphicsFormat));
            }
            else
            {
                InternalVar_1.InternalField_1061 = 0;
            }

            InternalField_1014.InternalMethod_1427(InternalParameter_1483.graphicsFormat, InternalVar_1);
        }

        
        public void InternalMethod_1390()
        {
            if (InternalField_1009.Count == 0)
            {
                return;
            }


            foreach (var InternalVar_1 in InternalField_1009)
            {
                if (InternalVar_1.Value.InternalField_1021 == null)
                {
                    continue;
                }

                InternalField_1014.InternalField_1043[InternalVar_1.Key] = new InternalType_321(InternalVar_1.Value.InternalField_1021);
                InternalMethod_1389(InternalVar_1.Value.InternalField_1021);
            }
        }

        public void InternalMethod_3652()
        {
            foreach (var InternalVar_1 in InternalField_1010.Values)
            {
                if (InternalVar_1 == null)
                {
                    continue;
                }
                InternalVar_1.InternalMethod_3653();
            }
        }

        
        public bool InternalMethod_23(Texture InternalParameter_1903, UnityEngine.Object[] InternalParameter_1902)
        {
            var InternalVar_1 = InternalParameter_1903.GetInstanceID();
            if (!InternalMethod_24(InternalVar_1))
            {
                return false;
            }

            using var InternalVar_2 = InternalField_1014.InternalField_1042.GetKeyArray(Allocator.Temp);

            bool InternalVar_3 = false;
            for (int InternalVar_4 = 0; InternalVar_4 < InternalVar_2.Length; InternalVar_4++)
            {
                var InternalVar_5 = InternalVar_2[InternalVar_4];
                var InternalVar_6 = InternalField_1014.InternalField_1042[InternalVar_5];
                if (InternalVar_6.InternalField_1025 != InternalVar_1 || InternalVar_6.InternalField_1420 == 0)
                {
                    continue;
                }

                for (int InternalVar_7 = 0; InternalVar_7 < InternalParameter_1902.Length; InternalVar_7++)
                {
                    if (!(InternalParameter_1902[InternalVar_7] is Sprite sprite))
                    {
                        continue;
                    }

                    if (sprite.GetInstanceID() != InternalVar_6.InternalField_1420)
                    {
                        continue;
                    }

                    Rect InternalVar_8 = sprite.rect;
                    if (InternalVar_8.Equals(InternalVar_6.InternalField_1024))
                    {
                        continue;
                    }

                    InternalVar_6.InternalField_1024 = InternalVar_8;
                    InternalField_1014.InternalField_1042[InternalVar_5] = InternalVar_6;
                    InternalVar_3 = true;
                }
            }

            return InternalVar_3;
        }

        
        public bool InternalMethod_22(Texture InternalParameter_1901)
        {
            InternalType_310 InternalVar_1 = InternalParameter_1901.GetInstanceID();

            if (!InternalField_1014.InternalField_1043.TryGetValue(InternalVar_1, out InternalType_321 InternalVar_2))
            {
                return false;
            }

            InternalType_321 InternalVar_3 = new InternalType_321(InternalParameter_1901);
            if (InternalVar_3.Equals(InternalVar_2))
            {
                return false;
            }

            InternalField_1014.InternalField_1043[InternalVar_1] = InternalVar_3;
            InternalMethod_1389(InternalParameter_1901);

            if (InternalParameter_1901 is Texture2D && !InternalVar_2.InternalField_1077.Equals(InternalVar_3.InternalField_1077))
            {
                using var InternalVar_4 = InternalField_1014.InternalField_1042.GetKeyArray(Allocator.Temp);
                for (int InternalVar_5 = 0; InternalVar_5 < InternalVar_4.Length; InternalVar_5++)
                {
                    var InternalVar_6 = InternalVar_4[InternalVar_5];
                    var InternalVar_7 = InternalField_1014.InternalField_1042[InternalVar_6];
                    if (InternalVar_7.InternalField_1025 != InternalVar_1)
                    {
                        continue;
                    }

                    InternalVar_7.InternalField_1024 = new Rect(Vector2.zero, new Vector2(InternalParameter_1901.width, InternalParameter_1901.height));
                    InternalField_1014.InternalField_1042[InternalVar_6] = InternalVar_7;
                }
            }

            return true;
        }
        #endregion

        #region 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1391(InternalType_282 InternalParameter_1484, InternalType_265 InternalParameter_1485)
        {
            if (InternalMethod_1393(InternalParameter_1484, out InternalType_312 InternalVar_1, true))
            {
                InternalVar_1.InternalMethod_1407(InternalParameter_1485);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1392(InternalType_282 InternalParameter_1486, InternalType_265 InternalParameter_1487)
        {
            if (InternalMethod_1393(InternalParameter_1486, out InternalType_312 InternalVar_1, false))
            {
                InternalVar_1.InternalMethod_1408(InternalParameter_1487);
            }
        }

        private bool InternalMethod_1393(InternalType_282 InternalParameter_1488, out InternalType_312 InternalParameter_1489, bool InternalParameter_1490)
        {
            if (!InternalField_1010.TryGetValue(InternalParameter_1488, out InternalParameter_1489))
            {
                if (InternalParameter_1490)
                {
                    Debug.LogError($"Unknown TexturePack {InternalParameter_1488}");
                }
                return false;
            }

            return true;
        }

        public void InternalMethod_1394()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1015.InternalField_1071.Length; ++InternalVar_1)
            {
                InternalType_282 InternalVar_2 = InternalField_1015.InternalField_1071[InternalVar_1];
                if (!InternalField_1010.TryGetValue(InternalVar_2, out InternalType_312 InternalVar_3))
                {
                    continue;
                }
                InternalVar_3.InternalMethod_1406();
            }
        }
        #endregion

        public void InternalMethod_1395()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1015.InternalField_1071.Length; ++InternalVar_1)
            {
                InternalType_282 InternalVar_2 = InternalField_1015.InternalField_1071[InternalVar_1];
                if (InternalField_1010.TryGetValue(InternalVar_2, out InternalType_312 InternalVar_3))
                {
                    InternalVar_3.InternalMethod_1409();
                }
            }

            InternalField_1015.InternalField_1071.Clear();
            InternalField_1015.InternalField_1070.Clear();
        }

        public void InternalMethod_1396()
        {
            unsafe
            {
                InternalField_1018.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_1015));
            }
        }

        public void InternalMethod_1397()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1015.InternalField_1070.Length; ++InternalVar_1)
            {
                InternalType_282 InternalVar_2 = InternalField_1015.InternalField_1070[InternalVar_1];
                if (!InternalField_1010.TryGetValue(InternalVar_2, out InternalType_312 InternalVar_3))
                {
                    continue;
                }

                InternalVar_3.InternalMethod_705();
                InternalField_1011.Add(InternalVar_3);
                InternalField_1010.Remove(InternalVar_2);
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1015.InternalField_1071.Length; ++InternalVar_1)
            {
                InternalType_282 InternalVar_2 = InternalField_1015.InternalField_1071[InternalVar_1];
                if (!InternalField_1014.InternalField_1049.TryGetValue(InternalVar_2, out InternalType_313 InternalVar_3))
                {
                    continue;
                }

                if (!InternalField_1010.TryGetValue(InternalVar_2, out InternalType_312 InternalVar_4))
                {
                    if (!InternalField_1011.InternalMethod_995(out InternalVar_4))
                    {
                        InternalVar_4 = new InternalType_312();
                    }

                    InternalVar_4.InternalField_3341 = InternalVar_2;
                    InternalField_1010[InternalVar_2] = InternalVar_4;
                }

                InternalVar_4.InternalMethod_1410(ref InternalVar_3);
                InternalVar_3.InternalMethod_1417();
                InternalField_1014.InternalField_1049[InternalVar_2] = InternalVar_3;
            }
        }

        private void InternalMethod_1398()
        {
            if (!InternalField_2223)
            {
                InternalField_2223 = true;
                InternalField_2224 = InternalType_24.InternalProperty_945.InternalField_3088;
                return;
            }

            if (InternalType_24.InternalProperty_945.InternalField_3088 == InternalField_2224)
            {
                return;
            }

            InternalField_2224 = InternalType_24.InternalProperty_1045;

            if (InternalField_2224)
            {
                unsafe
                {
                    InternalField_1020.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_1015));
                }
            }
            else
            {
                unsafe
                {
                    InternalField_1019.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_1015));
                }
            }

            InternalMethod_1397();
        }

        public InternalType_308(ref InternalType_315 InternalParameter_1491)
        {
            unsafe
            {
                InternalField_1016 = new InternalType_735<InternalType_175>(InternalType_318.InternalMethod_1443);
                InternalField_1017 = new InternalType_735<InternalType_175>(InternalType_318.InternalMethod_1444);
                InternalField_1018 = new InternalType_735<InternalType_175>(InternalType_318.InternalMethod_1445);
                InternalField_1019 = new InternalType_735<InternalType_175>(InternalType_318.InternalMethod_1446);
                InternalField_1020 = new InternalType_735<InternalType_175>(InternalType_318.InternalMethod_1447);
            }

            this.InternalField_1014 = InternalParameter_1491;
            InternalField_1015 = new InternalType_318(ref InternalParameter_1491, NovaApplication.IsEditor);

            InternalType_24.InternalEvent_10 += InternalMethod_1398;

            if (InternalType_24.InternalProperty_1040)
            {
                InternalField_2223 = true;
                InternalField_2224 = InternalType_24.InternalProperty_945.InternalField_3088;
            }
        }

        public void Dispose()
        {
            InternalField_1015.Dispose();

            InternalType_24.InternalEvent_10 -= InternalMethod_1398;

            foreach (var InternalVar_1 in InternalField_1010.Values)
            {
                InternalVar_1.Dispose();
            }
            InternalField_1010.Clear();

            InternalField_1011.InternalMethod_997();
        }
    }
}

