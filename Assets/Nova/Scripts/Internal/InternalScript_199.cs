using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_315 : InternalType_147
    {
        public struct InternalType_316 : IEquatable<InternalType_316>
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_1059;
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public int InternalField_1060;

            public bool Equals(InternalType_316 other)
            {
                return InternalField_1059 == other.InternalField_1059 && InternalField_1060 == other.InternalField_1060;
            }

            public override string ToString()
            {
                return $"Total: {InternalField_1060}, Statie: {InternalField_1059}";
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_103, InternalType_311> InternalField_1042;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_310, InternalType_321> InternalField_1043;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_310, InternalType_316> InternalField_1044;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_310, InternalType_282> InternalField_1045;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_282, int> InternalField_1046;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_310, InternalType_314> InternalField_1047;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_282> InternalField_1048;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_282, InternalType_313> InternalField_1049;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_321, InternalType_282> InternalField_1050;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_313> InternalField_1051;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeReference<InternalType_172<InternalType_103, InternalType_282>> InternalField_1052;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NovaHashMap<int, InternalType_317> InternalField_1053;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeReference<bool> InternalField_1054;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_1055;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalField_1056;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_957
        {
            get
            {
                if (!InternalField_1055)
                {
                    if (!InternalField_1054.Value && InternalType_24.InternalProperty_945.InternalMethod_554(InternalType_116.InternalField_2767))
                    {
                        Debug.LogWarning($"TextureArrays not supported on platform. Static images will not be able to be batched, falling back to dynamic. {InternalType_178.InternalField_484}");
                        InternalField_1054.Value = true;
                    }
                    return false;
                }

                if (!InternalField_1056)
                {
                    if (!InternalField_1054.Value && InternalType_24.InternalProperty_945.InternalMethod_554(InternalType_116.InternalField_2767))
                    {
                        Debug.LogWarning($"A bug with Texture2DArrays when the \"Texture Quality\" setting is not full resolution prevents static images from working properly. Falling back to dynamic. {InternalType_178.InternalField_484}");
                        InternalField_1054.Value = true;
                    }
                    return false;
                }

                return true;
            }
        }
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public InternalType_359 InternalField_1057;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_360 InternalField_1058;

        public InternalType_103 InternalMethod_1424() => InternalField_1052.InternalMethod_1030().InternalField_462++;
        public InternalType_282 InternalMethod_1425()
        {
            InternalType_282 InternalVar_1 = InternalField_1052.InternalMethod_1030().InternalField_463++;
            InternalField_1048.Add(InternalVar_1);
            return InternalVar_1;
        }

        public bool InternalMethod_1426(GraphicsFormat InternalParameter_1514, out InternalType_317 InternalParameter_1515)
        {
            InternalParameter_1515 = default;
            return InternalField_1053.TryGetValue((int)InternalParameter_1514, out InternalParameter_1515);
        }

        public void InternalMethod_1427(GraphicsFormat InternalParameter_1516, InternalType_317 InternalParameter_1517)
        {
            InternalField_1053[(int)InternalParameter_1516] = InternalParameter_1517;
        }

        public void InternalMethod_702()
        {
            InternalField_1042.Init(InternalType_178.InternalField_3012);
            InternalField_1043.Init(InternalType_178.InternalField_3012);
            InternalField_1053.Init(InternalType_178.InternalField_3012);
            InternalField_1044.Init(InternalType_178.InternalField_3012);

            InternalField_1045.Init(InternalType_178.InternalField_3012);
            InternalField_1046.Init(InternalType_178.InternalField_3012);
            InternalField_1047.Init(InternalType_178.InternalField_3012);
            InternalField_1050.Init(InternalType_178.InternalField_3012);

            InternalField_1049.Init(InternalType_178.InternalField_3012);
            InternalField_1051.InternalMethod_1020(InternalType_178.InternalField_3012);
            InternalField_1048.InternalMethod_1020(InternalType_178.InternalField_3012);

            InternalField_1052.InternalMethod_1033(new InternalType_172<InternalType_103, InternalType_282>(0, 0));
            InternalField_1054.InternalMethod_1033(false);

            InternalField_1055 = SystemInfo.supports2DArrayTextures;
            InternalField_1056 = InternalType_271.InternalProperty_747 == 0;

            InternalField_1057 = new InternalType_359(ref InternalField_1042, ref InternalField_1043);
            InternalField_1058 = new InternalType_360(ref InternalField_1045, ref InternalField_1047, ref InternalField_1046);
        }

        public void Dispose()
        {
            InternalField_1042.Dispose();
            InternalField_1043.Dispose();
            InternalField_1053.Dispose();
            InternalField_1044.Dispose();

            InternalField_1045.Dispose();
            InternalField_1046.Dispose();
            InternalField_1047.Dispose();
            InternalField_1050.Dispose();

            InternalField_1048.Dispose();
            InternalField_1052.Dispose();
            InternalField_1054.Dispose();

            using (var packs = InternalField_1049.GetValueArray(Allocator.Temp))
            {
                for (int InternalVar_1 = 0; InternalVar_1 < packs.Length; ++InternalVar_1)
                {
                    packs[InternalVar_1].Dispose();
                }
            }

            InternalField_1049.Clear();
            InternalField_1049.Dispose();
            InternalField_1051.InternalMethod_1022();
        }
    }
}

