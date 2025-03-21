namespace Fast;
using System;

sealed public class VectorList<T>: IDisposable where T: unmanaged {
    BasicVector<T, NativeAllocator<T>> _vector;

    const float _defaultGrowthFactor = 1.5f;
    public VectorList(nuint capacity = 10, float growthFactor = _defaultGrowthFactor) => _vector = new(capacity, new(), growthFactor);
    public VectorList(ReadOnlySpan<T> span) {
        _vector = new((nuint)span.Length, new(), _defaultGrowthFactor);
        _vector.AddRange(span);
    }

    public PointerEnumerator<T> GetEnumerator() => _vector.GetEnumerator();

    bool _disposed = false;
    public void Dispose() {
        if (_disposed) return;
        _vector.Free();
        _disposed = true;
        GC.SuppressFinalize(this);
    }
    ~VectorList() => Dispose();

    public ref BasicVector<T, NativeAllocator<T>> Dense => ref _vector;
    public ref T this[nuint idx] => ref _vector[idx];  
    public ref T this[int idx] => ref _vector[(nuint)idx];  
    public nuint Size => _vector.Length;
    public nuint Capacity => _vector.Capacity;
    public void CopyTo(Span<T> span) => _vector.CopyTo(span);
    public void Resize(nuint newSize) => _vector.Resize(newSize);
    public void ResizeZeroed(nuint newSize) => _vector.ResizeZeroed(newSize);
    public void Reserve(nuint amount) => _vector.Reserve(amount);
    public void Add(in T v) => _vector.Add(v);
    public void AddRange(ReadOnlySpan<T> span) => _vector.AddRange(span);
    public void AddRange(IEnumerable<T> enumerable) {
        foreach (var e in enumerable) _vector.Add(in e);
    }
    public void Clear() => _vector.Clear();
    public void ShrinkToFit() => _vector.ShrinkToFit();
}
