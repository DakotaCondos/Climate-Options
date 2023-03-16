using System.Runtime.CompilerServices;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal class InternalType_264 : InternalType_265
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Material InternalField_780 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public MaterialPropertyBlock InternalField_781 = new MaterialPropertyBlock();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_276 InternalField_782;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_305 InternalField_783;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_784;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_266 InternalProperty_278
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_782.InternalField_902;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Mesh InternalProperty_279
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                switch (InternalProperty_278)
                {
                    case InternalType_266.InternalField_787:
                        return InternalType_268.InternalField_406.InternalProperty_280.InternalProperty_291;
                    case InternalType_266.InternalField_789:
                    case InternalType_266.InternalField_786:
                    case InternalType_266.InternalField_788:
                    case InternalType_266.InternalField_790:
                    default:
                        return InternalType_268.InternalField_406.InternalProperty_280.InternalProperty_290;
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1204()
        {
            InternalField_781.Clear();

            if ((InternalField_782.InternalField_903 & InternalType_322.InternalField_1087) != 0 &&
                InternalType_274.InternalProperty_190 != null &&
                InternalField_782.InternalField_904.InternalField_913.InternalProperty_296)
            {
                InternalType_274.InternalProperty_190.InternalField_876.InternalMethod_1392(InternalField_782.InternalField_904.InternalField_913, this);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1591(Camera InternalParameter_1721, ref InternalType_362.InternalType_361 InternalParameter_1720)
        {
            if (InternalParameter_1720.InternalField_1257 || InternalField_784 == 0)
            {
                return;
            }

            InternalField_781.SetInt(InternalType_331.InternalField_1597, InternalParameter_1720.InternalField_1258 ? 1 : 0);

            Graphics.DrawMeshInstancedProcedural(
                InternalProperty_279,
                0,
                InternalField_780,
                InternalParameter_1720.InternalField_1259,
                InternalField_784,
                InternalField_781,
                InternalField_782.InternalField_907.InternalField_910,
                receiveShadows: InternalField_782.InternalField_907.InternalField_911,
                layer: InternalField_782.InternalField_901,
                camera: InternalParameter_1721
                );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1206(Texture2DArray InternalParameter_1291)
        {
            InternalField_781.SetTexture(InternalType_331.InternalField_1167, InternalParameter_1291);
        }
    }
}

