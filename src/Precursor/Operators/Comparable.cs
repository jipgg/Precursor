namespace Precursor.Operators.Comparable;

public static class ComparableOperators {
   extension<T>(T) where T : IComparable<T>, allows ref struct {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator >(T a, T b) => a.CompareTo(b) > 0;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator >=(T a, T b) => a.CompareTo(b) >= 0;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator <(T a, T b) => a.CompareTo(b) < 0;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator <=(T a, T b) => a.CompareTo(b) <= 0;
   }
   extension<T, U>(T) where T : IComparable<U>, allows ref struct {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator >(T a, U b) => a.CompareTo(b) > 0;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator >=(T a, U b) => a.CompareTo(b) >= 0;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator <(T a, U b) => a.CompareTo(b) < 0;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator <=(T a, U b) => a.CompareTo(b) <= 0;
   }
}
