using Nova.InternalNamespace_0.InternalNamespace_4;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
#pragma warning disable CS0660
#pragma warning disable CS0661

namespace Nova.InternalNamespace_0.InternalNamespace_10
{
    
    
    internal struct InternalType_301 : InternalType_160<InternalType_301>, IEquatable<int>, IComparable<int>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_990;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_303
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_990 >= 0;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_227
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_990;
        }

        public static implicit operator int(InternalType_301 InternalParameter_1409) => InternalParameter_1409.InternalField_990;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_301(int InternalParameter_1410) => new InternalType_301()
        {
            InternalField_990 = InternalParameter_1410
        };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_301 InternalParameter_1411, InternalType_301 InternalParameter_1412) => InternalParameter_1411.InternalField_990 == InternalParameter_1412.InternalField_990;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_301 InternalParameter_1413, InternalType_301 InternalParameter_1414) => InternalParameter_1413.InternalField_990 != InternalParameter_1414.InternalField_990;

        public bool Equals(int other)
        {
            return InternalField_990 == other;
        }

        public int CompareTo(int other)
        {
            return InternalField_990.CompareTo(other);
        }

        public int CompareTo(InternalType_301 other)
        {
            return InternalField_990.CompareTo(other.InternalField_990);
        }

        public bool Equals(InternalType_301 other)
        {
            return InternalField_990.Equals(other);
        }
    }

    
    
    internal struct InternalType_305 : InternalType_160<InternalType_305>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_1003;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_227 => InternalField_1003;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int(InternalType_305 InternalParameter_1436) => InternalParameter_1436.InternalField_1003;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_305(int InternalParameter_1437) => new InternalType_305()
        {
            InternalField_1003 = InternalParameter_1437
        };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_305 InternalParameter_1438, InternalType_305 InternalParameter_1439) => InternalParameter_1438.InternalField_1003 == InternalParameter_1439.InternalField_1003;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_305 InternalParameter_1440, InternalType_305 InternalParameter_1441) => InternalParameter_1440.InternalField_1003 != InternalParameter_1441.InternalField_1003;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(InternalType_305 other)
        {
            return InternalField_1003.CompareTo(other.InternalField_1003);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_305 other)
        {
            return InternalField_1003.Equals(other.InternalField_1003);
        }

        public static InternalType_305 InternalMethod_1361(ref InternalType_305 InternalParameter_1442, ref InternalType_305 InternalParameter_1443)
        {
            return math.max(InternalParameter_1442.InternalField_1003, InternalParameter_1443.InternalField_1003);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_305 InternalField_1004 = new InternalType_305()
        {
            InternalField_1003 = -1
        };
    }

    
    
    internal struct InternalType_304 : InternalType_160<InternalType_304>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_1001;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_227
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1001;
        }
        public static implicit operator InternalType_304(int InternalParameter_1430) => new InternalType_304()
        {
            InternalField_1001 = InternalParameter_1430
        };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(InternalType_304 InternalParameter_1431) => InternalParameter_1431.InternalField_1001;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_304 InternalParameter_1432, InternalType_304 InternalParameter_1433) => InternalParameter_1432.InternalField_1001 == InternalParameter_1433.InternalField_1001;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_304 InternalParameter_1434, InternalType_304 InternalParameter_1435) => InternalParameter_1434.InternalField_1001 != InternalParameter_1435.InternalField_1001;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return InternalField_1001.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return InternalField_1001.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(InternalType_304 other)
        {
            return InternalField_1001.CompareTo(other.InternalField_1001);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_304 other)
        {
            return InternalField_1001.Equals(other.InternalField_1001);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_304 InternalField_1002 = new InternalType_304() { InternalField_1001 = -1 };
    }

    
    internal struct InternalType_358 : InternalType_160<InternalType_358>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_1247;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_321
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1247 > -1;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_227
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1247;
        }
        public static implicit operator InternalType_358(int InternalParameter_1673) => new InternalType_358()
        {
            InternalField_1247 = InternalParameter_1673
        };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(InternalType_358 InternalParameter_1674) => InternalParameter_1674.InternalField_1247;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_358 InternalParameter_1675, InternalType_358 InternalParameter_1676) => InternalParameter_1675.InternalField_1247 == InternalParameter_1676.InternalField_1247;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_358 InternalParameter_1677, InternalType_358 InternalParameter_1678) => InternalParameter_1677.InternalField_1247 != InternalParameter_1678.InternalField_1247;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return InternalField_1247.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return InternalField_1247.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(InternalType_358 other)
        {
            return InternalField_1247.CompareTo(other.InternalField_1247);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_358 other)
        {
            return InternalField_1247.Equals(other.InternalField_1247);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_358 InternalField_1248 = new InternalType_358() { InternalField_1247 = -1 };
    }

    internal struct InternalType_257 : IEquatable<InternalType_257>, IComparable<InternalType_257>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_747;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_271
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_747 != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_257 other)
        {
            return InternalField_747 == other.InternalField_747;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return InternalField_747.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_257(int InternalParameter_1261) => new InternalType_257()
        {
            InternalField_747 = InternalParameter_1261
        };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_257 InternalParameter_1262, InternalType_257 InternalParameter_1263)
        {
            return InternalParameter_1262.InternalField_747 == InternalParameter_1263.InternalField_747;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_257 InternalParameter_1264, InternalType_257 InternalParameter_1265)
        {
            return InternalParameter_1264.InternalField_747 != InternalParameter_1265.InternalField_747;
        }

        public int CompareTo(InternalType_257 other)
        {
            return InternalField_747 - other.InternalField_747;
        }

        public override string ToString()
        {
            return InternalField_747.ToString();
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_257 InternalField_748 = new InternalType_257()
        {
            InternalField_747 = 0
        };
    }

    internal struct InternalType_310 : IEquatable<InternalType_310>, IComparable<InternalType_310>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_1022;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_310 InternalField_1023 = 0;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_307
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_1022 != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(InternalType_310 other)
        {
            return InternalField_1022 == other.InternalField_1022;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return InternalField_1022.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_310 InternalParameter_1492, InternalType_310 InternalParameter_1493)
        {
            return InternalParameter_1492.InternalField_1022 == InternalParameter_1493.InternalField_1022;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_310 InternalParameter_1494, InternalType_310 InternalParameter_1495)
        {
            return InternalParameter_1494.InternalField_1022 != InternalParameter_1495.InternalField_1022;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(InternalType_310 other)
        {
            return InternalField_1022 - other.InternalField_1022;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_310(int InternalParameter_1496) => new InternalType_310()
        {
            InternalField_1022 = InternalParameter_1496,
        };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int(InternalType_310 InternalParameter_1497) => InternalParameter_1497.InternalField_1022;

        public override string ToString()
        {
            return InternalField_1022.ToString();
        }
    }

    internal struct InternalType_282 : InternalType_160<InternalType_282>
    {
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int InternalField_922;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool InternalProperty_296
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_922 >= 0;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public int InternalProperty_227
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalField_922;
        }

        public bool Equals(InternalType_282 other)
        {
            return InternalField_922 == other.InternalField_922;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return InternalField_922.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(InternalType_282 InternalParameter_1336, InternalType_282 InternalParameter_1337)
        {
            return InternalParameter_1336.InternalField_922 == InternalParameter_1337.InternalField_922;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(InternalType_282 InternalParameter_1338, InternalType_282 InternalParameter_1339)
        {
            return InternalParameter_1338.InternalField_922 != InternalParameter_1339.InternalField_922;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(InternalType_282 other)
        {
            return InternalField_922 - other.InternalField_922;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator InternalType_282(int InternalParameter_1340) => new InternalType_282()
        {
            InternalField_922 = InternalParameter_1340,
        };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int(InternalType_282 InternalParameter_1341) => InternalParameter_1341.InternalField_922;

        public override string ToString()
        {
            return InternalField_922.ToString();
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public static readonly InternalType_282 InternalField_923 = new InternalType_282()
        {
            InternalField_922 = -1
        };
    }
}
