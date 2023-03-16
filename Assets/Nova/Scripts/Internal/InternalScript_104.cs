
#define CACHE_NAME

using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Unity.Collections;
using UnityEngine;
using static Nova.InternalNamespace_0.InternalNamespace_9.InternalType_227;

namespace Nova.InternalNamespace_0.InternalNamespace_9
{
    internal class InternalType_253 : InternalType_129<InternalType_253, InternalType_145>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public InternalType_138 InternalProperty_259 { get; private set; } = new InternalType_138();
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref InternalType_174<InternalType_131> InternalProperty_260 => ref InternalField_742.InternalProperty_255.InternalField_629;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_227 InternalField_742 = new InternalType_227();

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref InternalType_228.InternalType_229 InternalProperty_261 => ref InternalField_742.InternalProperty_254;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref InternalType_228 InternalProperty_262 => ref InternalField_742.InternalProperty_255;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref NativeList<InternalType_222> InternalProperty_263 => ref InternalField_742.InternalProperty_256;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref NovaHashMap<InternalType_131, InternalType_133> InternalProperty_264 => ref InternalField_742.InternalProperty_257;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ref InternalType_225 InternalProperty_265 => ref InternalField_742.InternalProperty_258;

        protected override bool InternalMethod_620(InternalType_131 InternalParameter_506, out InternalType_133 InternalParameter_507) => InternalProperty_259.InternalMethod_665(InternalParameter_506, out InternalParameter_507);
        protected override InternalType_131 InternalMethod_621(InternalType_133 InternalParameter_508) => InternalProperty_259.InternalMethod_667(InternalParameter_508);

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public override bool InternalProperty_193 => InternalProperty_265.InternalProperty_193;

        public override void InternalMethod_635() => InternalProperty_265.InternalMethod_635();

        protected override void InternalMethod_615(InternalType_145 InternalParameter_499)
        {

            int InternalVar_1 = InternalParameter_499.InternalProperty_209;
            InternalProperty_259.InternalMethod_663(InternalParameter_499.InternalProperty_195, InternalProperty_191);

            InternalType_131 InternalVar_2 = InternalType_131.InternalField_415;

            InternalType_145 InternalVar_3 = InternalParameter_499.InternalProperty_210;
            if (InternalVar_3 != null)
            {
                if (InternalVar_3.InternalProperty_197)
                {
                    InternalVar_2 = InternalVar_3.InternalProperty_195;
                }
                else
                {
                    Debug.LogError($"Tried to register {InternalParameter_499.InternalProperty_198} but parent {InternalVar_3.InternalProperty_198} was not registered.");
                }
            }

            InternalField_742.InternalMethod_1075(InternalParameter_499.InternalProperty_195, InternalVar_2, InternalVar_1, InternalParameter_499.InternalProperty_203);

            InternalType_180.InternalMethod_849();
        }

        
        public int InternalMethod_1148(InternalType_145 InternalParameter_1229, InternalType_145 InternalParameter_1230)
        {
            bool InternalVar_1 = InternalMethod_625(InternalParameter_1230);
            bool InternalVar_2 = InternalMethod_625(InternalParameter_1229);

            if (!InternalVar_1 || !InternalVar_2)
            {
                Debug.LogError("Called RegisterWithParent when parent or child was not registered");
                return -1;
            }

            InternalType_131 InternalVar_3 = InternalParameter_1229.InternalProperty_195;
            InternalType_131 InternalVar_4 = InternalParameter_1230.InternalProperty_195;

            int InternalVar_5 = InternalField_742.InternalMethod_1076(InternalParameter_1229.InternalProperty_196, InternalVar_4, InternalParameter_1229.InternalProperty_209);

            InternalMethod_1154(InternalVar_3);

            InternalType_180.InternalMethod_849();

            return InternalVar_5;
        }

        
        public void InternalMethod_1149(InternalType_145 InternalParameter_1231)
        {
            if (!InternalMethod_625(InternalParameter_1231))
            {
                Debug.LogError("Called UnregisterFromParent when child was not registered");
                return;
            }

            InternalType_131 InternalVar_1 = InternalParameter_1231.InternalProperty_195;
            InternalType_133 InternalVar_2 = InternalParameter_1231.InternalProperty_196;
            InternalType_131 InternalVar_3 = InternalField_742.InternalMethod_1092(InternalVar_2);
            if (!InternalVar_3.InternalProperty_192)
            {
                return;
            }

            InternalField_742.InternalMethod_1077(InternalVar_2, InternalVar_1);

            if (!InternalParameter_1231.InternalProperty_154)
            {
                InternalMethod_1153(InternalVar_1);
            }

            InternalType_180.InternalMethod_849();
        }

