using System.Collections.Generic;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    internal static class InternalType_198
    {
        public static void InternalMethod_987<U, T>(this IEnumerable<U> InternalParameter_956, List<T> InternalParameter_957, bool InternalParameter_958 = false) where T : U
        {
            if (!InternalParameter_958)
            {
                InternalParameter_957.Clear();
            }

            foreach (U InternalVar_1 in InternalParameter_956)
            {
                T InternalVar_2 = (T)InternalVar_1;

                if (InternalVar_2 == null)
                {
                    continue;
                }

                InternalParameter_957.Add(InternalVar_2);
            }
        }
    }
}
