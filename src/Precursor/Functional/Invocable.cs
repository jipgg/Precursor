namespace Precursor.Functional;

public interface IInvocable<in T, out R>
where T : allows ref struct
where R : allows ref struct {
   static abstract R Invoke(T v);
}
public interface IInvocable<in T0, in T1, out R>
where T0 : allows ref struct
where T1 : allows ref struct
where R : allows ref struct {
   static abstract R Invoke(T0 v0, T1 v1);
}
public interface IInvocable<in T0, in T1, in T2, out R>
where T0 : allows ref struct
where T1 : allows ref struct
where T2 : allows ref struct
where R : allows ref struct {
   static abstract R Invoke(T0 v0, T1 v1, T2 v2);
}
public interface IInvocable<in T0, in T1, in T2, in T3, out R>
where T0 : allows ref struct
where T1 : allows ref struct
where T2 : allows ref struct
where T3 : allows ref struct
where R : allows ref struct {
   static abstract R Invoke(T0 v0, T1 v1, T2 v2, T3 v3);
}
public interface IInvocable<in T0, in T1, in T2, in T3, in T4, out R>
where T0 : allows ref struct
where T1 : allows ref struct
where T2 : allows ref struct
where T3 : allows ref struct
where T4 : allows ref struct
where R : allows ref struct {
   static abstract R Invoke(T0 v0, T1 v1, T2 v2, T3 v3, T4 v4);
}
public interface IInvocable<in T0, in T1, in T2, in T3, in T4, in T5, out R>
where T0 : allows ref struct
where T1 : allows ref struct
where T2 : allows ref struct
where T3 : allows ref struct
where T4 : allows ref struct
where T5 : allows ref struct
where R : allows ref struct {
   static abstract R Invoke(T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5);
}
public interface IInvocable<in T0, in T1, in T2, in T3, in T4, in T5, in T6, out R>
where T0 : allows ref struct
where T1 : allows ref struct
where T2 : allows ref struct
where T3 : allows ref struct
where T4 : allows ref struct
where T5 : allows ref struct
where T6 : allows ref struct
where R : allows ref struct {
   static abstract R Invoke(T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6);
}
public interface IInvocable<in T0, in T1, in T2, in T3, in T4, in T5, in T6, in T7, out R>
where T0 : allows ref struct
where T1 : allows ref struct
where T2 : allows ref struct
where T3 : allows ref struct
where T4 : allows ref struct
where T5 : allows ref struct
where T6 : allows ref struct
where R : allows ref struct {
   static abstract R Invoke(T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7);
}
public interface IInvocable<in T0, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, out R>
where T0 : allows ref struct
where T1 : allows ref struct
where T2 : allows ref struct
where T3 : allows ref struct
where T4 : allows ref struct
where T5 : allows ref struct
where T6 : allows ref struct
where R : allows ref struct {
   static abstract R Invoke(T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8);
}
public interface IInvocable<in T0, in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, out R>
where T0 : allows ref struct
where T1 : allows ref struct
where T2 : allows ref struct
where T3 : allows ref struct
where T4 : allows ref struct
where T5 : allows ref struct
where T6 : allows ref struct
where R : allows ref struct {
   static abstract R Invoke(T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9);
}
