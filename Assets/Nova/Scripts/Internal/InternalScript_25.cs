using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Collections.Generic;

namespace Nova.InternalNamespace_0.InternalNamespace_1
{
    internal class InternalType_120 : InternalType_126<InternalType_120>
    {
        public interface InternalType_122 : InternalType_123
        {
            void InternalMethod_588(InternalType_125 InternalParameter_478, int InternalParameter_479);
            void InternalMethod_589(InternalType_125 InternalParameter_480);
            void InternalMethod_590(InternalType_125 InternalParameter_481);
            void InternalMethod_591(InternalType_125 InternalParameter_482);
            void InternalMethod_592(InternalType_125 InternalParameter_483);
            void InternalMethod_593(InternalType_125 InternalParameter_484);
        }

        public interface InternalType_123
        {
            void InternalMethod_594(InternalType_125 InternalParameter_485, float InternalParameter_486);

            void InternalMethod_595(InternalType_125 InternalParameter_487);
        }

        private struct InternalType_121
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_125 InternalField_397;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalField_398;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalField_399;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalField_400;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_401;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_402;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float InternalField_385;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private const float InternalField_386 = -1;

        private class InternalType_124 : Dictionary<InternalType_125, InternalType_123>
        {
            public new bool Remove(InternalType_125 InternalParameter_488)
            {
                if (!TryGetValue(InternalParameter_488, out InternalType_123 InternalVar_1))
                {
                    return false;
                }

                InternalVar_1.InternalMethod_595(InternalParameter_488);
                return base.Remove(InternalParameter_488);
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Queue<InternalType_153<InternalType_125>> InternalField_388 = new Queue<InternalType_153<InternalType_125>>();

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private List<InternalType_125> InternalField_389 = new List<InternalType_125>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_153<InternalType_125> InternalField_390 = new InternalType_153<InternalType_125>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_125, InternalType_121> InternalField_391 = new Dictionary<InternalType_125, InternalType_121>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_124 InternalField_392 = new InternalType_124();

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_125, InternalType_125> InternalField_2249 = new Dictionary<InternalType_125, InternalType_125>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_125, InternalType_125> InternalField_2248 = new Dictionary<InternalType_125, InternalType_125>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_125, InternalType_125> InternalField_393 = new Dictionary<InternalType_125, InternalType_125>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_125, InternalType_125> InternalField_394 = new Dictionary<InternalType_125, InternalType_125>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_125, InternalType_125> InternalField_395 = new Dictionary<InternalType_125, InternalType_125>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_125, InternalType_153<InternalType_125>> InternalField_396 = new Dictionary<InternalType_125, InternalType_153<InternalType_125>>();

        public bool InternalMethod_565(InternalType_125 InternalParameter_436)
        {
            if (!InternalParameter_436.InternalField_405 && !InternalField_391.ContainsKey(InternalParameter_436) && !InternalField_2249.ContainsKey(InternalParameter_436))
            {
                return true;
            }

            if (InternalParameter_436.InternalField_405 && !InternalField_396.ContainsKey(InternalParameter_436))
            {
                return true;
            }

            return false;
        }

        public InternalType_125 InternalMethod_2721<T>(ref T InternalParameter_2764, float InternalParameter_2763, int InternalParameter_2762, InternalType_123 InternalParameter_2761) where T : struct
        {
            InternalType_125 InternalVar_1 = InternalMethod_2603(ref InternalParameter_2764, InternalParameter_2763, InternalParameter_2762, InternalParameter_2761);
            InternalField_390.Add(InternalVar_1);
            return InternalVar_1;
        }

        public InternalType_125 InternalMethod_2720<T>(InternalType_125 InternalParameter_2760, ref T InternalParameter_2759, float InternalParameter_2742, int InternalParameter_2740, InternalType_123 InternalParameter_2739) where T : struct
        {
            if (InternalMethod_565(InternalParameter_2760))
            {
                return InternalMethod_2721(ref InternalParameter_2759, InternalParameter_2742, InternalParameter_2740, InternalParameter_2739);
            }

            InternalType_125 InternalVar_1 = InternalMethod_2603(ref InternalParameter_2759, InternalParameter_2742, InternalParameter_2740, InternalParameter_2739);

            bool InternalVar_3 = InternalField_394.TryGetValue(InternalParameter_2760, out InternalType_125 InternalVar_2);
            InternalType_153<InternalType_125> InternalVar_4 = InternalVar_3 ? InternalField_396[InternalVar_2] : null;

            if (!InternalVar_3)
            {
                InternalVar_2 = InternalType_125.InternalMethod_602();

                InternalField_394.Add(InternalParameter_2760, InternalVar_2);
                InternalField_395.Add(InternalVar_2, InternalParameter_2760);

                InternalVar_4 = InternalMethod_586();

                InternalField_396.Add(InternalVar_2, InternalVar_4);
            }

            InternalField_393.Add(InternalVar_1, InternalVar_2);

            InternalVar_4.Add(InternalVar_1);
            return InternalVar_1;
        }

        public InternalType_125 InternalMethod_2719<T>(InternalType_125 InternalParameter_2738, ref T InternalParameter_2737, float InternalParameter_2736, int InternalParameter_2735, InternalType_123 InternalParameter_2731) where T : struct
        {
            if (!InternalParameter_2738.InternalField_405 && !InternalField_391.ContainsKey(InternalParameter_2738))
            {
                return InternalMethod_2721(ref InternalParameter_2737, InternalParameter_2736, InternalParameter_2735, InternalParameter_2731);
            }

            return InternalMethod_2605(InternalParameter_2738, ref InternalParameter_2737, InternalParameter_2736, InternalParameter_2735, InternalParameter_2731);
        }

        public InternalType_125 InternalMethod_2718<T>(InternalType_125 InternalParameter_2730, ref T InternalParameter_2729, InternalType_123 InternalParameter_2728) where T : struct
        {
            InternalType_121 InternalVar_1;

            if (InternalParameter_2730.InternalField_405 && InternalField_396.TryGetValue(InternalParameter_2730, out InternalType_153<InternalType_125> InternalVar_2))
            {
                InternalVar_1 = InternalField_391[InternalVar_2[InternalVar_2.Count - 1]];
            }
            else if (!InternalField_391.TryGetValue(InternalParameter_2730, out InternalVar_1))
            {
                return default;
            }

            return InternalMethod_2605(InternalParameter_2730, ref InternalParameter_2729, InternalVar_1.InternalField_400, InternalVar_1.InternalField_401, InternalParameter_2728);
        }

        private InternalType_125 InternalMethod_2605<T>(InternalType_125 InternalParameter_2727, ref T InternalParameter_2610, float InternalParameter_2609, int InternalParameter_2608, InternalType_123 InternalParameter_2607) where T : struct
        {
            InternalType_125 InternalVar_1 = InternalParameter_2727;

            if (!InternalParameter_2727.InternalField_405 && !InternalField_393.TryGetValue(InternalParameter_2727, out InternalVar_1))
            {
                InternalVar_1 = InternalType_125.InternalMethod_602();

                InternalType_153<InternalType_125> InternalVar_2 = InternalMethod_586();

                InternalVar_2.Add(InternalParameter_2727);
                InternalField_393.Add(InternalParameter_2727, InternalVar_1);
                InternalField_396.Add(InternalVar_1, InternalVar_2);
                InternalField_2248.Add(InternalVar_1, InternalParameter_2727);
                InternalField_2249.Add(InternalParameter_2727, InternalVar_1);
            }

            return InternalMethod_2604(InternalVar_1, ref InternalParameter_2610, InternalParameter_2609, InternalParameter_2608, InternalParameter_2607);
        }

        private InternalType_125 InternalMethod_2604<T>(InternalType_125 InternalParameter_2606, ref T InternalParameter_2605, float InternalParameter_2604, int InternalParameter_2603, InternalType_123 InternalParameter_2602) where T : struct
        {
            if (!InternalField_396.TryGetValue(InternalParameter_2606, out InternalType_153<InternalType_125> InternalVar_1))
            {
                return InternalMethod_2721(ref InternalParameter_2605, InternalParameter_2604, InternalParameter_2603, InternalParameter_2602);
            }

            InternalType_125 InternalVar_2 = InternalMethod_2603(ref InternalParameter_2605, InternalParameter_2604, InternalParameter_2603, InternalParameter_2602);

            InternalVar_1.Add(InternalVar_2);
            InternalField_393.Add(InternalVar_2, InternalParameter_2606);

            if (!InternalField_395.ContainsKey(InternalParameter_2606)) 
            {
                InternalField_390.Add(InternalVar_2);
            }

            return InternalParameter_2606;
        }

        public void InternalMethod_572(InternalType_125 InternalParameter_458)
        {
            InternalType_125 InternalVar_1 = InternalMethod_577(InternalParameter_458);

            if (!InternalVar_1.InternalField_405 && InternalField_391.ContainsKey(InternalVar_1))
            {
                InternalField_390.Remove(InternalVar_1);

                if (InternalField_392.TryGetValue(InternalVar_1, out InternalType_123 InternalVar_2) &&
                    InternalVar_2 is InternalType_122 stateful)
                {
                    stateful.InternalMethod_591(InternalVar_1);
                }

                return;
            }

            if (InternalVar_1.InternalField_405 && InternalField_396.TryGetValue(InternalVar_1, out InternalType_153<InternalType_125> InternalVar_3))
            {
                int InternalVar_4 = InternalVar_3.Count;
                for (int InternalVar_5 = 0; InternalVar_5 < InternalVar_4; ++InternalVar_5)
                {
                    InternalType_125 InternalVar_6 = InternalVar_3[InternalVar_5];
                    InternalField_390.Remove(InternalVar_6);

                    if (InternalField_392.TryGetValue(InternalVar_6, out InternalType_123 InternalVar_7) &&
                        InternalVar_7 is InternalType_122 stateful)
                    {
                        stateful.InternalMethod_591(InternalVar_6);
                    }
                }
            }
        }

        public void InternalMethod_573(InternalType_125 InternalParameter_459)
        {
            InternalType_125 InternalVar_1 = InternalMethod_577(InternalParameter_459);

            if (!InternalVar_1.InternalField_405 && InternalField_391.TryGetValue(InternalVar_1, out InternalType_121 InternalVar_2))
            {
                InternalField_390.Add(InternalVar_1);

                if (InternalVar_2.InternalField_398 != InternalField_386)
                {
                    InternalVar_2.InternalField_398 = InternalField_385 - (InternalVar_2.InternalField_399 - InternalVar_2.InternalField_398);
                    InternalField_391[InternalVar_1] = InternalVar_2;
                }

                if (InternalField_392.TryGetValue(InternalVar_2.InternalField_397, out InternalType_123 InternalVar_3) &&
                    InternalVar_3 is InternalType_122 stateful)
                {
                    stateful.InternalMethod_592(InternalVar_2.InternalField_397);
                }

                return;
            }

            if (InternalVar_1.InternalField_405 && InternalField_396.TryGetValue(InternalVar_1, out InternalType_153<InternalType_125> InternalVar_4))
            {
                for (int InternalVar_5 = 0; InternalVar_5 < InternalVar_4.Count; ++InternalVar_5)
                {
                    InternalType_125 InternalVar_6 = InternalVar_4[InternalVar_5];

                    if (!InternalField_391.TryGetValue(InternalVar_6, out InternalType_121 InternalVar_7))
                    {
                        UnityEngine.Debug.LogError("Child animation not found. Unable to resume");
                        continue;
                    }

                    InternalField_390.Add(InternalVar_6);

                    if (InternalVar_7.InternalField_398 != InternalField_386)
                    {
                        InternalVar_7.InternalField_398 = InternalField_385 - (InternalVar_7.InternalField_399 - InternalVar_7.InternalField_398);
                        InternalField_391[InternalVar_6] = InternalVar_7;
                    }

                    if (InternalField_392.TryGetValue(InternalVar_7.InternalField_397, out InternalType_123 InternalVar_8) &&
                        InternalVar_8 is InternalType_122 stateful)
                    {
                        stateful.InternalMethod_592(InternalVar_7.InternalField_397);
                    }
                }
            }
        }

        public void InternalMethod_574(InternalType_125 InternalParameter_460, bool InternalParameter_461)
        {
            if (InternalMethod_565(InternalParameter_460))
            {
                return;
            }

            InternalMethod_576(InternalParameter_461 ? InternalMethod_577(InternalParameter_460) : InternalParameter_460, InternalParameter_464: false);
        }

        public void InternalMethod_575(InternalType_125 InternalParameter_462)
        {
            if (InternalMethod_565(InternalParameter_462))
            {
                return;
            }

            InternalMethod_576(InternalMethod_577(InternalParameter_462), InternalParameter_464: true);
        }

        private void InternalMethod_576(InternalType_125 InternalParameter_463, bool InternalParameter_464)
        {
            InternalType_153<InternalType_125> InternalVar_1 = null;

            if (InternalField_393.TryGetValue(InternalParameter_463, out InternalType_125 InternalVar_2))
            {
                _ = InternalField_396.TryGetValue(InternalVar_2, out InternalVar_1);
            }

            InternalMethod_579(InternalParameter_463, InternalVar_2, InternalVar_1, InternalParameter_464);
        }

        private InternalType_125 InternalMethod_577(InternalType_125 InternalParameter_465)
        {
            while (InternalField_393.TryGetValue(InternalParameter_465, out InternalType_125 InternalVar_1) ||
                  (InternalParameter_465.InternalField_405 && InternalField_395.TryGetValue(InternalParameter_465, out InternalVar_1)) ||
                  InternalField_2249.TryGetValue(InternalParameter_465, out InternalVar_1))
            {
                InternalParameter_465 = InternalVar_1;
            }

            return InternalParameter_465;
        }

        private InternalType_125 InternalMethod_2603<T>(ref T InternalParameter_2601, float InternalParameter_2600, int InternalParameter_2599, InternalType_123 InternalParameter_2598) where T : struct
        {
            InternalType_152<InternalType_125> InternalVar_1 = InternalType_169<InternalType_125>.InternalType_171<T>.InternalMethod_823(InternalParameter_2601);

            InternalType_121 InternalVar_2 = new InternalType_121()
            {
                InternalField_397 = InternalType_125.InternalMethod_599(InternalVar_1),
                InternalField_398 = InternalField_386,
                InternalField_399 = InternalField_386,
                InternalField_400 = InternalParameter_2600,
                InternalField_401 = InternalParameter_2599,
                InternalField_402 = 0,
            };

            InternalField_392[InternalVar_2.InternalField_397] = InternalParameter_2598;
            InternalField_391[InternalVar_2.InternalField_397] = InternalVar_2;

            return InternalVar_2.InternalField_397;
        }

        private void InternalMethod_579(InternalType_125 InternalParameter_469, InternalType_125 InternalParameter_470, InternalType_153<InternalType_125> InternalParameter_471, bool InternalParameter_472)
        {
            if (InternalParameter_469.InternalField_405)
            {
                InternalMethod_580(InternalParameter_469, InternalParameter_472);
            }
            else
            {
                if (InternalParameter_472)
                {
                    if (InternalField_391.TryGetValue(InternalParameter_469, out InternalType_121 InternalVar_1))
                    {
                        InternalVar_1.InternalField_401 = 1;
                        InternalVar_1.InternalField_398 = InternalField_385 - InternalVar_1.InternalField_400;

                        InternalMethod_583(ref InternalVar_1);

                        InternalField_391.Remove(InternalParameter_469);
                    }
                }
                else
                {
                    if (InternalField_392.TryGetValue(InternalParameter_469, out InternalType_123 InternalVar_1) &&
                        InternalVar_1 is InternalType_122 stateful)
                    {
                        stateful.InternalMethod_593(InternalParameter_469);
                    }
                }

                InternalField_391.Remove(InternalParameter_469);
                InternalField_390.Remove(InternalParameter_469);
                InternalField_392.Remove(InternalParameter_469);
            }

            if (InternalParameter_470.InternalField_404.InternalProperty_220 && InternalParameter_471 != null)
            {
                InternalParameter_471.Remove(InternalParameter_469);
                InternalField_393.Remove(InternalParameter_469);

                if (InternalParameter_471.Count == 0)
                {
                    if (InternalField_395.TryGetValue(InternalParameter_470, out InternalType_125 InternalVar_1))
                    {
                        InternalField_395.Remove(InternalParameter_470);
                        InternalField_394.Remove(InternalVar_1);
                    }

                    if (InternalField_2248.TryGetValue(InternalParameter_470, out InternalType_125 InternalVar_2))
                    {
                        InternalField_2248.Remove(InternalParameter_470);
                        InternalField_2249.Remove(InternalVar_2);
                    }

                    InternalField_396.Remove(InternalParameter_470);
                    InternalMethod_587(InternalParameter_471);
                }
            }

            if (InternalField_394.TryGetValue(InternalParameter_469, out InternalType_125 InternalVar_3))
            {
                InternalMethod_576(InternalVar_3, InternalParameter_472);
            }
        }

        private void InternalMethod_580(InternalType_125 InternalParameter_473, bool InternalParameter_474)
        {
            if (!InternalField_396.TryGetValue(InternalParameter_473, out InternalType_153<InternalType_125> InternalVar_1))
            {
                return;
            }

            while (InternalVar_1.Count > 0)
            {
                InternalType_125 InternalVar_2 = InternalVar_1[InternalVar_1.Count - 1];
                InternalMethod_579(InternalVar_2, InternalParameter_473, InternalVar_1, InternalParameter_474);
            }
        }

        public void InternalMethod_581()
        {
            InternalMethod_582();
            InternalMethod_584();
        }

        private void InternalMethod_582()
        {
            InternalField_385 = UnityEngine.Time.unscaledTime;
            int InternalVar_1 = InternalField_390.Count;

            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; ++InternalVar_2)
            {
                InternalType_125 InternalVar_3 = InternalField_390[InternalVar_2];
                InternalType_121 InternalVar_4 = InternalField_391[InternalVar_3];
                InternalMethod_583(ref InternalVar_4);
            }
        }

