using System.Numerics;
namespace Precursor.Functional;

using static MethodImplOptions;

public sealed class InvalidExpectedAccessException : InvalidOperationException;

public static class UnexpectedFunction {
   [MethodImpl(AggressiveInlining)]
   public static Unexpected<E> Unexpected<E>(scoped in E error) => new(error);
}

public readonly ref struct Unexpected<E>
where E : allows ref struct {
   public E Error { get; }

   [MethodImpl(AggressiveInlining)]
   public Unexpected(scoped in E error) => Error = error;
   [MethodImpl(AggressiveInlining)]
   public Unexpected(E error) => Error = error;
}

public readonly struct Expected<T, E> :
ITruthiness<Expected<T, E>>,
ICastableTo<Expected<T, E>, T>,
IImplicitlyCastableFrom<Expected<T, E>, T> {
   [MemberNotNullWhen(true, nameof(Value))]
   [MemberNotNullWhen(false, nameof(Error))]
   public bool HasValue {
      [MethodImpl(AggressiveInlining)]
      get => field;
   }
   [MemberNotNullWhen(false, nameof(Value))]
   [MemberNotNullWhen(true, nameof(Error))]
   public bool HasError {
      [MethodImpl(AggressiveInlining)]
      get => !HasValue;
   }

   public T? Value { get; }
   public E? Error { get; }

   [MethodImpl(AggressiveInlining)]
   [OverloadResolutionPriority(1)]
   public Expected(in T value) {
      HasValue = true;
      Error = default;
      Value = value;
   }
   [MethodImpl(AggressiveInlining)]
   public Expected(in Unexpected<E> u) {
      HasValue = false;
      Value = default;
      Error = u.Error;
   }

   public Expected<X, E> Map<X>(Func<T, X> f)
       => HasValue ? f(Value) : new Unexpected<E>(Error);

   [MethodImpl(AggressiveInlining)]
   public Expected<X, E> Map<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<T, X>, allows ref struct
       => HasValue ? f.Invoke(Value) : new Unexpected<E>(Error);

   [MethodImpl(AggressiveInlining)]
   public Expected<X, E> Map<Invocable, X>()
   where Invocable : IInvocable<T, X>, allows ref struct
       => HasValue ? Invocable.Invoke(Value) : new Unexpected<E>(Error);

   public Expected<T, X> MapError<X>(Func<E, X> f)
       => HasError ? new Unexpected<X>(f(Error)) : Value;

   [MethodImpl(AggressiveInlining)]
   public Expected<T, X> MapError<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<E, X>, allows ref struct
       => HasValue ? Value : new Unexpected<X>(f.Invoke(Error));

   [MethodImpl(AggressiveInlining)]
   public Expected<T, X> MapError<Invocable, X>()
   where Invocable : IInvocable<E, X>, allows ref struct
       => HasValue ? Value : new Unexpected<X>(Invocable.Invoke(Error));

   public Expected<T, E> AndThen(Func<T, Expected<T, E>> f)
       => HasValue ? f(Value) : this;

   [MethodImpl(AggressiveInlining)]
   public Expected<T, E> AndThen<Invoker>(in Invoker f)
   where Invoker : IInvoker<T, Expected<T, E>>, allows ref struct
       => HasValue ? f.Invoke(Value) : this;

   [MethodImpl(AggressiveInlining)]
   public Expected<T, E> AndThen<Invocable>()
   where Invocable : IInvocable<T, Expected<T, E>>, allows ref struct
       => HasValue ? Invocable.Invoke(Value) : this;

   public Expected<X, E> AndThen<X>(Func<T, Expected<X, E>> f)
       => HasValue ? f(Value) : new Unexpected<E>(Error);

   [MethodImpl(AggressiveInlining)]
   public Expected<X, E> AndThen<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<T, Expected<X, E>>, allows ref struct
       => HasValue ? f.Invoke(Value) : new Unexpected<E>(Error);

   [MethodImpl(AggressiveInlining)]
   public Expected<X, E> AndThen<Invocable, X>()
   where Invocable : IInvocable<T, Expected<X, E>>, allows ref struct
       => HasValue ? Invocable.Invoke(Value) : new Unexpected<E>(Error);

   public Expected<T, E> OrElse(Func<E, Expected<T, E>> f)
       => HasError ? f(Error) : this;

   [MethodImpl(AggressiveInlining)]
   public Expected<T, E> OrElse<Invoker>(in Invoker f)
   where Invoker : IInvoker<E, Expected<T, E>>, allows ref struct
       => HasError ? f.Invoke(Error) : this;

   [MethodImpl(AggressiveInlining)]
   public Expected<T, E> OrElse<Invocable>()
   where Invocable : IInvocable<E, Expected<T, E>>, allows ref struct
       => HasError ? Invocable.Invoke(Error) : this;

   public Expected<T, X> OrElse<X>(Func<E, Expected<T, X>> f)
       => HasError ? f(Error) : Value;

   [MethodImpl(AggressiveInlining)]
   public Expected<T, X> OrElse<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<E, Expected<T, X>>, allows ref struct
       => HasError ? f.Invoke(Error) : Value;

   [MethodImpl(AggressiveInlining)]
   public Expected<T, X> OrElse<Invocable, X>()
   where Invocable : IInvocable<E, Expected<T, X>>, allows ref struct
       => HasError ? Invocable.Invoke(Error) : Value;

   [MethodImpl(AggressiveInlining)]
   public static implicit operator Expected<T, E>(in T v) => new(v);

   [MethodImpl(AggressiveInlining)]
   public static implicit operator Expected<T, E>(in Unexpected<E> u) => new(u);

   [MethodImpl(AggressiveInlining)]
   public static bool operator true(in Expected<T, E> r) => r.HasValue;

   [MethodImpl(AggressiveInlining)]
   public static bool operator false(in Expected<T, E> r) => r.HasError;

   [MethodImpl(AggressiveInlining)]
   public static bool operator !(in Expected<T, E> r) => r.HasError;

   public static explicit operator T(in Expected<T, E> e) => e.HasValue ? e.Value : throw new InvalidExpectedAccessException();
}
public readonly ref struct RefExpected<T, E> :
ICastableTo<RefExpected<T, E>, T>,
IImplicitlyCastableFrom<RefExpected<T, E>, T>,
ITruthiness<RefExpected<T, E>>
where T : allows ref struct
where E : allows ref struct {
   public readonly T? Value { get; }
   public readonly E? Error { get; }

   [MemberNotNullWhen(true, nameof(Value))]
   [MemberNotNullWhen(false, nameof(Error))]
   public bool HasValue { get; }

   [MemberNotNullWhen(false, nameof(Value))]
   [MemberNotNullWhen(true, nameof(Error))]
   public bool HasError {
      [MethodImpl(AggressiveInlining)]
      get => !HasValue;
   }

   [MethodImpl(AggressiveInlining)]
   [OverloadResolutionPriority(1)]
   public RefExpected(scoped in T value) {
      HasValue = true;
      Error = default;
      Value = value;
   }
   [MethodImpl(AggressiveInlining)]
   public RefExpected(scoped in Unexpected<E> u) {
      HasValue = false;
      Value = default;
      Error = u.Error;
   }
   public RefExpected<X, E> Map<X>(Func<T, X> f)
   where X : allows ref struct
       => HasValue ? f(Value) : new Unexpected<E>(Error);

   [MethodImpl(AggressiveInlining)]
   public RefExpected<X, E> Map<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<T, X>, allows ref struct
   where X : allows ref struct
       => HasValue ? f.Invoke(Value) : new Unexpected<E>(Error);

   [MethodImpl(AggressiveInlining)]
   public RefExpected<X, E> Map<Invocable, X>()
   where Invocable : IInvocable<T, X>, allows ref struct
   where X : allows ref struct
       => HasValue ? Invocable.Invoke(Value) : new Unexpected<E>(Error);

   public RefExpected<T, X> MapError<X>(Func<E, X> f)
   where X : allows ref struct
       => HasError ? new Unexpected<X>(f(Error)) : Value;

   [MethodImpl(AggressiveInlining)]
   public RefExpected<T, X> MapError<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<E, X>, allows ref struct
   where X : allows ref struct
       => HasValue ? Value : new Unexpected<X>(f.Invoke(Error));

   [MethodImpl(AggressiveInlining)]
   public RefExpected<T, X> MapError<Invocable, X>()
   where Invocable : IInvocable<E, X>, allows ref struct
   where X : allows ref struct
       => HasValue ? Value : new Unexpected<X>(Invocable.Invoke(Error));

   public RefExpected<T, E> AndThen(Func<T, RefExpected<T, E>> f)
       => HasValue ? f(Value) : this;
   [MethodImpl(AggressiveInlining)]
   public RefExpected<T, E> AndThen<Invoker>(Invoker f)
   where Invoker : IInvoker<T, RefExpected<T, E>>
       => HasValue ? f.Invoke(Value) : this;
   [MethodImpl(AggressiveInlining)]
   public RefExpected<T, E> AndThen<Invocable>()
   where Invocable : IInvocable<T, RefExpected<T, E>>
       => HasValue ? Invocable.Invoke(Value) : this;

   public RefExpected<X, E> AndThen<X>(Func<T, RefExpected<X, E>> f)
       => HasValue ? f(Value) : new Unexpected<E>(Error);

   [MethodImpl(AggressiveInlining)]
   public RefExpected<X, E> AndThen<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<T, RefExpected<X, E>>, allows ref struct
   where X : allows ref struct
       => HasValue ? f.Invoke(Value) : new Unexpected<E>(Error);

   [MethodImpl(AggressiveInlining)]
   public RefExpected<X, E> AndThen<Invocable, X>()
   where Invocable : IInvocable<T, RefExpected<X, E>>, allows ref struct
   where X : allows ref struct
       => HasValue ? Invocable.Invoke(Value) : new Unexpected<E>(Error);

   public RefExpected<T, E> OrElse(Func<E, RefExpected<T, E>> f)
       => HasError ? f(Error) : this;

   [MethodImpl(AggressiveInlining)]
   public RefExpected<T, E> OrElse<Invoker>(in Invoker f)
   where Invoker : IInvoker<E, RefExpected<T, E>>, allows ref struct
       => HasError ? f.Invoke(Error) : this;

   [MethodImpl(AggressiveInlining)]
   public RefExpected<T, E> OrElse<Invocable>()
   where Invocable : IInvocable<E, RefExpected<T, E>>, allows ref struct
       => HasError ? Invocable.Invoke(Error) : this;

   public RefExpected<T, X> OrElse<X>(Func<E, RefExpected<T, X>> f)
   where X : allows ref struct
       => HasError ? f(Error) : Value;

   [MethodImpl(AggressiveInlining)]
   public RefExpected<T, X> OrElse<Invoker, X>(in Invoker f)
   where Invoker : IInvoker<E, RefExpected<T, X>>, allows ref struct
   where X : allows ref struct
       => HasError ? f.Invoke(Error) : Value;

   [MethodImpl(AggressiveInlining)]
   public RefExpected<T, X> OrElse<Invocable, X>()
   where Invocable : IInvocable<E, RefExpected<T, X>>, allows ref struct
   where X : allows ref struct
       => HasError ? Invocable.Invoke(Error) : Value;

   [MethodImpl(AggressiveInlining)]
   public static implicit operator RefExpected<T, E>(scoped in T v) => new(v);

   [MethodImpl(AggressiveInlining)]
   public static implicit operator RefExpected<T, E>(scoped in Unexpected<E> u) => new(u);

   [MethodImpl(AggressiveInlining)]
   public static bool operator true(in RefExpected<T, E> r) => r.HasValue;
   [MethodImpl(AggressiveInlining)]
   public static bool operator false(in RefExpected<T, E> r) => r.HasError;
   [MethodImpl(AggressiveInlining)]
   public static bool operator !(in RefExpected<T, E> r) => r.HasError;

   public static explicit operator T(scoped in RefExpected<T, E> e) => e.HasValue ? e.Value : throw new InvalidExpectedAccessException();
}

public static class ExpectedExtensions {
   extension<V, E>(RefExpected<V, E> e) {
      public Expected<V, E> AsExpected() => e.HasValue ? e.Value : new Unexpected<E>(e.Error);
   }
   extension<V, E>(Expected<V, E> e) {
      public RefExpected<V, E> AsRefExpected() => e.HasValue ? e.Value : new Unexpected<E>(e.Error);
   }
}
