using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    internal struct InternalType_275 : InternalType_147
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NativeList<InternalType_131> InternalField_877;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_164<InternalType_403>> InternalField_878;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_284> InternalField_879;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_339> InternalField_880;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_302> InternalField_881;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_373>> InternalField_882;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_288, InternalType_305>> InternalField_883;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_304, InternalType_356>> InternalField_884;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_380> InternalField_885;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_164<InternalType_383>> InternalField_886;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_164<InternalType_131>> InternalField_887;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, InternalType_162<InternalType_301, InternalType_326>> InternalField_888;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                public NovaHashMap<InternalType_131, InternalType_337> InternalField_283;

        #region 
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
                private NativeList<InternalType_164<InternalType_403>> InternalField_889;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_284> InternalField_890;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_339> InternalField_891;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_302> InternalField_892;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_162<InternalType_288, InternalType_373>> InternalField_893;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_162<InternalType_288, InternalType_305>> InternalField_894;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_162<InternalType_304, InternalType_356>> InternalField_895;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_380> InternalField_896;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_164<InternalType_383>> InternalField_897;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_164<InternalType_131>> InternalField_898;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_162<InternalType_301, InternalType_326>> InternalField_899;
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool InternalMethod_1268(InternalType_131 InternalParameter_1332) => InternalField_881.ContainsKey(InternalParameter_1332);

        public void InternalMethod_1269(InternalType_131 InternalParameter_1333)
        {
            InternalField_877.Add(InternalParameter_1333);

            InternalField_878.Add(InternalParameter_1333, InternalField_889.InternalMethod_1025());
            InternalField_879.Add(InternalParameter_1333, InternalField_890.InternalMethod_1024());
            InternalField_880.Add(InternalParameter_1333, InternalField_891.InternalMethod_1024());
            InternalField_881.Add(InternalParameter_1333, InternalField_892.InternalMethod_1024());
            InternalField_882.Add(InternalParameter_1333, InternalField_893.InternalMethod_1026());
            InternalField_883.Add(InternalParameter_1333, InternalField_894.InternalMethod_1026());
            InternalField_884.Add(InternalParameter_1333, InternalField_895.InternalMethod_1026());
            InternalField_885.Add(InternalParameter_1333, InternalField_896.InternalMethod_1024());
            InternalField_886.Add(InternalParameter_1333, InternalField_897.InternalMethod_1025());
            InternalField_887.Add(InternalParameter_1333, InternalField_898.InternalMethod_1025());
            InternalField_888.Add(InternalParameter_1333, InternalField_899.InternalMethod_1026());
            InternalField_283.Add(InternalParameter_1333, default);
        }

        public void InternalMethod_1270(InternalType_131 InternalParameter_1334)
        {
            if (!InternalField_877.InternalMethod_1011(InternalParameter_1334, out int InternalVar_1))
            {
                return;
            }

            InternalField_877.RemoveAtSwapBack(InternalVar_1);

            InternalField_889.InternalMethod_1028(InternalField_878[InternalParameter_1334]);
            InternalField_878.Remove(InternalParameter_1334);
            InternalField_890.InternalMethod_1028(InternalField_879[InternalParameter_1334]);
            InternalField_879.Remove(InternalParameter_1334);
            InternalField_891.InternalMethod_1028(InternalField_880[InternalParameter_1334]);
            InternalField_880.Remove(InternalParameter_1334);
            InternalField_892.InternalMethod_1028(InternalField_881[InternalParameter_1334]);
            InternalField_881.Remove(InternalParameter_1334);
            InternalField_893.InternalMethod_1028(InternalField_882[InternalParameter_1334]);
            InternalField_882.Remove(InternalParameter_1334);
            InternalField_894.InternalMethod_1028(InternalField_883[InternalParameter_1334]);
            InternalField_883.Remove(InternalParameter_1334);
            InternalField_895.InternalMethod_1028(InternalField_884[InternalParameter_1334]);
            InternalField_884.Remove(InternalParameter_1334);
            InternalField_896.InternalMethod_1028(InternalField_885[InternalParameter_1334]);
            InternalField_885.Remove(InternalParameter_1334);
            InternalField_897.InternalMethod_1028(InternalField_886[InternalParameter_1334]);
            InternalField_886.Remove(InternalParameter_1334);
            InternalField_898.InternalMethod_1028(InternalField_887[InternalParameter_1334]);
            InternalField_887.Remove(InternalParameter_1334);
            InternalField_899.InternalMethod_1028(InternalField_888[InternalParameter_1334]);
            InternalField_888.Remove(InternalParameter_1334);
            InternalField_283.Remove(InternalParameter_1334);
        }

        public void InternalMethod_702()
        {
            InternalField_877.InternalMethod_1020();

            InternalField_878.Init();
            InternalField_879.Init();
            InternalField_880.Init();
            InternalField_882.Init();
            InternalField_883.Init();
            InternalField_881.Init();
            InternalField_884.Init();
            InternalField_885.Init();
            InternalField_886.Init();
            InternalField_887.Init();
            InternalField_888.Init();
            InternalField_283.Init();

            InternalField_889.InternalMethod_1020();
            InternalField_890.InternalMethod_1020();
            InternalField_891.InternalMethod_1020();
            InternalField_892.InternalMethod_1020();
            InternalField_893.InternalMethod_1020();
            InternalField_894.InternalMethod_1020();
            InternalField_895.InternalMethod_1020();
            InternalField_896.InternalMethod_1020();
            InternalField_897.InternalMethod_1020();
            InternalField_898.InternalMethod_1020();
            InternalField_899.InternalMethod_1020();
        }

        public void Dispose()
        {
            InternalField_877.Dispose();

            InternalField_878.Dispose();
            InternalField_879.Dispose();
            InternalField_880.Dispose();
            InternalField_882.Dispose();
            InternalField_883.Dispose();
            InternalField_881.Dispose();
            InternalField_884.Dispose();
            InternalField_885.Dispose();
            InternalField_886.Dispose();
            InternalField_887.Dispose();
            InternalField_888.Dispose();
            InternalField_283.Dispose();

            InternalField_889.InternalMethod_1022();
            InternalField_890.InternalMethod_1022();
            InternalField_891.InternalMethod_1022();
            InternalField_892.InternalMethod_1022();
            InternalField_893.InternalMethod_1022();
            InternalField_894.InternalMethod_1022();
            InternalField_895.InternalMethod_1022();
            InternalField_896.InternalMethod_1022();
            InternalField_897.InternalMethod_1022();
            InternalField_898.InternalMethod_1022();
            InternalField_899.InternalMethod_1022();
        }
    }

}
