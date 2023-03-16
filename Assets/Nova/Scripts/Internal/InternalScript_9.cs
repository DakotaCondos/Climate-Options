
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_4
{
    internal class InternalType_153<T92> : ICollection<T92>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private List<T92> InternalField_444 = null;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<T92, int> InternalField_445 = null;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_521<T92> InternalProperty_221 => InternalField_444.InternalMethod_2043();

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int Count => InternalField_444.Count;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool IsReadOnly => ((ICollection<T92>)InternalField_444).IsReadOnly;

        public T92 this[int InternalParameter_559] => InternalField_444[InternalParameter_559];

        public void Add(T92 value)
        {
            if (Contains(value))
            {
                return;
            }

            int InternalVar_1 = InternalField_444.Count;

            InternalField_445.Add(value, InternalVar_1);
            InternalField_444.Add(value);

        }

        public void InternalMethod_719(List<T92> InternalParameter_560)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_560.Count; ++InternalVar_1)
            {
                Add(InternalParameter_560[InternalVar_1]);
            }
        }

        public void InternalMethod_720(InternalType_153<T92> InternalParameter_561)
        {
            InternalMethod_719(InternalParameter_561.InternalField_444);
        }

        public void InternalMethod_721(T92[] InternalParameter_562)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_562.Length; ++InternalVar_1)
            {
                Add(InternalParameter_562[InternalVar_1]);
            }
        }

        public bool Remove(T92 value)
        {
            if (!InternalField_445.TryGetValue(value, out int InternalVar_1))
            {
                return false;
            }

            InternalMethod_722(InternalVar_1);

            return true;
        }

        public void InternalMethod_722(int InternalParameter_563)
        {
            T92 InternalVar_1 = InternalField_444[InternalParameter_563];
            InternalField_445.Remove(InternalVar_1);
            InternalField_444.RemoveAtSwapBack(InternalParameter_563);

            if (InternalParameter_563 < InternalField_444.Count)
            {
                InternalField_445[InternalField_444[InternalParameter_563]] = InternalParameter_563;
            }

        }

        public bool Contains(T92 value)
        {
            return InternalField_445.ContainsKey(value);
        }

        public int InternalMethod_723(T92 InternalParameter_564)
        {
            if (InternalField_445.TryGetValue(InternalParameter_564, out int InternalVar_1))
            {
                return InternalVar_1;
            }

            return -1;
        }

        public void Clear()
        {
            InternalField_444.Clear();
            InternalField_445.Clear();
        }

        public void CopyTo(T92[] array, int arrayIndex)
        {
            InternalField_444.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T92> GetEnumerator()
        {
            return InternalField_444.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)InternalField_444).GetEnumerator();
        }

        public InternalType_153(IEqualityComparer<T92> InternalParameter_565)
        {
            InternalField_445 = new Dictionary<T92, int>(InternalParameter_565);
            InternalField_444 = new List<T92>();
        }

        public InternalType_153(int InternalParameter_566 = 4)
        {
            InternalField_445 = new Dictionary<T92, int>(InternalParameter_566);
            InternalField_444 = new List<T92>(InternalParameter_566);
        }

        public InternalType_153() : this(InternalParameter_566: 4) { }
    }
}

