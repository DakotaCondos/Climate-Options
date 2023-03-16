
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

namespace Nova.InternalNamespace_0.InternalNamespace_5.InternalNamespace_6
{
    [JobProducerType(typeof(InternalType_199.InternalType_200<>))]
    internal interface InternalType_192 : IJob { }

    [JobProducerType(typeof(InternalType_202.InternalType_203<>))]
    internal interface InternalType_193 : IJobParallelFor
    { }

    internal static class InternalType_199
    {
        public static unsafe void InternalMethod_988<T>(this ref T InternalParameter_959) where T : struct, InternalType_192
        {
            JobsUtility.JobScheduleParameters InternalVar_1 = InternalType_200<T>.InternalField_555;
            InternalVar_1.JobDataPtr = new IntPtr(UnsafeUtility.AddressOf(ref InternalParameter_959));

            JobsUtility.Schedule(ref InternalVar_1);
        }

        public static unsafe JobHandle InternalMethod_1982<T>(this ref T InternalParameter_965, JobHandle InternalParameter_964 = default) where T : struct, InternalType_192
        {
            JobsUtility.JobScheduleParameters InternalVar_1 = InternalType_200<T>.InternalField_556;
            InternalVar_1.JobDataPtr = new IntPtr(UnsafeUtility.AddressOf(ref InternalParameter_965));
            InternalVar_1.Dependency = InternalParameter_964;

            return JobsUtility.Schedule(ref InternalVar_1);
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public unsafe struct InternalType_200<T45> where T45 : struct, InternalType_192
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly JobsUtility.JobScheduleParameters InternalField_555 = new JobsUtility.JobScheduleParameters(null, InternalProperty_247, default, ScheduleMode.Run);
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly JobsUtility.JobScheduleParameters InternalField_556 = new JobsUtility.JobScheduleParameters(null, InternalProperty_247, default, ScheduleMode.Single);

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private static IntPtr InternalField_557;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static IntPtr InternalProperty_247
            {
                get
                {
                    if (InternalField_557 == IntPtr.Zero)
                    {
                        InternalField_557 = JobsUtility.CreateJobReflectionData(typeof(T45), typeof(T45), (InternalType_201)Execute);
                    }

                    return InternalField_557;
                }
            }

            private delegate void InternalType_201(ref T45 jobData);

            [Obfuscation]
            private static void Execute(ref T45 jobData)
            {
                jobData.Execute();
            }
        }
    }

    internal static class InternalType_202
    {
        public static unsafe JobHandle InternalMethod_1984<T>(this ref T InternalParameter_963, int InternalParameter_962, int InternalParameter_961, JobHandle InternalParameter_960 = default) where T : struct, InternalType_193
        {

            JobsUtility.JobScheduleParameters InternalVar_1 = InternalType_203<T>.InternalField_558;
            InternalVar_1.JobDataPtr = new IntPtr(UnsafeUtility.AddressOf(ref InternalParameter_963));
            InternalVar_1.Dependency = InternalParameter_960;
            return JobsUtility.ScheduleParallelFor(ref InternalVar_1, InternalParameter_962, InternalParameter_961);
        }

        public static unsafe JobHandle InternalMethod_3333<T>(this ref T InternalParameter_15, int* InternalParameter_17, int InternalParameter_16, JobHandle InternalParameter_14 = default) where T : struct, InternalType_193
        {
            JobsUtility.JobScheduleParameters InternalVar_1 = InternalType_203<T>.InternalField_558;
            InternalVar_1.JobDataPtr = new IntPtr(UnsafeUtility.AddressOf(ref InternalParameter_15));
            InternalVar_1.Dependency = InternalParameter_14;

            var InternalVar_2 = (byte*)InternalParameter_17 - sizeof(void*);
            return JobsUtility.ScheduleParallelForDeferArraySize(ref InternalVar_1, InternalParameter_16, InternalVar_2, null);
        }

        public static unsafe JobHandle InternalMethod_3334<T,U>(this ref T InternalParameter_5, NativeList<U> InternalParameter_8, int InternalParameter_7, JobHandle InternalParameter_6 = default) 
            where T : struct, InternalType_193
            where U : unmanaged
        {
            JobsUtility.JobScheduleParameters InternalVar_1 = InternalType_203<T>.InternalField_558;
            InternalVar_1.JobDataPtr = new IntPtr(UnsafeUtility.AddressOf(ref InternalParameter_5));
            InternalVar_1.Dependency = InternalParameter_6;

            void* InternalVar_2 = null;
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            var InternalVar_3 = NativeListUnsafeUtility.GetAtomicSafetyHandle(ref InternalParameter_8);
            InternalVar_2 = UnsafeUtility.AddressOf(ref InternalVar_3);
#endif

            var InternalVar_4 = NativeListUnsafeUtility.GetInternalListDataPtrUnchecked(ref InternalParameter_8);
            return JobsUtility.ScheduleParallelForDeferArraySize(ref InternalVar_1, InternalParameter_7, InternalVar_4, InternalVar_2);
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public unsafe struct InternalType_203<T46> where T46 : struct, InternalType_193
        {
            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static readonly JobsUtility.JobScheduleParameters InternalField_558 = new JobsUtility.JobScheduleParameters(null, InternalProperty_248, default, ScheduleMode.Parallel);

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            private static IntPtr InternalField_559;

            [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
            public static IntPtr InternalProperty_248
            {
                get
                {
                    if (InternalField_559 == IntPtr.Zero)
                    {
                        InternalField_559 = JobsUtility.CreateJobReflectionData(typeof(T46), typeof(T46), (InternalType_204)Execute);
                    }

                    return InternalField_559;
                }
            }

            private delegate void InternalType_204(ref T46 jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);

            [Obfuscation]
            private static unsafe void Execute(ref T46 jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex)
            {
                while (JobsUtility.GetWorkStealingRange(ref ranges, jobIndex, out int InternalVar_1, out int InternalVar_2))
                {
                    for (var InternalVar_3 = InternalVar_1; InternalVar_3 < InternalVar_2; ++InternalVar_3)
                    {
                        jobData.Execute(InternalVar_3);
                    }
                }
            }

        }
    }
}
