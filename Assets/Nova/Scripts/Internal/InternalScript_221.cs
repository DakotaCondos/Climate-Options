using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_10;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_79 : InternalType_147, InternalType_150
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<InternalType_110> InternalField_261;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_306 InternalField_262;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_3197;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public float InternalField_264;

        public void InternalMethod_705()
        {
            InternalField_261.InternalMethod_705();
            InternalField_3197 = 0;
            InternalField_262 = default;
            InternalField_264 = default;
        }

        public void InternalMethod_481(InternalType_257 InternalParameter_347, out int InternalParameter_348, out int InternalParameter_349)
        {
            InternalParameter_348 = 0;
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_261.InternalProperty_216; ++InternalVar_1)
            {
                InternalType_110 InternalVar_2 = InternalField_261[InternalVar_1];
                if (InternalVar_2.InternalField_354 != InternalParameter_347)
                {
                    InternalParameter_348 += InternalVar_2.InternalField_353;
                    continue;
                }

                InternalParameter_349 = InternalVar_2.InternalField_353;
                return;
            }

            Debug.LogError("Failed to get vert index slice for a text material");
            InternalParameter_349 = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_482(int InternalParameter_350, ref InternalType_258 InternalParameter_351, ref float3 InternalParameter_352)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_261.InternalProperty_216; ++InternalVar_1)
            {
                InternalType_110 InternalVar_2 = InternalField_261[InternalVar_1];
                if (InternalParameter_350 >= InternalVar_2.InternalField_353)
                {
                    InternalParameter_350 -= InternalVar_2.InternalField_353;
                    continue;
                }

                InternalVar_2.InternalMethod_550(InternalParameter_350, ref InternalParameter_351, ref InternalParameter_352);
                return;
            }
        }

        public void Dispose()
        {
            InternalField_261.InternalMethod_776();
        }

        public void InternalMethod_702()
        {
            InternalField_261.InternalMethod_775(1);
        }
    }

    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_110 : InternalType_147, InternalType_150
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_352;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_353;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_257 InternalField_354;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<float3> InternalField_355;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<Color32> InternalField_356;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<Vector2> InternalField_357;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<Vector2> InternalField_358;

        public void InternalMethod_705()
        {
            InternalField_352 = 0;
            InternalField_353 = 0;
            InternalField_354 = InternalType_257.InternalField_748;
            InternalField_355.InternalMethod_705();
            InternalField_356.InternalMethod_705();
            InternalField_357.InternalMethod_705();
            InternalField_358.InternalMethod_705();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_550(int InternalParameter_415, ref InternalType_258 InternalParameter_416, ref float3 InternalParameter_417)
        {
            int InternalVar_1 = InternalParameter_415 * 4;
            for (int InternalVar_2 = 0; InternalVar_2 < 4; ++InternalVar_2)
            {
                int InternalVar_3 = InternalVar_1 + InternalVar_2;

                ref InternalType_260 InternalVar_4 = ref InternalParameter_416[InternalVar_2];
                InternalVar_4.InternalField_755 = InternalField_355[InternalVar_3] + InternalParameter_417;
                InternalVar_4.InternalField_759.InternalMethod_1602(ref InternalField_356.InternalMethod_800(InternalVar_3));
                InternalVar_4.InternalField_757 = InternalField_357[InternalVar_3];
                InternalVar_4.InternalField_758 = InternalField_358[InternalVar_3];
            }

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_551(ref float3 InternalParameter_418, ref float3 InternalParameter_419, ref int InternalParameter_420)
        {
            InternalParameter_420 += InternalField_352;
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_352; ++InternalVar_1)
            {
                float3 InternalVar_2 = InternalField_355[InternalVar_1];
                InternalParameter_418 = math.max(InternalParameter_418, InternalVar_2);
                InternalParameter_419 = math.min(InternalParameter_419, InternalVar_2);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_552(int InternalParameter_421)
        {
            InternalField_352 = InternalParameter_421;
            InternalField_353 = InternalField_352 / 4;
            InternalField_355.InternalMethod_793(InternalParameter_421);
            InternalField_356.InternalMethod_793(InternalParameter_421);
            InternalField_357.InternalMethod_793(InternalParameter_421);
            InternalField_358.InternalMethod_793(InternalParameter_421);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void InternalMethod_553(TMP_MeshInfo InternalParameter_422)
        {
            InternalField_354 = InternalParameter_422.material.GetInstanceID();
            InternalMethod_552(InternalParameter_422.vertices.Length);
            InternalType_164<Vector3> InternalVar_1 = InternalField_355.InternalMethod_781<float3, Vector3>();
            InternalVar_1.InternalMethod_771(InternalParameter_422.vertices, InternalField_352);
            InternalField_356.InternalMethod_771(InternalParameter_422.colors32, InternalField_352);
            InternalField_358.InternalMethod_771(InternalParameter_422.uvs2, InternalField_352);
        }

        public void Dispose()
        {
            InternalField_355.Dispose();
            InternalField_356.Dispose();
            InternalField_357.Dispose();
            InternalField_358.Dispose();
        }

        public void InternalMethod_702()
        {
            InternalField_355.InternalMethod_775(64);
            InternalField_356.InternalMethod_775(64);
            InternalField_357.InternalMethod_775(64);
            InternalField_358.InternalMethod_775(64);
        }
    }
}
