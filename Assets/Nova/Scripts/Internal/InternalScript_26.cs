using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Collections.Generic;

namespace Nova.InternalNamespace_0.InternalNamespace_2
{
    internal abstract class InternalType_129<T9,T10> : InternalType_130, InternalType_132
        where T9 : InternalType_129<T9, T10>
        where T10 : InternalType_134
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static T9 InternalProperty_190 { get; private set; } = null;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Dictionary<InternalType_131, T10> InternalField_413 = new Dictionary<InternalType_131, T10>();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        protected bool InternalField_414 = false;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_191 { get; private set; } = 0;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public abstract bool InternalProperty_193 { get; }

        protected abstract void InternalMethod_615(T10 InternalParameter_499);
        protected abstract void InternalMethod_616(InternalType_131 InternalParameter_500, InternalType_133 InternalParameter_501);

        protected abstract void InternalMethod_617(T10 InternalParameter_502);
        protected abstract void InternalMethod_618(T10 InternalParameter_503);
        protected abstract void InternalMethod_619(T10 InternalParameter_504, T10 InternalParameter_505);

        protected abstract bool InternalMethod_620(InternalType_131 InternalParameter_506, out InternalType_133 InternalParameter_507);
        protected abstract InternalType_131 InternalMethod_621(InternalType_133 InternalParameter_508);

        public abstract void InternalMethod_635();

        public void InternalMethod_622(T10 InternalParameter_509)
        {
            if (!InternalField_414)
            {
                return;
            }

            if (!InternalProperty_190.InternalMethod_628(InternalParameter_509.InternalProperty_195))
            {
                return;
            }

            InternalProperty_190.InternalMethod_617(InternalParameter_509);

            InternalType_180.InternalMethod_849();
        }

        public void InternalMethod_623(T10 InternalParameter_510)
        {
            if (!InternalField_414)
            {
                return;
            }

            if (!InternalProperty_190.InternalMethod_628(InternalParameter_510.InternalProperty_195))
            {
                return;
            }

            InternalProperty_190.InternalMethod_618(InternalParameter_510);
        }

        public void InternalMethod_624(InternalType_131 InternalParameter_511, T10 InternalParameter_512)
        {
            if (!InternalField_414)
            {
                return;
            }

            if (!InternalProperty_190.InternalField_413.TryGetValue(InternalParameter_511, out T10 InternalVar_1))
            {
                return;
            }

            InternalProperty_190.InternalMethod_619(InternalVar_1, InternalParameter_512);
        }

        public bool InternalMethod_625(T10 InternalParameter_513)
        {
            if (!InternalField_414)
            {
                return false;
            }
            return InternalParameter_513.InternalProperty_196.InternalProperty_194;
        }

        public bool InternalMethod_628(InternalType_131 InternalParameter_516)
        {
            if (!InternalField_414)
            {
                return false;
            }

            return InternalField_413.ContainsKey(InternalParameter_516);
        }

        
        public void InternalMethod_626(T10 InternalParameter_514)
        {
            if (!InternalField_414)
            {
                return;
            }

            if (!InternalParameter_514.InternalProperty_195.InternalProperty_192)
            {
                return;
            }

            if (InternalMethod_628(InternalParameter_514.InternalProperty_195))
            {
                return;
            }


            InternalField_413.Add(InternalParameter_514.InternalProperty_195, InternalParameter_514);
            InternalParameter_514.InternalMethod_642(InternalField_413.Count - 1);
            {
                InternalMethod_615(InternalParameter_514);
            }
            InternalProperty_191 += 1;

            InternalType_180.InternalMethod_849();
        }

        public void InternalMethod_627(T10 InternalParameter_515)
        {
            InternalType_131 InternalVar_1 = InternalParameter_515.InternalProperty_195;

            if (!InternalField_414 || !InternalMethod_628(InternalVar_1))
            {
                return;
            }

            if (!InternalMethod_620(InternalVar_1, out InternalType_133 InternalVar_2))
            {
                return;
            }

            {
                InternalMethod_616(InternalVar_1, InternalVar_2);
            }

            InternalParameter_515.InternalMethod_642(InternalType_133.InternalField_418);
            InternalField_413.Remove(InternalVar_1);

            if (InternalVar_2 < InternalField_413.Count)
            {
                if (InternalField_413.TryGetValue(InternalMethod_621(InternalVar_2), out InternalParameter_515))
                {
                    InternalParameter_515.InternalMethod_642(InternalVar_2);
                }
            }

            InternalProperty_191 -= 1;

            InternalType_180.InternalMethod_849();
        }

        public virtual void InternalMethod_702()
        {
            InternalProperty_190 = (T9)this;
            InternalField_414 = true;
        }

        public virtual void Dispose()
        {
            InternalProperty_190 = null;
            InternalField_414 = false;

            foreach (var InternalVar_1 in InternalField_413)
            {
                if (InternalVar_1.Value == null)
                {
                    continue;
                }

                InternalVar_1.Value.InternalMethod_642(InternalType_133.InternalField_418);
            }
        }
    }
}

