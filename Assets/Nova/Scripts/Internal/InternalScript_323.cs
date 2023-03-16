using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_11;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Collections.Generic;
using UnityEngine;


namespace Nova.InternalNamespace_0
{
    internal enum InternalType_764
    {
        InternalField_1157,
        InternalField_1557,
        InternalField_1558
    }

    internal struct InternalType_756
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_5 InternalField_3547;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_5 InternalField_3548;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_5 InternalField_3549;
    }

    internal static class InternalType_757<T103> where T103 : MonoBehaviour, InternalType_5
    {
        private class InternalType_758
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private Dictionary<T103, InternalType_153<T103>> InternalField_3555 = new Dictionary<T103, InternalType_153<T103>>();
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private Dictionary<T103, T103> InternalField_3556 = new Dictionary<T103, T103>();

            public void InternalMethod_3587(T103 InternalParameter_3319)
            {
                if (InternalField_3555.ContainsKey(InternalParameter_3319))
                {
                    return;
                }

                InternalField_3555.Add(InternalParameter_3319, InternalType_156<InternalType_153<T103>, T103>.InternalMethod_740());
            }

            public InternalType_521<T103> InternalMethod_3588(T103 InternalParameter_3320)
            {
                if (InternalField_3555.TryGetValue(InternalParameter_3320, out InternalType_153<T103> InternalVar_1))
                {
                    return InternalVar_1.InternalProperty_221;
                }

                return InternalType_521<T103>.InternalProperty_435;
            }

            public void InternalMethod_3589(T103 InternalParameter_3321)
            {
                if (!InternalField_3555.TryGetValue(InternalParameter_3321, out InternalType_153<T103> InternalVar_1))
                {
                    return;
                }

                InternalType_521<T103> InternalVar_2 = InternalVar_1.InternalProperty_221;

                for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_2.InternalProperty_433; InternalVar_3++)
                {
                    InternalField_3556.Remove(InternalVar_2[InternalVar_3]);
                }

                InternalField_3555.Remove(InternalParameter_3321);
                InternalType_156<InternalType_153<T103>, T103>.InternalMethod_741(InternalVar_1);
            }

            public void InternalMethod_3590(T103 InternalParameter_3322, T103 InternalParameter_3323)
            {
                InternalMethod_3591(InternalParameter_3322);

                InternalField_3556[InternalParameter_3322] = InternalParameter_3323;
                InternalField_3555[InternalParameter_3323].Add(InternalParameter_3322);
            }

            public void InternalMethod_3591(T103 InternalParameter_3324)
            {
                if (!InternalField_3556.TryGetValue(InternalParameter_3324, out T103 InternalVar_1))
                {
                    return;
                }

                InternalField_3556.Remove(InternalParameter_3324);
                InternalField_3555[InternalVar_1].Remove(InternalParameter_3324);
            }
        }


        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_761<T103> InternalField_3550 = new InternalType_761<T103>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_761<T103> InternalField_3551 = new InternalType_761<T103>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static List<InternalType_428> InternalField_3552 = new List<InternalType_428>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static List<T103> InternalField_1085 = new List<T103>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_758 InternalField_3554 = new InternalType_758();

        public static event System.Action<uint, T103, T103, int> InternalEvent_12 = null;

        public static void InternalMethod_3563(T103 InternalParameter_3241, bool InternalParameter_3242)
        {
            InternalType_429.InternalProperty_200.InternalMethod_3610(InternalParameter_3241.InternalProperty_195, InternalParameter_3242);
        }

        public static void InternalMethod_3564(T103 InternalParameter_3243)
        {
            InternalType_429.InternalProperty_200.InternalMethod_3608(InternalParameter_3243.InternalProperty_195);
        }

        public static void InternalMethod_3565(T103 InternalParameter_3244)
        {
            InternalType_429.InternalProperty_200.InternalMethod_3609(InternalParameter_3244.InternalProperty_195);

            InternalField_3554.InternalMethod_3591(InternalParameter_3244);

            InternalType_521<InternalType_761<T103>.InternalType_762> InternalVar_1 = InternalField_3551.InternalMethod_3630(InternalParameter_3244);

            for (int InternalVar_2 = InternalVar_1.InternalProperty_433 - 1; InternalVar_2 >= 0; --InternalVar_2)
            {
                InternalType_761<T103>.InternalType_762 InternalVar_3 = InternalVar_1[InternalVar_2];
                bool InternalVar_4 = InternalMethod_3568(InternalVar_3.InternalField_3601) == InternalParameter_3244;
                InternalMethod_3567(InternalVar_3.InternalField_3601, InternalParameter_3244);

                if (InternalVar_4)
                {
                    InternalEvent_12(InternalVar_3.InternalField_3601, InternalParameter_3244, InternalMethod_3568(InternalVar_3.InternalField_3601), InternalVar_3.InternalField_3602);
                }
            }
        }

        public static void InternalMethod_3566(T103 InternalParameter_3245)
        {
            InternalType_429.InternalProperty_200.InternalMethod_3611(InternalParameter_3245.InternalProperty_195);

            InternalType_521<InternalType_761<T103>.InternalType_762> InternalVar_1 = InternalField_3550.InternalMethod_3630(InternalParameter_3245);

            for (int InternalVar_2 = InternalVar_1.InternalProperty_433 - 1; InternalVar_2 >= 0; --InternalVar_2)
            {
                InternalType_761<T103>.InternalType_762 InternalVar_3 = InternalVar_1[InternalVar_2];
                InternalField_3550.InternalMethod_3625(InternalVar_3.InternalField_3601, InternalParameter_3245);
            }

            if (!InternalParameter_3245.InternalProperty_152)
            {
                InternalType_521<T103> InternalVar_2 = InternalField_3554.InternalMethod_3588(InternalParameter_3245);
                for (int InternalVar_3 = InternalVar_2.InternalProperty_433 - 1; InternalVar_3 >= 0; --InternalVar_3)
                {
                    InternalMethod_3565(InternalVar_2[InternalVar_3]);
                }
            }

            InternalField_3554.InternalMethod_3589(InternalParameter_3245);
        }

        private static void InternalMethod_3567(uint InternalParameter_3246, T103 InternalParameter_3247) => InternalField_3551.InternalMethod_3625(InternalParameter_3246, InternalParameter_3247);

        public static T103 InternalMethod_3568(uint InternalParameter_3248) => InternalField_3551.InternalMethod_3627(InternalParameter_3248);

        public static void InternalMethod_3569(uint InternalParameter_3249, T103 InternalParameter_3250, int InternalParameter_3251)
        {
            if (InternalParameter_3250 == null)
            {
                InternalMethod_3573(InternalParameter_3249);
                return;
            }

            InternalField_3551.InternalMethod_3623(InternalParameter_3249, InternalParameter_3250, InternalParameter_3251);

            T103 InternalVar_1 = InternalField_3550.InternalMethod_3627(InternalParameter_3249);

            if (InternalVar_1 != null)
            {
                InternalField_3554.InternalMethod_3590(InternalParameter_3250, InternalVar_1);
            }
        }

        public static T103 InternalMethod_3570(uint InternalParameter_3252) => InternalField_3550.InternalMethod_3627(InternalParameter_3252);

        public static T103 InternalMethod_3571(uint InternalParameter_3253, int InternalParameter_3254) => InternalField_3550.InternalMethod_3628(InternalParameter_3253, InternalParameter_3254);

        public static int InternalMethod_3620(uint InternalParameter_3312) => InternalField_3550.InternalMethod_3629(InternalParameter_3312);

        public static void InternalMethod_3572(uint InternalParameter_3255, T103 InternalParameter_3256, int InternalParameter_3257)
        {
            InternalField_3550.InternalMethod_3623(InternalParameter_3255, InternalParameter_3256, InternalParameter_3257);
            InternalField_3554.InternalMethod_3587(InternalParameter_3256);
        }

        public static void InternalMethod_3573(uint InternalParameter_3258)
        {
            InternalField_3550.InternalMethod_3626(InternalParameter_3258);
            InternalField_3551.InternalMethod_3626(InternalParameter_3258);
        }

        public static T103 InternalMethod_3574(uint InternalParameter_3259)
        {
            T103 InternalVar_1 = InternalField_3550.InternalMethod_3624(InternalParameter_3259);

            if (InternalVar_1 != null)
            {
                T103 InternalVar_2 = InternalField_3551.InternalMethod_3627(InternalParameter_3259);

                while (InternalVar_2 != null && InternalVar_2 != InternalVar_1 && InternalVar_2.transform.IsChildOf(InternalVar_1.transform))
                {
                    InternalVar_2 = InternalField_3551.InternalMethod_3624(InternalParameter_3259);
                }
            }

            return InternalVar_1;
        }

        public static bool InternalMethod_3575(uint InternalParameter_3260, T103 InternalParameter_3261)
        {
            T103 InternalVar_1 = InternalField_3550.InternalMethod_3627(InternalParameter_3260);

            return InternalVar_1 == null || (InternalParameter_3261 != null && InternalParameter_3261.transform.IsChildOf(InternalVar_1.transform));
        }

        
        public static InternalType_764 InternalMethod_3613(T103 InternalParameter_3311, T103 InternalParameter_3402, Vector3 InternalParameter_3401, int InternalParameter_3362, out InternalType_5 InternalParameter_3361)
        {
            InternalParameter_3361 = null;

            if (InternalParameter_3311 != InternalParameter_3402)
            {
                if (InternalMethod_3577(InternalParameter_3311, InternalParameter_3401, out InternalParameter_3361))
                {
                    return InternalType_764.InternalField_1557;
                }
            }

            if (InternalParameter_3402 != null && InternalParameter_3402.InternalProperty_34.InternalProperty_1150 != null)
            {
                bool InternalVar_2 = InternalMethod_3586(InternalParameter_3402, InternalParameter_3311, InternalParameter_3401, InternalParameter_3362, out InternalType_756 InternalVar_1);

                bool InternalVar_3 = InternalParameter_3402.InternalProperty_34.InternalProperty_1150.InternalMethod_3576(InternalVar_1.InternalField_3548, InternalVar_1.InternalField_3549, InternalParameter_3401);

                if (InternalVar_2)
                {
                    InternalParameter_3361 = InternalVar_1.InternalField_3547;
                    return InternalType_764.InternalField_1557;
                }

                if (InternalVar_3)
                {
                    return InternalType_764.InternalField_1558;
                }
            }

            return InternalType_764.InternalField_1157;
        }

        public static void InternalMethod_3637(InternalType_5 InternalParameter_3360, uint InternalParameter_3359, int InternalParameter_3422)
        {
            int InternalVar_1 = InternalParameter_3422 + 1;

            InternalParameter_3360.InternalMethod_442();

            for (T103 InternalVar_2 = InternalMethod_3571(InternalParameter_3359, InternalVar_1); InternalVar_2 != null; InternalVar_2 = InternalMethod_3571(InternalParameter_3359, ++InternalVar_1))
            {
                InternalVar_2.InternalProperty_34.InternalProperty_1150.InternalMethod_3585(InternalParameter_3360);
            }
        }

        public static bool InternalMethod_3577(T103 InternalParameter_3267, Vector3 InternalParameter_3268, out InternalType_5 InternalParameter_3269)
        {
            InternalParameter_3269 = null;
            return InternalParameter_3267 != null && InternalParameter_3267.InternalProperty_34.InternalProperty_1150 != null && InternalParameter_3267.InternalProperty_34.InternalProperty_1150.InternalMethod_3561(InternalParameter_3268, out InternalParameter_3269);
        }

        public static bool InternalMethod_3578(T103 InternalParameter_3270, InternalType_5 InternalParameter_3271, Vector3 InternalParameter_3272, int InternalParameter_3273, bool InternalParameter_3274, out InternalType_428 InternalParameter_3275) =>
            InternalMethod_3579(InternalMethod_3583(InternalParameter_3272, InternalParameter_3270, InternalParameter_3270 == InternalParameter_3271), InternalParameter_3270, InternalParameter_3271, InternalParameter_3273, InternalParameter_3274, out InternalParameter_3275, InternalParameter_3282: false);

        public static bool InternalMethod_3579(Ray InternalParameter_3276, T103 InternalParameter_3277, InternalType_5 InternalParameter_3278, int InternalParameter_3279, bool InternalParameter_3280, out InternalType_428 InternalParameter_3281, bool InternalParameter_3282 = true, bool InternalParameter_3283 = false)
        {
            InternalParameter_3281 = default;

            InternalType_131 InternalVar_1 = InternalParameter_3278 == null || !InternalParameter_3278.InternalProperty_151 ? InternalType_131.InternalField_415 : InternalParameter_3278.InternalProperty_195;
            InternalType_131 InternalVar_2 = InternalParameter_3277 == null || !InternalParameter_3277.InternalProperty_151 ? InternalType_131.InternalField_415 : InternalParameter_3277.InternalProperty_195;

            if (InternalParameter_3283)
            {
                InternalType_429.InternalProperty_200.InternalMethod_3615(InternalParameter_3276, InternalVar_1, InternalVar_2, InternalParameter_3282, InternalField_3552, InternalParameter_3379: InternalParameter_3279);
            }
            else
            {
                InternalType_429.InternalProperty_200.InternalMethod_3614(InternalParameter_3276, InternalVar_1, InternalVar_2, InternalParameter_3280, InternalParameter_3282, InternalField_3552, InternalParameter_3370: InternalParameter_3279);
            }

            for (int InternalVar_3 = 0; InternalVar_3 < InternalField_3552.Count; ++InternalVar_3)
            {
                InternalType_428 InternalVar_4 = InternalField_3552[InternalVar_3];

                if (InternalVar_4.InternalField_1642.InternalProperty_34.InternalProperty_1150 != null)
                {
                    InternalParameter_3281 = InternalVar_4;
                    return true;
                }
            }

            return false;
        }

        public static bool InternalMethod_3580(Ray InternalParameter_3284, T103 InternalParameter_3285, InternalType_5 InternalParameter_3286, int InternalParameter_3287, bool InternalParameter_3288, System.Func<InternalType_5, bool> InternalParameter_3289, out InternalType_428 InternalParameter_3290, bool InternalParameter_3291 = false)
        {
            InternalParameter_3290 = default;

            InternalType_131 InternalVar_1 = InternalParameter_3286 == null || !InternalParameter_3286.InternalProperty_151 ? InternalType_131.InternalField_415 : InternalParameter_3286.InternalProperty_195;
            InternalType_131 InternalVar_2 = InternalParameter_3285 == null || !InternalParameter_3285.InternalProperty_151 ? InternalType_131.InternalField_415 : InternalParameter_3285.InternalProperty_195;

            bool InternalVar_3 = NovaApplication.InPlayer(InternalParameter_3285);

            if (InternalParameter_3291)
            {
                InternalType_429.InternalProperty_200.InternalMethod_3615(InternalParameter_3284, InternalVar_1, InternalVar_2, InternalParameter_3376: false, InternalField_3552, InternalVar_3, InternalParameter_3379: InternalParameter_3287, InternalParameter_3380: InternalParameter_3289);
            }
            else
            {
                InternalType_429.InternalProperty_200.InternalMethod_3614(InternalParameter_3284, InternalVar_1, InternalVar_2, InternalParameter_3288, InternalParameter_3367: false, InternalField_3552, InternalVar_3, InternalParameter_3370: InternalParameter_3287, InternalParameter_3371: InternalParameter_3289);
            }

            for (int InternalVar_4 = 0; InternalVar_4 < InternalField_3552.Count; ++InternalVar_4)
            {
                InternalType_428 InternalVar_5 = InternalField_3552[InternalVar_4];

                if (InternalParameter_3289(InternalVar_5.InternalField_1642))
                {
                    InternalParameter_3290 = InternalVar_5;
                    return true;
                }
            }

            return false;
        }

        public static bool InternalMethod_3581(Ray InternalParameter_3292, int InternalParameter_3293, InternalType_131 InternalParameter_3294, InternalType_131 InternalParameter_3295, bool InternalParameter_3296, out InternalType_428 InternalParameter_3297)
        {
            InternalField_3552.Clear();
            InternalType_429.InternalProperty_200.InternalMethod_3614(InternalParameter_3292, InternalParameter_3294, InternalParameter_3295, false, true, InternalField_3552, InternalParameter_3370: InternalParameter_3293, InternalParameter_3369: InternalParameter_3296);

            InternalParameter_3297 = InternalField_3552.Count > 0 ? InternalField_3552[0] : default;
            return InternalParameter_3297.InternalField_1642 as T103 != null;
        }

        public static InternalType_521<InternalType_428> InternalMethod_3582(Ray InternalParameter_3298, int InternalParameter_3299, InternalType_131 InternalParameter_3300, InternalType_131 InternalParameter_3301, bool InternalParameter_3302)
        {
            InternalField_3552.Clear();
            InternalType_429.InternalProperty_200.InternalMethod_3614(InternalParameter_3298, InternalParameter_3300, InternalParameter_3301, false, true, InternalField_3552, InternalParameter_3370: InternalParameter_3299, InternalParameter_3372: int.MaxValue, InternalParameter_3369: InternalParameter_3302);
            return InternalField_3552.InternalMethod_2043();
        }

        public static Ray InternalMethod_3583(Vector3 InternalParameter_3303, T103 InternalParameter_3304, bool InternalParameter_3305 = false)
        {
            Vector3 InternalVar_1 = InternalParameter_3305 ? -InternalParameter_3303 : InternalParameter_3303;

            float InternalVar_2 = Mathf.Abs(1 / InternalType_187.InternalMethod_865(InternalVar_1));
            InternalVar_2 = float.IsNaN(InternalVar_2) || float.IsInfinity(InternalVar_2) ? 0 : InternalVar_2;

            Vector3 InternalVar_3 = Vector3.Scale(InternalParameter_3304.InternalProperty_144.InternalProperty_124, InternalVar_1 * InternalVar_2) * 0.5f;

            return new Ray(InternalParameter_3304.transform.TransformPoint(InternalVar_3), InternalParameter_3304.transform.TransformDirection(InternalParameter_3303));
        }

        public static bool InternalMethod_3584(T103 InternalParameter_3306, out Vector3 InternalParameter_3307, out Ray InternalParameter_3308, int InternalParameter_3309, out T103 InternalParameter_3310)
        {
            InternalParameter_3307 = default;
            InternalParameter_3308 = default;
            InternalParameter_3310 = null;

            if (InternalParameter_3306 == null)
            {
                return false;
            }

            if (!InternalType_429.InternalProperty_200.InternalMethod_3612(InternalParameter_3306.InternalProperty_196, out InternalType_5 InternalVar_1))
            {
                return false;
            }

            Vector3 InternalVar_2 = InternalVar_1.InternalProperty_202.position;
            Vector3 InternalVar_3 = InternalParameter_3306.InternalProperty_202.InverseTransformPoint(InternalVar_2);

            InternalType_441 InternalVar_4 = new InternalType_441(InternalParameter_3306.InternalProperty_144.InternalProperty_124);

            Vector3 InternalVar_5 = InternalVar_4.InternalMethod_3621(InternalVar_3);
            Vector3 InternalVar_6 = Vector3.Normalize(InternalVar_3 - InternalVar_5);

            InternalParameter_3307 = InternalVar_6 == Vector3.zero ? Vector3.down : InternalVar_6;
            InternalParameter_3308 = new Ray(InternalParameter_3306.InternalProperty_202.TransformPoint(InternalVar_5), InternalParameter_3306.InternalProperty_202.TransformDirection(InternalParameter_3307));
            InternalParameter_3310 = InternalVar_1 as T103;

            return true;
        }

        public static InternalType_521<T103> InternalMethod_3636(T103 InternalParameter_3237, T103 InternalParameter_3236, int InternalParameter_3235)
        {
            if (InternalParameter_3237 == null)
            {
                return InternalType_521<T103>.InternalProperty_435;
            }

            InternalType_131 InternalVar_1 = InternalParameter_3236 == null ? InternalType_131.InternalField_415 : InternalParameter_3236.InternalProperty_195;
            InternalType_429.InternalProperty_200.InternalMethod_3689(InternalParameter_3237.InternalProperty_196, InternalVar_1, InternalParameter_3235, InternalField_1085);

            return InternalField_1085.InternalMethod_2043();
        }

        public static bool InternalMethod_3586(InternalType_5 InternalParameter_3314, InternalType_5 InternalParameter_3315, Vector3 InternalParameter_3316, int InternalParameter_3317, out InternalType_756 InternalParameter_3318)
        {
            InternalParameter_3318 = default;

            if (!InternalType_182.InternalMethod_3638(InternalParameter_3314, InternalParameter_3316, out int _, out int InternalVar_1))
            {
                return false;
            }

            if (InternalParameter_3315 == InternalParameter_3314)
            {
                return false;
            }

            if (!InternalMethod_3578(InternalParameter_3315 as T103, InternalParameter_3314, InternalParameter_3316, InternalParameter_3317, InternalParameter_3274: true, out InternalType_428 InternalVar_2))
            {
                return false;
            }

            InternalType_5 InternalVar_3 = InternalVar_2.InternalField_1642;
            InternalType_70 InternalVar_4 = InternalParameter_3314.InternalProperty_143;

            InternalType_5 InternalVar_5 = InternalParameter_3314.InternalMethod_3598(InternalParameter_3315);
            int InternalVar_6 = InternalParameter_3314.InternalMethod_3594(InternalVar_5);
            int InternalVar_7 = Mathf.Clamp(InternalVar_6 + InternalVar_4.InternalProperty_1148 * InternalVar_1, 0, InternalParameter_3314.InternalMethod_3596() - 1);
            InternalType_5 InternalVar_8 = InternalParameter_3314.InternalMethod_3595(InternalVar_7);

            if (InternalVar_3.InternalMethod_3597(InternalVar_8))
            {
            }
            else if (InternalVar_3.InternalMethod_3597(InternalVar_5))
            {
                InternalVar_8 = InternalVar_5;
            }
            else if (InternalMethod_3578(InternalParameter_3315 as T103, InternalVar_8, InternalParameter_3316, InternalParameter_3317, InternalParameter_3274: false, out InternalVar_2))
            {
                InternalVar_3 = InternalVar_2.InternalField_1642;
            }
            else
            {
                InternalVar_8 = InternalParameter_3314.InternalMethod_3598(InternalVar_3);
            }

            InternalParameter_3318 = new InternalType_756()
            {
                InternalField_3547 = InternalVar_3,
                InternalField_3548 = InternalVar_5,
                InternalField_3549 = InternalVar_8
            };

            return true;
        }
    }
}
