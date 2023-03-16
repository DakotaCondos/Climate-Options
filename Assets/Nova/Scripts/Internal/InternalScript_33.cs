using System;
using System.Collections.Generic;

namespace Nova.InternalNamespace_0.InternalNamespace_8
{
    internal class InternalType_516<T75> : InternalType_518
    {
        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private static Queue<InternalType_516<T75>> InternalField_2330 = new Queue<InternalType_516<T75>>();

        public static InternalType_516<T75> InternalMethod_2034(IList<T75> InternalParameter_2357)
        {
            InternalType_516<T75> InternalVar_1 = InternalField_2330.Count > 0 ? InternalField_2330.Dequeue() : new InternalType_516<T75>();

            InternalVar_1.InternalField_2329 = InternalParameter_2357;
            return InternalVar_1;
        }
        #endregion

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public IList<T75> InternalField_2329;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public override bool InternalProperty_431 => InternalProperty_430 == 0;

        public override Type InternalMethod_2039() => typeof(T75);

        public override IList<T> InternalMethod_2038<T>() => InternalField_2329 as IList<T>;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public override int InternalProperty_430
        {
            get
            {
                if (InternalField_2329 == null)
                {
                    return 0;
                }

                try
                {
                    return InternalField_2329.Count;
                }
                catch (Exception e)
                {
                    UnityEngine.Debug.LogException(e);
                    return 0;
                }
            }
        }

        public override bool InternalMethod_2035<T>(int index, out T InternalParameter_2358)
        {
            InternalParameter_2358 = default;

            if (InternalProperty_431)
            {
                return false;
            }

            if (InternalField_2329 is IList<T> typedSource)
            {
                try
                {
                    if (index >= 0 && index < InternalProperty_430)
                    {
                        InternalParameter_2358 = typedSource[index];
                        return true;
                    }
                }
                catch (Exception e)
                {
                    UnityEngine.Debug.LogException(e);
                    return false;
                }

            }

            T75 InternalVar_1 = InternalMethod_1958(index);

            if (InternalVar_1 is T valAsT)
            {
                InternalParameter_2358 = valAsT;
                return true;
            }
            else
            {
                return InternalVar_1 == null;
            }
        }

        public override Type InternalMethod_2036(int InternalParameter_2360)
        {
            Type InternalVar_1 = typeof(T75);

            if (InternalVar_1.IsValueType || !InternalMethod_2035(InternalParameter_2360, out T75 InternalVar_2) || InternalVar_2 == null)
            {
                return InternalVar_1;
            }

            return InternalVar_2.GetType();
        }

        public T75 InternalMethod_1958(int InternalParameter_1279)
        {
            try
            {
                if (InternalParameter_1279 >= 0 && InternalParameter_1279 < InternalProperty_430)
                {
                    return InternalField_2329[InternalParameter_1279];
                }
            }
            catch (Exception e)
            {
                UnityEngine.Debug.LogException(e);
            }

            return default;
        }

        public override void Dispose()
        {
            InternalField_2330.Enqueue(this);
        }
    }

    
    internal abstract class InternalType_518 : InternalType_517<int>, IDisposable
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public abstract bool InternalProperty_431 { get; }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public abstract int InternalProperty_430 { get; }
        public abstract Type InternalMethod_2036(int index);
        public abstract bool InternalMethod_2035<TData>(int index, out TData InternalParameter_2358);
        public abstract Type InternalMethod_2039();
        public abstract IList<T> InternalMethod_2038<T>();

        public virtual void Dispose() { }
    }

    
    internal interface InternalType_517<T101>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_430 { get; }
        Type InternalMethod_2036(T101 InternalParameter_2360);
        bool InternalMethod_2035<TData>(T101 InternalParameter_2359, out TData InternalParameter_2358);
    }
}
