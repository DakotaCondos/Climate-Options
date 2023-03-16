using Nova.InternalNamespace_0.InternalNamespace_5;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Nova
{
    [Serializable]
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_40
    {
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int SortingOrder;
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int RenderQueue;
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool RenderOverOpaqueGeometry;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal static readonly InternalType_40 InternalField_137 = new InternalType_40()
        {
            SortingOrder = 0,
            RenderQueue = InternalType_178.InternalField_472,
            RenderOverOpaqueGeometry = false,
        };
    }
}
