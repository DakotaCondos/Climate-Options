using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_9;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;

namespace Nova.InternalNamespace_0
{
    internal static class InternalType_119
    {
        
        private static void InternalMethod_555(InternalType_146 InternalParameter_424, InternalType_157<int> InternalParameter_425 = null)
        {
            if (!InternalParameter_424.InternalProperty_212)
            {
                return;
            }

            InternalParameter_424.InternalProperty_214.Clear();
            InternalParameter_424.InternalProperty_215.Clear();

            if (!InternalParameter_424.InternalProperty_203)
            {
                for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_424.InternalProperty_202.childCount; ++InternalVar_1)
                {
                    UnityEngine.Transform InternalVar_2 = InternalParameter_424.InternalProperty_202.GetChild(InternalVar_1);
                    if (InternalVar_2.TryGetComponent(out InternalType_146 InternalVar_3) && InternalVar_3.InternalMethod_556())
                    {
                        if (InternalParameter_425 != null)
                        {
                            InternalParameter_425.Add(InternalVar_3.InternalProperty_209);
                        }

                        InternalParameter_424.InternalProperty_214.Add(InternalVar_3.InternalProperty_195);
                        InternalParameter_424.InternalProperty_215.Add(InternalVar_3);
                    }
                }
            }

            InternalParameter_424.InternalProperty_212 = false;
            InternalParameter_424.InternalProperty_213 = false;
        }

        public static bool InternalMethod_556(this InternalType_146 InternalParameter_426)
        {
            return InternalParameter_426.InternalProperty_151;
        }

        public static void InternalMethod_557(this InternalType_146 InternalParameter_427)
        {
            if (InternalParameter_427.InternalProperty_197 == InternalParameter_427.InternalMethod_556())
            {
                return;
            }

            InternalParameter_427.InternalMethod_645();
            InternalParameter_427.InternalMethod_564();
        }

        public static void InternalMethod_558(this InternalType_146 InternalParameter_428)
        {
            InternalType_146 InternalVar_1 = InternalParameter_428.InternalProperty_210 as InternalType_146;

            if (InternalVar_1 == null)
            {
                return;
            }

            InternalType_131 InternalVar_2 = InternalParameter_428.InternalProperty_195;
            int InternalVar_3 = InternalVar_1.InternalProperty_214.IndexOf(InternalVar_2);

            if (InternalVar_3 == -1)
            {
                UnityEngine.Debug.LogError("Child Node not found in Parent list");
                return;
            }

            InternalVar_1.InternalProperty_214.RemoveAt(InternalVar_3);
            InternalVar_1.InternalProperty_214.Insert(0, InternalVar_2);

            InternalVar_1.InternalProperty_215.RemoveAt(InternalVar_3);
            InternalVar_1.InternalProperty_215.Insert(0, InternalParameter_428);

            InternalType_253.InternalProperty_190.InternalMethod_1162(InternalVar_1.InternalProperty_195, InternalVar_2);

            InternalVar_1.InternalProperty_213 = true;
        }

        public static void InternalMethod_559(this InternalType_146 InternalParameter_429, int InternalParameter_430)
        {
            InternalType_146 InternalVar_1 = InternalParameter_429.InternalProperty_210;
            if (InternalVar_1 == null)
            {
                return;
            }

            InternalType_131 InternalVar_2 = InternalParameter_429.InternalProperty_195;
            int InternalVar_3 = InternalVar_1.InternalProperty_214.IndexOf(InternalVar_2);

            if (InternalVar_3 == -1)
            {
                UnityEngine.Debug.LogError("Child Node not found in Parent list");
                return;
            }

            InternalVar_1.InternalProperty_214.RemoveAt(InternalVar_3);
            InternalVar_1.InternalProperty_214.Add(InternalVar_2);

            InternalVar_1.InternalProperty_215.RemoveAt(InternalVar_3);
            InternalVar_1.InternalProperty_215.Add(InternalParameter_429);

            InternalType_253.InternalProperty_190.InternalMethod_1163(InternalVar_1.InternalProperty_195, InternalVar_2, InternalParameter_430);

            InternalVar_1.InternalProperty_213 = true;
        }

