using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal unsafe class InternalType_269 : IDisposable
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static readonly List<Vector3> InternalField_838 = new List<Vector3>()
        {
            new Vector3(.5f, .5f, 0f),
            new Vector3(.5f, -.5f, 0f),
            new Vector3(-.5f, -.5f, 0f),
            new Vector3(-.5f, .5f, 0f),
        };

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_388> InternalField_839;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<ushort> InternalField_840;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_841 = -1;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_842 = -1;


        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Mesh InternalField_843 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Mesh InternalProperty_290
        {
            get
            {
                if (InternalField_843 == null)
                {
                    InternalField_843 = new Mesh();
                    InternalField_843.subMeshCount = 1;
                    List<Vector3> InternalVar_1 = new List<Vector3>();
                    InternalVar_1.AddRange(InternalField_838);
                    InternalField_843.SetVertices(InternalVar_1);

                    InternalField_843.SetIndices(new ushort[]
                    {
                        0, 1, 2,
                        2, 3, 0,

                    }, MeshTopology.Triangles, 0);

                    InternalField_843.SetNormals(new List<Vector3>()
                    {
                        Vector3.back,
                        Vector3.back,
                        Vector3.back,
                        Vector3.back,
                    });
                }
                return InternalField_843;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Mesh InternalField_844 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Mesh InternalProperty_291
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (InternalField_844 == null)
                {
                    InternalMethod_1234();
                    InternalField_844 = new Mesh();
                    InternalField_844.subMeshCount = 1;

                    InternalField_844.SetVertexBufferParams(
                        InternalField_839.Length,
                        new VertexAttributeDescriptor[]
                        {
                            new VertexAttributeDescriptor(VertexAttribute.Position, VertexAttributeFormat.Float32, 3),
                            new VertexAttributeDescriptor(VertexAttribute.Normal, VertexAttributeFormat.Float32, 3),
                            new VertexAttributeDescriptor(VertexAttribute.TexCoord0, VertexAttributeFormat.Float32, 3),
                            new VertexAttributeDescriptor(VertexAttribute.TexCoord1, VertexAttributeFormat.Float32, 3),
                        });
                    InternalField_844.SetVertexBufferData(InternalField_839.AsArray(), 0, 0, InternalField_839.Length);

                    InternalField_844.SetIndices(InternalField_840.AsArray(), MeshTopology.Triangles, 0);
                }
                return InternalField_844;
            }
        }

        private void InternalMethod_1234()
        {
            if (!InternalField_839.IsCreated)
            {
                InternalField_839 = new NativeList<InternalType_388>(1000, Allocator.Persistent);
                InternalField_840 = new NativeList<ushort>(6000, Allocator.Persistent);
            }

            InternalField_839.Clear();
            InternalField_840.Clear();

            InternalField_841 = InternalType_24.InternalProperty_1043;
            InternalField_842 = InternalType_24.InternalProperty_1044;

            InternalType_424 InternalVar_1 = new InternalType_424()
            {
                InternalField_1608 = InternalField_841,
                InternalField_1609 = InternalField_842,

                InternalField_1610 = InternalField_840,
                InternalField_1611 = InternalField_839,
                InternalField_1612 = new NativeList<Unity.Mathematics.float2>(0, Allocator.TempJob),
                InternalField_1613 = new NativeList<Unity.Mathematics.float3>(0, Allocator.TempJob),
            };

            InternalVar_1.Run();

            InternalVar_1.InternalField_1612.Dispose();
            InternalVar_1.InternalField_1613.Dispose();
        }

        #region 
        private void InternalMethod_1235()
        {
            if (InternalType_24.InternalProperty_1043 != InternalField_841 ||
                InternalType_24.InternalProperty_1044 != InternalField_842)
            {
                InternalField_844 = null;
            }
        }

        public InternalType_269()
        {
            InternalType_24.InternalEvent_10 += InternalMethod_1235;
        }

        public void Dispose()
        {
            InternalType_24.InternalEvent_10 -= InternalMethod_1235;

            if (InternalField_839.IsCreated)
            {
                InternalField_839.Dispose();
                InternalField_840.Dispose();
            }
        }
        #endregion
    }
}

