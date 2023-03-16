using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_371
    {
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_133, InternalType_259> InternalField_1287;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_259> InternalField_1288;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_259> InternalField_1289;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_348, InternalType_259> InternalField_1290;
        [ReadOnly]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_348, InternalType_164<InternalType_259>> InternalField_1291;
    }

    internal struct InternalType_372
    {
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_133, InternalType_164<InternalType_288>> InternalField_1292;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_259, InternalType_164<InternalType_288>> InternalField_1293;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref InternalType_164<InternalType_288> InternalMethod_1583(ref InternalType_373 InternalParameter_1708, ref InternalType_371 InternalParameter_1709)
        {
            switch (InternalParameter_1708.InternalField_1297)
            {
                case InternalType_266.InternalField_786:
                case InternalType_266.InternalField_787:
                case InternalType_266.InternalField_788:
                case InternalType_266.InternalField_790:
                    return ref InternalField_1292.InternalMethod_748(InternalParameter_1708.InternalField_1294);
                case InternalType_266.InternalField_789:
                {
                    InternalType_259 InternalVar_1 = InternalParameter_1709.InternalField_1290[InternalParameter_1708.InternalField_1295];
                    return ref InternalField_1293.InternalMethod_748(InternalVar_1);
                }
                default:
                    Debug.LogError($"Failed to get overlap list for {InternalParameter_1708.InternalField_1297}");
                    return ref InternalField_1292.InternalMethod_748(InternalParameter_1708.InternalField_1294);
            }
        }
    }

    internal struct InternalType_374
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public float4x4 InternalField_1299;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_306 InternalField_1300;
    }

    internal struct InternalType_375
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_374 InternalField_1301;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_374 InternalField_1302;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1585(ref InternalType_306 InternalParameter_1714)
        {
            if (!InternalField_1301.InternalField_1300.InternalMethod_1374(ref InternalParameter_1714))
            {
                return false;
            }

            return !InternalField_1302.InternalField_1300.InternalMethod_1375(ref InternalParameter_1714);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1586(ref InternalType_375 InternalParameter_1715)
        {
            if (!InternalField_1301.InternalField_1300.InternalMethod_1374(ref InternalParameter_1715.InternalField_1301.InternalField_1300))
            {
                return false;
            }

            return !(InternalField_1302.InternalField_1300.InternalMethod_1375(ref InternalParameter_1715.InternalField_1302.InternalField_1300) ||
                InternalParameter_1715.InternalField_1302.InternalField_1300.InternalMethod_1375(ref InternalField_1302.InternalField_1300));
        }
    }

    internal struct InternalType_376
    {
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_133, InternalType_374> InternalField_1303;
        [NativeDisableParallelForRestriction]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_161<InternalType_259, InternalType_375> InternalField_1304;
    }
}
