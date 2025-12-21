namespace Precursor.Operators {

using static MethodImplOptions;

namespace Comparable {
public static class ComparableOperators {
   extension<T>(T) where T : IComparable<T> {
      [MethodImpl(AggressiveInlining)]
      public static bool operator >(T a, T b) => a.CompareTo(b) > 0;

      [MethodImpl(AggressiveInlining)]
      public static bool operator >=(T a, T b) => a.CompareTo(b) >= 0;

      [MethodImpl(AggressiveInlining)]
      public static bool operator <(T a, T b) => a.CompareTo(b) < 0;

      [MethodImpl(AggressiveInlining)]
      public static bool operator <=(T a, T b) => a.CompareTo(b) <= 0;
   }
}
} // namespace Comparable
namespace Equatable {
public static class EquatableOperators {
   extension<T>(T) where T : IEquatable<T> {
      [MethodImpl(AggressiveInlining)]
      public static bool operator ==(T a, T b) => a.Equals(b);

      [MethodImpl(AggressiveInlining)]
      public static bool operator !=(T a, T b) => !a.Equals(b);
   }
}
} // namespace Equatable
} // namespace Precursor.Operators
