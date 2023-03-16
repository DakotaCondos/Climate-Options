using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Nova
{
    [Serializable]
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_37
    {
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Color Color;
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool Clip;
        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalField_131;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal static readonly InternalType_37 InternalField_132 = new InternalType_37()
        {
            Color = Color.white,
            Clip = true,
        };
    }
}

