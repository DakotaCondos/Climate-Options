using Nova.Compat;
using Nova.InternalNamespace_0.InternalNamespace_4;
using Nova.InternalNamespace_0.InternalNamespace_3;
using Nova.InternalNamespace_0.InternalNamespace_5;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
#pragma warning disable CS0660 

namespace Nova.InternalNamespace_0.InternalNamespace_2
{
     
    [Serializable]
    internal struct InternalType_131 : IEquatable<InternalType_131>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_131 InternalField_415 = default;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public const int InternalField_416 = sizeof(ulong);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private static ulong InternalField_417 = 1;

        [SerializeField]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private ulong val;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public readonly bool InternalProperty_192
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return val != default;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(InternalType_131 other)
        {
            return other == this;
        }

        public static InternalType_131 InternalMethod_630()
        {
            return new InternalType_131(InternalField_417++);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_131 InternalParameter_517, InternalType_131 InternalParameter_518)
        {
            return InternalParameter_517.val == InternalParameter_518.val;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_131 InternalParameter_519, InternalType_131 InternalParameter_520)
        {
            return InternalParameter_519.val != InternalParameter_520.val;
        }

        private InternalType_131(ulong InternalParameter_521)
        {
            val = InternalParameter_521;
        }

        public override int GetHashCode()
        {
            return val.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("0x{0:X8}", val);
        }
    }

    
    internal struct InternalType_137 : IEquatable<int>, IComparable<int>, InternalType_160<InternalType_137>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_137 InternalField_420 = default;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_421;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_227
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_421 - 1;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_201
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return InternalField_421 != InternalField_420.InternalField_421;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(int other)
        {
            return ((int)this).CompareTo(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(int other)
        {
            return other == this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_137(int InternalParameter_528)
        {
            return new InternalType_137()
            {
                InternalField_421 = InternalParameter_528 + 1
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int(InternalType_137 InternalParameter_529)
        {
            int InternalVar_1 = InternalParameter_529.InternalField_421;
            return InternalVar_1 - 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(InternalType_137 InternalParameter_530)
        {
            return (uint)(InternalParameter_530.InternalField_421 - 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return ((int)this).GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return ((int)this).ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(InternalType_137 other)
        {
            return InternalField_421.CompareTo(other.InternalField_421);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_137 other)
        {
            return InternalField_421.Equals(other.InternalField_421);
        }
    }

    
     
    internal struct InternalType_133 : IEquatable<int>, IEquatable<InternalType_133>, IComparable<int>, InternalType_160<InternalType_133>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_133 InternalField_418 = default;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_419;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_194
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                int InternalVar_1 = InternalField_418.InternalField_419;
                return InternalField_419 != InternalVar_1;
            }
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_227
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_419 - 1;
        }

        public bool Equals(int other)
        {
            return other == this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(int other)
        {
            return ((int)this).CompareTo(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_133(int InternalParameter_522)
        {
            return new InternalType_133()
            {
                InternalField_419 = InternalParameter_522 + 1
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int(InternalType_133 InternalParameter_523)
        {
            int InternalVar_1 = InternalParameter_523.InternalField_419;
            return InternalVar_1 - 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(InternalType_133 InternalParameter_524)
        {
            int InternalVar_1 = InternalParameter_524.InternalField_419;
            return (uint)(InternalVar_1 - 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return ((int)this).GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return ((int)this).ToString();
        }

        public bool Equals(InternalType_133 other)
        {
            return this.InternalField_419 == other.InternalField_419;
        }

        public int CompareTo(InternalType_133 other)
        {
            return InternalField_419.CompareTo(other.InternalField_419);
        }
    }

    internal class InternalType_138 : InternalType_147
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private List<InternalType_131> InternalField_422 = new List<InternalType_131>(InternalType_178.InternalField_3013);
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private Dictionary<InternalType_131, InternalType_133> InternalField_423 = new Dictionary<InternalType_131, InternalType_133>();

        public void InternalMethod_702()
        {
            InternalField_423.Clear();
            InternalField_422.Clear();
        }

        public bool InternalMethod_662(InternalType_131 InternalParameter_531)
        {
            return InternalField_423.ContainsKey(InternalParameter_531);
        }

        public void InternalMethod_663(InternalType_131 InternalParameter_532, InternalType_133 InternalParameter_533)
        {
            InternalField_423.Add(InternalParameter_532, InternalParameter_533);
            InternalField_422.Add(InternalParameter_532);
        }

        public void InternalMethod_664(InternalType_133 InternalParameter_534)
        {
            InternalType_131 InternalVar_1 = InternalMethod_667(InternalParameter_534);
            InternalType_131 InternalVar_2 = InternalMethod_667(InternalField_423.Count - 1);

            InternalField_423[InternalVar_2] = InternalParameter_534;
            InternalField_423.Remove(InternalVar_1);
            InternalField_422.RemoveAtSwapBack(InternalParameter_534);
        }

        public bool InternalMethod_665(InternalType_131 InternalParameter_535, out InternalType_133 InternalParameter_536)
        {
            return InternalField_423.TryGetValue(InternalParameter_535, out InternalParameter_536);
        }

        public InternalType_133 InternalMethod_666(InternalType_131 InternalParameter_537)
        {
            return InternalField_423[InternalParameter_537];
        }

        public InternalType_131 InternalMethod_667(InternalType_133 InternalParameter_538)
        {
            return InternalField_422[InternalParameter_538];
        }

        public void Dispose()
        {
            InternalField_423.Clear();
        }
    }

    
    internal struct InternalType_139 : IDisposable
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NativeList<InternalType_131> InternalField_424;
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private NovaHashMap<InternalType_131, InternalType_133> InternalField_425;

        public bool InternalMethod_668(InternalType_131 InternalParameter_539)
        {
            return InternalField_425.ContainsKey(InternalParameter_539);
        }

        public void InternalMethod_669(InternalType_131 InternalParameter_540, InternalType_133 InternalParameter_541)
        {
            InternalField_425.Add(InternalParameter_540, InternalParameter_541);
            InternalField_424.Add(InternalParameter_540);
        }

        public void InternalMethod_670(InternalType_133 InternalParameter_542)
        {
            InternalType_131 InternalVar_1 = InternalMethod_673(InternalParameter_542);
            InternalType_131 InternalVar_2 = InternalMethod_673(InternalField_424.Length - 1);

            InternalField_425[InternalVar_2] = InternalParameter_542;
            InternalField_424.RemoveAtSwapBack(InternalParameter_542);
            InternalField_425.Remove(InternalVar_1);
        }

        public bool InternalMethod_671(InternalType_131 InternalParameter_543, out InternalType_133 InternalParameter_544)
        {
            if (!InternalField_425.TryGetValue(InternalParameter_543, out InternalParameter_544))
            {
                InternalParameter_544 = InternalType_133.InternalField_418;
                return false;
            }

            return InternalParameter_544.InternalProperty_194;
        }

        public int InternalMethod_672(InternalType_131 InternalParameter_545)
        {
            return InternalField_425[InternalParameter_545];
        }

        public InternalType_131 InternalMethod_673(InternalType_133 InternalParameter_546)
        {
            return InternalField_424[InternalParameter_546];
        }

        public void Dispose()
        {
            InternalField_424.Dispose();
            InternalField_425.Dispose();
        }

        public static InternalType_139 InternalMethod_674()
        {
            return new InternalType_139()
            {
                InternalField_424 = new NativeList<InternalType_131>(InternalType_178.InternalField_3013, Allocator.Persistent),
                InternalField_425 = new NovaHashMap<InternalType_131, InternalType_133>(InternalType_178.InternalField_3013, Allocator.Persistent)
            };
        }
    }
}