        private void InternalMethod_583(ref InternalType_121 InternalParameter_475)
        {
            InternalType_123 InternalVar_1 = InternalField_392[InternalParameter_475.InternalField_397];
            InternalType_122 InternalVar_2 = InternalVar_1 as InternalType_122;

            if (InternalParameter_475.InternalField_398 == InternalField_386)
            {
                InternalParameter_475.InternalField_398 = InternalField_385;

                if (InternalVar_2 != null)
                {
                    InternalVar_2.InternalMethod_588(InternalParameter_475.InternalField_397, InternalParameter_475.InternalField_402);
                }
            }

            InternalParameter_475.InternalField_399 = InternalField_385;
            InternalField_391[InternalParameter_475.InternalField_397] = InternalParameter_475;

            float InternalVar_3 = InternalParameter_475.InternalField_400 == 0 ? 1 : UnityEngine.Mathf.Clamp01((InternalField_385 - InternalParameter_475.InternalField_398) / InternalParameter_475.InternalField_400);

            if (InternalType_187.InternalMethod_914(InternalVar_3))
            {
                InternalVar_3 = 0;
            }
            else if (InternalType_187.InternalMethod_922(InternalVar_3, 1))
            {
                InternalVar_3 = 1;
            }

            InternalVar_1.InternalMethod_594(InternalParameter_475.InternalField_397, InternalVar_3);

            if (InternalVar_3 == 1)
            {
                if (InternalVar_2 != null)
                {
                    InternalVar_2.InternalMethod_589(InternalParameter_475.InternalField_397);
                }

                if (InternalParameter_475.InternalField_401 == 1)
                {
                    if (InternalVar_2 != null)
                    {
                        InternalVar_2.InternalMethod_590(InternalParameter_475.InternalField_397);
                    }

                    InternalField_389.Add(InternalParameter_475.InternalField_397);
                }
                else if (InternalParameter_475.InternalField_401 > 1)
                {
                    InternalParameter_475.InternalField_401--;
                    InternalParameter_475.InternalField_402++;
                    InternalParameter_475.InternalField_398 = InternalField_386;
                    InternalField_391[InternalParameter_475.InternalField_397] = InternalParameter_475;
                }
                else 
                {
                    InternalParameter_475.InternalField_398 = InternalField_386;
                    InternalParameter_475.InternalField_402++;
                    InternalField_391[InternalParameter_475.InternalField_397] = InternalParameter_475;
                }
            }
        }

