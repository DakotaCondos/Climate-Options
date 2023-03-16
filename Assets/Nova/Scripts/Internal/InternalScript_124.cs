using AOT;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_9
{
    internal partial class InternalType_227
    {
        private enum InternalType_230
        {
            InternalField_639,
            InternalField_640,
            InternalField_641,
            InternalField_642,
            InternalField_643,
            InternalField_644,
            InternalField_645,
            InternalField_646,
            InternalField_647,
            InternalField_648,
            InternalField_649,
            InternalField_650,
            InternalField_651,
            InternalField_652,
            InternalField_654,
            InternalField_655,
            InternalField_656,
            InternalField_657,
            InternalField_3564,
        }


        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_176))]
        private static unsafe void InternalMethod_1101(void* InternalParameter_1129, int InternalParameter_1130)
        {
            InternalType_230 InternalVar_1 = (InternalType_230)InternalParameter_1130;

            switch (InternalVar_1)
            {
                case InternalType_230.InternalField_639:
                    UnsafeUtility.AsRef<InternalType_231>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_640:
                    UnsafeUtility.AsRef<InternalType_232>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_641:
                    UnsafeUtility.AsRef<InternalType_233>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_642:
                    UnsafeUtility.AsRef<InternalType_234>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_643:
                    UnsafeUtility.AsRef<InternalType_238>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_644:
                    UnsafeUtility.AsRef<InternalType_237>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_645:
                    UnsafeUtility.AsRef<InternalType_236>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_646:
                    UnsafeUtility.AsRef<InternalType_235>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_647:
                    UnsafeUtility.AsRef<InternalType_239>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_648:
                    UnsafeUtility.AsRef<InternalType_240>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_649:
                    UnsafeUtility.AsRef<InternalType_241>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_650:
                    UnsafeUtility.AsRef<InternalType_242>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_652:
                    UnsafeUtility.AsRef<InternalType_243>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_651:
                    UnsafeUtility.AsRef<InternalType_244>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_654:
                    UnsafeUtility.AsRef<InternalType_246>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_655:
                    UnsafeUtility.AsRef<InternalType_247>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_656:
                    UnsafeUtility.AsRef<InternalType_248>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_657:
                    UnsafeUtility.AsRef<InternalType_249>(InternalParameter_1129).Execute();
                    break;
                case InternalType_230.InternalField_3564:
                    UnsafeUtility.AsRef<InternalType_760>(InternalParameter_1129).InternalMethod_3604();
                    break;
            }
        }

        
        private struct InternalType_231 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_658;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_659;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_133 InternalField_660;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_661;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_662;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_663;

            public void Execute()
            {
                InternalField_663 = InternalMethod_1102(InternalField_660, InternalField_661, InternalField_662, ref InternalField_658, ref InternalField_659);
            }
        }

        
        private struct InternalType_232 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_664;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_665;

            public void Execute()
            {
                InternalMethod_1104(InternalField_665, ref InternalField_664);
            }
        }

        private struct InternalType_233 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_666;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_667;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_668;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_669;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_670;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_671;

            public void Execute()
            {
                InternalType_133 InternalVar_1 = InternalField_666.InternalField_628.Length;
                InternalField_666.InternalField_632.Add(InternalField_667, InternalVar_1);

                InternalType_222 InternalVar_2 = InternalType_222.InternalMethod_1059(InternalField_667);
                InternalVar_2.InternalField_587 = InternalField_666.InternalMethod_1127();

                InternalField_666.InternalField_628.Add(InternalVar_2);
                InternalField_666.InternalField_633.InternalMethod_1063();

                InternalField_666.InternalField_630.Add(InternalField_668);

                if (InternalField_670.InternalProperty_192)
                {
                    _ = InternalMethod_1102(InternalVar_1, InternalField_670, InternalField_668, ref InternalField_666, ref InternalField_669);
                }
                else if (!InternalField_671)
                {
                    InternalType_236.InternalMethod_1136(InternalField_667, ref InternalField_666);
                }
            }

            [BurstCompile]
            [MonoPInvokeCallback(typeof(InternalType_175))]
            public static unsafe void InternalMethod_1135(void* InternalParameter_1217)
            {
                UnsafeUtility.AsRef<InternalType_232>(InternalParameter_1217).Execute();
            }
        }

        private struct InternalType_234 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_672;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_673;

            public void Execute()
            {
                InternalMethod_1117(InternalField_673, ref InternalField_672);
            }
        }

        private struct InternalType_235 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_674;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_675;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_676;

            public void Execute()
            {
                if (!InternalField_674.InternalField_629.InternalMethod_838(InternalField_675) || InternalField_676)
                {
                    return;
                }

                InternalMethod_1118(InternalField_675, ref InternalField_674);
            }
        }

        private struct InternalType_236 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_677;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_678;

            public void Execute()
            {
                InternalMethod_1136(InternalField_678, ref InternalField_677);
            }

            public static void InternalMethod_1136(InternalType_131 InternalParameter_1218, ref InternalType_228 InternalParameter_1219)
            {
                if (!InternalParameter_1219.InternalField_629.InternalMethod_837(InternalParameter_1218))
                {
                    return;
                }

                InternalMethod_1119(InternalParameter_1218, ref InternalParameter_1219);
            }
        }

        private struct InternalType_237 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_679;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_680;

            public void Execute()
            {
                InternalMethod_1118(InternalField_680, ref InternalField_679);
            }
        }

        private struct InternalType_238 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_681;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_682;

            public void Execute()
            {
                InternalMethod_1119(InternalField_682, ref InternalField_681);
            }
        }

        
        private struct InternalType_239 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_683;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_684;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_222 InternalField_685;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_686;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_687;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_688;

            public void Execute()
            {
                InternalMethod_1111(InternalField_686, InternalField_687, InternalField_688, ref InternalField_685, ref InternalField_684, ref InternalField_683);
            }
        }

        
        private struct InternalType_240 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_689;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_690;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_222 InternalField_691;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_692;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_693;

            public void Execute()
            {
                InternalMethod_1112(InternalField_692, InternalField_693, ref InternalField_691, ref InternalField_690, ref InternalField_689);
            }
        }

        
        private struct InternalType_241 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_694;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_695;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_222 InternalField_696;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_697;

            public void Execute()
            {
                InternalMethod_1113(InternalField_697, ref InternalField_696, ref InternalField_695, ref InternalField_694);
            }
        }

        
        private struct InternalType_242 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_698;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_699;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_252 InternalField_700;

            public void Execute()
            {
                int InternalVar_1 = InternalMethod_1107(ref InternalField_700.InternalField_740, ref InternalField_699, ref InternalField_698);
                InternalMethod_1108(ref InternalField_700, ref InternalField_699, InternalVar_1, ref InternalField_698);
            }
        }

        private struct InternalType_243 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_701;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_133 InternalField_702;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_703;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_704;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<int> InternalField_705;

            public void Execute()
            {
                int InternalVar_1 = InternalField_704.Length;
                for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; ++InternalVar_2)
                {
                    InternalField_701.InternalField_630[InternalField_704[InternalVar_2]] = InternalField_705[InternalVar_2];
                }

                if (InternalField_701.InternalField_631.TryGetValue(InternalField_703, out InternalType_252 InternalVar_3))
                {
                    InternalMethod_1108(ref InternalVar_3, ref InternalField_704, InternalVar_1, ref InternalField_701);
                }
                else 
                {
                    InternalType_222 InternalVar_4 = InternalField_701.InternalField_628[InternalField_702];

                    if (InternalVar_4.InternalProperty_253 != InternalVar_1) 
                    {
                        Debug.LogError($"Called UpdateChildOrder with {InternalField_704.Length} children while hierarchy is tracking {InternalVar_4.InternalProperty_253}.");
                        return;
                    }

                    InternalType_164<InternalType_133> InternalVar_5 = InternalVar_4.InternalField_587;
                    InternalVar_5.InternalMethod_705();

                    unsafe
                    {
                        InternalVar_5.InternalMethod_790(InternalField_704.GetUnsafeReadOnlyPtr(), InternalVar_1);
                    }

                    InternalVar_4.InternalField_587 = InternalVar_5;

                    InternalField_701.InternalField_628[InternalField_702] = InternalVar_4;
                    InternalField_701.InternalField_633.InternalMethod_1065(InternalField_702);
                }
            }
        }

        
        private struct InternalType_244 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_706;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_707;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_708;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_709;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_710;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_711;

            public void Execute()
            {
                InternalMethod_1116(InternalField_708, InternalField_707, InternalField_710, InternalField_711, ref InternalField_709, ref InternalField_706);
            }
        }

        
        private struct InternalType_246 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228 InternalField_716;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_717;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_718;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_719;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_720;

            public void Execute()
            {
                InternalField_720 = -1;
                InternalType_133 InternalVar_1 = InternalType_133.InternalField_418;

                if (!InternalField_718.InternalProperty_192)
                {
                    if (!InternalField_719.InternalProperty_192)
                    {
                        Debug.LogError("Unable to retrieve children or siblings of invalid elements.");
                        return;
                    }

                    InternalVar_1 = InternalField_716.InternalField_632[InternalField_719];
                    InternalField_718 = InternalField_716.InternalField_628[InternalVar_1].InternalField_586;
                }

                InternalMethod_1115(InternalField_718, ref InternalField_717, ref InternalField_716);

                if (InternalVar_1.InternalProperty_194)
                {
                    _ = InternalField_717.InternalMethod_1011(InternalVar_1, out InternalField_720);
                }
            }
        }

        [BurstCompile]
        private struct InternalType_247 : InternalType_192
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228.InternalType_229 InternalField_721;

            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_131> InternalField_722;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_723;

            public void Execute()
            {
                InternalMethod_1137(ref InternalField_721, ref InternalField_722, ref InternalField_723);
            }

            public static void InternalMethod_1137(ref InternalType_228.InternalType_229 InternalParameter_1220, ref NativeList<InternalType_131> InternalParameter_1221, ref NativeList<InternalType_133> InternalParameter_1222)
            {
                int InternalVar_1 = InternalParameter_1221.Length;
                InternalParameter_1222.Clear();

                if (InternalVar_1 == 0)
                {
                    return;
                }

                for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; ++InternalVar_2)
                {
                    InternalType_133 InternalVar_3 = InternalParameter_1220.InternalField_637[InternalParameter_1221[InternalVar_2]];

                    if (InternalParameter_1220.InternalField_635[InternalVar_3].InternalField_586.InternalProperty_192)
                    {
                        bool InternalVar_4 = false;
                        for (int InternalVar_5 = 0; InternalVar_5 < InternalVar_1; ++InternalVar_5)
                        {
                            if (InternalVar_5 == InternalVar_2)
                            {
                                continue;
                            }

                            if (InternalParameter_1220.InternalMethod_3603(InternalVar_3, InternalParameter_1221[InternalVar_5], out _))
                            {
                                InternalVar_4 = true;
                                break;
                            }
                        }

                        if (InternalVar_4)
                        {
                            continue;
                        }
                    }

                    InternalParameter_1222.Add(InternalVar_3);

                    unsafe
                    {
                        for (int InternalVar_4 = InternalParameter_1222.Length - 1; InternalVar_4 < InternalParameter_1222.Length; ++InternalVar_4)
                        {
                            InternalType_164<InternalType_133> InternalVar_5 = InternalParameter_1220.InternalField_635[InternalParameter_1222[InternalVar_4]].InternalField_587;

                            if (InternalVar_5.InternalProperty_216 > 0)
                            {
                                InternalParameter_1222.AddRange(InternalVar_5.InternalProperty_232, InternalVar_5.InternalProperty_216);
                            }
                        }
                    }
                }
            }
        }

        [BurstCompile]
        private struct InternalType_760
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228.InternalType_229 InternalField_3565;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_3566;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_133 InternalField_3567;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_3568;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_3569;

            public void InternalMethod_3604()
            {
                InternalField_3568 = InternalField_3565.InternalMethod_3603(InternalField_3567, InternalField_3566, out InternalField_3569);
            }
        }

        [BurstCompile]
        private struct InternalType_248 : InternalType_192
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228.InternalType_229 InternalField_724;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_131> InternalField_725;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_133> InternalField_726;

            public void Execute()
            {
                InternalField_724.InternalField_638.InternalMethod_1069(ref InternalField_725);
                InternalType_247.InternalMethod_1137(ref InternalField_724, ref InternalField_725, ref InternalField_726);
            }
        }

        private struct InternalType_249 : IJob
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_228.InternalType_229 InternalField_727;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_131 InternalField_728;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<InternalType_131> InternalField_729;

            public void Execute()
            {
                InternalField_729.Clear();

                InternalType_131 InternalVar_1 = InternalField_728;
                InternalType_131 InternalVar_2 = InternalField_728;

                while (InternalField_727.InternalField_637.TryGetValue(InternalVar_2, out InternalType_133 InternalVar_3))
                {
                    InternalVar_1 = InternalVar_2;
                    InternalVar_2 = InternalField_727.InternalField_635[InternalVar_3].InternalField_586;
                }

                InternalField_729.Add(InternalVar_1);
            }
        }

        private static int InternalMethod_1102(InternalType_133 InternalParameter_1131, InternalType_131 InternalParameter_1132, int InternalParameter_1133, ref InternalType_228 InternalParameter_1134, ref NativeList<InternalType_133> InternalParameter_1135)
        {
            int InternalVar_1 = -1;

            if (!InternalParameter_1134.InternalField_632.TryGetValue(InternalParameter_1132, out InternalType_133 InternalVar_2))
            {
                Debug.LogError("Called SetParent when parent was not found.");
                return InternalVar_1;
            }

            InternalType_131 InternalVar_3 = InternalParameter_1134.InternalMethod_1124(InternalParameter_1131);

            if (InternalVar_3 == InternalParameter_1132)
            {
                _ = InternalMethod_1115(InternalParameter_1132, ref InternalParameter_1135, ref InternalParameter_1134);

                _ = InternalParameter_1135.InternalMethod_1011(InternalParameter_1131, out InternalVar_1);
                return InternalVar_1;
            }

            int InternalVar_4 = InternalMethod_1115(InternalParameter_1132, ref InternalParameter_1135, ref InternalParameter_1134);

            int InternalVar_5 = InternalParameter_1135.Length;
            bool InternalVar_6 = InternalParameter_1133 < InternalVar_5 * 0.5f;
            InternalVar_1 = InternalVar_6 ? 0 : InternalVar_5;

            if (InternalVar_6)
            {
                while (InternalVar_1 < InternalVar_5 && InternalParameter_1134.InternalField_630[InternalParameter_1135[InternalVar_1]] <= InternalParameter_1133)
                {
                    InternalVar_1++;
                }
            }
            else
            {
                while (InternalVar_1 > 0 && InternalParameter_1134.InternalField_630[InternalParameter_1135[InternalVar_1 - 1]] >= InternalParameter_1133)
                {
                    InternalVar_1--;
                }
            }

            InternalParameter_1134.InternalField_630[InternalParameter_1131] = InternalParameter_1133;

            if (InternalParameter_1134.InternalField_631.TryGetValue(InternalParameter_1132, out InternalType_252 InternalVar_7))
            {
                InternalVar_4++;

                InternalParameter_1135.InternalMethod_1016(InternalVar_1, InternalParameter_1131);

                InternalMethod_1108(ref InternalVar_7, ref InternalParameter_1135, InternalVar_4, ref InternalParameter_1134);
            }
            else
            {
                InternalType_222 InternalVar_8 = InternalParameter_1134.InternalField_628[InternalVar_2];
                InternalMethod_1103(InternalParameter_1131, ref InternalVar_8, InternalVar_1, ref InternalParameter_1134);
            }

            return InternalVar_1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1103(InternalType_133 InternalParameter_1136, ref InternalType_222 InternalParameter_1137, int InternalParameter_1138, ref InternalType_228 InternalParameter_1139)
        {
            InternalType_222 InternalVar_1 = InternalParameter_1139.InternalField_628[InternalParameter_1136];

            if (InternalVar_1.InternalField_586.InternalProperty_192)
            {
                InternalMethod_1104(InternalVar_1.InternalField_585, ref InternalParameter_1139);

                InternalVar_1 = InternalParameter_1139.InternalField_628[InternalParameter_1136];
            }

            InternalVar_1.InternalField_586 = InternalParameter_1137.InternalField_585;
            InternalParameter_1139.InternalField_628[InternalParameter_1136] = InternalVar_1;

            InternalType_164<InternalType_133> InternalVar_2 = InternalParameter_1137.InternalField_587;
            InternalVar_2.InternalMethod_801(InternalParameter_1138, InternalParameter_1136);
            InternalParameter_1137.InternalField_587 = InternalVar_2;

            InternalType_131 InternalVar_3 = InternalParameter_1137.InternalField_585;
            InternalType_133 InternalVar_4 = InternalParameter_1139.InternalField_632[InternalVar_3];
            InternalParameter_1139.InternalField_628[InternalVar_4] = InternalParameter_1137;

            InternalParameter_1139.InternalField_633.InternalMethod_1066(InternalParameter_1136, InternalVar_4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1104(InternalType_131 InternalParameter_1140, ref InternalType_228 InternalParameter_1141)
        {
            if (!InternalParameter_1141.InternalField_632.TryGetValue(InternalParameter_1140, out InternalType_133 InternalVar_1))
            {
                Debug.LogError("Called Unparent when child was not found.");
                return;
            }

            InternalType_222 InternalVar_2 = InternalParameter_1141.InternalField_628[InternalVar_1];

            if (!InternalVar_2.InternalField_586.InternalProperty_192)
            {
                return;
            }

            if (!InternalParameter_1141.InternalField_632.TryGetValue(InternalVar_2.InternalField_586, out InternalType_133 InternalVar_3))
            {
                Debug.LogError($"Called Unparent when parent was not found.");
                return;
            }

            InternalType_222 InternalVar_4 = InternalParameter_1141.InternalField_628[InternalVar_3];

            InternalMethod_1105(InternalVar_1, ref InternalVar_4, ref InternalParameter_1141);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1105(InternalType_133 InternalParameter_1142, ref InternalType_222 InternalParameter_1143, ref InternalType_228 InternalParameter_1144)
        {
            if (!InternalParameter_1143.InternalField_587.InternalMethod_769(InternalParameter_1142, out int InternalVar_1))
            {
                Debug.LogError($"ChildIndex [{(int)InternalParameter_1142}] not found in parent [0x{InternalParameter_1143.InternalField_585:X8}] list. Something is broken");
            }

            InternalType_164<InternalType_133> InternalVar_2 = InternalParameter_1143.InternalField_587;
            InternalVar_2.InternalMethod_791(InternalVar_1);
            InternalParameter_1143.InternalField_587 = InternalVar_2;

            InternalType_222 InternalVar_3 = InternalParameter_1144.InternalField_628[InternalParameter_1142];
            InternalVar_3.InternalField_586 = InternalType_131.InternalField_415;
            InternalParameter_1144.InternalField_628[InternalParameter_1142] = InternalVar_3;

            InternalType_131 InternalVar_4 = InternalParameter_1143.InternalField_585;
            InternalType_133 InternalVar_5 = InternalParameter_1144.InternalField_632[InternalVar_4];
            InternalParameter_1144.InternalField_628[InternalVar_5] = InternalParameter_1143;

            InternalParameter_1144.InternalField_633.InternalMethod_1066(InternalParameter_1142, InternalVar_5);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void InternalMethod_1106(ref InternalType_222 InternalParameter_1145, InternalType_131 InternalParameter_1146, ref NativeList<InternalType_133> InternalParameter_1147, ref InternalType_228 InternalParameter_1148)
        {
            InternalType_133 InternalVar_1 = InternalParameter_1148.InternalField_632[InternalParameter_1146];

            InternalParameter_1147.AddRange(InternalParameter_1145.InternalField_587.InternalProperty_232, InternalParameter_1145.InternalField_587.InternalProperty_216);

            for (int InternalVar_2 = 0; InternalVar_2 < InternalParameter_1147.Length; ++InternalVar_2)
            {
                InternalType_222 InternalVar_3 = InternalParameter_1148.InternalField_628[InternalVar_1];
                InternalMethod_1103(InternalParameter_1147[InternalVar_2], ref InternalVar_3, InternalVar_2, ref InternalParameter_1148);
            }

            InternalParameter_1147.Clear();
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int InternalMethod_1107(ref InternalType_164<InternalType_131> InternalParameter_1149, ref NativeList<InternalType_133> InternalParameter_1150, ref InternalType_228 InternalParameter_1151)
        {
            int InternalVar_1 = 0;

            for (int InternalVar_2 = 0; InternalVar_2 < InternalParameter_1149.InternalProperty_216; ++InternalVar_2)
            {
                InternalType_133 InternalVar_3 = InternalParameter_1151.InternalField_632[InternalParameter_1149[InternalVar_2]];
                InternalType_222 InternalVar_4 = InternalParameter_1151.InternalField_628[InternalVar_3];

                InternalType_164<InternalType_133> InternalVar_5 = InternalVar_4.InternalField_587;
                int InternalVar_6 = InternalVar_5.InternalProperty_216;

                InternalParameter_1150.AddRange(InternalVar_5.InternalProperty_232, InternalVar_6);

                InternalVar_1 += InternalVar_6;
            }

            return InternalVar_1;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void InternalMethod_1108(ref InternalType_252 InternalParameter_1152, ref NativeList<InternalType_133> InternalParameter_1153, int InternalParameter_1154, ref InternalType_228 InternalParameter_1155)
        {
            InternalType_164<InternalType_131> InternalVar_1 = InternalParameter_1152.InternalField_740;

            int InternalVar_2 = InternalParameter_1154 / InternalVar_1.InternalProperty_216;
            InternalVar_2 = math.select(InternalVar_2 + 1, InternalVar_2, InternalParameter_1154 % InternalVar_1.InternalProperty_216 == 0);

            InternalVar_2 = math.max(InternalVar_2, InternalParameter_1152.InternalField_741);

            int InternalVar_3 = 0;
            int InternalVar_4 = 0;

            while (InternalVar_4 < InternalParameter_1153.Length && InternalVar_3 < InternalVar_1.InternalProperty_216)
            {
                InternalType_131 InternalVar_5 = InternalVar_1[InternalVar_3++];
                InternalVar_4 = InternalMethod_1109(InternalVar_4, InternalVar_2, InternalVar_5, ref InternalParameter_1153, ref InternalParameter_1155);
            }

            InternalParameter_1153.Clear();
        }

        
        private static int InternalMethod_1109(int InternalParameter_1156, int InternalParameter_1157, InternalType_131 InternalParameter_1158, ref NativeList<InternalType_133> InternalParameter_1159, ref InternalType_228 InternalParameter_1160)
        {
            int InternalVar_1 = InternalParameter_1156;

            int InternalVar_2 = 0;
            int InternalVar_3 = 0;

            InternalType_133 InternalVar_4 = InternalParameter_1160.InternalField_632[InternalParameter_1158];
            while (InternalVar_2 < InternalParameter_1157 && InternalVar_1 < InternalParameter_1159.Length)
            {
                if (InternalVar_1 >= InternalParameter_1159.Length)
                {
                    return InternalVar_1;
                }

                InternalType_133 InternalVar_5 = InternalParameter_1159[InternalVar_1];

                InternalType_222 InternalVar_6 = InternalParameter_1160.InternalField_628[InternalVar_4];

                InternalMethod_1110(InternalVar_5, InternalVar_3, InternalVar_4, ref InternalVar_6, ref InternalParameter_1160);

                InternalVar_3++;
                InternalVar_2++;
                InternalVar_1++;
            }

            return InternalVar_1;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1110(InternalType_133 InternalParameter_1161, int InternalParameter_1162, InternalType_133 InternalParameter_1163, ref InternalType_222 InternalParameter_1164, ref InternalType_228 InternalParameter_1165)
        {
            InternalType_222 InternalVar_1 = InternalParameter_1165.InternalField_628[InternalParameter_1161];

            if (InternalVar_1.InternalField_586 != InternalParameter_1164.InternalField_585)
            {
                InternalMethod_1103(InternalParameter_1161, ref InternalParameter_1164, InternalParameter_1162, ref InternalParameter_1165);
                return;
            }

            InternalType_164<InternalType_133> InternalVar_2 = InternalParameter_1164.InternalField_587;

            if (InternalVar_2.InternalMethod_769(InternalParameter_1161, out int InternalVar_3) && InternalVar_3 != InternalParameter_1162)
            {
                InternalVar_2.InternalMethod_791(InternalVar_3);
                InternalVar_2.InternalMethod_801(InternalParameter_1162, InternalParameter_1161);
                InternalParameter_1164.InternalField_587 = InternalVar_2;
                InternalParameter_1165.InternalField_633.InternalMethod_1066(InternalParameter_1161, InternalParameter_1163);
            }
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1111(InternalType_131 InternalParameter_1166, int InternalParameter_1167, bool InternalParameter_1168, ref InternalType_222 InternalParameter_1169, ref NativeList<InternalType_133> InternalParameter_1170, ref InternalType_228 InternalParameter_1171)
        {
            if (!InternalParameter_1171.InternalField_631.TryGetValue(InternalParameter_1169.InternalField_585, out InternalType_252 InternalVar_1))
            {
                InternalVar_1 = new InternalType_252()
                {
                    InternalField_740 = new InternalType_164<InternalType_131>(4, Allocator.Persistent),
                };
            }

            InternalType_164<InternalType_131> InternalVar_2 = InternalVar_1.InternalField_740;

            int InternalVar_3 = math.select(InternalVar_2.InternalProperty_216, 0, InternalParameter_1168);
            InternalVar_2.InternalMethod_801(InternalVar_3, InternalParameter_1166);

            InternalVar_1.InternalField_740 = InternalVar_2;
            InternalVar_1.InternalField_741 = InternalParameter_1167;

            InternalParameter_1171.InternalField_631[InternalParameter_1169.InternalField_585] = InternalVar_1;

            if (InternalVar_2.InternalProperty_216 == 1)
            {
                InternalMethod_1106(ref InternalParameter_1169, InternalParameter_1166, ref InternalParameter_1170, ref InternalParameter_1171);
            }
            else
            {
                int InternalVar_4 = InternalMethod_1107(ref InternalVar_2, ref InternalParameter_1170, ref InternalParameter_1171);
                InternalMethod_1108(ref InternalVar_1, ref InternalParameter_1170, InternalVar_4, ref InternalParameter_1171);
            }

            InternalParameter_1169 = InternalParameter_1171.InternalField_628[InternalParameter_1171.InternalField_632[InternalParameter_1169.InternalField_585]];
            InternalMethod_1103(InternalParameter_1171.InternalField_632[InternalParameter_1166], ref InternalParameter_1169, InternalVar_3, ref InternalParameter_1171);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1112(InternalType_131 InternalParameter_1172, int InternalParameter_1173, ref InternalType_222 InternalParameter_1174, ref NativeList<InternalType_133> InternalParameter_1175, ref InternalType_228 InternalParameter_1176)
        {
            if (!InternalParameter_1176.InternalField_631.TryGetValue(InternalParameter_1174.InternalField_585, out InternalType_252 InternalVar_1))
            {
                Debug.LogError($"Virtual Proxy, {InternalParameter_1172}, not found in parent proxy container.");
                return;
            }

            InternalType_164<InternalType_131> InternalVar_2 = InternalVar_1.InternalField_740;

            if (!InternalVar_2.InternalMethod_769(InternalParameter_1172, out int InternalVar_3))
            {
                Debug.LogError($"Virtual Proxy, {InternalParameter_1172}, not found in parent proxy container.");
                return;
            }

            if (InternalVar_3 == InternalParameter_1173)
            {
                return;
            }

            int InternalVar_4 = InternalMethod_1107(ref InternalVar_2, ref InternalParameter_1175, ref InternalParameter_1176);

            InternalVar_2.InternalMethod_791(InternalVar_3);
            InternalVar_2.InternalMethod_801(InternalParameter_1173, InternalParameter_1172);

            InternalVar_1.InternalField_740 = InternalVar_2;
            InternalParameter_1176.InternalField_631[InternalParameter_1174.InternalField_585] = InternalVar_1;

            InternalType_164<InternalType_133> InternalVar_5 = InternalParameter_1174.InternalField_587;
            InternalVar_5.InternalMethod_791(InternalVar_3);
            InternalVar_5.InternalMethod_801(InternalParameter_1173, InternalParameter_1176.InternalField_632[InternalParameter_1172]);
            InternalParameter_1174.InternalField_587 = InternalVar_5;

            InternalParameter_1176.InternalField_628[InternalParameter_1176.InternalField_632[InternalParameter_1174.InternalField_585]] = InternalParameter_1174;

            InternalMethod_1108(ref InternalVar_1, ref InternalParameter_1175, InternalVar_4, ref InternalParameter_1176);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1113(InternalType_131 InternalParameter_1177, ref InternalType_222 InternalParameter_1178, ref NativeList<InternalType_133> InternalParameter_1179, ref InternalType_228 InternalParameter_1180)
        {
            if (!InternalParameter_1180.InternalField_631.TryGetValue(InternalParameter_1178.InternalField_585, out InternalType_252 InternalVar_1))
            {
                Debug.LogError("Parent not tracking any virtual proxy elements.");
                return;
            }

            InternalType_164<InternalType_131> InternalVar_2 = InternalVar_1.InternalField_740;

            if (!InternalVar_2.InternalMethod_769(InternalParameter_1177, out int InternalVar_3))
            {
                Debug.LogError("Element is not a proxy to Parent element");
                return;
            }

            InternalMethod_1104(InternalParameter_1177, ref InternalParameter_1180);

            InternalType_133 InternalVar_4 = InternalParameter_1180.InternalField_632[InternalParameter_1177];
            InternalType_222 InternalVar_5 = InternalParameter_1180.InternalField_628[InternalVar_4];

            if (InternalVar_2.InternalProperty_216 > 1)
            {
                int InternalVar_6 = InternalMethod_1107(ref InternalVar_2, ref InternalParameter_1179, ref InternalParameter_1180);
                InternalVar_2.InternalMethod_791(InternalVar_3);
                InternalVar_1.InternalField_740 = InternalVar_2;

                InternalMethod_1108(ref InternalVar_1, ref InternalParameter_1179, InternalVar_6, ref InternalParameter_1180);

                InternalParameter_1180.InternalField_631[InternalParameter_1178.InternalField_585] = InternalVar_1;
            }
            else
            {
                InternalVar_2.InternalMethod_791(0);
                InternalVar_2.Dispose();
                InternalParameter_1180.InternalField_631.Remove(InternalParameter_1178.InternalField_585);

                InternalMethod_1106(ref InternalVar_5, InternalParameter_1178.InternalField_585, ref InternalParameter_1179, ref InternalParameter_1180);
            }
        }

        private static void InternalMethod_1114(InternalType_131 InternalParameter_1181, InternalType_133 InternalParameter_1182, ref NativeList<InternalType_133> InternalParameter_1183, ref InternalType_228 InternalParameter_1184)
        {
            if (InternalParameter_1184.InternalField_631.TryGetValue(InternalParameter_1181, out InternalType_252 InternalVar_1))
            {
                InternalMethod_1108(ref InternalVar_1, ref InternalParameter_1183, InternalMethod_1095(ref InternalVar_1.InternalField_740, ref InternalParameter_1184), ref InternalParameter_1184);
            }
            else 
            {
                InternalType_222 InternalVar_2 = InternalParameter_1184.InternalField_628[InternalParameter_1182];
                if (InternalVar_2.InternalProperty_253 != InternalParameter_1183.Length) 
                {
                    Debug.LogError($"Called UpdateChildOrder with {InternalParameter_1183.Length} children while hierarchy is tracking {InternalVar_2.InternalProperty_253}.");
                    return;
                }

                InternalType_164<InternalType_133> InternalVar_3 = InternalVar_2.InternalField_587;
                InternalVar_3.InternalMethod_705();

                unsafe
                {
                    InternalVar_3.InternalMethod_790(InternalParameter_1183.GetUnsafeReadOnlyPtr(), InternalParameter_1183.Length);
                }

                InternalVar_2.InternalField_587 = InternalVar_3;

                InternalParameter_1184.InternalField_628[InternalParameter_1182] = InternalVar_2;

                InternalParameter_1184.InternalField_633.InternalMethod_1065(InternalParameter_1182);
            }
        }


        
        private static int InternalMethod_1115(InternalType_131 InternalParameter_1185, ref NativeList<InternalType_133> InternalParameter_1186, ref InternalType_228 InternalParameter_1187)
        {
            InternalParameter_1186.Clear();

            if (!InternalParameter_1187.InternalField_632.TryGetValue(InternalParameter_1185, out InternalType_133 InternalVar_1))
            {
                return 0;
            }

            int InternalVar_2 = 0;
            if (InternalParameter_1187.InternalField_631.TryGetValue(InternalParameter_1185, out InternalType_252 InternalVar_3))
            {
                InternalVar_2 = InternalMethod_1107(ref InternalVar_3.InternalField_740, ref InternalParameter_1186, ref InternalParameter_1187);
            }
            else
            {
                InternalType_222 InternalVar_4 = InternalParameter_1187.InternalField_628[InternalVar_1];

                int InternalVar_5 = InternalVar_4.InternalProperty_253;
                if (InternalVar_5 > 0)
                {
                    unsafe
                    {
                        InternalParameter_1186.AddRange(InternalVar_4.InternalField_587.InternalProperty_232, InternalVar_5);
                    }
                }

                InternalVar_2 = InternalVar_5;
            }

            return InternalVar_2;
        }

        private static void InternalMethod_1116(InternalType_131 InternalParameter_1188, InternalType_131 InternalParameter_1189, bool InternalParameter_1190, int InternalParameter_1191, ref NativeList<InternalType_133> InternalParameter_1192, ref InternalType_228 InternalParameter_1193)
        {
            if (!InternalParameter_1193.InternalField_632.TryGetValue(InternalParameter_1188, out InternalType_133 InternalVar_1) ||
                !InternalParameter_1193.InternalField_632.TryGetValue(InternalParameter_1189, out InternalType_133 InternalVar_2))
            {
                return;
            }

            InternalParameter_1193.InternalField_630[InternalVar_1] = InternalParameter_1191;

            InternalParameter_1192.Clear();
            InternalMethod_1115(InternalParameter_1189, ref InternalParameter_1192, ref InternalParameter_1193);

            if (!InternalParameter_1192.InternalMethod_1011(InternalVar_1, out int InternalVar_3))
            {
                return;
            }

            if ((InternalParameter_1190 && InternalVar_3 == InternalParameter_1192.Length - 1) ||
                (!InternalParameter_1190 && InternalVar_3 == 0))
            {
                return;
            }

            InternalParameter_1192.RemoveAt(InternalVar_3);
            if (InternalParameter_1190)
            {
                InternalParameter_1192.Add(InternalVar_1);
            }
            else
            {
                InternalParameter_1192.InternalMethod_1016(0, InternalVar_1);
            }

            InternalMethod_1114(InternalParameter_1189, InternalVar_2, ref InternalParameter_1192, ref InternalParameter_1193);
        }

        public static void InternalMethod_1117(InternalType_131 InternalParameter_1194, ref InternalType_228 InternalParameter_1195)
        {
            if (!InternalParameter_1195.InternalField_632.TryGetValue(InternalParameter_1194, out InternalType_133 InternalVar_1))
            {
                return;
            }

            InternalType_222 InternalVar_2 = InternalParameter_1195.InternalField_628[InternalVar_1];
            InternalType_131 InternalVar_3 = InternalVar_2.InternalField_586;

            if (InternalParameter_1195.InternalField_632.ContainsKey(InternalVar_3))
            {
                InternalMethod_1104(InternalParameter_1194, ref InternalParameter_1195);
            }

            InternalParameter_1195.InternalField_632.Remove(InternalParameter_1194);
            InternalParameter_1195.InternalField_628.RemoveAtSwapBack(InternalVar_1);
            InternalParameter_1195.InternalField_630.RemoveAtSwapBack(InternalVar_1);
            InternalParameter_1195.InternalField_633.InternalMethod_1062(InternalParameter_1194, InternalType_133.InternalField_418);
            InternalParameter_1195.InternalField_633.InternalMethod_1064(InternalVar_1);

            if (InternalVar_1 < InternalParameter_1195.InternalField_628.Length) 
            {
                InternalType_222 InternalVar_4 = InternalParameter_1195.InternalField_628[InternalVar_1];
                InternalParameter_1195.InternalField_632[InternalVar_4.InternalField_585] = InternalVar_1;

                if (InternalParameter_1195.InternalField_632.TryGetValue(InternalVar_4.InternalField_586, out InternalType_133 InternalVar_5))
                {
                    InternalType_222 InternalVar_6 = InternalParameter_1195.InternalField_628[InternalVar_5];
                    InternalType_164<InternalType_133> InternalVar_7 = InternalVar_6.InternalField_587;
                    if (InternalVar_7.InternalMethod_769(InternalParameter_1195.InternalField_628.Length, out int InternalVar_8))
                    {
                        InternalVar_7[InternalVar_8] = InternalVar_1;
                        InternalVar_6.InternalField_587 = InternalVar_7;
                        InternalParameter_1195.InternalField_628[InternalVar_5] = InternalVar_6;
                    }
                }
            }

            InternalParameter_1195.InternalMethod_1128(ref InternalVar_2.InternalField_587);

            InternalVar_2.InternalField_587 = default;
            InternalVar_2.Dispose();
        }

        private static void InternalMethod_1118(InternalType_131 InternalParameter_1196, ref InternalType_228 InternalParameter_1197)
        {
            InternalType_131 InternalVar_1 = InternalParameter_1197.InternalMethod_1125(InternalParameter_1196);
            InternalParameter_1197.InternalField_632.TryGetValue(InternalVar_1, out InternalType_133 InternalVar_2);
            InternalParameter_1197.InternalField_633.InternalMethod_1062(InternalParameter_1196, InternalVar_2);
        }

        private static void InternalMethod_1119(InternalType_131 InternalParameter_1198, ref InternalType_228 InternalParameter_1199)
        {
            if (!InternalParameter_1199.InternalField_632.TryGetValue(InternalParameter_1198, out InternalType_133 InternalVar_1))
            {
                return;
            }

            InternalType_222 InternalVar_2 = InternalParameter_1199.InternalField_628[InternalVar_1];
            InternalType_131 InternalVar_3 = InternalVar_2.InternalField_586;
            InternalParameter_1199.InternalField_632.TryGetValue(InternalVar_3, out InternalType_133 InternalVar_4);
            InternalParameter_1199.InternalField_633.InternalMethod_1061(InternalParameter_1198, InternalVar_4);
        }
    }
}
