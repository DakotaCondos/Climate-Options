using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0
{
    internal enum InternalType_59
    {
        InternalField_201,
        InternalField_202
    };

    internal interface InternalType_51<T88> : InternalType_52
    {
        bool InternalMethod_377(ref T88 InternalParameter_274);
    }

    internal interface InternalType_52 { }

    [StructLayoutAttribute(LayoutKind.Explicit, Size = InternalField_181)]
#pragma warning disable CS0660, CS0661 
    internal struct InternalType_56 : InternalType_51<InternalType_56>
#pragma warning restore CS0660, CS0661 
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal const int InternalField_181 = 2 * InternalType_53.InternalField_166;

        [FieldOffset(0 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_182;
        [FieldOffset(1 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_183;
        [FieldOffset(2 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_184;
        [FieldOffset(3 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_185;
        [FieldOffset(4 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_186;
        [FieldOffset(5 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_187;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool3 InternalProperty_126 => InternalProperty_127 | InternalProperty_128;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool3 InternalProperty_127 => new bool3(InternalField_182.InternalProperty_102, InternalField_184.InternalProperty_102, InternalField_186.InternalProperty_102);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool3 InternalProperty_128 => new bool3(InternalField_183.InternalProperty_102, InternalField_185.InternalProperty_102, InternalField_187.InternalProperty_102);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly float3x2 InternalProperty_129 => new float3x2(new float3(InternalField_182.InternalProperty_103, InternalField_184.InternalProperty_103, InternalField_186.InternalProperty_103),
                                                       new float3(InternalField_183.InternalProperty_103, InternalField_185.InternalProperty_103, InternalField_187.InternalProperty_103));

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly float3x2 InternalProperty_130 => new float3x2(new float3(InternalField_182.InternalProperty_104, InternalField_184.InternalProperty_104, InternalField_186.InternalProperty_104),
                                                         new float3(InternalField_183.InternalProperty_104, InternalField_185.InternalProperty_104, InternalField_187.InternalProperty_104));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_56 InternalParameter_295, InternalType_56 InternalParameter_296)
        {
            return !InternalParameter_295.InternalMethod_422(ref InternalParameter_296);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_56 InternalParameter_297, InternalType_56 InternalParameter_298)
        {
            return InternalParameter_297.InternalMethod_422(ref InternalParameter_298);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_377(ref InternalType_56 InternalParameter_274)
        {
            return !this.InternalMethod_423(ref InternalParameter_274, InternalField_181);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_58 InternalMethod_410(in InternalType_56 InternalParameter_299, in InternalType_57 InternalParameter_300, in float3 InternalParameter_301)
        {
            return new InternalType_58()
            {
                InternalField_195 = new InternalType_45.InternalType_47(InternalParameter_299.InternalField_182, InternalParameter_300.InternalField_189, InternalParameter_301.x),
                InternalField_196 = new InternalType_45.InternalType_47(InternalParameter_299.InternalField_183, InternalParameter_300.InternalField_190, InternalParameter_301.x),
                InternalField_197 = new InternalType_45.InternalType_47(InternalParameter_299.InternalField_184, InternalParameter_300.InternalField_191, InternalParameter_301.y),
                InternalField_198 = new InternalType_45.InternalType_47(InternalParameter_299.InternalField_185, InternalParameter_300.InternalField_192, InternalParameter_301.y),
                InternalField_199 = new InternalType_45.InternalType_47(InternalParameter_299.InternalField_186, InternalParameter_300.InternalField_193, InternalParameter_301.z),
                InternalField_200 = new InternalType_45.InternalType_47(InternalParameter_299.InternalField_187, InternalParameter_300.InternalField_194, InternalParameter_301.z),
            };
        }

        [StructLayoutAttribute(LayoutKind.Explicit, Size = InternalField_188)]
#pragma warning disable CS0660, CS0661 
        public struct InternalType_57 : InternalType_51<InternalType_57>
#pragma warning restore CS0660, CS0661 
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public const int InternalField_188 = 2 * InternalType_53.InternalType_54.InternalField_171;

            [FieldOffset(0 * InternalType_45.InternalField_144)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_46 InternalField_189;
            [FieldOffset(1 * InternalType_45.InternalField_144)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_46 InternalField_190;
            [FieldOffset(2 * InternalType_45.InternalField_144)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_46 InternalField_191;
            [FieldOffset(3 * InternalType_45.InternalField_144)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_46 InternalField_192;
            [FieldOffset(4 * InternalType_45.InternalField_144)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_46 InternalField_193;
            [FieldOffset(5 * InternalType_45.InternalField_144)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_46 InternalField_194;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float3 InternalProperty_131 => new float3(InternalField_189.InternalField_148 + InternalField_190.InternalField_148, InternalField_191.InternalField_148 + InternalField_192.InternalField_148, InternalField_193.InternalField_148 + InternalField_194.InternalField_148);
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float3 InternalProperty_132 => new float3(InternalField_189.InternalField_149 + InternalField_190.InternalField_149, InternalField_191.InternalField_149 + InternalField_192.InternalField_149, InternalField_193.InternalField_149 + InternalField_194.InternalField_149);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InternalType_57 InternalParameter_302, InternalType_57 InternalParameter_303)
            {
                return !InternalParameter_302.InternalMethod_422(ref InternalParameter_303);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InternalType_57 InternalParameter_304, InternalType_57 InternalParameter_305)
            {
                return InternalParameter_304.InternalMethod_422(ref InternalParameter_305);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool InternalMethod_377(ref InternalType_57 InternalParameter_274)
            {
                return !this.InternalMethod_423(ref InternalParameter_274, InternalField_188);
            }
        }

        [StructLayoutAttribute(LayoutKind.Explicit, Size = 6 * InternalType_45.InternalType_47.InternalField_152)]
        public struct InternalType_58
        {
            [FieldOffset(0 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47 InternalField_195;
            [FieldOffset(1 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47 InternalField_196;
            [FieldOffset(2 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47 InternalField_197;
            [FieldOffset(3 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47 InternalField_198;
            [FieldOffset(4 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47 InternalField_199;
            [FieldOffset(5 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47 InternalField_200;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float3x2 InternalProperty_133 => new float3x2(new float3(InternalField_195.InternalField_153, InternalField_197.InternalField_153, InternalField_199.InternalField_153),
                                                           new float3(InternalField_196.InternalField_153, InternalField_198.InternalField_153, InternalField_200.InternalField_153));

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float3x2 InternalProperty_134 => new float3x2(new float3(InternalField_195.InternalField_154, InternalField_197.InternalField_154, InternalField_199.InternalField_154),
                                                             new float3(InternalField_196.InternalField_154, InternalField_198.InternalField_154, InternalField_200.InternalField_154));

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float3 InternalProperty_135 => new float3(InternalField_195.InternalField_153, InternalField_197.InternalField_153, InternalField_199.InternalField_153);
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float3 InternalProperty_136 => new float3(InternalField_196.InternalField_153, InternalField_198.InternalField_153, InternalField_200.InternalField_153);

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float3 InternalProperty_137
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    float3x2 InternalVar_1 = InternalProperty_133;
                    return InternalVar_1.c0 + InternalVar_1.c1;
                }
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float3 InternalProperty_138
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    float3x2 InternalVar_1 = InternalProperty_134;
                    return InternalVar_1.c0 + InternalVar_1.c1;
                }
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float3 InternalProperty_139
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    float3x2 InternalVar_1 = InternalProperty_133;
                    return 0.5f * (InternalVar_1.c0 - InternalVar_1.c1);
                }
            }
        }
    }

    [StructLayoutAttribute(LayoutKind.Explicit, Size = InternalField_166)]
#pragma warning disable CS0660, CS0661 
    internal struct InternalType_53 : InternalType_51<InternalType_53>
#pragma warning restore CS0660, CS0661 
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal const int InternalField_166 = 3 * InternalType_45.InternalField_144;

        [FieldOffset(0 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_167;
        [FieldOffset(1 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_168;
        [FieldOffset(2 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_169;

        [FieldOffset(0 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_48 InternalField_170;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalProperty_115
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return new float3(InternalField_167.InternalField_145, InternalField_168.InternalField_145, InternalField_169.InternalField_145);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                InternalField_167.InternalField_145 = value.x;
                InternalField_168.InternalField_145 = value.y;
                InternalField_169.InternalField_145 = value.z;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly float3 InternalProperty_116
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return new float3(InternalField_167.InternalProperty_103, InternalField_168.InternalProperty_103, InternalField_169.InternalProperty_103);
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly float3 InternalProperty_117
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return new float3(InternalField_167.InternalProperty_104, InternalField_168.InternalProperty_104, InternalField_169.InternalProperty_104);
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool3 InternalProperty_118
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return math.bool3(InternalField_167.InternalProperty_102, InternalField_168.InternalProperty_102, InternalField_169.InternalProperty_102);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                InternalField_167.InternalProperty_102 = value.x;
                InternalField_168.InternalProperty_102 = value.y;
                InternalField_169.InternalProperty_102 = value.z;
            }
        }

        public InternalType_45 this[int InternalParameter_275]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                switch (InternalParameter_275)
                {
                    case 0:
                        return InternalField_167;
                    case 1:
                        return InternalField_168;
                    case 2:
                        return InternalField_169;
                }

                return default;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                switch (InternalParameter_275)
                {
                    case 0:
                        InternalField_167 = value;
                        break;
                    case 1:
                        InternalField_168 = value;
                        break;
                    case 2:
                        InternalField_169 = value;
                        break;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator ==(InternalType_53 InternalParameter_276, InternalType_53 InternalParameter_277)
        {
            return new bool3(InternalParameter_276.InternalField_167 == InternalParameter_277.InternalField_167, InternalParameter_276.InternalField_168 == InternalParameter_277.InternalField_168, InternalParameter_276.InternalField_169 == InternalParameter_277.InternalField_169);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator !=(InternalType_53 InternalParameter_278, InternalType_53 InternalParameter_279)
        {
            return new bool3(InternalParameter_278.InternalField_167 != InternalParameter_279.InternalField_167, InternalParameter_278.InternalField_168 != InternalParameter_279.InternalField_168, InternalParameter_278.InternalField_169 != InternalParameter_279.InternalField_169);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return $"Length3({InternalField_167.ToString()}, {InternalField_168.ToString()}, {InternalField_169.ToString()})";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_377(ref InternalType_53 InternalParameter_274)
        {
            return !this.InternalMethod_423(ref InternalParameter_274, InternalField_166);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InternalMethod_388(float3 InternalParameter_280, ref InternalType_53 InternalParameter_281, ref InternalType_54 InternalParameter_282, float3 InternalParameter_283)
        {
            return new float3(InternalType_45.InternalMethod_346(InternalParameter_280.x, ref InternalParameter_281.InternalField_167, ref InternalParameter_282.InternalField_172, InternalParameter_283.x),
                              InternalType_45.InternalMethod_346(InternalParameter_280.y, ref InternalParameter_281.InternalField_168, ref InternalParameter_282.InternalField_173, InternalParameter_283.y),
                              InternalType_45.InternalMethod_346(InternalParameter_280.z, ref InternalParameter_281.InternalField_169, ref InternalParameter_282.InternalField_174, InternalParameter_283.z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_55 InternalMethod_389(InternalType_53 InternalParameter_284, InternalType_54 InternalParameter_285, float3 InternalParameter_286)
        {
            return new InternalType_55()
            {
                InternalField_177 = new InternalType_45.InternalType_47(InternalParameter_284.InternalField_167, InternalParameter_285.InternalField_172, InternalParameter_286.x),
                InternalField_178 = new InternalType_45.InternalType_47(InternalParameter_284.InternalField_168, InternalParameter_285.InternalField_173, InternalParameter_286.y),
                InternalField_179 = new InternalType_45.InternalType_47(InternalParameter_284.InternalField_169, InternalParameter_285.InternalField_174, InternalParameter_286.z),
            };
        }

        [StructLayoutAttribute(LayoutKind.Explicit, Size = InternalField_171)]
#pragma warning disable CS0660, CS0661 
        public struct InternalType_54 : InternalType_51<InternalType_54>
#pragma warning restore CS0660, CS0661 
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            internal const int InternalField_171 = 3 * InternalType_45.InternalType_46.InternalField_147;

            [FieldOffset(0 * InternalType_45.InternalType_46.InternalField_147)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_46 InternalField_172;
            [FieldOffset(1 * InternalType_45.InternalType_46.InternalField_147)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_46 InternalField_173;
            [FieldOffset(2 * InternalType_45.InternalType_46.InternalField_147)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_46 InternalField_174;

            [FieldOffset(0 * InternalType_45.InternalType_46.InternalField_147)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_48.InternalType_49 InternalField_175;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float3 InternalProperty_120
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => new float3(InternalField_172.InternalField_148, InternalField_173.InternalField_148, InternalField_174.InternalField_148);
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    InternalField_172.InternalField_148 = value.x;
                    InternalField_173.InternalField_148 = value.y;
                    InternalField_174.InternalField_148 = value.z;
                }
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float3 InternalProperty_121
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get => new float3(InternalField_172.InternalField_149, InternalField_173.InternalField_149, InternalField_174.InternalField_149);
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    InternalField_172.InternalField_149 = value.x;
                    InternalField_173.InternalField_149 = value.y;
                    InternalField_174.InternalField_149 = value.z;
                }
            }

            public InternalType_45.InternalType_46 this[int InternalParameter_287]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    switch (InternalParameter_287)
                    {
                        case 0:
                            return InternalField_172;
                        case 1:
                            return InternalField_173;
                        case 2:
                            return InternalField_174;
                    }

                    return default;
                }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    switch (InternalParameter_287)
                    {
                        case 0:
                            InternalField_172 = value;
                            break;
                        case 1:
                            InternalField_173 = value;
                            break;
                        case 2:
                            InternalField_174 = value;
                            break;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InternalType_54 InternalParameter_288, InternalType_54 InternalParameter_289)
            {
                return InternalParameter_288.InternalField_172 == InternalParameter_289.InternalField_172 && InternalParameter_288.InternalField_173 == InternalParameter_289.InternalField_173 && InternalParameter_288.InternalField_174 == InternalParameter_289.InternalField_174;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InternalType_54 InternalParameter_290, InternalType_54 InternalParameter_291)
            {
                return InternalParameter_290.InternalField_172 != InternalParameter_291.InternalField_172 || InternalParameter_290.InternalField_173 != InternalParameter_291.InternalField_173 || InternalParameter_290.InternalField_174 != InternalParameter_291.InternalField_174;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override string ToString()
            {
                return $"MinMax3([{InternalField_172.ToString()}], [{InternalField_173.ToString()}], [{InternalField_174.ToString()}])";
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public float3 InternalMethod_398(float3 InternalParameter_292)
            {
                return new float3(InternalField_172.InternalMethod_349(InternalParameter_292.x), InternalField_173.InternalMethod_349(InternalParameter_292.y), InternalField_174.InternalMethod_349(InternalParameter_292.z));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public float2 InternalMethod_399(float2 InternalParameter_293)
            {
                return new float2(InternalField_172.InternalMethod_349(InternalParameter_293.x), InternalField_173.InternalMethod_349(InternalParameter_293.y));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool InternalMethod_377(ref InternalType_54 InternalParameter_274)
            {
                return !this.InternalMethod_423(ref InternalParameter_274, InternalField_171);
            }
        }

        [StructLayoutAttribute(LayoutKind.Explicit, Size = InternalField_176)]
        public struct InternalType_55
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            internal const int InternalField_176 = 3 * InternalType_45.InternalType_47.InternalField_152;

            [FieldOffset(0 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47 InternalField_177;
            [FieldOffset(1 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47 InternalField_178;
            [FieldOffset(2 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47 InternalField_179;

            [FieldOffset(0 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_48.InternalType_50 InternalField_180;

            public readonly InternalType_45.InternalType_47 this[int InternalParameter_294]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    switch (InternalParameter_294)
                    {
                        case 0:
                            return InternalField_177;
                        case 1:
                            return InternalField_178;
                        case 2:
                            return InternalField_179;
                    }

                    return default;
                }
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float3 InternalProperty_124
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return new float3(InternalField_177.InternalField_153, InternalField_178.InternalField_153, InternalField_179.InternalField_153);
                }
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float3 InternalProperty_125
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return new float3(InternalField_177.InternalField_154, InternalField_178.InternalField_154, InternalField_179.InternalField_154);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override string ToString()
            {
                return $"Calc3([{InternalField_177.ToString()}], [{InternalField_178.ToString()}], [{InternalField_179.ToString()}])";
            }
        }
    }

    [StructLayoutAttribute(LayoutKind.Explicit, Size = InternalField_155)]
#pragma warning disable CS0660, CS0661 
    internal struct InternalType_48 : InternalType_51<InternalType_48>
#pragma warning restore CS0660, CS0661 
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal const int InternalField_155 = 2 * InternalType_45.InternalField_144;

        [FieldOffset(0 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_156;
        [FieldOffset(1 * InternalType_45.InternalField_144)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_45 InternalField_157;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float2 InternalProperty_105
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return new float2(InternalField_156.InternalField_145, InternalField_157.InternalField_145);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                InternalField_156.InternalField_145 = value.x;
                InternalField_157.InternalField_145 = value.y;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly float2 InternalProperty_106
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return new float2(InternalField_156.InternalProperty_103, InternalField_157.InternalProperty_103);
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly float2 InternalProperty_107
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return new float2(InternalField_156.InternalProperty_104, InternalField_157.InternalProperty_104);
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool2 InternalProperty_108
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return new bool2(InternalField_156.InternalProperty_102, InternalField_157.InternalProperty_102);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                InternalField_156.InternalProperty_102 = value.x;
                InternalField_157.InternalProperty_102 = value.y;

            }
        }

        public InternalType_45 this[int InternalParameter_256]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                switch (InternalParameter_256)
                {
                    case 0:
                        return InternalField_156;
                    case 1:
                        return InternalField_157;
                }

                return default;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                switch (InternalParameter_256)
                {
                    case 0:
                        InternalField_156 = value;
                        break;
                    case 1:
                        InternalField_157 = value;
                        break;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator ==(InternalType_48 InternalParameter_257, InternalType_48 InternalParameter_258)
        {
            return new bool2(InternalParameter_257.InternalField_156 == InternalParameter_258.InternalField_156, InternalParameter_257.InternalField_157 == InternalParameter_258.InternalField_157);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator !=(InternalType_48 InternalParameter_259, InternalType_48 InternalParameter_260)
        {
            return new bool2(InternalParameter_259.InternalField_156 != InternalParameter_260.InternalField_156, InternalParameter_259.InternalField_157 != InternalParameter_260.InternalField_157);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return $"Length3({InternalField_156.ToString()}, {InternalField_157.ToString()})";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_377(ref InternalType_48 InternalParameter_274)
        {
            return !this.InternalMethod_423(ref InternalParameter_274, InternalField_155);
        }

        public static float2 InternalMethod_364(float2 InternalParameter_261, ref InternalType_48 InternalParameter_262, ref InternalType_49 InternalParameter_263, float2 InternalParameter_264)
        {
            return new float2(InternalType_45.InternalMethod_346(InternalParameter_261.x, ref InternalParameter_262.InternalField_156, ref InternalParameter_263.InternalField_159, InternalParameter_264.x),
                              InternalType_45.InternalMethod_346(InternalParameter_261.y, ref InternalParameter_262.InternalField_157, ref InternalParameter_263.InternalField_160, InternalParameter_264.y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_50 InternalMethod_365(InternalType_48 InternalParameter_265, InternalType_49 InternalParameter_266, float2 InternalParameter_267)
        {
            return new InternalType_50()
            {
                InternalField_164 = new InternalType_45.InternalType_47(InternalParameter_265.InternalField_156, InternalParameter_266.InternalField_159, InternalParameter_267.x),
                InternalField_165 = new InternalType_45.InternalType_47(InternalParameter_265.InternalField_157, InternalParameter_266.InternalField_160, InternalParameter_267.y),
            };
        }

        [StructLayoutAttribute(LayoutKind.Explicit, Size = InternalField_158)]
#pragma warning disable CS0660, CS0661 
        public struct InternalType_49 : InternalType_51<InternalType_49>
#pragma warning restore CS0660, CS0661 
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            internal const int InternalField_158 = 2 * InternalType_45.InternalType_46.InternalField_147;

            [FieldOffset(0 * InternalType_45.InternalType_46.InternalField_147)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_46 InternalField_159;
            [FieldOffset(1 * InternalType_45.InternalType_46.InternalField_147)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_46 InternalField_160;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float2 InternalProperty_110
            {
                get => new float2(InternalField_159.InternalField_148, InternalField_160.InternalField_148);
                set
                {
                    InternalField_159.InternalField_148 = value.x;
                    InternalField_160.InternalField_148 = value.y;
                }
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float2 InternalProperty_111
            {
                get => new float2(InternalField_159.InternalField_149, InternalField_160.InternalField_149);
                set
                {
                    InternalField_159.InternalField_149 = value.x;
                    InternalField_160.InternalField_149 = value.y;
                }
            }

            public InternalType_45.InternalType_46 this[int InternalParameter_268]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    switch (InternalParameter_268)
                    {
                        case 0:
                            return InternalField_159;
                        case 1:
                            return InternalField_160;
                    }

                    return default;
                }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    switch (InternalParameter_268)
                    {
                        case 0:
                            InternalField_159 = value;
                            break;
                        case 1:
                            InternalField_160 = value;
                            break;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InternalType_49 InternalParameter_269, InternalType_49 InternalParameter_270)
            {
                return InternalParameter_269.InternalField_159 == InternalParameter_270.InternalField_159 && InternalParameter_269.InternalField_160 == InternalParameter_270.InternalField_160;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InternalType_49 InternalParameter_271, InternalType_49 InternalParameter_272)
            {
                return InternalParameter_271.InternalField_159 != InternalParameter_272.InternalField_159 || InternalParameter_271.InternalField_160 != InternalParameter_272.InternalField_160;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override string ToString()
            {
                return $"MinMax2([{InternalField_159.ToString()}], [{InternalField_160.ToString()}])";
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public float2 InternalMethod_374(float2 InternalParameter_273)
            {
                return new float2(InternalField_159.InternalMethod_349(InternalParameter_273.x), InternalField_160.InternalMethod_349(InternalParameter_273.y));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool InternalMethod_377(ref InternalType_49 InternalParameter_274)
            {
                return !this.InternalMethod_423(ref InternalParameter_274, InternalField_158);
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly InternalType_49 InternalField_161 = new InternalType_49() { InternalProperty_110 = float.NegativeInfinity, InternalProperty_111 = float.PositiveInfinity };
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly InternalType_49 InternalField_162 = new InternalType_49() { InternalProperty_110 = 0, InternalProperty_111 = float.PositiveInfinity };
        }

        [StructLayoutAttribute(LayoutKind.Explicit, Size = InternalField_163)]
        public struct InternalType_50
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            internal const int InternalField_163 = 2 * InternalType_45.InternalType_47.InternalField_152;

            [FieldOffset(0 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47 InternalField_164;
            [FieldOffset(1 * InternalType_45.InternalType_47.InternalField_152)]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public InternalType_45.InternalType_47 InternalField_165;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float2 InternalProperty_113 => new float2(InternalField_164.InternalField_153, InternalField_165.InternalField_153);
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float2 InternalProperty_114 => new float2(InternalField_164.InternalField_154, InternalField_165.InternalField_154);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override string ToString()
            {
                return $"Calc2([{InternalField_164.ToString()}], [{InternalField_165.ToString()}])";
            }
        }
    }

    [StructLayoutAttribute(LayoutKind.Explicit, Size = InternalField_144)]
#pragma warning disable CS0660, CS0661 
    internal struct InternalType_45
#pragma warning restore CS0660, CS0661 
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal const int InternalField_144 = 8;

        [FieldOffset(0 * sizeof(float))]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_145;
        [FieldOffset(1 * sizeof(float))]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_59 InternalField_146;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_102
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return InternalField_146 == InternalType_59.InternalField_202;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                InternalField_146 = value ? InternalType_59.InternalField_202 : InternalType_59.InternalField_201;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalProperty_103 => InternalField_146 == InternalType_59.InternalField_201 ? InternalField_145 : 0;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalProperty_104 => InternalField_146 == InternalType_59.InternalField_202 ? InternalField_145 : 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_45 InternalParameter_233, InternalType_45 InternalParameter_234)
        {
            return InternalParameter_233.InternalField_145 == InternalParameter_234.InternalField_145 && InternalParameter_233.InternalField_146 == InternalParameter_234.InternalField_146;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_45 InternalParameter_235, InternalType_45 InternalParameter_236)
        {
            return InternalParameter_235.InternalField_145 != InternalParameter_236.InternalField_145 || InternalParameter_235.InternalField_146 != InternalParameter_236.InternalField_146;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static float InternalMethod_346(float InternalParameter_237, ref InternalType_45 InternalParameter_238, ref InternalType_46 InternalParameter_239, float InternalParameter_240)
        {
            return InternalParameter_238.InternalField_146 == InternalType_59.InternalField_202 ? InternalParameter_239.InternalMethod_349(InternalParameter_237) / InternalParameter_240 : InternalParameter_239.InternalMethod_349(InternalParameter_237);
        }

        public override string ToString()
        {
            return InternalProperty_102 ? $"{(100 * InternalField_145).ToString()}%" : $"{InternalField_145.ToString()}f";
        }

        [StructLayoutAttribute(LayoutKind.Explicit, Size = InternalField_147)]
#pragma warning disable CS0660, CS0661  
        public struct InternalType_46
#pragma warning restore CS0660, CS0661  
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            internal const int InternalField_147 = 2 * sizeof(float);

            [FieldOffset(0 * sizeof(float))]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalField_148;
            [FieldOffset(1 * sizeof(float))]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float InternalField_149;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InternalType_46 InternalParameter_241, InternalType_46 InternalParameter_242)
            {
                return InternalParameter_241.InternalField_148 == InternalParameter_242.InternalField_148 && InternalParameter_241.InternalField_149 == InternalParameter_242.InternalField_149;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InternalType_46 InternalParameter_243, InternalType_46 InternalParameter_244)
            {
                return InternalParameter_243.InternalField_148 != InternalParameter_244.InternalField_148 || InternalParameter_243.InternalField_149 != InternalParameter_244.InternalField_149;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly float InternalMethod_349(float InternalParameter_245)
            {
                if (float.IsInfinity(InternalParameter_245))
                {
                    if (float.IsInfinity(InternalField_148))
                    {
                        return float.IsInfinity(InternalField_149) ? 0 : InternalField_149;
                    }

                    return InternalField_148;
                }

                return InternalField_148 > InternalParameter_245 ? InternalField_148 :
                       InternalField_149 < InternalParameter_245 ? InternalField_149 :
                       InternalParameter_245;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float InternalMethod_350(float InternalParameter_246, float InternalParameter_247, float InternalParameter_248)
            {
                return new InternalType_46() { InternalField_148 = InternalParameter_247, InternalField_149 = InternalParameter_248 }.InternalMethod_349(InternalParameter_246);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override string ToString()
            {
                return this == InternalField_150 ? "Unclamped" :
                       this == InternalField_151 ? "Positive" :
                       $"Min = {InternalField_148.ToString()}f, Max = {InternalField_149.ToString()}f";
            }

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly InternalType_46 InternalField_150 = new InternalType_46() { InternalField_148 = float.NegativeInfinity, InternalField_149 = float.PositiveInfinity };
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly InternalType_46 InternalField_151 = new InternalType_46() { InternalField_148 = 0, InternalField_149 = float.PositiveInfinity };
        }

        [StructLayoutAttribute(LayoutKind.Explicit, Size = InternalField_152)]
#pragma warning disable CS0660, CS0661 
        public readonly struct InternalType_47
#pragma warning restore CS0660, CS0661 
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            internal const int InternalField_152 = 2 * sizeof(float);

            [FieldOffset(0 * sizeof(float))]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float InternalField_153;
            [FieldOffset(1 * sizeof(float))]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public readonly float InternalField_154;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InternalType_47 InternalParameter_249, InternalType_47 InternalParameter_250)
            {
                return InternalParameter_249.InternalField_153 == InternalParameter_250.InternalField_153 && InternalParameter_249.InternalField_154 == InternalParameter_250.InternalField_154;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InternalType_47 InternalParameter_251, InternalType_47 InternalParameter_252)
            {
                return InternalParameter_251.InternalField_153 != InternalParameter_252.InternalField_153 || InternalParameter_251.InternalField_154 != InternalParameter_252.InternalField_154;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override string ToString()
            {
                return $"Value = {InternalField_153.ToString()}f, {(100 * InternalField_154).ToString()}%";
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_47(in InternalType_45 InternalParameter_253, in InternalType_46 InternalParameter_254, float InternalParameter_255)
            {
                bool InternalVar_1 = InternalParameter_255 == 0;

                float InternalVar_2 = InternalParameter_253.InternalProperty_102 ? InternalVar_1 || InternalParameter_253.InternalField_145 == 0 ? 0 : InternalParameter_253.InternalField_145.InternalMethod_981(InternalParameter_255) : InternalParameter_253.InternalField_145;

                InternalField_153 = InternalParameter_254.InternalMethod_349(InternalVar_2);
                InternalField_154 = InternalVar_1 || InternalField_153 == 0 ? 0 : InternalField_153 / InternalParameter_255;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_47(float InternalParameter_1991, float InternalParameter_1990)
            {
                InternalField_153 = InternalParameter_1991;
                InternalField_154 = InternalParameter_1990;
            }
        }
    }

    [BurstCompile]
    internal static class InternalType_60
    {
        [BurstCompile]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_422<T>(ref this T InternalParameter_306, ref T InternalParameter_307) where T : unmanaged, InternalType_52
        {
            unsafe
            {
                T* InternalVar_1 = (T*)UnsafeUtility.AddressOf(ref InternalParameter_306);
                T* InternalVar_2 = (T*)UnsafeUtility.AddressOf(ref InternalParameter_307);
                return UnsafeUtility.MemCmp(InternalVar_1, InternalVar_2, UnsafeUtility.SizeOf<T>()) != 0;
            }
        }

        [BurstCompile]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_423<T>(ref this T InternalParameter_308, ref T InternalParameter_309, long InternalParameter_310) where T : unmanaged, InternalType_52
        {
            unsafe
            {
                T* InternalVar_1 = (T*)UnsafeUtility.AddressOf(ref InternalParameter_308);
                T* InternalVar_2 = (T*)UnsafeUtility.AddressOf(ref InternalParameter_309);
                return UnsafeUtility.MemCmp(InternalVar_1, InternalVar_2, InternalParameter_310) != 0;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe bool InternalMethod_424<T>(T* InternalParameter_311, T* InternalParameter_312, long InternalParameter_313) where T : unmanaged, InternalType_52
        {
            return UnsafeUtility.MemCmp(InternalParameter_311, InternalParameter_312, InternalParameter_313) != 0;
        }
    }
}
