using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Nova
{
    [Flags]
    internal enum InternalType_11 : byte
    {
        InternalField_63 = InternalNamespace_0.InternalType_72.InternalField_236,

        InternalField_64 = InternalNamespace_0.InternalType_72.InternalField_237,
        InternalField_65 = InternalNamespace_0.InternalType_72.InternalField_238,

        InternalField_66 = InternalNamespace_0.InternalType_72.InternalField_239,
    }

    [Serializable]
    [StructLayoutAttribute(LayoutKind.Sequential)]
    internal struct InternalType_36
    {
        [NonSerialized]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalField_130;
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public short ZIndex;
        [SerializeField]
        [HideInInspector]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_11 BlockType;
        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool Visible;

        public static InternalType_36 InternalMethod_307(InternalType_11 InternalParameter_220) => new InternalType_36()
        {
            BlockType = InternalParameter_220,
            Visible = true,
        };
    }
}