        public void InternalMethod_1150(InternalType_145 InternalParameter_1232, InternalType_131 InternalParameter_1233, int InternalParameter_1234, bool InternalParameter_1235)
        {
            bool InternalVar_1 = InternalMethod_625(InternalParameter_1232);

            if (!InternalVar_1)
            {
                Debug.LogError("Called ReparentVirtualProxy when virtual element was not registered");
                return;
            }

            InternalType_131 InternalVar_2 = InternalParameter_1232.InternalProperty_195;
            InternalType_131 InternalVar_3 = InternalField_742.InternalMethod_1091(InternalVar_2);
            if (InternalVar_3 == InternalParameter_1233)
            {
                return;
            }

            InternalField_742.InternalMethod_1087(InternalVar_2, InternalParameter_1233, InternalParameter_1234, InternalParameter_1235);
        }

        public void InternalMethod_1151(InternalType_133 InternalParameter_1236, InternalType_131 InternalParameter_1237, int InternalParameter_1238)
        {
            if (!InternalParameter_1236.InternalProperty_194)
            {
                Debug.LogError("Called SetVirtualProxyIndex when virtual element was not registered");
                return;
            }

            InternalField_742.InternalMethod_1088(InternalParameter_1236, InternalParameter_1237, InternalParameter_1238);

            InternalType_180.InternalMethod_849();
        }

        public void InternalMethod_1152(InternalType_145 InternalParameter_1239)
        {
            bool InternalVar_1 = InternalMethod_625(InternalParameter_1239);

            if (!InternalVar_1)
            {
                Debug.LogError("Called UnparentVirtualProxy when virtual element was not registered");
                return;
            }

            InternalType_131 InternalVar_2 = InternalParameter_1239.InternalProperty_195;
            InternalField_742.InternalMethod_1089(InternalVar_2);

            InternalType_180.InternalMethod_849();
        }

        protected override void InternalMethod_616(InternalType_131 InternalParameter_500, InternalType_133 InternalParameter_501)
        {
            InternalField_742.InternalMethod_1078(InternalParameter_501, InternalParameter_500);
            InternalMethod_1154(InternalParameter_500);

            InternalProperty_259.InternalMethod_664(InternalParameter_501);

            InternalType_180.InternalMethod_849();
        }

        private void InternalMethod_1153(InternalType_131 InternalParameter_1240)
        {
            InternalField_742.InternalMethod_1079(InternalParameter_1240);

            InternalType_180.InternalMethod_849();
        }

        private void InternalMethod_1154(InternalType_131 InternalParameter_1241)
        {
            InternalType_146 InternalVar_1 = InternalField_413[InternalParameter_1241] as InternalType_146;

            bool InternalVar_2 = InternalVar_1 != null && InternalVar_1.InternalProperty_208;

            InternalField_742.InternalMethod_1080(InternalParameter_1241, InternalVar_2);

            InternalType_180.InternalMethod_849();
        }

        
        public void InternalMethod_1155(InternalType_131 InternalParameter_1242)
        {
            if (!InternalMethod_628(InternalParameter_1242))
            {
                return;
            }

            InternalField_742.InternalMethod_1082(InternalParameter_1242);

            InternalType_180.InternalMethod_849();

        }

        public void InternalMethod_1156(InternalType_131 InternalParameter_1243)
        {
            if (!InternalMethod_628(InternalParameter_1243))
            {
                return;
            }

            if (!InternalProperty_260.InternalMethod_839(InternalParameter_1243))
            {
                InternalField_742.InternalMethod_1081(InternalParameter_1243);
            }

            InternalType_180.InternalMethod_849();
        }

