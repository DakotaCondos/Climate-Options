using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using System;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;

namespace Nova.InternalNamespace_0
{
    internal class InternalType_64 : InternalType_136<InternalType_64>
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private static InternalType_127[] InternalField_204 = null;

        
        public static event Action InternalEvent_11 = null;

        
        public static event Action InternalEvent_1 = null;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static bool InternalProperty_140 { get; set; } = false;


        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_128 InternalField_210;

        public void InternalMethod_427(InternalType_131 InternalParameter_314)
        {
            using (new InternalNamespace_12.InternalType_457.InternalType_459(this))
            {
                InternalNamespace_12.InternalType_479.InternalField_406.InternalMethod_1904(InternalParameter_314, InternalParameter_2126: false);
                InternalNamespace_10.InternalType_268.InternalField_406.InternalMethod_1216(ref InternalNamespace_12.InternalType_479.InternalField_406.InternalField_2148.InternalField_2165);

                if (InternalNamespace_12.InternalType_457.InternalProperty_190.InternalProperty_407)
                {
                    InternalNamespace_12.InternalType_479.InternalField_406.InternalMethod_1904(InternalParameter_314, InternalParameter_2126: true);
                }
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalProperty_141 => InternalNamespace_9.InternalType_253.InternalProperty_190.InternalField_413.Count > 0;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_742 { get; private set; } = false;

        public static void InternalMethod_718()
        {
            if (InternalProperty_200 == null)
            {
                return;
            }

            InternalProperty_200.InternalProperty_742 = false;
        }

        protected override void InternalMethod_656()
        {
            try
            {
                if (InternalProperty_140)
                {
                    return;
                }

                InternalField_210.InternalMethod_702();

                InternalNamespace_1.InternalType_120 InternalVar_1 = new InternalNamespace_1.InternalType_120();
                InternalVar_1.InternalMethod_603();

                InternalField_204 = new InternalType_127[]
                {
                    new InternalNamespace_9.InternalType_254(),
                    new InternalNamespace_12.InternalType_479(),
                    new InternalNamespace_10.InternalType_268(),
                };

                for (int InternalVar_2 = 0; InternalVar_2 < InternalField_204.Length; ++InternalVar_2)
                {
                    InternalField_204[InternalVar_2].InternalMethod_603();
                }

                InternalNamespace_11.InternalType_429.InternalMethod_652();

                PlayerLoopSystem InternalVar_3 = PlayerLoop.GetCurrentPlayerLoop();

                if (!InternalMethod_429(ref InternalVar_3))
                {
                    Debug.LogError("Nova failed to insert engine update and will not work properly");
                    return;
                }
                PlayerLoop.SetPlayerLoop(InternalVar_3);

                InternalProperty_140 = true;
            }
            catch (Exception e)
            {
                Debug.LogError($"Nova initialization failed with {e}");
            }
        }

        
        private bool InternalMethod_429(ref PlayerLoopSystem InternalParameter_315)
        {
            if (InternalParameter_315.subSystemList == null)
            {
                return false;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_315.subSystemList.Length; ++InternalVar_1)
            {
                if (InternalParameter_315.subSystemList[InternalVar_1].type == typeof(UnityEngine.PlayerLoop.Initialization))
                {
                    PlayerLoopSystem[] InternalVar_2 = InternalParameter_315.subSystemList[InternalVar_1].subSystemList;
                    PlayerLoopSystem[] InternalVar_3 = new PlayerLoopSystem[InternalVar_2.Length + 1];
                    InternalVar_3[0] = new PlayerLoopSystem()
                    {
                        type = typeof(NovaEngine.NovaNavigation),
                        updateDelegate = InternalNamespace_11.InternalType_429.InternalMethod_3607
                    };

                    Array.Copy(InternalVar_2, sourceIndex: 0, InternalVar_3, destinationIndex: 1, InternalVar_2.Length);

                    InternalParameter_315.subSystemList[InternalVar_1].subSystemList = InternalVar_3;

                    continue;
                }

                if (InternalParameter_315.subSystemList[InternalVar_1].type != typeof(UnityEngine.PlayerLoop.PostLateUpdate))
                {
                    continue;
                }

                PlayerLoopSystem[] InternalVar_4 = InternalParameter_315.subSystemList[InternalVar_1].subSystemList;
                PlayerLoopSystem[] InternalVar_5 = new PlayerLoopSystem[InternalVar_4.Length + 2];

                InternalVar_5[0] = new PlayerLoopSystem()
                {
                    type = typeof(NovaEngine.NovaAnimator),
                    updateDelegate = InternalNamespace_1.InternalType_120.InternalField_406.InternalMethod_581
                };

                for (int InternalVar_6 = 0; InternalVar_6 < InternalVar_4.Length; ++InternalVar_6)
                {
                    if (InternalVar_4[InternalVar_6].type != typeof(UnityEngine.PlayerLoop.PostLateUpdate.PlayerUpdateCanvases))
                    {
                        continue;
                    }

                    Array.Copy(InternalVar_4, sourceIndex: 0, InternalVar_5, destinationIndex: 1, InternalVar_6 + 1);

                    InternalVar_5[InternalVar_6 + 2] = new PlayerLoopSystem()
                    {
                        type = typeof(NovaEngine),
                        updateDelegate = InternalMethod_431
                    };

                    if (InternalVar_6 + 1 < InternalVar_4.Length)
                    {
                        Array.Copy(InternalVar_4, sourceIndex: InternalVar_6 + 1, InternalVar_5, destinationIndex: InternalVar_6 + 3, InternalVar_4.Length - InternalVar_6 - 1);
                    }

                    InternalParameter_315.subSystemList[InternalVar_1].subSystemList = InternalVar_5;

                    return true;
                }

                InternalVar_5[InternalVar_5.Length - 1] = new PlayerLoopSystem()
                {
                    type = typeof(NovaEngine),
                    updateDelegate = InternalMethod_431
                };

                return true;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_315.subSystemList.Length; ++InternalVar_1)
            {
                PlayerLoopSystem InternalVar_2 = InternalParameter_315.subSystemList[InternalVar_1];
                if (!InternalMethod_429(ref InternalVar_2))
                {
                    continue;
                }

                InternalParameter_315.subSystemList[InternalVar_1] = InternalVar_2;
                return true;
            }

            return false;
        }

        private bool InternalMethod_430(ref PlayerLoopSystem InternalParameter_316)
        {
            if (InternalParameter_316.subSystemList == null)
            {
                return false;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_316.subSystemList.Length; ++InternalVar_1)
            {
                if (InternalParameter_316.subSystemList[InternalVar_1].type == typeof(UnityEngine.PlayerLoop.Initialization))
                {
                    PlayerLoopSystem[] InternalVar_2 = InternalParameter_316.subSystemList[InternalVar_1].subSystemList;
                    PlayerLoopSystem[] InternalVar_3 = new PlayerLoopSystem[InternalVar_2.Length - 1];

                    int InternalVar_4 = 0;

                    for (int InternalVar_5 = 0; InternalVar_5 < InternalVar_2.Length; ++InternalVar_5)
                    {
                        PlayerLoopSystem InternalVar_6 = InternalVar_2[InternalVar_5];

                        bool InternalVar_7 = InternalVar_6.type == typeof(NovaEngine.NovaNavigation);

                        if (!InternalVar_7)
                        {
                            InternalVar_3[InternalVar_4++] = InternalVar_2[InternalVar_5];
                        }
                    }

                    InternalParameter_316.subSystemList[InternalVar_1].subSystemList = InternalVar_3;

                    continue;
                }

                if (InternalParameter_316.subSystemList[InternalVar_1].type != typeof(UnityEngine.PlayerLoop.PostLateUpdate))
                {
                    continue;
                }

                PlayerLoopSystem[] InternalVar_8 = InternalParameter_316.subSystemList[InternalVar_1].subSystemList;
                PlayerLoopSystem[] InternalVar_9 = new PlayerLoopSystem[InternalVar_8.Length - 2];

                int InternalVar_10 = 0;

                for (int InternalVar_11 = 0; InternalVar_11 < InternalVar_8.Length; ++InternalVar_11)
                {
                    PlayerLoopSystem InternalVar_12 = InternalVar_8[InternalVar_11];

                    bool InternalVar_13 = InternalVar_12.type == typeof(NovaEngine);
                    bool InternalVar_14 = InternalVar_12.type == typeof(NovaEngine.NovaAnimator);

                    if (!InternalVar_13 && !InternalVar_14)
                    {
                        InternalVar_9[InternalVar_10++] = InternalVar_8[InternalVar_11];
                    }
                }

                InternalParameter_316.subSystemList[InternalVar_1].subSystemList = InternalVar_9;

                return true;
            }

            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_316.subSystemList.Length; ++InternalVar_1)
            {
                PlayerLoopSystem InternalVar_2 = InternalParameter_316.subSystemList[InternalVar_1];
                if (!InternalMethod_430(ref InternalVar_2))
                {
                    continue;
                }
                InternalParameter_316.subSystemList[InternalVar_1] = InternalVar_2;
                return true;
            }

            return false;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_211 = false;
        internal void InternalMethod_431()
        {
            if (InternalField_211 || !InternalProperty_141)
            {
                return;
            }

            if (NovaApplication.IsEditor)
            {
                InternalEvent_11?.Invoke();
            }

            if (InternalNamespace_10.InternalType_274.InternalProperty_190 != null)
            {
                InternalNamespace_10.InternalType_274.InternalProperty_190.InternalMethod_3646();
            }

            InternalProperty_742 = true;

            JobHandle InternalVar_1 = default(JobHandle);

            {
                try
                {
                    for (int InternalVar_2 = 0; InternalVar_2 < InternalField_204.Length; ++InternalVar_2)
                    {
                        InternalVar_1 = InternalField_204[InternalVar_2].InternalMethod_604(InternalVar_1);
                    }
                }
                catch (Exception e)
                {
                    InternalField_211 = true;
                    Debug.LogError($"NovaEngine CleanUp failed with {e}");
                }
                finally
                {
                    InternalVar_1.Complete();
                }
            }

            InternalField_210.InternalMethod_610();

            {
                try
                {
                    for (int InternalVar_2 = 0; InternalVar_2 < InternalField_204.Length; ++InternalVar_2)
                    {
                        InternalField_204[InternalVar_2].InternalMethod_605(ref InternalField_210);
                    }
                }
                catch (Exception e)
                {
                    InternalField_211 = true;
                    Debug.LogError($"NovaEngine Update failed with {e}");
                }
            }

            InternalNamespace_10.InternalType_268.InternalField_406.InternalMethod_1217();

            {
                try
                {
                    for (int InternalVar_2 = 0; InternalVar_2 < InternalField_204.Length; ++InternalVar_2)
                    {
                        InternalField_204[InternalVar_2].InternalMethod_606(ref InternalField_210);
                    }
                }
                catch (Exception e)
                {
                    InternalField_211 = true;
                    Debug.LogError($"NovaEngine Update failed with {e}");
                }
            }

            InternalField_210.InternalField_410.Complete();

            {
                try
                {
                    for (int InternalVar_2 = 0; InternalVar_2 < InternalField_204.Length; ++InternalVar_2)
                    {
                        InternalField_204[InternalVar_2].InternalMethod_607();
                    }
                }
                catch (Exception e)
                {
                    InternalField_211 = true;
                    Debug.LogError($"NovaEngine CompleteUpdate failed with {e}");
                }
            }
            
            if (NovaApplication.IsEditor)
            {
                InternalEvent_1?.Invoke();
            }

            {
                try
                {
                    for (int InternalVar_2 = 0; InternalVar_2 < InternalField_204.Length; ++InternalVar_2)
                    {
                        InternalField_204[InternalVar_2].InternalMethod_608();
                    }
                }
                catch (Exception e)
                {
                    InternalField_211 = true;
                    Debug.LogError($"NovaEngine PostUpdate failed with {e}");
                }
            }
        }

        protected override void InternalMethod_657()
        {
            if (!InternalProperty_140)
            {
                return;
            }

            InternalField_210.InternalField_410.Complete();

            InternalNamespace_1.InternalType_120.InternalField_406.Dispose();

            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_204.Length; ++InternalVar_1)
            {
                InternalField_204[InternalVar_1].Dispose();
            }

            InternalField_210.Dispose();

            InternalField_204 = null;
            InternalProperty_140 = false;
            InternalProperty_742 = false;
        }

        internal void InternalMethod_432()
        {
            PlayerLoopSystem InternalVar_1 = PlayerLoop.GetCurrentPlayerLoop();
            InternalMethod_430(ref InternalVar_1);
            PlayerLoop.SetPlayerLoop(InternalVar_1);
        }
    }
}

