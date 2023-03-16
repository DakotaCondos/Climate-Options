using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System;
using Unity.Collections;
using Unity.Jobs;

namespace Nova.InternalNamespace_0.InternalNamespace_2
{
    
    internal abstract class InternalType_126<T90> : InternalType_127 where T90 : InternalType_126<T90>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static T90 InternalField_406 = null;
    }

    internal struct InternalType_128 : InternalType_147
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<InternalType_131> InternalField_408;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NativeList<InternalType_133> InternalField_409;

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public JobHandle InternalField_410;

        public void InternalMethod_702()
        {
            InternalField_408 = new NativeList<InternalType_131>(InternalType_178.InternalField_3012, Allocator.Persistent);
            InternalField_409 = new NativeList<InternalType_133>(InternalType_178.InternalField_3013, Allocator.Persistent);
        }

        public void InternalMethod_610()
        {
            InternalField_408.Clear();
            InternalField_409.Clear();
            InternalField_410 = default(JobHandle);
        }

        public void Dispose()
        {
            InternalField_408.Dispose();
            InternalField_409.Dispose();
        }
    }

    
    internal abstract class InternalType_127 : IDisposable
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const int InternalField_407 = 32;

        public abstract void InternalMethod_603();
        public abstract void Dispose();

        public virtual JobHandle InternalMethod_604(JobHandle InternalParameter_495) { return InternalParameter_495; }
        public virtual void InternalMethod_605(ref InternalType_128 InternalParameter_496) { }
        public virtual void InternalMethod_606(ref InternalType_128 InternalParameter_497) { }
        public virtual void InternalMethod_607() { }
        public virtual void InternalMethod_608() { }
    }
}

