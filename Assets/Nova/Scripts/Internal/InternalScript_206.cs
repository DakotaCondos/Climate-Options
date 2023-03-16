using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_378 : InternalType_147, InternalType_150
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<InternalType_364> InternalField_1308;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<InternalType_172<InternalType_364, int>> InternalField_1309;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<float3> InternalField_1310;

        public void InternalMethod_1593(int InternalParameter_1722)
        {
            InternalField_1308.InternalProperty_216 = InternalParameter_1722;
        }

        public void InternalMethod_705()
        {
            InternalField_1308.InternalMethod_705();
            InternalField_1309.InternalMethod_705();
            InternalField_1310.InternalMethod_705();
        }

        public void Dispose()
        {
            InternalField_1308.Dispose();
            InternalField_1309.Dispose();
            InternalField_1310.Dispose();
        }

        public void InternalMethod_702()
        {
            InternalField_1308.InternalMethod_702();
            InternalField_1309.InternalMethod_702();
            InternalField_1310.InternalMethod_702();
        }
    }

    
    internal struct InternalType_379 : InternalType_147, InternalType_150
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float4x4 InternalField_1311;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public float4x4 InternalField_1312;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_1313;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_164<InternalType_288> InternalField_1314;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_378 InternalField_1315;

        public void InternalMethod_1594()
        {
            InternalField_1315.InternalMethod_1593(InternalField_1314.InternalProperty_216);
        }

        public void InternalMethod_705()
        {
            InternalField_1314.InternalMethod_705();
            InternalField_1315.InternalMethod_705();
        }

        public void Dispose()
        {
            InternalField_1314.Dispose();
            InternalField_1315.Dispose();
        }

        public void InternalMethod_702()
        {
            InternalField_1314.InternalMethod_702();
            InternalField_1315.InternalMethod_702();
        }
    }

    
    internal struct InternalType_380 : InternalType_147, InternalType_150
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_162<InternalType_358, InternalType_379> InternalField_1316;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_164<InternalType_379> InternalField_1317;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_334
        {
            get => InternalField_1316.InternalProperty_216;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_335
        {
            get
            {
                int InternalVar_1 = 0;
                for (int InternalVar_2 = 0; InternalVar_2 < InternalField_1316.InternalProperty_216; ++InternalVar_2)
                {
                    InternalVar_1 += InternalField_1316.InternalMethod_758(InternalVar_2).InternalField_1314.InternalProperty_216;
                }
                return InternalVar_1;
            }
        }

        public void InternalMethod_1597()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_1316.InternalProperty_216; ++InternalVar_1)
            {
                InternalField_1316.InternalMethod_758(InternalVar_1).InternalMethod_1594();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InternalMethod_1598(InternalType_358 InternalParameter_1723, InternalType_288 InternalParameter_1724)
        {
            InternalField_1316.InternalMethod_758(InternalParameter_1723).InternalField_1314.InternalMethod_785(InternalParameter_1724);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public InternalType_358 InternalMethod_1599(ref float4x4 InternalParameter_1725, ref float4x4 InternalParameter_1726)
        {
            InternalType_358 InternalVar_1 = InternalField_1316.InternalProperty_216;

            if (!InternalField_1317.InternalMethod_792(out InternalType_379 InternalVar_2))
            {
                InternalVar_2.InternalMethod_702();
            }

            InternalVar_2.InternalField_1312 = InternalParameter_1725;
            InternalVar_2.InternalField_1311 = InternalParameter_1726;
            InternalField_1316.InternalMethod_761(InternalVar_2);
            return InternalVar_1;
        }

        public void InternalMethod_705()
        {
            InternalField_1316.InternalMethod_766(ref InternalField_1317);
        }

        public void Dispose()
        {
            InternalField_1316.InternalMethod_765();
            InternalField_1317.InternalMethod_776();
        }

        public void InternalMethod_702()
        {
            InternalField_1316.InternalMethod_703();
            InternalField_1317.InternalMethod_702();
        }
    }

    internal static class InternalType_381
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool InternalMethod_1004(this ref NativeList<InternalType_131> InternalParameter_988, ref NovaHashMap<InternalType_131, InternalType_380> InternalParameter_978, ref int InternalParameter_977, out InternalType_379 InternalParameter_1739, out InternalType_131 InternalParameter_1738)
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalParameter_988.Length; ++InternalVar_1)
            {
                InternalParameter_1738 = InternalParameter_988[InternalVar_1];
                InternalType_380 InternalVar_2 = InternalParameter_978[InternalParameter_1738];

                if (InternalParameter_977 >= InternalVar_2.InternalProperty_335)
                {
                    InternalParameter_977 -= InternalVar_2.InternalProperty_335;
                    continue;
                }

                for (int InternalVar_3 = 0; InternalVar_3 < InternalVar_2.InternalProperty_334; ++InternalVar_3)
                {
                    InternalParameter_1739 = InternalVar_2.InternalField_1316.InternalMethod_758(InternalVar_3);
                    if (InternalParameter_977 >= InternalParameter_1739.InternalField_1314.InternalProperty_216)
                    {
                        InternalParameter_977 -= InternalParameter_1739.InternalField_1314.InternalProperty_216;
                        continue;
                    }

                    return true;
                }
            }

            InternalParameter_1739 = default;
            InternalParameter_1738 = default;
            return false;
        }
    }
}


