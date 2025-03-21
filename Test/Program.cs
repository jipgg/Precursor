using Fast;

Span<int> a = stackalloc int[] {1, 2, 3, 4, 5};

var myArray = new Array2<double>();
Console.WriteLine(myArray[1]);
var myvec = new VectorList<double>(10, 0);
using var myve = new VectorList<double>(myArray);
Console.WriteLine($"SIZE {myve.Size}, {myve.Capacity} | {myArray.Length}");


myvec.AddRange(stackalloc double[]{1, 2, 3});
myvec.Reserve(10000000);
Console.WriteLine($"CAPACITY IS {myvec.Capacity} SIZE IS {myvec.Size}");
myvec.ShrinkToFit();
myvec.AddRange(myArray);
Console.WriteLine($"CAPACITY IS {myvec.Capacity}");
foreach (ref var val in myvec) {
    Console.WriteLine($"val is {val}");
}
