using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal unsafe struct InternalType_397 : InternalType_193
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_1399;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_373>> InternalField_1400;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_284> InternalField_1401;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_133, InternalType_304> InternalField_1402;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_299<InternalType_71>> InternalField_1403;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_376 InternalField_1404;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_304, InternalType_356>> InternalField_1405;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_79> InternalField_1406;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_371 InternalField_1407;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_133> InternalField_1408;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1409;
        [NativeDisableContainerSafetyRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<float4x4> InternalField_1410;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_643, InternalType_306> InternalField_1411;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_372 InternalField_1412;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_643, InternalType_131> InternalField_1146;

        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_302> InternalField_1413;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_305>> InternalField_1414;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_131 InternalField_1415;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_302 InternalField_1416;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_284 InternalField_1417;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_162<InternalType_288, InternalType_373> InternalField_1418;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_162<InternalType_288, InternalType_305> InternalField_1419;

        public void Execute(int index)
        {
            InternalField_1415 = InternalField_1399[index];
            InternalField_1416 = InternalField_1413[InternalField_1415];
            InternalField_1417 = InternalField_1401[InternalField_1415];
            InternalField_1418 = InternalField_1400[InternalField_1415];
            InternalField_1419 = InternalField_1414.InternalMethod_1297(InternalField_1415, InternalField_1418.InternalProperty_216);
            InternalField_1419.InternalMethod_763();

            if (!InternalField_1417.InternalMethod_1284(0, out InternalType_288 InternalVar_1, out InternalType_284.InternalType_286 InternalVar_2))
            {
                return;
            }

            do
            {
                InternalMethod_1608(InternalVar_1);
            } while (InternalField_1417.InternalMethod_1285(out InternalVar_1, ref InternalVar_2));

            InternalField_1416.InternalMethod_1345();
            InternalMethod_1546();

            InternalField_1413[InternalField_1415] = InternalField_1416;
            InternalField_1414[InternalField_1415] = InternalField_1419;
        }

        
        private void InternalMethod_1546()
        {
            InternalType_162<InternalType_304, InternalType_356> InternalVar_1 = InternalField_1405[InternalField_1415];

            for (int InternalVar_2 = 0; InternalVar_2 < InternalField_1416.InternalField_992.InternalProperty_216; ++InternalVar_2)
            {
                ref InternalType_300 InternalVar_3 = ref InternalField_1416.InternalField_992.InternalMethod_758(InternalVar_2);
                ref InternalType_276 InternalVar_4 = ref InternalField_1416.InternalField_991.InternalMethod_758(InternalVar_3.InternalField_986);
                if (!InternalVar_4.InternalField_902.InternalMethod_1605())
                {
                    continue;
                }

                ref InternalType_356 InternalVar_5 = ref InternalVar_1.InternalMethod_758(InternalVar_3.InternalField_988);

                if (InternalVar_4.InternalField_900.InternalProperty_761 &&
                    InternalField_1411.TryGetValue(InternalVar_4.InternalField_900, out InternalType_306 InternalVar_6))
                {
                    InternalType_133 InternalVar_7 = InternalField_1408[InternalVar_5.InternalField_577];
                    InternalType_133 InternalVar_8 = InternalField_1408[InternalField_1146[InternalVar_4.InternalField_900]];
                    ref float4x4 InternalVar_9 = ref InternalField_1409.ElementAt(InternalVar_8);
                    ref float4x4 InternalVar_10 = ref InternalField_1410.ElementAt(InternalVar_7);
                    InternalType_306 InternalVar_11 = InternalType_306.InternalMethod_1378(ref InternalVar_9, ref InternalVar_10, ref InternalVar_3.InternalField_578);
                    InternalVar_11.InternalMethod_1367(ref InternalVar_6);

                    ref float4x4 InternalVar_12 = ref InternalField_1410.ElementAt(InternalVar_8);
                    ref float4x4 InternalVar_13 = ref InternalField_1409.ElementAt(InternalVar_7);
                    InternalVar_3.InternalField_578 = InternalType_306.InternalMethod_1378(ref InternalVar_13, ref InternalVar_12, ref InternalVar_11);
                }

                InternalVar_3.InternalField_989 = InternalVar_5.InternalField_1246++;
                InternalVar_5.InternalField_1244.InternalMethod_1376(ref InternalVar_3.InternalField_578);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1608(InternalType_288 InternalParameter_1744)
        {
            ref InternalType_373 InternalVar_1 = ref InternalField_1418.InternalMethod_758(InternalParameter_1744);
            if (InternalVar_1.InternalField_1298)
            {
                return;
            }

            InternalType_304 InternalVar_2 = InternalField_1402[InternalVar_1.InternalField_1294];
            InternalType_305 InternalVar_3 = InternalMethod_1610(ref InternalVar_1);
            if (!InternalField_1416.InternalMethod_1348(InternalVar_1.InternalField_1296, InternalField_1402[InternalVar_1.InternalField_1294], InternalVar_3, out InternalType_305 InternalVar_4))
            {
                InternalVar_4 = InternalField_1416.InternalMethod_1349(InternalVar_1.InternalField_1296, InternalVar_2);
            }

            ref InternalType_306 InternalVar_5 = ref InternalMethod_1609(ref InternalVar_1);
            InternalType_348 InternalVar_6 = InternalField_1403[InternalVar_1.InternalField_1294].InternalField_984;
            switch (InternalVar_1.InternalField_1297)
            {
                case InternalType_266.InternalField_789:
                    InternalType_259 InternalVar_7 = InternalField_1407.InternalField_1290[InternalVar_6];
                    InternalVar_7 *= InternalType_178.InternalField_475;
                    for (int InternalVar_8 = 0; InternalVar_8 < InternalType_178.InternalField_475; ++InternalVar_8)
                    {
                        InternalField_1416.InternalMethod_1350(InternalVar_7 + InternalVar_8, ref InternalVar_4, ref InternalVar_5);
                    }
                    break;
                case InternalType_266.InternalField_788:
                case InternalType_266.InternalField_790:
                {
                    InternalType_164<InternalType_259> InternalVar_8 = InternalField_1407.InternalField_1291[InternalVar_6];
                    ref InternalType_276 InternalVar_9 = ref InternalField_1416.InternalField_991.InternalMethod_758(InternalVar_1.InternalField_1296);
                    InternalType_79 InternalVar_10 = InternalField_1406[InternalVar_6];
                    InternalVar_10.InternalMethod_481(InternalVar_9.InternalField_906.InternalField_918, out int InternalVar_11, out int InternalVar_12);
                    for (int InternalVar_13 = 0; InternalVar_13 < InternalVar_12; ++InternalVar_13)
                    {
                        InternalField_1416.InternalMethod_1350(InternalVar_8[InternalVar_11 + InternalVar_13], ref InternalVar_4, ref InternalVar_5);
                    }
                    break;
                }
                case InternalType_266.InternalField_786:
                    InternalField_1416.InternalMethod_1351(ref InternalVar_4, ref InternalVar_5, ref InternalParameter_1744);
                    break;
                case InternalType_266.InternalField_787:
                    InternalField_1416.InternalMethod_1350(InternalField_1407.InternalField_1289[InternalVar_6], ref InternalVar_4, ref InternalVar_5);
                    break;
                default:
                    Debug.LogError("Unknown visual type");
                    break;
            }

            InternalField_1419[InternalParameter_1744] = InternalVar_4;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ref InternalType_306 InternalMethod_1609(ref InternalType_373 InternalParameter_1745)
        {
            if (InternalParameter_1745.InternalField_1297 == InternalType_266.InternalField_789)
            {
                return ref InternalField_1404.InternalField_1304.InternalMethod_748(InternalField_1407.InternalField_1290[InternalParameter_1745.InternalField_1295]).InternalField_1301.InternalField_1300;
            }
            else
            {
                return ref InternalField_1404.InternalField_1303.InternalMethod_748(InternalParameter_1745.InternalField_1294).InternalField_1300;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private InternalType_305 InternalMethod_1610(ref InternalType_373 InternalParameter_1746)
        {
            InternalType_305 InternalVar_1 = InternalType_305.InternalField_1004;
            ref InternalType_164<InternalType_288> InternalVar_2 = ref InternalField_1412.InternalMethod_1583(ref InternalParameter_1746, ref InternalField_1407);
            for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_2.InternalProperty_216; ++InternalVar_3)
            {
                InternalVar_1 = InternalType_305.InternalMethod_1361(ref InternalVar_1, ref InternalField_1419.InternalMethod_758(InternalVar_2[InternalVar_3]));
            }
            return InternalVar_1;
        }
    }
}

