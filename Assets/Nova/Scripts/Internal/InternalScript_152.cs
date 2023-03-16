using AOT;
using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    [BurstCompile]
    internal struct InternalType_298
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_355 InternalField_969;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_350 InternalField_970;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_347 InternalField_971;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_351 InternalField_972;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_346 InternalField_973;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_345 InternalField_974;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_370 InternalField_975;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_164<InternalType_131>> InternalField_1765;

        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public bool InternalField_976;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_133 InternalField_977;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_131 InternalField_978;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_71 InternalField_979;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_353 InternalField_980;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_73 InternalField_981;

        private void InternalMethod_1328()
        {
            InternalType_299<InternalType_71> InternalVar_1 = new InternalType_299<InternalType_71>(ref InternalField_979);
            switch (InternalField_979.InternalField_234)
            {
                case InternalType_72.InternalField_237:
                    InternalVar_1.InternalField_984 = InternalField_970.InternalMethod_966(InternalField_977, ref InternalField_980.InternalField_1229);
                    break;
                case InternalType_72.InternalField_239:
                    InternalVar_1.InternalField_984 = InternalField_972.InternalMethod_1682(InternalField_977, ref InternalField_980.InternalField_1230);
                    break;
                case InternalType_72.InternalField_238:
                    InternalVar_1.InternalField_984 = InternalField_971.InternalMethod_1005(InternalField_977);
                    break;
            }

            InternalField_973.InternalMethod_2951(InternalField_977, ref InternalField_981);

            InternalField_969.InternalField_1239.Add(InternalVar_1);
            InternalField_969.InternalField_1234.InternalMethod_751(InternalField_969.InternalField_1241.InternalMethod_1025());
            InternalField_969.InternalField_1233.InternalMethod_751(default);
            InternalField_969.InternalField_1237.InternalMethod_751(default);
            InternalField_969.InternalField_1238.InternalMethod_751(default);
            InternalField_969.InternalField_1232.InternalMethod_751(default);
            InternalField_969.InternalField_1235.InternalMethod_751(InternalType_643.InternalField_1148);
            InternalField_969.InternalField_1236.InternalMethod_751(InternalField_969.InternalField_1240.InternalMethod_1246());

            InternalField_975.InternalField_1286.InternalMethod_837(InternalField_978);

            if (InternalField_976 && !InternalField_974.InternalField_1187.ContainsKey(InternalField_978))
            {
                InternalField_974.InternalMethod_1507(InternalField_978);
            }
        }

        private void InternalMethod_1329()
        {
            InternalType_299<InternalType_71> InternalVar_1 = InternalField_969.InternalField_1239[InternalField_977];

            switch (InternalVar_1.InternalField_983.InternalField_234)
            {
                case InternalType_72.InternalField_237:
                    InternalMethod_1330<InternalType_80, InternalType_350>(ref InternalVar_1, ref InternalField_970);
                    break;
                case InternalType_72.InternalField_238:
                    InternalMethod_1330<InternalType_79, InternalType_347>(ref InternalVar_1, ref InternalField_971);
                    break;
                case InternalType_72.InternalField_239:
                    InternalMethod_1330<InternalType_82, InternalType_351>(ref InternalVar_1, ref InternalField_972);
                    break;
            }

            InternalField_973.InternalMethod_1518(InternalField_977);

            if (InternalField_977 != InternalField_969.InternalField_1239.Length - 1)
            {
                InternalType_299<InternalType_71> InternalVar_2 = InternalField_969.InternalField_1239[InternalField_969.InternalField_1239.Length - 1];
                switch (InternalVar_2.InternalField_983.InternalField_234)
                {
                    case InternalType_72.InternalField_237:
                        InternalField_970.InternalMethod_1533(InternalVar_2.InternalField_984, InternalField_977);
                        break;
                    case InternalType_72.InternalField_239:
                        InternalField_972.InternalMethod_1543(InternalVar_2.InternalField_984, InternalField_977);
                        break;
                    case InternalType_72.InternalField_238:
                        InternalField_971.InternalMethod_1523(InternalVar_2.InternalField_984, InternalField_977);
                        break;
                }
            }

            InternalField_969.InternalField_1239.RemoveAtSwapBack(InternalField_977);
            InternalField_969.InternalField_1235.InternalMethod_749(InternalField_977);
            InternalField_969.InternalField_1233.InternalMethod_749(InternalField_977);
            InternalField_969.InternalField_1237.InternalMethod_749(InternalField_977);
            InternalField_969.InternalField_1238.InternalMethod_749(InternalField_977);
            InternalField_969.InternalField_1241.InternalMethod_1029(ref InternalField_969.InternalField_1234.InternalMethod_748(InternalField_977));
            InternalField_969.InternalField_1234.InternalMethod_749(InternalField_977);
            InternalField_969.InternalField_1232.InternalMethod_749(InternalField_977);
            InternalField_969.InternalField_1240.InternalMethod_1245(InternalField_969.InternalField_1236[InternalField_977]);
            InternalField_969.InternalField_1236.InternalMethod_749(InternalField_977);
        }

        private void InternalMethod_1330<T, TStore>(ref InternalType_299<InternalType_71> InternalParameter_1403, ref TStore InternalParameter_1404)
            where TStore : struct, InternalType_343<T, InternalType_348>
        {
            if (InternalParameter_1404.InternalMethod_1505(InternalField_978, InternalParameter_1403.InternalField_984, out InternalType_133 InternalVar_1))
            {
                InternalField_969.InternalField_1239.ElementAt(InternalVar_1).InternalField_984 = InternalParameter_1403.InternalField_984;
            }
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_1331(void* InternalParameter_1405)
        {
            UnsafeUtility.AsRef<InternalType_298>(InternalParameter_1405).InternalMethod_1328();
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_1332(void* InternalParameter_1406)
        {
            UnsafeUtility.AsRef<InternalType_298>(InternalParameter_1406).InternalMethod_1329();
        }
        #endregion

        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                        public InternalType_342 InternalField_982;

        private void InternalMethod_1333()
        {
            InternalMethod_1335();
            InternalMethod_1336();
            InternalMethod_1334();

            InternalField_970.InternalMethod_1532(ref InternalField_982);
            InternalField_972.InternalMethod_1542(ref InternalField_982);
            InternalField_971.InternalMethod_1519(ref InternalField_982);
            InternalField_973.InternalMethod_1513(ref InternalField_982);
        }

        private void InternalMethod_1334()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_982.InternalField_1184.InternalField_1284.InternalProperty_240; ++InternalVar_1)
            {
                InternalType_131 InternalVar_2 = InternalField_982.InternalField_1184.InternalField_1284[InternalVar_1];
                if (!InternalField_982.InternalField_1181.TryGetValue(InternalVar_2, out InternalType_133 InternalVar_3))
                {
                    continue;
                }

                InternalType_131 InternalVar_4 = InternalField_982.InternalField_1182[InternalVar_3].InternalField_589;
                InternalMethod_3681(InternalVar_4);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalMethod_3681(InternalType_131 InternalParameter_3473)
        {
            InternalField_982.InternalField_1184.InternalField_1283.InternalMethod_837(InternalParameter_3473);

            if (!InternalField_1765.TryGetValue(InternalParameter_3473, out InternalType_164<InternalType_131> InternalVar_1))
            {
                return;
            }

            for (int InternalVar_2 = 0; InternalVar_2 < InternalVar_1.InternalProperty_216; ++InternalVar_2)
            {
                InternalMethod_3681(InternalVar_1[InternalVar_2]);
            }
        }

        private void InternalMethod_1335()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_982.InternalField_1184.InternalField_1286.InternalProperty_240; ++InternalVar_1)
            {
                if (!InternalField_982.InternalField_1181.TryGetValue(InternalField_982.InternalField_1184.InternalField_1286[InternalVar_1], out InternalType_133 InternalVar_2))
                {
                    continue;
                }

                InternalField_982.InternalField_1184.InternalField_1282.InternalMethod_837(InternalVar_2);
            }
        }

        private void InternalMethod_1336()
        {
            for (int InternalVar_1 = 0; InternalVar_1 < InternalField_982.InternalField_1184.InternalField_1285.InternalProperty_240; ++InternalVar_1)
            {
                if (!InternalField_982.InternalField_1181.TryGetValue(InternalField_982.InternalField_1184.InternalField_1285[InternalVar_1], out InternalType_133 InternalVar_2))
                {
                    continue;
                }

                InternalType_131 InternalVar_3 = InternalField_982.InternalField_1182[InternalVar_2].InternalField_589;
                InternalField_982.InternalField_1184.InternalField_1282.InternalMethod_837(InternalVar_2);
                InternalField_982.InternalField_1184.InternalField_1283.InternalMethod_837(InternalVar_3);
            }
        }

        [BurstCompile]
        [MonoPInvokeCallback(typeof(InternalType_175))]
        public static unsafe void InternalMethod_1337(void* InternalParameter_1407)
        {
            UnsafeUtility.AsRef<InternalType_298>(InternalParameter_1407).InternalMethod_1333();
        }
        #endregion
    }
}

