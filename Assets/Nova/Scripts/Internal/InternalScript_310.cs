using System;
using System.Runtime.CompilerServices;
using Unity.Burst;

namespace Nova.InternalNamespace_0
{
    internal interface InternalType_26
    {
        event Action InternalEvent_7;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        float InternalProperty_226 { get; }
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        int InternalProperty_944 { get; }
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        int InternalProperty_943 { get; }
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        bool InternalProperty_946 { get; }
    }

    internal class InternalType_24
    {
        public static event Action InternalEvent_8 = null;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_26 InternalField_138 = null;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static readonly SharedStatic<InternalType_115> InternalField_88 = SharedStatic<InternalType_115>.GetOrCreate<InternalType_24>();

        public static void InternalMethod_334()
        {
            InternalField_138 = null;
            InternalEvent_8 = null;
        }

        public static void InternalMethod_333(InternalType_26 InternalParameter_1309)
        {
            InternalField_138 = InternalParameter_1309;
            InternalField_138.InternalEvent_7 += InternalEvent_9;
            InternalEvent_9 = null;
        }

        private static event Action InternalEvent_9 = null;
        public static event Action InternalEvent_10
        {
            add
            {
                if (InternalProperty_1041 == null)
                {
                    InternalEvent_9 += value;
                    return;
                }

                InternalProperty_1041.InternalEvent_7 += value;
            }
            remove
            {
                if (InternalProperty_1041 == null)
                {
                    return;
                }

                InternalProperty_1041.InternalEvent_7 -= value;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static ref InternalType_115 InternalProperty_945
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref InternalField_88.Data;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static bool InternalProperty_1040 => InternalProperty_1041 != null;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static InternalType_26 InternalProperty_1041
        {
            get
            {
                if (InternalField_138 as UnityEngine.Object == null)
                {
                    InternalEvent_8?.Invoke();
                }

                return InternalField_138;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static float InternalProperty_1042 => InternalProperty_1041.InternalProperty_226;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static int InternalProperty_1043 => InternalProperty_1041.InternalProperty_944;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static int InternalProperty_1044 => InternalProperty_1041.InternalProperty_943;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static bool InternalProperty_1045 => InternalProperty_1041.InternalProperty_946;
    }
}
