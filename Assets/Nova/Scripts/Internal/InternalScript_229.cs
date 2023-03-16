using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_424 : InternalType_192
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1608;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1609;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<ushort> InternalField_1610;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_388> InternalField_1611;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float2> InternalField_1612;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float3> InternalField_1613;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_1614;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_1615;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_1616;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float InternalField_1617;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float InternalField_1618;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_1619;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_1620;

        public void Execute()
        {
            InternalMethod_1678();

            InternalField_1619 = 0;
            InternalField_1620 = false;
            InternalMethod_1675(-.5f, new float3(0f, 0f, -1f));

            InternalField_1619 = InternalField_1611.Length;
            InternalField_1620 = true;
            InternalMethod_1675(.5f, new float3(0f, 0f, 1f));

            InternalField_1620 = false;

            InternalMethod_1674();
        }

        private void InternalMethod_1673(int InternalParameter_1855, int InternalParameter_1856)
        {
            InternalMethod_1679(InternalParameter_1855, InternalField_1619 + InternalParameter_1855, InternalField_1619 + InternalParameter_1856, InternalParameter_1856);
        }

        private void InternalMethod_1674()
        {
            InternalMethod_1673(4 + 4 * InternalField_1614 - 1, 4 + InternalField_1614 - 1);

            InternalMethod_1673(4 + InternalField_1616 - 1, 4 + InternalField_1614 + InternalField_1616 - 1);

            InternalMethod_1673(4 + 2 * InternalField_1614 - 1, 4 + 3 * InternalField_1614 - 1);

            InternalMethod_1673(4 + 2 * InternalField_1614 + InternalField_1616 - 1, 4 + 3 * InternalField_1614 + InternalField_1616 - 1);

            for (int InternalVar_1 = 0; InternalVar_1 < 4; InternalVar_1++)
            {
                int InternalVar_2 = 4 + InternalVar_1 * InternalField_1614;
                for (int InternalVar_3 = 1; InternalVar_3 < InternalField_1615; ++InternalVar_3)
                {
                    InternalMethod_1673(InternalVar_2 + (InternalVar_3 + 1) * InternalField_1616 - 1, InternalVar_2 + InternalVar_3 * InternalField_1616 - 1);
                }

                InternalField_1620 = !InternalField_1620;
            }
        }

        private void InternalMethod_1675(float InternalParameter_1857, float3 InternalParameter_1858)
        {
            InternalField_1611.Add(new InternalType_388()
            {
                InternalField_1363 = new float3(.5f, .5f, InternalParameter_1857),
                InternalField_1364 = InternalParameter_1858,
                InternalField_1365 = new float3(-1f, -1f, 0f),
                InternalField_1366 = float3.zero,
            });

            InternalField_1611.Add(new InternalType_388()
            {
                InternalField_1363 = new float3(.5f, -.5f, InternalParameter_1857),
                InternalField_1364 = InternalParameter_1858,
                InternalField_1365 = new float3(-1f, 1f, 0f),
                InternalField_1366 = float3.zero,
            });

            InternalField_1611.Add(new InternalType_388()
            {
                InternalField_1363 = new float3(-.5f, -.5f, InternalParameter_1857),
                InternalField_1364 = InternalParameter_1858,
                InternalField_1365 = new float3(1f, 1f, 0f),
                InternalField_1366 = float3.zero,
            });

            InternalField_1611.Add(new InternalType_388()
            {
                InternalField_1363 = new float3(-.5f, .5f, InternalParameter_1857),
                InternalField_1364 = InternalParameter_1858,
                InternalField_1365 = new float3(1f, -1f, 0f),
                InternalField_1366 = float3.zero,
            });

            InternalMethod_1679(0 + InternalField_1619, 1 + InternalField_1619, 2 + InternalField_1619, 3 + InternalField_1619);

            InternalType_388 InternalVar_1 = new InternalType_388()
            {
                InternalField_1363 = new float3(.5f, .5f, InternalParameter_1857),
                InternalField_1364 = InternalParameter_1858,
            };
            InternalMethod_1677(ref InternalVar_1, new float2(.5f, .5f), 0 + InternalField_1619);

            InternalVar_1.InternalField_1363 = new float3(.5f, -.5f, InternalParameter_1857);
            InternalField_1620 = !InternalField_1620;
            InternalMethod_1677(ref InternalVar_1, new float2(.5f, -.5f), 1 + InternalField_1619);

            InternalVar_1.InternalField_1363 = new float3(-.5f, -.5f, InternalParameter_1857);
            InternalField_1620 = !InternalField_1620;
            InternalMethod_1677(ref InternalVar_1, new float2(-.5f, -.5f), 2 + InternalField_1619);

            InternalVar_1.InternalField_1363 = new float3(-.5f, .5f, InternalParameter_1857);
            InternalField_1620 = !InternalField_1620;
            InternalMethod_1677(ref InternalVar_1, new float2(-.5f, .5f), 3 + InternalField_1619);
            InternalField_1620 = !InternalField_1620;

            int InternalVar_2 = InternalField_1619 + 4;

            int2 InternalVar_3 = new int2(InternalField_1619 + 3, InternalField_1619);
            int2 InternalVar_4 = new int2(InternalVar_2 + 3 * InternalField_1614 + (InternalField_1615 - 1) * InternalField_1616, InternalVar_2 + (InternalField_1615 - 1) * InternalField_1616);
            InternalMethod_1676(ref InternalVar_3, ref InternalVar_4);

            InternalVar_3 = new int2(InternalField_1619, InternalField_1619 + 1);
            InternalVar_4 = new int2(InternalVar_2, InternalVar_2 + InternalField_1614);
            InternalMethod_1676(ref InternalVar_3, ref InternalVar_4);

            InternalVar_3 = new int2(InternalField_1619 + 1, InternalField_1619 + 2);
            InternalVar_4 = new int2(InternalVar_2 + 2 * InternalField_1614 - InternalField_1616, InternalVar_2 + 3 * InternalField_1614 - InternalField_1616);
            InternalMethod_1676(ref InternalVar_3, ref InternalVar_4);

            InternalVar_3 = new int2(InternalField_1619 + 2, InternalField_1619 + 3);
            InternalVar_4 = new int2(InternalVar_2 + 2 * InternalField_1614, InternalVar_2 + 3 * InternalField_1614);
            InternalMethod_1676(ref InternalVar_3, ref InternalVar_4);
        }

        private void InternalMethod_1676(ref int2 InternalParameter_1859, ref int2 InternalParameter_1860)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1616; InternalVar_1++)
            {
                InternalMethod_1679(InternalParameter_1860.y, InternalParameter_1859.y, InternalParameter_1859.x, InternalParameter_1860.x);
                InternalParameter_1859 = InternalParameter_1860;
                InternalParameter_1860 += 1;
            }
        }

        private void InternalMethod_1677(ref InternalType_388 InternalParameter_1861, float2 InternalParameter_1862, int InternalParameter_1863)
        {
            int InternalVar_1 = InternalField_1611.Length;
            for (int InternalVar_2 = 0; InternalVar_2 < InternalField_1612.Length; InternalVar_2++)
            {
                float2 InternalVar_3 = InternalField_1612[InternalVar_2];
                InternalVar_3 *= InternalParameter_1862;
                InternalParameter_1861.InternalField_1365 = 2f * (new float3(InternalVar_3, InternalParameter_1861.InternalField_1363.z) - InternalParameter_1861.InternalField_1363);

                float3 InternalVar_4 = new float3(-InternalVar_3, -InternalParameter_1861.InternalField_1363.z);

                for (int InternalVar_5 = 0; InternalVar_5 < InternalField_1616; InternalVar_5++)
                {
                    InternalParameter_1861.InternalField_1366 = InternalField_1613[InternalVar_5] * InternalVar_4 * 2;

                    float3 InternalVar_6 = InternalParameter_1861.InternalField_1363 + InternalParameter_1861.InternalField_1365 * 0.5f + InternalParameter_1861.InternalField_1366 * 0.5f;
                    InternalParameter_1861.InternalField_1364 = math.normalize(InternalVar_6);
                    InternalField_1611.Add(InternalParameter_1861);
                }

                if (InternalVar_2 == 0)
                {
                    continue;
                }

                InternalMethod_1680(InternalParameter_1863, InternalVar_1 + InternalVar_2 * InternalField_1616, InternalVar_1 + (InternalVar_2 - 1) * InternalField_1616);

                for (int InternalVar_5 = 0; InternalVar_5 < InternalField_1609 + 1; ++InternalVar_5)
                {
                    InternalMethod_1679(InternalVar_1 + InternalVar_2 * InternalField_1616 + InternalVar_5, InternalVar_1 + InternalVar_2 * InternalField_1616 + InternalVar_5 + 1, InternalVar_1 + (InternalVar_2 - 1) * InternalField_1616 + InternalVar_5 + 1, InternalVar_1 + (InternalVar_2 - 1) * InternalField_1616 + InternalVar_5);
                }
            }
        }

        private void InternalMethod_1678()
        {
            InternalField_1615 = InternalField_1608 + 2;
            InternalField_1616 = InternalField_1609 + 2;
            InternalField_1614 = InternalField_1615 * InternalField_1616;
            InternalField_1617 = .5f * math.PI / (InternalField_1608 + 1);
            InternalField_1618 = .5f * math.PI / (InternalField_1609 + 1);

            InternalField_1612.Length = InternalField_1615;
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1615; InternalVar_1++)
            {
                float2 InternalVar_2 = default;
                math.sincos(InternalVar_1 * InternalField_1617, out InternalVar_2.y, out InternalVar_2.x);
                InternalField_1612[InternalVar_1] = InternalVar_2;
            }

            InternalField_1613.Length = InternalField_1616;
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1616; InternalVar_1++)
            {
                float2 InternalVar_2 = default;
                math.sincos(InternalVar_1 * InternalField_1618, out InternalVar_2.y, out InternalVar_2.x);
                InternalField_1613[InternalVar_1] = new float3(-InternalVar_2.yy + 1f, -InternalVar_2.x + 1f);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1679(int InternalParameter_1864, int InternalParameter_1865, int InternalParameter_1866, int InternalParameter_1867)
        {
            InternalMethod_1680(InternalParameter_1864, InternalParameter_1865, InternalParameter_1866);
            InternalMethod_1680(InternalParameter_1866, InternalParameter_1867, InternalParameter_1864);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1680(int InternalParameter_1868, int InternalParameter_1869, int InternalParameter_1870)
        {
            if (InternalField_1620)
            {
                InternalField_1610.Add((ushort)InternalParameter_1870);
                InternalField_1610.Add((ushort)InternalParameter_1869);
                InternalField_1610.Add((ushort)InternalParameter_1868);
            }
            else
            {
                InternalField_1610.Add((ushort)InternalParameter_1868);
                InternalField_1610.Add((ushort)InternalParameter_1869);
                InternalField_1610.Add((ushort)InternalParameter_1870);
            }
        }
    }
}

