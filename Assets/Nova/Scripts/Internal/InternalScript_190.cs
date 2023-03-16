using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal static partial class InternalType_362
    {
        internal struct InternalType_341
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float4x4 InternalField_1255;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float4x4 InternalField_1254;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public float4x4 InternalField_1637;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_3374;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public CameraType InternalField_3375;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private bool InternalField_1180;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public float3 InternalMethod_1590(ref InternalType_362.InternalType_297 InternalParameter_1719)
            {
                if (InternalField_1180)
                {
                    return math.normalize(math.rotate(InternalField_1254, InternalParameter_1719.InternalField_1176 ? InternalType_187.InternalField_503 : InternalType_187.InternalField_506));
                }
                else
                {
                    float3 InternalVar_1 = math.rotate(InternalField_1254, InternalParameter_1719.InternalField_1176 ? InternalParameter_1719.InternalField_1179.InternalField_1175 : -InternalParameter_1719.InternalField_1179.InternalField_1175);
                    return math.any(InternalVar_1) ? math.normalize(InternalVar_1) : InternalVar_1;
                }
            }

            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void InternalMethod_1588(ref InternalType_362.InternalType_297 InternalParameter_1718, ref InternalType_362.InternalType_297 InternalParameter_1672, int InternalParameter_1671)
            {
                float InternalVar_1 = InternalType_178.InternalField_477 * InternalParameter_1672.InternalField_1179.InternalField_1172;
                float InternalVar_2 = InternalParameter_1672.InternalField_1179.InternalField_1172 - InternalVar_1 * InternalParameter_1671;
                if (InternalVar_2 > InternalParameter_1718.InternalField_1179.InternalField_1172)
                {
                    return;
                }

                float InternalVar_3 = InternalType_178.InternalField_476 * InternalVar_2;
                InternalParameter_1718.InternalField_1179.InternalField_1172 = InternalVar_3;

                if (InternalField_1180)
                {
                    InternalParameter_1718.InternalField_1179.InternalField_1175.z = InternalVar_3;
                }
                else
                {
                    InternalParameter_1718.InternalField_1179.InternalField_1175 = InternalVar_3 * math.normalize(InternalParameter_1718.InternalField_1179.InternalField_1175);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_362.InternalType_296 InternalMethod_1548(ref InternalType_292 InternalParameter_1611)
            {
                if (InternalField_1180)
                {
                    return InternalMethod_1504(ref InternalParameter_1611);
                }
                else
                {
                    return InternalMethod_1503(ref InternalParameter_1611);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private InternalType_362.InternalType_296 InternalMethod_1504(ref InternalType_292 InternalParameter_1610)
            {
                InternalType_362.InternalType_296 InternalVar_1 = default;
                InternalVar_1.InternalField_1173 = float.MinValue;
                InternalVar_1.InternalField_1174 = float.MaxValue;

                for (int InternalVar_2 = 0; InternalVar_2 < 4; ++InternalVar_2)
                {
                    InternalVar_1.InternalField_1175 += InternalParameter_1610.InternalField_947[InternalVar_2];
                    float InternalVar_3 = InternalParameter_1610.InternalField_947[InternalVar_2].z;
                    InternalVar_1.InternalField_1173 = math.max(InternalVar_3, InternalVar_1.InternalField_1173);
                    InternalVar_1.InternalField_1174 = math.min(InternalVar_3, InternalVar_1.InternalField_1174);
                }

                InternalVar_1.InternalField_1175 *= InternalType_187.InternalField_527;
                InternalVar_1.InternalField_1172 = InternalVar_1.InternalField_1175.z;
                return InternalVar_1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private InternalType_362.InternalType_296 InternalMethod_1503(ref InternalType_292 InternalParameter_1402)
            {
                InternalType_362.InternalType_296 InternalVar_1 = default;

                float InternalVar_2 = 0f;
                float InternalVar_3 = float.MaxValue;
                int InternalVar_4 = 0;
                int InternalVar_5 = 0;
                for (int InternalVar_6 = 0; InternalVar_6 < 4; ++InternalVar_6)
                {
                    InternalVar_1.InternalField_1175 += InternalParameter_1402.InternalField_947[InternalVar_6];
                    float InternalVar_7 = math.lengthsq(InternalParameter_1402.InternalField_947[InternalVar_6]);
                    if (InternalVar_7 > InternalVar_2)
                    {
                        InternalVar_4 = InternalVar_6;
                        InternalVar_2 = InternalVar_7;
                    }

                    if (InternalVar_7 < InternalVar_3)
                    {
                        InternalVar_3 = InternalVar_7;
                        InternalVar_5 = InternalVar_6;
                    }
                }

                InternalVar_1.InternalField_1175 *= InternalType_187.InternalField_527;

                float3 InternalVar_8 = InternalType_292.InternalMethod_1313(ref InternalParameter_1402, InternalType_187.InternalField_530);

                float3 InternalVar_9;
                if (InternalParameter_1402.InternalMethod_1303(ref InternalVar_8) != InternalType_267.InternalField_940)
                {
                    InternalVar_9 = InternalVar_8;
                }
                else
                {

                    float3 InternalVar_10 = InternalParameter_1402.InternalField_947[InternalVar_5];
                    float3 InternalVar_11 = InternalParameter_1402.InternalField_947[InternalType_187.InternalMethod_936(InternalVar_5 + 1, 4)];
                    float3 InternalVar_12 = InternalParameter_1402.InternalField_947[InternalType_187.InternalMethod_936(InternalVar_5 - 1, 4)];
                    if (InternalType_187.InternalMethod_911(ref InternalVar_10, ref InternalVar_11, ref InternalVar_8, out InternalVar_9))
                    {
                    }
                    else if (InternalType_187.InternalMethod_911(ref InternalVar_10, ref InternalVar_12, ref InternalVar_8, out InternalVar_9))
                    {
                    }
                    else
                    {
                        InternalVar_9 = InternalParameter_1402.InternalField_947[InternalVar_5];
                    }
                }

                InternalVar_1.InternalField_1174 = math.length(InternalVar_9);

                InternalVar_1.InternalField_1173 = math.length(InternalParameter_1402.InternalField_947[InternalVar_4]);
                InternalVar_1.InternalField_1172 = math.length(InternalVar_1.InternalField_1175);
                return InternalVar_1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public InternalType_341(Camera InternalParameter_230)
            {
                InternalField_1255 = InternalParameter_230.transform.worldToLocalMatrix;
                InternalField_1637 = InternalParameter_230.projectionMatrix;
                InternalField_1254 = default;
                InternalField_3374 = InternalParameter_230.GetInstanceID();
                InternalField_3375 = InternalParameter_230.cameraType;

                switch (InternalParameter_230.transparencySortMode)
                {
                    case TransparencySortMode.Default:
                        InternalField_1180 = InternalParameter_230.orthographic;
                        break;
                    case TransparencySortMode.Orthographic:
                        InternalField_1180 = true;
                        break;
                    case TransparencySortMode.Perspective:
                    default:
                        InternalField_1180 = false;
                        break;
                }
            }
        }
    }
}
