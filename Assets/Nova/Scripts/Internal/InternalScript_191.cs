using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_349<T54> : InternalType_147 where T54 : unmanaged
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_186<T54, T54> InternalField_1205;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_348, InternalType_259> InternalField_1206;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_259, InternalType_164<InternalType_288>> InternalField_1207;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_259, InternalType_375> InternalField_1208;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1527()
        {
            InternalField_1205.InternalMethod_1247();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1528(InternalType_348 InternalParameter_1639)
        {
            InternalType_259 InternalVar_1 = InternalField_1205.InternalMethod_1246();
            InternalField_1206.Add(InternalParameter_1639, InternalVar_1);

            if (InternalVar_1 >= InternalField_1207.InternalProperty_216)
            {
                InternalField_1207.InternalMethod_768();
                InternalField_1208.InternalMethod_751(default);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1529(InternalType_348 InternalParameter_1640, InternalType_348 InternalParameter_1641, out InternalType_259 InternalParameter_1642)
        {
            if (!InternalField_1206.TryGetValue(InternalParameter_1640, out InternalParameter_1642))
            {
                InternalMethod_1530(InternalParameter_1641, InternalParameter_1640);
                return false;
            }

            InternalField_1205.InternalMethod_1245(InternalParameter_1642);

            if (!InternalMethod_1530(InternalParameter_1641, InternalParameter_1640))
            {
                InternalField_1206.Remove(InternalParameter_1640);
            }

            return true;
        }

        private bool InternalMethod_1530(InternalType_348 InternalParameter_1643, InternalType_348 InternalParameter_1644)
        {
            if (InternalParameter_1643.InternalProperty_320 && InternalField_1206.TryGetValue(InternalParameter_1643, out InternalType_259 InternalVar_1))
            {
                InternalField_1206[InternalParameter_1644] = InternalVar_1;
                InternalField_1206.Remove(InternalParameter_1643);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Dispose()
        {
            InternalField_1205.Dispose();
            InternalField_1206.Dispose();
            InternalField_1207.InternalMethod_764();
            InternalField_1208.Dispose();
        }

        public void InternalMethod_702()
        {
            InternalField_1205.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_1206.Init(InternalType_178.InternalField_3012);
            InternalField_1207.InternalMethod_703(InternalType_178.InternalField_3012);
            InternalField_1208.InternalMethod_703(InternalType_178.InternalField_3012);
        }

        public static implicit operator ComputeBuffer(InternalType_349<T54> InternalParameter_1645) => InternalParameter_1645.InternalField_1205;
    }

    internal unsafe struct InternalType_350 : InternalType_343<InternalType_80, InternalType_348>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_80> InternalField_1209;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_418> InternalField_1210;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_186<InternalType_384, InternalType_384> InternalField_1211;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_259> InternalField_1212;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_349<InternalType_385> InternalField_1213;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_186<InternalType_387, InternalType_386> InternalField_1214;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_161<InternalType_348, InternalType_133> InternalField_1215;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_161<InternalType_348, InternalType_367> InternalField_1216;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_352<InternalType_80>> InternalField_1217;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_418> InternalField_1219;

        public void InternalMethod_1506()
        {
            InternalField_1217.Clear();

            InternalField_1211.InternalMethod_1247();
            InternalField_1213.InternalMethod_1527();
            InternalField_1214.InternalMethod_1247();
        }

        public void InternalMethod_1532(ref InternalType_342 InternalParameter_1646)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1217.Length; ++InternalVar_1)
            {
                ref InternalType_352<InternalType_80> InternalVar_2 = ref InternalField_1217.ElementAt(InternalVar_1);

                using InternalType_455 InternalVar_3 = new InternalType_455(InternalVar_2.InternalField_2010);

                if (!InternalVar_2.InternalField_1228.InternalProperty_192 ||
                    !InternalParameter_1646.InternalField_1181.TryGetValue(InternalVar_2.InternalField_1228, out InternalType_133 InternalVar_4))
                {
                    continue;
                }

                InternalType_348 InternalVar_5 = InternalParameter_1646.InternalField_1183[InternalVar_4].InternalField_984;
                InternalField_1216[InternalVar_5] = InternalType_367.InternalField_1277;
                if (!InternalField_1209.InternalMethod_747(InternalVar_5, out InternalType_80* InternalVar_6))
                {
                    continue;
                }

                InternalVar_2.InternalProperty_1030.InternalMethod_1291();

                if (InternalVar_2.InternalProperty_1030.Equals(*InternalVar_6))
                {
                    continue;
                }

                if (InternalVar_2.InternalProperty_1030.InternalField_270.InternalProperty_186 != InternalVar_6->InternalField_270.InternalProperty_186)
                {
                    if (InternalVar_2.InternalProperty_1030.InternalField_270.InternalProperty_186)
                    {
                        InternalMethod_1537(InternalVar_5);
                    }
                    else
                    {
                        InternalMethod_1538(InternalVar_5, InternalType_348.InternalField_1204);
                    }
                }

                InternalType_188.InternalMethod_952(InternalVar_6, InternalVar_2.InternalField_1962);
                InternalParameter_1646.InternalField_1184.InternalField_1282.InternalMethod_837(InternalVar_4);
                InternalType_131 InternalVar_7 = InternalParameter_1646.InternalField_1182[InternalVar_4].InternalField_589;
                InternalParameter_1646.InternalField_1184.InternalField_1283.InternalMethod_837(InternalVar_7);
            }
        }

        public void InternalMethod_1533(InternalType_348 InternalParameter_1647, InternalType_133 InternalParameter_1648)
        {
            if (!InternalType_181.InternalMethod_850(InternalParameter_1647, InternalField_1215.InternalProperty_216))
            {
                Debug.LogError($"Tried to set global index from sublist index {InternalParameter_1647} when list was length {InternalField_1215.InternalProperty_216}");
                return;
            }

            InternalField_1215[InternalParameter_1647] = InternalParameter_1648;
        }

        public InternalType_348 InternalMethod_966(InternalType_133 InternalParameter_924, ref InternalType_80 InternalParameter_1874)
        {
            InternalType_348 InternalVar_1 = InternalField_1209.InternalProperty_216;
            InternalField_1209.InternalMethod_751(InternalParameter_1874);
            InternalField_1210.InternalMethod_751(InternalField_1219.InternalMethod_1024());
            InternalField_1212.InternalMethod_751(InternalField_1211.InternalMethod_1246());
            InternalField_1216.InternalMethod_751(InternalType_367.InternalField_1277);
            InternalField_1215.InternalMethod_751(InternalParameter_924);

            if (InternalParameter_1874.InternalField_270.InternalProperty_186)
            {
                InternalMethod_1537(InternalVar_1);
            }

            return InternalVar_1;
        }

        public ref InternalType_80 InternalMethod_1535(InternalType_348 InternalParameter_1652)
        {
            ref InternalType_367 InternalVar_1 = ref InternalField_1216.InternalMethod_748(InternalParameter_1652);
            if (InternalVar_1 >= 0)
            {
                return ref InternalField_1217.ElementAt(InternalVar_1).InternalProperty_1030;
            }
            else
            {
                return ref InternalField_1209.InternalMethod_748(InternalParameter_1652);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref InternalType_80 InternalMethod_1536(InternalType_7 InternalParameter_1910, InternalType_348 InternalParameter_1909)
        {
            ref InternalType_367 InternalVar_1 = ref InternalField_1216.InternalMethod_748(InternalParameter_1909);
            if (InternalVar_1 >= 0)
            {
                return ref InternalField_1217.ElementAt(InternalVar_1).InternalProperty_1030;
            }

            InternalVar_1 = InternalField_1217.Length;

            InternalType_352<InternalType_80> InternalVar_2 = new InternalType_352<InternalType_80>(InternalParameter_1910, ref InternalParameter_1910.InternalProperty_270);
            InternalField_1217.Add(InternalVar_2);
            return ref InternalVar_2.InternalProperty_1030;
        }

        public bool InternalMethod_1505(InternalType_131 InternalParameter_1612, InternalType_348 renderIndex, out InternalType_133 InternalParameter_1614)
        {
            InternalField_1209.InternalMethod_749(renderIndex);
            InternalField_1219.InternalMethod_1027(ref InternalField_1210.InternalMethod_748(renderIndex));
            InternalField_1210.InternalMethod_749(renderIndex);
            InternalField_1211.InternalMethod_1245(InternalField_1212[renderIndex]);
            InternalField_1212.InternalMethod_749(renderIndex);
            InternalField_1215.InternalMethod_749(renderIndex);

            InternalType_367 InternalVar_1 = InternalField_1216[renderIndex];
            InternalField_1216.InternalMethod_749(renderIndex);
            if (InternalVar_1 >= 0)
            {
                InternalField_1217.ElementAt(InternalVar_1).InternalField_1228 = InternalType_131.InternalField_415;
            }

            InternalMethod_1538(renderIndex, InternalField_1209.InternalProperty_216);

            if (renderIndex == InternalField_1209.InternalProperty_216)
            {
                InternalParameter_1614 = -1;
                return false;
            }
            else
            {
                InternalParameter_1614 = InternalField_1215[renderIndex];
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1537(InternalType_348 InternalParameter_1655)
        {
            InternalField_1213.InternalMethod_1528(InternalParameter_1655);
            InternalField_1214.InternalMethod_1246();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1538(InternalType_348 InternalParameter_1656, InternalType_348 InternalParameter_1657)
        {
            if (InternalField_1213.InternalMethod_1529(InternalParameter_1656, InternalParameter_1657, out InternalType_259 InternalVar_1))
            {
                InternalField_1214.InternalMethod_1245(InternalVar_1);
            }
        }

        public void Dispose()
        {
            InternalField_1209.Dispose();

            InternalField_1210.InternalMethod_764();
            InternalField_1211.Dispose();
            InternalField_1213.Dispose();
            InternalField_1214.Dispose();

            InternalField_1212.Dispose();

            InternalField_1215.Dispose();
            InternalField_1216.Dispose();

            InternalField_1217.Dispose();
            InternalField_1219.InternalMethod_1022();
        }

        public void InternalMethod_702()
        {
            InternalField_1209.InternalMethod_703(InternalType_178.InternalField_3013);

            InternalField_1210.InternalMethod_703(InternalType_178.InternalField_3013);

            InternalField_1211.InternalMethod_703(InternalType_178.InternalField_3013);
            InternalField_1213.InternalMethod_702();
            InternalField_1214.InternalMethod_703(InternalType_178.InternalField_3012);

            InternalField_1212.InternalMethod_703(InternalType_178.InternalField_3013);

            InternalField_1215.InternalMethod_703(InternalType_178.InternalField_3013);
            InternalField_1216.InternalMethod_703(InternalType_178.InternalField_3013);

            InternalField_1217.InternalMethod_1020(InternalType_178.InternalField_3013);
            InternalField_1219.InternalMethod_1020(InternalType_178.InternalField_3012);
        }
    }
}

