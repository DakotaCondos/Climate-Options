using System.Runtime.CompilerServices;
using Unity.Burst;
using UnityEngine;
using UnityEngine.Rendering;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal class InternalType_333
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static ColorSpace InternalProperty_318
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1158.Data.InternalField_1159;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static bool InternalProperty_1033
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1158.Data.InternalField_3353;
        }

        public struct InternalType_334
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public ColorSpace InternalField_1159;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public bool InternalField_3353;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly SharedStatic<InternalType_334> InternalField_1158 = SharedStatic<InternalType_334>.GetOrCreate<InternalType_333, InternalType_335>();

        public static void InternalMethod_1494()
        {
            ref InternalType_334 InternalVar_1 = ref InternalField_1158.Data;
            InternalVar_1.InternalField_1159 = QualitySettings.activeColorSpace;
            InternalVar_1.InternalField_3353 = GraphicsSettings.renderPipelineAsset != null;
        }

        private class InternalType_335 { }
    }
}

