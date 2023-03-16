using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_306 : System.IEquatable<InternalType_306>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1005;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float3 InternalField_1006;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 InternalMethod_1362() => InternalType_187.InternalField_526 * (InternalField_1005 + InternalField_1006);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 InternalMethod_1363() => InternalField_1006 - InternalField_1005;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bounds InternalMethod_1364() => new Bounds(InternalMethod_1362(), InternalMethod_1363());

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float2 InternalProperty_305
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1005.xy;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private float2 InternalProperty_306
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1006.xy;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1367(ref InternalType_306 InternalParameter_1444)
        {
            InternalField_1005.xy = math.clamp(InternalField_1005.xy, InternalParameter_1444.InternalField_1005.xy, InternalParameter_1444.InternalField_1006.xy);
            InternalField_1006.xy = math.clamp(InternalField_1006.xy, InternalParameter_1444.InternalField_1005.xy, InternalParameter_1444.InternalField_1006.xy);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x4 InternalMethod_1368()
        {
            return new float4x4(
                new float4(InternalField_1005.xy, 0, 1f),
                new float4(InternalField_1005.x, InternalField_1006.y, 0, 1f),
                new float4(InternalField_1006.xy, 0, 1f),
                new float4(InternalField_1006.x, InternalField_1005.y, 0, 1f)
                );
        }

        public void InternalMethod_1369(out float4x4 InternalParameter_1445, out float4x4 InternalParameter_1446)
        {
            InternalParameter_1445 = InternalParameter_1446 = InternalMethod_1368();
            InternalParameter_1445 += float4x4.Translate(new float3(0, 0, InternalField_1005.z));
            InternalParameter_1446 += float4x4.Translate(new float3(0, 0, InternalField_1006.z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_306(float3 InternalParameter_1447, float3 InternalParameter_1448)
        {
            this.InternalField_1005 = InternalParameter_1447;
            this.InternalField_1006 = InternalParameter_1448;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_306(float2 InternalParameter_1449, float2 InternalParameter_1450)
        {
            this.InternalField_1005 = new float3(InternalParameter_1449, 0f);
            this.InternalField_1006 = new float3(InternalParameter_1450, 0f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_306(Bounds InternalParameter_1451)
        {
            InternalField_1005 = InternalParameter_1451.min;
            InternalField_1006 = InternalParameter_1451.max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_306(ref float4x4 InternalParameter_1452)
        {
            float4 InternalVar_1 = InternalType_187.InternalMethod_912(ref InternalParameter_1452);
            float4 InternalVar_2 = InternalType_187.InternalMethod_913(ref InternalParameter_1452);
            this.InternalField_1005 = InternalVar_1.xyz;
            this.InternalField_1006 = InternalVar_2.xyz;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1374(ref InternalType_306 InternalParameter_1453)
        {
            float4 InternalVar_1 = new float4(InternalProperty_305, InternalParameter_1453.InternalProperty_305);
            float4 InternalVar_2 = new float4(InternalParameter_1453.InternalProperty_306, InternalProperty_306);
            return !math.any(InternalVar_1.InternalMethod_938(ref InternalVar_2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1375(ref InternalType_306 InternalParameter_1454)
        {
            float4 InternalVar_1 = new float4(InternalProperty_306, InternalParameter_1454.InternalProperty_305);
            float4 InternalVar_2 = new float4(InternalParameter_1454.InternalProperty_306, InternalProperty_305);
            return math.all(InternalVar_1.InternalMethod_938(ref InternalVar_2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1376(ref InternalType_306 InternalParameter_1455)
        {
            InternalField_1005 = math.min(InternalField_1005, InternalParameter_1455.InternalField_1005);
            InternalField_1006 = math.max(InternalField_1006, InternalParameter_1455.InternalField_1006);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_306 InternalMethod_1377(ref float4x4 InternalParameter_1456, ref InternalType_306 InternalParameter_1457)
        {
            float4x4 InternalVar_1 = math.mul(InternalParameter_1456, InternalParameter_1457.InternalMethod_1368());
            return new InternalType_306(ref InternalVar_1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_306 InternalMethod_1378(ref float4x4 InternalParameter_1458, ref float4x4 InternalParameter_1459, ref InternalType_306 InternalParameter_1460)
        {
            float4x4 InternalVar_1 = math.mul(InternalParameter_1458, InternalParameter_1459);
            return InternalMethod_1377(ref InternalVar_1, ref InternalParameter_1460);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_306 InternalMethod_1379(ref float4x4 InternalParameter_1461, ref InternalType_306 InternalParameter_1462)
        {
            InternalParameter_1462.InternalMethod_1369(out float4x4 InternalVar_1, out float4x4 InternalVar_2);
            float4x4 InternalVar_3 = math.mul(InternalParameter_1461, InternalVar_1);
            float4x4 InternalVar_4 = math.mul(InternalParameter_1461, InternalVar_2);

            float4 InternalVar_5 = math.min(InternalType_187.InternalMethod_912(ref InternalVar_3), InternalType_187.InternalMethod_912(ref InternalVar_4));
            float4 InternalVar_6 = math.max(InternalType_187.InternalMethod_913(ref InternalVar_3), InternalType_187.InternalMethod_913(ref InternalVar_4));
            return new InternalType_306(InternalVar_5.xyz, InternalVar_6.xyz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_306 InternalMethod_1380(ref float4x4 InternalParameter_1463, ref float4x4 InternalParameter_1464, ref InternalType_306 InternalParameter_1465)
        {
            float4x4 InternalVar_1 = math.mul(InternalParameter_1463, InternalParameter_1464);
            return InternalMethod_1379(ref InternalVar_1, ref InternalParameter_1465);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InternalType_306 InternalMethod_1381(ref float2 InternalParameter_1466, ref InternalType_306 InternalParameter_1467)
        {
            float3 InternalVar_1 = new float3(InternalParameter_1466, 0f);
            return new InternalType_306(InternalParameter_1467.InternalField_1005 + InternalVar_1, InternalParameter_1467.InternalField_1006 + InternalVar_1);
        }

        public bool Equals(InternalType_306 other)
        {
            return InternalField_1005.Equals(other.InternalField_1005) && InternalField_1006.Equals(other.InternalField_1006);
        }

        public override string ToString()
        {
            return $"({InternalField_1005} => {InternalField_1006}";
        }
    }
}
