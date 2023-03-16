using Nova.InternalNamespace_0.InternalNamespace_5;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal static class InternalType_330
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InternalMethod_1479(ref this InternalType_80 InternalParameter_1563, float InternalParameter_1564)
        {
            float InternalVar_1 = InternalParameter_1563.InternalField_267.InternalMethod_1488(ref InternalParameter_1564);
            return math.clamp(InternalVar_1, 0, InternalParameter_1564);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InternalMethod_1480(ref this InternalType_82 InternalParameter_1565, float InternalParameter_1566)
        {
            float InternalVar_1 = InternalParameter_1565.InternalField_278.InternalMethod_1488(ref InternalParameter_1566);
            return math.clamp(InternalVar_1, 0, InternalParameter_1566);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InternalMethod_1481(ref this InternalType_82 InternalParameter_1567, float InternalParameter_1568, float InternalParameter_1569)
        {
            float InternalVar_1 = math.min(0.5f * InternalParameter_1568, InternalParameter_1569);
            float InternalVar_2 = InternalParameter_1567.InternalField_279.InternalMethod_1488(ref InternalVar_1);
            return math.clamp(InternalVar_2, 0, InternalVar_1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InternalMethod_1482(ref this InternalType_106 InternalParameter_1570, float InternalParameter_1571)
        {
            float InternalVar_1 = InternalParameter_1570.InternalField_334.InternalMethod_1488(ref InternalParameter_1571);

            float InternalVar_2 = float.PositiveInfinity;
            if (InternalParameter_1570.InternalField_336 == InternalType_111.InternalField_361)
            {
                InternalVar_2 = InternalParameter_1571;
            }
            else if (InternalParameter_1570.InternalField_336 == InternalType_111.InternalField_360)
            {
                InternalVar_2 = 2f * InternalParameter_1571;
            }

            return math.clamp(InternalVar_1, 0, InternalVar_2);
        }

        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private static readonly float2 InternalField_2599 = new float2(float.NegativeInfinity, 0f);

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InternalMethod_1483(ref this InternalType_107 InternalParameter_1572, float InternalParameter_1573)
        {
            float2 InternalVar_1 = new float2(
                InternalParameter_1572.InternalField_338.InternalMethod_1488(ref InternalParameter_1573),
                InternalParameter_1572.InternalField_339.InternalMethod_1488(ref InternalParameter_1573));

            if (InternalParameter_1572.InternalField_342 == InternalType_114.InternalField_368)
            {
                return math.max(InternalVar_1, InternalField_2599);
            }
            else
            {
                return math.clamp(InternalVar_1, InternalField_2599, InternalParameter_1573);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InternalMethod_3394(ref this InternalType_486 InternalParameter_2397, ref float2 InternalParameter_3006)
        {
            return InternalParameter_2397.InternalField_3413.InternalMethod_1487(ref InternalParameter_3006) * new float2(1.01f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InternalMethod_1484(ref this InternalType_108 InternalParameter_1574, ref float2 InternalParameter_1575)
        {
            return InternalParameter_1574.InternalField_345.InternalMethod_1487(ref InternalParameter_1575);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InternalMethod_1485(ref this InternalType_108 InternalParameter_1576, ref float2 InternalParameter_1577)
        {
            return InternalParameter_1576.InternalField_344.InternalMethod_1487(ref InternalParameter_1577);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InternalMethod_1486(ref this InternalType_107 InternalParameter_1578, ref float2 InternalParameter_1579)
        {
            return InternalParameter_1578.InternalField_340.InternalMethod_1487(ref InternalParameter_1579);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float2 InternalMethod_1487(ref this InternalType_48 InternalParameter_1580, ref float2 InternalParameter_1581)
        {
            return new float2(
               InternalParameter_1580.InternalField_156.InternalMethod_1488(ref InternalParameter_1581.x),
               InternalParameter_1580.InternalField_157.InternalMethod_1488(ref InternalParameter_1581.y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float InternalMethod_1488(ref this InternalType_45 InternalParameter_1582, ref float InternalParameter_1583)
        {
            return InternalParameter_1582.InternalField_146 == InternalType_59.InternalField_201 ? InternalParameter_1582.InternalField_145 : InternalParameter_1582.InternalField_145 * InternalParameter_1583;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1489(this ref InternalType_80 InternalParameter_1584, ref float2 InternalParameter_1585, float InternalParameter_1586)
        {
            if (InternalParameter_1584.InternalField_271.InternalField_274.InternalField_367 == InternalType_112.InternalField_363)
            {
                float InternalVar_1 = InternalParameter_1585.x / InternalParameter_1585.y;
                float InternalVar_2 = InternalParameter_1586 / InternalVar_1;
                if (InternalVar_2 > 1)
                {
                    InternalParameter_1585.y /= InternalVar_2;
                }
                else
                {
                    InternalParameter_1585.x *= InternalVar_2;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1490(ref this InternalType_106 InternalParameter_1587, float InternalParameter_1588, float InternalParameter_1589, ref float2 InternalParameter_1590, out float InternalParameter_1591, out float InternalParameter_1592)
        {
            InternalParameter_1591 = 0f;
            InternalParameter_1592 = 0f;
            switch (InternalParameter_1587.InternalField_336)
            {
                case InternalType_111.InternalField_361:
                    InternalParameter_1591 = math.max(0, InternalParameter_1588 - InternalParameter_1589);
                    InternalParameter_1592 = InternalParameter_1588;
                    break;
                case InternalType_111.InternalField_359:
                    InternalParameter_1590 += 2f * InternalParameter_1589;
                    InternalParameter_1591 = InternalParameter_1588;
                    InternalParameter_1592 = InternalParameter_1588 + InternalParameter_1589;
                    break;
                case InternalType_111.InternalField_360:
                    InternalParameter_1590 += InternalParameter_1589;
                    float InternalVar_1 = .5f * InternalParameter_1589;
                    InternalParameter_1591 = math.max(0, InternalParameter_1588 - InternalVar_1);
                    InternalParameter_1592 = InternalParameter_1588 + InternalVar_1;
                    break;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InternalMethod_1491(ref this InternalType_106 InternalParameter_1593, ref float InternalParameter_1594, ref float2 InternalParameter_1595, float InternalParameter_1596)
        {
            switch (InternalParameter_1593.InternalField_336)
            {
                case InternalType_111.InternalField_359:
                    InternalParameter_1595 += 2f * InternalParameter_1596;
                    InternalParameter_1594 = math.select(0f, InternalParameter_1594 + InternalParameter_1596, InternalParameter_1594 > InternalType_187.InternalField_494);
                    break;
                case InternalType_111.InternalField_360:
                    InternalParameter_1595 += InternalParameter_1596;
                    float InternalVar_1 = .5f * InternalParameter_1596;
                    InternalParameter_1594 = math.select(0f, InternalParameter_1594 + InternalVar_1, InternalParameter_1594 > InternalType_187.InternalField_494);
                    break;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 InternalMethod_2606(ref this InternalType_79 InternalParameter_2746, bool2 InternalParameter_2743)
        {
            return math.select(float2.zero, -InternalParameter_2746.InternalField_262.InternalMethod_1362().xy, InternalParameter_2743);
        }
    }
}