        public static void InternalMethod_560(this InternalType_146 InternalParameter_431)
        {
            if (!InternalParameter_431.InternalMethod_556())
            {
                return;
            }

            InternalParameter_431.InternalProperty_212 = !InternalParameter_431.InternalProperty_213;

            if (InternalParameter_431.InternalProperty_212)
            {
                InternalType_157<int> InternalVar_1 = InternalType_155<int>.InternalMethod_740();
                InternalMethod_555(InternalParameter_431, InternalVar_1);

                if (InternalParameter_431.InternalProperty_214.Count > 0)
                {
                    InternalType_253.InternalProperty_190.InternalMethod_2014(InternalParameter_431.InternalProperty_195, InternalParameter_431.InternalProperty_214.InternalMethod_2043(), InternalVar_1.InternalMethod_2043());
                }

                InternalType_155<int>.InternalMethod_741(InternalVar_1);
            }

            InternalParameter_431.InternalProperty_213 = false;

            if (InternalParameter_431.InternalProperty_214.Count == 0 && !InternalParameter_431.InternalMethod_556())
            {
                InternalParameter_431.InternalMethod_645();
            }
        }

        public static void InternalMethod_561(this InternalType_146 InternalParameter_432)
        {
            if (!InternalParameter_432.InternalProperty_197)
            {
                return;
            }

            InternalType_146 InternalVar_1 = InternalParameter_432.InternalProperty_210;

            int InternalVar_2 = InternalVar_1.InternalProperty_214.IndexOf(InternalParameter_432.InternalProperty_195);

            if (InternalVar_2 != -1)
            {
                InternalVar_1.InternalProperty_214.RemoveAt(InternalVar_2);
                InternalVar_1.InternalProperty_215.RemoveAt(InternalVar_2);
            }
            else
            {
                UnityEngine.Debug.LogWarning($"{InternalParameter_432.InternalProperty_198} not registered with parent {InternalVar_1.InternalProperty_198}");
            }

            InternalVar_1.InternalProperty_213 = true;

            InternalType_253.InternalProperty_190.InternalMethod_1149(InternalParameter_432);
        }

        public static void InternalMethod_562(this InternalType_146 InternalParameter_433)
        {
            InternalType_146 InternalVar_1 = InternalParameter_433.InternalProperty_210;

            if (InternalVar_1 == null || !InternalParameter_433.InternalMethod_556())
            {
                return;
            }


            bool InternalVar_2 = InternalParameter_433.InternalProperty_197;
            if (!InternalVar_2)
            {
                InternalParameter_433.InternalMethod_564();

                if (!InternalParameter_433.InternalProperty_197)
                {
                    UnityEngine.Debug.LogWarning($"{InternalParameter_433.InternalProperty_198} didn't register. ShouldBeRegistered == {InternalParameter_433.InternalMethod_556()}");
                }
            }

            bool InternalVar_3 = InternalVar_1.InternalProperty_197;
            if (!InternalVar_3)
            {
                InternalVar_1.InternalMethod_564();

                if (!InternalVar_1.InternalProperty_197)
                {
                    UnityEngine.Debug.LogWarning($"Parent {InternalVar_1.InternalProperty_198} didn't register. Aborting.");
                    return;
                }
            }


            int InternalVar_4 = InternalVar_2 && InternalVar_3 ? InternalType_253.InternalProperty_190.InternalMethod_1148(InternalParameter_433, InternalVar_1) : InternalType_253.InternalProperty_190.InternalMethod_1161(InternalParameter_433.InternalProperty_195);

            if (InternalVar_4 < 0 || InternalVar_4 > InternalVar_1.InternalProperty_214.Count)
            {
                UnityEngine.Debug.LogError($"Sibling index [{InternalVar_4}]. Expected [0, {InternalVar_1.InternalProperty_214.Count})");
            }

            if (InternalVar_4 == InternalVar_1.InternalProperty_214.Count || InternalVar_1.InternalProperty_214[InternalVar_4] != InternalParameter_433.InternalProperty_195)
            {
                InternalVar_1.InternalProperty_214.Insert(InternalVar_4, InternalParameter_433.InternalProperty_195);
                InternalVar_1.InternalProperty_215.Insert(InternalVar_4, InternalParameter_433);
            }

            InternalVar_1.InternalProperty_213 = true;
        }

        public static void InternalMethod_563(this InternalType_146 InternalParameter_434)
        {
            InternalParameter_434.InternalProperty_210 = null;

            for (int InternalVar_1 = InternalParameter_434.InternalProperty_214.Count - 1; InternalVar_1 >= 0; --InternalVar_1)
            {
                InternalParameter_434.InternalProperty_215[InternalVar_1].InternalProperty_210 = null;
            }

            InternalParameter_434.InternalProperty_215.Clear();
            InternalParameter_434.InternalProperty_214.Clear();

            InternalParameter_434.InternalMethod_645();
        }

