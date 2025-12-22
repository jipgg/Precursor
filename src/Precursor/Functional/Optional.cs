namespace Precursor.Functional;

public sealed class InvalidOptionalAccessException : InvalidOperationException;

public readonly struct Optional<T> :
ITruthiness<Optional<T>>,
ICastableTo<Optional<T>, T>,
IImplicitlyCastableFrom<Optional<T>, T> {
   public readonly T? Value;
   [MemberNotNullWhen(true, nameof(Value))]
   public bool HasValue { get; }
   public Optional() {
      Value = default!;
      HasValue = false;
   }
   public Optional(in T value) {
      Value = value;
      HasValue = true;
   }
   public static implicit operator Optional<T>(in T v) => new(v);
   public bool TryValue([NotNullWhen(true)] out T? value) {
      if (HasValue) {
         value = Value!;
         return true;
      }
      value = default;
      return false;
   }
   public Optional<X> Map<X>(Func<T, X> f)
       => HasValue ? new(f(Value)) : default;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public Optional<X> Map<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<T, X>, allows ref struct
       => HasValue ? new(f.Invoke(Value)) : default;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public Optional<X> Map<Invocable, X>()
   where Invocable : IInvocable<T, X>, allows ref struct
       => HasValue ? new(Invocable.Invoke(Value)) : default;

   public Optional<T> AndThen(Func<T, Optional<T>> f)
       => HasValue ? f(Value) : this;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public Optional<T> AndThen<Invoker>(in Invoker f)
   where Invoker : IInvoker<T, Optional<T>>, allows ref struct
       => HasValue ? f.Invoke(Value) : this;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public Optional<T> AndThen<Invocable>()
   where Invocable : IInvocable<T, Optional<T>>, allows ref struct
       => HasValue ? Invocable.Invoke(Value) : this;

   public Optional<X> AndThen<X>(Func<T, Optional<X>> f)
       => HasValue ? f(Value) : default;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public Optional<X> AndThen<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<T, Optional<X>>, allows ref struct
       => HasValue ? f.Invoke(Value) : default;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public Optional<X> AndThen<Invocable, X>()
   where Invocable : IInvocable<T, Optional<X>>, allows ref struct
       => HasValue ? Invocable.Invoke(Value) : default;

   public static bool operator true(in Optional<T> o) => o.HasValue;
   public static bool operator false(in Optional<T> o) => !o.HasValue;
   public static bool operator !(in Optional<T> o) => !o.HasValue;

   public static explicit operator T(in Optional<T> n)
      => n.HasValue ? n.Value! : throw new InvalidOptionalAccessException();
}

public readonly ref struct RefOptional<T>:
ITruthiness<RefOptional<T>>,
ICastableTo<RefOptional<T>, T>,
IImplicitlyCastableFrom<RefOptional<T>, T>
where T : allows ref struct {
   public readonly T? Value { get; }
   [MemberNotNullWhen(true, nameof(Value))]
   public bool HasValue { get; }
   public RefOptional() {
      Value = default!;
      HasValue = false;
   }
   public RefOptional(scoped in T value) {
      Value = value;
      HasValue = true;
   }
   public static implicit operator RefOptional<T>(scoped in T v) => new(v);
   public bool TryValue([NotNullWhen(true)] out T? value) {
      if (HasValue) {
         value = Value!;
         return true;
      }
      value = default;
      return false;
   }
   public RefOptional<X> Map<X>(Func<T, X> f)
   where X : allows ref struct
       => HasValue ? new(f(Value)) : default;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public RefOptional<X> Map<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<T, X>, allows ref struct
   where X : allows ref struct
       => HasValue ? new(f.Invoke(Value)) : default;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public RefOptional<X> Map<Invocable, X>()
   where Invocable : IInvocable<T, X>, allows ref struct
   where X : allows ref struct
       => HasValue ? new(Invocable.Invoke(Value)) : default;

   public RefOptional<T> AndThen(Func<T, RefOptional<T>> f)
       => HasValue ? f(Value) : this;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public RefOptional<T> AndThen<Invoker>(in Invoker f)
   where Invoker : IInvoker<T, RefOptional<T>>, allows ref struct
       => HasValue ? f.Invoke(Value) : this;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public RefOptional<T> AndThen<Invocable>()
   where Invocable : IInvocable<T, RefOptional<T>>, allows ref struct
       => HasValue ? Invocable.Invoke(Value) : this;

   public RefOptional<X> AndThen<X>(Func<T, RefOptional<X>> f)
   where X : allows ref struct
       => HasValue ? f(Value) : default;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public RefOptional<X> AndThen<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<T, RefOptional<X>>, allows ref struct
   where X : allows ref struct
       => HasValue ? f.Invoke(Value) : default;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public RefOptional<X> AndThen<Invocable, X>()
   where Invocable : IInvocable<T, RefOptional<X>>, allows ref struct
   where X : allows ref struct
       => HasValue ? Invocable.Invoke(Value) : default;

   public static bool operator true(in RefOptional<T> o) => o.HasValue;
   public static bool operator false(in RefOptional<T> o) => !o.HasValue;
   public static bool operator !(in RefOptional<T> o) => !o.HasValue;

   public static explicit operator T(scoped in RefOptional<T> o)
      => o.HasValue ? o.Value! : throw new InvalidOptionalAccessException();
}

public static class OptionalExtensions {
   extension<T>(in RefOptional<T> o) {
      public Optional<T> AsOptional() => o.HasValue ? new(o.Value) : default;
      public RefExpected<T, Nil> AsRefExpected() => o.HasValue ? o.Value : new Unexpected<Nil>(default);
   }
   extension<T>(in Optional<T> o) {
      public RefOptional<T> AsRefOptional() => o.HasValue ? new(o.Value) : default;
      public Expected<T, Nil> AsExpected() => o.HasValue ? o.Value : new Unexpected<Nil>(default);
   }
}

public static class OptionalStructExtensions {
   extension<T>(in Optional<T> n) where T : struct {
      public T? AsNullable() => n.HasValue ? n.Value : null;
   }
   extension<T>(in RefOptional<T> o) where T : struct {
      public T? AsNullable() => o.HasValue ? o.Value : null;
   }
}
public static class OptionalClassExtensions {
   extension<T>(in Optional<T> n) where T : class {
      public T? AsNullable() => n.HasValue ? n.Value : null;
   }
   extension<T>(in RefOptional<T> o) where T : class {
      public T? AsNullable() => o.HasValue ? o.Value : null;
   }
}
