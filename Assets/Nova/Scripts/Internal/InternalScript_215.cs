using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
#pragma warning disable CS0660 
#pragma warning disable CS0661 

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    
    internal struct InternalType_293
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_950;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public float3 InternalField_951;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float InternalField_952;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1316(ref float3 InternalParameter_1393, ref float3 InternalParameter_1394, out float3 InternalParameter_1395)
        {
            float InternalVar_1 = math.dot(InternalParameter_1394, InternalField_950);
            if (InternalType_187.InternalMethod_914(InternalVar_1))
            {
                InternalParameter_1395 = float3.zero;
                return false;
            }

            float InternalVar_2 = math.dot(InternalField_951 - InternalParameter_1393, InternalField_950);
            float InternalVar_3 = InternalVar_2 / InternalVar_1;
            if (InternalVar_3 < 0)
            {
                InternalParameter_1395 = float3.zero;
                return false;
            }
            InternalParameter_1395 = InternalParameter_1393 + InternalVar_3 * InternalParameter_1394;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_293 InternalParameter_1396, InternalType_293 InternalParameter_1397) => !(InternalParameter_1396 == InternalParameter_1397);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_293 InternalParameter_1398, InternalType_293 InternalParameter_1399)
        {
            if (!InternalType_187.InternalMethod_943(ref InternalParameter_1398.InternalField_950, ref InternalParameter_1399.InternalField_950))
            {
                return false;
            }

            return InternalType_187.InternalMethod_922(InternalParameter_1398.InternalField_952, InternalParameter_1399.InternalField_952);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_293 InternalMethod_1319(ref float4x4 InternalParameter_1400)
        {
            float3 InternalVar_1 = math.normalize(math.rotate(InternalParameter_1400, InternalType_187.InternalField_506));
            float3 InternalVar_2 = math.transform(InternalParameter_1400, float3.zero);
            float InternalVar_3 = math.dot(InternalVar_2, InternalVar_1);
            return new InternalType_293()
            {
                InternalField_950 = InternalVar_1,
                InternalField_951 = InternalVar_2,
                InternalField_952 = InternalVar_3
            };
        }
    }

    internal enum InternalType_267 : byte
    {
        InternalField_940 = 1,
        InternalField_939 = 2,
        
        InternalField_938 = 4,
    }

    internal struct InternalType_290
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_267 InternalField_944;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_267 InternalField_943;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_267 InternalField_942;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_267 InternalField_941;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_267 InternalProperty_771
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_944 | InternalField_943 | InternalField_942 | InternalField_941;
        }

        public unsafe InternalType_267 this[int InternalParameter_1368]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (InternalType_290* array = &this) { return ((InternalType_267*)array)[InternalParameter_1368]; }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                fixed (InternalType_290* array = &this) { ((InternalType_267*)array)[InternalParameter_1368] = value; }
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_301
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (InternalProperty_771 & InternalType_267.InternalField_939) != 0;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_300
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (InternalField_944 & InternalField_943 & InternalField_942 & InternalField_941) == InternalType_267.InternalField_939;
            }
        }
    }

    
    internal struct InternalType_292
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3x4 InternalField_947;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_293 InternalField_948;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float3x4 InternalField_949;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_292(ref float4x4 InternalParameter_1374, ref InternalType_293 InternalParameter_1375)
        {
            InternalField_947 = new float3x4(
                InternalParameter_1374.c0.xyz,
                InternalParameter_1374.c1.xyz,
                InternalParameter_1374.c2.xyz,
                InternalParameter_1374.c3.xyz
                );

            InternalField_948 = InternalParameter_1375;
            InternalField_949 = new float3x4(
                math.normalize(InternalField_947.c1 - InternalField_947.c0),
                math.normalize(InternalField_947.c2 - InternalField_947.c1),
                math.normalize(InternalField_947.c3 - InternalField_947.c2),
                math.normalize(InternalField_947.c0 - InternalField_947.c3)
                );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_290 InternalMethod_1304(ref float3x4 InternalParameter_1371, out float3x4 InternalParameter_1370)
        {
            InternalParameter_1370 = default;

            float3 InternalVar_1 = float3.zero;
            InternalType_290 InternalVar_2 = default;
            for (int InternalVar_3 = 0; InternalVar_3 < 4; ++InternalVar_3)
            {
                if (InternalField_948.InternalMethod_1316(ref InternalVar_1, ref InternalParameter_1371[InternalVar_3], out InternalParameter_1370[InternalVar_3]))
                {
                    InternalVar_2[InternalVar_3] = InternalMethod_1303(ref InternalParameter_1370[InternalVar_3]);
                }
                else
                {
                    InternalVar_2[InternalVar_3] = InternalType_267.InternalField_938;
                }
            }
            return InternalVar_2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_267 InternalMethod_1303(ref float3 InternalParameter_1369)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < 4; ++InternalVar_1)
            {
                float3 InternalVar_2 = math.cross(InternalField_949[InternalVar_1], math.normalize(InternalParameter_1369 - InternalField_947[InternalVar_1]));
                if (InternalType_187.InternalMethod_914(math.lengthsq(InternalVar_2)))
                {
                    continue;
                }

                float InternalVar_3 = math.dot(InternalField_948.InternalField_950, InternalVar_2);
                if (InternalVar_3 <= 0)
                {
                    return InternalType_267.InternalField_940;
                }
            }
            return InternalType_267.InternalField_939;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InternalMethod_1313(ref InternalType_292 InternalParameter_1385, float3 InternalParameter_1386)
        {
            float3 InternalVar_1 = math.normalize(math.cross(InternalParameter_1385.InternalField_947.c1 - InternalParameter_1385.InternalField_947.c0, InternalParameter_1385.InternalField_947.c2 - InternalParameter_1385.InternalField_947.c0));
            float3 InternalVar_2 = InternalParameter_1386 - InternalParameter_1385.InternalField_947.c0;
            float InternalVar_3 = math.dot(InternalVar_1, InternalVar_2);
            return InternalParameter_1386 - InternalVar_3 * InternalVar_1;
        }
    }
}
