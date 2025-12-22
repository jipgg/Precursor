namespace Precursor.Functional;

public readonly struct Nil: ITruthiness<Nil> {
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator true(in Nil n) => false;
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator false(in Nil n) => true;
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator !(Nil n) => true;

   public static Nil Value {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get => default;
   }
}
