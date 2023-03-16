using Nova.Compat;
using System;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_2
{
    internal abstract class InternalType_136<T89> where T89 : InternalType_136<T89>, new()
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static bool InternalProperty_199 { get; private set; } = false;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static T89 InternalProperty_200 { get; private set; } = null;

        protected InternalType_136()
        {
            if (NovaApplication.IsEditor)
            {
                AppDomain.CurrentDomain.DomainUnload -= InternalMethod_653;
                AppDomain.CurrentDomain.DomainUnload += InternalMethod_653;
            }

            InternalProperty_199 = true;
            try
            {
                InternalMethod_656();
            }
            catch (Exception e)
            {
                Debug.LogError($"System {typeof(T89)} Init failed with {e}");
            }
        }

        internal static void InternalMethod_652()
        {
            if (InternalProperty_200 == null)
            {
                InternalProperty_200 = new T89();
            }
        }

        private static void InternalMethod_653(object InternalParameter_526, EventArgs InternalParameter_527)
        {
            InternalMethod_654();
        }

        internal static void InternalMethod_654()
        {
            try
            {
                InternalProperty_200.InternalMethod_657();
            }
            catch (Exception e)
            {
                Debug.LogError($"System {typeof(T89)} Dispose failed with {e}");
            }

            InternalProperty_199 = false;
        }

        public static void InternalMethod_655()
        {
            InternalMethod_654();
            InternalProperty_200 = null;
        }

        protected abstract void InternalMethod_656();
        protected abstract void InternalMethod_657();
    }
}
