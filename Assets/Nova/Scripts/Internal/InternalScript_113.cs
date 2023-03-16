#define USE_HIERARCHY_JOBS

using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_9
{
    [BurstCompile]
    internal partial class InternalType_227 : InternalType_147, IDisposable
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_228 InternalField_601 = default(InternalType_228);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_228.InternalType_229 InternalField_602 = default(InternalType_228.InternalType_229);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref InternalType_228.InternalType_229 InternalProperty_254 => ref InternalField_602;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref InternalType_228 InternalProperty_255 => ref InternalField_601;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref NativeList<InternalType_222> InternalProperty_256 => ref InternalField_601.InternalField_628;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref NovaHashMap<InternalType_131, InternalType_133> InternalProperty_257 => ref InternalField_601.InternalField_632;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref InternalType_225 InternalProperty_258 => ref InternalField_601.InternalField_633;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_154<InternalType_131> InternalField_603 = new InternalType_154<InternalType_131>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_154<int> InternalField_604 = new InternalType_154<int>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_131> InternalField_605 = default(NativeList<InternalType_131>);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<int> InternalField_606 = default(NativeList<int>);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_133> InternalField_607 = default(NativeList<InternalType_133>);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private unsafe static InternalType_735<InternalType_176> InternalField_608;

        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_233 InternalField_609;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_234 InternalField_610;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_238 InternalField_611;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_237 InternalField_612;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_236 InternalField_613;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_235 InternalField_614;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_231 InternalField_615;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_232 InternalField_616;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_244 InternalField_617;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_246 InternalField_618;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_239 InternalField_619;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_240 InternalField_620;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_241 InternalField_621;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_242 InternalField_622;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_248 InternalField_623;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_249 InternalField_624;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_243 InternalField_625;
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_760 InternalField_3563;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_183.InternalType_184<InternalType_131, InternalType_133> InternalField_626;

        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_247 InternalField_627;

        public void InternalMethod_1075(InternalType_131 InternalParameter_1081, InternalType_131 InternalParameter_1082, int InternalParameter_1083, bool InternalParameter_1084)
        {
            InternalField_609.InternalField_667 = InternalParameter_1081;
            InternalField_609.InternalField_668 = InternalParameter_1083;
            InternalField_609.InternalField_670 = InternalParameter_1082;
            InternalField_609.InternalField_671 = InternalParameter_1084;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_609), (int)InternalType_230.InternalField_641);
            }
        }

        
        public int InternalMethod_1076(InternalType_133 InternalParameter_1085, InternalType_131 InternalParameter_1086, int InternalParameter_1087)
        {
            if (!InternalParameter_1086.InternalProperty_192)
            {
                Debug.LogError("Called SetParent when parent was not found.");
                return -1;
            }

            InternalField_615.InternalField_660 = InternalParameter_1085;
            InternalField_615.InternalField_661 = InternalParameter_1086;
            InternalField_615.InternalField_662 = InternalParameter_1087;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_615), (int)InternalType_230.InternalField_639);
            }

            return InternalField_615.InternalField_663;
        }

        public void InternalMethod_1077(InternalType_133 InternalParameter_1088, InternalType_131 InternalParameter_1089)
        {
            InternalType_131 InternalVar_1 = InternalField_601.InternalMethod_1124(InternalParameter_1088);

            InternalField_616.InternalField_665 = InternalParameter_1089;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_616), (int)InternalType_230.InternalField_640);
            }
            InternalMethod_1086(InternalVar_1);
        }

        public void InternalMethod_1078(InternalType_133 InternalParameter_1090, InternalType_131 InternalParameter_1091)
        {
            InternalType_131 InternalVar_1 = InternalField_601.InternalMethod_1124(InternalParameter_1090);

            InternalField_610.InternalField_673 = InternalParameter_1091;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_610), (int)InternalType_230.InternalField_642);
            }
            InternalMethod_1086(InternalVar_1);
        }

        public void InternalMethod_1079(InternalType_131 InternalParameter_1092)
        {
            InternalField_613.InternalField_678 = InternalParameter_1092;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_613), (int)InternalType_230.InternalField_645);
            }
        }

        public void InternalMethod_1080(InternalType_131 InternalParameter_1093, bool InternalParameter_1094)
        {
            InternalField_614.InternalField_675 = InternalParameter_1093;
            InternalField_614.InternalField_676 = InternalParameter_1094;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_614), (int)InternalType_230.InternalField_646);
            }
        }

        public void InternalMethod_1081(InternalType_131 InternalParameter_1095)
        {
            InternalField_612.InternalField_680 = InternalParameter_1095;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_612), (int)InternalType_230.InternalField_644);
            }
        }

        public void InternalMethod_1082(InternalType_131 InternalParameter_1096)
        {
            InternalField_611.InternalField_682 = InternalParameter_1096;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_611), (int)InternalType_230.InternalField_643);
            }
        }

        public void InternalMethod_1083(InternalType_131 InternalParameter_1097, InternalType_131 InternalParameter_1098, int InternalParameter_1099)
        {
            InternalField_617.InternalField_707 = InternalParameter_1097;
            InternalField_617.InternalField_708 = InternalParameter_1098;
            InternalField_617.InternalField_711 = InternalParameter_1099;
            InternalField_617.InternalField_710 = true;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_617), (int)InternalType_230.InternalField_651);
            }
        }

        public void InternalMethod_1084(InternalType_131 InternalParameter_1100, InternalType_131 InternalParameter_1101)
        {
            InternalField_617.InternalField_707 = InternalParameter_1100;
            InternalField_617.InternalField_708 = InternalParameter_1101;
            InternalField_617.InternalField_711 = 0;
            InternalField_617.InternalField_710 = false;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_617), (int)InternalType_230.InternalField_651);
            }
        }

        public void InternalMethod_2015(InternalType_131 InternalParameter_2330, InternalType_521<InternalType_131> InternalParameter_2329, InternalType_521<int> InternalParameter_2328)
        {
            if (!InternalField_601.InternalField_632.TryGetValue(InternalParameter_2330, out InternalType_133 InternalVar_1))
            {
                return;
            }

            if (InternalParameter_2329.InternalProperty_433 == 0)
            {
                Debug.LogError($"Called UpdateChildOrder with zero children.");
                return;
            }

            InternalField_603.InternalMethod_735();
            InternalField_603.InternalMethod_2044(InternalParameter_2329);

            InternalField_604.InternalMethod_735();
            InternalField_604.InternalMethod_2044(InternalParameter_2328);

            InternalField_605.Length = InternalField_603.InternalProperty_223;
            NativeArray<InternalType_131>.Copy(InternalField_603.InternalMethod_736(), 0, InternalField_605.AsArray(), 0, InternalField_603.InternalProperty_223);

            InternalField_606.Length = InternalField_603.InternalProperty_223;
            NativeArray<int>.Copy(InternalField_604.InternalMethod_736(), 0, InternalField_606.AsArray(), 0, InternalField_603.InternalProperty_223);

            InternalField_626.Run();

            InternalField_625.InternalField_703 = InternalParameter_2330;
            InternalField_625.InternalField_702 = InternalVar_1;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_625), (int)InternalType_230.InternalField_652);
            }
        }

        public void InternalMethod_1086(InternalType_131 InternalParameter_1105)
        {
            if (!InternalField_601.InternalField_631.TryGetValue(InternalParameter_1105, out InternalType_252 InternalVar_1))
            {
                return;
            }

            InternalField_607.Clear();

            InternalField_622.InternalField_700 = InternalVar_1;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_622), (int)InternalType_230.InternalField_650);
            }
        }

        public void InternalMethod_1087(InternalType_131 InternalParameter_1106, InternalType_131 InternalParameter_1107, int InternalParameter_1108, bool InternalParameter_1109)
        {
            bool InternalVar_2 = InternalField_601.InternalField_632.TryGetValue(InternalParameter_1107, out InternalType_133 InternalVar_1);

            if (!InternalVar_2)
            {
                Debug.LogError("Called AddVirtualProxyToParent when parent was not found.");
                return;
            }

            InternalType_222 InternalVar_3 = InternalField_601.InternalField_628[InternalVar_1];

            InternalField_607.Clear();

            InternalField_619.InternalField_686 = InternalParameter_1106;
            InternalField_619.InternalField_685 = InternalVar_3;
            InternalField_619.InternalField_687 = InternalParameter_1108;
            InternalField_619.InternalField_688 = InternalParameter_1109;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_619), (int)InternalType_230.InternalField_647);
            }
        }

        public void InternalMethod_1088(InternalType_133 InternalParameter_1110, InternalType_131 InternalParameter_1111, int InternalParameter_1112)
        {
            InternalType_222 InternalVar_1 = InternalField_601.InternalField_628.ElementAt(InternalParameter_1110);
            InternalType_131 InternalVar_2 = InternalVar_1.InternalField_585;
            bool InternalVar_3 = InternalVar_1.InternalField_586 == InternalParameter_1111;

            if (!InternalVar_3 || !InternalParameter_1111.InternalProperty_192)
            {
                Debug.LogError("Called SetVirtualProxyIndex when proxy is not parented to the requested parent.");
                return;
            }

            InternalType_133 InternalVar_4 = InternalField_601.InternalField_632[InternalParameter_1111];
            InternalType_222 InternalVar_5 = InternalField_601.InternalField_628.ElementAt(InternalVar_4);

            InternalField_607.Clear();

            InternalField_620.InternalField_692 = InternalVar_2;
            InternalField_620.InternalField_691 = InternalVar_5;
            InternalField_620.InternalField_693 = InternalParameter_1112;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_620), (int)InternalType_230.InternalField_648);
            }
        }

        public void InternalMethod_1089(InternalType_131 InternalParameter_1113)
        {
            InternalType_131 InternalVar_1 = InternalField_601.InternalMethod_1125(InternalParameter_1113);
            bool InternalVar_3 = InternalField_601.InternalField_632.TryGetValue(InternalVar_1, out InternalType_133 InternalVar_2);

            if (!InternalVar_3)
            {
                Debug.LogError("Called RemoveVirtualProxyFromParent when parent was not found.");
                return;
            }

            InternalType_222 InternalVar_4 = InternalField_601.InternalField_628[InternalVar_2];

            InternalField_607.Clear();

            InternalField_621.InternalField_697 = InternalParameter_1113;
            InternalField_621.InternalField_696 = InternalVar_4;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_621), (int)InternalType_230.InternalField_649);
            }
        }

        
        public InternalType_131 InternalMethod_1090(InternalType_131 InternalParameter_1114)
        {
            InternalField_624.InternalField_728 = InternalParameter_1114;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_624), (int)InternalType_230.InternalField_657);
            }

            return InternalField_624.InternalField_729.Length == 0 ? InternalType_131.InternalField_415 : InternalField_624.InternalField_729[0];
        }

        
        public InternalType_131 InternalMethod_1091(InternalType_131 InternalParameter_1115, bool InternalParameter_1116 = false)
        {
            return InternalField_601.InternalMethod_1123(InternalParameter_1115, InternalParameter_1116);
        }

        
        public InternalType_131 InternalMethod_1092(InternalType_133 InternalParameter_1117, bool InternalParameter_1118 = false)
        {
            return InternalField_601.InternalMethod_1124(InternalParameter_1117, InternalParameter_1118);
        }

        public JobHandle InternalMethod_1093(ref NativeList<InternalType_131> InternalParameter_1119, ref NativeList<InternalType_133> InternalParameter_1120, JobHandle InternalParameter_1121)
        {
            InternalField_627.InternalField_722 = InternalParameter_1119;
            InternalField_627.InternalField_723 = InternalParameter_1120;

            return InternalField_627.InternalMethod_1982(InternalParameter_1121);
        }

        
        public ref NativeList<InternalType_133> InternalMethod_1094(InternalType_131 InternalParameter_1122)
        {
            InternalField_618.InternalField_718 = InternalParameter_1122;
            InternalField_618.InternalField_719 = InternalType_131.InternalField_415;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_618), (int)InternalType_230.InternalField_654);
            }
            return ref InternalField_607;
        }

        private static int InternalMethod_1095(ref InternalType_164<InternalType_131> InternalParameter_1123, ref InternalType_228 InternalParameter_1124)
        {
            int InternalVar_1 = 0;

            for (int InternalVar_2 = 0; InternalVar_2 < InternalParameter_1123.InternalProperty_216; ++InternalVar_2)
            {
                if (InternalParameter_1124.InternalField_632.TryGetValue(InternalParameter_1123[InternalVar_2], out InternalType_133 InternalVar_3))
                {
                    InternalVar_1 += InternalParameter_1124.InternalField_628[InternalVar_3].InternalProperty_253;
                }
            }

            return InternalVar_1;
        }

        public int InternalMethod_1096(InternalType_131 InternalParameter_1125)
        {
            if (InternalField_601.InternalField_632.TryGetValue(InternalParameter_1125, out InternalType_133 InternalVar_1))
            {
                return InternalField_601.InternalField_628[InternalVar_1].InternalProperty_253;
            }

            return 0;
        }

        
        public int InternalMethod_1097(InternalType_131 InternalParameter_1126)
        {
            InternalField_618.InternalField_718 = InternalType_131.InternalField_415;
            InternalField_618.InternalField_719 = InternalParameter_1126;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_618), (int)InternalType_230.InternalField_654);
            }
            return InternalField_618.InternalField_720;
        }

        public bool InternalMethod_3601(InternalType_133 InternalParameter_3337, InternalType_131 InternalParameter_3338, out InternalType_131 InternalParameter_3339)
        {
            InternalField_3563.InternalField_3567 = InternalParameter_3337;
            InternalField_3563.InternalField_3566 = InternalParameter_3338;

            unsafe
            {
                InternalField_608.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_3563), (int)InternalType_230.InternalField_3564);
            }

            InternalParameter_3339 = InternalField_3563.InternalField_3569;
            return InternalField_3563.InternalField_3568;
        }

        public JobHandle InternalMethod_1098(ref InternalType_128 InternalParameter_1127, JobHandle InternalParameter_1128)
        {
            if (!InternalField_601.InternalField_633.InternalProperty_193)
            {
                return InternalParameter_1128;
            }

            InternalField_623.InternalField_726 = InternalParameter_1127.InternalField_409;
            InternalField_623.InternalField_725 = InternalParameter_1127.InternalField_408;
            return InternalField_623.InternalMethod_1982(InternalParameter_1128);
        }

        public void InternalMethod_702()
        {
            InternalField_601.InternalMethod_702();
            InternalField_602 = InternalField_601.InternalMethod_1120();

            InternalField_605 = new NativeList<InternalType_131>(InternalType_178.InternalField_3012, Allocator.Persistent);
            InternalField_607 = new NativeList<InternalType_133>(InternalType_178.InternalField_3012, Allocator.Persistent);
            InternalField_606 = new NativeList<int>(InternalType_178.InternalField_3012, Allocator.Persistent);

            InternalMethod_1099();
            InternalMethod_1100();
        }

        private void InternalMethod_1099()
        {
            InternalField_609 = new InternalType_233()
            {
                InternalField_666 = InternalField_601,
                InternalField_669 = InternalField_607,
            };

            InternalField_610 = new InternalType_234()
            {
                InternalField_672 = InternalField_601,
            };

            InternalField_611 = new InternalType_238()
            {
                InternalField_681 = InternalField_601,
            };

            InternalField_612 = new InternalType_237()
            {
                InternalField_679 = InternalField_601,
            };

            InternalField_613 = new InternalType_236()
            {
                InternalField_677 = InternalField_601,
            };

            InternalField_614 = new InternalType_235()
            {
                InternalField_674 = InternalField_601,
            };

            InternalField_615 = new InternalType_231()
            {
                InternalField_658 = InternalField_601,
                InternalField_659 = InternalField_607,
            };

            InternalField_616 = new InternalType_232()
            {
                InternalField_664 = InternalField_601,
            };

            InternalField_617 = new InternalType_244()
            {
                InternalField_706 = InternalField_601,
                InternalField_709 = InternalField_607,
            };

            InternalField_618 = new InternalType_246()
            {
                InternalField_716 = InternalField_601,
                InternalField_717 = InternalField_607,
            };

            InternalField_619 = new InternalType_239()
            {
                InternalField_683 = InternalField_601,
                InternalField_684 = InternalField_607,
            };

            InternalField_620 = new InternalType_240()
            {
                InternalField_689 = InternalField_601,
                InternalField_690 = InternalField_607,
            };

            InternalField_621 = new InternalType_241()
            {
                InternalField_694 = InternalField_601,
                InternalField_695 = InternalField_607,
            };

            InternalField_622 = new InternalType_242()
            {
                InternalField_698 = InternalField_601,
                InternalField_699 = InternalField_607,
            };

            InternalField_626 = new InternalType_183.InternalType_184<InternalType_131, InternalType_133>()
            {
                InternalField_486 = InternalField_601.InternalField_632,
                InternalField_487 = InternalField_605,
                InternalField_488 = InternalField_607,
            };

            InternalField_627 = new InternalType_247()
            {
                InternalField_721 = InternalField_602,
            };

            InternalField_623 = new InternalType_248()
            {
                InternalField_724 = InternalField_602,
            };

            InternalField_624 = new InternalType_249()
            {
                InternalField_727 = InternalField_602,
                InternalField_729 = InternalField_605,
            };

            InternalField_625 = new InternalType_243()
            {
                InternalField_701 = InternalField_601,
                InternalField_704 = InternalField_607,
                InternalField_705 = InternalField_606,
            };

            InternalField_3563 = new InternalType_760()
            {
                InternalField_3565 = InternalField_602,
            };
        }

        private unsafe void InternalMethod_1100()
        {
            InternalField_608 = new InternalType_735<InternalType_176>(InternalMethod_1101);
        }

        public void Dispose()
        {
            InternalField_601.Dispose();
            InternalField_605.Dispose();
            InternalField_607.Dispose();
            InternalField_606.Dispose();
        }
    }
}
