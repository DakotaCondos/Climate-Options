using System;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    internal static class InternalType_194
    {
        public static void InternalMethod_967<T>(this T[] InternalParameter_926, T InternalParameter_927)
        {
            int InternalVar_1 = InternalParameter_926.Length;

            if (InternalVar_1 == 0)
            {
                return;
            }

            InternalParameter_926[0] = InternalParameter_927;

            int InternalVar_2 = 1;
            while (InternalVar_2 <= InternalVar_1 / 2)
            {
                Array.Copy(InternalParameter_926, 0, InternalParameter_926, InternalVar_2, InternalVar_2);
                InternalVar_2 *= 2;
            }

            Array.Copy(InternalParameter_926, 0, InternalParameter_926, InternalVar_2, InternalVar_1 - InternalVar_2);
        }
    }
}

