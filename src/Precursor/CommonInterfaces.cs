namespace Precursor;

public interface ITruthiness<Self>
where Self: ITruthiness<Self>, allows ref struct {
   static abstract bool operator true(scoped in Self v);
   static abstract bool operator false(scoped in Self v);
   static virtual bool operator !(scoped in Self v) => v ? false : true;
}
public interface ICastableTo<Self, out T>
where Self : ICastableTo<Self, T>, allows ref struct
where T : allows ref struct {
   static abstract explicit operator T(scoped in Self s);
}
public interface IImplicitlyCastableTo<Self, out T>
where Self : IImplicitlyCastableTo<Self, T>, allows ref struct
where T : allows ref struct {
   static abstract implicit operator T(scoped in Self s);
}
public interface ICastableFrom<out Self, T>
where Self : ICastableFrom<Self, T>, allows ref struct
where T : allows ref struct {
   static abstract explicit operator Self(scoped in T s);
}
public interface IImplicitlyCastableFrom<out Self, T>
where Self : IImplicitlyCastableFrom<Self, T>, allows ref struct
where T: allows ref struct {
   static abstract implicit operator Self(scoped in T s);
}