        private void InternalMethod_584()
        {
            int InternalVar_1 = InternalField_389.Count;

            if (InternalVar_1 == 0)
            {
                return;
            }

            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1; ++InternalVar_2)
            {
                InternalType_125 InternalVar_3 = InternalField_389[InternalVar_2];
                InternalField_390.Remove(InternalVar_3);
                InternalField_392.Remove(InternalVar_3);
                InternalField_391.Remove(InternalVar_3);

                if (InternalField_393.TryGetValue(InternalVar_3, out InternalType_125 InternalVar_4) &&
                    InternalField_396.TryGetValue(InternalVar_4, out InternalType_153<InternalType_125> InternalVar_5))
                {
                    InternalVar_5.Remove(InternalVar_3);
                    InternalField_393.Remove(InternalVar_3);

                    if (InternalVar_5.Count == 0)
                    {
                        InternalMethod_585(InternalVar_4);
                        InternalField_396.Remove(InternalVar_4);

                        if (InternalField_2248.TryGetValue(InternalVar_4, out InternalType_125 InternalVar_6))
                        {
                            InternalField_2248.Remove(InternalVar_4);
                            InternalField_2249.Remove(InternalVar_6);
                        }

                        InternalMethod_587(InternalVar_5);
                    }
                }

                InternalMethod_585(InternalVar_3);
            }

