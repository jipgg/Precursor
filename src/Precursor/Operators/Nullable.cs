namespace Precursor.Operators.Nullable;

public static class NullableOperators {
   extension<T>(T?) where T : struct {
      public static bool operator true(T? v) => v.HasValue;
      public static bool operator false(T? v) => !v.HasValue;
      public static bool operator !(T? v) => !v.HasValue;
   }
   extension<T>(T?) where T : class {
      public static bool operator true(T? v) => v is not null;
      public static bool operator false(T? v) => v is null;
      public static bool operator !(T? v) => v is null;
   }
}
