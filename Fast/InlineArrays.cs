namespace Fast;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[InlineArray(size)]
public struct Array2<T> {
    public const int size = 2;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
[InlineArray(size)]
public struct Array3<T> {
    public const int size = 3;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
[InlineArray(size)]
public struct Array4<T> {
    public const int size = 4;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
[InlineArray(size)]
public struct Array5<T> {
    public const int size = 5;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
[InlineArray(size)]
public struct Array6<T> {
    public const int size = 6;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
[InlineArray(size)]
public struct Array7<T> {
    public const int size = 7;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
[InlineArray(size)]
public struct Array8<T> {
    public const int size = 8;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
[InlineArray(size)]
public struct Array9<T> {
    public const int size = 9;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
[InlineArray(size)]
public struct Array10<T> {
    public const int size = 10;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
[InlineArray(size)]
public struct Array11<T> {
    public const int size = 11;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
[InlineArray(size)]
public struct Array12<T> {
    public const int size = 12;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
[InlineArray(size)]
public struct Array13<T> {
    public const int size = 13;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
//ChaptGPT mvp
// Array14
[InlineArray(size)]
public struct Array14<T> {
    public const int size = 14;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array15
[InlineArray(size)]
public struct Array15<T> {
    public const int size = 15;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array16
[InlineArray(size)]
public struct Array16<T> {
    public const int size = 16;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array17
[InlineArray(size)]
public struct Array17<T> {
    public const int size = 17;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array18
[InlineArray(size)]
public struct Array18<T> {
    public const int size = 18;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array19
[InlineArray(size)]
public struct Array19<T> {
    public const int size = 19;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array20
[InlineArray(size)]
public struct Array20<T> {
    public const int size = 20;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array21
[InlineArray(size)]
public struct Array21<T> {
    public const int size = 21;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array22
[InlineArray(size)]
public struct Array22<T> {
    public const int size = 22;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array23
[InlineArray(size)]
public struct Array23<T> {
    public const int size = 23;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array24
[InlineArray(size)]
public struct Array24<T> {
    public const int size = 24;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array25
[InlineArray(size)]
public struct Array25<T> {
    public const int size = 25;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array26
[InlineArray(size)]
public struct Array26<T> {
    public const int size = 26;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array27
[InlineArray(size)]
public struct Array27<T> {
    public const int size = 27;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array28
[InlineArray(size)]
public struct Array28<T> {
    public const int size = 28;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array29
[InlineArray(size)]
public struct Array29<T> {
    public const int size = 29;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array30
[InlineArray(size)]
public struct Array30<T> {
    public const int size = 30;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array31
[InlineArray(size)]
public struct Array31<T> {
    public const int size = 31;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array32
[InlineArray(size)]
public struct Array32<T> {
    public const int size = 32;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array33
[InlineArray(size)]
public struct Array33<T> {
    public const int size = 33;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array34
[InlineArray(size)]
public struct Array34<T> {
    public const int size = 34;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array35
[InlineArray(size)]
public struct Array35<T> {
    public const int size = 35;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array36
[InlineArray(size)]
public struct Array36<T> {
    public const int size = 36;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array37
[InlineArray(size)]
public struct Array37<T> {
    public const int size = 37;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array38
[InlineArray(size)]
public struct Array38<T> {
    public const int size = 38;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array39
[InlineArray(size)]
public struct Array39<T> {
    public const int size = 39;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array40
[InlineArray(size)]
public struct Array40<T> {
    public const int size = 40;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array41
[InlineArray(size)]
public struct Array41<T> {
    public const int size = 41;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array42
[InlineArray(size)]
public struct Array42<T> {
    public const int size = 42;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array43
[InlineArray(size)]
public struct Array43<T> {
    public const int size = 43;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array44
[InlineArray(size)]
public struct Array44<T> {
    public const int size = 44;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array45
[InlineArray(size)]
public struct Array45<T> {
    public const int size = 45;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array46
[InlineArray(size)]
public struct Array46<T> {
    public const int size = 46;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array47
[InlineArray(size)]
public struct Array47<T> {
    public const int size = 47;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array48
[InlineArray(size)]
public struct Array48<T> {
    public const int size = 48;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array49
[InlineArray(size)]
public struct Array49<T> {
    public const int size = 49;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array50
[InlineArray(size)]
public struct Array50<T> {
    public const int size = 50;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array51
[InlineArray(size)]
public struct Array51<T> {
    public const int size = 51;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array52
[InlineArray(size)]
public struct Array52<T> {
    public const int size = 52;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array53
[InlineArray(size)]
public struct Array53<T> {
    public const int size = 53;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array54
[InlineArray(size)]
public struct Array54<T> {
    public const int size = 54;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array55
[InlineArray(size)]
public struct Array55<T> {
    public const int size = 55;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array56
[InlineArray(size)]
public struct Array56<T> {
    public const int size = 56;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array57
[InlineArray(size)]
public struct Array57<T> {
    public const int size = 57;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array58
[InlineArray(size)]
public struct Array58<T> {
    public const int size = 58;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array59
[InlineArray(size)]
public struct Array59<T> {
    public const int size = 59;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array60
[InlineArray(size)]
public struct Array60<T> {
    public const int size = 60;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array61
[InlineArray(size)]
public struct Array61<T> {
    public const int size = 61;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array62
[InlineArray(size)]
public struct Array62<T> {
    public const int size = 62;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array63
[InlineArray(size)]
public struct Array63<T> {
    public const int size = 63;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array64
[InlineArray(size)]
public struct Array64<T> {
    public const int size = 64;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array65
[InlineArray(size)]
public struct Array65<T> {
    public const int size = 65;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array66
[InlineArray(size)]
public struct Array66<T> {
    public const int size = 66;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array67
[InlineArray(size)]
public struct Array67<T> {
    public const int size = 67;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array68
[InlineArray(size)]
public struct Array68<T> {
    public const int size = 68;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array69
[InlineArray(size)]
public struct Array69<T> {
    public const int size = 69;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array70
[InlineArray(size)]
public struct Array70<T> {
    public const int size = 70;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array71
[InlineArray(size)]
public struct Array71<T> {
    public const int size = 71;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array72
[InlineArray(size)]
public struct Array72<T> {
    public const int size = 72;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array73
[InlineArray(size)]
public struct Array73<T> {
    public const int size = 73;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array74
[InlineArray(size)]
public struct Array74<T> {
    public const int size = 74;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array75
[InlineArray(size)]
public struct Array75<T> {
    public const int size = 75;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array76
[InlineArray(size)]
public struct Array76<T> {
    public const int size = 76;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array77
[InlineArray(size)]
public struct Array77<T> {
    public const int size = 77;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array78
[InlineArray(size)]
public struct Array78<T> {
    public const int size = 78;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array79
[InlineArray(size)]
public struct Array79<T> {
    public const int size = 79;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array80
[InlineArray(size)]
public struct Array80<T> {
    public const int size = 80;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array81
[InlineArray(size)]
public struct Array81<T> {
    public const int size = 81;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array82
[InlineArray(size)]
public struct Array82<T> {
    public const int size = 82;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array83
[InlineArray(size)]
public struct Array83<T> {
    public const int size = 83;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array84
[InlineArray(size)]
public struct Array84<T> {
    public const int size = 84;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array85
[InlineArray(size)]
public struct Array85<T> {
    public const int size = 85;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array86
[InlineArray(size)]
public struct Array86<T> {
    public const int size = 86;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array87
[InlineArray(size)]
public struct Array87<T> {
    public const int size = 87;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array88
[InlineArray(size)]
public struct Array88<T> {
    public const int size = 88;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array89
[InlineArray(size)]
public struct Array89<T> {
    public const int size = 89;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array90
[InlineArray(size)]
public struct Array90<T> {
    public const int size = 90;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array91
[InlineArray(size)]
public struct Array91<T> {
    public const int size = 91;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array92
[InlineArray(size)]
public struct Array92<T> {
    public const int size = 92;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array93
[InlineArray(size)]
public struct Array93<T> {
    public const int size = 93;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array94
[InlineArray(size)]
public struct Array94<T> {
    public const int size = 94;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array95
[InlineArray(size)]
public struct Array95<T> {
    public const int size = 95;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array96
[InlineArray(size)]
public struct Array96<T> {
    public const int size = 96;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array97
[InlineArray(size)]
public struct Array97<T> {
    public const int size = 97;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array98
[InlineArray(size)]
public struct Array98<T> {
    public const int size = 98;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array99
[InlineArray(size)]
public struct Array99<T> {
    public const int size = 99;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array100
[InlineArray(size)]
public struct Array100<T> {
    public const int size = 100;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array101
[InlineArray(size)]
public struct Array101<T> {
    public const int size = 101;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array102
[InlineArray(size)]
public struct Array102<T> {
    public const int size = 102;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array103
[InlineArray(size)]
public struct Array103<T> {
    public const int size = 103;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array104
[InlineArray(size)]
public struct Array104<T> {
    public const int size = 104;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array105
[InlineArray(size)]
public struct Array105<T> {
    public const int size = 105;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array106
[InlineArray(size)]
public struct Array106<T> {
    public const int size = 106;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array107
[InlineArray(size)]
public struct Array107<T> {
    public const int size = 107;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array108
[InlineArray(size)]
public struct Array108<T> {
    public const int size = 108;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array109
[InlineArray(size)]
public struct Array109<T> {
    public const int size = 109;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array110
[InlineArray(size)]
public struct Array110<T> {
    public const int size = 110;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array111
[InlineArray(size)]
public struct Array111<T> {
    public const int size = 111;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array112
[InlineArray(size)]
public struct Array112<T> {
    public const int size = 112;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array113
[InlineArray(size)]
public struct Array113<T> {
    public const int size = 113;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array114
[InlineArray(size)]
public struct Array114<T> {
    public const int size = 114;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array115
[InlineArray(size)]
public struct Array115<T> {
    public const int size = 115;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array116
[InlineArray(size)]
public struct Array116<T> {
    public const int size = 116;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array117
[InlineArray(size)]
public struct Array117<T> {
    public const int size = 117;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array118
[InlineArray(size)]
public struct Array118<T> {
    public const int size = 118;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array119
[InlineArray(size)]
public struct Array119<T> {
    public const int size = 119;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array120
[InlineArray(size)]
public struct Array120<T> {
    public const int size = 120;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array121
[InlineArray(size)]
public struct Array121<T> {
    public const int size = 121;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array122
[InlineArray(size)]
public struct Array122<T> {
    public const int size = 122;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array123
[InlineArray(size)]
public struct Array123<T> {
    public const int size = 123;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array124
[InlineArray(size)]
public struct Array124<T> {
    public const int size = 124;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array125
[InlineArray(size)]
public struct Array125<T> {
    public const int size = 125;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array126
[InlineArray(size)]
public struct Array126<T> {
    public const int size = 126;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array127
[InlineArray(size)]
public struct Array127<T> {
    public const int size = 127;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}

// Array128
[InlineArray(size)]
public struct Array128<T> {
    public const int size = 128;
    public int Length => size;
    public T data;
    public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref data, size);
    public ReadOnlySpan<T> AsReadOnlySpan() => MemoryMarshal.CreateReadOnlySpan(in data, size);
}
