
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Nova.InternalNamespace_0
{
    internal interface InternalType_84
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        InternalType_5 InternalProperty_169 { get; set; }
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        Vector3 InternalProperty_170 { get; set; }
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        Vector3 InternalProperty_171 { get; set; }
    }

    internal class InternalType_87<T5> where T5 : struct, System.IEquatable<T5>, InternalType_84
    {
        private struct InternalType_88
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_152<InternalType_94> InternalField_288;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_289;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public Ray InternalField_290;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_77 InternalField_291;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_88[] InternalField_286 = new InternalType_88[InternalType_89.InternalField_2940];
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private List<InternalType_5>[] InternalField_287 = new List<InternalType_5>[InternalType_89.InternalField_2940];

        public InternalType_87()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalType_89.InternalField_2940; ++InternalVar_1)
            {
                InternalField_287[InternalVar_1] = new List<InternalType_5>();
            }
        }

        public void InternalMethod_2057<T>(InternalType_78 InternalParameter_2698, InternalType_76<T> InternalParameter_2697, InternalType_521<T5> InternalParameter_2696) where T : unmanaged, System.IEquatable<T>
        {
            InternalMethod_496(InternalParameter_2698.InternalField_257);

            List<InternalType_5> InternalVar_1 = InternalField_287[InternalParameter_2698.InternalField_257];

            for (int InternalVar_2 = 0; InternalVar_2 < InternalParameter_2696.InternalProperty_433; ++InternalVar_2)
            {
                InternalVar_1.Add(InternalParameter_2696[InternalVar_2].InternalProperty_169);
            }

            InternalField_286[InternalParameter_2698.InternalField_257] = new InternalType_88()
            {
                InternalField_288 = InternalType_169<InternalType_94>.InternalType_171<InternalType_76<T>>.InternalMethod_823(InternalParameter_2697),
                InternalField_289 = 0,
                InternalField_290 = InternalParameter_2698.InternalField_258,
                InternalField_291 = InternalVar_1.Count == 0 ? InternalType_77.InternalField_251 : InternalType_77.InternalField_252
            };

        }

        public void InternalMethod_496(uint InternalParameter_360)
        {
            InternalType_152<InternalType_94> InternalVar_1 = InternalField_286[InternalParameter_360].InternalField_288;

            if (InternalVar_1.InternalProperty_220)
            {
                InternalType_169<InternalType_94>.InternalMethod_821(InternalVar_1);
            }

            InternalField_286[InternalParameter_360] = default;

            List<InternalType_5> InternalVar_2 = InternalField_287[InternalParameter_360];
            InternalVar_2.Clear();

        }

        public InternalType_77 InternalMethod_497(uint InternalParameter_361) => InternalField_286[InternalParameter_361].InternalField_291;

        public InternalType_77 InternalMethod_498<T>(uint InternalParameter_362, InternalType_76<T> InternalParameter_363, out InternalType_5 InternalParameter_364) where T : unmanaged, System.IEquatable<T>
        {
            List<InternalType_5> InternalVar_1 = InternalField_287[InternalParameter_362];
            InternalType_88 InternalVar_2 = InternalField_286[InternalParameter_362];

            InternalParameter_364 = null;

            if (InternalVar_1.Count == 0 || !InternalVar_2.InternalField_291.InternalMethod_490())
            {

                return InternalType_77.InternalField_251;
            }

            if (InternalVar_1.Count == 1 && InternalVar_2.InternalField_291.InternalMethod_492())
            {
                InternalParameter_364 = InternalVar_1[0];
                return InternalVar_2.InternalField_291;
            }

            InternalType_76<T> InternalVar_3 = InternalType_169<InternalType_94>.InternalType_171<InternalType_76<T>>.InternalMethod_825(InternalVar_2.InternalField_288);

            InternalType_77 InternalVar_4 = InternalType_77.InternalField_251;

            Transform InternalVar_5 = InternalVar_1.Count > 0 ? InternalVar_1[0].InternalProperty_202 : null;

            for (int InternalVar_6 = InternalVar_1.Count - 1; InternalVar_6 >= 0; --InternalVar_6)
            {
                InternalType_5 InternalVar_7 = InternalVar_1[InternalVar_6];

                if (InternalVar_7 == null)
                {
                    InternalVar_1.RemoveAt(InternalVar_6);
                    continue;
                }

                InternalType_75 InternalVar_8 = InternalVar_7.InternalProperty_34.InternalProperty_1149;

                bool InternalVar_9 = false;
                InternalType_77 InternalVar_10 = InternalType_77.InternalField_251;

                if (InternalVar_8 != null)
                {
                    InternalType_77 InternalVar_11 = InternalVar_8.InternalMethod_3340(InternalVar_2.InternalField_290, InternalVar_3, InternalParameter_363, InternalVar_5);

                    if (InternalVar_11.InternalMethod_490())
                    {
                        InternalVar_9 = true;

                        InternalVar_4 = InternalMethod_499(InternalVar_4, InternalVar_11);
                        InternalVar_10 = InternalMethod_499(InternalVar_10, InternalVar_11);
                    }
                }

                if (!InternalVar_9 || InternalVar_10 != InternalMethod_499(InternalVar_10, InternalVar_4))
                {

                    InternalVar_1.RemoveAt(InternalVar_6);
                }
            }

            InternalVar_2.InternalField_291 = InternalVar_4;
            InternalVar_2.InternalField_289++;

            if (InternalVar_2.InternalField_291.InternalMethod_492())
            {
                InternalVar_1.RemoveRange(1, InternalVar_1.Count - 1);
            }


            InternalField_286[InternalParameter_362] = InternalVar_2;

            InternalParameter_364 = InternalVar_1.Count == 1 && InternalVar_2.InternalField_291.InternalMethod_491() ? InternalVar_1[0] : null;
            return InternalParameter_364 != null ? InternalVar_2.InternalField_291 : InternalType_77.InternalField_251;
        }

        private static InternalType_77 InternalMethod_499(InternalType_77 InternalParameter_365, InternalType_77 InternalParameter_366)
        {
            return InternalParameter_365.InternalMethod_493() > InternalParameter_366.InternalMethod_493() ? InternalParameter_365 : InternalParameter_366;
        }
    }

    internal class InternalType_89
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const int InternalField_2940 = 31;
    }

    internal enum InternalType_85
    {
        InternalField_1162,
        InternalField_284,
        InternalField_285
    }

    internal class InternalType_90<T6> where T6 : struct, System.IEquatable<T6>, InternalType_84
    {
        public class InternalType_91 : InternalNamespace_0.InternalType_89
        {
            private struct InternalType_92
            {
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private T6? InternalField_2255;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private T6 InternalField_2254;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public T6 InternalProperty_738
                {
                    get
                    {
                        T6 InternalVar_1 = InternalField_2254;

                        if (InternalField_2255.HasValue)
                        {
                            T6 InternalVar_2 = InternalField_2255.Value;
                            InternalType_5 InternalVar_3 = InternalVar_2.InternalProperty_169;
                            Transform InternalVar_4 = (InternalVar_3 as MonoBehaviour) != null ? InternalVar_3.InternalProperty_202 : null;

                            if (InternalVar_4 != null)
                            {
                                InternalVar_1.InternalProperty_171 = InternalVar_4.TransformDirection(InternalVar_2.InternalProperty_171);
                                InternalVar_1.InternalProperty_170 = InternalVar_4.TransformPoint(InternalVar_2.InternalProperty_170);
                            }
                        }

                        return InternalVar_1;
                    }
                    set
                    {
                        InternalField_2254 = value;

                        InternalType_5 InternalVar_1 = InternalField_2254.InternalProperty_169;
                        Transform InternalVar_2 = (InternalVar_1 as MonoBehaviour) != null ? InternalVar_1.InternalProperty_202 : null;

                        if (InternalVar_2 == null)
                        {
                            InternalField_2255 = null;
                            return;
                        }

                        T6 InternalVar_3 = InternalField_2254;

                        InternalVar_3.InternalProperty_171 = InternalVar_2.InverseTransformDirection(InternalField_2254.InternalProperty_171);
                        InternalVar_3.InternalProperty_170 = InternalVar_2.InverseTransformPoint(InternalField_2254.InternalProperty_170);

                        InternalField_2255 = InternalVar_3;
                    }
                }

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public bool InternalField_300;
            }

            private struct InternalType_93
            {
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_152<InternalType_94> InternalField_301;
                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public Vector3 InternalField_302;

                [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public static InternalType_93 InternalProperty_172 => new InternalType_93() { InternalField_301 = InternalType_152<InternalType_94>.InternalField_441, InternalField_302 = InternalType_187.InternalField_550 };
            }

            [System.NonSerialized]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private static BitField32 InternalField_293 = new BitField32(0);

            [System.NonSerialized]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private static BitField32 InternalField_294 = new BitField32(0);

            [System.NonSerialized]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private static InternalType_92[] InternalField_295 = null;
            [System.NonSerialized]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private static InternalType_93[] InternalField_297 = null;
            [System.NonSerialized]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private static InternalType_87<T6> InternalField_298 = null;

            public void InternalMethod_2056<T>(InternalType_78 InternalParameter_2695, T InternalParameter_2694, InternalType_521<T6> InternalParameter_2693, InternalType_85 InternalParameter_2692, bool InternalParameter_2376) where T : unmanaged, System.IEquatable<T>
            {
                uint InternalVar_1 = InternalParameter_2695.InternalField_257;
                int InternalVar_2 = (int)InternalVar_1;

                T6 InternalVar_3 = InternalParameter_2693.InternalProperty_433 > 0 ? InternalParameter_2693[0] : default(T6);

                InternalType_92 InternalVar_4 = InternalField_295[InternalVar_2];
                T6 InternalVar_5 = InternalVar_4.InternalProperty_738;
                InternalType_5 InternalVar_6 = InternalVar_5.InternalProperty_169;
                bool InternalVar_7 = InternalVar_6 != null;

                InternalType_93 InternalVar_8 = InternalField_297[InternalVar_2];
                bool InternalVar_9 = InternalVar_4.InternalField_300 && InternalParameter_2692 != InternalType_85.InternalField_284;

                InternalType_169<InternalType_94>.InternalMethod_821(InternalVar_8.InternalField_301);

                bool InternalVar_10 = !InternalParameter_2694.Equals(default(T));

                if (InternalField_294.IsSet(InternalVar_2))
                {
                    if (InternalVar_10 && InternalParameter_2692 != InternalType_85.InternalField_284)
                    {
                        return;
                    }

                    InternalField_294.SetBits(InternalVar_2, false);
                }

                if (InternalVar_9 != InternalVar_10)
                {
                    InternalField_298.InternalMethod_496(InternalVar_1);
                }

                if (InternalVar_10 && InternalVar_7)
                {
                    InternalVar_3.InternalProperty_171 = InternalVar_4.InternalProperty_738.InternalProperty_171;
                }

                InternalType_77 InternalVar_11 = InternalField_298.InternalMethod_497(InternalVar_1);

                InternalType_76<T>? InternalVar_12 = InternalVar_7 ? InternalVar_6.InternalProperty_34.InternalMethod_464<T>(InternalVar_1) : null;

                if (InternalParameter_2692 != InternalType_85.InternalField_1162 && InternalVar_10)
                {
                    InternalType_76<T> InternalVar_13 = new InternalType_76<T>() { InternalField_246 = true, InternalField_247 = InternalParameter_2694, InternalField_248 = InternalVar_3.InternalProperty_170, InternalField_250 = InternalParameter_2376 };

                    if (!InternalVar_9)
                    {
                        InternalField_298.InternalMethod_2057(InternalParameter_2695, InternalVar_13, InternalParameter_2693);
                    }

                    InternalType_77 InternalVar_15 = InternalField_298.InternalMethod_498(InternalVar_1, InternalVar_13, out InternalType_5 InternalVar_14);

                    if (InternalVar_15.InternalMethod_491())
                    {
                        if (InternalVar_11.InternalMethod_490() && InternalVar_7 && InternalVar_14 != InternalVar_6)
                        {
                            InternalVar_6.InternalProperty_34.InternalMethod_467(InternalParameter_2695);

                            InternalVar_6 = InternalVar_14;

                            InternalVar_7 = true;

                            InternalVar_14.InternalProperty_34.InternalMethod_466<T>(InternalParameter_2695, new InternalType_76<T>() { InternalField_246 = true, InternalField_247 = InternalParameter_2694, InternalField_248 = InternalVar_5.InternalProperty_170, InternalField_249 = InternalVar_11, InternalField_250 = InternalParameter_2376 });
                        }
                        
                        InternalVar_11 = InternalVar_15;

                        InternalVar_3.InternalProperty_169 = InternalVar_14;
                    }
                }

                bool InternalVar_16 = true;


                bool InternalVar_17 = false;

                if (InternalVar_7 && InternalVar_6 != InternalVar_3.InternalProperty_169 && InternalVar_12.HasValue)
                {
                    for (int InternalVar_18 = 0; InternalVar_18 < InternalParameter_2693.InternalProperty_433; ++InternalVar_18)
                    {
                        if (InternalParameter_2693[InternalVar_18].InternalProperty_169 == InternalVar_6)
                        {
                            InternalVar_17 = true;
                            break;
                        }
                    }

                    if (InternalVar_9)
                    {
                        InternalVar_3.InternalProperty_169 = InternalVar_6;
                        InternalVar_16 = InternalVar_17;
                    }
                    else if (!InternalVar_17 || !InternalVar_10)
                    {
                        InternalVar_6.InternalProperty_34.InternalMethod_466<T>(InternalParameter_2695, new InternalType_76<T>() { InternalField_246 = false, InternalField_247 = default, InternalField_248 = InternalVar_3.InternalProperty_170, InternalField_250 = InternalParameter_2376 });
                    }
                    else if (InternalVar_10 && InternalVar_3.InternalProperty_169 != null)
                    {
                        InternalVar_6.InternalProperty_34.InternalMethod_467(InternalParameter_2695);
                    }
                }

                bool InternalVar_19 = InternalVar_3.InternalProperty_169 != null;

                if (InternalVar_19)
                {
                    Vector3 InternalVar_20 = InternalVar_3.InternalProperty_170;

                    if (InternalField_293.Value == 0)
                    {
                        InternalVar_3.InternalProperty_169.InternalProperty_34.InternalMethod_466<T>(InternalParameter_2695, new InternalType_76<T>() { InternalField_246 = true, InternalField_247 = default, InternalField_248 = InternalVar_20, InternalField_250 = InternalParameter_2376 });
                    }

                    InternalVar_3.InternalProperty_169.InternalProperty_34.InternalMethod_466<T>(InternalParameter_2695, new InternalType_76<T>() { InternalField_246 = InternalVar_16, InternalField_247 = InternalParameter_2694, InternalField_248 = InternalVar_20, InternalField_249 = InternalVar_11, InternalField_250 = InternalParameter_2376 });

                    if (!InternalVar_3.InternalProperty_169.InternalProperty_34.InternalMethod_464<T>(InternalParameter_2695.InternalField_257).HasValue)
                    {
                        InternalVar_19 = false;
                        InternalVar_3.InternalProperty_169 = null;
                        InternalField_298.InternalMethod_496(InternalParameter_2695.InternalField_257);
                        InternalField_294.SetBits(InternalVar_2, InternalVar_10);
                    }
                }
                else if (InternalVar_10)
                {
                    InternalField_294.SetBits(InternalVar_2, true);
                }

                InternalField_293.SetBits(InternalVar_2, InternalVar_19);

                InternalField_295[InternalVar_1] = new InternalType_92() { InternalProperty_738 = InternalVar_3, InternalField_300 = InternalVar_10 };

                InternalField_297[InternalVar_2] = new InternalType_93()
                {
                    InternalField_301 = InternalType_169<InternalType_94>.InternalType_171<T>.InternalMethod_823(InternalParameter_2694),
                    InternalField_302 = InternalVar_3.InternalProperty_170,
                };
            }

            public void InternalMethod_501(InternalType_78 InternalParameter_372)
            {
                if (InternalField_295[InternalParameter_372.InternalField_257].InternalProperty_738.InternalProperty_169 != null)
                {
                    InternalType_5 InternalVar_1 = InternalField_295[InternalParameter_372.InternalField_257].InternalProperty_738.InternalProperty_169;
                    InternalVar_1.InternalProperty_34.InternalMethod_467(InternalParameter_372);

                    InternalField_295[InternalParameter_372.InternalField_257] = default;
                }

                int InternalVar_2 = (int)InternalParameter_372.InternalField_257;

                InternalField_293.SetBits(InternalVar_2, false);
                InternalField_294.SetBits(InternalVar_2, false);

                InternalType_169<InternalType_94>.InternalMethod_821(InternalField_297[InternalParameter_372.InternalField_257].InternalField_301);
                InternalField_297[InternalParameter_372.InternalField_257] = InternalType_93.InternalProperty_172;

                InternalField_298.InternalMethod_496(InternalParameter_372.InternalField_257);
            }

            public bool InternalMethod_502<T>(uint InternalParameter_373, out T6 InternalParameter_374) where T : unmanaged, System.IEquatable<T>
            {
                T6 InternalVar_1 = InternalField_295[InternalParameter_373].InternalProperty_738;

                if (InternalVar_1.InternalProperty_169 != null)
                {
                    InternalParameter_374 = InternalVar_1;
                    InternalType_76<T>? InternalVar_2 = InternalVar_1.InternalProperty_169.InternalProperty_34.InternalMethod_464<T>(InternalParameter_373);

                    return InternalVar_2.HasValue && !InternalVar_2.Value.InternalField_247.Equals(default);
                }

                InternalParameter_374 = default;
                return false;
            }

            public bool InternalMethod_503<T>(uint InternalParameter_375, out T6 InternalParameter_376) where T : unmanaged, System.IEquatable<T>
            {
                T6 InternalVar_1 = InternalField_295[InternalParameter_375].InternalProperty_738;

                if (InternalVar_1.InternalProperty_169 != null && InternalVar_1.InternalProperty_169.InternalProperty_152)
                {
                    InternalParameter_376 = InternalVar_1;
                    InternalType_76<T>? InternalVar_2 = InternalVar_1.InternalProperty_169.InternalProperty_34.InternalMethod_464<T>(InternalParameter_375);

                    return InternalVar_2.HasValue;
                }

                InternalParameter_376 = default;
                return false;
            }

            public Color InternalMethod_504(uint InternalParameter_377)
            {
                InternalType_92 InternalVar_1 = InternalField_295[InternalParameter_377];

                return InternalVar_1.InternalField_300 ? InternalField_298.InternalMethod_497(InternalParameter_377).InternalMethod_492() ? Color.green : Color.cyan : Color.blue;
            }

            public void InternalMethod_505()
            {
                InternalField_293.Clear();
                InternalField_294.Clear();
                InternalField_297 = new InternalType_93[InternalField_2940];
                InternalField_295 = new InternalType_92[InternalField_2940];
                InternalField_298 = new InternalType_87<T6>();
            }
        }
    }

    internal struct InternalType_94 { }

    internal struct InternalType_76<T4> : System.IEquatable<InternalType_76<T4>> where T4 : unmanaged, System.IEquatable<T4>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_246; 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public T4 InternalField_247; 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Vector3 InternalField_248; 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_77 InternalField_249; 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_250; 

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_166 => InternalField_249.InternalMethod_492();

        public bool Equals(InternalType_76<T4> other)
        {
            return this == other;
        }

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case InternalType_76<T4> input:
                    return this.Equals(input);
                default:
                    return false;
            }
        }

        public static bool operator ==(in InternalType_76<T4> InternalParameter_331, in InternalType_76<T4> InternalParameter_332)
        {
            return InternalParameter_331.InternalField_247.Equals(InternalParameter_332.InternalField_247) &&
                   InternalParameter_331.InternalField_246 == InternalParameter_332.InternalField_246 &&
                   InternalType_187.InternalMethod_891(InternalParameter_331.InternalField_248, InternalParameter_332.InternalField_248);
        }

        public static bool operator !=(in InternalType_76<T4> InternalParameter_333, in InternalType_76<T4> InternalParameter_334)
        {
            return !(InternalParameter_333 == InternalParameter_334);
        }

        public override int GetHashCode()
        {
            int InternalVar_1 = 13;
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_246.GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_247.GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_248.GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_249.GetHashCode();
            InternalVar_1 = (InternalVar_1 * 7) + InternalField_250.GetHashCode();
            return InternalVar_1;
        }

        public override string ToString()
        {
            return $"Hit:{InternalField_246}, Value: {InternalField_247}, {InternalField_248}";
        }

        public unsafe bool InternalMethod_474<U>(out InternalType_76<U>? InternalParameter_335) where U : unmanaged, System.IEquatable<U>
        {
            if (typeof(U) != typeof(T4))
            {
                InternalParameter_335 = null;
                return false;
            }

            InternalParameter_335 = UnsafeUtility.As<InternalType_76<T4>, InternalType_76<U>>(ref this);
            return true;
        }
    }

    internal readonly struct InternalType_78
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const uint InternalField_256 = uint.MaxValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly uint InternalField_257;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly Ray InternalField_258;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly object InternalField_259;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_167 => InternalField_257 != InternalField_256;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_78 InternalField_260 = new InternalType_78(InternalField_256);

        public InternalType_78(Ray InternalParameter_336, uint InternalParameter_337 = 0, object InternalParameter_338 = null)
        {
            InternalField_258 = InternalParameter_336;
            InternalField_257 = InternalParameter_337;
            InternalField_259 = InternalParameter_338;
        }

        public InternalType_78(uint InternalParameter_339)
        {
            InternalField_257 = InternalParameter_339;
            InternalField_258 = new Ray(InternalType_187.InternalField_535, InternalType_187.InternalField_535);
            InternalField_259 = null;
        }
    }

    
    internal readonly struct InternalType_755<T102> : System.IEquatable<InternalType_755<T102>> where T102 : struct, System.IEquatable<T102>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly T102 InternalField_3546;

        public bool Equals(InternalType_755<T102> other) => InternalField_3546.Equals(default) && other.InternalField_3546.Equals(default) ? true : false;

        public InternalType_755(ref T102 InternalParameter_3240)
        {
            InternalField_3546 = InternalParameter_3240;
        }
    }
}
