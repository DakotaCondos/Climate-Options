using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal partial class InternalType_274 : InternalType_129<InternalType_274, InternalType_255>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_370 InternalField_862;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_355 InternalField_863;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_350 InternalField_864;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_347 InternalField_865;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_351 InternalField_866;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_346 InternalField_867;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_315 InternalField_868;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_345 InternalField_869;

        #region 
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_298 InternalField_870;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_175> InternalField_871;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_175> InternalField_872;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_175> InternalField_873;
        #endregion

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public HashSet<InternalType_131> InternalField_3380 = new HashSet<InternalType_131>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public List<InternalType_765> InternalField_3623 = new List<InternalType_765>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_338 InternalField_874 = new InternalType_338();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Dictionary<InternalType_257, Material> InternalField_875 = new Dictionary<InternalType_257, Material>();

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_308 InternalField_876 = null;

        public void InternalMethod_3646()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_3623.Count; ++InternalVar_1)
            {
                var InternalVar_2 = InternalField_3623[InternalVar_1];
                if (InternalVar_2 == null)
                {
                    continue;
                }

                InternalVar_2.InternalMethod_3365();
            }
        }

        public bool InternalMethod_1258(InternalType_131 InternalParameter_1320)
        {
            return InternalField_869.InternalField_1187.TryGetValue(InternalParameter_1320, out InternalType_344 InternalVar_1) && InternalVar_1 != InternalType_344.InternalField_1185;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public override bool InternalProperty_193 => InternalField_862.InternalProperty_331;

        public unsafe void InternalMethod_1259()
        {
            InternalField_870.InternalField_1765 = InternalType_268.InternalField_406.InternalField_807.InternalField_887;
            InternalField_873.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_870));
        }

        public override void InternalMethod_635()
        {
            InternalField_862.InternalMethod_705();
            InternalField_876.InternalMethod_1395();
            InternalField_864.InternalMethod_1506();
            InternalField_866.InternalMethod_1506();
            InternalField_865.InternalMethod_1506();
            InternalField_867.InternalMethod_1515();

            InternalField_863.InternalField_1240.InternalMethod_1247();
        }

        public void InternalMethod_1260(InternalType_131 InternalParameter_1321, bool InternalParameter_1322)
        {
            if (!InternalMethod_628(InternalParameter_1321))
            {
                return;
            }

            bool InternalVar_2 = InternalField_869.InternalField_1187.TryGetValue(InternalParameter_1321, out InternalType_344 InternalVar_1);

            if (InternalParameter_1322 && !InternalVar_2)
            {
                InternalField_869.InternalMethod_1507(InternalParameter_1321);
            }
            else if (!InternalParameter_1322 && InternalVar_2 && InternalVar_1 == InternalType_344.InternalField_1185)
            {
                InternalField_869.InternalMethod_1508(InternalParameter_1321);
            }
        }

        public void InternalMethod_3647(InternalType_131 InternalParameter_227, InternalType_765 InternalParameter_228)
        {
            if (InternalField_3380.Add(InternalParameter_227))
            {
                InternalField_3623.Add(InternalParameter_228);
            }
            InternalField_869.InternalField_3381[InternalParameter_227] = InternalParameter_228.InternalProperty_1156;
            InternalMethod_3367(InternalParameter_227);
        }

        public void InternalMethod_3648(InternalType_131 InternalParameter_229, InternalType_765 InternalParameter_3443)
        {
            if (InternalField_3380.Remove(InternalParameter_229))
            {
                InternalField_3623.Remove(InternalParameter_3443);
            }

            InternalField_869.InternalField_3381.Remove(InternalParameter_229);
            InternalMethod_3367(InternalParameter_229);
        }

        public void InternalMethod_1261(InternalType_131 InternalParameter_1323)
        {
            if (!InternalField_869.InternalField_1187.TryGetValue(InternalParameter_1323, out InternalType_344 InternalVar_1) ||
                InternalVar_1 != InternalType_344.InternalField_1186)
            {
                return;
            }

            if (!InternalField_413.TryGetValue(InternalParameter_1323, out InternalType_255 InternalVar_2))
            {
                return;
            }

            InternalType_253.InternalProperty_190.InternalMethod_1156(InternalParameter_1323);
            InternalField_869.InternalMethod_1510(InternalParameter_1323);
            InternalField_862.InternalField_1283.InternalMethod_837(InternalParameter_1323);

            if (InternalVar_2.InternalProperty_207)
            {
                InternalField_869.InternalMethod_1507(InternalParameter_1323);
            }

            if (InternalField_3380.Contains(InternalParameter_1323))
            {
                InternalMethod_3367(InternalParameter_1323);
            }
        }

        private void InternalMethod_3367(InternalType_131 InternalParameter_226)
        {
            if (InternalType_268.InternalField_406.InternalField_807.InternalField_887.TryGetValue(InternalParameter_226, out var InternalVar_1))
            {
                InternalField_862.InternalField_1283.InternalMethod_3375(InternalVar_1);
            }
        }

        public void InternalMethod_1262(InternalType_131 InternalParameter_1324, InternalType_101 InternalParameter_1325)
        {
            bool InternalVar_2 = InternalField_869.InternalField_1187.TryGetValue(InternalParameter_1324, out InternalType_344 InternalVar_1);

            if (!InternalVar_2 || InternalVar_1 == InternalType_344.InternalField_1185)
            {
                InternalField_869.InternalMethod_1509(InternalParameter_1324, ref InternalParameter_1325);
                InternalField_862.InternalField_1283.InternalMethod_837(InternalParameter_1324);
                InternalType_253.InternalProperty_190.InternalMethod_1155(InternalParameter_1324);

                if (InternalField_3380.Contains(InternalParameter_1324))
                {
                    InternalMethod_3367(InternalParameter_1324);
                }

                return;
            }

            if (InternalVar_2 && InternalVar_1 == InternalType_344.InternalField_1186)
            {
                if (InternalField_869.InternalField_1188[InternalParameter_1324].Equals(InternalParameter_1325))
                {
                    return;
                }

                InternalField_869.InternalField_1188[InternalParameter_1324] = InternalParameter_1325;
                InternalField_862.InternalField_1283.InternalMethod_837(InternalParameter_1324);

                if (InternalField_3380.Contains(InternalParameter_1324))
                {
                    InternalMethod_3367(InternalParameter_1324);
                }

                return;
            }
        }

        protected override bool InternalMethod_620(InternalType_131 InternalParameter_506, out InternalType_133 InternalParameter_507) => InternalType_253.InternalProperty_190.InternalProperty_259.InternalMethod_665(InternalParameter_506, out InternalParameter_507);
        protected override InternalType_131 InternalMethod_621(InternalType_133 InternalParameter_508) => InternalType_253.InternalProperty_190.InternalProperty_259.InternalMethod_667(InternalParameter_508);

        #region 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref InternalType_80 InternalMethod_1695(InternalType_7 InternalParameter_2055)
        {
            if (!InternalParameter_2055.InternalProperty_196.InternalProperty_194)
            {
                return ref InternalParameter_2055.InternalProperty_270;
            }

            InternalType_348 InternalVar_1 = InternalField_863.InternalField_1239.ElementAt(InternalParameter_2055.InternalProperty_196).InternalField_984;
            return ref InternalField_864.InternalMethod_1536(InternalParameter_2055, InternalVar_1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref InternalType_82 InternalMethod_1694(InternalType_9 InternalParameter_1912)
        {
            if (!InternalParameter_1912.InternalProperty_196.InternalProperty_194)
            {
                return ref InternalParameter_1912.InternalProperty_270;
            }

            InternalType_348 InternalVar_1 = InternalField_863.InternalField_1239.ElementAt(InternalParameter_1912.InternalProperty_196).InternalField_984;
            return ref InternalField_866.InternalMethod_1512(InternalParameter_1912, InternalVar_1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref InternalType_79 InternalMethod_1265(InternalType_256<InternalType_79> InternalParameter_1328, int InternalParameter_1329)
        {
            InternalType_348 InternalVar_1 = InternalField_863.InternalField_1239.ElementAt(InternalParameter_1328.InternalProperty_196).InternalField_984;
            return ref InternalField_865.InternalMethod_1520(InternalParameter_1328.InternalProperty_195, InternalVar_1, InternalParameter_1329);
        }

        public ref InternalType_73 InternalMethod_1266(InternalType_255 InternalParameter_1330)
        {
            if (!InternalParameter_1330.InternalProperty_196.InternalProperty_194)
            {
                return ref InternalParameter_1330.InternalProperty_268;
            }

            return ref InternalField_867.InternalMethod_1540(InternalParameter_1330);
        }
        #endregion

        public void InternalMethod_3031(InternalType_255 InternalParameter_2749)
        {
            if (!InternalField_414)
            {
                return;
            }

            if (!InternalProperty_190.InternalMethod_628(InternalParameter_2749.InternalProperty_195))
            {
                return;
            }

            ref InternalType_299<InternalType_71> InternalVar_1 = ref InternalField_863.InternalField_1239.ElementAt(InternalParameter_2749.InternalProperty_196);
            ref InternalType_71 InternalVar_2 = ref InternalParameter_2749.InternalProperty_267;
            if (!InternalVar_1.InternalField_983.InternalMethod_453(ref InternalVar_2))
            {
                InternalField_862.InternalField_1285.InternalMethod_837(InternalParameter_2749.InternalProperty_195);
                InternalVar_1.InternalField_983 = InternalVar_2;
            }

            InternalType_180.InternalMethod_849();
        }

        protected unsafe override void InternalMethod_617(InternalType_255 renderNode)
        {
            InternalType_131 InternalVar_1 = renderNode.InternalProperty_195;
            InternalType_133 InternalVar_2 = renderNode.InternalProperty_196;
            ref InternalType_299<InternalType_71> InternalVar_3 = ref InternalField_863.InternalField_1239.ElementAt(InternalVar_2);
            ref InternalType_71 InternalVar_4 = ref renderNode.InternalProperty_267;

            InternalField_867.InternalMethod_1540(renderNode);

            if (!InternalVar_3.InternalField_983.InternalMethod_453(ref InternalVar_4))
            {
                InternalField_862.InternalField_1285.InternalMethod_837(renderNode.InternalProperty_195);
                InternalVar_3.InternalField_983 = InternalVar_4;
            }

            switch (renderNode)
            {
                case InternalType_7 block2D:
                    InternalField_864.InternalMethod_1536(block2D, InternalVar_3.InternalField_984);
                    break;
                case InternalType_9 block3D:
                    InternalField_866.InternalMethod_1512(block3D, InternalVar_3.InternalField_984);
                    break;

            }
        }

        protected override void InternalMethod_618(InternalType_255 InternalParameter_503)
        {
            InternalType_133 InternalVar_1 = InternalParameter_503.InternalProperty_196;
            InternalParameter_503.InternalProperty_268 = InternalField_867.InternalMethod_1511(InternalVar_1);
            switch (InternalParameter_503)
            {
                case InternalType_256<InternalType_80> uiNode2D:
                {
                    InternalType_348 InternalVar_2 = InternalField_863.InternalField_1239[InternalParameter_503.InternalProperty_196].InternalField_984;
                    uiNode2D.InternalProperty_270 = InternalField_864.InternalMethod_1535(InternalVar_2);
                    break;
                }
                case InternalType_256<InternalType_82> uiNode3D:
                {
                    InternalType_348 InternalVar_2 = InternalField_863.InternalField_1239[InternalParameter_503.InternalProperty_196].InternalField_984;
                    uiNode3D.InternalProperty_270 = InternalField_866.InternalMethod_1539(InternalVar_2);
                    break;
                }
            }
        }

        protected override void InternalMethod_619(InternalType_255 InternalParameter_504, InternalType_255 InternalParameter_505)
        {
            InternalType_133 InternalVar_1 = InternalParameter_504.InternalProperty_196;
            InternalParameter_505.InternalProperty_268 = InternalField_867.InternalMethod_1511(InternalVar_1);

            InternalType_299<InternalType_71> InternalVar_2 = InternalField_863.InternalField_1239[InternalParameter_504.InternalProperty_196];
            InternalParameter_505.InternalProperty_267 = InternalVar_2.InternalField_983;

            switch (InternalParameter_505)
            {
                case InternalType_256<InternalType_80> uiNode2D:
                {
                    InternalType_348 InternalVar_3 = InternalVar_2.InternalField_984;
                    uiNode2D.InternalProperty_270 = InternalField_864.InternalMethod_1535(InternalVar_3);
                    uiNode2D.InternalProperty_270.InternalField_271.InternalField_276 = InternalType_103.InternalField_322;
                    break;
                }
                case InternalType_256<InternalType_82> uiNode3D:
                {
                    InternalType_348 InternalVar_3 = InternalVar_2.InternalField_984;
                    uiNode3D.InternalProperty_270 = InternalField_866.InternalMethod_1539(InternalVar_3);
                    break;
                }
            }
        }

        protected override void InternalMethod_615(InternalType_255 renderNode)
        {
            InternalField_870.InternalField_976 = renderNode.InternalProperty_207;
            InternalField_870.InternalField_977 = renderNode.InternalProperty_196;
            InternalField_870.InternalField_978 = renderNode.InternalProperty_195;
            InternalField_870.InternalField_979 = renderNode.InternalProperty_267;
            InternalField_870.InternalField_981 = renderNode.InternalProperty_268;
            switch (renderNode)
            {
                case InternalType_256<InternalType_80> uiNode2D:
                    InternalField_870.InternalField_980.InternalField_1229 = uiNode2D.InternalProperty_270;
                    break;
                case InternalType_256<InternalType_82> uiNode3D:
                    InternalField_870.InternalField_980.InternalField_1230 = uiNode3D.InternalProperty_270;
                    break;
            }

            unsafe
            {
                InternalField_871.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_870));
            }
        }

        protected override void InternalMethod_616(InternalType_131 InternalParameter_500, InternalType_133 InternalParameter_501)
        {
            InternalField_870.InternalField_977 = InternalParameter_501;
            InternalField_870.InternalField_978 = InternalParameter_500;
            unsafe
            {
                InternalField_872.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_870));
            }

            if (InternalField_869.InternalField_1187.TryGetValue(InternalParameter_500, out InternalType_344 InternalVar_1))
            {
                if (InternalVar_1 == InternalType_344.InternalField_1185)
                {
                    InternalField_869.InternalMethod_1508(InternalParameter_500);
                }
                else if (InternalVar_1 == InternalType_344.InternalField_1186)
                {
                    InternalField_869.InternalMethod_1510(InternalParameter_500);
                    InternalType_253.InternalProperty_190.InternalMethod_1156(InternalParameter_500);
                }
            }
        }

        public void InternalMethod_3651() => InternalField_876.InternalMethod_3652();

        public override void InternalMethod_702()
        {
            base.InternalMethod_702();

            unsafe
            {
                InternalField_871 = new InternalType_735<InternalType_175>(InternalType_298.InternalMethod_1331);
                InternalField_872 = new InternalType_735<InternalType_175>(InternalType_298.InternalMethod_1332);
                InternalField_873 = new InternalType_735<InternalType_175>(InternalType_298.InternalMethod_1337);
            }

            InternalField_863.InternalMethod_702();
            InternalField_862.InternalMethod_702();
            InternalField_867.InternalMethod_1517();
            InternalField_864.InternalMethod_702();
            InternalField_866.InternalMethod_702();
            InternalField_865.InternalMethod_702();
            InternalField_869.InternalMethod_702();

            InternalField_874.InternalMethod_702();
            InternalField_868.InternalMethod_702();

            InternalField_876 = new InternalType_308(ref InternalField_868);

            InternalMethod_1257();

            InternalField_870 = new InternalType_298()
            {
                InternalField_969 = InternalField_863,
                InternalField_973 = InternalField_867,
                InternalField_970 = InternalField_864,
                InternalField_972 = InternalField_866,
                InternalField_971 = InternalField_865,
                InternalField_974 = InternalField_869,
                InternalField_975 = InternalField_862,
                InternalField_982 = new InternalType_342()
                {
                    InternalField_1181 = InternalType_253.InternalProperty_190.InternalProperty_264,
                    InternalField_1182 = InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_594,
                    InternalField_1183 = InternalField_863.InternalField_1239,

                    InternalField_1184 = InternalField_862,
                },
            };
        }

        public override void Dispose()
        {
            base.Dispose();
            InternalField_863.Dispose();

            InternalField_862.Dispose();

            InternalField_867.InternalMethod_1516();
            InternalField_864.Dispose();
            InternalField_866.Dispose();
            InternalField_865.Dispose();
            InternalField_868.Dispose();
            InternalField_869.Dispose();

            InternalField_874.Dispose();
            InternalField_876.Dispose();
        }
    }
}
