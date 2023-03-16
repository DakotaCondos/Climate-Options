using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_2;
using Nova.InternalNamespace_0.InternalNamespace_5;
using Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6;
using Unity.Collections;
using Unity.Jobs;

namespace Nova.InternalNamespace_0.InternalNamespace_9
{
    internal class InternalType_254 : InternalType_126<InternalType_254>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public NovaHashMap<InternalType_131, int> InternalField_743;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public JobHandle InternalField_744;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool InternalProperty_266 => InternalType_253.InternalProperty_190.InternalProperty_193;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_227.InternalType_251 InternalField_745;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private InternalType_227.InternalType_250 InternalField_746;

        public override void Dispose()
        {
            InternalField_743.Dispose();
        }

        public override void InternalMethod_603()
        {
            InternalField_406 = this;

            InternalField_743 = new NovaHashMap<InternalType_131, int>(InternalType_178.InternalField_3012, Allocator.Persistent);

            #region 
            InternalField_745 = new InternalType_227.InternalType_251()
            {
                InternalField_735 = InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_596,
                InternalField_736 = InternalType_253.InternalProperty_190.InternalProperty_264,

                InternalField_737 = InternalField_743,
            };

            InternalField_746 = new InternalType_227.InternalType_250()
            {
                InternalField_730 = InternalType_253.InternalProperty_190.InternalProperty_263,
                InternalField_731 = InternalType_253.InternalProperty_190.InternalProperty_264,

                InternalField_732 = InternalField_743,
                InternalField_734 = InternalType_253.InternalProperty_190.InternalProperty_265.InternalField_594,
            };
            #endregion
        }

        public override void InternalMethod_605(ref InternalType_128 engineUpdateInfo)
        {
            if (!InternalProperty_266)
            {
                return;
            }

            InternalField_745.InternalField_738 = InternalType_253.InternalProperty_190.InternalField_413.Count;
            engineUpdateInfo.InternalField_410 = InternalField_745.InternalMethod_1982();

            engineUpdateInfo.InternalField_410 = InternalType_253.InternalProperty_190.InternalMethod_1165(ref engineUpdateInfo, engineUpdateInfo.InternalField_410);

            InternalField_746.InternalField_733 = engineUpdateInfo.InternalField_409;
            engineUpdateInfo.InternalField_410 = InternalField_746.InternalMethod_3334(engineUpdateInfo.InternalField_409, InternalField_407, engineUpdateInfo.InternalField_410);

            InternalField_744 = engineUpdateInfo.InternalField_410;
        }

        public override void InternalMethod_608()
        {
            InternalType_253.InternalProperty_190.InternalMethod_635();
        }
    }
}
