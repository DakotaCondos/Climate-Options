using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal enum InternalType_262
    {
        InternalField_764,
        InternalField_765,
        InternalField_766,
        InternalField_767,
        InternalField_768,
    }

    internal unsafe class InternalType_263 : IDisposable
    {
        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private static List<InternalType_264> InternalField_769 = new List<InternalType_264>(InternalType_178.InternalField_3012);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static InternalType_264 InternalMethod_1184()
        {
            if (!InternalField_769.InternalMethod_995(out InternalType_264 InternalVar_1))
            {
                InternalVar_1 = new InternalType_264();
            }
            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1185(List<InternalType_264> InternalParameter_1275)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_1275.Count; ++InternalVar_1)
            {
                InternalParameter_1275[InternalVar_1].InternalMethod_1204();
            }

            InternalField_769.AddRange(InternalParameter_1275);
            InternalParameter_1275.Clear();
        }
        #endregion

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private InternalType_131 InternalField_770 = default;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private List<InternalType_264> InternalField_772 = new List<InternalType_264>(InternalType_178.InternalField_3012);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_773 InternalField_1105 = new InternalType_773();

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private ComputeBuffer InternalField_773 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private ComputeBuffer InternalField_774 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_302 InternalField_775;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_162<InternalType_301, InternalType_326> InternalField_776;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Matrix4x4 InternalField_777 = default;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Matrix4x4 InternalField_778 = default;

        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_268 InternalProperty_274
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalType_268.InternalField_406;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_274 InternalProperty_275
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalType_274.InternalProperty_190;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private ref InternalType_275 InternalProperty_276
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref InternalProperty_274.InternalField_807;
        }
        #endregion

        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        private InternalType_5 InternalField_779 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_5 InternalProperty_277
        {
            get
            {
                if (InternalField_779 == null)
                {
                    if (!InternalType_253.InternalProperty_190.InternalField_413.TryGetValue(InternalField_770, out InternalType_145 InternalVar_1))
                    {
                        Debug.LogError("Root node not found in Hierarchy Data Store.");
                        return null;
                    }

                    if (!(InternalVar_1 is InternalType_5 uinode))
                    {
                        Debug.LogError("Root was not a UINode.");
                        return null;
                    }

                    InternalField_779 = uinode;
                }
                return InternalField_779;
            }
        }
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1190(Camera InternalParameter_1276)
        {
            InternalType_162<InternalType_305, InternalType_362.InternalType_361> InternalVar_1 = InternalType_268.InternalField_406.InternalMethod_1305(InternalField_770);
            for (int InternalVar_2 = 0; InternalVar_2 < InternalField_772.Count; ++InternalVar_2)
            {
                InternalType_264 InternalVar_3 = InternalField_772[InternalVar_2];
                InternalVar_3.InternalMethod_1591(InternalParameter_1276, ref InternalVar_1.InternalMethod_758(InternalVar_3.InternalField_783));
            }
        }

        public void InternalMethod_1191()
        {
            InternalMethod_1185(InternalField_772);
        }

        public void InternalMethod_1192()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_772.Count; ++InternalVar_1)
            {
                InternalType_264 InternalVar_2 = InternalField_772[InternalVar_1];

                if (InternalVar_2.InternalField_782.InternalProperty_294)
                {
                    Texture InternalVar_3 = InternalProperty_275.InternalField_874.InternalField_1153[InternalVar_2.InternalField_782.InternalField_900];
                    if (InternalVar_3 != null)
                    {
                        InternalVar_2.InternalField_781.SetTexture(InternalType_331.InternalField_1483, InternalVar_3);
                    }
                }

                if ((InternalVar_2.InternalField_782.InternalField_903 & InternalType_322.InternalField_1086) != 0)
                {
                    if (InternalType_274.InternalProperty_190.InternalField_876.InternalMethod_1382(InternalVar_2.InternalField_782.InternalField_904.InternalField_914, out Texture InternalVar_3))
                    {
                        InternalVar_2.InternalField_781.SetTexture(InternalType_331.InternalField_1197, InternalVar_3);

                    }
                    else
                    {
                        Debug.LogError("Texture tracker did not have matching texture");
                    }
                }
            }
        }

        public void InternalMethod_1970()
        {
            InternalType_133 InternalVar_1 = InternalType_253.InternalProperty_190.InternalProperty_264[InternalField_770];
            InternalField_777 = InternalType_457.InternalProperty_190.InternalField_431.ElementAt(InternalVar_1);
            InternalField_778 = InternalType_457.InternalProperty_190.InternalField_430.ElementAt(InternalVar_1);

            for (int InternalVar_2 = 0; InternalVar_2 < InternalField_772.Count; ++InternalVar_2)
            {
                InternalType_264 InternalVar_3 = InternalField_772[InternalVar_2];
                InternalVar_3.InternalField_781.SetMatrix(InternalType_331.InternalField_2221, InternalField_777);
                InternalVar_3.InternalField_781.SetMatrix(InternalType_331.InternalField_2210, InternalField_778);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_2346(ComputeBuffer InternalParameter_2222, int InternalParameter_2221, InternalType_262 InternalParameter_2220)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_772.Count; ++InternalVar_1)
            {
                InternalType_264 InternalVar_2 = InternalField_772[InternalVar_1];
                bool InternalVar_3 = false;
                switch (InternalParameter_2220)
                {
                    case InternalType_262.InternalField_764:
                        InternalVar_3 = true;
                        break;
                    case InternalType_262.InternalField_765:
                        InternalVar_3 = InternalVar_2.InternalProperty_278 == InternalType_266.InternalField_786;
                        break;
                    case InternalType_262.InternalField_767:
                        InternalVar_3 = (InternalVar_2.InternalProperty_278 & InternalType_266.InternalField_791) != 0;
                        break;
                    case InternalType_262.InternalField_766:
                        InternalVar_3 = InternalVar_2.InternalProperty_278 == InternalType_266.InternalField_787;
                        break;
                    case InternalType_262.InternalField_768:
                        InternalVar_3 = InternalVar_2.InternalProperty_278 == InternalType_266.InternalField_789;
                        break;
                }

                if (InternalVar_3)
                {
                    InternalVar_2.InternalField_781.SetBuffer(InternalParameter_2221, InternalParameter_2222);
                }
            }
        }

        public void InternalMethod_1194()
        {
            if (InternalProperty_277 == null)
            {
                Debug.LogError($"RootNode was null for {InternalField_770}");
                return;
            }

            if (!InternalProperty_277.InternalProperty_152)
            {
                return;
            }

            InternalField_775 = InternalProperty_276.InternalField_881[InternalField_770];
            if (InternalField_775.InternalProperty_304 == 0)
            {
                return;
            }

            InternalField_775.InternalMethod_1347(ref InternalField_773);

            InternalType_133 InternalVar_1 = InternalType_253.InternalProperty_190.InternalProperty_264[InternalField_770];
            InternalField_777 = InternalType_457.InternalProperty_190.InternalField_431.ElementAt(InternalVar_1);
            InternalField_778 = InternalType_457.InternalProperty_190.InternalField_430.ElementAt(InternalVar_1);

            InternalType_164<InternalType_383> InternalVar_2 = InternalProperty_276.InternalField_886[InternalField_770];
            InternalType_177.InternalMethod_845(ref InternalField_774, ref InternalVar_2);

            InternalField_776 = InternalProperty_276.InternalField_888[InternalField_770];

            for (int InternalVar_3 = 0; InternalVar_3 < InternalField_775.InternalField_992.InternalProperty_216; ++InternalVar_3)
            {
                try
                {
                    InternalMethod_1195(InternalVar_3);
                }
                catch (Exception ex)
                {
                    Debug.LogError($"Processing draw call failed with: {ex}");
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1195(int InternalParameter_1280)
        {
            ref InternalType_300 InternalVar_1 = ref InternalField_775.InternalField_992.InternalMethod_758(InternalParameter_1280);
            ref InternalType_276 InternalVar_2 = ref InternalField_775.InternalField_991.InternalMethod_758(InternalVar_1.InternalField_986);

            InternalType_264 InternalVar_3 = InternalMethod_1184();
            InternalType_307 InternalVar_4 = InternalField_775.InternalMethod_1352(InternalVar_1.InternalField_987);

            InternalVar_3.InternalField_783 = InternalVar_1.InternalField_987;
            InternalVar_3.InternalField_782 = InternalVar_2;
            InternalVar_3.InternalField_784 = InternalVar_2.InternalField_902 == InternalType_266.InternalField_786 ? InternalVar_4.InternalField_1008 / 4 : InternalVar_4.InternalField_1008;
            InternalVar_3.InternalField_781.SetInt(InternalType_331.InternalField_1605, InternalVar_4.InternalField_1007);
            InternalVar_3.InternalField_781.SetInt(InternalType_331.InternalField_1604, InternalVar_4.InternalField_1007 + InternalVar_4.InternalField_1008 - 1);
            InternalVar_3.InternalField_780 = InternalType_325.InternalMethod_1450(InternalField_776[InternalVar_1.InternalField_986]);

            if (InternalVar_2.InternalField_902 != InternalType_266.InternalField_786)
            {
                InternalVar_3.InternalField_781.SetBuffer(InternalType_331.InternalField_1560, InternalField_773);
            }

            InternalVar_3.InternalField_781.SetMatrix(InternalType_331.InternalField_2221, InternalField_777);
            InternalVar_3.InternalField_781.SetMatrix(InternalType_331.InternalField_2210, InternalField_778);
            InternalVar_3.InternalField_781.SetBuffer(InternalType_331.InternalField_1912, InternalProperty_275.InternalField_863.InternalField_1240);
            InternalVar_3.InternalField_781.SetFloat(InternalType_331.InternalField_1198, InternalType_24.InternalProperty_1042);

            InternalMethod_1196(InternalVar_3, ref InternalVar_2);

            switch (InternalVar_2.InternalField_902)
            {
                case InternalType_266.InternalField_786:
                    InternalMethod_1200(ref InternalVar_3, ref InternalVar_2);
                    break;
                case InternalType_266.InternalField_789:
                    InternalMethod_1199(ref InternalVar_3);
                    break;
                case InternalType_266.InternalField_788:
                case InternalType_266.InternalField_790:
                    InternalMethod_1198(ref InternalVar_3);
                    break;
                case InternalType_266.InternalField_787:
                    InternalMethod_1197(ref InternalVar_3);
                    break;
            }

            InternalField_772.Add(InternalVar_3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1196(InternalType_264 InternalParameter_1281, ref InternalType_276 InternalParameter_1282)
        {
            InternalType_773 InternalVar_1 = null;
            if (InternalParameter_1282.InternalProperty_294)
            {
                InternalVar_1 = InternalProperty_275.InternalField_874.InternalField_3677[InternalParameter_1282.InternalField_900];
            }
            else
            {
                if (InternalField_1105.InternalField_3670 == 0)
                {
                    return;
                }

                InternalVar_1 = InternalField_1105;
            }

            InternalParameter_1281.InternalField_781.SetInt(InternalType_331.InternalField_3598, InternalVar_1.InternalField_3670);


            InternalParameter_1281.InternalField_781.SetMatrixArray(InternalType_331.InternalField_292, InternalVar_1.InternalField_3672);
            InternalParameter_1281.InternalField_781.SetVectorArray(InternalType_331.InternalField_1713, InternalVar_1.InternalField_3673);
            InternalParameter_1281.InternalField_781.SetVectorArray(InternalType_331.InternalField_319, InternalVar_1.InternalField_3674);

            if (InternalVar_1.InternalField_3671 != -1)
            {
                Texture InternalVar_2 = InternalProperty_275.InternalField_874.InternalField_1153[InternalVar_1.InternalField_3675[InternalVar_1.InternalField_3671]];
                if (InternalVar_2 == null)
                {
                    return;
                }

                InternalParameter_1281.InternalField_781.SetInt(InternalType_331.InternalField_3597, InternalVar_1.InternalField_3671);
                InternalParameter_1281.InternalField_781.SetTexture(InternalType_331.InternalField_1483, InternalVar_2);
            }

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1197(ref InternalType_264 InternalParameter_1283)
        {
            InternalParameter_1283.InternalField_781.SetBuffer(InternalType_331.InternalField_1575, InternalProperty_275.InternalField_866.InternalField_1221);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1198(ref InternalType_264 InternalParameter_1284)
        {
            InternalParameter_1284.InternalField_781.SetBuffer(InternalType_331.InternalField_1575, InternalProperty_275.InternalField_865.InternalField_1195);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1199(ref InternalType_264 InternalParameter_1285)
        {
            InternalParameter_1285.InternalField_781.SetBuffer(InternalType_331.InternalField_1575, InternalProperty_275.InternalField_864.InternalField_1214);
            InternalParameter_1285.InternalField_781.SetBuffer(InternalType_331.InternalField_1163, InternalProperty_275.InternalField_864.InternalField_1213);
            InternalParameter_1285.InternalField_781.SetFloat(InternalType_331.InternalField_1198, InternalType_24.InternalProperty_1042);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1200(ref InternalType_264 InternalParameter_1286, ref InternalType_276 InternalParameter_1287)
        {
            InternalParameter_1286.InternalField_781.SetBuffer(InternalType_331.InternalField_1478, InternalField_774);
            InternalParameter_1286.InternalField_781.SetBuffer(InternalType_331.InternalField_1575, InternalProperty_275.InternalField_864.InternalField_1211);
            InternalParameter_1286.InternalField_781.SetFloat(InternalType_331.InternalField_1198, InternalType_24.InternalProperty_1042);

            if ((InternalParameter_1287.InternalField_903 & InternalType_322.InternalField_1087) != 0)
            {
                InternalType_274.InternalProperty_190.InternalField_876.InternalMethod_1391(InternalParameter_1287.InternalField_904.InternalField_913, InternalParameter_1286);
            }
            else if ((InternalParameter_1287.InternalField_903 & InternalType_322.InternalField_1086) != 0)
            {
                if (InternalType_274.InternalProperty_190.InternalField_876.InternalMethod_1382(InternalParameter_1287.InternalField_904.InternalField_914, out Texture InternalVar_1))
                {
                    InternalParameter_1286.InternalField_781.SetTexture(InternalType_331.InternalField_1197, InternalVar_1);
                }
                else
                {
                    Debug.LogError("Texture tracker did not have matching texture");
                }
            }
        }

        #region 
        public InternalType_263(InternalType_131 InternalParameter_1288)
        {
            this.InternalField_770 = InternalParameter_1288;
        }

        public void Dispose()
        {
            InternalMethod_1185(InternalField_772);
            InternalField_773.InternalMethod_846();
            InternalField_774.InternalMethod_846();
        }
        #endregion
    }
}

