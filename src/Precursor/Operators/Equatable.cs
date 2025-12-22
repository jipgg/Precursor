namespace Precursor.Operators.Equatable;

public static class EquatableOperators {
   extension<T>(T) where T : IEquatable<T>, allows ref struct {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator ==(T a, T b) => a.Equals(b);

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator !=(T a, T b) => !a.Equals(b);
   }
   extension<T, U>(T) where T : IEquatable<U>, allows ref struct {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator ==(T a, U b) => a.Equals(b);

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static bool operator !=(T a, U b) => !a.Equals(b);
   }
}
