namespace Fast;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Local;

public unsafe struct NativeAllocator<T>: IAllocator<T> where T: unmanaged {
    public T* Allocate(nuint count) => (T*)NativeMemory.Alloc(ByteCount<T>(count));
    public T* Reallocate(T* oldPtr, nuint count) => (T*)NativeMemory.Realloc(oldPtr, ByteCount<T>(count));
    public void Free(T* ptr) => NativeMemory.Free(ptr);
}
public unsafe struct AlignedNativeAllocator<T>(nuint Alignment = 32): IAllocator<T> where T: unmanaged {
    public T* Allocate(nuint count) => (T*)NativeMemory.AlignedAlloc(ByteCount<T>(count), Alignment);
    public T* Reallocate(T* oldPtr, nuint count) => (T*)NativeMemory.AlignedRealloc(oldPtr, ByteCount<T>(count), Alignment);
    public void Free(T* ptr) => NativeMemory.AlignedFree(ptr);
}
public unsafe struct MarshalAllocator<T>(): IAllocator<T> where T: unmanaged {
    public T* Allocate(nuint count) => (T*)Marshal.AllocHGlobal((int)ByteCount<T>(count));
    public T* Reallocate(T* oldPtr, nuint count) => (T*)Marshal.ReAllocHGlobal((nint)oldPtr, (nint)ByteCount<T>(count));
    public void Free(T* ptr) => Marshal.FreeHGlobal((nint)ptr);
}

static file class Local {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static public nuint ByteCount<T>(nuint count) where T: unmanaged => (nuint)Marshal.SizeOf<T>() * count;
}
