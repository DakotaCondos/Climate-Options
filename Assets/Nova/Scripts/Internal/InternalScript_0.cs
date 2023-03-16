using System.Collections.Generic;


namespace Nova.InternalNamespace_0.InternalNamespace_4
{
    internal class InternalType_155<T17> : InternalType_156<InternalType_157<T17>, T17> { }

    internal class InternalType_157<T20> : List<T20> { }

    internal class InternalType_158<T21,T22> : InternalType_156<InternalType_159<T21, T22>, KeyValuePair<T21, T22>> { }

    internal class InternalType_159<T23,T24> : Dictionary<T23, T24> { }

    internal class InternalType_156<T94,T19> where T94 : ICollection<T19>, new()
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly static Queue<T94> InternalField_449 = new Queue<T94>();

        public static T94 InternalMethod_740()
        {
            if (InternalField_449.Count > 0)
            {
                T94 InternalVar_1 = InternalField_449.Dequeue();
                InternalVar_1.Clear();
                return InternalVar_1;
            }

            return new T94();
        }

        public static void InternalMethod_741(T94 InternalParameter_572)
        {
            if (InternalParameter_572 == null)
            {
                return;
            }

            InternalField_449.Enqueue(InternalParameter_572);
        }
    }
}
