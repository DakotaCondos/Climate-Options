using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    internal static class InternalType_213
    {
        public static Vector3 InternalMethod_1043(this Vector3 InternalParameter_1055, Vector3 InternalParameter_1056, float InternalParameter_1057 = 0, bool InternalParameter_1058 = true)
        {
            if (!InternalParameter_1058)
            {
                return new Vector3(InternalParameter_1055.x / InternalParameter_1056.x,
                                   InternalParameter_1055.y / InternalParameter_1056.y,
                                   InternalParameter_1055.z / InternalParameter_1056.z);
            }

            return new Vector3(InternalParameter_1056.x == 0 ? InternalParameter_1057 : InternalParameter_1055.x / InternalParameter_1056.x,
                               InternalParameter_1056.y == 0 ? InternalParameter_1057 : InternalParameter_1055.y / InternalParameter_1056.y,
                               InternalParameter_1056.z == 0 ? InternalParameter_1057 : InternalParameter_1055.z / InternalParameter_1056.z);
        }
    }

    internal static class InternalType_214
    {
        public static Unity.Mathematics.int3 InternalMethod_1044(this Vector3Int InternalParameter_1059)
        {
            return new Unity.Mathematics.int3(InternalParameter_1059.x, InternalParameter_1059.y, InternalParameter_1059.z);
        }
    }
}