            InternalField_389.Clear();
        }

        private void InternalMethod_585(InternalType_125 InternalParameter_476)
        {
            if (!InternalField_394.TryGetValue(InternalParameter_476, out InternalType_125 InternalVar_1))
            {
                return;
            }

            InternalField_394.Remove(InternalParameter_476);
            InternalField_395.Remove(InternalVar_1);

            InternalType_153<InternalType_125> InternalVar_2 = InternalField_396[InternalVar_1];

            for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_2.Count; ++InternalVar_3)
            {
                InternalType_125 InternalVar_4 = InternalVar_2[InternalVar_3];

                if (InternalVar_4.InternalField_405 && InternalField_396.TryGetValue(InternalVar_4, out InternalType_153<InternalType_125> InternalVar_5))
                {
                    InternalField_390.InternalMethod_720(InternalVar_5);
                }
                else
                {
                    InternalField_390.Add(InternalVar_4);
                }
            }
        }

        private InternalType_153<InternalType_125> InternalMethod_586()
        {
            return InternalField_388.Count > 0 ? InternalField_388.Dequeue() : new InternalType_153<InternalType_125>();
        }

        private void InternalMethod_587(InternalType_153<InternalType_125> InternalParameter_477)
        {
            InternalParameter_477.Clear();

            InternalField_388.Enqueue(InternalParameter_477);
        }

        public override void InternalMethod_603()
        {
            InternalField_406 = this;
        }

        public override void Dispose()
        {
            InternalField_388.Clear();

            InternalField_389.Clear();
            InternalField_390.Clear();
            InternalField_391.Clear();
            InternalField_392.Clear();

            InternalField_393.Clear();
            InternalField_394.Clear();
            InternalField_2249.Clear();
            InternalField_395.Clear();
            InternalField_396.Clear();
            InternalField_2248.Clear();
        }
    }
}