        public static void InternalMethod_564(this InternalType_146 InternalParameter_435)
        {
            if (!InternalParameter_435.InternalMethod_556() || InternalParameter_435.InternalProperty_197)
            {
                return;
            }

            if (InternalParameter_435.InternalProperty_210 == null)
            {
                InternalParameter_435.InternalMethod_644();
            }
            else if (!InternalParameter_435.InternalProperty_210.InternalProperty_197)
            {
                InternalParameter_435.InternalProperty_210.InternalProperty_212 = true;

                InternalParameter_435.InternalProperty_210.InternalMethod_564();
                bool InternalVar_1 = InternalParameter_435.InternalProperty_210.InternalProperty_197;

                if (InternalVar_1 && !InternalParameter_435.InternalProperty_197)
                {
                    UnityEngine.Debug.LogError($"Parent [{InternalParameter_435.InternalProperty_210.InternalProperty_198}] should have told us [{InternalParameter_435.InternalProperty_198}] to register, but apparently that failed...? ShouldBeRegistered == {InternalParameter_435.InternalMethod_556()}");
                    InternalParameter_435.InternalMethod_644();
                }
            }
            else
            {
                InternalParameter_435.InternalMethod_644();
            }

            bool InternalVar_2 = InternalParameter_435.InternalProperty_213;

            if (InternalParameter_435.InternalProperty_212)
            {
                InternalMethod_555(InternalParameter_435);
            }

            for (int InternalVar_3 = 0; InternalVar_3 < InternalParameter_435.InternalProperty_214.Count; ++InternalVar_3)
            {
                InternalParameter_435.InternalProperty_215[InternalVar_3].InternalProperty_210 = InternalParameter_435;
            }

            InternalParameter_435.InternalProperty_213 = InternalVar_2;
        }

        
        public static InternalType_5 InternalMethod_3592(this InternalType_5 InternalParameter_3325) => InternalType_253.InternalProperty_190.InternalMethod_1158(InternalParameter_3325.InternalProperty_195) as InternalType_5;
        public static InternalType_164<InternalType_133> InternalMethod_3593(this InternalType_5 InternalParameter_3326) => InternalType_253.InternalProperty_190.InternalMethod_3606(InternalParameter_3326.InternalProperty_196);
        public static int InternalMethod_3594(this InternalType_5 InternalParameter_3327, InternalType_5 InternalParameter_3328)
        {
            if (InternalParameter_3328 == null)
            {
                return -1;
            }

            InternalType_164<InternalType_133> InternalVar_1 = InternalParameter_3327.InternalMethod_3593();

            if (InternalVar_1.InternalMethod_769(InternalParameter_3328.InternalProperty_196, out int InternalVar_2))
            {
                return InternalVar_2;
            }

            return -1;
        }

        public static InternalType_5 InternalMethod_3595(this InternalType_5 InternalParameter_3329, int InternalParameter_3330)
        {
            if (InternalParameter_3330 < 0)
            {
                return null;
            }

            InternalType_164<InternalType_133> InternalVar_1 = InternalParameter_3329.InternalMethod_3593();

            if (InternalParameter_3330 >= InternalVar_1.InternalProperty_216)
            {
                return null;
            }

            return InternalType_253.InternalProperty_190.InternalField_413[InternalType_253.InternalProperty_190.InternalProperty_259.InternalMethod_667(InternalVar_1[InternalParameter_3330])] as InternalType_5;
        }

        public static int InternalMethod_3596(this InternalType_5 InternalParameter_3331) => InternalParameter_3331.InternalMethod_3593().InternalProperty_216;

        public static bool InternalMethod_3597(this InternalType_5 InternalParameter_3332, InternalType_5 InternalParameter_3333) => InternalParameter_3333 == null ? false : InternalType_253.InternalProperty_190.InternalMethod_3605(InternalParameter_3332.InternalProperty_196, InternalParameter_3333.InternalProperty_195, out _);

        public static InternalType_5 InternalMethod_3598(this InternalType_5 InternalParameter_3334, InternalType_5 InternalParameter_3335)
        {
            if (InternalParameter_3335 == null)
            {
                return null;
            }

            if (!InternalType_253.InternalProperty_190.InternalMethod_3605(InternalParameter_3335.InternalProperty_196, InternalParameter_3334.InternalProperty_195, out InternalType_145 InternalVar_1))
            {
                return null;
            }

            return InternalVar_1 as InternalType_5;
        }
    }
}

