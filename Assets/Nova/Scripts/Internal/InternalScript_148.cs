using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal static class InternalType_289
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1291(ref this InternalType_80 InternalParameter_1356)
        {
            InternalParameter_1356.InternalField_267.InternalMethod_1294();
            InternalParameter_1356.InternalField_268.InternalField_345.InternalMethod_1296();
            InternalParameter_1356.InternalField_269.InternalField_334.InternalMethod_1295();
            InternalParameter_1356.InternalField_270.InternalField_339.InternalMethod_1295();
            InternalParameter_1356.InternalField_3412.InternalField_3414 = math.clamp(InternalParameter_1356.InternalField_3412.InternalField_3414, -360f, 360f);
            InternalParameter_1356.InternalField_3412.InternalField_3415 = math.clamp(InternalParameter_1356.InternalField_3412.InternalField_3415, -360f, 360f);
            InternalParameter_1356.InternalField_271.InternalField_274.InternalField_3428 = math.max(InternalParameter_1356.InternalField_271.InternalField_274.InternalField_3428, .01f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1292(ref this InternalType_82 InternalParameter_1357)
        {
            InternalParameter_1357.InternalField_278.InternalMethod_1294();
            InternalParameter_1357.InternalField_279.InternalMethod_1294();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void InternalMethod_1293(ref this InternalType_73 InternalParameter_1358)
        {
            InternalParameter_1358.InternalField_241 = math.saturate(InternalParameter_1358.InternalField_241);
            InternalParameter_1358.InternalField_242 = math.saturate(InternalParameter_1358.InternalField_242);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1294(ref this InternalType_45 InternalParameter_1359)
        {
            if (InternalParameter_1359.InternalField_146 == InternalType_59.InternalField_201)
            {
                InternalParameter_1359.InternalField_145 = math.max(InternalParameter_1359.InternalField_145, 0);
            }
            else
            {
                InternalParameter_1359.InternalField_145 = math.clamp(InternalParameter_1359.InternalField_145, 0, 1f);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1295(ref this InternalType_45 InternalParameter_1360)
        {
            InternalParameter_1360.InternalField_145 = math.max(InternalParameter_1360.InternalField_145, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InternalMethod_1296(ref this InternalType_48 InternalParameter_1361)
        {
            InternalParameter_1361.InternalProperty_105 = math.max(InternalParameter_1361.InternalProperty_105, 0);
        }
    }
}