        public InternalType_145 InternalMethod_1157(InternalType_131 InternalParameter_1244)
        {
            InternalType_131 InternalVar_1 = InternalField_742.InternalMethod_1090(InternalParameter_1244);

            if (InternalField_413.TryGetValue(InternalVar_1, out InternalType_145 InternalVar_2))
            {
                return InternalVar_2;
            }

            return null;
        }

        public InternalType_145 InternalMethod_1158(InternalType_131 InternalParameter_1245)
        {
            InternalType_131 InternalVar_1 = InternalField_742.InternalMethod_1091(InternalParameter_1245, InternalParameter_1116: true);
            if (InternalField_413.TryGetValue(InternalVar_1, out InternalType_145 InternalVar_2))
            {
                return InternalVar_2;
            }

            return null;
        }

        public bool InternalMethod_3605(InternalType_133 InternalParameter_3348, InternalType_131 InternalParameter_3349, out InternalType_145 InternalParameter_3350)
        {
            if (!InternalField_742.InternalMethod_3601(InternalParameter_3348, InternalParameter_3349, out InternalType_131 InternalVar_1))
            {
                InternalParameter_3350 = null;
                return false;
            }

            InternalParameter_3350 = InternalField_413[InternalVar_1];
            return true;
        }

        public InternalType_164<InternalType_133> InternalMethod_3606(InternalType_133 InternalParameter_3351)
        {
            return InternalField_742.InternalProperty_256[InternalParameter_3351].InternalField_587;
        }

        public Unity.Jobs.JobHandle InternalMethod_1159(ref NativeList<InternalType_131> InternalParameter_1246, ref NativeList<InternalType_133> InternalParameter_1247, Unity.Jobs.JobHandle InternalParameter_1248)
        {
            return InternalField_742.InternalMethod_1093(ref InternalParameter_1246, ref InternalParameter_1247, InternalParameter_1248);
        }

        public int InternalMethod_1160(InternalType_131 InternalParameter_1249)
        {
            return InternalField_742.InternalMethod_1096(InternalParameter_1249);
        }

        
        public int InternalMethod_1161(InternalType_131 InternalParameter_1250)
        {
            return InternalField_742.InternalMethod_1097(InternalParameter_1250);
        }

        public void InternalMethod_1162(InternalType_131 InternalParameter_1251, InternalType_131 InternalParameter_1252)
        {
            InternalField_742.InternalMethod_1084(InternalParameter_1251, InternalParameter_1252);

            InternalType_180.InternalMethod_849();
        }

        public void InternalMethod_1163(InternalType_131 InternalParameter_1253, InternalType_131 InternalParameter_1254, int InternalParameter_1255)
        {
            InternalField_742.InternalMethod_1083(InternalParameter_1253, InternalParameter_1254, InternalParameter_1255);

            InternalType_180.InternalMethod_849();
        }

        public void InternalMethod_2014(InternalType_131 InternalParameter_2327, InternalType_521<InternalType_131> InternalParameter_2326, InternalType_521<int> InternalParameter_2325)
        {
            InternalField_742.InternalMethod_2015(InternalParameter_2327, InternalParameter_2326, InternalParameter_2325);

            InternalType_180.InternalMethod_849();
        }

        public Unity.Jobs.JobHandle InternalMethod_1165(ref InternalType_128 InternalParameter_1259, Unity.Jobs.JobHandle InternalParameter_1260)
        {
            return InternalField_742.InternalMethod_1098(ref InternalParameter_1259, InternalParameter_1260);
        }

        public override void InternalMethod_702()
        {
            base.InternalMethod_702();
            InternalProperty_259.InternalMethod_702();
            InternalField_742.InternalMethod_702();
        }

        public override void Dispose()
        {
            base.Dispose();
            InternalProperty_259.Dispose();
            InternalField_742.Dispose();
        }

        protected override void InternalMethod_617(InternalType_145 InternalParameter_502)
        {

            InternalType_180.InternalMethod_849();
        }

        protected override void InternalMethod_618(InternalType_145 InternalParameter_503) { }
        protected override void InternalMethod_619(InternalType_145 InternalParameter_504, InternalType_145 InternalParameter_505) { }
    }
}
