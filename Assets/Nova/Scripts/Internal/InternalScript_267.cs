using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace Nova.InternalNamespace_0.InternalNamespace_5
{
    internal static class InternalType_182
    {
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InternalMethod_851(float3 InternalParameter_700, float3 InternalParameter_701, float3 InternalParameter_702, float3 InternalParameter_703, float3 InternalParameter_704, float3 InternalParameter_705)
        {
            float3 InternalVar_1 = InternalType_187.InternalField_526 * (InternalParameter_703 - InternalParameter_701) * InternalParameter_705;
            float3 InternalVar_2 = InternalType_187.InternalMethod_889(-InternalParameter_705);
            float3 InternalVar_3 = InternalParameter_702 + InternalParameter_704;

            float3 InternalVar_4 = InternalVar_2 * InternalParameter_700;
            return InternalVar_1 + InternalVar_4 + InternalVar_3;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InternalMethod_852(float3 InternalParameter_706, float3 InternalParameter_707, float3 InternalParameter_708, float3 InternalParameter_709, float3 InternalParameter_710, float3 InternalParameter_711)
        {
            float3 InternalVar_1 = InternalType_187.InternalField_526 * (InternalParameter_709 - InternalParameter_707) * InternalParameter_711;
            float3 InternalVar_2 = InternalType_187.InternalMethod_889(-InternalParameter_711);
            float3 InternalVar_3 = InternalParameter_708 + InternalParameter_710;

            float3 InternalVar_4 = InternalParameter_706 - InternalVar_1 - InternalVar_3;
            return InternalVar_2 * InternalVar_4;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double InternalMethod_855(double InternalParameter_718, double InternalParameter_719, double InternalParameter_720, double InternalParameter_721, int InternalParameter_722)
        {
            double InternalVar_1 = InternalType_187.InternalMethod_888(-InternalParameter_722);
            double InternalVar_2 = 0.5f * (InternalParameter_720 - InternalParameter_719) * InternalParameter_722;

            double InternalVar_3 = InternalVar_1 * InternalParameter_718;
            double InternalVar_4 = InternalVar_2 + InternalParameter_721 + InternalVar_3;

            return InternalVar_4;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double InternalMethod_856(double InternalParameter_723, double InternalParameter_724, double InternalParameter_725, double InternalParameter_726, int InternalParameter_727)
        {
            double InternalVar_1 = InternalType_187.InternalMethod_888(-InternalParameter_727);
            double InternalVar_2 = 0.5f * (InternalParameter_725 - InternalParameter_724) * InternalParameter_727;

            double InternalVar_3 = InternalParameter_723 - InternalParameter_726 - InternalVar_2;
            double InternalVar_4 = InternalVar_1 * InternalVar_3;

            return InternalVar_4;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InternalMethod_857(float InternalParameter_728, float InternalParameter_729, float InternalParameter_730, float InternalParameter_731, int InternalParameter_732)
        {
            float InternalVar_1 = InternalType_187.InternalMethod_888(-InternalParameter_732);
            float InternalVar_2 = 0.5f * (InternalParameter_730 - InternalParameter_729) * InternalParameter_732;

            float InternalVar_3 = InternalVar_1 * InternalParameter_728;
            float InternalVar_4 = InternalVar_2 + InternalParameter_731 + InternalVar_3;

            return InternalVar_4;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float InternalMethod_858(float InternalParameter_733, float InternalParameter_734, float InternalParameter_735, float InternalParameter_736, int InternalParameter_737)
        {
            float InternalVar_1 = InternalType_187.InternalMethod_888(-InternalParameter_737);
            float InternalVar_2 = 0.5f * (InternalParameter_735 - InternalParameter_734) * InternalParameter_737;

            float InternalVar_3 = InternalParameter_733 - InternalParameter_736 - InternalVar_2;
            float InternalVar_4 = InternalVar_1 * InternalVar_3;

            return InternalVar_4;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_3638(InternalType_5 InternalParameter_3423, Vector3 InternalParameter_3424, out int InternalParameter_3425, out int InternalParameter_3426)
        {
            InternalParameter_3426 = 0;
            InternalParameter_3425 = -1;

            InternalType_96 InternalVar_1 = InternalParameter_3423.InternalProperty_143.InternalField_225;

            switch (InternalVar_1)
            {
                case InternalType_96.InternalField_305:
                    InternalParameter_3425 = 0;
                    break;
                case InternalType_96.InternalField_306:
                    InternalParameter_3425 = 1;
                    break;
                case InternalType_96.InternalField_307:
                    InternalParameter_3425 = 2;
                    break;
                default:
                    return false;
            }

            float InternalVar_2 = InternalType_187.InternalMethod_865(InternalParameter_3424);

            if (Mathf.Abs(InternalParameter_3424[InternalParameter_3425]) != Mathf.Abs(InternalVar_2))
            {
                return false;
            }

            InternalParameter_3426 = (int)Mathf.Sign(InternalVar_2);

            return true;
        }

        
        public static float InternalMethod_3654(InternalType_5 InternalParameter_3450, int InternalParameter_3451, int InternalParameter_3452)
        {
            InternalType_5 InternalVar_1 = InternalParameter_3450.InternalProperty_210 as InternalType_5;

            if (InternalParameter_3450.InternalProperty_210 == null)
            {
                return 0;
            }

            float InternalVar_2 = InternalParameter_3450.InternalProperty_150[InternalParameter_3451];
            float InternalVar_3 = InternalParameter_3450.InternalProperty_145[InternalParameter_3451].InternalField_153;
            float InternalVar_4 = InternalParameter_3450.InternalProperty_147.InternalProperty_139[InternalParameter_3451];

            return InternalMethod_3696(InternalVar_2, InternalVar_3, InternalVar_4, InternalVar_1, InternalParameter_3451, InternalParameter_3452);
        }

        public static float InternalMethod_3696(float InternalParameter_3503, float InternalParameter_3504, float InternalParameter_3505, InternalType_5 InternalParameter_3506, int InternalParameter_3507, int InternalParameter_3508)
        {
            float InternalVar_1 = InternalParameter_3506.InternalProperty_146.InternalProperty_139[InternalParameter_3507];
            float InternalVar_2 = InternalParameter_3506.InternalProperty_148[InternalParameter_3507];
            float InternalVar_3 = InternalVar_2 * 0.5f;
            float InternalVar_4 = InternalVar_1 - InternalVar_3;
            float InternalVar_5 = InternalVar_1 + InternalVar_3;

            float InternalVar_6 = InternalMethod_857(InternalParameter_3504, InternalParameter_3503, InternalVar_2, InternalVar_1 + InternalParameter_3505, InternalParameter_3508);

            float InternalVar_7 = InternalParameter_3503 * 0.5f;
            float InternalVar_8 = InternalVar_6 - InternalVar_7;
            float InternalVar_9 = InternalVar_6 + InternalVar_7;

            float InternalVar_10 = InternalVar_4 - InternalVar_8;
            float InternalVar_11 = InternalVar_5 - InternalVar_9;

            if (InternalVar_10 <= 0 && InternalVar_11 >= 0)
            {
                return 0;
            }

            return InternalType_187.InternalMethod_869(InternalVar_10, InternalVar_11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 InternalMethod_859(float3 InternalParameter_738, quaternion InternalParameter_739)
        {
            bool InternalVar_1 = math.all(InternalParameter_739.value == InternalType_187.InternalField_543);

            if (InternalVar_1)
            {
                return InternalParameter_738;
            }

            float3 InternalVar_2 = InternalParameter_738 * InternalType_187.InternalField_526;

            float3 InternalVar_3 = math.rotate(InternalParameter_739, new float3(InternalVar_2.x, 0, 0));
            float3 InternalVar_4 = math.rotate(InternalParameter_739, new float3(0, InternalVar_2.y, 0));
            float3 InternalVar_5 = math.rotate(InternalParameter_739, new float3(0, 0, InternalVar_2.z));

            InternalVar_2 = InternalType_187.InternalMethod_874(InternalVar_3) + InternalType_187.InternalMethod_874(InternalVar_4) + InternalType_187.InternalMethod_874(InternalVar_5);

            return InternalType_187.InternalField_532 * InternalVar_2;
        }

        public static string InternalMethod_861(int InternalParameter_742, int InternalParameter_743)
        {
            if (InternalParameter_743 == 0)
            {
                return InternalParameter_742 == 0 ? "X" : InternalParameter_742 == 1 ? "Y" : "Z";
            }

            if (InternalParameter_742 == 0) 
            {
                if (InternalParameter_743 < 0)
                {
                    return "Left";
                }

                return "Right";
            }

            if (InternalParameter_742 == 1) 
            {
                if (InternalParameter_743 < 0)
                {
                    return "Bottom";
                }

                return "Top";
            }

            if (InternalParameter_742 == 2) 
            {
                if (InternalParameter_743 < 0)
                {
                    return "Front";
                }

                return "Back";
            }

            return string.Empty;
        }

        public static string InternalMethod_862(int InternalParameter_744)
        {
            if (InternalParameter_744 == 0) 
            {
                return "Width";
            }

            if (InternalParameter_744 == 1) 
            {
                return "Height";
            }

            if (InternalParameter_744 == 2) 
            {
                return "Depth";
            }

            return string.Empty;
        }
    }
}
