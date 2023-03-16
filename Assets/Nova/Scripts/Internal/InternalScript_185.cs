using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_12;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.Camera;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_328
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1126;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1127;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_1128;
    }

    internal unsafe partial class InternalType_268 : InternalType_126<InternalType_268>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_269 InternalProperty_280 { get; private set; } = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeReference<InternalType_328> InternalField_796;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_328* InternalField_797 = null;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_131, InternalType_263> InternalField_798 = new Dictionary<InternalType_131, InternalType_263>(InternalType_178.InternalField_3012);

        #region 
        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_329 InternalField_799 = default;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_175> InternalField_800;

        [FixedAddressValueType]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_362.InternalType_295 InternalField_801 = default;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_175> InternalField_802;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_735<InternalType_421.InternalType_423> InternalField_803;
        #endregion

        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        private CameraCallback InternalField_804 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private CameraCallback InternalProperty_281
        {
            get
            {
                if (InternalField_804 == null)
                {
                    InternalField_804 = InternalMethod_1223;
                }
                return InternalField_804;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Action<ScriptableRenderContext, Camera> InternalField_805 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Action<ScriptableRenderContext, Camera> InternalProperty_282
        {
            get
            {
                if (InternalField_805 == null)
                {
                    InternalField_805 = InternalMethod_1222;
                }
                return InternalField_805;
            }
        }
        #endregion

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_275 InternalField_807;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_1525 = false;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_419> InternalField_809;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_131> InternalField_810;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_133> InternalField_811;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_133> InternalField_812;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NovaHashMap<InternalType_131, InternalType_304> InternalField_813;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NovaHashMap<InternalType_131, InternalType_358> InternalField_814;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_408> InternalField_3378;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_131> InternalField_816;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_643> InternalField_2827;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_131> InternalField_817;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private NovaHashMap<InternalType_131, InternalType_101> InternalField_3379;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static readonly ProfilerMarker InternalField_819 = new ProfilerMarker("TMP Mesh Building");

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_283 { get; set; } = false;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_162<InternalType_305, InternalType_362.InternalType_361> InternalMethod_1305(InternalType_131 InternalParameter_1372) => InternalField_801.InternalMethod_1309(InternalParameter_1372);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_270 InternalProperty_284 => new InternalType_270()
        {
            InternalField_845 = InternalProperty_287,
            InternalField_847 = InternalProperty_288,
            InternalField_846 = InternalField_807.InternalField_880,
            InternalField_848 = InternalProperty_289.InternalField_863.InternalField_1233,
            InternalField_849 = InternalField_3379,
        };

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_820 = false;
        private void InternalMethod_1214()
        {
            if (InternalField_820)
            {
                return;
            }

            InternalField_820 = true;
            RenderPipelineManager.beginCameraRendering += InternalProperty_282;
            Camera.onPreCull += InternalProperty_281;
        }

        private void InternalMethod_1215()
        {
            if (!InternalField_820)
            {
                return;
            }

            InternalField_820 = false;
            RenderPipelineManager.beginCameraRendering -= InternalProperty_282;
            Camera.onPreCull -= InternalProperty_281;
        }

        public override void InternalMethod_608()
        {
            InternalType_325.InternalMethod_1454();

#pragma warning disable CS0162 
            if (NovaApplication.ConstIsEditor)
            {
                if (InternalProperty_283)
                {
                    foreach (InternalType_263 InternalVar_1 in InternalField_798.Values)
                    {
                        InternalVar_1.InternalMethod_1192();
                    }
                    InternalProperty_283 = false;
                }
            }
#pragma warning restore CS0162 

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_2827.Length; ++InternalVar_1)
            {
                InternalType_643 InternalVar_2 = InternalField_2827[InternalVar_1];

                InternalType_773 InternalVar_3 = InternalProperty_289.InternalField_874.InternalField_3677[InternalVar_2];
                InternalVar_3.InternalMethod_3686(InternalProperty_289.InternalField_874.InternalField_1166[InternalVar_2]);
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_810.Length; ++InternalVar_1)
            {
                InternalType_131 InternalVar_2 = InternalField_810[InternalVar_1];
                InternalType_337 InternalVar_3 = InternalField_807.InternalField_283[InternalVar_2];
                InternalField_798[InternalVar_2].InternalField_1105.InternalMethod_3686(InternalVar_3);
            }

            {
                for (int InternalVar_1 = 0; InternalVar_1 < InternalField_810.Length; ++InternalVar_1)
                {
                    InternalField_798[InternalField_810[InternalVar_1]].InternalMethod_1191();
                }

                InternalProperty_289.InternalField_876.InternalMethod_1394();

                InternalMethod_1219();

                for (int InternalVar_1 = 0; InternalVar_1 < InternalField_810.Length; ++InternalVar_1)
                {
                    InternalField_798[InternalField_810[InternalVar_1]].InternalMethod_1194();
                }

                NativeList<InternalType_131> InternalVar_2 = InternalType_479.InternalField_406.InternalField_2148.InternalField_3628;
                for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_2.Length; ++InternalVar_3)
                {
                    InternalField_798[InternalVar_2[InternalVar_3]].InternalMethod_1970();
                }
            }

            InternalField_810.Clear();
            InternalProperty_289.InternalMethod_635();
            InternalField_1525 = false;

            if (InternalField_798.Count > 0)
            {
                InternalMethod_1214();
            }
        }

        public unsafe void InternalMethod_1216(ref NativeList<InternalType_133> InternalParameter_1292)
        {
            InternalType_421.InternalType_422 InternalVar_1 = new InternalType_421.InternalType_422()
            {
                InternalField_1606 = InternalProperty_289.InternalField_863.InternalField_1239,
                InternalField_1607 = InternalParameter_1292,
            };

            InternalField_803.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_830), UnsafeUtility.AddressOf(ref InternalVar_1));

            InternalMethod_1218();
        }

        public void InternalMethod_1217()
        {
            if (InternalType_479.InternalField_406.InternalProperty_410)
            {
                InternalMethod_1218();
            }

            InternalProperty_289.InternalMethod_1259();
        }

        private void InternalMethod_1218()
        {
            NativeList<InternalType_172<InternalType_131, float2>> InternalVar_1 = InternalProperty_289.InternalField_865.InternalField_2241;
            if (InternalVar_1.Length > 0)
            {
                for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1.Length; ++InternalVar_2)
                {
                    var InternalVar_3 = InternalVar_1[InternalVar_2];
                    if (!InternalProperty_289.InternalField_413.TryGetValue(InternalVar_3.InternalField_462, out InternalType_255 InternalVar_4))
                    {
                        continue;
                    }

                    InternalType_457.InternalProperty_190.InternalMethod_1846(InternalVar_4 as InternalType_67, InternalVar_3.InternalField_463);
                }

                InternalProperty_289.InternalField_865.InternalField_2241.Clear();
            }

            NativeList<InternalType_172<InternalType_131, InternalType_670>> InternalVar_5 = InternalProperty_289.InternalField_865.InternalField_1150;

            int InternalVar_6 = InternalVar_5.Length;

            if (InternalVar_6 == 0)
            {
                return;
            }

            using (InternalField_819.Auto())
            {
                for (int InternalVar_7 = 0; InternalVar_7 < InternalVar_6; ++InternalVar_7)
                {
                    ref InternalType_172<InternalType_131, InternalType_670> InternalVar_8 = ref InternalVar_5.ElementAt(InternalVar_7);
                    InternalType_6 InternalVar_9 = InternalProperty_289.InternalField_413[InternalVar_8.InternalField_462] as InternalType_6;
                    InternalVar_9.InternalMethod_2724(ref InternalVar_8.InternalField_463);
                }
            }

            InternalProperty_289.InternalField_865.InternalField_1150.Clear();
        }

        private void InternalMethod_1219()
        {
            InternalMethod_2336(InternalProperty_289.InternalField_863.InternalField_1240, InternalType_331.InternalField_1912, InternalType_262.InternalField_764);

            InternalMethod_2336(InternalProperty_289.InternalField_864.InternalField_1211, InternalType_331.InternalField_1575, InternalType_262.InternalField_765);
            InternalMethod_2336(InternalProperty_289.InternalField_864.InternalField_1214, InternalType_331.InternalField_1575, InternalType_262.InternalField_768);
            InternalMethod_2336(InternalProperty_289.InternalField_864.InternalField_1213.InternalField_1205, InternalType_331.InternalField_1163, InternalType_262.InternalField_768);

            InternalMethod_2336(InternalProperty_289.InternalField_866.InternalField_1221, InternalType_331.InternalField_1575, InternalType_262.InternalField_766);

            InternalMethod_2336(InternalProperty_289.InternalField_865.InternalField_1195, InternalType_331.InternalField_1575, InternalType_262.InternalField_767);
        }

        private void InternalMethod_2336<TCPU, TGPU>(InternalType_186<TCPU, TGPU> InternalParameter_2200, int InternalParameter_2201, InternalType_262 InternalParameter_2202)
            where TCPU : unmanaged
            where TGPU : unmanaged
        {
            if (!InternalParameter_2200.InternalMethod_1249())
            {
                return;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_807.InternalField_877.Length; ++InternalVar_1)
            {
                InternalField_798[InternalField_807.InternalField_877[InternalVar_1]].InternalMethod_2346(InternalParameter_2200, InternalParameter_2201, InternalParameter_2202);
            }
        }

        public override JobHandle InternalMethod_604(JobHandle InternalParameter_495)
        {
            InternalProperty_289.InternalField_876.InternalMethod_1396();

#pragma warning disable CS0162 
            if (NovaApplication.ConstIsEditor)
            {
                if (InternalType_333.InternalProperty_318 != QualitySettings.activeColorSpace)
                {
                    InternalType_333.InternalMethod_1494();
                    InternalField_1525 = true;
                }
            }
#pragma warning restore CS0162 


            return InternalParameter_495;
        }

        public override void InternalMethod_605(ref InternalType_128 engineUpdateInfo)
        {
            if (InternalType_479.InternalField_406.InternalProperty_410)
            {
                InternalField_830.InternalMethod_1982(engineUpdateInfo.InternalField_410).Complete();
            }
        }

        public override void InternalMethod_606(ref InternalType_128 engineUpdateInfo)
        {
            if (!InternalType_253.InternalProperty_190.InternalProperty_193 &&
                !InternalType_457.InternalProperty_190.InternalProperty_193 &&
                !InternalProperty_289.InternalProperty_193 &&
                !InternalField_1525)
            {
                InternalProperty_289.InternalField_876.InternalMethod_1397();
                return;
            }

            InternalMethod_1221(ref engineUpdateInfo.InternalField_408);

            if (InternalProperty_285.Length > InternalField_811.Capacity)
            {
                InternalField_811.Capacity = InternalProperty_285.Length;
                InternalField_812.Capacity = InternalProperty_285.Length;
            }

            InternalField_811.Clear();
            InternalField_812.Clear();

            InternalField_822.InternalField_792 = InternalField_1525;
            InternalField_821.InternalField_808 = InternalField_1525;
            InternalField_821.InternalField_1421 = engineUpdateInfo.InternalField_408;
            InternalField_827.InternalField_1523 = InternalField_811.AsParallelWriter();
            InternalField_827.InternalField_1524 = InternalField_812.AsParallelWriter();


            JobHandle InternalVar_1 = InternalField_821.InternalMethod_1982(engineUpdateInfo.InternalField_410);

            JobHandle InternalVar_2 = InternalField_827.InternalMethod_1984(InternalProperty_285.Length, 64, InternalVar_1);
            JobHandle InternalVar_3 = InternalField_835.InternalMethod_1982(InternalVar_2);

            JobHandle InternalVar_4 = InternalField_823.InternalMethod_1984(InternalProperty_285.Length, 32, InternalVar_2);
            JobHandle InternalVar_5 = InternalField_822.InternalMethod_1984(InternalProperty_285.Length, 32, InternalVar_2);

            JobHandle InternalVar_6 = InternalField_825.InternalMethod_3334(InternalField_810, 1, InternalVar_3);
            JobHandle InternalVar_7 = InternalField_826.InternalMethod_1982(InternalVar_6);

            JobHandle InternalVar_8 = InternalField_831.InternalMethod_3333(&InternalField_797->InternalField_1128, 64, InternalVar_7);
            JobHandle InternalVar_9 = InternalField_832.InternalMethod_3333(&InternalField_797->InternalField_1127, 1, InternalVar_8);
            JobHandle InternalVar_10 = InternalField_833.InternalMethod_3333(&InternalField_797->InternalField_1128, 32, InternalVar_9);

            JobHandle InternalVar_11 = InternalField_824.InternalMethod_3333(&InternalField_797->InternalField_1126, 32, JobHandle.CombineDependencies(InternalVar_4, InternalVar_7));
            JobHandle InternalVar_12 = InternalField_828.InternalMethod_3333(&InternalField_797->InternalField_1126, 32, InternalVar_11);
            JobHandle InternalVar_13 = InternalField_829.InternalMethod_3334(InternalField_810, 1, InternalVar_12);

            JobHandle InternalVar_14 = InternalField_834.InternalMethod_3334(InternalField_810, 1, JobHandle.CombineDependencies(InternalVar_13, InternalVar_10));

            InternalField_2600.InternalField_3382 = InternalType_325.InternalProperty_314;
            InternalField_2600.InternalField_3383 = InternalType_325.InternalProperty_315;
            JobHandle InternalVar_15 = InternalField_2600.InternalMethod_1982(InternalVar_6);

            JobHandle InternalVar_16 = JobHandle.CombineDependencies(InternalVar_14, InternalVar_5, InternalVar_15);

            InternalProperty_289.InternalField_876.InternalMethod_1397();
            InternalVar_16.Complete();
        }

        private void InternalMethod_1221(ref NativeList<InternalType_131> InternalParameter_1296)
        {
            InternalField_799.InternalField_1129 = InternalParameter_1296;
            InternalField_799.InternalField_1130 = InternalType_254.InternalField_406.InternalField_743;

            unsafe
            {
                InternalField_800.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_799));
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_799.InternalField_1133.Length; ++InternalVar_1)
            {
                InternalType_131 InternalVar_2 = InternalField_799.InternalField_1133[InternalVar_1];

                if (InternalField_798.TryGetValue(InternalVar_2, out InternalType_263 InternalVar_3))
                {
                    InternalVar_3.Dispose();
                    InternalField_798.Remove(InternalVar_2);
                }
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_799.InternalField_1134.Length; ++InternalVar_1)
            {
                InternalType_131 InternalVar_2 = InternalField_799.InternalField_1134[InternalVar_1];
                InternalField_798.Add(InternalVar_2, new InternalType_263(InternalVar_2));
            }
        }

        private void InternalMethod_1222(ScriptableRenderContext InternalParameter_1297, Camera InternalParameter_1298)
        {
            InternalMethod_1223(InternalParameter_1298);
        }

        private void InternalMethod_1223(Camera InternalParameter_1299)
        {
            if (InternalType_253.InternalProperty_190.InternalField_413.Count == 0)
            {
                InternalMethod_1215();
                return;
            }

            try
            {
#pragma warning disable CS0162 
                if (NovaApplication.ConstIsEditor)
                {
                    switch (InternalParameter_1299.cameraType)
                    {
                        case CameraType.Game:
                        case CameraType.SceneView:
                        case CameraType.VR:
                            break;
                        default:
                            return;
                    }
                }
#pragma warning restore CS0162 

                InternalField_801.InternalField_1132 = new InternalType_362.InternalType_341(InternalParameter_1299);

                InternalField_801.InternalField_3376 = InternalMethod_1224(InternalParameter_1299);

                unsafe
                {
                    InternalField_802.InternalField_3352.Invoke(UnsafeUtility.AddressOf(ref InternalField_801));
                }

                {
                    for (int InternalVar_1 = 0; InternalVar_1 < InternalField_801.InternalField_968.Length; ++InternalVar_1)
                    {
                        if (!InternalField_798.TryGetValue(InternalField_801.InternalField_968[InternalVar_1], out InternalType_263 InternalVar_2))
                        {
                            continue;
                        }

                        InternalVar_2.InternalMethod_1190(InternalParameter_1299);
                    }
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError($"Nova RenderCamera failed with: {e}");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private NativeList<InternalType_131> InternalMethod_1224(Camera InternalParameter_1300)
        {
            if (!NovaApplication.IsEditor)
            {
                return InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_596;
            }

            if (!PrefabStageUtils.TryGetCurrentStageRoot(out GameObject InternalVar_1))
            {
                return InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_596;
            }

            InternalField_817.Clear();

            for (int InternalVar_2 = 0; InternalVar_2 < InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_596.InternalProperty_240; ++InternalVar_2)
            {
                InternalType_131 InternalVar_3 = InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_596[InternalVar_2];

                if (!InternalField_807.InternalMethod_1268(InternalVar_3))
                {
                    continue;
                }

                InternalType_5 InternalVar_4 = InternalType_253.InternalProperty_190.InternalField_413[InternalVar_3] as InternalType_5;
                if (InternalVar_4 as MonoBehaviour == null)
                {
                    continue;
                }

                Transform InternalVar_5 = InternalVar_4.InternalProperty_202;

                bool InternalVar_6 = InternalVar_5.gameObject == InternalVar_1 || InternalVar_5.IsChildOf(InternalVar_1.transform);

                if ((InternalParameter_1300.cameraType == CameraType.Game && !InternalVar_6) ||
                    (InternalParameter_1300.cameraType == CameraType.SceneView && InternalVar_6))
                {
                    InternalField_817.Add(InternalVar_3);
                }
            }

            return InternalField_817;
        }

        public void InternalMethod_2107()
        {
            InternalField_1525 = true;
        }

        #region 
        public override void InternalMethod_603()
        {
            InternalField_406 = this;

            unsafe
            {
                InternalField_800 = new InternalType_735<InternalType_175>(InternalType_329.InternalMethod_1478);
                InternalField_802 = new InternalType_735<InternalType_175>(InternalType_362.InternalType_295.InternalMethod_1310);
                InternalField_803 = new InternalType_735<InternalType_421.InternalType_423>(InternalType_421.InternalMethod_1672);
            }

            InternalType_333.InternalMethod_1494();
            InternalProperty_280 = new InternalType_269();
            InternalField_796.InternalMethod_1032();
            InternalField_797 = (InternalType_328*)InternalField_796.GetUnsafeReadOnlyPtr();
            InternalField_810.InternalMethod_1020(InternalType_178.InternalField_3012);

            InternalField_807.InternalMethod_702();

            InternalField_811.InternalMethod_1020();
            InternalField_812.InternalMethod_1020();
            InternalField_813.Init();
            InternalField_814.Init();

            InternalField_3378.Init();
            InternalField_816.InternalMethod_1020();
            InternalField_2827.InternalMethod_1020();
            InternalField_3379.Init(InternalType_178.InternalField_3012);

            InternalField_809.InternalMethod_1020(JobsUtility.MaxJobThreadCount);
            InternalField_809.Length = JobsUtility.MaxJobThreadCount;
            for (int InternalVar_1 = 0; InternalVar_1 < JobsUtility.MaxJobThreadCount; ++InternalVar_1)
            {
                InternalField_809.ElementAt(InternalVar_1).InternalMethod_702();
            }

            InternalType_24.InternalEvent_10 += InternalMethod_2107;

#pragma warning disable CS0162 
            if (NovaApplication.ConstIsEditor)
            {
                InternalField_817.InternalMethod_1020();
            }
#pragma warning restore CS0162 


            InternalType_325.InternalMethod_1467();
            InternalMethod_1231();

            InternalField_801.InternalMethod_702();

            InternalField_801.InternalField_1242 = InternalType_457.InternalProperty_190.InternalField_430;
            InternalField_801.InternalField_2168 = InternalType_457.InternalProperty_190.InternalField_431;
            InternalField_801.InternalField_1243 = InternalProperty_286;
            InternalField_801.InternalField_967 = InternalField_807.InternalField_881;
            InternalField_801.InternalField_966 = InternalField_3379;
            InternalField_801.InternalField_965 = InternalField_807.InternalField_884;
            InternalField_801.InternalField_964 = InternalField_3378;
            InternalField_801.InternalField_3377 = InternalProperty_289.InternalField_869.InternalField_3381;

            InternalField_799 = new InternalType_329()
            {
                InternalField_1131 = InternalField_807,
                InternalField_794 = InternalField_801,
            };
            InternalField_799.InternalMethod_702();

            InternalType_331.InternalMethod_2330();
        }

        public override void Dispose()
        {
            InternalField_406 = null;

            InternalProperty_280.Dispose();

            InternalField_796.Dispose();
            InternalField_810.Dispose();

            InternalField_811.Dispose();
            InternalField_812.Dispose();
            InternalField_813.Dispose();
            InternalField_814.Dispose();

            InternalField_3378.Dispose();
            InternalField_2827.Dispose();
            InternalField_816.Dispose();
            InternalField_3379.Dispose();

            InternalField_809.InternalMethod_1022();

            InternalField_798.InternalMethod_977();

            while (!InternalField_807.InternalField_877.IsEmpty)
            {
                InternalType_131 InternalVar_1 = InternalField_807.InternalField_877.InternalMethod_1018();
                InternalField_807.InternalMethod_1270(InternalVar_1);
                InternalField_801.InternalMethod_1306(InternalVar_1);
            }

            InternalField_807.Dispose();
            InternalField_801.Dispose();
            InternalField_799.Dispose();

            RenderPipelineManager.beginCameraRendering -= InternalProperty_282;
            Camera.onPreCull -= InternalProperty_281;

            InternalType_24.InternalEvent_10 -= InternalMethod_2107;

            if (NovaApplication.IsEditor)
            {
                InternalField_817.Dispose();
            }

            InternalType_325.InternalMethod_1468();
        }
        #endregion
    }
}


