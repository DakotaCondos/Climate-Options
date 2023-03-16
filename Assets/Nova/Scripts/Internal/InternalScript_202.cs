using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [StructLayoutAttribute(LayoutKind.Explicit)]
    internal struct InternalType_382
    {
        [FieldOffset(0)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_1318;
        [FieldOffset(0)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte InternalField_1319;
        [FieldOffset(1)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte InternalField_1320;
        [FieldOffset(2)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte InternalField_1321;
        [FieldOffset(3)]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte InternalField_1322;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1601(ref Color InternalParameter_1732)
        {
            if (InternalType_333.InternalProperty_318 == ColorSpace.Linear)
            {
                Color InternalVar_1 = InternalParameter_1732.linear;
                InternalMethod_1603(ref InternalVar_1);
            }
            else
            {
                InternalMethod_1603(ref InternalParameter_1732);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1602(ref Color32 InternalParameter_1733)
        {
            if (InternalType_333.InternalProperty_318 == ColorSpace.Linear)
            {
                Color InternalVar_1 = ((Color)InternalParameter_1733).linear;
                InternalMethod_1603(ref InternalVar_1);
            }
            else
            {
                InternalField_1319 = InternalParameter_1733.r;
                InternalField_1320 = InternalParameter_1733.g;
                InternalField_1321 = InternalParameter_1733.b;
                InternalField_1322 = InternalParameter_1733.a;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_1603(ref Color InternalParameter_1734)
        {
            float4 InternalVar_1 = InternalParameter_1734.InternalMethod_969();
            InternalVar_1 = math.round(InternalType_187.InternalField_542 * math.saturate(InternalVar_1));
            InternalField_1319 = (byte)InternalVar_1.x;
            InternalField_1320 = (byte)InternalVar_1.y;
            InternalField_1321 = (byte)InternalVar_1.z;
            InternalField_1322 = (byte)InternalVar_1.w;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_382 InternalField_1323 = default;
    }
}

