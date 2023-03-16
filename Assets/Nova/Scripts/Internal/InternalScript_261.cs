using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_5
{
    internal static partial class InternalType_183
    {
        [BurstCompile]
        internal struct InternalType_184<T37,T38> : InternalType_192
            where T37 : unmanaged, IEquatable<T37>
            where T38 : unmanaged
        {
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NovaHashMap<T37, T38> InternalField_486;
            [ReadOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<T37> InternalField_487;

            [WriteOnly]
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public NativeList<T38> InternalField_488;

            public void Execute()
            {
                InternalField_488.Clear();

                for (int InternalVar_1 = 0; InternalVar_1 < InternalField_487.Length; ++InternalVar_1)
                {
                    if (!InternalField_486.TryGetValue(InternalField_487[InternalVar_1], out T38 InternalVar_2))
                    {
                        Debug.LogError($"Key {InternalField_487[InternalVar_1]} was not in map");
                        continue;
                    }

                    InternalField_488.Add(InternalVar_2);
                }
            }
        }
    }
}

